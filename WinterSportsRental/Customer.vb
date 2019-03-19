' Name:         Customer.vb
' Programmer:   Jack Morris on 02/06/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class Customer

    Private Property CustomerID As Integer
    Private Property FisrtName As String
    Private Property LastName As String
    Private Property StreetAddress As String
    Private Property City As String
    Private Property State As String
    Private Property Zip As String
    Private Property Phone As String

    Public Sub New(customerID As Integer, fisrtName As String, lastName As String,
                   streetAddress As String, city As String, state As String,
                   zip As String, phone As String)

        Me.CustomerID = customerID
        Me.FisrtName = fisrtName
        Me.LastName = lastName
        Me.StreetAddress = streetAddress
        Me.City = city
        Me.State = state
        Me.Zip = zip
        Me.Phone = phone
    End Sub

End Class
