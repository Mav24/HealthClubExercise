Public Class Dues

    Public Property memberShipDues As Double
    Public Property additionalFees As Double
    Public Sub New()

    End Sub

    Public Sub New(memberShip As Double, additionalFees As Double)
        memberShipDues = memberShip
        Me.additionalFees = additionalFees

    End Sub

    Public Function Total()
        Dim totalDue As Double = memberShipDues + additionalFees
        Return $"{totalDue.ToString("C")}"
    End Function
End Class
