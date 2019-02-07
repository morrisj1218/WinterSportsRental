Public Class frmSummary

    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles Me.Load


        For Each str As String In frmRental.clbEquipment.CheckedItems
            lstEquip_Rented.Items.Add(str)
        Next

    End Sub
End Class