' Name:         Equipment.vb
' Programmer:   Jack Morris

Option Explicit On
Option Strict On
Option Infer Off

Public Class Equipment

    Private Property EquipID As Integer
    Private Property Description As String
    Private Property OneDayRental As Double
    Private Property TwoDayRental As Double
    Private Property ThreeDayRental As Double
    Private Property OneWeekRental As Double
    Private Property TwoWeekRental As Double
    Private Property PurchasePrice As Double
    Private Property PurchaseDate As String
    Private Property RentalStatus As Boolean

    Public Sub New(equipID As Integer, description As String, oneDayRental As Double, twoDayRental As Double,
                   threeDayRental As Double, oneWeekRental As Double, twoWeekRental As Double,
                   purchasePrice As Double, purchaseDate As String, rentalStatus As Boolean)
        Me.EquipID = equipID
        Me.Description = description
        Me.OneDayRental = oneDayRental
        Me.TwoDayRental = twoDayRental
        Me.ThreeDayRental = threeDayRental
        Me.OneWeekRental = oneWeekRental
        Me.TwoWeekRental = twoWeekRental
        Me.PurchasePrice = purchasePrice
        Me.PurchaseDate = purchaseDate
        Me.RentalStatus = rentalStatus
    End Sub
End Class
