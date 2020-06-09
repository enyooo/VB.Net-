Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class ShowUsers
    '新規画面へ遷移
    Private Sub btnGoToNew_Click(sender As Object, e As EventArgs) Handles btnGoToNew.Click
        Dim frm As Form = New NewUser()
        frm.Show()
    End Sub
    '編集画面へ遷移
    Private Sub btnGoToEdit_Click(sender As Object, e As EventArgs) Handles btnGoToEdit.Click
        Dim frm As Form = New EditUser()
        frm.Show()
    End Sub
    'ログアウト処理 
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Close()
    End Sub
    '検索処理
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'create the connection
        Using connection As New SqlConnection(My.Settings.connString)
            'define the query string 
            Dim sql As String = "select * from [Manage].[User] where UserName like N`%" & txtSrcName.Text & "%`"
            'create a sqlcommand object
            Using SqlCommand As New SqlCommand(sql, connection)

            End Using
        End Using
    End Sub
    '情報一覧
    Private Sub ShowUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create the connection
        Using connection As New SqlConnection(My.Settings.connString)
            'define the query string that search all users
            Const sql As String = "select * from [Manage].[User]"
            'create a sqlcommand object
            Using sqlCommand As New SqlCommand(sql, connection)

                Try
                    'open the connection
                    connection.Open()
                    'execute the query
                    Dim dataReader As SqlDataReader = sqlCommand.ExecuteReader()
                    'create a data table to hold the retrieved data
                    Dim dataTable As New DataTable()
                    'load the data from sqldatareader into the data table
                    dataTable.Load(dataReader)
                    'display the data from datatable in the datagridview
                    Me.dgvShowUsers.DataSource = dataTable
                    'close sqldatareader
                    dataReader.Close()
                Catch
                    MessageBox.Show("data could not be load")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub
    '検索で入力した内容をクリア
    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSrcName.Clear()
        pdSrcGender.SelectedValue = Nothing
        pdSrcDeparts.SelectedValue = Nothing
        txtSrcBirth.Clear()
        txtSrcMail.Clear()
        txtSrcTel.Clear()
        txtSrcAddress.Clear()
        pdSrcGra.SelectedValue = Nothing
        txtSrcSkill.Clear()

    End Sub


End Class