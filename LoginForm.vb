Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles usernameLabel.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles passwordLabel.Click

    End Sub

    Private Sub passwordInput_TextChanged(sender As Object, e As EventArgs) Handles passwordInput.TextChanged
        passwordInput.PasswordChar = "*"
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles masterLoginLabel.Click

    End Sub


    Private Sub login(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = usernameInput.Text
        Dim password As String = passwordInput.Text
        Dim username2 As String = My.Settings.username
        Dim password2 As String = My.Settings.password

        If username.Length() < 3 Then
            MessageBox.Show("Enter valid username")
        ElseIf password.Length() < 3 Then
            MessageBox.Show("Enter valid password")
        ElseIf String.Compare(username, "admin") = 0 And String.Compare(password, "adminpwd") = 0 Then
            MessageBox.Show("Successful Login")
            Dim Dashboard As New Dashboard
            Dashboard.Show()
            Me.Hide()
        ElseIf String.Compare(username, username2) = 0 And String.Compare(password, password2) = 0 Then
            MessageBox.Show("Successful Login")
            Dim Dashboard As New Dashboard
            Dashboard.Show()
            Me.Hide()
        Else MessageBox.Show("Invalid login credentials. Please try again!")
        End If


    End Sub


End Class
