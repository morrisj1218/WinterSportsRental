' Rental Summary Form (frmSummary)
' Displays user selections and calculated totals like an invoice

Public Class frmSummary
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim dblBalanceDue As Double
        Dim dblDeposit As Double
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblInsurance As Double

        dblSubTotal = frmRental.GetSubTotal()
        dblTax = frmRental.GetTax()

        If frmRental.chkInsurance.Checked = True Then
            dblInsurance = frmRental.GetInsurance()
        Else
            dblInsurance = 0
        End If

        Double.TryParse(frmRental.txtDeposit.Text, dblDeposit)

        dblBalanceDue = (dblSubTotal + dblInsurance + dblTax) - dblDeposit

        lblStDate.Text = frmRental.datePicker.Text
        lstEquip_Rented.Items.Add(frmRental.clbEquipment.CheckedItems)
        lblSubTotal.Text = dblSubTotal.ToString("C2")
        lblTax.Text = dblTax.ToString("C2")
        lblInsurance.Text = dblInsurance.ToString("C2")
        lblDeposit.Text = dblDeposit.ToString("C2")
        lblBalanceDue.Text = dblBalanceDue.ToString("C2")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        frmRental.Close()

    End Sub
End Class