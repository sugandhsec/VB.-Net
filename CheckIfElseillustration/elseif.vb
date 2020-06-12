Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim intinput As Integer
        MsgBox("ENETR AN INTEGER")
        Dim str As String
        str = InputBox("Enter Some TEXT")
        intinput = Val(str)
        If intinput = 1 Then
            MsgBox("THIS IS FOR NO 1")
        ElseIf intinput = 2 Then
            MsgBox("THIS IS FOR NO 2")
        Else
            MsgBox("ESLE STATEMENT EXECUTED")
        End If
    End Sub
End Class
