Public Class chkselect

    Private Sub chkselect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim intinput As Integer
        MsgBox("ENTER AN NUMBER")
        intinput = InputBox("ENTER SOME TEXT")
        Select Case intinput
            Case 1
                MsgBox("NUMBER 1 IS TYPED")
            Case 2
                MsgBox("NUMBER 2 IS TYPED")
            Case 3
                MsgBox("NUMBER 3 IS TYPED")
            Case 4
                MsgBox("NUMBER 4 IS TYPED")
            Case 5
                MsgBox("NUMBER 5 IS TYPED")
            Case Else
                MsgBox("NOT ANUMBER IN LIST")

        End Select
    End Sub
End Class
