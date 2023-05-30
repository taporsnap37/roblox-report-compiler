<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApp
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
        btnFetchID = New Button()
        btnCopy = New Button()
        btnClear = New Button()
        txtUsername = New TextBox()
        txtExploit = New TextBox()
        GroupBox1 = New GroupBox()
        lbl_Username = New Label()
        lbl_Clip = New Label()
        lbl_Date = New Label()
        lbl_Exploit = New Label()
        lbl_ID = New Label()
        Label1 = New Label()
        Label2 = New Label()
        CheckBoxDate = New CheckBox()
        CheckBoxIDOnly = New CheckBox()
        Label3 = New Label()
        CheckBoxUsername = New CheckBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnFetchID
        ' 
        btnFetchID.Location = New Point(108, 689)
        btnFetchID.Name = "btnFetchID"
        btnFetchID.Size = New Size(161, 64)
        btnFetchID.TabIndex = 0
        btnFetchID.Text = "Fetch ID"
        btnFetchID.UseVisualStyleBackColor = True
        ' 
        ' btnCopy
        ' 
        btnCopy.Location = New Point(314, 689)
        btnCopy.Name = "btnCopy"
        btnCopy.Size = New Size(161, 64)
        btnCopy.TabIndex = 1
        btnCopy.Text = "Copy"
        btnCopy.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(518, 689)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(161, 64)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(359, 134)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(270, 39)
        txtUsername.TabIndex = 3
        ' 
        ' txtExploit
        ' 
        txtExploit.Location = New Point(359, 198)
        txtExploit.Name = "txtExploit"
        txtExploit.Size = New Size(270, 39)
        txtExploit.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbl_Username)
        GroupBox1.Controls.Add(lbl_Clip)
        GroupBox1.Controls.Add(lbl_Date)
        GroupBox1.Controls.Add(lbl_Exploit)
        GroupBox1.Controls.Add(lbl_ID)
        GroupBox1.Location = New Point(130, 409)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(480, 253)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Formatted Report"
        ' 
        ' lbl_Username
        ' 
        lbl_Username.AutoSize = True
        lbl_Username.Location = New Point(21, 79)
        lbl_Username.Name = "lbl_Username"
        lbl_Username.Size = New Size(126, 32)
        lbl_Username.TabIndex = 4
        lbl_Username.Text = "Username:"
        ' 
        ' lbl_Clip
        ' 
        lbl_Clip.AutoSize = True
        lbl_Clip.Location = New Point(21, 205)
        lbl_Clip.Name = "lbl_Clip"
        lbl_Clip.Size = New Size(231, 32)
        lbl_Clip.TabIndex = 3
        lbl_Clip.Text = "Clip: Attached Video"
        ' 
        ' lbl_Date
        ' 
        lbl_Date.AutoSize = True
        lbl_Date.Location = New Point(21, 163)
        lbl_Date.Name = "lbl_Date"
        lbl_Date.Size = New Size(69, 32)
        lbl_Date.TabIndex = 2
        lbl_Date.Text = "Date:"
        ' 
        ' lbl_Exploit
        ' 
        lbl_Exploit.AutoSize = True
        lbl_Exploit.Location = New Point(21, 121)
        lbl_Exploit.Name = "lbl_Exploit"
        lbl_Exploit.Size = New Size(90, 32)
        lbl_Exploit.TabIndex = 1
        lbl_Exploit.Text = "Exploit:"
        ' 
        ' lbl_ID
        ' 
        lbl_ID.AutoSize = True
        lbl_ID.Location = New Point(21, 37)
        lbl_ID.Name = "lbl_ID"
        lbl_ID.Size = New Size(42, 32)
        lbl_ID.TabIndex = 0
        lbl_ID.Text = "ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(130, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 32)
        Label1.TabIndex = 6
        Label1.Text = "Enter Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(130, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 32)
        Label2.TabIndex = 7
        Label2.Text = "Enter Exploit:"
        ' 
        ' CheckBoxDate
        ' 
        CheckBoxDate.AutoSize = True
        CheckBoxDate.Location = New Point(137, 270)
        CheckBoxDate.Name = "CheckBoxDate"
        CheckBoxDate.Size = New Size(181, 36)
        CheckBoxDate.TabIndex = 8
        CheckBoxDate.Text = "Include Date"
        CheckBoxDate.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxIDOnly
        ' 
        CheckBoxIDOnly.AutoSize = True
        CheckBoxIDOnly.Location = New Point(137, 354)
        CheckBoxIDOnly.Name = "CheckBoxIDOnly"
        CheckBoxIDOnly.Size = New Size(188, 36)
        CheckBoxIDOnly.TabIndex = 9
        CheckBoxIDOnly.Text = "Copy ID Only"
        CheckBoxIDOnly.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("High Tower Text", 28.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(95, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(596, 89)
        Label3.TabIndex = 10
        Label3.Text = "Report Formatter"
        ' 
        ' CheckBoxUsername
        ' 
        CheckBoxUsername.AutoSize = True
        CheckBoxUsername.Location = New Point(137, 312)
        CheckBoxUsername.Name = "CheckBoxUsername"
        CheckBoxUsername.Size = New Size(238, 36)
        CheckBoxUsername.TabIndex = 11
        CheckBoxUsername.Text = "Include Username"
        CheckBoxUsername.UseVisualStyleBackColor = True
        ' 
        ' MainApp
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(787, 840)
        Controls.Add(CheckBoxUsername)
        Controls.Add(Label3)
        Controls.Add(CheckBoxIDOnly)
        Controls.Add(CheckBoxDate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(txtExploit)
        Controls.Add(txtUsername)
        Controls.Add(btnClear)
        Controls.Add(btnCopy)
        Controls.Add(btnFetchID)
        Name = "MainApp"
        Text = "MainApp"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnFetchID As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtExploit As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Clip As Label
    Friend WithEvents lbl_Date As Label
    Friend WithEvents lbl_Exploit As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxDate As CheckBox
    Friend WithEvents CheckBoxIDOnly As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents CheckBoxUsername As CheckBox
End Class
