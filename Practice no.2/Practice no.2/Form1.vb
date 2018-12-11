Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first As Integer = CInt(TextBox1.Text)
        Dim last As Integer = CInt(TextBox2.Text)
        Dim steps As Integer = CInt(TextBox3.Text)
        Dim message As String = ""

        If steps > 0 Then
            If first < last Then
                For x = first To last Step steps
                    message += x & vbNewLine
                Next
                MessageBox.Show(message)
            Else
                MessageBox.Show("เลขเริ่มต้น ต้องน้อยกว่า เลขสิ้นสุด เท่านั้น!!")
            End If
        ElseIf steps < 0 Then
            If first > last Then
                For x = first To last Step steps
                    message += x & vbNewLine
                Next
                MessageBox.Show(message)
            Else
                MessageBox.Show("เลขเริ่มต้น ต้องมากกว่า เลขสิ้นสุด เท่านั้น!!")
            End If
        End If
    End Sub
End Class
