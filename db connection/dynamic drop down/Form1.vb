Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\sybca\b2\db connection\db connection\bookdb.mdb")
    Dim cn2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\sybca\b2\db connection\db connection\bookdb.mdb")
    Dim ds As New DataSet()
    Dim ds2 As New DataSet()
    Dim cmd As OleDbCommand
    Dim cmd2 As OleDbCommand
    Dim adp As OleDbDataAdapter

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fildrp()
    End Sub

    Public Sub fildrp()
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select * from tblcategory", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()

        cmbCategory.DisplayMember = "catname"
        cmbCategory.ValueMember = "catid"
        cmbCategory.DataSource = ds.Tables(0)
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        MsgBox(cmbCategory.SelectedValue)
        MsgBox(cmbCategory.SelectedText)
        cn2.Open()
        cmd2 = New OleDbCommand("select * from tblsubcategory where `catid`=" + cmbCategory.SelectedValue, cn2)
        cn2.Close()


    End Sub
End Class
