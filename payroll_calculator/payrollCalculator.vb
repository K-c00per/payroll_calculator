'Program: Payroll Calculator
'Author: Katelyn Coper
'Date: February 28, 2023
'Purpose: This application calculates and then displays the total cost of 

Public Class payrollCalculator
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPay.Text = ""
        lblFicatxt.Text = ""
        lblFtax.Text = ""
        lblStax.Text = ""

        txtPay.Focus()

    End Sub

    Private Sub btnTaxes_Click(sender As Object, e As EventArgs) Handles btnTaxes.Click


        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        Const _cdecFica As Decimal = 0.0765D
        Const _cdecFed As Decimal = 0.22D
        Const _cdecState As Decimal = 0.04D

        strIncome = txtPay.Text
        decIncome = Convert.ToInt32(strIncome)

        decFica = _cdecFica * decIncome
        decFederal = _cdecFed * decIncome
        decState = _cdecState * decIncome

        decNet = decIncome - decFica - decFederal - decState
        txtNetIncome.Text = decNet.ToString("C")
        txtNetIncome.Visible = True

        lblFicatxt.Text = decFica.ToString("C")
        lblFtax.Text = decFederal.ToString("C")
        lblStax.Text = decState.ToString("C")

    End Sub
End Class
