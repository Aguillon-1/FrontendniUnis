<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.introPanel = New System.Windows.Forms.Panel()
        Me.profButton = New System.Windows.Forms.Button()
        Me.adminButton = New System.Windows.Forms.Button()
        Me.officerButton = New System.Windows.Forms.Button()
        Me.userAccessLevel = New System.Windows.Forms.Label()
        Me.accesslevlLbl = New System.Windows.Forms.Label()
        Me.studentButton = New System.Windows.Forms.Button()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.accessPanel = New System.Windows.Forms.Panel()
        Me.AccessRoleadmin1 = New CMS_Frontend.AccessRoleadmin()
        Me.AccessRoleprof1 = New CMS_Frontend.AccessRoleprof()
        Me.AccessRoleofficer1 = New CMS_Frontend.AccessRoleofficer()
        Me.AccessRolestudent1 = New CMS_Frontend.AccessRolestudent()
        Me.requestPanel = New System.Windows.Forms.Panel()
        Me.passwordLbl = New System.Windows.Forms.Label()
        Me.newEmailLbl = New System.Windows.Forms.Label()
        Me.currentEmailLbl = New System.Windows.Forms.Label()
        Me.passwordPanel = New System.Windows.Forms.Panel()
        Me.passwordTxtBox = New System.Windows.Forms.TextBox()
        Me.newEmailPanel = New System.Windows.Forms.Panel()
        Me.newEmailTxtBox = New System.Windows.Forms.TextBox()
        Me.currentEmailPanel = New System.Windows.Forms.Panel()
        Me.currentEmailTxtBox = New System.Windows.Forms.TextBox()
        Me.requestDescLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.requestLbl = New System.Windows.Forms.Label()
        Me.joinClassPanel = New System.Windows.Forms.Panel()
        Me.joinTxtBoxPanel = New System.Windows.Forms.Panel()
        Me.codeTxtBox = New System.Windows.Forms.TextBox()
        Me.codeSubmitBttn = New System.Windows.Forms.Button()
        Me.joinDescLbl = New System.Windows.Forms.Label()
        Me.joinLabel = New System.Windows.Forms.Label()
        Me.introPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.accessPanel.SuspendLayout()
        Me.requestPanel.SuspendLayout()
        Me.passwordPanel.SuspendLayout()
        Me.newEmailPanel.SuspendLayout()
        Me.currentEmailPanel.SuspendLayout()
        Me.joinClassPanel.SuspendLayout()
        Me.joinTxtBoxPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'introPanel
        '
        Me.introPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.introPanel.Controls.Add(Me.profButton)
        Me.introPanel.Controls.Add(Me.adminButton)
        Me.introPanel.Controls.Add(Me.officerButton)
        Me.introPanel.Controls.Add(Me.userAccessLevel)
        Me.introPanel.Controls.Add(Me.accesslevlLbl)
        Me.introPanel.Controls.Add(Me.studentButton)
        Me.introPanel.Controls.Add(Me.descLabel)
        Me.introPanel.Controls.Add(Me.PictureBox1)
        Me.introPanel.Controls.Add(Me.titleLabel)
        Me.introPanel.Location = New System.Drawing.Point(21, 20)
        Me.introPanel.Name = "introPanel"
        Me.introPanel.Size = New System.Drawing.Size(1093, 481)
        Me.introPanel.TabIndex = 1
        '
        'profButton
        '
        Me.profButton.BackColor = System.Drawing.Color.Transparent
        Me.profButton.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.buttonBackgroundHighlight
        Me.profButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.profButton.FlatAppearance.BorderSize = 0
        Me.profButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.profButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.profButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.profButton.Location = New System.Drawing.Point(323, 386)
        Me.profButton.Name = "profButton"
        Me.profButton.Size = New System.Drawing.Size(110, 42)
        Me.profButton.TabIndex = 20
        Me.profButton.Text = "Professor"
        Me.profButton.UseVisualStyleBackColor = False
        '
        'adminButton
        '
        Me.adminButton.BackColor = System.Drawing.Color.Transparent
        Me.adminButton.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.buttonBackgroundHighlight
        Me.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminButton.FlatAppearance.BorderSize = 0
        Me.adminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.adminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminButton.Location = New System.Drawing.Point(477, 386)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(110, 42)
        Me.adminButton.TabIndex = 19
        Me.adminButton.Text = "Admin"
        Me.adminButton.UseVisualStyleBackColor = False
        '
        'officerButton
        '
        Me.officerButton.BackColor = System.Drawing.Color.Transparent
        Me.officerButton.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.buttonBackgroundHighlight
        Me.officerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.officerButton.FlatAppearance.BorderSize = 0
        Me.officerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.officerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.officerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.officerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.officerButton.Location = New System.Drawing.Point(168, 386)
        Me.officerButton.Name = "officerButton"
        Me.officerButton.Size = New System.Drawing.Size(110, 42)
        Me.officerButton.TabIndex = 18
        Me.officerButton.Text = "Officer"
        Me.officerButton.UseVisualStyleBackColor = False
        '
        'userAccessLevel
        '
        Me.userAccessLevel.AutoSize = True
        Me.userAccessLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userAccessLevel.ForeColor = System.Drawing.Color.DarkRed
        Me.userAccessLevel.Location = New System.Drawing.Point(176, 315)
        Me.userAccessLevel.Name = "userAccessLevel"
        Me.userAccessLevel.Size = New System.Drawing.Size(102, 20)
        Me.userAccessLevel.TabIndex = 17
        Me.userAccessLevel.Text = "Access Level"
        '
        'accesslevlLbl
        '
        Me.accesslevlLbl.AutoSize = True
        Me.accesslevlLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accesslevlLbl.Location = New System.Drawing.Point(34, 315)
        Me.accesslevlLbl.Name = "accesslevlLbl"
        Me.accesslevlLbl.Size = New System.Drawing.Size(136, 20)
        Me.accesslevlLbl.TabIndex = 16
        Me.accesslevlLbl.Text = "Your access level:"
        '
        'studentButton
        '
        Me.studentButton.BackColor = System.Drawing.Color.Transparent
        Me.studentButton.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.buttonBackGround
        Me.studentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.studentButton.FlatAppearance.BorderSize = 0
        Me.studentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.studentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.studentButton.Location = New System.Drawing.Point(20, 386)
        Me.studentButton.Name = "studentButton"
        Me.studentButton.Size = New System.Drawing.Size(110, 42)
        Me.studentButton.TabIndex = 15
        Me.studentButton.Text = "Student"
        Me.studentButton.UseVisualStyleBackColor = False
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(34, 190)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(544, 80)
        Me.descLabel.TabIndex = 14
        Me.descLabel.Text = resources.GetString("descLabel.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.UCC
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(614, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(478, 481)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.titleLabel.Location = New System.Drawing.Point(28, 34)
        Me.titleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(549, 110)
        Me.titleLabel.TabIndex = 12
        Me.titleLabel.Text = "Classroom Management" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'accessPanel
        '
        Me.accessPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.accessPanel.Controls.Add(Me.AccessRoleadmin1)
        Me.accessPanel.Controls.Add(Me.AccessRoleprof1)
        Me.accessPanel.Controls.Add(Me.AccessRoleofficer1)
        Me.accessPanel.Controls.Add(Me.AccessRolestudent1)
        Me.accessPanel.Location = New System.Drawing.Point(21, 532)
        Me.accessPanel.Name = "accessPanel"
        Me.accessPanel.Size = New System.Drawing.Size(1093, 398)
        Me.accessPanel.TabIndex = 2
        '
        'AccessRoleadmin1
        '
        Me.AccessRoleadmin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessRoleadmin1.Location = New System.Drawing.Point(0, 0)
        Me.AccessRoleadmin1.Name = "AccessRoleadmin1"
        Me.AccessRoleadmin1.Size = New System.Drawing.Size(1093, 398)
        Me.AccessRoleadmin1.TabIndex = 3
        '
        'AccessRoleprof1
        '
        Me.AccessRoleprof1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessRoleprof1.Location = New System.Drawing.Point(0, 0)
        Me.AccessRoleprof1.Name = "AccessRoleprof1"
        Me.AccessRoleprof1.Size = New System.Drawing.Size(1093, 398)
        Me.AccessRoleprof1.TabIndex = 2
        '
        'AccessRoleofficer1
        '
        Me.AccessRoleofficer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessRoleofficer1.Location = New System.Drawing.Point(0, 0)
        Me.AccessRoleofficer1.Name = "AccessRoleofficer1"
        Me.AccessRoleofficer1.Size = New System.Drawing.Size(1093, 398)
        Me.AccessRoleofficer1.TabIndex = 1
        '
        'AccessRolestudent1
        '
        Me.AccessRolestudent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessRolestudent1.Location = New System.Drawing.Point(0, 0)
        Me.AccessRolestudent1.Name = "AccessRolestudent1"
        Me.AccessRolestudent1.Size = New System.Drawing.Size(1093, 398)
        Me.AccessRolestudent1.TabIndex = 0
        '
        'requestPanel
        '
        Me.requestPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.requestPanel.Controls.Add(Me.passwordLbl)
        Me.requestPanel.Controls.Add(Me.newEmailLbl)
        Me.requestPanel.Controls.Add(Me.currentEmailLbl)
        Me.requestPanel.Controls.Add(Me.passwordPanel)
        Me.requestPanel.Controls.Add(Me.newEmailPanel)
        Me.requestPanel.Controls.Add(Me.currentEmailPanel)
        Me.requestPanel.Controls.Add(Me.requestDescLbl)
        Me.requestPanel.Controls.Add(Me.Button1)
        Me.requestPanel.Controls.Add(Me.requestLbl)
        Me.requestPanel.Location = New System.Drawing.Point(1131, 359)
        Me.requestPanel.Name = "requestPanel"
        Me.requestPanel.Size = New System.Drawing.Size(532, 571)
        Me.requestPanel.TabIndex = 3
        '
        'passwordLbl
        '
        Me.passwordLbl.AutoSize = True
        Me.passwordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLbl.Location = New System.Drawing.Point(69, 353)
        Me.passwordLbl.Name = "passwordLbl"
        Me.passwordLbl.Size = New System.Drawing.Size(78, 20)
        Me.passwordLbl.TabIndex = 27
        Me.passwordLbl.Text = "Password"
        Me.passwordLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'newEmailLbl
        '
        Me.newEmailLbl.AutoSize = True
        Me.newEmailLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newEmailLbl.Location = New System.Drawing.Point(69, 237)
        Me.newEmailLbl.Name = "newEmailLbl"
        Me.newEmailLbl.Size = New System.Drawing.Size(81, 20)
        Me.newEmailLbl.TabIndex = 26
        Me.newEmailLbl.Text = "New email"
        Me.newEmailLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'currentEmailLbl
        '
        Me.currentEmailLbl.AutoSize = True
        Me.currentEmailLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentEmailLbl.Location = New System.Drawing.Point(66, 131)
        Me.currentEmailLbl.Name = "currentEmailLbl"
        Me.currentEmailLbl.Size = New System.Drawing.Size(103, 20)
        Me.currentEmailLbl.TabIndex = 25
        Me.currentEmailLbl.Text = "Current email"
        Me.currentEmailLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'passwordPanel
        '
        Me.passwordPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.passwordPanel.Controls.Add(Me.passwordTxtBox)
        Me.passwordPanel.Location = New System.Drawing.Point(101, 404)
        Me.passwordPanel.Name = "passwordPanel"
        Me.passwordPanel.Size = New System.Drawing.Size(361, 27)
        Me.passwordPanel.TabIndex = 23
        '
        'passwordTxtBox
        '
        Me.passwordTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.passwordTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.passwordTxtBox.Name = "passwordTxtBox"
        Me.passwordTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTxtBox.Size = New System.Drawing.Size(361, 22)
        Me.passwordTxtBox.TabIndex = 22
        '
        'newEmailPanel
        '
        Me.newEmailPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.newEmailPanel.Controls.Add(Me.newEmailTxtBox)
        Me.newEmailPanel.Location = New System.Drawing.Point(101, 286)
        Me.newEmailPanel.Name = "newEmailPanel"
        Me.newEmailPanel.Size = New System.Drawing.Size(361, 27)
        Me.newEmailPanel.TabIndex = 23
        '
        'newEmailTxtBox
        '
        Me.newEmailTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.newEmailTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newEmailTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.newEmailTxtBox.Name = "newEmailTxtBox"
        Me.newEmailTxtBox.Size = New System.Drawing.Size(361, 22)
        Me.newEmailTxtBox.TabIndex = 22
        '
        'currentEmailPanel
        '
        Me.currentEmailPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.currentEmailPanel.Controls.Add(Me.currentEmailTxtBox)
        Me.currentEmailPanel.Location = New System.Drawing.Point(101, 175)
        Me.currentEmailPanel.Name = "currentEmailPanel"
        Me.currentEmailPanel.Size = New System.Drawing.Size(361, 27)
        Me.currentEmailPanel.TabIndex = 23
        '
        'currentEmailTxtBox
        '
        Me.currentEmailTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.currentEmailTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentEmailTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.currentEmailTxtBox.Name = "currentEmailTxtBox"
        Me.currentEmailTxtBox.Size = New System.Drawing.Size(361, 22)
        Me.currentEmailTxtBox.TabIndex = 22
        '
        'requestDescLbl
        '
        Me.requestDescLbl.AutoSize = True
        Me.requestDescLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestDescLbl.Location = New System.Drawing.Point(69, 81)
        Me.requestDescLbl.Name = "requestDescLbl"
        Me.requestDescLbl.Size = New System.Drawing.Size(396, 20)
        Me.requestDescLbl.TabIndex = 24
        Me.requestDescLbl.Text = "Send a request to the admin in case of changing email."
        Me.requestDescLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(184, 477)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 39)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'requestLbl
        '
        Me.requestLbl.AutoSize = True
        Me.requestLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestLbl.Location = New System.Drawing.Point(199, 28)
        Me.requestLbl.Name = "requestLbl"
        Me.requestLbl.Size = New System.Drawing.Size(137, 29)
        Me.requestLbl.TabIndex = 22
        Me.requestLbl.Text = "REQUEST"
        '
        'joinClassPanel
        '
        Me.joinClassPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.joinClassPanel.Controls.Add(Me.joinTxtBoxPanel)
        Me.joinClassPanel.Controls.Add(Me.codeSubmitBttn)
        Me.joinClassPanel.Controls.Add(Me.joinDescLbl)
        Me.joinClassPanel.Controls.Add(Me.joinLabel)
        Me.joinClassPanel.Location = New System.Drawing.Point(1131, 41)
        Me.joinClassPanel.Name = "joinClassPanel"
        Me.joinClassPanel.Size = New System.Drawing.Size(532, 288)
        Me.joinClassPanel.TabIndex = 4
        '
        'joinTxtBoxPanel
        '
        Me.joinTxtBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.joinTxtBoxPanel.Controls.Add(Me.codeTxtBox)
        Me.joinTxtBoxPanel.Location = New System.Drawing.Point(90, 146)
        Me.joinTxtBoxPanel.Name = "joinTxtBoxPanel"
        Me.joinTxtBoxPanel.Size = New System.Drawing.Size(361, 27)
        Me.joinTxtBoxPanel.TabIndex = 5
        '
        'codeTxtBox
        '
        Me.codeTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.codeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.codeTxtBox.Name = "codeTxtBox"
        Me.codeTxtBox.Size = New System.Drawing.Size(361, 22)
        Me.codeTxtBox.TabIndex = 22
        '
        'codeSubmitBttn
        '
        Me.codeSubmitBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.codeSubmitBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.codeSubmitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.codeSubmitBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeSubmitBttn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.codeSubmitBttn.Location = New System.Drawing.Point(184, 214)
        Me.codeSubmitBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.codeSubmitBttn.Name = "codeSubmitBttn"
        Me.codeSubmitBttn.Size = New System.Drawing.Size(175, 39)
        Me.codeSubmitBttn.TabIndex = 23
        Me.codeSubmitBttn.Text = "SUBMIT"
        Me.codeSubmitBttn.UseVisualStyleBackColor = False
        '
        'joinDescLbl
        '
        Me.joinDescLbl.AutoSize = True
        Me.joinDescLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.joinDescLbl.Location = New System.Drawing.Point(112, 90)
        Me.joinDescLbl.Name = "joinDescLbl"
        Me.joinDescLbl.Size = New System.Drawing.Size(309, 20)
        Me.joinDescLbl.TabIndex = 21
        Me.joinDescLbl.Text = "Enter a class code to join an existing class."
        '
        'joinLabel
        '
        Me.joinLabel.AutoSize = True
        Me.joinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.joinLabel.Location = New System.Drawing.Point(189, 23)
        Me.joinLabel.Name = "joinLabel"
        Me.joinLabel.Size = New System.Drawing.Size(161, 29)
        Me.joinLabel.TabIndex = 21
        Me.joinLabel.Text = "JOIN CLASS"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.joinClassPanel)
        Me.Controls.Add(Me.requestPanel)
        Me.Controls.Add(Me.accessPanel)
        Me.Controls.Add(Me.introPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1681, 978)
        Me.MinimumSize = New System.Drawing.Size(1681, 978)
        Me.Name = "Home"
        Me.Size = New System.Drawing.Size(1681, 978)
        Me.introPanel.ResumeLayout(False)
        Me.introPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.accessPanel.ResumeLayout(False)
        Me.requestPanel.ResumeLayout(False)
        Me.requestPanel.PerformLayout()
        Me.passwordPanel.ResumeLayout(False)
        Me.passwordPanel.PerformLayout()
        Me.newEmailPanel.ResumeLayout(False)
        Me.newEmailPanel.PerformLayout()
        Me.currentEmailPanel.ResumeLayout(False)
        Me.currentEmailPanel.PerformLayout()
        Me.joinClassPanel.ResumeLayout(False)
        Me.joinClassPanel.PerformLayout()
        Me.joinTxtBoxPanel.ResumeLayout(False)
        Me.joinTxtBoxPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents introPanel As Panel
    Friend WithEvents accessPanel As Panel
    Friend WithEvents requestPanel As Panel
    Friend WithEvents joinClassPanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents descLabel As Label
    Friend WithEvents studentButton As Button
    Friend WithEvents adminButton As Button
    Friend WithEvents officerButton As Button
    Friend WithEvents userAccessLevel As Label
    Friend WithEvents accesslevlLbl As Label
    Friend WithEvents profButton As Button
    Friend WithEvents requestLbl As Label
    Friend WithEvents joinLabel As Label
    Friend WithEvents codeTxtBox As TextBox
    Friend WithEvents joinDescLbl As Label
    Friend WithEvents joinTxtBoxPanel As Panel
    Friend WithEvents codeSubmitBttn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents requestDescLbl As Label
    Friend WithEvents passwordPanel As Panel
    Friend WithEvents passwordTxtBox As TextBox
    Friend WithEvents newEmailPanel As Panel
    Friend WithEvents newEmailTxtBox As TextBox
    Friend WithEvents currentEmailPanel As Panel
    Friend WithEvents currentEmailTxtBox As TextBox
    Friend WithEvents passwordLbl As Label
    Friend WithEvents newEmailLbl As Label
    Friend WithEvents currentEmailLbl As Label
    Friend WithEvents AccessRoleadmin1 As AccessRoleadmin
    Friend WithEvents AccessRoleprof1 As AccessRoleprof
    Friend WithEvents AccessRoleofficer1 As AccessRoleofficer
    Friend WithEvents AccessRolestudent1 As AccessRolestudent
End Class
