Imports System
Imports System.IO
Public Class DeleteFiles
    Dim c, c1, c2, c3 As Integer
    Dim filePath As String = "F:\Trial"
    Private Sub SearchFiles_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Me.File_ManagementTableAdapter.Fill(Me.DatabaseDataSetFinal.File_Management)
        TextBox3.Visible = False
        TextBox4.Enabled = False
        Me.WindowState = FormWindowState.Maximized
        Dim currentArea = Screen.FromControl(Me).WorkingArea
        Me.Top = currentArea.Top + CInt((currentArea.Height / 2) - (Me.Height / 2))
        Me.Left = currentArea.Left + CInt((currentArea.Width / 2) - (Me.Width / 2))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button7.Enabled = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Enabled = True
        Button1.Enabled = False
        Button3.Enabled = False
        Button7.Enabled = False
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Enabled = True
        ComboBox1.Text = String.Empty
        ComboBox1.Items.Clear()
        Button1.Enabled = False
        Button2.Enabled = False
        Button7.Enabled = False
        c = 1
        While c <= 10
            ComboBox1.Items.Add(c)
            c = c + 1
        End While
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.FileManagementBindingSource.Filter = "File_Name like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.FileManagementBindingSource.Filter = "File_Description like '%" & TextBox2.Text & "%'"
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        c3 = CInt(ComboBox3.Text)
        Me.FileManagementBindingSource.Filter = "C1 = " & c1 & " And C2 = " & c2 & " And C3 = " & c3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim con As OleDb.OleDbConnection
            Dim com As OleDb.OleDbCommand
            con = New OleDb.OleDbConnection("PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =" & filePath & "\Database.accdb")
            com = New OleDb.OleDbCommand("delete * from File_Management where [File_Path]=?", con)
            con.Open()
            com.Parameters.AddWithValue("File_Path", TextBox3.Text)
            com.ExecuteNonQuery()
            con.Close()
            My.Computer.FileSystem.DeleteFile(TextBox3.Text)
            MessageBox.Show("Record Deleted", "Prompt")
            Me.DataGridView1.Refresh()
            MessageBox.Show("No files selected for opening", "Prompt")
        Catch ex As System.ArgumentNullException
            MessageBox.Show("No files selected for opening", "Prompt")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Visible = False
        If (back = 1) Then
            AdminPage.Show()
            Me.Hide()
        Else
            UserPage.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox4.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.FileManagementBindingSource.Filter = "User_ID like '%" & TextBox4.Text & "%'"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox4.Enabled = False
        Button7.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Text = ""
        TextBox2.Enabled = False
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        Me.File_ManagementTableAdapter.Fill(Me.DatabaseDataSetFinal.File_Management)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        c1 = CInt(ComboBox1.Text)
        ComboBox2.Enabled = True
        ComboBox2.Text = String.Empty
        ComboBox2.Items.Clear()
        ComboBox3.Enabled = False
        ComboBox3.Text = String.Empty
        ComboBox3.Items.Clear()
        c2 = 1
        If (c1 = 1) Then
            While (c2 <= 5)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 2) Then
            While (c2 <= 2)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 3) Then
            While (c2 <= 3)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 4) Then
            While (c2 <= 6)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 5) Then
            While (c2 <= 9)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 6) Then
            While (c2 <= 5)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 7) Then
            While (c2 <= 4)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 8) Then
            While (c2 <= 5)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        ElseIf (c1 = 9) Then
            While (c2 <= 7)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        Else
            While (c2 <= 4)
                ComboBox2.Items.Add(c2)
                c2 = c2 + 1
            End While
        End If
        Me.FileManagementBindingSource.Filter = "C1 = " & c1
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        c2 = CInt(ComboBox2.Text)
        ComboBox3.Enabled = True
        ComboBox3.Text = String.Empty
        ComboBox3.Items.Clear()
        c3 = 1
        If (c1 = 2 And c2 = 1) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        ElseIf (c1 = 2 And c2 = 2) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
            ComboBox3.Items.Add(3)
            ComboBox3.Items.Add(4)
            ComboBox3.Items.Add(5)
        ElseIf (c1 = 3 And c2 = 1) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
            ComboBox3.Items.Add(3)
        ElseIf (c1 = 3 And c2 = 2) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        ElseIf (c1 = 3 And c2 = 3) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        ElseIf (c1 = 4 And c2 = 2) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        ElseIf (c1 = 4 And c2 = 6) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
            ComboBox3.Items.Add(3)
        ElseIf (c1 = 5 And c2 = 7) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
            ComboBox3.Items.Add(3)
            ComboBox3.Items.Add(4)
        ElseIf (c1 = 8 And c2 = 4) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        ElseIf (c1 = 8 And c2 = 5) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        ElseIf (c1 = 10 And c2 = 1) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
            ComboBox3.Items.Add(3)
            ComboBox3.Items.Add(4)
            ComboBox3.Items.Add(5)
        ElseIf (c1 = 10 And c2 = 2) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
            ComboBox3.Items.Add(3)
        ElseIf (c1 = 10 And c2 = 3) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        ElseIf (c1 = 10 And c2 = 4) Then
            ComboBox3.Items.Add(1)
            ComboBox3.Items.Add(2)
        Else
            ComboBox3.Enabled = False
        End If
        Me.FileManagementBindingSource.Filter = "C1 = " & c1 & " And C2 = " & c2
    End Sub

End Class