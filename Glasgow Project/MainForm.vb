Public Class MainForm
    ' single membership is $50
    ' $25 for golf
    ' $30 for tennis
    ' $20 for racquetball

    ' Family membership is $90
    ' $35 for golf
    ' $50 for tennis
    ' $30 for racquetball
    Dim memberShip As Double
    Dim golf As Double
    Dim tennis As Double
    Dim racquetball As Double
    Dim additionalFees As Double


    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim newMemberShip As Dues
        newMemberShip = New Dues(memberShip, additionalFees)

        lblMonthlyDue.Text = newMemberShip.Total()


    End Sub

    Private Sub MemberShip_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingle.CheckedChanged
        If rdoFamily.Checked Then
            unCheckBoxes()
            lblMonthlyDue.Text = String.Empty
            memberShip = 90
            golf = 35
            tennis = 50
            racquetball = 30
            lblBasicFee.Text = memberShip.ToString("C")
        Else
            unCheckBoxes()
            lblMonthlyDue.Text = String.Empty
            memberShip = 50
            golf = 25
            tennis = 30
            racquetball = 20
            lblBasicFee.Text = memberShip.ToString("C")
        End If
    End Sub

    Private Sub unCheckBoxes()
        chkGolf.Checked = False
        chkTennis.Checked = False
        chkRecquetball.Checked = False
    End Sub

    Private Sub ChkGolf_CheckedChanged(sender As Object, e As EventArgs) Handles chkGolf.CheckedChanged

        If chkGolf.Checked Then

            additionalFees += golf
            lblAdditional.Text = additionalFees.ToString("C")
        Else
            additionalFees -= golf
            lblAdditional.Text = additionalFees.ToString("C")
        End If


    End Sub

    Private Sub ChkTennis_CheckedChanged(sender As Object, e As EventArgs) Handles chkTennis.CheckedChanged
        If chkTennis.Checked Then
            additionalFees += tennis
            lblAdditional.Text = additionalFees.ToString("C")
        Else
            additionalFees -= tennis
            lblAdditional.Text = additionalFees.ToString("C")
        End If
    End Sub

    Private Sub ChkRecquetball_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecquetball.CheckedChanged

        If chkRecquetball.Checked Then
            additionalFees += racquetball
            lblAdditional.Text = additionalFees.ToString("C")
        Else
            additionalFees -= racquetball
            lblAdditional.Text = additionalFees.ToString("C")
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
