Public Class GradeAdminView

    Public Sub New()

        InitializeComponent()
        editGradePanel.Hide()
        TxTBoxPanel.BackColor = Color.Transparent

    End Sub
    Private Sub editGradeButton_Click(sender As Object, e As EventArgs) Handles editGradeButton.Click
        editGradePanel.Show()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        editGradePanel.Hide()
    End Sub

    Private Sub passwordTxtBox_MouseEnter(sender As Object, e As EventArgs) Handles passwordTxtBox.MouseEnter
        TxTBoxPanel.BackColor = SystemColors.Highlight
    End Sub

    Private Sub passwordTxtBox_MouseLeave(sender As Object, e As EventArgs) Handles passwordTxtBox.MouseLeave
        TxTBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub passwordTxtBox_Click(sender As Object, e As EventArgs) Handles passwordTxtBox.Click
        TxTBoxPanel.BackColor = SystemColors.Highlight
    End Sub
End Class
