Imports System.IO

Public Class Report
    ReadOnly userID As String
    ReadOnly exploit As String
    ReadOnly mediaBytes As Byte
    ReadOnly mediaType As String

    Public Sub New(userID As String, exploit As String, mediaBytes As Byte, mediaType As String)
        InitializeComponent()

        Me.userID = userID
        Me.exploit = exploit
        Me.mediaBytes = mediaBytes
        Me.mediaType = mediaType
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = userID
        txtExploit.Text = exploit
        If mediaType = "image" Then
            PictureBox1.Image = Image.FromStream(New MemoryStream(mediaBytes))
        ElseIf mediaType = "video" Then
            AxWindowsMediaPlayer1.URL = mediaBytes
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

    End Sub
End Class