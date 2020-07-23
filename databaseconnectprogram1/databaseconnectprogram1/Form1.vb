Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\VB.net\databaseconnectprogram1\bookdb.mdb")
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
