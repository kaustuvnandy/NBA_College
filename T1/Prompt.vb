Public Class Prompt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        promptChoice = 1
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        promptChoice = 2
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        promptChoice = 3
        Me.Close()
    End Sub

    Private Sub Prompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        promptChoice = 3
    End Sub
End Class