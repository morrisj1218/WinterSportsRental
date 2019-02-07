Public Class frmCustomer
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        Dim strName As String = txtName.Text.ToString.Trim
        Dim strAddress As String = txtAddress.Text.ToString.Trim
        Dim strCity As String = txtCity.Text.ToString.Trim
        Dim strState As String = txtState.Text.ToString.Trim
        Dim strZip As String = txtZip.Text.ToString.Trim
        Dim strPhone As String = txtPhone.Text.ToString.Trim
        Dim strCardNum As String = txtCardNum.Text.ToString.Trim

        Dim cust As New Customer(strName, strAddress, strCity, strState, strZip,
                                  strPhone, strCardNum)

        Dim ofCustomerInfo As IO.StreamWriter
        ofCustomerInfo = IO.File.AppendText("customerInfo.txt")

        ofCustomerInfo.WriteLine(strName)
        ofCustomerInfo.WriteLine(strAddress)
        ofCustomerInfo.WriteLine(strCity & " " & strState & ", " & strZip)
        ofCustomerInfo.WriteLine(strPhone)
        ofCustomerInfo.WriteLine(strCardNum)
        ofCustomerInfo.WriteLine()
        ofCustomerInfo.Close()

        frmSummary.Show()

    End Sub
End Class