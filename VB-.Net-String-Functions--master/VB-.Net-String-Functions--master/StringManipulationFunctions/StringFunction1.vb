Public Class StringFunction1
    Dim str As String
    Private Sub btnlen_Click(sender As System.Object, e As System.EventArgs) Handles btnlen.Click
        str = txtstr.Text
        txtlen.Text = Len(str)
    End Sub

    Private Sub btnleft_Click(sender As System.Object, e As System.EventArgs) Handles btnleft.Click
        Dim cnt As Integer
        str = txtstr.Text
        cnt = txtcnt.Text
        txtleft.Text = Strings.Left(str, cnt)
    End Sub


    Private Sub btnright_Click(sender As System.Object, e As System.EventArgs) Handles btnright.Click
        Dim cnt As Integer
        str = txtstr.Text
        cnt = txtcnt1.Text
        txtright.Text = Strings.Right(str, cnt)
    End Sub

    Private Sub btnasc_Click(sender As System.Object, e As System.EventArgs) Handles btnasc.Click
        Dim ch As Char
        ch = txtcnt2.Text
        txtasc.Text = Asc(ch)
    End Sub


    Private Sub btnlcase_Click(sender As System.Object, e As System.EventArgs) Handles btnlcase.Click
        str = txtstr.Text
        txtlcase.Text = LCase(str)
    End Sub

    Private Sub btnucase_Click(sender As System.Object, e As System.EventArgs) Handles btnucase.Click
        str = txtstr.Text
        txtucase.Text = UCase(str)
    End Sub

    Private Sub btnrev_Click(sender As System.Object, e As System.EventArgs) Handles btnrev.Click
        str = txtstr.Text
        txtrev.Text = StrReverse(str)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        StringFunction2.Show()
    End Sub
End Class
