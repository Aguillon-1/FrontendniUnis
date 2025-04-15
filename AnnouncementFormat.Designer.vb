<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnnouncementFormat
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
        Me.components = New System.ComponentModel.Container()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.positionLbl = New System.Windows.Forms.Label()
        Me.descPanel = New System.Windows.Forms.Panel()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.previewPanel = New System.Windows.Forms.Panel()
        Me.seeMoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.editButton = New FontAwesome.Sharp.IconButton()
        Me.deleteButton = New FontAwesome.Sharp.IconButton()
        Me.CircularPictureBox1 = New CMS_Frontend.CircularPictureBox()
        Me.descPanel.SuspendLayout()
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nameLabel.Location = New System.Drawing.Point(98, 33)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(41, 15)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Name"
        '
        'positionLbl
        '
        Me.positionLbl.AutoSize = True
        Me.positionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.positionLbl.Location = New System.Drawing.Point(98, 56)
        Me.positionLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.positionLbl.Name = "positionLbl"
        Me.positionLbl.Size = New System.Drawing.Size(51, 15)
        Me.positionLbl.TabIndex = 2
        Me.positionLbl.Text = "Position"
        '
        'descPanel
        '
        Me.descPanel.BackColor = System.Drawing.Color.Transparent
        Me.descPanel.Controls.Add(Me.descriptionTextBox)
        Me.descPanel.Location = New System.Drawing.Point(757, 104)
        Me.descPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.descPanel.Name = "descPanel"
        Me.descPanel.Size = New System.Drawing.Size(816, 548)
        Me.descPanel.TabIndex = 3
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descriptionTextBox.Enabled = False
        Me.descriptionTextBox.Location = New System.Drawing.Point(0, 0)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(816, 548)
        Me.descriptionTextBox.TabIndex = 0
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.titleLbl.Location = New System.Drawing.Point(724, 33)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(61, 24)
        Me.titleLbl.TabIndex = 4
        Me.titleLbl.Text = "TITLE"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'previewPanel
        '
        Me.previewPanel.Location = New System.Drawing.Point(40, 104)
        Me.previewPanel.Name = "previewPanel"
        Me.previewPanel.Size = New System.Drawing.Size(693, 548)
        Me.previewPanel.TabIndex = 6
        '
        'seeMoreTimer
        '
        Me.seeMoreTimer.Interval = 50
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatAppearance.BorderSize = 0
        Me.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editButton.ForeColor = System.Drawing.Color.DarkRed
        Me.editButton.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.editButton.IconColor = System.Drawing.SystemColors.InfoText
        Me.editButton.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.editButton.IconSize = 26
        Me.editButton.Location = New System.Drawing.Point(1535, 3)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(28, 27)
        Me.editButton.TabIndex = 12
        Me.editButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Transparent
        Me.deleteButton.FlatAppearance.BorderSize = 0
        Me.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.ForeColor = System.Drawing.Color.DarkRed
        Me.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.deleteButton.IconColor = System.Drawing.Color.DarkRed
        Me.deleteButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.deleteButton.IconSize = 23
        Me.deleteButton.Location = New System.Drawing.Point(1569, 3)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(28, 27)
        Me.deleteButton.TabIndex = 11
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'CircularPictureBox1
        '
        Me.CircularPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularPictureBox1.Location = New System.Drawing.Point(22, 17)
        Me.CircularPictureBox1.Name = "CircularPictureBox1"
        Me.CircularPictureBox1.Size = New System.Drawing.Size(71, 61)
        Me.CircularPictureBox1.TabIndex = 5
        Me.CircularPictureBox1.TabStop = False
        '
        'AnnouncementFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.previewPanel)
        Me.Controls.Add(Me.titleLbl)
        Me.Controls.Add(Me.CircularPictureBox1)
        Me.Controls.Add(Me.descPanel)
        Me.Controls.Add(Me.positionLbl)
        Me.Controls.Add(Me.nameLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1600, 686)
        Me.MinimumSize = New System.Drawing.Size(1600, 91)
        Me.Name = "AnnouncementFormat"
        Me.Size = New System.Drawing.Size(1600, 91)
        Me.descPanel.ResumeLayout(False)
        Me.descPanel.PerformLayout()
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As Label
    Friend WithEvents positionLbl As Label
    Friend WithEvents descPanel As Panel
    Friend WithEvents titleLbl As Label
    Friend WithEvents CircularPictureBox1 As CircularPictureBox
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents previewPanel As Panel
    Friend WithEvents seeMoreTimer As Timer
    Friend WithEvents deleteButton As FontAwesome.Sharp.IconButton
    Friend WithEvents editButton As FontAwesome.Sharp.IconButton
End Class
