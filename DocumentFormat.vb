Public Class DocumentFormat
    Private Sub DocumentFormat_Click(sender As Object, e As EventArgs) Handles MyBase.Click



    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim del = New Delete
        del.Show()
    End Sub
End Class
