Public Class ViewReports

    Dim prevForm As Form

    Public Sub New(prevForm As Form)
        InitializeComponent()
        Me.prevForm = prevForm
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.prevForm.Show()
        Me.Close()
    End Sub
End Class