' Name:         Winter Sports Rental
' Purpose:      
' Programmer:   Jack Morris on 02/06/2019

Option Explicit On
Option Strict On
Option Infer Off


Public Class frmRental
    ' Rental prices parallel to equipment() and duration(); Row=equipment(index), Col=duration(index)

    Dim equipPrices(,) As Double = {{56.99, 113.98, 170.97, 341.94, 683.88},
                                       {48.99, 97.98, 146.97, 293.94, 587.88},
                                       {32.99, 65.98, 98.97, 197.94, 395.88},
                                       {48.99, 97.98, 146.97, 293.94, 587.88},
                                       {24.99, 49.98, 74.97, 149.94, 299.88},
                                       {16.99, 33.98, 50.97, 101.94, 203.88},
                                       {15.99, 31.98, 47.97, 95.94, 191.88},
                                       {10.99, 21.98, 32.97, 65.94, 131.88}}

    Dim equipment() As String = {"Sport Skis", "Beginner Skis", "Youth Skis", "Snowboard",
                                     "Adult Boots", "Youth Boots", "Adult Helmet", "Youth Helmet"}

    Dim duration() As String = {"1 Day", "2 Days", "3 Days", "1 Week", "2 Weeks"}

    Private Sub FillCheckLists()
        ' Sub Routine to Clear and Fill List Boxes on frmRental
        clbEquipment.Items.Clear()
        cmbDuration.Items.Clear()

        For i As Integer = 0 To equipment.GetUpperBound(0)
            clbEquipment.Items.Add(equipment(i))
        Next

        For i As Integer = 0 To duration.GetUpperBound(0)
            cmbDuration.Items.Add(duration(i))
        Next

    End Sub

    Public Function GetSubTotal() As Double
        ' Calculates SubTotal based on User Selections
        Dim dblSubTotal As Double

        For Each Index As Integer In clbEquipment.CheckedIndices
            dblSubTotal += equipPrices(Index, cmbDuration.SelectedIndex)
        Next

        Return dblSubTotal
    End Function

    Public Function GetTax() As Double
        ' Calculates Sales Tax for Rental Subtotal at 8.25%
        Dim dblTax As Double
        dblTax = GetSubTotal() * 0.0825

        Return dblTax
    End Function

    Public Function GetInsurance() As Double
        ' Calculates damage liability insurance at 10% of SubTotal before tax if elected
        Dim dblInsurance As Double
        dblInsurance = GetSubTotal() * 0.1

        Return dblInsurance
    End Function

    Private Sub frmRental_Load(sender As Object, e As EventArgs) Handles Me.Load

        FillCheckLists()

    End Sub

    Private Sub lnkWeather_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkWeather.LinkClicked

        frmBrowser.Show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears current selected items

        FillCheckLists()
        chkInsurance.Checked = False
        chkWaiver.Checked = False
        lblDepError.Visible = False
        txtDeposit.Text = String.Empty
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblInsurance.Text = String.Empty
        lblLessDep.Text = String.Empty
        lblBalance.Text = String.Empty

    End Sub

    Private Sub btnSnap_Click(sender As Object, e As EventArgs) Handles btnSnap.Click

        Dim dblDeposit As Double
        Dim dblBalance As Double
        Dim dblMinDep_Req As Double
        Double.TryParse(txtDeposit.Text.Trim, dblDeposit)

        Select Case chkInsurance.Checked
            Case True
                dblMinDep_Req = 0.1 * (GetSubTotal() + GetTax() + GetInsurance())
                lblSubTotal.Text = GetSubTotal().ToString("C2")
                lblTax.Text = GetTax().ToString("C2")
                lblInsurance.Text = GetInsurance().ToString("C2")
                If dblDeposit >= dblMinDep_Req Then
                    lblDepError.Visible = False
                    lblLessDep.Text = dblDeposit.ToString("C2")
                    dblBalance = (GetSubTotal() + GetTax() + GetInsurance()) - dblDeposit
                    lblBalance.Text = dblBalance.ToString("C2")
                Else
                    lblDepError.Text = "A minimum deposit of " & dblMinDep_Req.ToString("C2") & " is required."
                    lblDepError.Visible = True
                End If
            Case False
                dblMinDep_Req = 0.1 * (GetSubTotal() + GetTax())
                lblSubTotal.Text = GetSubTotal().ToString("C2")
                lblTax.Text = GetTax().ToString("C2")
                If dblDeposit >= dblMinDep_Req Then
                    lblDepError.Visible = False
                    lblLessDep.Text = dblDeposit.ToString("C2")
                    dblBalance = (GetSubTotal() + GetTax()) - dblDeposit
                    lblBalance.Text = dblBalance.ToString("C2")
                Else
                    lblDepError.Text = "A minimum deposit of " & dblMinDep_Req.ToString("C2") & " is required."
                    lblDepError.Visible = True
                End If
        End Select
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If chkWaiver.Checked = True And lblDepError.Visible = False Then
            frmCustInfo.Show()
        Else
            If chkWaiver.Checked = False Then
                MessageBox.Show("Liability Waiver must be signed before continuing.", "Liabilty Waiver",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
