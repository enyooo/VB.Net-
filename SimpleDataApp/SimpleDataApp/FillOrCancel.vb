Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FillOrCancel
    'Orderid 変数
    Private parsedOrderID As Integer
    '認証OrderID有効
    Private Function IsOrderIDValid() As Boolean
        'id text boxに入力した内容を検査
        If txtOrderID.Text = "" Then
            MessageBox.Show("Please specify the Order ID.")
            Return False
            'integer以外の文字を確認    
        ElseIf Regex.IsMatch(txtOrderID.Text, "^\D*$") Then
            'メッセージを表示、入力した内容をクリア
            MessageBox.Show("Please specify integers only.")
            txtOrderID.Clear()
            Return False
        Else
            'textboxの内容を整数に変換し、DBへ送る
            parsedOrderID = Integer.Parse(txtOrderID.Text)
            Return True
        End If
    End Function
    Private Sub FillOrCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '検索ボタン  
    Private Sub btnFindByOrderID_Click(sender As Object, e As EventArgs) Handles btnFindByOrderID.Click
        '接続と命令を準備
        If IsOrderIDValid() Then
            '接続を新規
            Using connection As New SqlConnection(My.Settings.connString)
                '@orderIDパラメータを持つクエリ文字列を定義する
                Const sql As String = "select*from Sales.Orders where orderID=@orderID"
                'sqlCommandオブジェクトを新規
                Using SqlCommand As New SqlCommand(sql, connection)
                    '@orderidパラメータと値を定義する
                    SqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    SqlCommand.Parameters("@orderID").Value = parsedOrderID

                    Try
                        '接続を開始
                        connection.Open()
                        'クエリを実行
                        Dim dataReader As SqlDataReader = SqlCommand.ExecuteReader()
                        '取得したデータを保持するtableを作成する
                        Dim dataTable As New DataTable()
                        'sqlDataReaderからtableにデータを読み込み
                        dataTable.Load(dataReader)
                        'datagridviewでtableのデータを表示する
                        Me.dgvCustomerOrders.DataSource = dataTable
                        'sqlDataReaderを閉じる
                        dataReader.Close()

                    Catch
                        MessageBox.Show("The requested order could not be loaded into the form.")
                    Finally
                        '接続を閉じる
                        connection.Close()

                    End Try
                End Using
            End Using

        End If
    End Sub
    'DBでSales.uspFillOrderストアドプロシージャを実行して、注文を入力
    Private Sub btnFillOrder_Click(sender As Object, e As EventArgs) Handles btnFillOrder.Click
        'orderid有効な場合にのみ、ストアドプロシージャをセットアップして実行する   
        If IsOrderIDValid() Then
            '接続を新規
            Using connection As New SqlConnection(My.Settings.connString)
                'コマンドを作成し、ストアドプロシージャとして識別する
                Using sqlCommand As New SqlCommand("Sales.uspFillOrder", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure
                    'input @orderIDパラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID
                    'input @FilledDateパラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@FilledDate", SqlDbType.DateTime, 8))
                    sqlCommand.Parameters("@FilledDate").Value = dtpFillDate.Value

                    Try
                        '接続を開始
                        connection.Open()
                        'sqlcommandを実行
                        sqlCommand.ExecuteNonQuery()

                    Catch
                        MessageBox.Show("The fill operation was not completed.")
                    Finally
                        '接続を閉じる
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub
    'DBでSales.uspCancelOrderストアドプロシージャを実行して、注文をキャンセルする
    Private Sub ButtonbtnCancelOrder_Click(sender As Object, e As EventArgs) Handles ButtonbtnCancelOrder.Click
        'ID有効だったら、セットアップして、実行する
        If IsOrderIDValid() Then
            '接続を新規
            Using connection As New SqlConnection(My.Settings.connString)
                '
                Using sqlCommand As New SqlCommand("Sales.uspCancelOrder", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure
                    '@orderIDパラメータを追加
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID

                    Try
                        connection.Open()
                        sqlCommand.ExecuteNonQuery()

                    Catch
                        MessageBox.Show("the cancel operation was not completed.")
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub
    'フォームを閉じて、ナビゲーションに戻る
    Private Sub btnFinishUpdates_Click(sender As Object, e As EventArgs) Handles btnFinishUpdates.Click
        Me.Close()
    End Sub
End Class