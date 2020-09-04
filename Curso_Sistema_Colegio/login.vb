Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtLogin.Click
        txtLogin.Text = ""
    End Sub

    Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub txtPwd_Click(sender As Object, e As EventArgs) Handles txtPwd.Click
        txtPwd.Text = ""
        txtPwd.Focus()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
