<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.useridtb = New System.Windows.Forms.TextBox()
        Me.passwordtb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogInButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AdminButton)
        Me.Panel1.Controls.Add(Me.useridtb)
        Me.Panel1.Controls.Add(Me.passwordtb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LogInButton)
        Me.Panel1.Location = New System.Drawing.Point(92, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 275)
        Me.Panel1.TabIndex = 2
        '
        'AdminButton
        '
        Me.AdminButton.Location = New System.Drawing.Point(75, 202)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(151, 45)
        Me.AdminButton.TabIndex = 1
        Me.AdminButton.Text = "Login As Admin"
        Me.AdminButton.UseVisualStyleBackColor = True
        '
        'useridtb
        '
        Me.useridtb.AcceptsTab = True
        Me.useridtb.BackColor = System.Drawing.Color.AliceBlue
        Me.useridtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.useridtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useridtb.Location = New System.Drawing.Point(35, 65)
        Me.useridtb.Name = "useridtb"
        Me.useridtb.Size = New System.Drawing.Size(230, 31)
        Me.useridtb.TabIndex = 1
        Me.useridtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordtb
        '
        Me.passwordtb.AcceptsTab = True
        Me.passwordtb.BackColor = System.Drawing.Color.AliceBlue
        Me.passwordtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtb.Location = New System.Drawing.Point(35, 102)
        Me.passwordtb.Name = "passwordtb"
        Me.passwordtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtb.Size = New System.Drawing.Size(230, 31)
        Me.passwordtb.TabIndex = 1
        Me.passwordtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LogInButton
        '
        Me.LogInButton.Location = New System.Drawing.Point(75, 151)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(151, 45)
        Me.LogInButton.TabIndex = 1
        Me.LogInButton.Text = "Login as User"
        Me.LogInButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(62, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Developed by dept. of IT, STCET : Kaustuv Nandy, Pinaki Pal, Sujan Mitra"
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 389)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(0, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginPage"
        Me.Text = "Login Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents passwordtb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LogInButton As Button
    Friend WithEvents useridtb As TextBox
    Friend WithEvents AdminButton As Button
    Friend WithEvents Label2 As Label
End Class
