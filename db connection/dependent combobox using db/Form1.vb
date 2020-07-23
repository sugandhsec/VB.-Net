Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\sybca\b2\db connection\db connection\bookdb.mdb")
    Dim ds As New DataSet()
    Dim ds2 As New DataSet()
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCmb()
    End Sub

    Public Sub fillCmb()
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select * from tblcategory", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        cmbCat.ValueMember = "catid"
        cmbCat.DisplayMember = "catname"
        cmbCat.DataSource = ds.Tables(0)
    End Sub

    Private Sub cmbSubcat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubcat.SelectedIndexChanged
        
    End Sub

    Private Sub cmbCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCat.SelectedIndexChanged
        ds2.Clear()
        cn.Open()
        cmd = New OleDbCommand("select * from tblsubcategory where catid=" + cmbCat.SelectedValue.ToString(), cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds2)
        cn.Close()
        cmbSubcat.ValueMember = "subcatid"
        cmbSubcat.DisplayMember = "subcatname"
        cmbSubcat.DataSource = ds2.Tables(0)
    End Sub
End Class
