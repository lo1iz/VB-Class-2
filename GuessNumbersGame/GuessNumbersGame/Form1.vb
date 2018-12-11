Public Class Form1
    Private Sub LabelCount_Click(sender As Object, e As EventArgs) Handles LabelCount.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        ButtonStart.Enabled = False
        Dim RANDOM As Random = New Random
        Dim GetNum As Integer = RANDOM.Next(1, 99)
        Dim Tried As Integer = 7

        For x = Tried - 1 To -1 Step -1

            Dim GuessNum As Integer = InputBox(" กรุณาป้อนตัวเลขที่ต้องการทาย ")
            If x = -1 Then
                MessageBox.Show("จบเกมส์ คุุณแพ้แล้ว", " ", MessageBoxButtons.OK)
            ElseIf GuessNum < GetNum Then
                MessageBox.Show("มากกว่านี้", " ", MessageBoxButtons.OK)
            ElseIf GuessNum > GetNum Then
                MessageBox.Show("น้อยกว่านี้", " ", MessageBoxButtons.OK)
            ElseIf GuessNum = GetNum Then
                MessageBox.Show(GetNum & "....ถูกต้อง คุุณคือผู้ชนะ", " ", MessageBoxButtons.OK)
                Exit For
            Else
                MessageBox.Show("กรุณาป้อนตัวเลข", " ", MessageBoxButtons.OK)
                x += 1
            End If
            LabelCount.Text = x

        Next
        LabelCount.Text = 7
        ButtonStart.Enabled = True
    End Sub

End Class
