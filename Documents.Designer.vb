<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Documents
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.documentPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DocumentFormat1 = New CMS_Frontend.DocumentFormat()
        Me.textBoxPanel = New System.Windows.Forms.Panel()
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.previewPanel = New System.Windows.Forms.Panel()
        Me.addDocPanel = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconPreview = New FontAwesome.Sharp.IconPictureBox()
        Me.previewLbl = New System.Windows.Forms.Label()
        Me.searchBttn = New FontAwesome.Sharp.IconButton()
        Me.addDocButton = New FontAwesome.Sharp.IconButton()
        Me.documentPanel.SuspendLayout()
        Me.textBoxPanel.SuspendLayout()
        Me.previewPanel.SuspendLayout()
        Me.addDocPanel.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'documentPanel
        '
        Me.documentPanel.AutoScroll = True
        Me.documentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.documentPanel.Controls.Add(Me.DocumentFormat1)
        Me.documentPanel.Location = New System.Drawing.Point(51, 117)
        Me.documentPanel.MaximumSize = New System.Drawing.Size(1582, 769)
        Me.documentPanel.MinimumSize = New System.Drawing.Size(787, 769)
        Me.documentPanel.Name = "documentPanel"
        Me.documentPanel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.documentPanel.Size = New System.Drawing.Size(787, 769)
        Me.documentPanel.TabIndex = 0
        '
        'DocumentFormat1
        '
        Me.DocumentFormat1.BackColor = System.Drawing.Color.White
        Me.DocumentFormat1.Location = New System.Drawing.Point(25, 15)
        Me.DocumentFormat1.Margin = New System.Windows.Forms.Padding(15)
        Me.DocumentFormat1.Name = "DocumentFormat1"
        Me.DocumentFormat1.Size = New System.Drawing.Size(350, 119)
        Me.DocumentFormat1.TabIndex = 4
        '
        'textBoxPanel
        '
        Me.textBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.textBoxPanel.Controls.Add(Me.searchTxtBox)
        Me.textBoxPanel.Location = New System.Drawing.Point(51, 47)
        Me.textBoxPanel.Name = "textBoxPanel"
        Me.textBoxPanel.Size = New System.Drawing.Size(612, 24)
        Me.textBoxPanel.TabIndex = 6
        '
        'searchTxtBox
        '
        Me.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(612, 19)
        Me.searchTxtBox.TabIndex = 2
        '
        'previewPanel
        '
        Me.previewPanel.BackColor = System.Drawing.Color.White
        Me.previewPanel.Controls.Add(Me.addDocPanel)
        Me.previewPanel.Controls.Add(Me.iconPreview)
        Me.previewPanel.Controls.Add(Me.previewLbl)
        Me.previewPanel.Location = New System.Drawing.Point(864, 117)
        Me.previewPanel.Name = "previewPanel"
        Me.previewPanel.Size = New System.Drawing.Size(769, 769)
        Me.previewPanel.TabIndex = 8
        '
        'addDocPanel
        '
        Me.addDocPanel.AllowDrop = True
        Me.addDocPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addDocPanel.Controls.Add(Me.IconPictureBox1)
        Me.addDocPanel.Controls.Add(Me.Label1)
        Me.addDocPanel.Location = New System.Drawing.Point(3, 3)
        Me.addDocPanel.Name = "addDocPanel"
        Me.addDocPanel.Size = New System.Drawing.Size(763, 763)
        Me.addDocPanel.TabIndex = 0
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 82
        Me.IconPictureBox1.Location = New System.Drawing.Point(330, 325)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(128, 82)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(311, 422)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Drop files here to add."
        '
        'iconPreview
        '
        Me.iconPreview.BackColor = System.Drawing.Color.White
        Me.iconPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.iconPreview.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.iconPreview.IconColor = System.Drawing.SystemColors.ControlDarkDark
        Me.iconPreview.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconPreview.IconSize = 82
        Me.iconPreview.Location = New System.Drawing.Point(333, 287)
        Me.iconPreview.Name = "iconPreview"
        Me.iconPreview.Size = New System.Drawing.Size(128, 82)
        Me.iconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.iconPreview.TabIndex = 2
        Me.iconPreview.TabStop = False
        '
        'previewLbl
        '
        Me.previewLbl.AutoSize = True
        Me.previewLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previewLbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.previewLbl.Location = New System.Drawing.Point(301, 391)
        Me.previewLbl.Name = "previewLbl"
        Me.previewLbl.Size = New System.Drawing.Size(187, 20)
        Me.previewLbl.TabIndex = 2
        Me.previewLbl.Text = "Preview of the document."
        '
        'searchBttn
        '
        Me.searchBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.searchBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBttn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.searchBttn.IconColor = System.Drawing.Color.Black
        Me.searchBttn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchBttn.IconSize = 19
        Me.searchBttn.Location = New System.Drawing.Point(679, 46)
        Me.searchBttn.Name = "searchBttn"
        Me.searchBttn.Size = New System.Drawing.Size(24, 19)
        Me.searchBttn.TabIndex = 7
        Me.searchBttn.UseVisualStyleBackColor = False
        '
        'addDocButton
        '
        Me.addDocButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.addDocButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.addDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addDocButton.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.addDocButton.IconColor = System.Drawing.Color.Black
        Me.addDocButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addDocButton.Location = New System.Drawing.Point(1549, 16)
        Me.addDocButton.Name = "addDocButton"
        Me.addDocButton.Size = New System.Drawing.Size(84, 79)
        Me.addDocButton.TabIndex = 7
        Me.addDocButton.UseVisualStyleBackColor = False
        '
        'Documents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.previewPanel)
        Me.Controls.Add(Me.searchBttn)
        Me.Controls.Add(Me.addDocButton)
        Me.Controls.Add(Me.textBoxPanel)
        Me.Controls.Add(Me.documentPanel)
        Me.Name = "Documents"
        Me.Size = New System.Drawing.Size(1681, 978)
        Me.documentPanel.ResumeLayout(False)
        Me.textBoxPanel.ResumeLayout(False)
        Me.textBoxPanel.PerformLayout()
        Me.previewPanel.ResumeLayout(False)
        Me.previewPanel.PerformLayout()
        Me.addDocPanel.ResumeLayout(False)
        Me.addDocPanel.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents documentPanel As FlowLayoutPanel
    Friend WithEvents textBoxPanel As Panel
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents searchBttn As FontAwesome.Sharp.IconButton
    Friend WithEvents addDocButton As FontAwesome.Sharp.IconButton
    Friend WithEvents previewPanel As Panel
    Friend WithEvents DocumentFormat1 As DocumentFormat
    Friend WithEvents addDocPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPreview As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents previewLbl As Label
End Class
