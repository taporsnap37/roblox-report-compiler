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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_Username
        '
        Me.TXT_Username.Location = New System.Drawing.Point(320, 147)
        Me.TXT_Username.Name = "TXT_Username"
        Me.TXT_Username.Size = New System.Drawing.Size(317, 31)
        Me.TXT_Username.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Exploit:"
        '
        'TXT_Exploit
        '
        Me.TXT_Exploit.Location = New System.Drawing.Point(320, 239)
        Me.TXT_Exploit.Name = "TXT_Exploit"
        Me.TXT_Exploit.Size = New System.Drawing.Size(317, 31)
        Me.TXT_Exploit.TabIndex = 2
        '
        'BoxIncludeDate
        '
        Me.BoxIncludeDate.AutoSize = True
        Me.BoxIncludeDate.Location = New System.Drawing.Point(127, 320)
        Me.BoxIncludeDate.Name = "BoxIncludeDate"
        Me.BoxIncludeDate.Size = New System.Drawing.Size(164, 29)
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
        Me.GroupBox1.Location = New System.Drawing.Point(127, 444)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 196)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formatted Report"
        '
        'LBL_Date
        '
        Me.LBL_Date.AutoSize = True
        Me.LBL_Date.Location = New System.Drawing.Point(6, 120)
        Me.LBL_Date.Name = "LBL_Date"
        Me.LBL_Date.Size = New System.Drawing.Size(69, 25)
        Me.LBL_Date.TabIndex = 3
        Me.LBL_Date.Text = "Date: "
        '
        'LBL_Clip
        '
        Me.LBL_Clip.AutoSize = True
        Me.LBL_Clip.Location = New System.Drawing.Point(6, 156)
        Me.LBL_Clip.Name = "LBL_Clip"
        Me.LBL_Clip.Size = New System.Drawing.Size(207, 25)
        Me.LBL_Clip.TabIndex = 2
        Me.LBL_Clip.Text = "Clip: Attached Video"
        '
        'LBL_Exploit
        '
        Me.LBL_Exploit.AutoSize = True
        Me.LBL_Exploit.Location = New System.Drawing.Point(6, 85)
        Me.LBL_Exploit.Name = "LBL_Exploit"
        Me.LBL_Exploit.Size = New System.Drawing.Size(89, 25)
        Me.LBL_Exploit.TabIndex = 1
        Me.LBL_Exploit.Text = "Exploit: "
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Location = New System.Drawing.Point(6, 52)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(44, 25)
        Me.LBL_ID.TabIndex = 0
        Me.LBL_ID.Text = "ID: "
        '
        'BTNCopy
        '
        Me.BTNCopy.Location = New System.Drawing.Point(315, 692)
        Me.BTNCopy.Name = "BTNCopy"
        Me.BTNCopy.Size = New System.Drawing.Size(121, 54)
        Me.BTNCopy.TabIndex = 7
        Me.BTNCopy.Text = "Copy"
        Me.BTNCopy.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Location = New System.Drawing.Point(477, 692)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(121, 54)
        Me.BTNClear.TabIndex = 8
        Me.BTNClear.Text = "Clear"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'BTNFormat
        '
        Me.BTNFormat.Location = New System.Drawing.Point(150, 692)
        Me.BTNFormat.Name = "BTNFormat"
        Me.BTNFormat.Size = New System.Drawing.Size(121, 54)
        Me.BTNFormat.TabIndex = 9
        Me.BTNFormat.Text = "Format"
        Me.BTNFormat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(732, 53)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Roblox Report Formatter"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 817)
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
End Class
