Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim itemlist As New ArrayList
        itemlist.Add("Item 4")
        itemlist.Add("Item 12")
        itemlist.Add("Item 5")
        itemlist.Add("Item 56")
        MsgBox("Shows Added Items")
        For i = 0 To itemlist.Count - 1
            MsgBox(itemlist.Item(i))
        Next
    End Sub
End Class
