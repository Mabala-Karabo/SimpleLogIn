Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtEmail.Text = "mbl@gmail.com" And txtPassword.Text = "1234") Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("your email or password is incorrect")
        End If
    End Sub
End Class
