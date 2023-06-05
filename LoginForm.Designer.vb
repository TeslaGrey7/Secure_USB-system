<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        loginBtn = New Button()
        usernameLabel = New Label()
        passwordLabel = New Label()
        usernameInput = New TextBox()
        passwordInput = New TextBox()
        masterLoginLabel = New Label()
        logoPicture = New PictureBox()
        loginStatusText = New Label()
        statusText = New Label()
        backgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(logoPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' loginBtn
        ' 
        loginBtn.Location = New Point(518, 262)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(112, 34)
        loginBtn.TabIndex = 0
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Location = New Point(394, 126)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(91, 25)
        usernameLabel.TabIndex = 1
        usernameLabel.Text = "Username"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(394, 182)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(87, 25)
        passwordLabel.TabIndex = 2
        passwordLabel.Text = "Password"
        ' 
        ' usernameInput
        ' 
        usernameInput.Location = New Point(506, 126)
        usernameInput.Name = "usernameInput"
        usernameInput.Size = New Size(150, 31)
        usernameInput.TabIndex = 3
        ' 
        ' passwordInput
        ' 
        passwordInput.Location = New Point(506, 182)
        passwordInput.Name = "passwordInput"
        passwordInput.Size = New Size(150, 31)
        passwordInput.TabIndex = 4
        ' 
        ' masterLoginLabel
        ' 
        masterLoginLabel.AutoSize = True
        masterLoginLabel.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point)
        masterLoginLabel.Location = New Point(480, 53)
        masterLoginLabel.Name = "masterLoginLabel"
        masterLoginLabel.Size = New Size(189, 38)
        masterLoginLabel.TabIndex = 5
        masterLoginLabel.Text = "Master Login"
        ' 
        ' logoPicture
        ' 
        logoPicture.Image = My.Resources.Resources.WhatsApp_Image_2023_06_05_at_13_58_43
        logoPicture.Location = New Point(25, 53)
        logoPicture.Name = "logoPicture"
        logoPicture.Size = New Size(315, 243)
        logoPicture.SizeMode = PictureBoxSizeMode.CenterImage
        logoPicture.TabIndex = 6
        logoPicture.TabStop = False
        ' 
        ' loginStatusText
        ' 
        loginStatusText.AutoSize = True
        loginStatusText.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        loginStatusText.ForeColor = Color.Red
        loginStatusText.Location = New Point(570, 216)
        loginStatusText.Name = "loginStatusText"
        loginStatusText.Size = New Size(0, 32)
        loginStatusText.TabIndex = 7
        loginStatusText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' statusText
        ' 
        statusText.AutoSize = True
        statusText.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point)
        statusText.ForeColor = SystemColors.Highlight
        statusText.Location = New Point(25, 327)
        statusText.Name = "statusText"
        statusText.Size = New Size(0, 38)
        statusText.TabIndex = 8
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(statusText)
        Controls.Add(loginStatusText)
        Controls.Add(logoPicture)
        Controls.Add(masterLoginLabel)
        Controls.Add(passwordInput)
        Controls.Add(usernameInput)
        Controls.Add(passwordLabel)
        Controls.Add(usernameLabel)
        Controls.Add(loginBtn)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoginForm"
        Text = "Master Login - Block USB Protection"
        CType(logoPicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents loginBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameInput As TextBox
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents masterLoginLabel As Label
    Friend WithEvents logoPicture As PictureBox
    Friend WithEvents loginStatusText As Label
    Friend WithEvents statusText As Label
    Friend WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
