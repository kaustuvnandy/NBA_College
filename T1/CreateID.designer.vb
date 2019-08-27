<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateID
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim UserPassLabel As System.Windows.Forms.Label
        Dim TeacherNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateID))
        Me.text1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DatabaseDataSet = New T1.DatabaseDataSet()
        Me.UserIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserIDTableAdapter = New T1.DatabaseDataSetTableAdapters.UserIDTableAdapter()
        Me.TableAdapterManager = New T1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UserIDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.UserIDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserPassTextBox = New System.Windows.Forms.TextBox()
        Me.TeacherNameTextBox = New System.Windows.Forms.TextBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Users = New System.Windows.Forms.GroupBox()
        Me.UserSelected = New System.Windows.Forms.GroupBox()
        Me.Update = New System.Windows.Forms.Button()
        Me.AddUser = New System.Windows.Forms.GroupBox()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        UserIDLabel = New System.Windows.Forms.Label()
        UserPassLabel = New System.Windows.Forms.Label()
        TeacherNameLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserIDBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Users.SuspendLayout()
        Me.UserSelected.SuspendLayout()
        Me.AddUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(43, 28)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(44, 13)
        UserIDLabel.TabIndex = 9
        UserIDLabel.Text = "user ID:"
        '
        'UserPassLabel
        '
        UserPassLabel.AutoSize = True
        UserPassLabel.Location = New System.Drawing.Point(43, 77)
        UserPassLabel.Name = "UserPassLabel"
        UserPassLabel.Size = New System.Drawing.Size(56, 13)
        UserPassLabel.TabIndex = 11
        UserPassLabel.Text = "user Pass:"
        '
        'TeacherNameLabel
        '
        TeacherNameLabel.AutoSize = True
        TeacherNameLabel.Location = New System.Drawing.Point(43, 127)
        TeacherNameLabel.Name = "TeacherNameLabel"
        TeacherNameLabel.Size = New System.Drawing.Size(77, 13)
        TeacherNameLabel.TabIndex = 13
        TeacherNameLabel.Text = "teacher Name:"
        '
        'text1
        '
        Me.text1.Location = New System.Drawing.Point(282, 21)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(100, 20)
        Me.text1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UserID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'text2
        '
        Me.text2.Location = New System.Drawing.Point(282, 66)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(100, 20)
        Me.text2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Name of user:"
        '
        'text3
        '
        Me.text3.Location = New System.Drawing.Point(282, 112)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(100, 20)
        Me.text3.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-3, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserIDBindingSource
        '
        Me.UserIDBindingSource.DataMember = "UserID"
        Me.UserIDBindingSource.DataSource = Me.DatabaseDataSet
        '
        'UserIDTableAdapter
        '
        Me.UserIDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.File_ManagementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = T1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserIDTableAdapter = Me.UserIDTableAdapter
        '
        'UserIDBindingNavigator
        '
        Me.UserIDBindingNavigator.AddNewItem = Nothing
        Me.UserIDBindingNavigator.BindingSource = Me.UserIDBindingSource
        Me.UserIDBindingNavigator.CountItem = Nothing
        Me.UserIDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserIDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.UserIDBindingNavigatorSaveItem})
        Me.UserIDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserIDBindingNavigator.MoveFirstItem = Nothing
        Me.UserIDBindingNavigator.MoveLastItem = Nothing
        Me.UserIDBindingNavigator.MoveNextItem = Nothing
        Me.UserIDBindingNavigator.MovePreviousItem = Nothing
        Me.UserIDBindingNavigator.Name = "UserIDBindingNavigator"
        Me.UserIDBindingNavigator.PositionItem = Nothing
        Me.UserIDBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.UserIDBindingNavigator.TabIndex = 8
        Me.UserIDBindingNavigator.Text = "BindingNavigator1"
        Me.UserIDBindingNavigator.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UserIDBindingNavigatorSaveItem
        '
        Me.UserIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserIDBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserIDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserIDBindingNavigatorSaveItem.Name = "UserIDBindingNavigatorSaveItem"
        Me.UserIDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserIDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserIDBindingSource, "userID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(128, 25)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(139, 20)
        Me.UserIDTextBox.TabIndex = 10
        '
        'UserPassTextBox
        '
        Me.UserPassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserIDBindingSource, "userPass", True))
        Me.UserPassTextBox.Location = New System.Drawing.Point(128, 74)
        Me.UserPassTextBox.Name = "UserPassTextBox"
        Me.UserPassTextBox.Size = New System.Drawing.Size(139, 20)
        Me.UserPassTextBox.TabIndex = 12
        '
        'TeacherNameTextBox
        '
        Me.TeacherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserIDBindingSource, "teacherName", True))
        Me.TeacherNameTextBox.Location = New System.Drawing.Point(128, 124)
        Me.TeacherNameTextBox.Name = "TeacherNameTextBox"
        Me.TeacherNameTextBox.Size = New System.Drawing.Size(139, 20)
        Me.TeacherNameTextBox.TabIndex = 14
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(181, 189)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(112, 33)
        Me.Delete.TabIndex = 16
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserPassDataGridViewTextBoxColumn, Me.TeacherNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserIDBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(422, 240)
        Me.DataGridView1.TabIndex = 15
        '
        'Users
        '
        Me.Users.Controls.Add(Me.DataGridView1)
        Me.Users.Location = New System.Drawing.Point(25, 174)
        Me.Users.Name = "Users"
        Me.Users.Size = New System.Drawing.Size(437, 264)
        Me.Users.TabIndex = 17
        Me.Users.TabStop = False
        Me.Users.Text = "Select the user to delete:"
        '
        'UserSelected
        '
        Me.UserSelected.Controls.Add(Me.Update)
        Me.UserSelected.Controls.Add(Me.Delete)
        Me.UserSelected.Controls.Add(UserIDLabel)
        Me.UserSelected.Controls.Add(Me.UserIDTextBox)
        Me.UserSelected.Controls.Add(UserPassLabel)
        Me.UserSelected.Controls.Add(Me.UserPassTextBox)
        Me.UserSelected.Controls.Add(TeacherNameLabel)
        Me.UserSelected.Controls.Add(Me.TeacherNameTextBox)
        Me.UserSelected.Location = New System.Drawing.Point(477, 174)
        Me.UserSelected.Name = "UserSelected"
        Me.UserSelected.Size = New System.Drawing.Size(314, 264)
        Me.UserSelected.TabIndex = 18
        Me.UserSelected.TabStop = False
        Me.UserSelected.Text = "User selected:"
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(46, 189)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(112, 33)
        Me.Update.TabIndex = 17
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'AddUser
        '
        Me.AddUser.Controls.Add(Me.Button1)
        Me.AddUser.Controls.Add(Me.Label3)
        Me.AddUser.Controls.Add(Me.text3)
        Me.AddUser.Controls.Add(Me.Label2)
        Me.AddUser.Controls.Add(Me.text2)
        Me.AddUser.Controls.Add(Me.Label1)
        Me.AddUser.Controls.Add(Me.text1)
        Me.AddUser.Location = New System.Drawing.Point(84, 15)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Size = New System.Drawing.Size(606, 150)
        Me.AddUser.TabIndex = 19
        Me.AddUser.TabStop = False
        Me.AddUser.Text = "Create User:"
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "userID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'UserPassDataGridViewTextBoxColumn
        '
        Me.UserPassDataGridViewTextBoxColumn.DataPropertyName = "userPass"
        Me.UserPassDataGridViewTextBoxColumn.HeaderText = "userPass"
        Me.UserPassDataGridViewTextBoxColumn.Name = "UserPassDataGridViewTextBoxColumn"
        '
        'TeacherNameDataGridViewTextBoxColumn
        '
        Me.TeacherNameDataGridViewTextBoxColumn.DataPropertyName = "teacherName"
        Me.TeacherNameDataGridViewTextBoxColumn.HeaderText = "teacherName"
        Me.TeacherNameDataGridViewTextBoxColumn.Name = "TeacherNameDataGridViewTextBoxColumn"
        Me.TeacherNameDataGridViewTextBoxColumn.Width = 190
        '
        'CreateID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddUser)
        Me.Controls.Add(Me.UserSelected)
        Me.Controls.Add(Me.Users)
        Me.Controls.Add(Me.UserIDBindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Name = "CreateID"
        Me.Text = "Create User ID"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserIDBindingNavigator.ResumeLayout(False)
        Me.UserIDBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Users.ResumeLayout(False)
        Me.UserSelected.ResumeLayout(False)
        Me.UserSelected.PerformLayout()
        Me.AddUser.ResumeLayout(False)
        Me.AddUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents text1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents text2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents text3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents UserIDBindingSource As BindingSource
    Friend WithEvents UserIDTableAdapter As DatabaseDataSetTableAdapters.UserIDTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserIDBindingNavigator As BindingNavigator
    Friend WithEvents UserIDBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents UserPassTextBox As TextBox
    Friend WithEvents TeacherNameTextBox As TextBox
    Friend WithEvents Delete As Button
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Users As GroupBox
    Friend WithEvents UserSelected As GroupBox
    Friend WithEvents AddUser As GroupBox
    Friend WithEvents Update As Button
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserPassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
