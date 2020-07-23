Public Class Form1

    
    Private Sub btnadd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd1.Click
        If lstbox1.Items.Contains(txt1.Text) Then
            MsgBox("Inserted item is already in the listbox")
        ElseIf txt1.Text Is Nothing Then
            MsgBox("Please insert some string")
        Else
            lstbox1.Items.Add(txt1.Text)
        End If

    End Sub

    Private Sub btnadd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd2.Click
        If lstbox2.Items.Contains(txt2.Text) Then
            MsgBox("Inserted item is already in the listbox")
        ElseIf txt2.Text Is Nothing Then
            MsgBox("Please insert some string")
        Else
            lstbox2.Items.Add(txt2.Text)
        End If
    End Sub

    Private Sub btnrmv1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrmv1.Click
        txtrmv1.Text = lstbox1.SelectedItem
        If lstbox1.SelectedItem Is Nothing Then
            MsgBox("select item to be removed")
        Else
            lstbox1.Items.Remove(lstbox1.SelectedItem)
        End If

    End Sub

    Private Sub btnrmv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrmv2.Click
        txtrmv2.Text = lstbox2.SelectedItem
        If lstbox2.SelectedItem Is Nothing Then
            MsgBox("select item to be removed")
        Else
            lstbox2.Items.Remove(lstbox2.SelectedItem)
        End If
    End Sub

    Private Sub btnrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrs.Click
        If lstbox1.SelectedItem Is Nothing Then
            MsgBox("select item to be move")
        Else
            lstbox2.Items.Add(lstbox1.SelectedItem)
            lstbox1.SelectedItem.remove()
        End If

    End Sub

    Private Sub btnls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnls.Click
        If lstbox2.SelectedItem Is Nothing Then
            MsgBox("select item to be move")
        Else
            lstbox1.Items.Add(lstbox2.SelectedItem)
        End If

    End Sub
End Class
