Imports System
Imports System.IO
Public Class CreateID
    Dim f As Integer
    Dim filePath As String = "F:\Trial"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f = 1
        Add()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdminPage.Show()
        Me.Hide()
    End Sub

    Private Sub UserIDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserIDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserIDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub CreateID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.UserID' table. You can move, or remove it, as needed.
        Me.UserIDTableAdapter.Fill(Me.DatabaseDataSet.UserID)

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Del()
        MessageBox.Show("Record Deleted", "Prompt")
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        f = 2
        text1.Text = UserIDTextBox.Text
        text2.Text = UserPassTextBox.Text
        text3.Text = TeacherNameTextBox.Text
        Del()
        Add()
    End Sub

    Function Add() As Integer
        If (text1.Text = "" Or text2.Text = "" Or text3.Text = "") Then
            MessageBox.Show("Fields cannot be empty", "Prompt")
        Else
            Dim uname As String = ""
            Dim userid As String
            uname = text1.Text.ToLower()
            Dim querry As String = "Select userID from UserID where userID= '" & uname & "';"
            Dim dbsource As String = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =" & filePath & "\Database.accdb;"
            Dim conn1 = New OleDb.OleDbConnection(dbsource)
            Dim cmd1 As New OleDb.OleDbCommand(querry, conn1)
            conn1.Open()
            Try
                userid = cmd1.ExecuteScalar().ToString
                If String.Compare(userid, uname) = 0 Then
                    MessageBox.Show("Username exists" & Environment.NewLine & "Enter new username", "Prompt")
                    text1.Text = ""
                    text2.Text = ""
                    text3.Text = ""

                End If
            Catch ex As Exception
                Dim con As New OleDb.OleDbConnection
                con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =" & filePath & "\Database.accdb"
                Dim SqlString As String = "Insert Into [UserID] (userID,userPass,teacherName) Values (text1,text2,text3)"
                Using conn As New OleDb.OleDbConnection(con.ConnectionString)
                    Using cmd As New OleDb.OleDbCommand(SqlString, con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("column", text1.Text.ToLower())
                        cmd.Parameters.AddWithValue("column", text2.Text)
                        cmd.Parameters.AddWithValue("column", text3.Text)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        If (f = 1) Then
                            MessageBox.Show("ID Added", "Prompt")
                        ElseIf (f = 2) Then
                            MessageBox.Show("Id Updated", "Prompt")
                        End If
                        text1.Text = ""
                        text2.Text = ""
                        text3.Text = ""
                    End Using
                End Using
            End Try
        End If
        Me.UserIDTableAdapter.Fill(Me.DatabaseDataSet.UserID)
        Return 0
    End Function
    Function Del() As Integer
        Dim con As OleDb.OleDbConnection
        Dim com As OleDb.OleDbCommand
        con = New OleDb.OleDbConnection("PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =" & filePath & "\Database.accdb")
        com = New OleDb.OleDbCommand("delete * from UserID where [userID]=?", con)
        con.Open()
        com.Parameters.AddWithValue("userID", UserIDTextBox.Text)
        com.ExecuteNonQuery()
        con.Close()
        Me.UserIDTableAdapter.Fill(Me.DatabaseDataSet.UserID)
        Return 0
    End Function
End Class