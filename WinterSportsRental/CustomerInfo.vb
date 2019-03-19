' Name:
' Purpose:
' Programmer:

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmCustInfo
    Private Sub frmCustInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Set radio button and group box defaults

        radExistCust.Checked = True
        radNewCust.Checked = False
        boxCustSearch.Visible = True
        boxNewCust.Visible = False

    End Sub

    Private Sub btnNameSearch_Click(sender As Object, e As EventArgs) Handles btnNameSearch.Click
        ' Search query database by last name using input box

        Dim strName As String
        strName = InputBox("Enter customer's last name and click OK. Click canccel to close this dialog.",
                           "Last Name Search").Trim

        CustomersTableAdapter.FillByLastName(WinterSportsDataSet.Customers, strName)

    End Sub

    Private Sub btnIDSearch_Click(sender As Object, e As EventArgs) Handles btnIDSearch.Click
        ' Search query database by cust ID using input box

        Dim intCustID As Integer
        Integer.TryParse(InputBox("Enter customer ID and click OK.", "Customer ID Search").Trim, intCustID)

        CustomersTableAdapter.FillByCustID(WinterSportsDataSet.Customers, intCustID)
    End Sub

    Private Sub radNewCust_CheckedChanged(sender As Object, e As EventArgs) Handles radNewCust.CheckedChanged

        If radNewCust.Checked = True Then

            boxNewCust.Visible = True
            boxCustSearch.Visible = False
        Else
            boxNewCust.Visible = False
            boxCustSearch.Visible = True

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Me.Validate()
            Me.CustomersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WinterSportsDataSet)
            MessageBox.Show("Customer added to database.", "New Customer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Customer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
End Class