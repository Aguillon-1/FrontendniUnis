<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.classOfficersListPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.OfficerFormat1 = New CMS_Frontend.officerFormat()
        Me.commentPanelPlaceholder = New System.Windows.Forms.Panel()
        Me.sendButton = New FontAwesome.Sharp.IconButton()
        Me.userPicture = New CMS_Frontend.CircularPictureBox()
        Me.commentHeaderPanel = New System.Windows.Forms.Panel()
        Me.commentLbl = New System.Windows.Forms.Label()
        Me.commentTxtBox = New System.Windows.Forms.TextBox()
        Me.commentSection = New System.Windows.Forms.Panel()
        Me.classMemberListPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MemberFormat1 = New CMS_Frontend.MemberFormat()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.classOfficersListPanel.SuspendLayout()
        Me.commentPanelPlaceholder.SuspendLayout()
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.commentHeaderPanel.SuspendLayout()
        Me.classMemberListPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.classOfficersListPanel)
        Me.Panel1.Location = New System.Drawing.Point(20, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(8, 8, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 947)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(383, 52)
        Me.Panel5.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(136, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Officers"
        '
        'classOfficersListPanel
        '
        Me.classOfficersListPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.classOfficersListPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.classOfficersListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classOfficersListPanel.Controls.Add(Me.OfficerFormat1)
        Me.classOfficersListPanel.Location = New System.Drawing.Point(15, 52)
        Me.classOfficersListPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.classOfficersListPanel.Name = "classOfficersListPanel"
        Me.classOfficersListPanel.Size = New System.Drawing.Size(355, 870)
        Me.classOfficersListPanel.TabIndex = 1
        '
        'OfficerFormat1
        '
        Me.OfficerFormat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OfficerFormat1.Location = New System.Drawing.Point(0, 0)
        Me.OfficerFormat1.Margin = New System.Windows.Forms.Padding(0)
        Me.OfficerFormat1.Name = "OfficerFormat1"
        Me.OfficerFormat1.Size = New System.Drawing.Size(354, 57)
        Me.OfficerFormat1.TabIndex = 1
        '
        'commentPanelPlaceholder
        '
        Me.commentPanelPlaceholder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.commentPanelPlaceholder.AutoSize = True
        Me.commentPanelPlaceholder.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.commentPanelPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.commentPanelPlaceholder.Controls.Add(Me.sendButton)
        Me.commentPanelPlaceholder.Controls.Add(Me.userPicture)
        Me.commentPanelPlaceholder.Controls.Add(Me.commentHeaderPanel)
        Me.commentPanelPlaceholder.Controls.Add(Me.commentTxtBox)
        Me.commentPanelPlaceholder.Controls.Add(Me.commentSection)
        Me.commentPanelPlaceholder.Location = New System.Drawing.Point(863, 15)
        Me.commentPanelPlaceholder.Margin = New System.Windows.Forms.Padding(0)
        Me.commentPanelPlaceholder.Name = "commentPanelPlaceholder"
        Me.commentPanelPlaceholder.Size = New System.Drawing.Size(790, 947)
        Me.commentPanelPlaceholder.TabIndex = 1
        '
        'sendButton
        '
        Me.sendButton.FlatAppearance.BorderSize = 0
        Me.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendButton.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.sendButton.IconColor = System.Drawing.Color.Black
        Me.sendButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.sendButton.IconSize = 50
        Me.sendButton.Location = New System.Drawing.Point(685, 849)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(47, 72)
        Me.sendButton.TabIndex = 13
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'userPicture
        '
        Me.userPicture.BackColor = System.Drawing.Color.Silver
        Me.userPicture.Location = New System.Drawing.Point(63, 849)
        Me.userPicture.Name = "userPicture"
        Me.userPicture.Size = New System.Drawing.Size(75, 72)
        Me.userPicture.TabIndex = 8
        Me.userPicture.TabStop = False
        '
        'commentHeaderPanel
        '
        Me.commentHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.commentHeaderPanel.Controls.Add(Me.commentLbl)
        Me.commentHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.commentHeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.commentHeaderPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.commentHeaderPanel.Name = "commentHeaderPanel"
        Me.commentHeaderPanel.Size = New System.Drawing.Size(788, 38)
        Me.commentHeaderPanel.TabIndex = 7
        '
        'commentLbl
        '
        Me.commentLbl.AutoSize = True
        Me.commentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.commentLbl.Location = New System.Drawing.Point(364, 10)
        Me.commentLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.commentLbl.Name = "commentLbl"
        Me.commentLbl.Size = New System.Drawing.Size(86, 20)
        Me.commentLbl.TabIndex = 3
        Me.commentLbl.Text = "Comments"
        '
        'commentTxtBox
        '
        Me.commentTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.commentTxtBox.Location = New System.Drawing.Point(162, 826)
        Me.commentTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.commentTxtBox.Multiline = True
        Me.commentTxtBox.Name = "commentTxtBox"
        Me.commentTxtBox.Size = New System.Drawing.Size(508, 107)
        Me.commentTxtBox.TabIndex = 5
        '
        'commentSection
        '
        Me.commentSection.BackColor = System.Drawing.Color.White
        Me.commentSection.Location = New System.Drawing.Point(42, 52)
        Me.commentSection.Margin = New System.Windows.Forms.Padding(2)
        Me.commentSection.Name = "commentSection"
        Me.commentSection.Size = New System.Drawing.Size(710, 759)
        Me.commentSection.TabIndex = 4
        '
        'classMemberListPanel
        '
        Me.classMemberListPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.classMemberListPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.classMemberListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classMemberListPanel.Controls.Add(Me.MemberFormat1)
        Me.classMemberListPanel.Location = New System.Drawing.Point(16, 51)
        Me.classMemberListPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.classMemberListPanel.Name = "classMemberListPanel"
        Me.classMemberListPanel.Size = New System.Drawing.Size(354, 871)
        Me.classMemberListPanel.TabIndex = 0
        '
        'MemberFormat1
        '
        Me.MemberFormat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MemberFormat1.Location = New System.Drawing.Point(0, 0)
        Me.MemberFormat1.Margin = New System.Windows.Forms.Padding(0)
        Me.MemberFormat1.Name = "MemberFormat1"
        Me.MemberFormat1.Size = New System.Drawing.Size(353, 59)
        Me.MemberFormat1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel2.Controls.Add(Me.classMemberListPanel)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Location = New System.Drawing.Point(442, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 947)
        Me.Panel2.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(383, 52)
        Me.Panel7.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(124, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Class Members"
        '
        'Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.commentPanelPlaceholder)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1681, 978)
        Me.MinimumSize = New System.Drawing.Size(1681, 978)
        Me.Name = "Section"
        Me.Size = New System.Drawing.Size(1681, 978)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.classOfficersListPanel.ResumeLayout(False)
        Me.commentPanelPlaceholder.ResumeLayout(False)
        Me.commentPanelPlaceholder.PerformLayout()
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.commentHeaderPanel.ResumeLayout(False)
        Me.commentHeaderPanel.PerformLayout()
        Me.classMemberListPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents commentPanelPlaceholder As Panel
    Friend WithEvents classMemberListPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents classOfficersListPanel As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents commentTxtBox As TextBox
    Friend WithEvents commentSection As Panel
    Friend WithEvents commentLbl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents OfficerFormat1 As officerFormat
    Friend WithEvents MemberFormat1 As MemberFormat
    Friend WithEvents Panel7 As Panel
    Friend WithEvents commentHeaderPanel As Panel
    Friend WithEvents userPicture As CircularPictureBox
    Friend WithEvents sendButton As FontAwesome.Sharp.IconButton
End Class
