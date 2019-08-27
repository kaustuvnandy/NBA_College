Public Class PublicFiles
    Private Sub PublicFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataRecord.File_Management' table. You can move, or remove it, as needed.
        Me.File_ManagementTableAdapter.PublicFiles(Me.DataRecord.File_Management)
        File_PathTextBox.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(File_PathTextBox.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class