' Name:         Customer.vb
' Programmer:   Jack Morris on 02/06/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class Customer

    Private Property Name As String
    Private Property Address As String
    Private Property City As String
    Private Property State As String
    Private Property Zip As String
    Private Property Phone As String
    Private Property CreditCard As String

    Public Sub New(name As String, address As String, city As String,
                   state As String, zip As String, phone As String,
                   creditCard As String)

        Me.Name = name
        Me.Address = address
        Me.City = city
        Me.State = state
        Me.Zip = zip
        Me.Phone = phone
        Me.CreditCard = creditCard

    End Sub

End Class
