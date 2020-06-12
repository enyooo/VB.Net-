Public Class Form1
    '乱数を生成
    Dim randomizer As New Random
    '加算整数変数
    Private addend1 As Integer
    Private addend2 As Integer
    '減算整数変数
    Private minuend As Integer
    Private subtrahend As Integer
    '乗算整数変数
    Private multiplicand As Integer
    Private multiplier As Integer
    '除算整数変数
    Private dividend As Integer
    Private divisor As Integer
    '時間を減る変数
    Private timeLeft As Integer


    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        StartTheQuiz()
        'start button使用不可
        startButton.Enabled = False

    End Sub

    Public Function StartTheQuiz()
        '加算問題乱数を生成
        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)
        '加算問題ラベルに生成したランスを表示
        plusLeftLabel.Text = addend1.ToString()
        plusRightLabel.Text = addend2.ToString()
        '加算解答欄を0
        sum.Value = 0
        '減算問題を生成
        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString()
        minusRightLabel.Text = subtrahend.ToString()
        difference.Value = 0
        '乗算問題を生成
        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        timesLeftLabel.Text = multiplicand.ToString()
        timesRightLabel.Text = multiplier.ToString()
        product.Value = 0
        '除算問題を生成
        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient
        dividedLeftLabel.Text = dividend.ToString()
        dividedRightLabel.Text = divisor.ToString()
        quotient.Value = 0
        'タイマーを開始
        timeLeft = 30
        timeLabel.Text = "30  seconds"
        Timer1.Start()
    End Function

    Public Function CheckTheAnswer() As Boolean
        If addend1 + addend2 = sum.Value AndAlso
           minuend - subtrahend = difference.Value AndAlso
           multiplicand * multiplier = product.Value AndAlso
          dividend / divisor = quotient.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckTheAnswer() Then
            '正解だったら、msgを出し、タイマーを停止
            Timer1.Stop()
            MessageBox.Show("You got all of the answers right!", "Congratulations!")
            'start button使用可能
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            '時間が5秒になったら、タイマーが赤になる
            If timeLeft < 6 Then
                timeLabel.BackColor = Color.Red
            End If
            timeLeft -= 1
            timeLabel.Text = timeLeft & "seconds"

        Else
            '時間になって、タイマーを停止し、msgを出す
            Timer1.Stop()
            timeLabel.Text = "Time is up!"
            MessageBox.Show("You didn`t finish in time.")
            sum.Value = addend1 + addend2
            difference.Value = minuend - subtrahend
            product.Value = multiplicand * multiplier
            quotient.Value = dividend / divisor
            startButton.Enabled = True
        End If
    End Sub

    Private Sub answer_Enter(sender As Object, e As EventArgs) Handles sum.Enter, quotient.Enter, product.Enter, difference.Enter
        Dim answerBox = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If
    End Sub

End Class
