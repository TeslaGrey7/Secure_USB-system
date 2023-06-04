Imports Microsoft.Win32
Public Class Form1

    Private Sub BlockUSBPort()
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
        regKey.SetValue("Start", 4)
    End Sub

    Private Sub UnblockUSBPort()
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
        regKey.SetValue("Start", 3)
    End Sub

    Private Sub btnBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlock.Click
        BlockUSBPort()
        PictureBox1.Image = My.Resources.Deactived_usb
        MsgBox("Blocked", MsgBoxStyle.Information)

    End Sub

    Private Sub btnUnblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnblock.Click
        UnblockUSBPort()
        PictureBox1.Image = My.Resources.Activated_usb
        MsgBox("Unblocked", MsgBoxStyle.Information)

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UnblockUSBPort()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.Activated_usb

    End Sub
End Class
