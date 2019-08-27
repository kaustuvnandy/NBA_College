Imports System
Imports System.IO
Public Class LoginPage
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        Dim filePath As String = "F:\Trial"
        Dim uname As String = ""
        Dim pword As String = ""
        Dim username As String = ""
        Dim pass As String
        If useridtb.Text = "" Or passwordtb.Text = "" Then
            MessageBox.Show("Fields cannot be empty", "Prompt")
        Else
            uname = useridtb.Text
            pword = passwordtb.Text
            userPath = uname
            Dim querry As String = "Select userPass from UserID where userID= '" & uname & "';"
            Dim dbsource As String = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =" & filePath & "\Database.accdb;"
            Dim conn = New OleDb.OleDbConnection(dbsource)
            Dim cmd As New OleDb.OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show("Username does not exist", "Prompt")
                useridtb.Select()
            End Try
            If (pword = pass) Then
                MessageBox.Show("Login Successful")
                UserPage.Show()
                If UserPage.Visible Then
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Login Failed", "Prompt")
                passwordtb.Text = ""
                useridtb.Select()
            End If
        End If
    End Sub

    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        Dim filePath As String = "F:\Trial"
        Dim uname As String = ""
        Dim pword As String = ""
        Dim username As String = ""
        Dim pass As String
        If useridtb.Text = "" Or passwordtb.Text = "" Then
            MessageBox.Show("Fields cannot be empty", "Prompt")
        Else
            uname = useridtb.Text
            pword = passwordtb.Text
            userPath = uname
            Dim querry As String = "Select pass from Admin"
            Dim dbsource As String = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =" & filePath & "\Database.accdb;"
            Dim conn = New OleDb.OleDbConnection(dbsource)
            Dim cmd As New OleDb.OleDbCommand(querry, conn)
            conn.Open()
            pass = cmd.ExecuteScalar().ToString
            If (pword = pass And uname = "admin") Then
                MessageBox.Show("Login Successful")
                AdminPage.Show()
                If AdminPage.Visible Then
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Login Failed", "Prompt")
                passwordtb.Text = ""
            End If
        End If
    End Sub
    Private Sub LoginPage_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        useridtb.Text = ""
        passwordtb.Text = ""
        useridtb.Select()
        Dim currentArea = Screen.FromControl(Me).WorkingArea
        Me.Top = currentArea.Top + CInt((currentArea.Height / 2) - (Me.Height / 2))
        Me.Left = currentArea.Left + CInt((currentArea.Width / 2) - (Me.Width / 2))
    End Sub


End Class