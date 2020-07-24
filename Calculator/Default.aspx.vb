
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub btnadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.Click
        txtans.Text = Convert.ToInt32(txtnum1.Text) + Convert.ToInt32(txtnum2.Text)
    End Sub

    Protected Sub btnsub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsub.Click
        txtans.Text = txtnum1.Text - txtnum2.Text
    End Sub

    Protected Sub btnmul_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnmul.Click
        txtans.Text = txtnum1.Text * txtnum2.Text
    End Sub

    Protected Sub btndiv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndiv.Click
        txtans.Text = txtnum1.Text / txtnum2.Text
    End Sub
End Class
