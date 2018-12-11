Public Class Form1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBalance_TextChanged(sender As Object, e As EventArgs) Handles TextBalance.TextChanged

    End Sub

    Private Sub TextWithdraw_TextChanged(sender As Object, e As EventArgs) Handles TextWithdraw.TextChanged

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim balance As Integer = CInt(TextBalance.Text)
        Dim withdraw As Integer = CInt(TextWithdraw.Text)
        Dim message As String = ""

        If withdraw > balance Then
            MessageBox.Show("ยอดเงินคงเหลือไม่พอ")
        ElseIf withdraw > 20000 Then
            MessageBox.Show("ถอนได้ไม่เกิน 20,000 บาท")
        ElseIf withdraw < 100 Then
            MessageBox.Show("ยอดขั้นต่ำต้องเป็นหลกร้อยเท่านั้น")
        End If
        Dim M1000 As Integer = withdraw \ 1000
        Dim M500 As Integer = (withdraw Mod 1000) \ 500
        Dim M100 As Integer = ((withdraw Mod 1000) Mod 500) \ 100
        LabelResult.Text = "1000 : " & M1000 & vbNewLine &
                           "500 : " & M500 & vbNewLine &
                           "100 : " & M100

    End Sub

    Private Sub LabelResult_Click(sender As Object, e As EventArgs) Handles LabelResult.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ran As Random = New Random
        TextBalance.Text = ran.Next(1, 9) * 100000
        TextWithdraw.Select()
    End Sub
End Class
