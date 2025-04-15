<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Upload
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.postButton = New System.Windows.Forms.Button()
        Me.announcementRequestButton = New System.Windows.Forms.CheckBox()
        Me.fileListBox = New System.Windows.Forms.ListBox()
        Me.dropFilePanel = New System.Windows.Forms.Panel()
        Me.dropFileLbl = New System.Windows.Forms.Label()
        Me.chooseFileBttn = New System.Windows.Forms.Button()
        Me.fileLbl = New System.Windows.Forms.Label()
        Me.descTxtBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DescLbl = New System.Windows.Forms.Label()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NoteUploadConfirmation1 = New CMS_Frontend.NoteUploadConfirmation()
        Me.Panel1.SuspendLayout()
        Me.dropFilePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.postButton)
        Me.Panel1.Controls.Add(Me.announcementRequestButton)
        Me.Panel1.Controls.Add(Me.fileListBox)
        Me.Panel1.Controls.Add(Me.dropFilePanel)
        Me.Panel1.Controls.Add(Me.chooseFileBttn)
        Me.Panel1.Controls.Add(Me.fileLbl)
        Me.Panel1.Controls.Add(Me.descTxtBox)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DescLbl)
        Me.Panel1.Controls.Add(Me.titleLbl)
        Me.Panel1.Location = New System.Drawing.Point(2, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 968)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "POST DETAILS"
        '
        'postButton
        '
        Me.postButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.postButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.postButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.postButton.Location = New System.Drawing.Point(261, 894)
        Me.postButton.Margin = New System.Windows.Forms.Padding(2)
        Me.postButton.Name = "postButton"
        Me.postButton.Size = New System.Drawing.Size(136, 43)
        Me.postButton.TabIndex = 8
        Me.postButton.Text = "POST"
        Me.postButton.UseVisualStyleBackColor = False
        '
        'announcementRequestButton
        '
        Me.announcementRequestButton.AutoSize = True
        Me.announcementRequestButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.announcementRequestButton.Location = New System.Drawing.Point(220, 850)
        Me.announcementRequestButton.Margin = New System.Windows.Forms.Padding(2)
        Me.announcementRequestButton.Name = "announcementRequestButton"
        Me.announcementRequestButton.Size = New System.Drawing.Size(212, 24)
        Me.announcementRequestButton.TabIndex = 7
        Me.announcementRequestButton.Text = "Make it an announcement"
        Me.announcementRequestButton.UseVisualStyleBackColor = True
        '
        'fileListBox
        '
        Me.fileListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileListBox.FormattingEnabled = True
        Me.fileListBox.ItemHeight = 16
        Me.fileListBox.Location = New System.Drawing.Point(31, 535)
        Me.fileListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.fileListBox.Name = "fileListBox"
        Me.fileListBox.Size = New System.Drawing.Size(243, 292)
        Me.fileListBox.TabIndex = 0
        '
        'dropFilePanel
        '
        Me.dropFilePanel.AllowDrop = True
        Me.dropFilePanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dropFilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dropFilePanel.Controls.Add(Me.dropFileLbl)
        Me.dropFilePanel.Location = New System.Drawing.Point(283, 492)
        Me.dropFilePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.dropFilePanel.Name = "dropFilePanel"
        Me.dropFilePanel.Size = New System.Drawing.Size(363, 335)
        Me.dropFilePanel.TabIndex = 6
        '
        'dropFileLbl
        '
        Me.dropFileLbl.AutoSize = True
        Me.dropFileLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropFileLbl.Location = New System.Drawing.Point(125, 146)
        Me.dropFileLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dropFileLbl.Name = "dropFileLbl"
        Me.dropFileLbl.Size = New System.Drawing.Size(105, 18)
        Me.dropFileLbl.TabIndex = 0
        Me.dropFileLbl.Text = "Or drop a file..."
        '
        'chooseFileBttn
        '
        Me.chooseFileBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.chooseFileBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.chooseFileBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chooseFileBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chooseFileBttn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chooseFileBttn.Location = New System.Drawing.Point(31, 492)
        Me.chooseFileBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.chooseFileBttn.Name = "chooseFileBttn"
        Me.chooseFileBttn.Size = New System.Drawing.Size(243, 39)
        Me.chooseFileBttn.TabIndex = 5
        Me.chooseFileBttn.Text = "Choose file/s"
        Me.chooseFileBttn.UseVisualStyleBackColor = False
        '
        'fileLbl
        '
        Me.fileLbl.AutoSize = True
        Me.fileLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileLbl.Location = New System.Drawing.Point(303, 450)
        Me.fileLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fileLbl.Name = "fileLbl"
        Me.fileLbl.Size = New System.Drawing.Size(34, 20)
        Me.fileLbl.TabIndex = 4
        Me.fileLbl.Text = "File"
        '
        'descTxtBox
        '
        Me.descTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descTxtBox.Location = New System.Drawing.Point(49, 177)
        Me.descTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.descTxtBox.Multiline = True
        Me.descTxtBox.Name = "descTxtBox"
        Me.descTxtBox.Size = New System.Drawing.Size(575, 253)
        Me.descTxtBox.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(116, 88)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(440, 22)
        Me.TextBox1.TabIndex = 2
        '
        'DescLbl
        '
        Me.DescLbl.AutoSize = True
        Me.DescLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLbl.Location = New System.Drawing.Point(292, 136)
        Me.DescLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DescLbl.Name = "DescLbl"
        Me.DescLbl.Size = New System.Drawing.Size(89, 20)
        Me.DescLbl.TabIndex = 1
        Me.DescLbl.Text = "Description"
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(312, 50)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(38, 20)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Title"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.NoteUploadConfirmation1)
        Me.Panel2.Location = New System.Drawing.Point(675, 13)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(991, 969)
        Me.Panel2.TabIndex = 1
        '
        'NoteUploadConfirmation1
        '
        Me.NoteUploadConfirmation1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NoteUploadConfirmation1.Location = New System.Drawing.Point(259, 409)
        Me.NoteUploadConfirmation1.Name = "NoteUploadConfirmation1"
        Me.NoteUploadConfirmation1.Size = New System.Drawing.Size(472, 248)
        Me.NoteUploadConfirmation1.TabIndex = 0
        '
        'Upload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1681, 978)
        Me.MinimumSize = New System.Drawing.Size(1681, 978)
        Me.Name = "Upload"
        Me.Size = New System.Drawing.Size(1681, 978)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.dropFilePanel.ResumeLayout(False)
        Me.dropFilePanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DescLbl As Label
    Friend WithEvents titleLbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents descTxtBox As TextBox
    Friend WithEvents dropFilePanel As Panel
    Friend WithEvents chooseFileBttn As Button
    Friend WithEvents fileLbl As Label
    Friend WithEvents postButton As Button
    Friend WithEvents announcementRequestButton As CheckBox
    Friend WithEvents fileListBox As ListBox
    Friend WithEvents dropFileLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NoteUploadConfirmation1 As NoteUploadConfirmation
End Class
