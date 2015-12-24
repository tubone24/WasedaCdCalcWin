Public Class Form1
    Private Sub Calc_Click(sender As Object, e As System.EventArgs) Handles Calc.Click
        Dim input_check_digit = TextBoxSId.Text

        If System.Text.RegularExpressions.Regex.IsMatch( _
        TextBoxSId.Text, "^[A-I0-9]{8}$") Then '学籍番号形式確認
            TextBoxAnswer.Text = calcCd(replaceSn(TextBoxSId.Text))
        Else
            MsgBox("ちゃんと学籍番号入力して！")

        End If
    End Sub

    Function replaceSn(inputN) 'アルファベットを数字に変換
        Dim after_cd
        Dim input_check_digit = inputN
        after_cd = input_check_digit.replace("A", "1")
        after_cd = after_cd.replace("B", "2")
        after_cd = after_cd.replace("C", "3")
        after_cd = after_cd.replace("D", "4")
        after_cd = after_cd.replace("E", "5")
        after_cd = after_cd.replace("F", "6")
        after_cd = after_cd.replace("G", "7")
        after_cd = after_cd.replace("H", "8")
        after_cd = after_cd.replace("I", "9")
        Return after_cd
    End Function

    Function calcCd(ByVal input_check_digit)
        Dim split_cdc() As Char = input_check_digit.ToCharArray '入力をChar型の配列に落とす
        Dim split_cdi(8) As Integer
        For i = 0 To 7
            split_cdi(i) = Integer.Parse(split_cdc(i)) '計算するために数値変換
        Next
        Dim answer = 11 - (split_cdi(1) * 2 + split_cdi(3) * 3 + split_cdi(4) * 4 + split_cdi(5) * 5 + split_cdi(6) * 6 + split_cdi(7) * 7) Mod 11
        Return answer
    End Function


End Class
