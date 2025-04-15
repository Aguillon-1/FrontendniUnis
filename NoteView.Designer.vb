<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoteView
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
        Me.orangePanel = New System.Windows.Forms.Panel()
        Me.subjectTxtBox = New System.Windows.Forms.TextBox()
        Me.posterNameTxtBox = New System.Windows.Forms.TextBox()
        Me.subjectLbl = New System.Windows.Forms.Label()
        Me.postedLbl = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.fileListBox = New System.Windows.Forms.ListBox()
        Me.descTxtBox = New System.Windows.Forms.TextBox()
        Me.filesLbl = New System.Windows.Forms.Label()
        Me.descLbl = New System.Windows.Forms.Label()
        Me.introductionLbl = New System.Windows.Forms.Label()
        Me.previewPanel = New System.Windows.Forms.Panel()
        Me.commentSection = New System.Windows.Forms.Panel()
        Me.commentLbl = New System.Windows.Forms.Label()
        Me.commentTxtBox = New System.Windows.Forms.TextBox()
        Me.greenPanel = New System.Windows.Forms.Panel()
        Me.sendButton = New FontAwesome.Sharp.IconButton()
        Me.userProfile = New CMS_Frontend.CircularPictureBox()
        Me.orangePanel.SuspendLayout()
        Me.greenPanel.SuspendLayout()
        CType(Me.userProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'orangePanel
        '
        Me.orangePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.orangePanel.Controls.Add(Me.subjectTxtBox)
        Me.orangePanel.Controls.Add(Me.posterNameTxtBox)
        Me.orangePanel.Controls.Add(Me.subjectLbl)
        Me.orangePanel.Controls.Add(Me.postedLbl)
        Me.orangePanel.Controls.Add(Me.closeButton)
        Me.orangePanel.Controls.Add(Me.fileListBox)
        Me.orangePanel.Controls.Add(Me.descTxtBox)
        Me.orangePanel.Controls.Add(Me.filesLbl)
        Me.orangePanel.Controls.Add(Me.descLbl)
        Me.orangePanel.Controls.Add(Me.introductionLbl)
        Me.orangePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orangePanel.Location = New System.Drawing.Point(997, 0)
        Me.orangePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.orangePanel.Name = "orangePanel"
        Me.orangePanel.Size = New System.Drawing.Size(684, 409)
        Me.orangePanel.TabIndex = 0
        '
        'subjectTxtBox
        '
        Me.subjectTxtBox.Enabled = False
        Me.subjectTxtBox.Location = New System.Drawing.Point(142, 147)
        Me.subjectTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.subjectTxtBox.Multiline = True
        Me.subjectTxtBox.Name = "subjectTxtBox"
        Me.subjectTxtBox.ReadOnly = True
        Me.subjectTxtBox.Size = New System.Drawing.Size(433, 24)
        Me.subjectTxtBox.TabIndex = 10
        '
        'posterNameTxtBox
        '
        Me.posterNameTxtBox.Enabled = False
        Me.posterNameTxtBox.Location = New System.Drawing.Point(142, 80)
        Me.posterNameTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.posterNameTxtBox.Multiline = True
        Me.posterNameTxtBox.Name = "posterNameTxtBox"
        Me.posterNameTxtBox.ReadOnly = True
        Me.posterNameTxtBox.Size = New System.Drawing.Size(433, 24)
        Me.posterNameTxtBox.TabIndex = 9
        '
        'subjectLbl
        '
        Me.subjectLbl.AutoSize = True
        Me.subjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.subjectLbl.Location = New System.Drawing.Point(117, 118)
        Me.subjectLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.subjectLbl.Name = "subjectLbl"
        Me.subjectLbl.Size = New System.Drawing.Size(57, 18)
        Me.subjectLbl.TabIndex = 8
        Me.subjectLbl.Text = "Subject"
        '
        'postedLbl
        '
        Me.postedLbl.AutoSize = True
        Me.postedLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postedLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.postedLbl.Location = New System.Drawing.Point(117, 45)
        Me.postedLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.postedLbl.Name = "postedLbl"
        Me.postedLbl.Size = New System.Drawing.Size(74, 18)
        Me.postedLbl.TabIndex = 7
        Me.postedLbl.Text = "Posted by"
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.closeButton.Location = New System.Drawing.Point(649, 0)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(35, 29)
        Me.closeButton.TabIndex = 6
        Me.closeButton.Text = "X"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'fileListBox
        '
        Me.fileListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileListBox.FormattingEnabled = True
        Me.fileListBox.ItemHeight = 16
        Me.fileListBox.Location = New System.Drawing.Point(41, 217)
        Me.fileListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.fileListBox.Name = "fileListBox"
        Me.fileListBox.Size = New System.Drawing.Size(291, 164)
        Me.fileListBox.TabIndex = 5
        '
        'descTxtBox
        '
        Me.descTxtBox.Enabled = False
        Me.descTxtBox.Location = New System.Drawing.Point(353, 217)
        Me.descTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.descTxtBox.Multiline = True
        Me.descTxtBox.Name = "descTxtBox"
        Me.descTxtBox.ReadOnly = True
        Me.descTxtBox.Size = New System.Drawing.Size(299, 164)
        Me.descTxtBox.TabIndex = 4
        '
        'filesLbl
        '
        Me.filesLbl.AutoSize = True
        Me.filesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filesLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.filesLbl.Location = New System.Drawing.Point(38, 185)
        Me.filesLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.filesLbl.Name = "filesLbl"
        Me.filesLbl.Size = New System.Drawing.Size(39, 18)
        Me.filesLbl.TabIndex = 2
        Me.filesLbl.Text = "Files"
        '
        'descLbl
        '
        Me.descLbl.AutoSize = True
        Me.descLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.descLbl.Location = New System.Drawing.Point(350, 185)
        Me.descLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.descLbl.Name = "descLbl"
        Me.descLbl.Size = New System.Drawing.Size(83, 18)
        Me.descLbl.TabIndex = 1
        Me.descLbl.Text = "Description"
        '
        'introductionLbl
        '
        Me.introductionLbl.AutoSize = True
        Me.introductionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.introductionLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.introductionLbl.Location = New System.Drawing.Point(291, 15)
        Me.introductionLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.introductionLbl.Name = "introductionLbl"
        Me.introductionLbl.Size = New System.Drawing.Size(106, 20)
        Me.introductionLbl.TabIndex = 0
        Me.introductionLbl.Text = "Introduction"
        '
        'previewPanel
        '
        Me.previewPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.previewPanel.Location = New System.Drawing.Point(0, 0)
        Me.previewPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.previewPanel.Name = "previewPanel"
        Me.previewPanel.Size = New System.Drawing.Size(997, 998)
        Me.previewPanel.TabIndex = 1
        '
        'commentSection
        '
        Me.commentSection.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.commentSection.Location = New System.Drawing.Point(61, 45)
        Me.commentSection.Margin = New System.Windows.Forms.Padding(2)
        Me.commentSection.Name = "commentSection"
        Me.commentSection.Size = New System.Drawing.Size(572, 432)
        Me.commentSection.TabIndex = 2
        '
        'commentLbl
        '
        Me.commentLbl.AutoSize = True
        Me.commentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.commentLbl.Location = New System.Drawing.Point(38, 13)
        Me.commentLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.commentLbl.Name = "commentLbl"
        Me.commentLbl.Size = New System.Drawing.Size(82, 18)
        Me.commentLbl.TabIndex = 6
        Me.commentLbl.Text = "Comments"
        '
        'commentTxtBox
        '
        Me.commentTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.commentTxtBox.Location = New System.Drawing.Point(166, 494)
        Me.commentTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.commentTxtBox.Multiline = True
        Me.commentTxtBox.Name = "commentTxtBox"
        Me.commentTxtBox.Size = New System.Drawing.Size(366, 73)
        Me.commentTxtBox.TabIndex = 8
        '
        'greenPanel
        '
        Me.greenPanel.Controls.Add(Me.sendButton)
        Me.greenPanel.Controls.Add(Me.userProfile)
        Me.greenPanel.Controls.Add(Me.commentTxtBox)
        Me.greenPanel.Controls.Add(Me.commentSection)
        Me.greenPanel.Controls.Add(Me.commentLbl)
        Me.greenPanel.Location = New System.Drawing.Point(997, 409)
        Me.greenPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.greenPanel.Name = "greenPanel"
        Me.greenPanel.Size = New System.Drawing.Size(684, 589)
        Me.greenPanel.TabIndex = 10
        '
        'sendButton
        '
        Me.sendButton.FlatAppearance.BorderSize = 0
        Me.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendButton.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.sendButton.IconColor = System.Drawing.Color.Black
        Me.sendButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.sendButton.Location = New System.Drawing.Point(542, 509)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(48, 45)
        Me.sendButton.TabIndex = 11
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'userProfile
        '
        Me.userProfile.BackColor = System.Drawing.Color.DarkGray
        Me.userProfile.Location = New System.Drawing.Point(77, 494)
        Me.userProfile.Name = "userProfile"
        Me.userProfile.Size = New System.Drawing.Size(70, 72)
        Me.userProfile.TabIndex = 10
        Me.userProfile.TabStop = False
        '
        'NoteView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1681, 997)
        Me.Controls.Add(Me.greenPanel)
        Me.Controls.Add(Me.previewPanel)
        Me.Controls.Add(Me.orangePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1681, 997)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1681, 997)
        Me.Name = "NoteView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NoteView"
        Me.orangePanel.ResumeLayout(False)
        Me.orangePanel.PerformLayout()
        Me.greenPanel.ResumeLayout(False)
        Me.greenPanel.PerformLayout()
        CType(Me.userProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents orangePanel As Panel
    Friend WithEvents previewPanel As Panel
    Friend WithEvents introductionLbl As Label
    Friend WithEvents fileListBox As ListBox
    Friend WithEvents descTxtBox As TextBox
    Friend WithEvents filesLbl As Label
    Friend WithEvents descLbl As Label
    Friend WithEvents commentSection As Panel
    Friend WithEvents commentLbl As Label
    Friend WithEvents commentTxtBox As TextBox
    Friend WithEvents closeButton As Button
    Friend WithEvents greenPanel As Panel
    Friend WithEvents subjectTxtBox As TextBox
    Friend WithEvents posterNameTxtBox As TextBox
    Friend WithEvents subjectLbl As Label
    Friend WithEvents postedLbl As Label
    Friend WithEvents userProfile As CircularPictureBox
    Friend WithEvents sendButton As FontAwesome.Sharp.IconButton
End Class
