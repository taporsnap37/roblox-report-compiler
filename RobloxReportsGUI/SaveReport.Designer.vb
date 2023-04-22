<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveReport))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblClip = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MediaPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtExploit = New System.Windows.Forms.TextBox()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MediaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(512, 1172)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(175, 65)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(866, 1172)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(175, 65)
        Me.BtnClear.TabIndex = 1
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(689, 1291)
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
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1036, 769)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Berlin Sans FB", 25.875!)
        Me.lblTitle.Location = New System.Drawing.Point(593, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(383, 76)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Save Report"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(412, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 35)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(1003, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 35)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Exploit"
        '
        'TxtExploit
        '
        Me.TxtExploit.Location = New System.Drawing.Point(933, 225)
        Me.TxtExploit.Name = "TxtExploit"
        Me.TxtExploit.Size = New System.Drawing.Size(250, 31)
        Me.TxtExploit.TabIndex = 15
        '
        'TxtUserID
        '
        Me.TxtUserID.Location = New System.Drawing.Point(348, 225)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(250, 31)
        Me.TxtUserID.TabIndex = 14
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1552, 1378)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtExploit)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblClip)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.MediaPanel)
        Me.MinimumSize = New System.Drawing.Size(1578, 1449)
        Me.Name = "SaveReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateReport"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MediaPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblClip As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents MediaPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtExploit As TextBox
    Friend WithEvents TxtUserID As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
