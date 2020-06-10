Imports System.Data.SqlClient
Public Class EditUser
    'キャンセル処理
    Private Sub btnEditCancel_Click(sender As Object, e As EventArgs) Handles btnEditCancel.Click
        Close()
    End Sub
    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = CType(Me.Owner, ShowUsers).IDbox
        txtEditByID.Text = str
    End Sub

    Private Sub btnSrcForEdit_Click(sender As Object, e As EventArgs) Handles btnSrcForEdit.Click
        Using connection As New SqlConnection(My.Settings.connString)
            Dim sql As String = "select UserName,UserGender,UserDeparts,UserBirth,UserMail,UserTel,UserAddress,UserGra,UserSkill,UserImage from [Manage].[User] where UserID=@UserID"
            Using sqlCommand As New SqlCommand(sql, connection)
                sqlCommand.Parameters.Add(New SqlParameter("@UserID", SqlDbType.Int))
                sqlCommand.Parameters("@UserID").Value = txtEditByID.Text

                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader = sqlCommand.ExecuteReader()

                    While dataReader.Read()
                        txtEditName.Text = dataReader(0).ToString
                        pdEditGender.SelectedItem = dataReader(1).ToString
                        pdEditDeparts.SelectedItem = dataReader(2).ToString
                        dtpEditBirth.Value = dataReader(3).ToString
                        txtEditMail.Text = dataReader(4).ToString
                        txtEditTel.Text = dataReader(5).ToString
                        txtEditAddress.Text = dataReader(6).ToString
                        pdEditGra.SelectedItem = dataReader(7).ToString
                        txtEditSkill.Text = dataReader(8).ToString
                        PictureBox1.Load(dataReader(9).ToString)
                    End While
                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("no data can be edit")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub
    'update
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Using connection As New SqlConnection(My.Settings.connString)

            Using sqlCommand As New SqlCommand("Manage.uspUpdate", connection)
                sqlCommand.CommandType = CommandType.StoredProcedure
                'add userid input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserID", SqlDbType.Int))
                sqlCommand.Parameters("@UserID").Value = txtEditByID.Text
                'add username input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 40))
                sqlCommand.Parameters("@UserName").Value = txtEditName.Text
                'add usergender input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserGender", SqlDbType.NVarChar))
                sqlCommand.Parameters("@UserGender").Value = pdEditGender.SelectedItem
                'add userdeparts input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserDeparts", SqlDbType.NVarChar, 10))
                sqlCommand.Parameters("@UserDeparts").Value = pdEditDeparts.SelectedItem
                'add userbirth input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserBirth", SqlDbType.Date, 8))
                sqlCommand.Parameters("@UserBirth").Value = dtpEditBirth.Value
                'add usermail input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserMail", SqlDbType.NVarChar, 50))
                sqlCommand.Parameters("@UserMail").Value = txtEditMail.Text
                'add usertel input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserTel", SqlDbType.NVarChar, 13))
                sqlCommand.Parameters("@UserTel").Value = txtEditTel.Text
                'add useraddress input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserAddress", SqlDbType.NVarChar, 80))
                sqlCommand.Parameters("@UserAddress").Value = txtEditAddress.Text
                'add usergra input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserGra", SqlDbType.NVarChar, 8))
                sqlCommand.Parameters("@UserGra").Value = pdEditGra.SelectedItem
                'add userskill input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserSkill", SqlDbType.NVarChar, 20))
                sqlCommand.Parameters("@UserSkill").Value = txtEditSkill.Text

                Try
                    'open the connection
                    connection.Open()
                    'run the stored procedure
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("update succeed")
                Catch
                    MessageBox.Show("update failed")
                Finally
                    'close the connection
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub
End Class