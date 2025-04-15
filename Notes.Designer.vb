<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.notepanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.filterHeadPanel = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.subjectsFilterPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.textBoxPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.searchBttn = New FontAwesome.Sharp.IconButton()
        Me.NoteFormat1 = New CMS_Frontend.NoteFormat()
        Me.notepanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.filterHeadPanel.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.subjectsFilterPanel.SuspendLayout()
        Me.textBoxPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(52, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subjects"
        '
        'notepanel
        '
        Me.notepanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.notepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notepanel.Controls.Add(Me.TableLayoutPanel1)
        Me.notepanel.Location = New System.Drawing.Point(195, 87)
        Me.notepanel.Margin = New System.Windows.Forms.Padding(2)
        Me.notepanel.Name = "notepanel"
        Me.notepanel.Size = New System.Drawing.Size(1442, 866)
        Me.notepanel.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NoteFormat1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1440, 864)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'filterHeadPanel
        '
        Me.filterHeadPanel.Controls.Add(Me.IconPictureBox1)
        Me.filterHeadPanel.Controls.Add(Me.Label1)
        Me.filterHeadPanel.Location = New System.Drawing.Point(0, 0)
        Me.filterHeadPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.filterHeadPanel.Name = "filterHeadPanel"
        Me.filterHeadPanel.Size = New System.Drawing.Size(154, 36)
        Me.filterHeadPanel.TabIndex = 1
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 27
        Me.IconPictureBox1.Location = New System.Drawing.Point(18, 6)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(29, 27)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.filterHeadPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.subjectsFilterPanel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(19, 27)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(154, 926)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'subjectsFilterPanel
        '
        Me.subjectsFilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subjectsFilterPanel.Controls.Add(Me.RadioButton1)
        Me.subjectsFilterPanel.Location = New System.Drawing.Point(0, 36)
        Me.subjectsFilterPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.subjectsFilterPanel.Name = "subjectsFilterPanel"
        Me.subjectsFilterPanel.Size = New System.Drawing.Size(154, 889)
        Me.subjectsFilterPanel.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(10, 10)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(10, 10, 3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'textBoxPanel
        '
        Me.textBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.textBoxPanel.Controls.Add(Me.TextBox1)
        Me.textBoxPanel.Location = New System.Drawing.Point(196, 37)
        Me.textBoxPanel.Name = "textBoxPanel"
        Me.textBoxPanel.Size = New System.Drawing.Size(612, 24)
        Me.textBoxPanel.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(612, 19)
        Me.TextBox1.TabIndex = 2
        '
        'searchBttn
        '
        Me.searchBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.searchBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBttn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.searchBttn.IconColor = System.Drawing.Color.Black
        Me.searchBttn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchBttn.IconSize = 19
        Me.searchBttn.Location = New System.Drawing.Point(814, 37)
        Me.searchBttn.Name = "searchBttn"
        Me.searchBttn.Size = New System.Drawing.Size(24, 19)
        Me.searchBttn.TabIndex = 6
        Me.searchBttn.UseVisualStyleBackColor = False
        '
        'NoteFormat1
        '
        Me.NoteFormat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoteFormat1.Location = New System.Drawing.Point(2, 2)
        Me.NoteFormat1.Margin = New System.Windows.Forms.Padding(2)
        Me.NoteFormat1.Name = "NoteFormat1"
        Me.NoteFormat1.Size = New System.Drawing.Size(281, 73)
        Me.NoteFormat1.TabIndex = 0
        '
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.searchBttn)
        Me.Controls.Add(Me.textBoxPanel)
        Me.Controls.Add(Me.notepanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1681, 978)
        Me.MinimumSize = New System.Drawing.Size(1681, 978)
        Me.Name = "Notes"
        Me.Size = New System.Drawing.Size(1681, 978)
        Me.notepanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.filterHeadPanel.ResumeLayout(False)
        Me.filterHeadPanel.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.subjectsFilterPanel.ResumeLayout(False)
        Me.subjectsFilterPanel.PerformLayout()
        Me.textBoxPanel.ResumeLayout(False)
        Me.textBoxPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents notepanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents filterHeadPanel As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents subjectsFilterPanel As FlowLayoutPanel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents textBoxPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents searchBttn As FontAwesome.Sharp.IconButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NoteFormat1 As NoteFormat
End Class
