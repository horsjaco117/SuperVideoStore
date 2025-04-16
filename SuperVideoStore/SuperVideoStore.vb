Option Strict On
Option Explicit On


Public Class SuperVideoStore

    Sub ReadfromFile()
        Dim filepath As String = "Emails for VB.txt"
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filepath, OpenMode.Input)



            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles FirstNameLabel.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
