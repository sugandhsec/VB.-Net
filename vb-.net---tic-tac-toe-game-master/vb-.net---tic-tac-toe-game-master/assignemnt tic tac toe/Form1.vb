Public Class Form1
        Dim turn As Integer = 1
        Public Sub disableAll()
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        End Sub
        Public Sub checkWinner()
            If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
                btn1.BackColor = Color.AliceBlue
                btn2.BackColor = Color.AliceBlue
                btn3.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
                btn4.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn6.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
                btn7.BackColor = Color.AliceBlue
                btn8.BackColor = Color.AliceBlue
                btn9.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
                btn1.BackColor = Color.AliceBlue
                btn4.BackColor = Color.AliceBlue
                btn7.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
                btn2.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn8.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
                btn3.BackColor = Color.AliceBlue
                btn6.BackColor = Color.AliceBlue
                btn9.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
                btn1.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn9.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
                btn3.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn7.BackColor = Color.AliceBlue
                MsgBox("Player 2 Won")
                disableAll()
            ElseIf btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
                btn1.BackColor = Color.AliceBlue
                btn2.BackColor = Color.AliceBlue
                btn3.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
                btn4.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn6.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
                btn7.BackColor = Color.AliceBlue
                btn8.BackColor = Color.AliceBlue
                btn9.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
                btn1.BackColor = Color.AliceBlue
                btn4.BackColor = Color.AliceBlue
                btn7.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
                btn2.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn8.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
                btn3.BackColor = Color.AliceBlue
                btn6.BackColor = Color.AliceBlue
                btn9.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
                btn1.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn9.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
                btn3.BackColor = Color.AliceBlue
                btn5.BackColor = Color.AliceBlue
                btn7.BackColor = Color.AliceBlue
                MsgBox("Player 1 Won")
                disableAll()
            ElseIf btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False Then
                MsgBox("It's a draw")
            End If
        End Sub

        Public Sub changeTurn()
            If turn = 0 Then
                turn = 1
                lblTurn.Text = "Player 2"
            Else
                turn = 0
                lblTurn.Text = "Player 1"
            End If
            checkWinner()
        End Sub
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            changeTurn()
        End Sub

        Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
            If turn = 0 Then
                btn1.Text = "O"
            Else
                btn1.Text = "X"
            End If
            btn1.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
            If turn = 0 Then
                btn2.Text = "O"
            Else
                btn2.Text = "X"
            End If
            btn2.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
            If turn = 0 Then
                btn3.Text = "O"
            Else
                btn3.Text = "X"
            End If
            btn3.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
            If turn = 0 Then
                btn4.Text = "O"
            Else
                btn4.Text = "X"
            End If
            btn4.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
            If turn = 0 Then
                btn5.Text = "O"
            Else
                btn5.Text = "X"
            End If
            btn5.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
            If turn = 0 Then
                btn6.Text = "O"
            Else
                btn6.Text = "X"
            End If
            btn6.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
            If turn = 0 Then
                btn7.Text = "O"
            Else
                btn7.Text = "X"
            End If
            btn7.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
            If turn = 0 Then
                btn8.Text = "O"
            Else
                btn8.Text = "X"
            End If
            btn8.Enabled = False
            changeTurn()
        End Sub

        Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
            If turn = 0 Then
                btn9.Text = "O"
            Else
                btn9.Text = "X"
            End If
            btn9.Enabled = False
            changeTurn()
        End Sub
    End Class
