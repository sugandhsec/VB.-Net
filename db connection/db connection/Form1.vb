Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\sybca\b2\db connection\db connection\bookdb.mdb")
    Dim ds As New DataSet()
    Dim ds2 As New DataSet()
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
        fillCmb()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        cn.Open()
        cmd = New OleDbCommand("insert into tblbook (`bookname`,`author`,`price`,`isbn`,`catid`) values ('" + txtBname.Text + "','" + txtAname.Text + "'," + txtPrice.Text + ",'" + txtIsbn.Text + "'," + cmbCat.SelectedValue.ToString() + ")", cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        fillgrid()
    End Sub
    Public Sub fillgrid()
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select b.bookid,b.bookname,b.author,b.price,b.isbn,c.catname from tblbook b,tblcategory c where c.catid=b.catid", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        grdBook.DataSource = ds.Tables(0)
    End Sub
    Public Sub fillCmb()
        ds2.Clear()
        cn.Open()
        cmd = New OleDbCommand("select * from tblcategory", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds2)
        cn.Close()
        cmbCat.ValueMember = "catid"
        cmbCat.DisplayMember = "catname"
        cmbCat.DataSource = ds2.Tables(0)

        cmbSearchCat.ValueMember = "catid"
        cmbSearchCat.DisplayMember = "catname"
        cmbSearchCat.DataSource = ds2.Tables(0)
    End Sub
    Public Sub clear_controls()
        txtAname.Text = ""
        txtBname.Text = ""
        txtIsbn.Text = ""
        txtPrice.Text = ""
        txtBid.Text = ""
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        cn.Open()
        cmd = New OleDbCommand("delete from tblbook where `bookid`=" + txtBid.Text, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        fillgrid()
        clear_controls()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        cn.Open()
        cmd = New OleDbCommand("update tblbook set `bookname`='" + txtBname.Text + "',`author`='" + txtAname.Text + "',`price`=" + txtPrice.Text + ",`isbn`='" + txtIsbn.Text + "' where `bookid`=" + txtBid.Text, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        fillgrid()
        clear_controls()
    End Sub

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select b.bookid,b.bookname,b.author,b.price,b.isbn,c.catname from tblbook b,tblcategory c where c.catid=b.catid and `author`='" + txtAnameSearch.Text + "'", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        grdBook.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fillgrid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select b.bookid,b.bookname,b.author,b.price,b.isbn,c.catname from tblbook b,tblcategory c where c.catid=b.catid and `price`>=" + txtMin.Text + " and `price`<=" + txtMax.Text, cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        grdBook.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select b.bookid,b.bookname,b.author,b.price,b.isbn,c.catname from tblbook b,tblcategory c where c.catid=b.catid order by `bookname`", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        grdBook.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select b.bookid,b.bookname,b.author,b.price,b.isbn,c.catname from tblbook b,tblcategory c where c.catid=b.catid order by `price`", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        grdBook.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select b.bookid,b.bookname,b.author,b.price,b.isbn,c.catname from tblbook b,tblcategory c where c.catid=b.catid order by `author`", cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        grdBook.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub btnSearchCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCat.Click
        ds.Clear()
        cn.Open()
        cmd = New OleDbCommand("select b.bookid,b.bookname,b.author,b.price,b.isbn,c.catname from tblbook b,tblcategory c where c.catid=b.catid and c.catid=" + cmbSearchCat.SelectedValue.ToString(), cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        grdBook.DataSource = ds.Tables(0)
    End Sub
End Class
