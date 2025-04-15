<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeStudentView
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
        Me.semesterLabel = New System.Windows.Forms.Label()
        Me.semesterComboBox = New System.Windows.Forms.ComboBox()
        Me.academivYearComboBox = New System.Windows.Forms.ComboBox()
        Me.academicLabel = New System.Windows.Forms.Label()
        Me.studentGradesDataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.studentGradesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'semesterLabel
        '
        Me.semesterLabel.AutoSize = True
        Me.semesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semesterLabel.Location = New System.Drawing.Point(99, 14)
        Me.semesterLabel.Name = "semesterLabel"
        Me.semesterLabel.Size = New System.Drawing.Size(72, 18)
        Me.semesterLabel.TabIndex = 6
        Me.semesterLabel.Text = "Semester"
        '
        'semesterComboBox
        '
        Me.semesterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semesterComboBox.FormattingEnabled = True
        Me.semesterComboBox.Location = New System.Drawing.Point(30, 44)
        Me.semesterComboBox.Name = "semesterComboBox"
        Me.semesterComboBox.Size = New System.Drawing.Size(215, 26)
        Me.semesterComboBox.TabIndex = 7
        '
        'academivYearComboBox
        '
        Me.academivYearComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.academivYearComboBox.FormattingEnabled = True
        Me.academivYearComboBox.Location = New System.Drawing.Point(302, 44)
        Me.academivYearComboBox.Name = "academivYearComboBox"
        Me.academivYearComboBox.Size = New System.Drawing.Size(215, 26)
        Me.academivYearComboBox.TabIndex = 8
        '
        'academicLabel
        '
        Me.academicLabel.AutoSize = True
        Me.academicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.academicLabel.Location = New System.Drawing.Point(358, 14)
        Me.academicLabel.Name = "academicLabel"
        Me.academicLabel.Size = New System.Drawing.Size(107, 18)
        Me.academicLabel.TabIndex = 9
        Me.academicLabel.Text = "Academic Year"
        '
        'studentGradesDataGrid
        '
        Me.studentGradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentGradesDataGrid.Location = New System.Drawing.Point(30, 89)
        Me.studentGradesDataGrid.Name = "studentGradesDataGrid"
        Me.studentGradesDataGrid.Size = New System.Drawing.Size(1549, 607)
        Me.studentGradesDataGrid.TabIndex = 10
        '
        'GradeStudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Controls.Add(Me.studentGradesDataGrid)
        Me.Controls.Add(Me.academicLabel)
        Me.Controls.Add(Me.academivYearComboBox)
        Me.Controls.Add(Me.semesterComboBox)
        Me.Controls.Add(Me.semesterLabel)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "GradeStudentView"
        Me.Size = New System.Drawing.Size(1606, 728)
        CType(Me.studentGradesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents semesterLabel As Label
    Friend WithEvents semesterComboBox As ComboBox
    Friend WithEvents academivYearComboBox As ComboBox
    Friend WithEvents academicLabel As Label
    Friend WithEvents studentGradesDataGrid As DataGridView
End Class
