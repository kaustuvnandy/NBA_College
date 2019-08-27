Public Class UserPage
    Private Sub UserPage_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'DataRecord.File_Management' table. You can move, or remove it, as needed.
        UserIDLabel.Text = userPath
        PrivateFilesButton.PerformClick()
        Me.WindowState = FormWindowState.Maximized
        Dim currentArea = Screen.FromControl(Me).WorkingArea
        Me.Top = currentArea.Top + CInt((currentArea.Height / 2) - (Me.Height / 2))
        Me.Left = currentArea.Left + CInt((currentArea.Width / 2) - (Me.Width / 2))

    End Sub
    Function clearFileViewer() As Integer

        DataGridView1.Visible = False
        Return 0
    End Function

    Private Sub PrivateFilesButton_Click(sender As Object, e As EventArgs) Handles PrivateFilesButton.Click
        clearFileViewer()
        'When Private Files is clicked
        DataGridView1.Visible = True
        Me.File_ManagementTableAdapter.FillByPrivate(Me.DatabaseDataSet.File_Management, userPath)
    End Sub

    Private Sub PublicFilesButton_Click(sender As Object, e As EventArgs) Handles PublicFilesButton.Click
        clearFileViewer()
        'When Public Files is clicked
        DataGridView1.Visible = True
        Me.File_ManagementTableAdapter.FillByPublic(Me.DatabaseDataSet.File_Management)

    End Sub

    Private Sub SearchFileButton_Click(sender As Object, e As EventArgs) Handles SearchFileButton.Click
        clearFileViewer()
        back = 0
        Me.Visible = False
        SearchFiles.Show()
        Me.Hide()
        'When Search Files is clicked
    End Sub
    Private Sub UploadFileButton_Click(sender As Object, e As EventArgs) Handles UploadFileButton.Click
        UploadPage.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start(File_PathTextBox.Text)
        Catch ex As System.InvalidOperationException
            MessageBox.Show("No files selected for opening", "Prompt")
        End Try
    End Sub

    Private Sub FillByPrivateToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByPrivateToolStripButton.Click
        Try
            Me.File_ManagementTableAdapter.FillByPrivate(Me.DatabaseDataSet.File_Management, User_IDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FillByPublicToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByPublicToolStripButton.Click
        Try
            Me.File_ManagementTableAdapter.FillByPublic(Me.DatabaseDataSet.File_Management)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        back = -1
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class
