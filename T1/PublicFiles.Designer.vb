<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PublicFiles
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
        Dim File_DescriptionLabel As System.Windows.Forms.Label
        Dim File_NameLabel As System.Windows.Forms.Label
        Me.PublicHeaderLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrivateFlagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataRecord = New T1.DataRecord()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.File_ManagementTableAdapter = New T1.DataRecordTableAdapters.File_ManagementTableAdapter()
        Me.TableAdapterManager = New T1.DataRecordTableAdapters.TableAdapterManager()
        Me.File_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.File_NameTextBox = New System.Windows.Forms.TextBox()
        Me.File_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.File_PathTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PublicFilesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PublicFilesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        File_TypeLabel = New System.Windows.Forms.Label()
        File_DescriptionLabel = New System.Windows.Forms.Label()
        File_NameLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PublicFilesToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'File_TypeLabel
        '
        File_TypeLabel.AutoSize = True
        File_TypeLabel.Location = New System.Drawing.Point(37, 63)
        File_TypeLabel.Name = "File_TypeLabel"
        File_TypeLabel.Size = New System.Drawing.Size(59, 15)
        File_TypeLabel.TabIndex = 2
        File_TypeLabel.Text = "File Type:"
        '
        'File_DescriptionLabel
        '
        File_DescriptionLabel.AutoSize = True
        File_DescriptionLabel.Location = New System.Drawing.Point(37, 91)
        File_DescriptionLabel.Name = "File_DescriptionLabel"
        File_DescriptionLabel.Size = New System.Drawing.Size(95, 15)
        File_DescriptionLabel.TabIndex = 6
        File_DescriptionLabel.Text = "File Description:"
        '
        'File_NameLabel
        '
        File_NameLabel.AutoSize = True
        File_NameLabel.Location = New System.Drawing.Point(272, 63)
        File_NameLabel.Name = "File_NameLabel"
        File_NameLabel.Size = New System.Drawing.Size(67, 15)
        File_NameLabel.TabIndex = 4
        File_NameLabel.Text = "File Name:"
        '
        'PublicHeaderLabel
        '
        Me.PublicHeaderLabel.AutoSize = True
        Me.PublicHeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicHeaderLabel.Location = New System.Drawing.Point(325, 19)
        Me.PublicHeaderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PublicHeaderLabel.Name = "PublicHeaderLabel"
        Me.PublicHeaderLabel.Size = New System.Drawing.Size(151, 29)
        Me.PublicHeaderLabel.TabIndex = 0
        Me.PublicHeaderLabel.Text = "Public Files"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileTypeDataGridViewTextBoxColumn, Me.FileNameDataGridViewTextBoxColumn, Me.FileDescriptionDataGridViewTextBoxColumn, Me.FilePathDataGridViewTextBoxColumn, Me.PrivateFlagDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FileManagementBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(697, 346)
        Me.DataGridView1.TabIndex = 1
        '
        'FileTypeDataGridViewTextBoxColumn
        '
        Me.FileTypeDataGridViewTextBoxColumn.DataPropertyName = "File_Type"
        Me.FileTypeDataGridViewTextBoxColumn.HeaderText = "File_Type"
        Me.FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn"
        Me.FileTypeDataGridViewTextBoxColumn.Visible = False
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
        Me.FileDescriptionDataGridViewTextBoxColumn.Width = 500
        '
        'FilePathDataGridViewTextBoxColumn
        '
        Me.FilePathDataGridViewTextBoxColumn.DataPropertyName = "File_Path"
        Me.FilePathDataGridViewTextBoxColumn.HeaderText = "File_Path"
        Me.FilePathDataGridViewTextBoxColumn.Name = "FilePathDataGridViewTextBoxColumn"
        Me.FilePathDataGridViewTextBoxColumn.Visible = False
        '
        'PrivateFlagDataGridViewTextBoxColumn
        '
        Me.PrivateFlagDataGridViewTextBoxColumn.DataPropertyName = "Private_Flag"
        Me.PrivateFlagDataGridViewTextBoxColumn.HeaderText = "Private_Flag"
        Me.PrivateFlagDataGridViewTextBoxColumn.Name = "PrivateFlagDataGridViewTextBoxColumn"
        Me.PrivateFlagDataGridViewTextBoxColumn.Visible = False
        '
        'FileManagementBindingSource
        '
        Me.FileManagementBindingSource.DataMember = "File_Management"
        Me.FileManagementBindingSource.DataSource = Me.DataRecord
        '
        'DataRecord
        '
        Me.DataRecord.DataSetName = "DataRecord"
        Me.DataRecord.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 395)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select the file from the table:"
        '
        'File_ManagementTableAdapter
        '
        Me.File_ManagementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.File_ManagementTableAdapter = Me.File_ManagementTableAdapter
        Me.TableAdapterManager.UpdateOrder = T1.DataRecordTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserIDTableAdapter = Nothing
        '
        'File_DescriptionTextBox
        '
        Me.File_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Description", True))
        Me.File_DescriptionTextBox.Location = New System.Drawing.Point(138, 88)
        Me.File_DescriptionTextBox.Name = "File_DescriptionTextBox"
        Me.File_DescriptionTextBox.Size = New System.Drawing.Size(472, 21)
        Me.File_DescriptionTextBox.TabIndex = 7
        '
        'File_NameTextBox
        '
        Me.File_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Name", True))
        Me.File_NameTextBox.Location = New System.Drawing.Point(373, 60)
        Me.File_NameTextBox.Name = "File_NameTextBox"
        Me.File_NameTextBox.Size = New System.Drawing.Size(237, 21)
        Me.File_NameTextBox.TabIndex = 5
        '
        'File_TypeTextBox
        '
        Me.File_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Type", True))
        Me.File_TypeTextBox.Location = New System.Drawing.Point(138, 60)
        Me.File_TypeTextBox.Name = "File_TypeTextBox"
        Me.File_TypeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.File_TypeTextBox.TabIndex = 3
        '
        'File_PathTextBox
        '
        Me.File_PathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileManagementBindingSource, "File_Path", True))
        Me.File_PathTextBox.Location = New System.Drawing.Point(40, 26)
        Me.File_PathTextBox.Name = "File_PathTextBox"
        Me.File_PathTextBox.Size = New System.Drawing.Size(10, 21)
        Me.File_PathTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PublicFilesToolStrip
        '
        Me.PublicFilesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PublicFilesToolStripButton})
        Me.PublicFilesToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PublicFilesToolStrip.Name = "PublicFilesToolStrip"
        Me.PublicFilesToolStrip.Size = New System.Drawing.Size(780, 25)
        Me.PublicFilesToolStrip.TabIndex = 11
        Me.PublicFilesToolStrip.Text = "PublicFilesToolStrip"
        '
        'PublicFilesToolStripButton
        '
        Me.PublicFilesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PublicFilesToolStripButton.Name = "PublicFilesToolStripButton"
        Me.PublicFilesToolStripButton.Size = New System.Drawing.Size(67, 22)
        Me.PublicFilesToolStripButton.Text = "PublicFiles"
        Me.PublicFilesToolStripButton.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(66, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PublicFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 522)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PublicFilesToolStrip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(File_TypeLabel)
        Me.Controls.Add(Me.File_TypeTextBox)
        Me.Controls.Add(File_NameLabel)
        Me.Controls.Add(Me.File_NameTextBox)
        Me.Controls.Add(File_DescriptionLabel)
        Me.Controls.Add(Me.File_DescriptionTextBox)
        Me.Controls.Add(Me.File_PathTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PublicHeaderLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PublicFiles"
        Me.Text = "Public Files"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PublicFilesToolStrip.ResumeLayout(False)
        Me.PublicFilesToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PublicHeaderLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataRecord As DataRecord
    Friend WithEvents FileManagementBindingSource As BindingSource
    Friend WithEvents File_ManagementTableAdapter As DataRecordTableAdapters.File_ManagementTableAdapter
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrivateFlagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DataRecordTableAdapters.TableAdapterManager
    Friend WithEvents File_DescriptionTextBox As TextBox
    Friend WithEvents File_NameTextBox As TextBox
    Friend WithEvents File_TypeTextBox As TextBox
    Friend WithEvents File_PathTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PublicFilesToolStrip As ToolStrip
    Friend WithEvents PublicFilesToolStripButton As ToolStripButton
    Friend WithEvents Button2 As Button
End Class
