<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoteUploadConfirmation
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TagLists = New System.Windows.Forms.ListBox()
        Me.subjectLbl = New System.Windows.Forms.Label()
        Me.cancelBttn = New System.Windows.Forms.Button()
        Me.subjectsComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.confirmBttn = New System.Windows.Forms.Button()
        Me.sendButton = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Note Upload"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(68, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tag/s:"
        '
        'TagLists
        '
        Me.TagLists.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagLists.FormattingEnabled = True
        Me.TagLists.ItemHeight = 16
        Me.TagLists.Location = New System.Drawing.Point(31, 103)
        Me.TagLists.Name = "TagLists"
        Me.TagLists.Size = New System.Drawing.Size(383, 20)
        Me.TagLists.TabIndex = 3
        '
        'subjectLbl
        '
        Me.subjectLbl.AutoSize = True
        Me.subjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectLbl.Location = New System.Drawing.Point(14, 147)
        Me.subjectLbl.Name = "subjectLbl"
        Me.subjectLbl.Size = New System.Drawing.Size(61, 18)
        Me.subjectLbl.TabIndex = 4
        Me.subjectLbl.Text = "Subject:"
        '
        'cancelBttn
        '
        Me.cancelBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cancelBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.cancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelBttn.Location = New System.Drawing.Point(54, 13)
        Me.cancelBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.cancelBttn.Name = "cancelBttn"
        Me.cancelBttn.Size = New System.Drawing.Size(120, 37)
        Me.cancelBttn.TabIndex = 9
        Me.cancelBttn.Text = "Cancel"
        Me.cancelBttn.UseVisualStyleBackColor = False
        '
        'subjectsComboBox
        '
        Me.subjectsComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectsComboBox.FormattingEnabled = True
        Me.subjectsComboBox.Location = New System.Drawing.Point(90, 145)
        Me.subjectsComboBox.Name = "subjectsComboBox"
        Me.subjectsComboBox.Size = New System.Drawing.Size(137, 24)
        Me.subjectsComboBox.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.confirmBttn)
        Me.Panel2.Controls.Add(Me.cancelBttn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 62)
        Me.Panel2.TabIndex = 11
        '
        'confirmBttn
        '
        Me.confirmBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.confirmBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.confirmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.confirmBttn.Location = New System.Drawing.Point(291, 13)
        Me.confirmBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.confirmBttn.Name = "confirmBttn"
        Me.confirmBttn.Size = New System.Drawing.Size(123, 37)
        Me.confirmBttn.TabIndex = 10
        Me.confirmBttn.Text = "Confirm"
        Me.confirmBttn.UseVisualStyleBackColor = False
        '
        'sendButton
        '
        Me.sendButton.FlatAppearance.BorderSize = 0
        Me.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendButton.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.sendButton.IconColor = System.Drawing.Color.Black
        Me.sendButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.sendButton.IconSize = 30
        Me.sendButton.Location = New System.Drawing.Point(350, 57)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(33, 33)
        Me.sendButton.TabIndex = 12
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'NoteUploadConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.subjectsComboBox)
        Me.Controls.Add(Me.subjectLbl)
        Me.Controls.Add(Me.TagLists)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NoteUploadConfirmation"
        Me.Size = New System.Drawing.Size(472, 248)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TagLists As ListBox
    Friend WithEvents subjectLbl As Label
    Friend WithEvents cancelBttn As Button
    Friend WithEvents subjectsComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents confirmBttn As Button
    Friend WithEvents sendButton As FontAwesome.Sharp.IconButton
End Class
