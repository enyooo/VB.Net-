Public Class Form1
    Private random As New Random
    Private icons = New List(Of String) From {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"}
    ' 1 つ目のラベルがクリックされると、プログラムではラベルのアイコンを表示します。
    'クリックする前には殻
    Private firstClicked As Label = Nothing
    ' 2 つ目のラベルがクリックする
    Private secondClicked As Label = Nothing
    'ゲーム時間を減る変数
    Private timeLeft As Integer

    'アイコンを生成
    Private Sub AssignIconsToSquares()
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            iconLabel.ForeColor = iconLabel.BackColor
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                icons.RemoveAt(randomNumber)
            End If
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssignIconsToSquares()
        timeLeft = 30


    End Sub
    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label9.Click,
        Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click,
        Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click,
        Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

        '二つのアイコンが違う時だけタイマーを起動
        If Timer1.Enabled Then Exit Sub

        Dim clickedLabel = TryCast(sender, Label)
        '二番目のアイコンは空じゃない、ユーザーも二回クリックしたとき、
        'リセットされてなかったら、二回目のクリックを無視
        If secondClicked IsNot Nothing Then Exit Sub

        If clickedLabel IsNot Nothing Then
            'アイコンが表示されている状態だと、クリックを無視
            If clickedLabel.ForeColor = Color.Black Then Exit Sub
            'アイコンを表示、subを退出
            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Exit Sub
            End If
            '二回目のクリック、アイコンを表示
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black
            'ユーザーが優勝するかどうかをチェック
            CheckForWinner()
            '同じアイコンの場合、アイコンペアを維持、クリックした状態をリセット
            If firstClicked.Text = secondClicked.Text Then
                firstClicked = Nothing
                secondClicked = Nothing
                Exit Sub
            End If
            '二つのアイコンが違ったっら、タイマーを起動
            Timer1.Start()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'タイマーを停止
        Timer1.Stop()
        'アイコンを隠す
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor
        'クリックした状態をリセット、次回重複
        firstClicked = Nothing
        secondClicked = Nothing

    End Sub
    Private Sub CheckForWinner()
        'すべてのラベルを見て、アイコンが一致するかどうかを確認する
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing AndAlso
                    iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
        Next
        Timer2.Stop()
        'ループ完了だったら、ユーザー優勝、msgを表示
        MessageBox.Show("You matched all the icons!", "Congratulations!")
        Close()
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        timeLeft -= 1
        If timeLeft = 0 Then
            MessageBox.Show("It's time!!", "Oops!")
        End If
        CheckForWinner()
    End Sub
End Class
