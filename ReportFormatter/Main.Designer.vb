<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TXT_Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Exploit = New System.Windows.Forms.TextBox()
        Me.BoxIncludeDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_Date = New System.Windows.Forms.Label()
        Me.LBL_Clip = New System.Windows.Forms.Label()
        Me.LBL_Exploit = New System.Windows.Forms.Label()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.BTNCopy = New System.Windows.Forms.Button()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.BTNFormat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckCopyIDOnly = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_Username
        '
        Me.TXT_Username.Location = New System.Drawing.Point(160, 76)
        Me.TXT_Username.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_Username.Name = "TXT_Username"
        Me.TXT_Username.Size = New System.Drawing.Size(160, 20)
        Me.TXT_Username.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Exploit:"
        '
        'TXT_Exploit
        '
        Me.TXT_Exploit.Location = New System.Drawing.Point(160, 124)
        Me.TXT_Exploit.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_Exploit.Name = "TXT_Exploit"
        Me.TXT_Exploit.Size = New System.Drawing.Size(160, 20)
        Me.TXT_Exploit.TabIndex = 2
        '
        'BoxIncludeDate
        '
        Me.BoxIncludeDate.AutoSize = True
        Me.BoxIncludeDate.Location = New System.Drawing.Point(64, 166)
        Me.BoxIncludeDate.Margin = New System.Windows.Forms.Padding(2)
        Me.BoxIncludeDate.Name = "BoxIncludeDate"
        Me.BoxIncludeDate.Size = New System.Drawing.Size(87, 17)
        Me.BoxIncludeDate.TabIndex = 5
        Me.BoxIncludeDate.Text = "Include Date"
        Me.BoxIncludeDate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_Date)
        Me.GroupBox1.Controls.Add(Me.LBL_Clip)
        Me.GroupBox1.Controls.Add(Me.LBL_Exploit)
        Me.GroupBox1.Controls.Add(Me.LBL_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 231)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(255, 102)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formatted Report"
        '
        'LBL_Date
        '
        Me.LBL_Date.AutoSize = True
        Me.LBL_Date.Location = New System.Drawing.Point(3, 62)
        Me.LBL_Date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Date.Name = "LBL_Date"
        Me.LBL_Date.Size = New System.Drawing.Size(36, 13)
        Me.LBL_Date.TabIndex = 3
        Me.LBL_Date.Text = "Date: "
        '
        'LBL_Clip
        '
        Me.LBL_Clip.AutoSize = True
        Me.LBL_Clip.Location = New System.Drawing.Point(3, 81)
        Me.LBL_Clip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Clip.Name = "LBL_Clip"
        Me.LBL_Clip.Size = New System.Drawing.Size(103, 13)
        Me.LBL_Clip.TabIndex = 2
        Me.LBL_Clip.Text = "Clip: Attached Video"
        '
        'LBL_Exploit
        '
        Me.LBL_Exploit.AutoSize = True
        Me.LBL_Exploit.Location = New System.Drawing.Point(3, 44)
        Me.LBL_Exploit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Exploit.Name = "LBL_Exploit"
        Me.LBL_Exploit.Size = New System.Drawing.Size(44, 13)
        Me.LBL_Exploit.TabIndex = 1
        Me.LBL_Exploit.Text = "Exploit: "
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Location = New System.Drawing.Point(3, 27)
        Me.LBL_ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(24, 13)
        Me.LBL_ID.TabIndex = 0
        Me.LBL_ID.Text = "ID: "
        '
        'BTNCopy
        '
        Me.BTNCopy.Location = New System.Drawing.Point(158, 360)
        Me.BTNCopy.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNCopy.Name = "BTNCopy"
        Me.BTNCopy.Size = New System.Drawing.Size(60, 28)
        Me.BTNCopy.TabIndex = 7
        Me.BTNCopy.Text = "Copy"
        Me.BTNCopy.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Location = New System.Drawing.Point(238, 360)
        Me.BTNClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(60, 28)
        Me.BTNClear.TabIndex = 8
        Me.BTNClear.Text = "Clear"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'BTNFormat
        '
        Me.BTNFormat.Location = New System.Drawing.Point(75, 360)
        Me.BTNFormat.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNFormat.Name = "BTNFormat"
        Me.BTNFormat.Size = New System.Drawing.Size(60, 28)
        Me.BTNFormat.TabIndex = 9
        Me.BTNFormat.Text = "Format"
        Me.BTNFormat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Report Formatter"
        '
        'CheckCopyIDOnly
        '
        Me.CheckCopyIDOnly.AutoSize = True
        Me.CheckCopyIDOnly.Location = New System.Drawing.Point(64, 187)
        Me.CheckCopyIDOnly.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckCopyIDOnly.Name = "CheckCopyIDOnly"
        Me.CheckCopyIDOnly.Size = New System.Drawing.Size(88, 17)
        Me.CheckCopyIDOnly.TabIndex = 11
        Me.CheckCopyIDOnly.Text = "Copy ID Only"
        Me.CheckCopyIDOnly.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 425)
        Me.Controls.Add(Me.CheckCopyIDOnly)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNFormat)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.BTNCopy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BoxIncludeDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Exploit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Username)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Exploit As TextBox
    Friend WithEvents BoxIncludeDate As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTNCopy As Button
    Friend WithEvents BTNClear As Button
    Friend WithEvents LBL_Clip As Label
    Friend WithEvents LBL_Exploit As Label
    Friend WithEvents LBL_ID As Label
    Friend WithEvents BTNFormat As Button
    Friend WithEvents LBL_Date As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckCopyIDOnly As CheckBox
End Class
