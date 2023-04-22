<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReports
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(233, 255)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(782, 52)
        Me.ComboBox1.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Berlin Sans FB", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(401, 71)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(459, 76)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Roblox Reports"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(681, 670)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(179, 57)
        Me.BtnDelete.TabIndex = 7
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(521, 779)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 57)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(375, 670)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(179, 57)
        Me.BtnEdit.TabIndex = 5
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'ViewReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 918)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "ViewReports"
        Me.Text = "ViewReports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnEdit As Button
End Class
