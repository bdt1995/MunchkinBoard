Public Class Form1
    Dim P1Lev, P2Lev, P3Lev, P4Lev As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P1Lev = 1
        P2Lev = 1
        P3Lev = 1
        P4Lev = 1

        P1Level.Text = "Level: " + P1Lev.ToString


    End Sub

    Public Sub totalReset()
        resetBoard(P1Lev)
        resetBoard(P2Lev)
        resetBoard(P3Lev)
        resetBoard(P4Lev)
    End Sub

    Private Sub P1Add_Click(sender As Object, e As EventArgs) Handles P1Add.Click
        P1Lev += 1
        Board_Update()

    End Sub
    Private Sub levelupdate(levlab As Label, lev As String)
        levlab.Text = "Level: " + lev.ToString

    End Sub
    Public Sub Board_Update()
        levelupdate(P1Level, P1Lev)
        levelupdate(P2Level, P2Lev)
        levelupdate(P3Level, P3Lev)
        levelupdate(P4Level, P4Lev)

        If P1Lev = 10 Or P2Lev = 10 Or P3Lev = 10 Or P4Lev = 10 Then
            MsgBox("We have a winner!")
        End If

    End Sub

    Private Sub P1Minus_Click(sender As Object, e As EventArgs) Handles P1Minus.Click
        If P1Lev > 1 Then
            P1Lev -= 1
        End If

        Board_Update()

    End Sub
    Private Sub resetBoard(player As Integer)
        If MsgBox("Are you sure you want to reset to level 1?", MsgBoxStyle.YesNo, "Reset Confirmation") = 6 Then
            player = 1
            Board_Update()
        End If
    End Sub
    Private Sub P1Reset_Click(sender As Object, e As EventArgs) Handles P1Reset.Click
        resetBoard(P1Lev)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles P2Add.Click
        P2Lev += 1
        Board_Update()

    End Sub

    Private Sub P2Minus_Click(sender As Object, e As EventArgs) Handles P2Minus.Click
        If P2Lev > 1 Then
            P2Lev -= 1
            Board_Update()

        End If

    End Sub

    Private Sub P3Add_Click(sender As Object, e As EventArgs) Handles P3Add.Click
        P3Lev += 1
        Board_Update()

    End Sub

    Private Sub P3Minus_Click(sender As Object, e As EventArgs) Handles P3Minus.Click
        If P3Lev > 1 Then
            P3Lev -= 1
            Board_Update()

        End If
    End Sub

    Private Sub P4Add_Click(sender As Object, e As EventArgs) Handles P4Add.Click
        P4Lev += 1
        Board_Update()

    End Sub

    Private Sub P4Minus_Click(sender As Object, e As EventArgs) Handles P4Minus.Click
        If P4Lev > 1 Then
            P4Lev -= 1
            Board_Update()

        End If
    End Sub

    Private Sub P2Reset_Click(sender As Object, e As EventArgs) Handles P2Reset.Click
        resetBoard(P2Lev)
    End Sub

    Private Sub P3Reset_Click(sender As Object, e As EventArgs) Handles P3Reset.Click
        resetBoard(P3Lev)
    End Sub

    Private Sub P4Reset_Click(sender As Object, e As EventArgs) Handles P4Reset.Click
        resetBoard(P4Lev)
    End Sub

    Private Sub TotalResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalResetToolStripMenuItem.Click
        totalReset()

    End Sub
End Class
