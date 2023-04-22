Imports System.IO
Imports System.Text.RegularExpressions

Public Class SaveReport
    ReadOnly prevForm As Form
    Private DefaultImage As Image

    Public Sub New(prevForm As Form)
        InitializeComponent()
        Me.prevForm = prevForm

    End Sub

    Private Sub CreateReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
        Me.DefaultImage = PictureBox1.Image
    End Sub

    Private Sub CreateReport_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub CreateReport_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length > 0 Then
            Dim file As String = files(0)
            Dim ext As String = Path.GetExtension(file).ToLower()

            If ext = ".jpg" Or ext = ".jpeg" Or ext = ".png" Or ext = ".bmp" Or ext = ".gif" Then
                DisplayImage(file)
            ElseIf ext = ".mp4" Or ext = ".wmv" Or ext = ".avi" Then
                PlayVideo(file)
            End If
        End If
    End Sub

    Private Sub DisplayImage(filePath As String)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Visible = True
        AxWindowsMediaPlayer1.Visible = False
        PictureBox1.ImageLocation = filePath

    End Sub

    Private Sub PlayVideo(filePath As String)
        PictureBox1.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.URL = filePath
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtUserID.TextChanged
        If Regex.IsMatch(TxtUserID.Text, "[0-9]*") Then
            TxtUserID.Text = Regex.Replace(TxtUserID.Text, "[^0-9]", "")
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.prevForm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        PictureBox1.Image = Nothing
        AxWindowsMediaPlayer1.URL = Nothing
        TxtExploit.Text = ""
        TxtUserID.Text = ""
        PictureBox1.Image = DefaultImage

    End Sub
End Class