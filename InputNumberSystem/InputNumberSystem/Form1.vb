Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim Sum As Integer = 0
        Dim message As String = ""
        Dim num As Integer = CInt(TextNum.Text)

        If num > 0 And num < 11 Then

            For x = 1 To num

                Dim data As Integer = CInt(InputBox("ป้อนเลขตัวที่ " & x))
                Sum += data
                message += data & vbNewLine


            Next

            LabelNum.Text = message
            LabelSum.Text = Sum
            LabelAverage.Text = Sum / CInt(TextNum.Text)

        End If

    End Sub


End Class