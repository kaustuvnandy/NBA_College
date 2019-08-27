<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPage
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
        Dim File_TypeLabel As System.Windows.Forms.Label
        Dim File_NameLabel As System.Windows.Forms.Label
        Dim File_DescriptionLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableAdapterManager = New T1.DataRecordTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FileManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New T1.DatabaseDataSet()
        Me.OpenFileButton = New System.Windows.Forms.Button()
        Me.FileViewer = New System.Windows.Forms.Panel()
        Me.File_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.File_NameTextBox = New System.Windows.Forms.TextBox()
        Me.File_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.File_PathTextBox1 = New System.Windows.Forms.TextBox()
        Me.ManageUserButton = New System.Windows.Forms.Button()
        Me.SearchFileButton = New System.Windows.Forms.Button()
        Me.PublicFilesButton = New System.Windows.Forms.Button()
        Me.PrivateFilesButton = New System.Windows.Forms.Button()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.UserDetailsPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ManageDeleteFiles = New System.Windows.Forms.Button()
        Me.ManageAdminButton = New System.Windows.Forms.Button()
        Me.PrivateFillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PrivateFillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PublicFill1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PublicFill1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.File_ManagementTableAdapter = New T1.DatabaseDataSetTableAdapters.File_ManagementTableAdapter()
        Me.TableAdapterManager1 = New T1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrivateFlagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        File_TypeLabel = New System.Windows.Forms.Label()
        File_NameLabel = New System.Windows.Forms.Label()
        File_DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FileViewer.SuspendLayout()
        Me.UserDetailsPanel.SuspendLayout()
        Me.PrivateFillToolStrip.SuspendLayout()
        Me.PublicFill1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'File_TypeLabel
        '
        File_TypeLabel.AutoSize = True
        File_TypeLabel.Location = New System.Drawing.Point(29, 9)
        File_TypeLabel.Name = "File_TypeLabel"
        File_TypeLabel.Size = New System.Drawing.Size(107, 25)
        File_TypeLabel.TabIndex = 12
        File_TypeLabel.Text = "File Type:"
        '
        'File_NameLabel
        '
        File_NameLabel.AutoSize = True
        File_NameLabel.Location = New System.Drawing.Point(321, 9)
        File_NameLabel.Name = "File_NameLabel"
        File_NameLabel.Size = New System.Drawing.Size(115, 25)
        File_NameLabel.TabIndex = 14
        File_NameLabel.Text = "File Name:"
        '
        'File_DescriptionLabel
        '
        File_DescriptionLabel.AutoSize = True
        File_DescriptionLabel.Location = New System.Drawing.Point(29, 50)
        File_DescriptionLabel.Name = "File_DescriptionLabel"
        File_DescriptionLabel.Size = New System.Drawing.Size(167, 25)
        File_DescriptionLabel.TabIndex = 16
        File_DescriptionLabel.Text = "File Description:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.File_ManagementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = T1.DataRecordTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserIDTableAdapter = Nothing
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileTypeDataGridViewTextBoxColumn, Me.FileNameDataGridViewTextBoxColumn, Me.FileDescriptionDataGridViewTextBoxColumn, Me.FilePathDataGridViewTextBoxColumn, Me.PrivateFlagDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FileManagementBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(24, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(898, 531)
        Me.DataGridView1.TabIndex = 1
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
        'OpenFileButton
        '
        Me.OpenFileButton.Location = New System.Drawing.Point(821, 18)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(101, 47)
        Me.OpenFileButton.TabIndex = 12
        Me.OpenFileButton.Text = "Open"
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'FileViewer
        '
        Me.FileViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileViewer.Controls.Add(Me.OpenFileButton)
        Me.FileViewer.Controls.Add(File_TypeLabel)
        Me.FileViewer.Controls.Add(Me.File_TypeTextBox)
        Me.FileViewer.Controls.Add(File_NameLabel)
        Me.FileViewer.Controls.Add(Me.File_NameTextBox)
        Me.FileViewer.Controls.Add(File_DescriptionLabel)
        Me.FileViewer.Controls.Add(Me.File_DescriptionTextBox)
        Me.FileViewer.Controls.Add(Me.File_PathTextBox1)
        Me.FileViewer.Controls.Add(Me.DataGridView1)
        Me.FileViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileViewer.Location = New System.Drawing.Point(318, 30)
        Me.FileViewer.Name = "FileViewer"
        Me.FileViewer.Size = New System.Drawing.Size(951, 642)
        Me.FileViewer.TabIndex = 5
        '
        'File_TypeTextBox
        '
        Me.File_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Type", True))
        Me.File_TypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_TypeTextBox.Location = New System.Drawing.Point(202, 6)
        Me.File_TypeTextBox.Name = "File_TypeTextBox"
        Me.File_TypeTextBox.Size = New System.Drawing.Size(100, 24)
        Me.File_TypeTextBox.TabIndex = 13
        '
        'File_NameTextBox
        '
        Me.File_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Name", True))
        Me.File_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_NameTextBox.Location = New System.Drawing.Point(442, 6)
        Me.File_NameTextBox.Name = "File_NameTextBox"
        Me.File_NameTextBox.Size = New System.Drawing.Size(364, 24)
        Me.File_NameTextBox.TabIndex = 15
        '
        'File_DescriptionTextBox
        '
        Me.File_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Description", True))
        Me.File_DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_DescriptionTextBox.Location = New System.Drawing.Point(202, 47)
        Me.File_DescriptionTextBox.Name = "File_DescriptionTextBox"
        Me.File_DescriptionTextBox.Size = New System.Drawing.Size(604, 24)
        Me.File_DescriptionTextBox.TabIndex = 17
        '
        'File_PathTextBox1
        '
        Me.File_PathTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Path", True))
        Me.File_PathTextBox1.Location = New System.Drawing.Point(846, 26)
        Me.File_PathTextBox1.Name = "File_PathTextBox1"
        Me.File_PathTextBox1.Size = New System.Drawing.Size(10, 31)
        Me.File_PathTextBox1.TabIndex = 19
        '
        'ManageUserButton
        '
        Me.ManageUserButton.Location = New System.Drawing.Point(0, 358)
        Me.ManageUserButton.Name = "ManageUserButton"
        Me.ManageUserButton.Size = New System.Drawing.Size(201, 57)
        Me.ManageUserButton.TabIndex = 7
        Me.ManageUserButton.Text = "Manage User"
        Me.ManageUserButton.UseVisualStyleBackColor = True
        '
        'SearchFileButton
        '
        Me.SearchFileButton.Location = New System.Drawing.Point(0, 253)
        Me.SearchFileButton.Name = "SearchFileButton"
        Me.SearchFileButton.Size = New System.Drawing.Size(201, 57)
        Me.SearchFileButton.TabIndex = 5
        Me.SearchFileButton.Text = "Search Files"
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
        'AdminLabel
        '
        Me.AdminLabel.AutoEllipsis = True
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.Location = New System.Drawing.Point(28, 25)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(147, 24)
        Me.AdminLabel.TabIndex = 1
        Me.AdminLabel.Text = "Administrator"
        '
        'UserDetailsPanel
        '
        Me.UserDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserDetailsPanel.Controls.Add(Me.ManageDeleteFiles)
        Me.UserDetailsPanel.Controls.Add(Me.ManageAdminButton)
        Me.UserDetailsPanel.Controls.Add(Me.Button2)
        Me.UserDetailsPanel.Controls.Add(Me.ManageUserButton)
        Me.UserDetailsPanel.Controls.Add(Me.SearchFileButton)
        Me.UserDetailsPanel.Controls.Add(Me.PublicFilesButton)
        Me.UserDetailsPanel.Controls.Add(Me.PrivateFilesButton)
        Me.UserDetailsPanel.Controls.Add(Me.AdminLabel)
        Me.UserDetailsPanel.Location = New System.Drawing.Point(58, 30)
        Me.UserDetailsPanel.Name = "UserDetailsPanel"
        Me.UserDetailsPanel.Size = New System.Drawing.Size(201, 470)
        Me.UserDetailsPanel.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ManageDeleteFiles
        '
        Me.ManageDeleteFiles.Location = New System.Drawing.Point(0, 306)
        Me.ManageDeleteFiles.Name = "ManageDeleteFiles"
        Me.ManageDeleteFiles.Size = New System.Drawing.Size(201, 57)
        Me.ManageDeleteFiles.TabIndex = 10
        Me.ManageDeleteFiles.Text = "Delete Files"
        Me.ManageDeleteFiles.UseVisualStyleBackColor = True
        '
        'ManageAdminButton
        '
        Me.ManageAdminButton.Location = New System.Drawing.Point(0, 413)
        Me.ManageAdminButton.Name = "ManageAdminButton"
        Me.ManageAdminButton.Size = New System.Drawing.Size(201, 57)
        Me.ManageAdminButton.TabIndex = 9
        Me.ManageAdminButton.Text = "Manage Admin"
        Me.ManageAdminButton.UseVisualStyleBackColor = True
        '
        'PrivateFillToolStrip
        '
        Me.PrivateFillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrivateFillToolStripButton})
        Me.PrivateFillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PrivateFillToolStrip.Name = "PrivateFillToolStrip"
        Me.PrivateFillToolStrip.Size = New System.Drawing.Size(1059, 25)
        Me.PrivateFillToolStrip.TabIndex = 7
        Me.PrivateFillToolStrip.Text = "PrivateFillToolStrip"
        Me.PrivateFillToolStrip.Visible = False
        '
        'PrivateFillToolStripButton
        '
        Me.PrivateFillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrivateFillToolStripButton.Name = "PrivateFillToolStripButton"
        Me.PrivateFillToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.PrivateFillToolStripButton.Text = "PrivateFill"
        '
        'PublicFill1ToolStrip
        '
        Me.PublicFill1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PublicFill1ToolStripButton})
        Me.PublicFill1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PublicFill1ToolStrip.Name = "PublicFill1ToolStrip"
        Me.PublicFill1ToolStrip.Size = New System.Drawing.Size(1059, 25)
        Me.PublicFill1ToolStrip.TabIndex = 8
        Me.PublicFill1ToolStrip.Text = "PublicFill1ToolStrip"
        Me.PublicFill1ToolStrip.Visible = False
        '
        'PublicFill1ToolStripButton
        '
        Me.PublicFill1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PublicFill1ToolStripButton.Name = "PublicFill1ToolStripButton"
        Me.PublicFill1ToolStripButton.Size = New System.Drawing.Size(65, 22)
        Me.PublicFill1ToolStripButton.Text = "PublicFill1"
        '
        'File_ManagementTableAdapter
        '
        Me.File_ManagementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.File_ManagementTableAdapter = Me.File_ManagementTableAdapter
        Me.TableAdapterManager1.UpdateOrder = T1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UserIDTableAdapter = Nothing
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
        Me.FileNameDataGridViewTextBoxColumn.Width = 180
        '
        'FileDescriptionDataGridViewTextBoxColumn
        '
        Me.FileDescriptionDataGridViewTextBoxColumn.DataPropertyName = "File_Description"
        Me.FileDescriptionDataGridViewTextBoxColumn.HeaderText = "File_Description"
        Me.FileDescriptionDataGridViewTextBoxColumn.Name = "FileDescriptionDataGridViewTextBoxColumn"
        Me.FileDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileDescriptionDataGridViewTextBoxColumn.Width = 580
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
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 684)
        Me.Controls.Add(Me.PublicFill1ToolStrip)
        Me.Controls.Add(Me.PrivateFillToolStrip)
        Me.Controls.Add(Me.FileViewer)
        Me.Controls.Add(Me.UserDetailsPanel)
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FileViewer.ResumeLayout(False)
        Me.FileViewer.PerformLayout()
        Me.UserDetailsPanel.ResumeLayout(False)
        Me.UserDetailsPanel.PerformLayout()
        Me.PrivateFillToolStrip.ResumeLayout(False)
        Me.PrivateFillToolStrip.PerformLayout()
        Me.PublicFill1ToolStrip.ResumeLayout(False)
        Me.PublicFill1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableAdapterManager As DataRecordTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileButton As Button
    Friend WithEvents FileViewer As Panel
    Friend WithEvents ManageUserButton As Button
    Friend WithEvents SearchFileButton As Button
    Friend WithEvents PublicFilesButton As Button
    Friend WithEvents PrivateFilesButton As Button
    Friend WithEvents AdminLabel As Label
    Friend WithEvents UserDetailsPanel As Panel
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents FileManagementBindingSource As BindingSource
    Friend WithEvents File_ManagementTableAdapter As DatabaseDataSetTableAdapters.File_ManagementTableAdapter
    Friend WithEvents PrivateFillToolStrip As ToolStrip
    Friend WithEvents PrivateFillToolStripButton As ToolStripButton
    Friend WithEvents PublicFill1ToolStrip As ToolStrip
    Friend WithEvents PublicFill1ToolStripButton As ToolStripButton
    Friend WithEvents File_TypeTextBox As TextBox
    Friend WithEvents File_NameTextBox As TextBox
    Friend WithEvents File_DescriptionTextBox As TextBox
    Friend WithEvents File_PathTextBox1 As TextBox
    Friend WithEvents TableAdapterManager1 As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ManageAdminButton As Button
    Friend WithEvents ManageDeleteFiles As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrivateFlagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
