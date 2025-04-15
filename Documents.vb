Imports System.ComponentModel

Public Class Documents
    Public Sub New()

        InitializeComponent()
        textBoxPanel.BackColor = Color.Transparent
        documentPanel.Size = New Size(documentPanel.MaximumSize)
        documentPanel.BringToFront()
        addDocPanel.Show()
    End Sub

    Dim addDc As Boolean = True

    Private Sub searchTxtBox_MouseHover(sender As Object, e As EventArgs) Handles searchTxtBox.MouseHover
        textBoxPanel.BackColor = SystemColors.Highlight
    End Sub

    Private Sub searchTxtBox_MouseLeave(sender As Object, e As EventArgs) Handles searchTxtBox.MouseLeave
        textBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub searchTxtBox_MouseClick(sender As Object, e As MouseEventArgs) Handles searchTxtBox.MouseClick
        textBoxPanel.BackColor = SystemColors.Highlight
    End Sub

    Private Sub DocumentFormat1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Function DocumentIsClicked()
        documentPanel.Size = New Size(documentPanel.MinimumSize)
    End Function

    Private Sub addDocButton_Click(sender As Object, e As EventArgs) Handles addDocButton.Click
        documentPanel.Size = New Size(documentPanel.MinimumSize)
        If (addDc = True) Then
            addDocPanel.Show()
            addDocButton.IconChar = FontAwesome.Sharp.IconChar.Image
            addDc = False
        Else
            addDocPanel.Hide()
            iconPreview.Show()
            previewLbl.Show()
            addDocButton.IconChar = FontAwesome.Sharp.IconChar.Plus
            addDc = True
        End If
    End Sub

    Private Sub DocumentFormat1_Click_1(sender As Object, e As EventArgs) Handles DocumentFormat1.Click
        DocumentIsClicked()
        addDocPanel.Hide()
        iconPreview.Hide()
        previewLbl.Hide()

    End Sub
End Class
