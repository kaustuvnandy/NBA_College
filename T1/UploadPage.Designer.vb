<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UploadPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SearchFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text1 = New System.Windows.Forms.TextBox()
        Me.text2 = New System.Windows.Forms.TextBox()
        Me.text4 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.text3 = New System.Windows.Forms.TextBox()
        Me.uploadtypeCB = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path:"
        '
        'tb1
        '
        Me.tb1.Cursor = System.Windows.Forms.Cursors.No
        Me.tb1.Enabled = False
        Me.tb1.Location = New System.Drawing.Point(65, 97)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(465, 20)
        Me.tb1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(564, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SearchFile
        '
        Me.SearchFile.FileName = "Search for file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "File Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "File Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 8
        '
        'text1
        '
        Me.text1.Cursor = System.Windows.Forms.Cursors.No
        Me.text1.Enabled = False
        Me.text1.Location = New System.Drawing.Point(185, 224)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(397, 20)
        Me.text1.TabIndex = 9
        '
        'text2
        '
        Me.text2.Cursor = System.Windows.Forms.Cursors.No
        Me.text2.Enabled = False
        Me.text2.Location = New System.Drawing.Point(185, 272)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(397, 20)
        Me.text2.TabIndex = 10
        '
        'text4
        '
        Me.text4.Cursor = System.Windows.Forms.Cursors.No
        Me.text4.Enabled = False
        Me.text4.Location = New System.Drawing.Point(203, 451)
        Me.text4.Name = "text4"
        Me.text4.Size = New System.Drawing.Size(17, 20)
        Me.text4.TabIndex = 12
        Me.text4.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(439, 436)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 48)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Add to Database"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'text3
        '
        Me.text3.Location = New System.Drawing.Point(185, 323)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(397, 20)
        Me.text3.TabIndex = 16
        '
        'uploadtypeCB
        '
        Me.uploadtypeCB.FormattingEnabled = True
        Me.uploadtypeCB.Location = New System.Drawing.Point(185, 159)
        Me.uploadtypeCB.Name = "uploadtypeCB"
        Me.uploadtypeCB.Size = New System.Drawing.Size(235, 21)
        Me.uploadtypeCB.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 48)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Back to previous menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(185, 362)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(321, 362)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 20
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(461, 362)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "File Criteria:"
        '
        'UploadPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 496)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.uploadtypeCB)
        Me.Controls.Add(Me.text3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.text4)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UploadPage"
        Me.Text = "Upload Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SearchFile As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents text1 As TextBox
    Friend WithEvents text2 As TextBox
    Friend WithEvents text4 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents text3 As TextBox
    Friend WithEvents uploadtypeCB As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
End Class
