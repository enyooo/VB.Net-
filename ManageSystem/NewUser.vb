Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class NewUser
    '変数 
    Private userNameValue As String
    Private userGenderValue As String
    Private userDepartsValue As String
    Private userBirthValue As Date
    Private userMailValue As String
    Private userTelValue As String
    Private userAddressValue As String
    Private userGraValue As String
    Private userSkillValue As String
    Private userimage As String = ""
    '氏名プロパティ
    Public Property userName() As String
        Get
            Return userNameValue
        End Get
        Set(ByVal value As String)
            'エラーチェック
            If value.Length = 0 Then
                '未入力はエラー
                Throw New Exception("氏名を入力してください")
            Else
                ' If Regex.IsMatch(value, "") Then
                userNameValue = value
                ' Else
                'Throw New Exception("全角")
            End If
        End Set
    End Property
    '性別プロパティ
    Public Property userGender() As String
        Get
            Return userGenderValue
        End Get
        Set(ByVal value As String)
            'エラーチェック
            If value.Length = 0 Then
                Throw New Exception("性別を選択してください")
            Else
                userGenderValue = value
            End If
        End Set
    End Property
    '部署プロパティ
    Public Property userDeparts() As String
        Get
            Return userDepartsValue
        End Get
        Set(ByVal value As String)
            'error check
            If value.Length = 0 Then
                Throw New Exception("部署を選択してください")
            Else
                userDepartsValue = value
            End If
        End Set
    End Property
    '生年月日プロパティ
    Public Property userBirth() As Date
        Get
            Return userBirthValue
        End Get
        Set(ByVal value As DateTime)
            'error check
            If value.Date = Now Then
                Throw New Exception("生年月日を選択してください")
            Else
                userBirthValue = value
            End If
        End Set
    End Property
    'メールプロパティ
    Public Property userMail() As String
        Get
            Return userMailValue
        End Get
        Set(ByVal value As String)
            'error check
            If value.Length = 0 Then
                Throw New Exception("メールアドレスを入力してください")
            Else
                userMailValue = value
            End If
        End Set
    End Property
    '電話プロパティ
    Public Property userTel() As String
        Get
            Return userTelValue
        End Get
        Set(ByVal value As String)
            If value.Length = 0 Then
                Throw New Exception("電話番号を入力してください")
            Else
                userTelValue = value
            End If
        End Set
    End Property
    '住所プロパティ
    Public Property userAddress() As String
        Get
            Return userAddressValue
        End Get
        Set(ByVal value As String)
            If value.Length = 0 Then
                Throw New Exception("住所を入力してください")
            Else
                userAddressValue = value
            End If
        End Set
    End Property
    '学歴プロパティ
    Public Property userGra() As String
        Get
            Return userGraValue
        End Get
        Set(ByVal value As String)
            If value.Length = 0 Then
                Throw New Exception("学歴を選択してください")
            Else
                userGraValue = value
            End If
        End Set
    End Property
    '特技プロパティ
    Public Property userSkill() As String
        Get
            Return userSkillValue
        End Get
        Set(ByVal value As String)
            userSkillValue = value
        End Set
    End Property
    'close the window by using the cancel button 
    Private Sub btnAddCancel_Click(sender As Object, e As EventArgs) Handles btnAddCancel.Click
        Close()
    End Sub
    'check if input already exist
    Public Sub checkInput()
        'Dim check = userName() + userGender() + userDeparts() + userBirth() + userMail() + userTel() + userAddress() + userGra()

    End Sub
    '入力した内容を保存する by running Manage.upNewUser stored procedure
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'create the SqlConnection object
        Using connection As New SqlConnection(My.Settings.connString)
            'create a sqlcommand,identify the command type as stored procedure
            Using sqlCommand As New SqlCommand("Manage.upNewUser", connection)
                sqlCommand.CommandType = CommandType.StoredProcedure
                'add username input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 40))
                sqlCommand.Parameters("@UserName").Value = txtAddName.Text
                'add usergender input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserGender", SqlDbType.NVarChar))
                sqlCommand.Parameters("@UserGender").Value = pdAddGender.SelectedItem
                'add userdeparts input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserDeparts", SqlDbType.NVarChar, 10))
                sqlCommand.Parameters("@UserDeparts").Value = pdAddDeparts.SelectedItem
                'add userbirth input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserBirth", SqlDbType.Date, 8))
                sqlCommand.Parameters("@UserBirth").Value = dtpAddBirth.Value
                'add usermail input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserMail", SqlDbType.NVarChar, 50))
                sqlCommand.Parameters("@UserMail").Value = txtAddMail.Text
                'add usertel input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserTel", SqlDbType.NVarChar, 13))
                sqlCommand.Parameters("@UserTel").Value = txtAddTel.Text

                'add useraddress input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserAddress", SqlDbType.NVarChar, 80))
                sqlCommand.Parameters("@UserAddress").Value = txtAddAddress.Text
                'add usergra input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserGra", SqlDbType.NVarChar, 8))
                sqlCommand.Parameters("@UserGra").Value = pdAddGra.SelectedItem
                'add userskill input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserSkill", SqlDbType.NVarChar, 20))
                sqlCommand.Parameters("@UserSkill").Value = txtAddSkill.Text
                'add userimage input parament
                sqlCommand.Parameters.Add(New SqlParameter("@UserImage", SqlDbType.NVarChar, 100))
                sqlCommand.Parameters("@UserImage").Value = userimage

                Try
                    'open the connection
                    connection.Open()
                    'run the stored procedure
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("新規完了")
                Catch
                    MessageBox.Show("新規できない")
                Finally
                    'close the connection
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub
    'add picture
    Private Sub btnAddPic_Click(sender As Object, e As EventArgs) Handles btnAddPic.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
            'transfer image to C:img folder
            Dim temp As String = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            Dim path As String = "C:\img\" + temp
            Try
                System.IO.File.Copy(OpenFileDialog1.FileName, path)
            Catch ex As Exception
                MessageBox.Show("could not copy")
            End Try
            userimage = path
        End If
    End Sub
    'clear picture
    Private Sub btnCancelPic_Click(sender As Object, e As EventArgs) Handles btnCancelPic.Click
        PictureBox1.Image = Nothing
        userimage = ""
    End Sub
End Class