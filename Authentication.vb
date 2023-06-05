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
            Me.Close()
        Else
            MessageBox.Show("Incorrect Pin, please try again.")
        End If

    End Sub


    Private Sub UnblockUSBPort()
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub


    Private Sub BlockUSBPort()
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub

End Class