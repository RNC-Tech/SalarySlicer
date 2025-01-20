Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub

    Private Sub ConvertBtn_Click(sender As Object, e As EventArgs) Handles ConvertBtn.Click

        If String.IsNullOrEmpty(SalaryReceived.Text) Then
            MessageBox.Show("Please enter a salary amount first.", "Input Required")
            Return
        End If

        Dim salary As Decimal
        If Not Decimal.TryParse(SalaryReceived.Text, salary) Then
            MessageBox.Show("Please enter a valid number for salary.", "Invalid Input")
            Return
        End If

        Dim userCutPercentage As Decimal
        Select Case ComboBox1.SelectedItem.ToString().ToLower()
            Case "rence", "joshua", "vence"
                userCutPercentage = 0.6 ' 60%
            Case "hans", "neo"
                userCutPercentage = 0.85 ' 15%
            Case Else
                MessageBox.Show("Please select a valid name.", "Invalid Selection")
                Return
        End Select

        Dim userCutAmount As Decimal = salary * userCutPercentage
        Dim rseCutAmount As Decimal = salary * 0.4 ' 40% for RSE

        UserCut.Text = "₱" & userCutAmount.ToString("N2") ' Display in ₱ with two decimal places
        RSECut.Text = "₱" & rseCutAmount.ToString("N2")
    End Sub

End Class
