Public Class for_loop
    Dim cnt As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Do
            ListBox1.Items.Add(cnt)
            cnt = cnt + 1
        Loop While cnt < 10

       


    End Sub
End Class
