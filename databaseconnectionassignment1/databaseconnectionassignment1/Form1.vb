Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\VB.net\databaseconnectionassignment1\enrolldb.mdb")
    Dim ds As New DataSet
    Dim cmd As New OleDbCommand
    Dim adp As OleDbDataAdapter
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim str As String
        Dim newds As New DataSet
        str = "select * from enroltbl "
        adp = New OleDbDataAdapter(str, cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        cn.Open()
        Dim str As String
        str = "insert into enroltbl values (" + txteno.Text + ",'" + txtname.Text + "','" + DateTimePicker1.Text + "'," + txtdur.Text + ",'" + txtcoourse.Text + "'," + txtapaid.Text + "," + txtbal.Text + ") "
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        MsgBox("ADDED")
        cn.Close()
    End Sub

    Private Sub btndel_Click(sender As System.Object, e As System.EventArgs) Handles btndel.Click
        cn.Open()
        Dim str As String
        str = "delete from enroltbl where eno=" + txteno.Text + ""
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Deleted")
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
          End Sub
End Class
