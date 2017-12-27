Imports System.Net.Mail
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myServer As New SmtpClient(TextBox7.Text, TextBox6.Text) 'for gmail 587 is secure smtp port

            myServer.Credentials = New System.Net.NetworkCredential(TextBox4.Text, TextBox5.Text)

            Dim myMessage As New MailMessage(from:=TextBox1.Text, to:=TextBox2.Text)
            myMessage.Body = RichTextBox1.Text
            myMessage.Subject = TextBox3.Text
            myServer.EnableSsl = True

            myServer.Send(myMessage)



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.TopMost = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
