Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frm As Form = New ShowUsers()
        'メールとパスが一致すれば、一覧画面、elseメッセージ出す
        If txtLoginMail.Text = "test" And txtLoginPass.Text = "pass" Then
            frm.Show()
        Else
            MessageBox.Show("メールアドレスか、パスワードが間違いました", "再度入力してください")
        End If
    End Sub
End Class
