Imports System.String
Public Class StringFunction2
    Dim str As String
    Private Sub btnmid_Click(sender As System.Object, e As System.EventArgs) Handles btnmid.Click
        str = txtstr.Text
        Dim pos As Integer
        Dim no As Integer
        pos = txtpos.Text
        no = txtnoc.Text
        txtmid.Text = Mid(str, pos, no)
    End Sub

    Private Sub btninstr_Click(sender As System.Object, e As System.EventArgs) Handles btninstr.Click
        str = txtstr.Text
        Dim wd As String
        wd = txtword.Text
        txtinstr.Text = InStr(1, str, wd)
    End Sub


    Private Sub btnrtrim_Click(sender As System.Object, e As System.EventArgs) Handles btnrtrim.Click
        str = txtstr.Text
        txtrtrim.Text = RTrim(str)
    End Sub

    Private Sub btnltrim_Click(sender As System.Object, e As System.EventArgs) Handles btnltrim.Click
        str = txtstr.Text
        txtltrim.Text = LTrim(str)
    End Sub

    Private Sub btnchar_Click(sender As System.Object, e As System.EventArgs) Handles btnchar.Click
        Dim cd As Integer
        cd = txtgascii.Text
        txtchar.Text = Chr(cd)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        StringFunction1.Show()
    End Sub
End Class