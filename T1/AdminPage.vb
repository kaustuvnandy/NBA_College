Public Class AdminPage

    Private Sub CreateUserButton_Click(sender As Object, e As EventArgs) 
        CreateID.Show()
        Me.Hide()
    End Sub

    Private Sub SearchFileButton_Click(sender As Object, e As EventArgs) Handles SearchFileButton.Click
        back = 1
        Me.Visible = False
        SearchFiles.Show()
        Me.Hide()
    End Sub

    Private Sub AdminPage_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'DatabaseDataSet.File_Management' table. You can move, or remove it, as needed.
        Me.WindowState = FormWindowState.Maximized
        Dim currentArea = Screen.FromControl(Me).WorkingArea
        Me.Top = currentArea.Top + CInt((currentArea.Height / 2) - (Me.Height / 2))
        Me.Left = currentArea.Left + CInt((currentArea.Width / 2) - (Me.Width / 2))
        PrivateFilesButton.PerformClick()
    End Sub

    Private Sub PublicFillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.File_ManagementTableAdapter.PublicFill(Me.DatabaseDataSet.File_Management)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrivateFillToolStripButton_Click(sender As Object, e As EventArgs) Handles PrivateFillToolStripButton.Click
        Try
            Me.File_ManagementTableAdapter.PrivateFill(Me.DatabaseDataSet.File_Management)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PublicFill1ToolStripButton_Click(sender As Object, e As EventArgs) Handles PublicFill1ToolStripButton.Click
        Try
            Me.File_ManagementTableAdapter.PublicFill1(Me.DatabaseDataSet.File_Management)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton.Click
        Try
            Process.Start(File_PathTextBox1.Text)
        Catch ex As System.InvalidOperationException
            MessageBox.Show("No files selected for opening", "Prompt")
        End Try
    End Sub

    Private Sub PrivateFilesButton_Click(sender As Object, e As EventArgs) Handles PrivateFilesButton.Click
        Me.File_ManagementTableAdapter.PrivateFill(Me.DatabaseDataSet.File_Management)
    End Sub

    Private Sub PublicFilesButton_Click(sender As Object, e As EventArgs) Handles PublicFilesButton.Click
        Me.File_ManagementTableAdapter.PublicFill1(Me.DatabaseDataSet.File_Management)
    End Sub

    Private Sub ManageUserButton_Click(sender As Object, e As EventArgs) Handles ManageUserButton.Click
        CreateID.Show()
        Me.Hide()
    End Sub

    Private Sub ManageDeleteFiles_Click(sender As Object, e As EventArgs) Handles ManageDeleteFiles.Click
        back = 1
        Me.Visible = False
        DeleteFiles.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        back = -1
        LoginPage.Show()
        Me.Hide()
    End Sub


End Class