<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentication
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Authentication))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        pincodeInput = New TextBox()
        checkAuthBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(239, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 38)
        Label1.TabIndex = 0
        Label1.Text = "USB Device Detected"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.IndianRed
        Label2.Location = New Point(85, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(607, 28)
        Label2.TabIndex = 1
        Label2.Text = "This computer is protected against unauthorized USB devices access."
        Label2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(113, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 28)
        Label3.TabIndex = 2
        Label3.Text = "Enter PIN to continue"
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' pincodeInput
        ' 
        pincodeInput.Location = New Point(340, 179)
        pincodeInput.Name = "pincodeInput"
        pincodeInput.Size = New Size(150, 31)
        pincodeInput.TabIndex = 3
        ' 
        ' checkAuthBtn
        ' 
        checkAuthBtn.Location = New Point(351, 248)
        checkAuthBtn.Name = "checkAuthBtn"
        checkAuthBtn.Size = New Size(112, 34)
        checkAuthBtn.TabIndex = 4
        checkAuthBtn.Text = "Submit"
        checkAuthBtn.UseVisualStyleBackColor = True
        ' 
        ' Authentication
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(checkAuthBtn)
        Controls.Add(pincodeInput)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Authentication"
        Text = "Authentication - Block USB Protection"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pincodeInput As TextBox
    Friend WithEvents checkAuthBtn As Button
End Class
