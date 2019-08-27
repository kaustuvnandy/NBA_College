<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPage
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
        Me.components = New System.ComponentModel.Container()
        Dim File_TypeLabel As System.Windows.Forms.Label
        Dim File_NameLabel As System.Windows.Forms.Label
        Dim File_DescriptionLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UserDetailsPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UploadFileButton = New System.Windows.Forms.Button()
        Me.SearchFileButton = New System.Windows.Forms.Button()
        Me.PublicFilesButton = New System.Windows.Forms.Button()
        Me.PrivateFilesButton = New System.Windows.Forms.Button()
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.FileViewer = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.File_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.FileManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New T1.DatabaseDataSet()
        Me.File_NameTextBox = New System.Windows.Forms.TextBox()
        Me.File_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.File_PathTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrivateFlagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByPrivateToolStrip = New System.Windows.Forms.ToolStrip()
        Me.User_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.User_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByPrivateToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByPublicToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByPublicToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.File_ManagementTableAdapter = New T1.DatabaseDataSetTableAdapters.File_ManagementTableAdapter()
        Me.TableAdapterManager = New T1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        File_TypeLabel = New System.Windows.Forms.Label()
        File_NameLabel = New System.Windows.Forms.Label()
        File_DescriptionLabel = New System.Windows.Forms.Label()
        Me.UserDetailsPanel.SuspendLayout()
        Me.FileViewer.SuspendLayout()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByPrivateToolStrip.SuspendLayout()
        Me.FillByPublicToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'File_TypeLabel
        '
        File_TypeLabel.AutoSize = True
        File_TypeLabel.Location = New System.Drawing.Point(19, 9)
        File_TypeLabel.Name = "File_TypeLabel"
        File_TypeLabel.Size = New System.Drawing.Size(107, 25)
        File_TypeLabel.TabIndex = 12
        File_TypeLabel.Text = "File Type:"
        '
        'File_NameLabel
        '
        File_NameLabel.AutoSize = True
        File_NameLabel.Location = New System.Drawing.Point(303, 9)
        File_NameLabel.Name = "File_NameLabel"
        File_NameLabel.Size = New System.Drawing.Size(115, 25)
        File_NameLabel.TabIndex = 14
        File_NameLabel.Text = "File Name:"
        '
        'File_DescriptionLabel
        '
        File_DescriptionLabel.AutoSize = True
        File_DescriptionLabel.Location = New System.Drawing.Point(19, 50)
        File_DescriptionLabel.Name = "File_DescriptionLabel"
        File_DescriptionLabel.Size = New System.Drawing.Size(167, 25)
        File_DescriptionLabel.TabIndex = 16
        File_DescriptionLabel.Text = "File Description:"
        '
        'UserDetailsPanel
        '
        Me.UserDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserDetailsPanel.Controls.Add(Me.Button2)
        Me.UserDetailsPanel.Controls.Add(Me.Label1)
        Me.UserDetailsPanel.Controls.Add(Me.UploadFileButton)
        Me.UserDetailsPanel.Controls.Add(Me.SearchFileButton)
        Me.UserDetailsPanel.Controls.Add(Me.PublicFilesButton)
        Me.UserDetailsPanel.Controls.Add(Me.PrivateFilesButton)
        Me.UserDetailsPanel.Controls.Add(Me.UserIDLabel)
        Me.UserDetailsPanel.Location = New System.Drawing.Point(4, 6)
        Me.UserDetailsPanel.Name = "UserDetailsPanel"
        Me.UserDetailsPanel.Size = New System.Drawing.Size(201, 366)
        Me.UserDetailsPanel.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-1, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "User Page"
        '
        'UploadFileButton
        '
        Me.UploadFileButton.Location = New System.Drawing.Point(0, 308)
        Me.UploadFileButton.Name = "UploadFileButton"
        Me.UploadFileButton.Size = New System.Drawing.Size(202, 58)
        Me.UploadFileButton.TabIndex = 6
        Me.UploadFileButton.Text = "Upload File"
        Me.UploadFileButton.UseVisualStyleBackColor = True
        '
        'SearchFileButton
        '
        Me.SearchFileButton.Location = New System.Drawing.Point(0, 253)
        Me.SearchFileButton.Name = "SearchFileButton"
        Me.SearchFileButton.Size = New System.Drawing.Size(201, 57)
        Me.SearchFileButton.TabIndex = 5
        Me.SearchFileButton.Text = "Search File"
        Me.SearchFileButton.UseVisualStyleBackColor = True
        '
        'PublicFilesButton
        '
        Me.PublicFilesButton.Location = New System.Drawing.Point(0, 198)
        Me.PublicFilesButton.Name = "PublicFilesButton"
        Me.PublicFilesButton.Size = New System.Drawing.Size(201, 57)
        Me.PublicFilesButton.TabIndex = 4
        Me.PublicFilesButton.Text = "Public Files"
        Me.PublicFilesButton.UseVisualStyleBackColor = True
        '
        'PrivateFilesButton
        '
        Me.PrivateFilesButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PrivateFilesButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PrivateFilesButton.Location = New System.Drawing.Point(0, 143)
        Me.PrivateFilesButton.Name = "PrivateFilesButton"
        Me.PrivateFilesButton.Size = New System.Drawing.Size(201, 57)
        Me.PrivateFilesButton.TabIndex = 3
        Me.PrivateFilesButton.Text = "Private Files"
        Me.PrivateFilesButton.UseVisualStyleBackColor = False
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Location = New System.Drawing.Point(155, 127)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(38, 13)
        Me.UserIDLabel.TabIndex = 2
        Me.UserIDLabel.Text = "usr_ID"
        '
        'FileViewer
        '
        Me.FileViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileViewer.Controls.Add(Me.Button1)
        Me.FileViewer.Controls.Add(File_TypeLabel)
        Me.FileViewer.Controls.Add(Me.File_TypeTextBox)
        Me.FileViewer.Controls.Add(File_NameLabel)
        Me.FileViewer.Controls.Add(Me.File_NameTextBox)
        Me.FileViewer.Controls.Add(File_DescriptionLabel)
        Me.FileViewer.Controls.Add(Me.File_DescriptionTextBox)
        Me.FileViewer.Controls.Add(Me.File_PathTextBox)
        Me.FileViewer.Controls.Add(Me.DataGridView1)
        Me.FileViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileViewer.Location = New System.Drawing.Point(344, 138)
        Me.FileViewer.Name = "FileViewer"
        Me.FileViewer.Size = New System.Drawing.Size(938, 527)
        Me.FileViewer.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(824, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 47)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'File_TypeTextBox
        '
        Me.File_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Type", True))
        Me.File_TypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_TypeTextBox.Location = New System.Drawing.Point(132, 6)
        Me.File_TypeTextBox.Name = "File_TypeTextBox"
        Me.File_TypeTextBox.Size = New System.Drawing.Size(160, 24)
        Me.File_TypeTextBox.TabIndex = 13
        '
        'FileManagementBindingSource
        '
        Me.FileManagementBindingSource.DataMember = "File_Management"
        Me.FileManagementBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'File_NameTextBox
        '
        Me.File_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Name", True))
        Me.File_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_NameTextBox.Location = New System.Drawing.Point(424, 6)
        Me.File_NameTextBox.Name = "File_NameTextBox"
        Me.File_NameTextBox.Size = New System.Drawing.Size(394, 24)
        Me.File_NameTextBox.TabIndex = 15
        '
        'File_DescriptionTextBox
        '
        Me.File_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Description", True))
        Me.File_DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_DescriptionTextBox.Location = New System.Drawing.Point(192, 47)
        Me.File_DescriptionTextBox.Name = "File_DescriptionTextBox"
        Me.File_DescriptionTextBox.Size = New System.Drawing.Size(626, 24)
        Me.File_DescriptionTextBox.TabIndex = 17
        '
        'File_PathTextBox
        '
        Me.File_PathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Path", True))
        Me.File_PathTextBox.Location = New System.Drawing.Point(836, 26)
        Me.File_PathTextBox.Name = "File_PathTextBox"
        Me.File_PathTextBox.Size = New System.Drawing.Size(18, 31)
        Me.File_PathTextBox.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileTypeDataGridViewTextBoxColumn, Me.FileNameDataGridViewTextBoxColumn, Me.FileDescriptionDataGridViewTextBoxColumn, Me.FilePathDataGridViewTextBoxColumn, Me.PrivateFlagDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FileManagementBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.Location = New System.Drawing.Point(24, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(891, 430)
        Me.DataGridView1.TabIndex = 1
        '
        'FileTypeDataGridViewTextBoxColumn
        '
        Me.FileTypeDataGridViewTextBoxColumn.DataPropertyName = "File_Type"
        Me.FileTypeDataGridViewTextBoxColumn.HeaderText = "File_Type"
        Me.FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn"
        Me.FileTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileTypeDataGridViewTextBoxColumn.Visible = False
        '
        'FileNameDataGridViewTextBoxColumn
        '
        Me.FileNameDataGridViewTextBoxColumn.DataPropertyName = "File_Name"
        Me.FileNameDataGridViewTextBoxColumn.HeaderText = "File_Name"
        Me.FileNameDataGridViewTextBoxColumn.Name = "FileNameDataGridViewTextBoxColumn"
        Me.FileNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileNameDataGridViewTextBoxColumn.Width = 300
        '
        'FileDescriptionDataGridViewTextBoxColumn
        '
        Me.FileDescriptionDataGridViewTextBoxColumn.DataPropertyName = "File_Description"
        Me.FileDescriptionDataGridViewTextBoxColumn.HeaderText = "File_Description"
        Me.FileDescriptionDataGridViewTextBoxColumn.Name = "FileDescriptionDataGridViewTextBoxColumn"
        Me.FileDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileDescriptionDataGridViewTextBoxColumn.Width = 570
        '
        'FilePathDataGridViewTextBoxColumn
        '
        Me.FilePathDataGridViewTextBoxColumn.DataPropertyName = "File_Path"
        Me.FilePathDataGridViewTextBoxColumn.HeaderText = "File_Path"
        Me.FilePathDataGridViewTextBoxColumn.Name = "FilePathDataGridViewTextBoxColumn"
        Me.FilePathDataGridViewTextBoxColumn.ReadOnly = True
        Me.FilePathDataGridViewTextBoxColumn.Visible = False
        '
        'PrivateFlagDataGridViewTextBoxColumn
        '
        Me.PrivateFlagDataGridViewTextBoxColumn.DataPropertyName = "Private_Flag"
        Me.PrivateFlagDataGridViewTextBoxColumn.HeaderText = "Private_Flag"
        Me.PrivateFlagDataGridViewTextBoxColumn.Name = "PrivateFlagDataGridViewTextBoxColumn"
        Me.PrivateFlagDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrivateFlagDataGridViewTextBoxColumn.Visible = False
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'FillByPrivateToolStrip
        '
        Me.FillByPrivateToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.User_IDToolStripLabel, Me.User_IDToolStripTextBox, Me.FillByPrivateToolStripButton})
        Me.FillByPrivateToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByPrivateToolStrip.Name = "FillByPrivateToolStrip"
        Me.FillByPrivateToolStrip.Size = New System.Drawing.Size(1135, 25)
        Me.FillByPrivateToolStrip.TabIndex = 2
        Me.FillByPrivateToolStrip.Text = "FillByPrivateToolStrip"
        Me.FillByPrivateToolStrip.Visible = False
        '
        'User_IDToolStripLabel
        '
        Me.User_IDToolStripLabel.Name = "User_IDToolStripLabel"
        Me.User_IDToolStripLabel.Size = New System.Drawing.Size(49, 22)
        Me.User_IDToolStripLabel.Text = "User_ID:"
        '
        'User_IDToolStripTextBox
        '
        Me.User_IDToolStripTextBox.Name = "User_IDToolStripTextBox"
        Me.User_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByPrivateToolStripButton
        '
        Me.FillByPrivateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPrivateToolStripButton.Name = "FillByPrivateToolStripButton"
        Me.FillByPrivateToolStripButton.Size = New System.Drawing.Size(75, 22)
        Me.FillByPrivateToolStripButton.Text = "FillByPrivate"
        '
        'FillByPublicToolStrip
        '
        Me.FillByPublicToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByPublicToolStripButton})
        Me.FillByPublicToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByPublicToolStrip.Name = "FillByPublicToolStrip"
        Me.FillByPublicToolStrip.Size = New System.Drawing.Size(1052, 25)
        Me.FillByPublicToolStrip.TabIndex = 3
        Me.FillByPublicToolStrip.Text = "FillByPublicToolStrip"
        Me.FillByPublicToolStrip.Visible = False
        '
        'FillByPublicToolStripButton
        '
        Me.FillByPublicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPublicToolStripButton.Name = "FillByPublicToolStripButton"
        Me.FillByPublicToolStripButton.Size = New System.Drawing.Size(72, 22)
        Me.FillByPublicToolStripButton.Text = "FillByPublic"
        '
        'File_ManagementTableAdapter
        '
        Me.File_ManagementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.File_ManagementTableAdapter = Me.File_ManagementTableAdapter
        Me.TableAdapterManager.UpdateOrder = T1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserIDTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UserDetailsPanel)
        Me.Panel1.Location = New System.Drawing.Point(90, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 377)
        Me.Panel1.TabIndex = 4
        '
        'UserPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FillByPrivateToolStrip)
        Me.Controls.Add(Me.FillByPublicToolStrip)
        Me.Controls.Add(Me.FileViewer)
        Me.Name = "UserPage"
        Me.Text = "User Page"
        Me.UserDetailsPanel.ResumeLayout(False)
        Me.UserDetailsPanel.PerformLayout()
        Me.FileViewer.ResumeLayout(False)
        Me.FileViewer.PerformLayout()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByPrivateToolStrip.ResumeLayout(False)
        Me.FillByPrivateToolStrip.PerformLayout()
        Me.FillByPublicToolStrip.ResumeLayout(False)
        Me.FillByPublicToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserDetailsPanel As Panel
    Friend WithEvents FileViewer As Panel
    Friend WithEvents UploadFileButton As Button
    Friend WithEvents SearchFileButton As Button
    Friend WithEvents PublicFilesButton As Button
    Friend WithEvents PrivateFilesButton As Button
    Friend WithEvents UserIDLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents FileManagementBindingSource As BindingSource
    Friend WithEvents File_ManagementTableAdapter As DatabaseDataSetTableAdapters.File_ManagementTableAdapter
    Friend WithEvents File_TypeTextBox As TextBox
    Friend WithEvents File_NameTextBox As TextBox
    Friend WithEvents File_DescriptionTextBox As TextBox
    Friend WithEvents File_PathTextBox As TextBox
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FillByPrivateToolStrip As ToolStrip
    Friend WithEvents User_IDToolStripLabel As ToolStripLabel
    Friend WithEvents User_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByPrivateToolStripButton As ToolStripButton
    Friend WithEvents FillByPublicToolStrip As ToolStrip
    Friend WithEvents FillByPublicToolStripButton As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrivateFlagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
