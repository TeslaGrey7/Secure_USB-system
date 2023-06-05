<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Dashboard))
        credentialsLabel = New Label()
        Label1 = New Label()
        saveSettings = New Button()
        exitBtn = New Button()
        usernameInput = New TextBox()
        passwordInput = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        pincodeInput = New TextBox()
        enabledInput = New CheckBox()
        SuspendLayout()
        ' 
        ' credentialsLabel
        ' 
        credentialsLabel.AutoSize = True
        credentialsLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        credentialsLabel.Location = New Point(38, 35)
        credentialsLabel.Name = "credentialsLabel"
        credentialsLabel.Size = New Size(229, 38)
        credentialsLabel.TabIndex = 7
        credentialsLabel.Text = "User Credentials"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(519, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 38)
        Label1.TabIndex = 8
        Label1.Text = "Authentication"
        ' 
        ' saveSettings
        ' 
        saveSettings.Location = New Point(354, 381)
        saveSettings.Name = "saveSettings"
        saveSettings.Size = New Size(174, 34)
        saveSettings.TabIndex = 9
        saveSettings.Text = "Save"
        saveSettings.UseVisualStyleBackColor = True
        ' 
        ' exitBtn
        ' 
        exitBtn.Location = New Point(587, 381)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(174, 34)
        exitBtn.TabIndex = 10
        exitBtn.Text = "Exit"
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' usernameInput
        ' 
        usernameInput.Location = New Point(126, 105)
        usernameInput.Name = "usernameInput"
        usernameInput.Size = New Size(150, 31)
        usernameInput.TabIndex = 11
        ' 
        ' passwordInput
        ' 
        passwordInput.Location = New Point(126, 164)
        passwordInput.Name = "passwordInput"
        passwordInput.Size = New Size(150, 31)
        passwordInput.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 13
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 14
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(25, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(262, 38)
        Label4.TabIndex = 15
        Label4.Text = "Master Credentials"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 310)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 25)
        Label5.TabIndex = 16
        Label5.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 359)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 17
        Label6.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(126, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 25)
        Label7.TabIndex = 18
        Label7.Text = "admin"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(126, 359)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 25)
        Label8.TabIndex = 19
        Label8.Text = "adminpwd"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(502, 105)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 25)
        Label9.TabIndex = 20
        Label9.Text = "PIN"
        ' 
        ' pincodeInput
        ' 
        pincodeInput.Location = New Point(571, 103)
        pincodeInput.Name = "pincodeInput"
        pincodeInput.Size = New Size(150, 31)
        pincodeInput.TabIndex = 21
        ' 
        ' enabledInput
        ' 
        enabledInput.AutoSize = True
        enabledInput.Location = New Point(571, 160)
        enabledInput.Name = "enabledInput"
        enabledInput.Size = New Size(101, 29)
        enabledInput.TabIndex = 22
        enabledInput.Text = "Enabled"
        enabledInput.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(enabledInput)
        Controls.Add(pincodeInput)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(passwordInput)
        Controls.Add(usernameInput)
        Controls.Add(exitBtn)
        Controls.Add(saveSettings)
        Controls.Add(Label1)
        Controls.Add(credentialsLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        Text = "Dashboard - Block USB Protection"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents credentialsLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents saveSettings As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents usernameInput As TextBox
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pincodeInput As TextBox
    Friend WithEvents enabledInput As CheckBox
End Class
