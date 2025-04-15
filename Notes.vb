Public Class Notes
    Public Sub New()

        InitializeComponent()
        textBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        textBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub

    Private Sub Notes_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        textBoxPanel.BackColor = Color.Transparent
        Me.Hide()
    End Sub

    Private Sub TableLayoutPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel1.MouseClick
        textBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        textBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub
End Class
