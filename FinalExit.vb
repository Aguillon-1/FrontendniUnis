Public Class FinalExit
    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        Application.Exit()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Hide()
    End Sub
End Class