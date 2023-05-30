Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class MainApp
    Dim prevUsername As String = ""
    Dim prevID As String = ""
    Dim formatted As Boolean = False
    Dim OffsetY As Integer = 0

    Private Shared Function DisplayError(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return Nothing
    End Function

    Private Sub TxtExploit_TextChanged(sender As Object, e As EventArgs) Handles txtExploit.TextChanged
        lbl_Exploit.Text = "Exploit: " & txtExploit.Text
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        CheckBoxDate.Checked = False
        CheckBoxIDOnly.Checked = False
        CheckBoxUsername.Checked = False
        lbl_Date.Text = "Date:"
        lbl_Exploit.Text = "Exploit:"
        lbl_ID.Text = "ID:"
        txtExploit.Text = ""
        txtUsername.Text = ""
        formatted = False
    End Sub

    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OffsetY = lbl_Clip.Location.Y - lbl_Date.Location.Y
        lbl_Date.Location = New Point(lbl_Date.Location.X, lbl_Exploit.Location.Y + OffsetY)
        lbl_Clip.Location = New Point(lbl_Date.Location.X, lbl_Date.Location.Y)
        lbl_ID.Location = New Point(lbl_ID.Location.X, lbl_ID.Location.Y + OffsetY)

        lbl_Date.Visible = False
        lbl_Username.Visible = False
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If formatted = False Then
            If txtUsername.Text = "" Then
                DisplayError("Please enter a username!")
                Exit Sub
            End If
            Dim userID As String = FetchID(txtUsername.Text)
            If userID <> "" Then
                lbl_ID.Text = "ID: " & userID
                prevUsername = txtUsername.Text
                prevID = userID
                formatted = True
            Else
                Exit Sub
            End If
        End If

        If formatted = True Then
            If CheckBoxIDOnly.Checked = True Then
                Dim userID As String = Regex.Replace(lbl_ID.Text, "[^\d]", "")
                If userID <> "" Then
                    Clipboard.SetText(userID)
                    MessageBox.Show("Copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    DisplayError("Could not retrieve user ID.")
                End If
                Exit Sub
            End If

            If txtExploit.Text = "" Then
                DisplayError("Please enter an exploit!")
                Exit Sub
            End If

            Dim TextToCopy As String = lbl_ID.Text
            If CheckBoxUsername.Checked = True Then
                TextToCopy = TextToCopy & vbCrLf & lbl_Username.Text
            End If
            TextToCopy = TextToCopy & vbCrLf & lbl_Exploit.Text
            If CheckBoxDate.Checked = True Then
                TextToCopy = TextToCopy & vbCrLf & lbl_Date.Text
            End If
            TextToCopy = TextToCopy & vbCrLf & lbl_Clip.Text
            Clipboard.SetText(TextToCopy)
            MessageBox.Show("Copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub CheckBoxDate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDate.CheckedChanged
        If CheckBoxDate.Checked = True Then
            lbl_Date.Visible = True
            lbl_Clip.Location = New Point(lbl_Clip.Location.X, lbl_Clip.Location.Y + OffsetY)
            lbl_Date.Text = "Date: " & DateTime.Now.ToString("dd/MM/yyyy")
        Else
            lbl_Date.Visible = False
            lbl_Clip.Location = New Point(lbl_Clip.Location.X, lbl_Clip.Location.Y - OffsetY)
        End If
    End Sub

    Private Sub CheckBoxUsername_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUsername.CheckedChanged
        If CheckBoxUsername.Checked = True Then
            lbl_Username.Visible = True
            lbl_ID.Location = New Point(lbl_ID.Location.X, lbl_ID.Location.Y - OffsetY)
            lbl_Username.Text = "Username: " & txtUsername.Text
        Else
            lbl_Username.Visible = False
            lbl_ID.Location = New Point(lbl_ID.Location.X, lbl_ID.Location.Y + OffsetY)
        End If
    End Sub


    Private Sub BtnFetchID_Click(sender As Object, e As EventArgs) Handles btnFetchID.Click
        If txtUsername.Text = "" Then
            DisplayError("Please enter a username!")
            Exit Sub
        ElseIf txtUsername.Text = prevUsername Then
            formatted = True
            lbl_ID.Text = "ID: " & prevID
        Else
            Dim userID As String = FetchID(txtUsername.Text)
            If userID <> "" Then
                lbl_ID.Text = "ID: " & userID
                formatted = True
                prevUsername = txtUsername.Text
                prevID = userID
            Else
                Exit Sub
            End If
        End If
        lbl_Username.Text = "Username: " & prevUsername
    End Sub

    Private Shared Function FetchID(username As String) As String
        Dim url As String = "https://users.roblox.com/v1/usernames/users"
        Dim excludeBannedUsers As Boolean = True
        Dim usernames As String() = {username}
        Dim data As New With {usernames, excludeBannedUsers}
        Dim jsonContent As New StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
        Try
            Using httpClient As New HttpClient()
                Dim response As HttpResponseMessage = httpClient.PostAsync(url, jsonContent).Result
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = response.Content.ReadAsStringAsync().Result
                    Dim result = JsonConvert.DeserializeObject(jsonResponse)
                    If result("data").Count > 0 Then
                        Dim userId = result("data")(0)("id").ToString()
                        If Not String.IsNullOrEmpty(userId) Then
                            Return userId
                        Else
                            DisplayError("Could not retrieve user ID.")
                            Return ""
                        End If
                    Else
                        DisplayError("No user found.")
                        Return ""
                    End If
                ElseIf response.StatusCode = HttpStatusCode.BadRequest Then
                    DisplayError("Too many usernames.")
                    Return ""
                Else
                    DisplayError(response.StatusCode.ToString())
                    Return ""
                End If
            End Using
        Catch ex As Exception
            DisplayError(ex.Message)
            Return ""
        End Try
    End Function

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text <> prevUsername Then
            formatted = False
        Else
            formatted = True
            lbl_ID.Text = "ID: " & prevID
            lbl_Username.Text = "Username: " & prevUsername
        End If
    End Sub


End Class