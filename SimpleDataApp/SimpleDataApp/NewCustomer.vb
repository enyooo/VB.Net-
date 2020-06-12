Imports System.Data.SqlClient
Public Class NewCustomer
    'DBから返したIDを保存
    Private parsedCustomerID As Integer
    Private orderID As Integer
    '検証顧客名有効
    Private ReadOnly Property IsCustomerNameValid As Boolean
        Get
            If txtCustomerName.Text = "" Then
                MessageBox.Show("Please enter a name.")
                Return False
            Else
                Return True
            End If
        End Get
    End Property
    '検証注文データ有効
    Private Function IsOrderDataValid() As Boolean
        '認証顧客ID存在
        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please create a customer account before placing order.")
            Return False
            '認証注文数0じゃない
        ElseIf (numOrderAmount.Value < 1) Then
            MessageBox.Show("Please specify an order amount.")
            Return False
        Else
            '注文申請可
            Return True
        End If
    End Function
    'コントロールの値をクリア
    Private Sub ClearForm()
        txtCustomerName.Clear()
        txtCustomerID.Clear()
        dtpOrderDate.Value = DateTime.Now
        numOrderAmount.Value = 0
        Me.parsedCustomerID = 0
    End Sub
    'Sales.uspNewCustomerで新規
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        '顧客名有効
        If IsCustomerNameValid Then
            'sql接続プロジェクトを作成
            Using connection As New SqlConnection(My.Settings.connString)
                '生成sqlコマンド、ストアドプロシージャとして識別
                Using sqlCommand As New SqlCommand("Sales.uspNewCustomer", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure
                    'ストアドプロシージャの@customernamer パラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerName", SqlDbType.NVarChar, 40))
                    sqlCommand.Parameters("@CustomerName").Value = txtCustomerName.Text
                    '@customerid 出力パラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
                    sqlCommand.Parameters("@CustomerID").Direction = ParameterDirection.Output

                    Try
                        '接続を開始
                        connection.Open()
                        'ストアドプロシージャを実行
                        sqlCommand.ExecuteNonQuery()
                        '顧客IDをintegerに変換
                        Me.parsedCustomerID = CInt(sqlCommand.Parameters("@CustomerID").Value)
                        'IDを対応するtext boxに挿入
                        Me.txtCustomerID.Text = Convert.ToString(parsedCustomerID)
                    Catch
                        MessageBox.Show("Customer ID was not returned.Account could not be created.")
                    Finally
                        '接続を閉じる
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub
    '実行Sales.uspPlaceNewOrderで注文    
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If IsOrderDataValid() Then
            '接続を作成
            Using connection As New SqlConnection(My.Settings.connString)
                '生成sqlコマンド、ストアドプロシージャとして識別
                Using sqlCommand As New SqlCommand("Sales.uspPlaceNewOrder", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure
                    'uspNewCustomerから@CustomerID　パラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
                    sqlCommand.Parameters("@CustomerID").Value = Me.parsedCustomerID
                    '@OderDate パラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@OrderDate", SqlDbType.DateTime, 8))
                    sqlCommand.Parameters("@OrderDate").Value = dtpOrderDate.Value
                    '@Amountパラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@Amount", SqlDbType.Int))
                    sqlCommand.Parameters("@Amount").Value = numOrderAmount.Value
                    '@Statusパラメータを追加、新規注文だと、いつも0
                    sqlCommand.Parameters.Add(New SqlParameter("@Status", SqlDbType.[Char], 1))
                    sqlCommand.Parameters("@Status").Value = "0"
                    'ストアドプロシージャの戻り値@OrderIDパラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@RC", SqlDbType.Int))
                    sqlCommand.Parameters("@RC").Direction = ParameterDirection.ReturnValue

                    Try
                        '接続を開始
                        connection.Open()
                        'ストアドプロシージャを実行
                        sqlCommand.ExecuteNonQuery()
                        '注文数を表示
                        Me.orderID = CInt(sqlCommand.Parameters("@RC").Value)
                        MessageBox.Show("Order number" & (Me.orderID).ToString & "has been submitted.")
                    Catch
                        MessageBox.Show("Order could not be placed.")
                    Finally
                        '使用完了接続を切断
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub
    '新規アカウントのためフォームをリセット
    Private Sub btnAddAnotheAccount_Click(sender As Object, e As EventArgs) Handles btnAddAnotheAccount.Click
        Me.ClearForm()
    End Sub
    '新規アカウント画面を閉じて、ナビゲーションに戻る
    Private Sub btnAddFinish_Click(sender As Object, e As EventArgs) Handles btnAddFinish.Click
        Me.Close()
    End Sub
End Class
