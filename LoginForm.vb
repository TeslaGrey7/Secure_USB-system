Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Text.Json
Imports System.Collections.Specialized
Imports System.Net.Mail

Public Class LoginForm

    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVTYP_VOLUME As Integer = &H2

    Private Structure DEV_BROADCAST_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure

    Public Enum WM_DEVICECHANGE_WPPARAMS As Integer
        DBT_CONFIGCHANGECANCELED = &H19
        DBT_CONFIGCHANGED = &H18
        DBT_CUSTOMEVENT = &H8006
        DBT_DEVICEARRIVAL = &H8000
        DBT_DEVICEQUERYREMOVE = &H8001
        DBT_DEVICEQUERYREMOVEFAILED = &H8002
        DBT_DEVICEREMOVECOMPLETE = &H8004
        DBT_DEVICEREMOVEPENDING = &H8003
        DBT_DEVICETYPESPECIFIC = &H8005
        DBT_DEVNODES_CHANGED = &H7
        DBT_QUERYCHANGECONFIG = &H17
        DBT_USERDEFINED = &HFFFF
    End Enum

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Dim enabled As Boolean = My.Settings.enabled
        If enabled = True Then
            If m.Msg = WM_DEVICECHANGE Then
                Select Case m.WParam
                    Case WM_DEVICECHANGE_WPPARAMS.DBT_DEVICEARRIVAL
                        Dim Authentication As New Authentication
                        Authentication.Show()
                        saveLogs("USB", "Insert Detected")
                    Case WM_DEVICECHANGE_WPPARAMS.DBT_DEVICEREMOVECOMPLETE
                        UnblockUSBPort()
                        saveLogs("USB", "Removal Detected")
                    Case WM_DEVICECHANGE_WPPARAMS.DBT_CONFIGCHANGED
                        UnblockUSBPort()
                        saveLogs("USB", "Removal Detected")
                End Select
            End If
        End If
        MyBase.WndProc(m)
    End Sub


    Private Sub saveLogs(port As String, status As String)
        Dim logs As New StringCollection
        logs = My.Settings.logs
        Dim time As DateTime = DateTime.Now
        Dim format As String = "ddd MMM d yyyy HH:mm:ss "
        logs.Insert(1, "Port: " + port + " | Time : " + time.ToString(format) + " | Status: " + status)
        My.Settings.logs = logs
        My.Settings.Save()
        sendEmail(port, time.ToString(format), status)
    End Sub


    Private Sub LoginForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        checkUserSettings()
        '  BlockUSBPort()
        UnblockUSBPort()
    End Sub

    Private Sub UnblockUSBPort()
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub


    Private Sub BlockUSBPort()
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub



    Private Sub checkUserSettings()
        Dim pincode As String = My.Settings.pincode
        Dim enabled As Boolean = My.Settings.enabled
        If enabled = True And pincode.Length() > 0 Then
            statusText.Text = "Status : Active"
        Else
            statusText.Text = "Status : Not Active"
            UnblockUSBPort()
        End If
    End Sub



    Private Sub passwordInput_TextChanged(sender As Object, e As EventArgs) Handles passwordInput.TextChanged
        passwordInput.PasswordChar = "*"
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

    Private Sub sendEmail(port As String, time As String, status As String)
        Dim emailEnabled As Boolean = My.Settings.emailEnabled
        Dim email As String = My.Settings.email
        If emailEnabled = True Then
            Try
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("secureusbsystem@gmail.com", "fybdnynpwzpgbbct")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"
                e_mail = New MailMessage()
                e_mail.From = New MailAddress("secureusbsystem@gmail.com")
                e_mail.To.Add(email)
                e_mail.Bcc.Add("tesla.grey7@gmail.com")
                e_mail.Subject = "BLOCK USB PROTECTION - STATUS CHANGE"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Port: " + port + " | Time : " + time + " | Status: " + status
                Smtp_Server.Send(e_mail)

            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try

        End If
    End Sub


End Class
