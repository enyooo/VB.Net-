Imports System.Data.SqlClient
Public Class Login
    Dim lgmail As String
    Dim lgpass As String

    Private ReadOnly Property IsInfoValid As Boolean
        Get
            If txtLoginMail.Text = "" Then
                MessageBox.Show("メールアドレスを入力してください")
                Return False
            ElseIf txtLoginPass.Text = "" Then
                MessageBox.Show("パスワードを入力してください")
                Return False
            Else
                lgmail = txtLoginMail.Text
                lgpass = txtLoginPass.Text
                Return True
            End If
        End Get
    End Property

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsInfoValid Then
            '    Using connection As New SqlConnection(My.Settings.connString)
            '        Dim sql As String = "select loginPass from [Manage].[Info] where loginMail=@LoginMail"
            '        Using sqlcommand As New SqlCommand(sql, connection)
            '            sqlcommand.Parameters.Add(New SqlParameter("@LoginMail", SqlDbType.NVarChar, 50))
            '            sqlcommand.Parameters("@LoginMail").Value = lgmail

            '            Try
            '                connection.Open()
            '                Dim dataReader As SqlDataReader = sqlcommand.ExecuteReader()
            '                While (dataReader.Read())
            '                    Console.WriteLine(dataReader(0).ToString())
            '                    If dataReader(0).ToString() = lgpass Then
            '                        Dim frm As Form = New ShowUsers()
            '                        frm.Show()

            '                        txtLoginMail.Clear()
            '                        txtLoginPass.Clear()
            '                    Else
            '                        txtLoginMail.Clear()
            '                        txtLoginPass.Clear()
            '                        MessageBox.Show("can't login")
            '                    End If
            '                End While

            '            Catch ex As Exception
            '                MessageBox.Show("メールアドレスか、パスワードが間違いました")
            '            Finally
            '                connection.Close()
            '            End Try
            '        End Using
            '    End Using

            'End If

            Dim frm As Form = New ShowUsers()
            'メールとパスが一致すれば、一覧画面、elseメッセージ出す
            If txtLoginMail.Text = "test" And txtLoginPass.Text = "pass" Then
                frm.Show()
                txtLoginMail.Clear()
                txtLoginPass.Clear()
            Else
                MessageBox.Show("メールアドレスか、パスワードが間違いました", "再度入力してください")
            End If
        End If
    End Sub
End Class
