<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnViewReports = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCreateReport = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnViewReports
        '
        Me.BtnViewReports.Location = New System.Drawing.Point(126, 308)
        Me.BtnViewReports.Name = "BtnViewReports"
        Me.BtnViewReports.Size = New System.Drawing.Size(179, 57)
        Me.BtnViewReports.TabIndex = 0
        Me.BtnViewReports.Text = "View Reports"
        Me.BtnViewReports.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(272, 417)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(179, 57)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCreateReport
        '
        Me.BtnCreateReport.Location = New System.Drawing.Point(432, 308)
        Me.BtnCreateReport.Name = "BtnCreateReport"
        Me.BtnCreateReport.Size = New System.Drawing.Size(179, 57)
        Me.BtnCreateReport.TabIndex = 2
        Me.BtnCreateReport.Text = "Create Report"
        Me.BtnCreateReport.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Berlin Sans FB", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(152, 98)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(459, 76)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Roblox Reports"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 575)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.BtnCreateReport)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnViewReports)
        Me.Name = "Main"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnViewReports As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCreateReport As Button
    Friend WithEvents lblWelcome As Label
End Class
