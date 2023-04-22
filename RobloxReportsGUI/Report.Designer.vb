<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblClip = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtExploit = New System.Windows.Forms.TextBox()
        Me.lblExploit = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MediaPanel = New System.Windows.Forms.Panel()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MediaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(689, 1228)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(175, 65)
        Me.BtnBack.TabIndex = 2
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1036, 769)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1036, 769)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblClip
        '
        Me.lblClip.AutoSize = True
        Me.lblClip.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.lblClip.Location = New System.Drawing.Point(683, 322)
        Me.lblClip.Name = "lblClip"
        Me.lblClip.Size = New System.Drawing.Size(194, 35)
        Me.lblClip.TabIndex = 5
        Me.lblClip.Text = "Clip or Image"
        '
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Location = New System.Drawing.Point(378, 220)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(250, 31)
        Me.txtUserID.TabIndex = 6
        '
        'txtExploit
        '
        Me.txtExploit.Enabled = False
        Me.txtExploit.Location = New System.Drawing.Point(904, 220)
        Me.txtExploit.Name = "txtExploit"
        Me.txtExploit.Size = New System.Drawing.Size(250, 31)
        Me.txtExploit.TabIndex = 7
        '
        'lblExploit
        '
        Me.lblExploit.AutoSize = True
        Me.lblExploit.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.lblExploit.Location = New System.Drawing.Point(974, 177)
        Me.lblExploit.Name = "lblExploit"
        Me.lblExploit.Size = New System.Drawing.Size(105, 35)
        Me.lblExploit.TabIndex = 8
        Me.lblExploit.Text = "Exploit"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.lblUserID.Location = New System.Drawing.Point(442, 177)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(110, 35)
        Me.lblUserID.TabIndex = 9
        Me.lblUserID.Text = "User ID"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Berlin Sans FB", 25.875!)
        Me.lblTitle.Location = New System.Drawing.Point(667, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(227, 76)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Report"
        '
        'MediaPanel
        '
        Me.MediaPanel.Controls.Add(Me.PictureBox1)
        Me.MediaPanel.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.MediaPanel.Location = New System.Drawing.Point(271, 383)
        Me.MediaPanel.Name = "MediaPanel"
        Me.MediaPanel.Size = New System.Drawing.Size(1036, 769)
        Me.MediaPanel.TabIndex = 13
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1552, 1378)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblExploit)
        Me.Controls.Add(Me.txtExploit)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblClip)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.MediaPanel)
        Me.Name = "Report"
        Me.Text = "CreateReport"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MediaPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBack As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblClip As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtExploit As TextBox
    Friend WithEvents lblExploit As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents MediaPanel As Panel
End Class
