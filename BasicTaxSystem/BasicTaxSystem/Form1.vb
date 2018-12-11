Public Class Form1
    Private Sub TextSalary_TextChanged(sender As Object, e As EventArgs) Handles TextSalary.TextChanged

    End Sub

    Private Sub LabelTax_Click(sender As Object, e As EventArgs) Handles LabelTax.Click

    End Sub

    Private Sub ButtonTax_Click(sender As Object, e As EventArgs) Handles ButtonTax.Click
        Dim salary As Integer = CInt(TextSalary.Text) * 12
        Dim net40 As Integer = salary * 0.4
        Dim tax As Integer = 0
        Dim message As String = ""

        If net40 > 60000 Then
            salary -= 60000
        Else
            salary -= net40
        End If

        salary -= 30000
        Dim Vsalary As Integer = salary

        If salary < 150000 Then
            LabelTax.Text = "ได้รับการยกเว้นภาษี"
        ElseIf salary <= 300000 Then
            Vsalary -= 150000
            tax += Vsalary * 0.05
        ElseIf salary <= 500000 Then
            Vsalary -= 200000
            tax += Vsalary * 0.1
        ElseIf salary <= 750000 Then
            Vsalary -= 250000
            tax += Vsalary * 0.15
        ElseIf salary <= 1000000 Then
            Vsalary -= 250000
            tax += Vsalary * 0.2
        ElseIf salary <= 2000000 Then
            Vsalary -= 1000000
            tax += Vsalary * 0.25
        ElseIf salary <= 4000000 Then
            Vsalary -= 2000000
            tax += Vsalary * 0.3
        Else
            tax += Vsalary * 0.35
        End If

        If tax <> 0 Then
            LabelTax.Text = tax
        Else
            LabelTax.Text = message
        End If


    End Sub
End Class
