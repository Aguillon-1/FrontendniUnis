<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Me.components = New System.ComponentModel.Container()
        Me.userPicture = New CMS_Frontend.CircularPictureBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.changeProfilePanel = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.closeChangeProfile = New FontAwesome.Sharp.IconButton()
        Me.CircularPictureBox1 = New CMS_Frontend.CircularPictureBox()
        Me.chooseFileBttn = New System.Windows.Forms.Button()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.accessLbl = New System.Windows.Forms.Label()
        Me.nameOfUser = New System.Windows.Forms.Label()
        Me.accessRole = New System.Windows.Forms.Label()
        Me.editButton = New FontAwesome.Sharp.IconButton()
        Me.profilechangeTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.changeProfilePanel.SuspendLayout()
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userPicture
        '
        Me.userPicture.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.userPicture.Location = New System.Drawing.Point(67, 12)
        Me.userPicture.Name = "userPicture"
        Me.userPicture.Size = New System.Drawing.Size(100, 90)
        Me.userPicture.TabIndex = 0
        Me.userPicture.TabStop = False
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(45, 119)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(158, 18)
        Me.emailLabel.TabIndex = 1
        Me.emailLabel.Text = "username@gmail.com"
        '
        'changeProfilePanel
        '
        Me.changeProfilePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.changeProfilePanel.Controls.Add(Me.IconButton2)
        Me.changeProfilePanel.Controls.Add(Me.closeChangeProfile)
        Me.changeProfilePanel.Controls.Add(Me.CircularPictureBox1)
        Me.changeProfilePanel.Controls.Add(Me.chooseFileBttn)
        Me.changeProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.changeProfilePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.changeProfilePanel.MaximumSize = New System.Drawing.Size(247, 235)
        Me.changeProfilePanel.MinimumSize = New System.Drawing.Size(247, 10)
        Me.changeProfilePanel.Name = "changeProfilePanel"
        Me.changeProfilePanel.Size = New System.Drawing.Size(247, 10)
        Me.changeProfilePanel.TabIndex = 2
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 25
        Me.IconButton2.Location = New System.Drawing.Point(73, 186)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(95, 35)
        Me.IconButton2.TabIndex = 9
        Me.IconButton2.Text = "SAVE"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'closeChangeProfile
        '
        Me.closeChangeProfile.BackColor = System.Drawing.Color.Maroon
        Me.closeChangeProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeChangeProfile.IconChar = FontAwesome.Sharp.IconChar.X
        Me.closeChangeProfile.IconColor = System.Drawing.Color.White
        Me.closeChangeProfile.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeChangeProfile.IconSize = 25
        Me.closeChangeProfile.Location = New System.Drawing.Point(219, 0)
        Me.closeChangeProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.closeChangeProfile.Name = "closeChangeProfile"
        Me.closeChangeProfile.Size = New System.Drawing.Size(29, 26)
        Me.closeChangeProfile.TabIndex = 8
        Me.closeChangeProfile.UseVisualStyleBackColor = False
        '
        'CircularPictureBox1
        '
        Me.CircularPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularPictureBox1.Location = New System.Drawing.Point(61, 12)
        Me.CircularPictureBox1.Name = "CircularPictureBox1"
        Me.CircularPictureBox1.Size = New System.Drawing.Size(119, 105)
        Me.CircularPictureBox1.TabIndex = 7
        Me.CircularPictureBox1.TabStop = False
        '
        'chooseFileBttn
        '
        Me.chooseFileBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chooseFileBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.chooseFileBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chooseFileBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chooseFileBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chooseFileBttn.Location = New System.Drawing.Point(64, 135)
        Me.chooseFileBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.chooseFileBttn.Name = "chooseFileBttn"
        Me.chooseFileBttn.Size = New System.Drawing.Size(109, 31)
        Me.chooseFileBttn.TabIndex = 6
        Me.chooseFileBttn.Text = "Choose file/s"
        Me.chooseFileBttn.UseVisualStyleBackColor = False
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.Location = New System.Drawing.Point(10, 156)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(52, 18)
        Me.nameLbl.TabIndex = 3
        Me.nameLbl.Text = "Name:"
        '
        'accessLbl
        '
        Me.accessLbl.AutoSize = True
        Me.accessLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accessLbl.Location = New System.Drawing.Point(9, 194)
        Me.accessLbl.Name = "accessLbl"
        Me.accessLbl.Size = New System.Drawing.Size(61, 18)
        Me.accessLbl.TabIndex = 4
        Me.accessLbl.Text = "Access:"
        '
        'nameOfUser
        '
        Me.nameOfUser.AutoSize = True
        Me.nameOfUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameOfUser.Location = New System.Drawing.Point(70, 158)
        Me.nameOfUser.Name = "nameOfUser"
        Me.nameOfUser.Size = New System.Drawing.Size(137, 16)
        Me.nameOfUser.TabIndex = 5
        Me.nameOfUser.Text = "LastName, FirstName"
        '
        'accessRole
        '
        Me.accessRole.AutoSize = True
        Me.accessRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accessRole.Location = New System.Drawing.Point(74, 196)
        Me.accessRole.Name = "accessRole"
        Me.accessRole.Size = New System.Drawing.Size(52, 16)
        Me.accessRole.TabIndex = 6
        Me.accessRole.Text = "Student"
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatAppearance.BorderSize = 0
        Me.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editButton.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.editButton.IconColor = System.Drawing.Color.Black
        Me.editButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.editButton.IconSize = 30
        Me.editButton.Location = New System.Drawing.Point(156, 71)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(38, 36)
        Me.editButton.TabIndex = 7
        Me.editButton.UseVisualStyleBackColor = False
        '
        'profilechangeTimer
        '
        Me.profilechangeTimer.Interval = 50
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(247, 230)
        Me.Controls.Add(Me.changeProfilePanel)
        Me.Controls.Add(Me.userPicture)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.accessRole)
        Me.Controls.Add(Me.nameOfUser)
        Me.Controls.Add(Me.accessLbl)
        Me.Controls.Add(Me.nameLbl)
        Me.Controls.Add(Me.emailLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Profile"
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.changeProfilePanel.ResumeLayout(False)
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userPicture As CircularPictureBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents changeProfilePanel As Panel
    Friend WithEvents nameLbl As Label
    Friend WithEvents accessLbl As Label
    Friend WithEvents nameOfUser As Label
    Friend WithEvents accessRole As Label
    Friend WithEvents editButton As FontAwesome.Sharp.IconButton
    Friend WithEvents profilechangeTimer As Timer
    Friend WithEvents chooseFileBttn As Button
    Friend WithEvents CircularPictureBox1 As CircularPictureBox
    Friend WithEvents closeChangeProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
