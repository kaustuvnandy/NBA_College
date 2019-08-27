Imports System
Imports System.IO
Public Class UploadPage
    Public filePath As String
    Dim copyPath As String
    Dim i As Integer
    Dim c1, c2, c3 As Integer
    Dim selectFileFlag As Integer
    Dim s As String
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        filePath = "F:\Trial"
        Label2.Visible = False
        text1.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        text2.Visible = False
        text3.Visible = False
        text4.Visible = False
        Label5.Visible = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        selectFileFlag = 0
        uploadtypeCB.Enabled = False
        Dim currentArea = Screen.FromControl(Me).WorkingArea
        Me.Top = currentArea.Top + CInt((currentArea.Height / 2) - (Me.Height / 2))
        Me.Left = currentArea.Left + CInt((currentArea.Width / 2) - (Me.Width / 2))

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creating filter for text file,pdf file,excel file,word file etc.
        SearchFile.Filter = "All files|*.*|(*.txt)|*.txt|(*.pdf)|*.pdf|(*.docx)|*.docx"
        'Action when the file has been selected
        uploadtypeCB.Items.Clear()
        uploadtypeCB.Text = "                    --UPLOAD TYPE--"
        uploadtypeCB.Items.Add("Upload Privately")
        uploadtypeCB.Items.Add("Upload Publicly")
        ComboBox1.Items.Clear()
        If SearchFile.ShowDialog = DialogResult.OK Then
            selectFileFlag = 1
            tb1.Text = SearchFile.FileName
            'Checking for the required folder
            PublicPath()
            'Once file selected making the details visible
            MakeVisible()
            'Showing the file details
            text2.Text = tb1.Text.Substring(tb1.Text.LastIndexOf("\") + 1, (tb1.Text.LastIndexOf(".")) - (tb1.Text.LastIndexOf("\")) - 1)
            If String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".txt") = 0 Then
                text1.Text = "Text"
            ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".pdf") = 0 Then
                text1.Text = "PDF"
            ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".docx") = 0 Then
                text1.Text = "Word"
            Else
                text1.Text = "Other"
            End If
            text4.Text = copyPath
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If (uploadtypeCB.Text = "Upload Privately" Or uploadtypeCB.Text = "Upload Publicly") Then
            If selectFileFlag = 1 Then
                If String.Compare(uploadtypeCB.SelectedItem.ToString, "Upload Privately") = 0 Then
                    i = 1
                    c1 = 0
                    c2 = 0
                    c3 = 0
                    Dim a As Integer
                    PrivatePath()
                    Do
                        a = uploadFile()
                    Loop While a <> 3
                Else
                    i = 0
                    PublicPath()
                    Dim a As Integer
                    Do
                        a = uploadFile()
                    Loop While a <> 3
                End If
                c1 = 0
                c2 = 0
                c3 = 0
                'Resetting all the data and hiding the textbox
                HideDetails()
            Else
                MessageBox.Show("No file selcted!", "Prompt")
            End If
        Else
            MessageBox.Show("Upload Type is Mandatory", "Prompt")
        End If
    End Sub
    'Function to show the  details of the selected file
    Function MakeVisible() As Integer
        ComboBox1.Enabled = True
        uploadtypeCB.Enabled = True
        c1 = 1
        While c1 <= 10
            ComboBox1.Items.Add(c1)
            c1 = c1 + 1
        End While

        Label2.Visible = True
        text1.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        text2.Visible = True
        text3.Visible = True
        text4.Visible = True
        Label5.Visible = True
        uploadtypeCB.Text = "                    --UPLOAD TYPE--"
        'selectFileFlag is set to 1 as the file has been selected
        selectFileFlag = 1
        Return 0
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
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
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        c2 = CInt(ComboBox2.Text)
        ComboBox3.Enabled = True
        ComboBox3.Text = String.Empty
        ComboBox3.Items.Clear()
        'c3 = 1
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
    End Sub

    Private Sub uploadtypeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uploadtypeCB.SelectedIndexChanged
        If String.Compare(uploadtypeCB.SelectedItem.ToString, "Upload Privately") = 0 Then
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
        Else
            ComboBox1.Enabled = True
        End If
    End Sub


    'Function to hide the details of the selected file once they have been uploaded 
    Function HideDetails() As Integer
        Label2.Visible = False
        text1.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        text2.Visible = False
        text3.Visible = False
        text4.Visible = False
        Label5.Visible = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        uploadtypeCB.Text = "                    --UPLOAD TYPE--"
        'Resetting the text boxes
        text1.Text = ""
        text2.Text = ""
        text3.Text = ""
        text4.Text = ""
        'Resetting the path variables
        copyPath = ""
        tb1.Text = ""
        'Resetting selectFileFlag 
        selectFileFlag = 0
        Return 0
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserPage.Show()
        Me.Hide()
    End Sub

    Function AddtoDatabase() As Integer
        Dim con As New OleDb.OleDbConnection
        'Establishing the connection
        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =" & filePath & "\Database.accdb"
        Dim SqlString As String = "Insert Into [File_Management] (File_Type,File_Name,File_Description,File_Path,Private_Flag,User_ID,C1,C2,C3) Values (text1,text2,text3,text4,i,s,c1,c2,c3)"
        Using conn As New OleDb.OleDbConnection(con.ConnectionString)
            Using cmd As New OleDb.OleDbCommand(SqlString, con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("column", text1.Text)
                cmd.Parameters.AddWithValue("column", text2.Text)
                cmd.Parameters.AddWithValue("column", text3.Text)
                cmd.Parameters.AddWithValue("column", text4.Text)
                cmd.Parameters.AddWithValue("column", i)
                cmd.Parameters.AddWithValue("column", s)
                cmd.Parameters.AddWithValue("column", c1)
                cmd.Parameters.AddWithValue("column", c2)
                cmd.Parameters.AddWithValue("column", c3)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("Added to File Register", "Prompt")
        Return 0
    End Function

    Function uploadFile() As Integer
        Try
            promptChoice = 0
            My.Computer.FileSystem.CopyFile(tb1.Text, copyPath)
            MessageBox.Show("File successfully uploaded!", "Prompt")
            AddtoDatabase()
            Return 3
            'If no file selected
        Catch ex As ArgumentNullException
            MessageBox.Show("No file selected!", "Error")
            'If the file already exits in the same path
        Catch ex As IOException
            Prompt.ShowDialog()
            'When overwriting

            If promptChoice = 1 Then
                    My.Computer.FileSystem.CopyFile(tb1.Text, copyPath, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                    promptChoice = 0
                    Return 3
                'When renaming the file name
            ElseIf promptChoice = 2 Then
                MessageInput.ShowDialog()
                text2.Text = promptString

                If i = 1 Then
                    PrivateRename()
                Else
                    PublicRename()
                End If
                promptChoice = 0
                    Return 2
                End If



        Catch ex As Exception
            MessageBox.Show("Some unexpected error has occoured!", "Error")
        End Try
        Return 3
    End Function
    Function PublicPath() As Integer
        If String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".txt") = 0 Then
            copyPath = (filePath & "\Public Folder" & "\text\" & c1 & "_" & c2 & "_" & c3 & tb1.Text.Substring(tb1.Text.LastIndexOf("\") + 1))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".pdf") = 0 Then
            copyPath = (filePath & "\Public Folder" & "\pdf\" & c1 & "_" & c2 & "_" & c3 & tb1.Text.Substring(tb1.Text.LastIndexOf("\") + 1))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".docx") = 0 Then
            copyPath = (filePath & "\Public Folder" & "\word\" & c1 & "_" & c2 & "_" & c3 & tb1.Text.Substring(tb1.Text.LastIndexOf("\") + 1))
        Else
            copyPath = (filePath & "\Public Folder" & "\others\" & c1 & "_" & c2 & "_" & c3 & tb1.Text.Substring(tb1.Text.LastIndexOf("\") + 1))
        End If
        s = userPath
        text4.Text = copyPath
        Return 0
    End Function
    Function PrivatePath() As Integer

        If String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".txt") = 0 Then
            copyPath = (filePath & "\" & userPath & "\text" & tb1.Text.Substring(tb1.Text.LastIndexOf("\")))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".pdf") = 0 Then
            copyPath = (filePath & "\" & userPath & "\pdf" & tb1.Text.Substring(tb1.Text.LastIndexOf("\")))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".docx") = 0 Then
            copyPath = (filePath & "\" & userPath & "\word" & tb1.Text.Substring(tb1.Text.LastIndexOf("\")))
        Else
            copyPath = (filePath & "\" & userPath & "\others" & tb1.Text.Substring(tb1.Text.LastIndexOf("\")))
        End If
        s = userPath
        text4.Text = copyPath
        Return 0
    End Function

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        c3 = CInt(ComboBox3.Text)
    End Sub

    Function PrivateRename() As Integer
        If String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".txt") = 0 Then
            copyPath = (filePath & "\" & userPath & "\text\" & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".pdf") = 0 Then
            copyPath = (filePath & "\" & userPath & "\pdf\" & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".docx") = 0 Then
            copyPath = (filePath & "\" & userPath & "\word\" & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        Else
            copyPath = (filePath & "\" & userPath & "\others\" & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        End If
        s = userPath
        text4.Text = copyPath
        Return 0
    End Function
    Function PublicRename() As Integer
        If String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".txt") = 0 Then
            copyPath = (filePath & "\Public Folder" & "\text\" & c1 & "_" & c2 & "_" & c3 & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".pdf") = 0 Then
            copyPath = (filePath & "\Public Folder" & "\pdf\" & c1 & "_" & c2 & "_" & c3 & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        ElseIf String.Compare(tb1.Text.Substring(tb1.Text.LastIndexOf(".")), ".docx") = 0 Then
            copyPath = (filePath & "\Public Folder" & "\word\" & c1 & "_" & c2 & "_" & c3 & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        Else
            copyPath = (filePath & "\Public Folder" & "\others\" & c1 & "_" & c2 & "_" & c3 & text2.Text & tb1.Text.Substring(tb1.Text.LastIndexOf(".")))
        End If
        s = userPath
        text4.Text = copyPath
        Return 0
    End Function
End Class

