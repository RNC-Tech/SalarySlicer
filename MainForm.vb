Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Check if there's a valid input in SalaryReceived
        If String.IsNullOrEmpty(SalaryReceived.Text) Then
            MessageBox.Show("Please enter a salary amount first.", "Input Required")
            Return
        End If

        ' Try to parse the salary input
        Dim salary As Decimal
        If Not Decimal.TryParse(SalaryReceived.Text, salary) Then
            MessageBox.Show("Please enter a valid number for salary.", "Invalid Input")
            Return
        End If

        ' Calculate cuts based on selected name
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

        ' Calculate the cuts
        Dim userCutAmount As Decimal = salary * userCutPercentage
        Dim rseCutAmount As Decimal = salary * 0.4 ' 40% for RSE

        ' Display the results
        UserCut.Text = userCutAmount.ToString("C") ' C format specifier for currency
        RSECut.Text = rseCutAmount.ToString("C")
    End Sub
End Class
