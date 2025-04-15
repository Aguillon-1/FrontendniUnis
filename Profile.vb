Public Class Profile

    Dim changeprofile As Boolean = True

    Public Sub New()

        InitializeComponent()
        changeProfilePanel.Hide()

    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        profilechangeTimer.Start()
    End Sub

    Private Sub profilechangeTimer_Tick(sender As Object, e As EventArgs) Handles profilechangeTimer.Tick
        If (changeprofile = True) Then
            changeProfilePanel.Height += 20
            changeProfilePanel.Show()
            If (changeProfilePanel.Height >= changeProfilePanel.MaximumSize.Height) Then
                changeprofile = False
                profilechangeTimer.Stop()

            End If
        Else
            changeProfilePanel.Height -= 20
            If (changeProfilePanel.Height <= changeProfilePanel.MinimumSize.Height) Then
                changeProfilePanel.Hide()
                changeprofile = True
                profilechangeTimer.Stop()
            End If

        End If
    End Sub

    Private Sub closeChangeProfile_Click(sender As Object, e As EventArgs) Handles closeChangeProfile.Click
        profilechangeTimer.Start()
    End Sub

    Private Sub Profile_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
    End Sub
End Class