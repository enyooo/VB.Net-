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
    Private Sub btnGoToEdit_Click(sender As Object, e As EventArgs)
        Dim frm As Form = New EditUser()
        frm.Show()
    End Sub
    'ログアウト処理 
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Close()
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
    '削除処理
    Private Sub btnDeleteByID_Click(sender As Object, e As EventArgs) Handles btnDeleteByID.Click
        'create the connection
        Using connection As New SqlConnection(My.Settings.connString)
            'define the query that search user by id
            Dim sql As String = "delete from [Manage].[User] where UserID='" & txtSrcID.Text & "'"
            'create a sqlcommand object
            Using sqlCommand As New SqlCommand(sql, connection)
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader = sqlCommand.ExecuteReader()
                    dataReader.Close()
                Catch
                    MessageBox.Show("data could not be delete")
                End Try
            End Using
        End Using
    End Sub
    '検索処理
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'create the connection
        Using connection As New SqlConnection(My.Settings.connString)
            'define the query string 
            Dim sqlselect As String = "" + "select * from [Manage].[User]"
            Dim sqlwhere As String = ""

            'search name
            If txtSrcName.Text = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserName like N'%" & txtSrcName.Text & "%'"
            End If
            'search gender
            If pdSrcGender.SelectedItem = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserGender like N'%" & pdSrcGender.SelectedItem & "%'"
            End If
            'search departs
            If pdSrcDeparts.SelectedItem = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserDeparts like N'%" & pdSrcDeparts.SelectedItem & "%'"
            End If
            'search birth
            If txtSrcBirth.Text = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserBirth like N'%" & txtSrcBirth.Text & "%'"
            End If
            'search mail
            If txtSrcMail.Text = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserMail like N'%" & txtSrcMail.Text & "%'"
            End If
            'search tel
            If txtSrcTel.Text = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserTel like N'%" & txtSrcTel.Text & "%'"
            End If
            'search address
            If txtSrcAddress.Text = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserAddress like N'%" & txtSrcAddress.Text & "%'"
            End If
            'search graduation
            If pdSrcGra.SelectedItem = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + " UserGra like N'%" & pdSrcGra.SelectedItem & "%'"
            End If
            'search skill
            If txtSrcSkill.Text = "" Then
            Else
                sqlwhere += IIf(sqlwhere = "", " WHERE", "AND") + "UserSkill like N'%" & txtSrcSkill.Text & "%'"
            End If

            Dim sql As String = sqlselect + sqlwhere
            Console.WriteLine(sql)

            'create a sqlcommand object
            Using SqlCommand As New SqlCommand(sql, connection)
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader = SqlCommand.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(dataReader)
                    Me.dgvShowUsers.DataSource = dataTable
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
        pdSrcGender.Text = pdSrcGender.GetItemText(pdSrcGender.Items(0))
        pdSrcDeparts.Text = pdSrcDeparts.GetItemText(pdSrcDeparts.Items(0))
        txtSrcBirth.Clear()
        txtSrcMail.Clear()
        txtSrcTel.Clear()
        txtSrcAddress.Clear()
        pdSrcGra.Text = pdSrcGra.GetItemText(pdSrcGra.Items(0))
        txtSrcSkill.Clear()
    End Sub
    'フォームインスタンス
    Private Shared formInstance As ShowUsers
    Public Shared Property ShowuserInstance() As ShowUsers
        Get
            Return formInstance
        End Get
        Set(ByVal Value As ShowUsers)
            formInstance = Value
        End Set
    End Property
    '入力したIDを取得するプロパティ
    Public Property IDbox() As String
        Get
            Return txtSrcID.Text
        End Get
        Set(ByVal Value As String)
            txtSrcID.Text = Value
        End Set
    End Property
    Private Sub btnEditByID_Click(sender As Object, e As EventArgs) Handles btnEditByID.Click
        Dim f As New EditUser
        '一覧画面情報を編集画面に渡す 
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
End Class