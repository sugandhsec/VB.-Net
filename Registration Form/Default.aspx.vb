
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnsub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsub.Click
        lbladdh.Text = "ADDRESS:"
        lblcityh.Text = "CITY:"
        lblfnameh.Text = "FIRST NAME:"
        lbllnameh.Text = "LAST NAME:"
        lbldobh.Text = "DATE OF BIRTH:"
        lblmobh.Text = "MOBILE NO:"
        lblgenh.Text = "GENDER:"
        lblhobh.Text = "HOBBIES:"

        lbladdv.Text = txtadd.Text
        lblcityv.Text = txtcity.Text
        lblfnamev.Text = txtfname.Text
        lbllnamev.Text = txtlname.Text
        lbldobv.Text = txtdob.Text
        lblmobv.Text = txtmob.Text
        If rbtnmal.Checked Then
            lblgenv.Text = "MALE"
        ElseIf rbtnfem.Checked Then
            lblgenv.Text = "FEMALE"

        End If
        Dim hob As String = ""
        If chkb1.Checked Then
            hob = chkb1.Text + ","

            If chkb2.Checked Then
                hob += chkb2.Text + ","

                If chkb3.Checked Then
                    hob += chkb3.Text + ""
                End If
            End If
        End If
        lblhobv.Text = hob
    End Sub
End Class
