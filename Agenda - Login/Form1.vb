Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim varUsuario = txtUser.Text
            varUsuario = varUsuario.Trim
            varUsuario = varUsuario.ToLower
            Dim varPassword = txtpassword.Text

            If varUsuario = "admin" And varPassword = "1234" Then


                Record.Show()

            Else
                MessageBox.Show("User or password incorrect")

            End If

        Catch ex As Exception

            MessageBox.Show("An error has ocurred " + ex.Message)

        End Try


    End Sub
End Class
