Option Strict On
Option Explicit On
Imports System.IO

Public Class SuperVideoStore

    Sub ReadfromFile()
        Dim filepath As String = "..\..\..\Emails for VB.txt" 'Emails for VB.txt
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        Try
            FileOpen(fileNumber, filepath, OpenMode.Input)

            Input(fileNumber, currentRecord)

            ListBox1.Items.Add(currentRecord)

            FileClose(fileNumber)
        Catch bob As FileNotFoundException

            MsgBox("Bob is sad...")

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles FirstNameLabel.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ReadfromFile()
    End Sub
End Class
