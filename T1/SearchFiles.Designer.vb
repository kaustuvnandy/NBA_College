﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchFiles
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
        Me.components = New System.ComponentModel.Container()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FileManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSetFinal = New T1.DatabaseDataSetFinal()
        Me.File_ManagementTableAdapter = New T1.DatabaseDataSetFinalTableAdapters.File_ManagementTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrivateFlagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoEllipsis = True
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(620, 34)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(134, 24)
        Me.SearchLabel.TabIndex = 2
        Me.SearchLabel.Text = "Search Files"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search By Name"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 34)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Search By Description"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(202, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(488, 29)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(202, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(488, 29)
        Me.TextBox2.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(202, 192)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 32)
        Me.ComboBox1.TabIndex = 20
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(375, 192)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(145, 32)
        Me.ComboBox2.TabIndex = 21
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(545, 192)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(145, 32)
        Me.ComboBox3.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(265, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 256)
        Me.Panel1.TabIndex = 24
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(28, 138)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(136, 34)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "Search By User"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(735, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 34)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Open"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(735, 36)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 34)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Reset"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(28, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 34)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Search By Criteria"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileTypeDataGridViewTextBoxColumn, Me.FileNameDataGridViewTextBoxColumn, Me.FileDescriptionDataGridViewTextBoxColumn, Me.FilePathDataGridViewTextBoxColumn, Me.PrivateFlagDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.C1DataGridViewTextBoxColumn, Me.C2DataGridViewTextBoxColumn, Me.C3DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FileManagementBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(265, 377)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(897, 376)
        Me.DataGridView1.TabIndex = 25
        '
        'FileManagementBindingSource
        '
        Me.FileManagementBindingSource.DataMember = "File_Management"
        Me.FileManagementBindingSource.DataSource = Me.DatabaseDataSetFinal
        '
        'DatabaseDataSetFinal
        '
        Me.DatabaseDataSetFinal.DataSetName = "DatabaseDataSetFinal"
        Me.DatabaseDataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'File_ManagementTableAdapter
        '
        Me.File_ManagementTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(136, 34)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Back"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Path", True))
        Me.TextBox3.Location = New System.Drawing.Point(265, 20)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 38
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(202, 138)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(488, 29)
        Me.TextBox4.TabIndex = 28
        '
        'FileTypeDataGridViewTextBoxColumn
        '
        Me.FileTypeDataGridViewTextBoxColumn.DataPropertyName = "File_Type"
        Me.FileTypeDataGridViewTextBoxColumn.HeaderText = "File_Type"
        Me.FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn"
        '
        'FileNameDataGridViewTextBoxColumn
        '
        Me.FileNameDataGridViewTextBoxColumn.DataPropertyName = "File_Name"
        Me.FileNameDataGridViewTextBoxColumn.HeaderText = "File_Name"
        Me.FileNameDataGridViewTextBoxColumn.Name = "FileNameDataGridViewTextBoxColumn"
        Me.FileNameDataGridViewTextBoxColumn.Width = 150
        '
        'FileDescriptionDataGridViewTextBoxColumn
        '
        Me.FileDescriptionDataGridViewTextBoxColumn.DataPropertyName = "File_Description"
        Me.FileDescriptionDataGridViewTextBoxColumn.HeaderText = "File_Description"
        Me.FileDescriptionDataGridViewTextBoxColumn.Name = "FileDescriptionDataGridViewTextBoxColumn"
        Me.FileDescriptionDataGridViewTextBoxColumn.Width = 300
        '
        'FilePathDataGridViewTextBoxColumn
        '
        Me.FilePathDataGridViewTextBoxColumn.DataPropertyName = "File_Path"
        Me.FilePathDataGridViewTextBoxColumn.HeaderText = "File_Path"
        Me.FilePathDataGridViewTextBoxColumn.Name = "FilePathDataGridViewTextBoxColumn"
        Me.FilePathDataGridViewTextBoxColumn.Visible = False
        Me.FilePathDataGridViewTextBoxColumn.Width = 400
        '
        'PrivateFlagDataGridViewTextBoxColumn
        '
        Me.PrivateFlagDataGridViewTextBoxColumn.DataPropertyName = "Private_Flag"
        Me.PrivateFlagDataGridViewTextBoxColumn.HeaderText = "Private_Flag"
        Me.PrivateFlagDataGridViewTextBoxColumn.Name = "PrivateFlagDataGridViewTextBoxColumn"
        Me.PrivateFlagDataGridViewTextBoxColumn.Visible = False
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.Width = 90
        '
        'C1DataGridViewTextBoxColumn
        '
        Me.C1DataGridViewTextBoxColumn.DataPropertyName = "C1"
        Me.C1DataGridViewTextBoxColumn.HeaderText = "Major Criteria"
        Me.C1DataGridViewTextBoxColumn.Name = "C1DataGridViewTextBoxColumn"
        Me.C1DataGridViewTextBoxColumn.Width = 75
        '
        'C2DataGridViewTextBoxColumn
        '
        Me.C2DataGridViewTextBoxColumn.DataPropertyName = "C2"
        Me.C2DataGridViewTextBoxColumn.HeaderText = "Minor Criteria"
        Me.C2DataGridViewTextBoxColumn.Name = "C2DataGridViewTextBoxColumn"
        Me.C2DataGridViewTextBoxColumn.Width = 75
        '
        'C3DataGridViewTextBoxColumn
        '
        Me.C3DataGridViewTextBoxColumn.DataPropertyName = "C3"
        Me.C3DataGridViewTextBoxColumn.HeaderText = "Sub Criteria"
        Me.C3DataGridViewTextBoxColumn.Name = "C3DataGridViewTextBoxColumn"
        Me.C3DataGridViewTextBoxColumn.Width = 75
        '
        'SearchFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SearchLabel)
        Me.Name = "SearchFiles"
        Me.Text = "SearchFiles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox

    Private Sub SearchFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SearchLabel_Click(sender As Object, e As EventArgs) Handles SearchLabel.Click

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabaseDataSetFinal As DatabaseDataSetFinal
    Friend WithEvents FileManagementBindingSource As BindingSource
    Friend WithEvents File_ManagementTableAdapter As DatabaseDataSetFinalTableAdapters.File_ManagementTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrivateFlagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
