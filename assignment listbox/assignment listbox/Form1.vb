Public Class Form1

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        lstbox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub btmrmv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmrmv.Click
        lstbox1.Items.Remove(lstbox1.SelectedItem)
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        lstbox1.Items.Clear()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
