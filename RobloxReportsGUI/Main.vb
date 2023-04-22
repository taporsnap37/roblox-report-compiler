Public Class Main

    Private Sub BtnViewReports_Click(sender As Object, e As EventArgs) Handles BtnViewReports.Click
        Dim ViewReportsForm As New ViewReports(Me)
        ViewReportsForm.Show()

    End Sub

    Private Sub BtnCreateReport_Click(sender As Object, e As EventArgs) Handles BtnCreateReport.Click
        Dim CreateReportForm As New SaveReport(Me)
        CreateReportForm.Show()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
