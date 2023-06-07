Imports System.Collections.Specialized
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Win32

Public Class Authentication

    Private Sub Authentication_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub


    Private Sub checkPincode(sender As Object, e As EventArgs) Handles checkAuthBtn.Click
        Dim pincode As String = My.Settings.pincode
        Dim pincodeUserInput As String = pincodeInput.Text

        If String.Compare(pincode, pincodeUserInput) = 0 Then
            UnblockUSBPort()
            MessageBox.Show("Success! Port unblocked")
            saveLogs("USB", "Authentication SUCCESS, port unblocked")
            Me.Close()
        Else
            saveLogs("USB", "Authentication FAILURE, port blocked")
            MessageBox.Show("Incorrect Pin, please try again.")
        End If

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

    Private Sub UnblockUSBPort()
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub


    Private Sub BlockUSBPort()
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord)
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