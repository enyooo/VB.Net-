Public Class ナビゲーション
    '新規画面に遷移
    Private Sub btnGoToAdd_Click(sender As Object, e As EventArgs) Handles btnGoToAdd.Click
        Dim frm As Form = New NewCustomer()
        frm.Show()
    End Sub
    '注文画面に遷移
    Private Sub btnGoToFillOrCancel_Click(sender As Object, e As EventArgs) Handles btnGoToFillOrCancel.Click
        Dim frm As Form = New FillOrCancel()
        frm.ShowDialog()
    End Sub
    '画面を退出
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
