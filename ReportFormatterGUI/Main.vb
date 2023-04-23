Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class Main
    Private Sub BTNFormat_Click(sender As Object, e As EventArgs) Handles BTNFormat.Click

        If CheckErrors() = False Then
            Exit Sub
        End If

        Dim userID As String = GetUserID(TXT_Username.Text)
        LBL_ID.Text = "ID: " & userID
    End Sub

    Private Function CheckErrors() As Boolean
        If TXT_Username.Text Is Nothing Or TXT_Username.Text = "" Then
            MessageBox.Show("Pleae provide the username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf TXT_Exploit.Text Is Nothing Or TXT_Exploit.Text = "" Then
            MessageBox.Show("Pleae provide the exploit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


    Private Function GetUserID(ByVal username As String) As String
        Const API_URL As String = "https://users.roblox.com/v1/usernames/users"

        ' Prepare the JSON request payload
        Dim jsonPayload As New JObject(
        New JProperty("usernames", New JArray(username)),
        New JProperty("excludeBannedUsers", True)
    )

        ' Send the HTTP request
        Dim webClient As New WebClient()
        webClient.Headers(HttpRequestHeader.ContentType) = "application/json"

        Dim jsonResponseString As String
        Try
            jsonResponseString = webClient.UploadString(API_URL, jsonPayload.ToString())
        Catch ex As WebException
            MessageBox.Show("An error occurred while fetching the user ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try

        ' Parse the JSON response
        Dim jsonResponse As JObject = JObject.Parse(jsonResponseString)

        ' Check if the user was found
        If jsonResponse("data").Count > 0 Then
            ' Return the user ID
            Return jsonResponse("data")(0)("id").ToString()
        Else
            MessageBox.Show("That account was not found. Check the username and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End If
    End Function

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        LBL_Date.Visible = False
        LBL_Date.Text = "Date: "
        LBL_ID.Text = "ID: "
        LBL_Exploit.Text = "Exploit: "
        TXT_Exploit.Text = ""
        TXT_Username.Text = ""
        BoxIncludeDate.Checked = False
    End Sub

    Private Sub BoxIncludeDate_CheckedChanged(sender As Object, e As EventArgs) Handles BoxIncludeDate.CheckedChanged
        If BoxIncludeDate.Checked = True Then
            LBL_Date.Visible = True
            LBL_Date.Text = "Date: " & DateTime.Now.ToString("dd/MM/yyyy")
            LBL_Clip.Location = New Point(LBL_Clip.Location.X, LBL_Clip.Location.Y + 18)
        Else
            LBL_Date.Visible = False
            LBL_Date.Text = "Date: "
            LBL_Clip.Location = New Point(LBL_Clip.Location.X, LBL_Clip.Location.Y - 18)
        End If
    End Sub

    Private Sub TXT_Exploit_TextChanged(sender As Object, e As EventArgs) Handles TXT_Exploit.TextChanged
        LBL_Exploit.Text = "Exploit: " & TXT_Exploit.Text
    End Sub

    Private Sub BTNCopy_Click(sender As Object, e As EventArgs) Handles BTNCopy.Click
        Dim textToCopy As String = LBL_ID.Text & vbNewLine & LBL_Exploit.Text
        If BoxIncludeDate.Checked = True Then
            textToCopy &= vbNewLine & LBL_Date.Text
        End If
        textToCopy &= vbNewLine & LBL_Clip.Text

        ' Set the clipboard text
        Clipboard.SetText(textToCopy)

        ' Show a message to confirm that the text has been copied
        MessageBox.Show("Text copied to clipboard!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_Clip.Location = New Point(LBL_Clip.Location.X, LBL_Clip.Location.Y - 18)
        LBL_Date.Visible = False
    End Sub

End Class
