Public Class Dashboard


    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        getUserSettings()
    End Sub
    Private Sub getUserSettings()
        Dim username As String = My.Settings.username
        Dim password As String = My.Settings.password
        Dim pincode As String = My.Settings.pincode
        Dim enabled As Boolean = My.Settings.enabled
        usernameInput.Text = username
        passwordInput.Text = password
        pincodeInput.Text = pincode
        enabledInput.Checked = enabled
    End Sub

    Private Sub saveUserSettings()
        Dim username As String = usernameInput.Text()
        Dim password As String = passwordInput.Text()
        Dim pincode As String = pincodeInput.Text()
        Dim enabled As Boolean = enabledInput.Checked()
        My.Settings.username = username
        My.Settings.password = password
        My.Settings.pincode = pincode
        My.Settings.enabled = enabled
        My.Settings.Save()
        MessageBox.Show("Settings saved!")
        getUserSettings()
    End Sub

    Private Sub saveSettingsAndExit(sender As Object, e As EventArgs) Handles saveSettings.Click
        saveUserSettings()
    End Sub

    Private Sub exitOnly(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

End Class