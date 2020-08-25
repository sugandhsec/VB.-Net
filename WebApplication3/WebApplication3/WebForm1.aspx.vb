Public Class WebForm1


    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim g() As String = {"surat", "vapi", "valsad"}

        If DropDownList1.SelectedItem.Text.ToString = "gujarat" Then
            DropDownList2.DataSource = g

            DropDownList2.DataBind()
        End If
    End Sub


    Protected Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).Selected = True Then
                ListBox2.Items(i).Selected = True
            End If
        Next
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim i As Integer, total As Integer = 0
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox2.Items(i).Selected Then
                total = total + Val(ListBox2.Items(i).ToString)
            End If
        Next
        TextBox1.Text = total
    End Sub


    Protected Sub chklstboxlang_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chklstboxlang.SelectedIndexChanged
        Dim i As Integer
        lstboxlang.Items.Clear()
        For i = 0 To chklstboxlang.Items.Count - 1
            If chklstboxlang.Items(i).Selected Then

                lstboxlang.Items.Add(chklstboxlang.Items(i).ToString)

            End If
        Next


    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If RadioButtonList1.SelectedItem.ToString = "FY" Then

        End If
    End Sub
End Class