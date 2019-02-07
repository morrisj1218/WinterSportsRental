' Name:         Winter Sports Rental
' Purpose:      
' Programmer:   Jack Morris on 02/06/2019

Option Explicit On
Option Strict On
Option Infer Off


Public Class frmRental
    Private Sub frmRental_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim equipment(,) As String = {{"Performance Skis", "$56"},
                                       {"Beginner Skis", "$48"},
                                       {"Youth Skis", "$32"},
                                       {"Snowboard", "$48"},
                                       {"Adult Boots", "$24"},
                                       {"Youth Boots", "$16"},
                                       {"Adult Helmet", "$15"},
                                       {"Youth Helmet", "$10"}}

        Dim duration() As String = {"1 Day", "2 Days", "3 Days", "1 Week", "2 Weeks"}

        For intRow As Integer = 0 To equipment.GetUpperBound(0)

            clbEquipment.Items.Add(equipment(intRow, 0) &
                                   equipment(intRow, 1).PadLeft(12))
        Next

        For i As Integer = 0 To duration.GetUpperBound(0)

            cmbDuration.Items.Add(duration(i))
        Next


    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        frmCustomer.Show()

    End Sub
End Class
