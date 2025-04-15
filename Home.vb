Public Class Home
    Public Sub New()

        InitializeComponent()
        joinTxtBoxPanel.BackColor = Color.Transparent
        currentEmailPanel.BackColor = Color.Transparent
        newEmailPanel.BackColor = Color.Transparent
        passwordPanel.BackColor = Color.Transparent
        AccessRolestudent1.BringToFront()

    End Sub

    Private Sub codeTxtBox_MouseHover(sender As Object, e As EventArgs) Handles codeTxtBox.MouseHover
        joinTxtBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub

    Private Sub codeTxtBox_MouseLeave(sender As Object, e As EventArgs) Handles codeTxtBox.MouseLeave
        joinTxtBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub currentEmailTxtBox_MouseEnter(sender As Object, e As EventArgs) Handles currentEmailTxtBox.MouseEnter
        currentEmailPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub

    Private Sub currentEmailTxtBox_MouseHover(sender As Object, e As EventArgs) Handles currentEmailTxtBox.MouseHover
        currentEmailPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub

    Private Sub currentEmailTxtBox_MouseLeave(sender As Object, e As EventArgs) Handles currentEmailTxtBox.MouseLeave
        currentEmailPanel.BackColor = Color.Transparent
    End Sub

    Private Sub newEmailTxtBox_MouseHover(sender As Object, e As EventArgs) Handles newEmailTxtBox.MouseHover
        newEmailPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub

    Private Sub newEmailTxtBox_MouseLeave(sender As Object, e As EventArgs) Handles newEmailTxtBox.MouseLeave
        newEmailPanel.BackColor = Color.Transparent
    End Sub

    Private Sub passwordTxtBox_MouseHover(sender As Object, e As EventArgs) Handles passwordTxtBox.MouseHover
        passwordPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub

    Private Sub passwordTxtBox_MouseLeave(sender As Object, e As EventArgs) Handles passwordTxtBox.MouseLeave
        passwordPanel.BackColor = Color.Transparent
    End Sub

    Private Sub studentButton_Click(sender As Object, e As EventArgs) Handles studentButton.Click
        AccessRolestudent1.BringToFront()
        studentButton.BackgroundImage = My.Resources.buttonBackGround
        officerButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        profButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        adminButton.BackgroundImage = My.Resources.buttonBackgroundHighlight

        studentButton.ForeColor = SystemColors.ButtonHighlight
        officerButton.ForeColor = SystemColors.ControlDarkDark
        adminButton.ForeColor = SystemColors.ControlDarkDark
        profButton.ForeColor = SystemColors.ControlDarkDark
    End Sub

    Private Sub officerButton_Click(sender As Object, e As EventArgs) Handles officerButton.Click
        AccessRoleofficer1.BringToFront()
        officerButton.BackgroundImage = My.Resources.buttonBackGround
        profButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        adminButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        studentButton.BackgroundImage = My.Resources.buttonBackgroundHighlight

        officerButton.ForeColor = SystemColors.ButtonHighlight
        studentButton.ForeColor = SystemColors.ControlDarkDark
        adminButton.ForeColor = SystemColors.ControlDarkDark
        profButton.ForeColor = SystemColors.ControlDarkDark
    End Sub

    Private Sub profButton_Click(sender As Object, e As EventArgs) Handles profButton.Click
        AccessRoleprof1.BringToFront()
        profButton.BackgroundImage = My.Resources.buttonBackGround
        studentButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        officerButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        adminButton.BackgroundImage = My.Resources.buttonBackgroundHighlight

        profButton.ForeColor = SystemColors.ButtonHighlight
        officerButton.ForeColor = SystemColors.ControlDarkDark
        adminButton.ForeColor = SystemColors.ControlDarkDark
        studentButton.ForeColor = SystemColors.ControlDarkDark
    End Sub

    Private Sub adminButton_Click(sender As Object, e As EventArgs) Handles adminButton.Click
        AccessRoleadmin1.BringToFront()
        adminButton.BackgroundImage = My.Resources.buttonBackGround
        studentButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        officerButton.BackgroundImage = My.Resources.buttonBackgroundHighlight
        profButton.BackgroundImage = My.Resources.buttonBackgroundHighlight

        adminButton.ForeColor = SystemColors.ButtonHighlight
        officerButton.ForeColor = SystemColors.ControlDarkDark
        studentButton.ForeColor = SystemColors.ControlDarkDark
        profButton.ForeColor = SystemColors.ControlDarkDark
    End Sub
End Class
