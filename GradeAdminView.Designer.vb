<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeAdminView
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
        Me.sectionLabel = New System.Windows.Forms.Label()
        Me.sectionComboBox = New System.Windows.Forms.ComboBox()
        Me.semesterLabel = New System.Windows.Forms.Label()
        Me.semesterComboBox = New System.Windows.Forms.ComboBox()
        Me.academivYearComboBox = New System.Windows.Forms.ComboBox()
        Me.academicLabel = New System.Windows.Forms.Label()
        Me.studentGradesDataGrid = New System.Windows.Forms.DataGridView()
        Me.editGradeButton = New FontAwesome.Sharp.IconButton()
        Me.studentNameLbl = New System.Windows.Forms.Label()
        Me.StudentNameComboBox = New System.Windows.Forms.ComboBox()
        Me.editGradePanel = New System.Windows.Forms.Panel()
        Me.TxTBoxPanel = New System.Windows.Forms.Panel()
        Me.passwordTxtBox = New System.Windows.Forms.TextBox()
        Me.passwordLbl = New System.Windows.Forms.Label()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.updatedGradeComboBox = New System.Windows.Forms.ComboBox()
        Me.currentLbl = New System.Windows.Forms.Label()
        Me.currentGradeTxtBox = New System.Windows.Forms.TextBox()
        Me.updateLbl = New System.Windows.Forms.Label()
        Me.editSubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.editSubjectLbl = New System.Windows.Forms.Label()
        Me.editGardeLbl = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.studentGradesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.editGradePanel.SuspendLayout()
        Me.TxTBoxPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sectionLabel
        '
        Me.sectionLabel.AutoSize = True
        Me.sectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionLabel.Location = New System.Drawing.Point(125, 32)
        Me.sectionLabel.Name = "sectionLabel"
        Me.sectionLabel.Size = New System.Drawing.Size(58, 18)
        Me.sectionLabel.TabIndex = 7
        Me.sectionLabel.Text = "Section"
        '
        'sectionComboBox
        '
        Me.sectionComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionComboBox.FormattingEnabled = True
        Me.sectionComboBox.Location = New System.Drawing.Point(47, 65)
        Me.sectionComboBox.Name = "sectionComboBox"
        Me.sectionComboBox.Size = New System.Drawing.Size(215, 26)
        Me.sectionComboBox.TabIndex = 8
        '
        'semesterLabel
        '
        Me.semesterLabel.AutoSize = True
        Me.semesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semesterLabel.Location = New System.Drawing.Point(873, 32)
        Me.semesterLabel.Name = "semesterLabel"
        Me.semesterLabel.Size = New System.Drawing.Size(72, 18)
        Me.semesterLabel.TabIndex = 9
        Me.semesterLabel.Text = "Semester"
        '
        'semesterComboBox
        '
        Me.semesterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semesterComboBox.FormattingEnabled = True
        Me.semesterComboBox.Location = New System.Drawing.Point(809, 65)
        Me.semesterComboBox.Name = "semesterComboBox"
        Me.semesterComboBox.Size = New System.Drawing.Size(215, 26)
        Me.semesterComboBox.TabIndex = 10
        '
        'academivYearComboBox
        '
        Me.academivYearComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.academivYearComboBox.FormattingEnabled = True
        Me.academivYearComboBox.Location = New System.Drawing.Point(1111, 65)
        Me.academivYearComboBox.Name = "academivYearComboBox"
        Me.academivYearComboBox.Size = New System.Drawing.Size(215, 26)
        Me.academivYearComboBox.TabIndex = 11
        '
        'academicLabel
        '
        Me.academicLabel.AutoSize = True
        Me.academicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.academicLabel.Location = New System.Drawing.Point(1161, 32)
        Me.academicLabel.Name = "academicLabel"
        Me.academicLabel.Size = New System.Drawing.Size(107, 18)
        Me.academicLabel.TabIndex = 12
        Me.academicLabel.Text = "Academic Year"
        '
        'studentGradesDataGrid
        '
        Me.studentGradesDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.studentGradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentGradesDataGrid.Location = New System.Drawing.Point(44, 119)
        Me.studentGradesDataGrid.MaximumSize = New System.Drawing.Size(1523, 569)
        Me.studentGradesDataGrid.MinimumSize = New System.Drawing.Size(901, 569)
        Me.studentGradesDataGrid.Name = "studentGradesDataGrid"
        Me.studentGradesDataGrid.Size = New System.Drawing.Size(1523, 569)
        Me.studentGradesDataGrid.TabIndex = 13
        '
        'editGradeButton
        '
        Me.editGradeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.editGradeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.editGradeButton.FlatAppearance.BorderSize = 2
        Me.editGradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editGradeButton.IconChar = FontAwesome.Sharp.IconChar.SquarePen
        Me.editGradeButton.IconColor = System.Drawing.Color.Black
        Me.editGradeButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.editGradeButton.IconSize = 45
        Me.editGradeButton.Location = New System.Drawing.Point(1448, 32)
        Me.editGradeButton.Name = "editGradeButton"
        Me.editGradeButton.Size = New System.Drawing.Size(71, 68)
        Me.editGradeButton.TabIndex = 14
        Me.editGradeButton.UseVisualStyleBackColor = False
        '
        'studentNameLbl
        '
        Me.studentNameLbl.AutoSize = True
        Me.studentNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNameLbl.Location = New System.Drawing.Point(477, 32)
        Me.studentNameLbl.Name = "studentNameLbl"
        Me.studentNameLbl.Size = New System.Drawing.Size(102, 18)
        Me.studentNameLbl.TabIndex = 15
        Me.studentNameLbl.Text = "Student Name"
        '
        'StudentNameComboBox
        '
        Me.StudentNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNameComboBox.FormattingEnabled = True
        Me.StudentNameComboBox.Location = New System.Drawing.Point(322, 65)
        Me.StudentNameComboBox.Name = "StudentNameComboBox"
        Me.StudentNameComboBox.Size = New System.Drawing.Size(400, 26)
        Me.StudentNameComboBox.TabIndex = 16
        '
        'editGradePanel
        '
        Me.editGradePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.editGradePanel.Controls.Add(Me.TxTBoxPanel)
        Me.editGradePanel.Controls.Add(Me.passwordLbl)
        Me.editGradePanel.Controls.Add(Me.cancelButton)
        Me.editGradePanel.Controls.Add(Me.saveButton)
        Me.editGradePanel.Controls.Add(Me.Panel2)
        Me.editGradePanel.Controls.Add(Me.editSubjectComboBox)
        Me.editGradePanel.Controls.Add(Me.editSubjectLbl)
        Me.editGradePanel.Controls.Add(Me.editGardeLbl)
        Me.editGradePanel.Location = New System.Drawing.Point(528, 209)
        Me.editGradePanel.Name = "editGradePanel"
        Me.editGradePanel.Size = New System.Drawing.Size(578, 333)
        Me.editGradePanel.TabIndex = 17
        '
        'TxTBoxPanel
        '
        Me.TxTBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.TxTBoxPanel.Controls.Add(Me.passwordTxtBox)
        Me.TxTBoxPanel.Location = New System.Drawing.Point(122, 107)
        Me.TxTBoxPanel.Name = "TxTBoxPanel"
        Me.TxTBoxPanel.Size = New System.Drawing.Size(215, 24)
        Me.TxTBoxPanel.TabIndex = 29
        '
        'passwordTxtBox
        '
        Me.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.passwordTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.passwordTxtBox.Name = "passwordTxtBox"
        Me.passwordTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTxtBox.Size = New System.Drawing.Size(215, 19)
        Me.passwordTxtBox.TabIndex = 2
        '
        'passwordLbl
        '
        Me.passwordLbl.AutoSize = True
        Me.passwordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLbl.Location = New System.Drawing.Point(39, 109)
        Me.passwordLbl.Name = "passwordLbl"
        Me.passwordLbl.Size = New System.Drawing.Size(75, 18)
        Me.passwordLbl.TabIndex = 28
        Me.passwordLbl.Text = "Password"
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cancelButton.FlatAppearance.BorderSize = 2
        Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelButton.Location = New System.Drawing.Point(105, 263)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(115, 33)
        Me.cancelButton.TabIndex = 27
        Me.cancelButton.Text = "CANCEL"
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.saveButton.FlatAppearance.BorderSize = 2
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.saveButton.Location = New System.Drawing.Point(365, 263)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(115, 33)
        Me.saveButton.TabIndex = 26
        Me.saveButton.Text = "SAVE"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.updatedGradeComboBox)
        Me.Panel2.Controls.Add(Me.currentLbl)
        Me.Panel2.Controls.Add(Me.currentGradeTxtBox)
        Me.Panel2.Controls.Add(Me.updateLbl)
        Me.Panel2.Location = New System.Drawing.Point(33, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 88)
        Me.Panel2.TabIndex = 25
        '
        'updatedGradeComboBox
        '
        Me.updatedGradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatedGradeComboBox.FormattingEnabled = True
        Me.updatedGradeComboBox.Items.AddRange(New Object() {"1.00", "1.25", "1.50", "1.75", "2.00", "2.25", "2.50", "2.75", "3.00", "3.25", "3.50", "3.75", "4.00", "4.25", "4.50", "4.75", "5.00"})
        Me.updatedGradeComboBox.Location = New System.Drawing.Point(372, 50)
        Me.updatedGradeComboBox.Name = "updatedGradeComboBox"
        Me.updatedGradeComboBox.Size = New System.Drawing.Size(91, 26)
        Me.updatedGradeComboBox.TabIndex = 26
        '
        'currentLbl
        '
        Me.currentLbl.AutoSize = True
        Me.currentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentLbl.Location = New System.Drawing.Point(20, 53)
        Me.currentLbl.Name = "currentLbl"
        Me.currentLbl.Size = New System.Drawing.Size(61, 18)
        Me.currentLbl.TabIndex = 23
        Me.currentLbl.Text = "Current:"
        '
        'currentGradeTxtBox
        '
        Me.currentGradeTxtBox.Enabled = False
        Me.currentGradeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentGradeTxtBox.Location = New System.Drawing.Point(89, 50)
        Me.currentGradeTxtBox.Name = "currentGradeTxtBox"
        Me.currentGradeTxtBox.Size = New System.Drawing.Size(99, 24)
        Me.currentGradeTxtBox.TabIndex = 24
        '
        'updateLbl
        '
        Me.updateLbl.AutoSize = True
        Me.updateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateLbl.Location = New System.Drawing.Point(291, 53)
        Me.updateLbl.Name = "updateLbl"
        Me.updateLbl.Size = New System.Drawing.Size(59, 18)
        Me.updateLbl.TabIndex = 25
        Me.updateLbl.Text = "Update:"
        '
        'editSubjectComboBox
        '
        Me.editSubjectComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editSubjectComboBox.FormattingEnabled = True
        Me.editSubjectComboBox.Location = New System.Drawing.Point(122, 56)
        Me.editSubjectComboBox.Name = "editSubjectComboBox"
        Me.editSubjectComboBox.Size = New System.Drawing.Size(215, 26)
        Me.editSubjectComboBox.TabIndex = 21
        '
        'editSubjectLbl
        '
        Me.editSubjectLbl.AutoSize = True
        Me.editSubjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editSubjectLbl.Location = New System.Drawing.Point(57, 59)
        Me.editSubjectLbl.Name = "editSubjectLbl"
        Me.editSubjectLbl.Size = New System.Drawing.Size(57, 18)
        Me.editSubjectLbl.TabIndex = 20
        Me.editSubjectLbl.Text = "Subject"
        '
        'editGardeLbl
        '
        Me.editGardeLbl.AutoSize = True
        Me.editGardeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editGardeLbl.Location = New System.Drawing.Point(15, 12)
        Me.editGardeLbl.Name = "editGardeLbl"
        Me.editGardeLbl.Size = New System.Drawing.Size(99, 24)
        Me.editGardeLbl.TabIndex = 19
        Me.editGardeLbl.Text = "Edit Grade"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mid Term", "Final Term"})
        Me.ComboBox1.Location = New System.Drawing.Point(184, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'GradeAdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Controls.Add(Me.editGradePanel)
        Me.Controls.Add(Me.StudentNameComboBox)
        Me.Controls.Add(Me.studentNameLbl)
        Me.Controls.Add(Me.editGradeButton)
        Me.Controls.Add(Me.studentGradesDataGrid)
        Me.Controls.Add(Me.academicLabel)
        Me.Controls.Add(Me.academivYearComboBox)
        Me.Controls.Add(Me.semesterComboBox)
        Me.Controls.Add(Me.semesterLabel)
        Me.Controls.Add(Me.sectionComboBox)
        Me.Controls.Add(Me.sectionLabel)
        Me.Name = "GradeAdminView"
        Me.Size = New System.Drawing.Size(1606, 728)
        CType(Me.studentGradesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.editGradePanel.ResumeLayout(False)
        Me.editGradePanel.PerformLayout()
        Me.TxTBoxPanel.ResumeLayout(False)
        Me.TxTBoxPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sectionLabel As Label
    Friend WithEvents sectionComboBox As ComboBox
    Friend WithEvents semesterLabel As Label
    Friend WithEvents semesterComboBox As ComboBox
    Friend WithEvents academivYearComboBox As ComboBox
    Friend WithEvents academicLabel As Label
    Friend WithEvents studentGradesDataGrid As DataGridView
    Friend WithEvents editGradeButton As FontAwesome.Sharp.IconButton
    Friend WithEvents studentNameLbl As Label
    Friend WithEvents StudentNameComboBox As ComboBox
    Friend WithEvents editGradePanel As Panel
    Friend WithEvents editGardeLbl As Label
    Friend WithEvents editSubjectComboBox As ComboBox
    Friend WithEvents editSubjectLbl As Label
    Friend WithEvents currentLbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents currentGradeTxtBox As TextBox
    Friend WithEvents updatedGradeComboBox As ComboBox
    Friend WithEvents updateLbl As Label
    Friend WithEvents cancelButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents passwordLbl As Label
    Friend WithEvents TxTBoxPanel As Panel
    Friend WithEvents passwordTxtBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
