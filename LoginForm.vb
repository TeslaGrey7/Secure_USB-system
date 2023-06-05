Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
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

        If m.Msg = WM_DEVICECHANGE Then

            Select Case m.WParam
                Case WM_DEVICECHANGE_WPPARAMS.DBT_DEVICEARRIVAL
                    Dim Authentication As New Authentication
                    Authentication.Show()
                Case WM_DEVICECHANGE_WPPARAMS.DBT_DEVICEREMOVECOMPLETE
                    UnblockUSBPort()
                Case WM_DEVICECHANGE_WPPARAMS.DBT_CONFIGCHANGED
                    UnblockUSBPort()

            End Select
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub LoginForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        checkUserSettings()
        ' hereeee
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


End Class
