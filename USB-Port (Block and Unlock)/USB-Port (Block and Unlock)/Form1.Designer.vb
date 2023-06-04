<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBlock = New System.Windows.Forms.Button()
        Me.btnUnblock = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 130)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBlock
        '
        Me.btnBlock.Location = New System.Drawing.Point(27, 168)
        Me.btnBlock.Name = "btnBlock"
        Me.btnBlock.Size = New System.Drawing.Size(112, 41)
        Me.btnBlock.TabIndex = 1
        Me.btnBlock.Text = "Block Port"
        Me.btnBlock.UseVisualStyleBackColor = True
        '
        'btnUnblock
        '
        Me.btnUnblock.Location = New System.Drawing.Point(154, 168)
        Me.btnUnblock.Name = "btnUnblock"
        Me.btnUnblock.Size = New System.Drawing.Size(112, 41)
        Me.btnUnblock.TabIndex = 2
        Me.btnUnblock.Text = "Unblock Port"
        Me.btnUnblock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(293, 221)
        Me.Controls.Add(Me.btnUnblock)
        Me.Controls.Add(Me.btnBlock)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USB Port"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBlock As System.Windows.Forms.Button
    Friend WithEvents btnUnblock As System.Windows.Forms.Button

End Class
