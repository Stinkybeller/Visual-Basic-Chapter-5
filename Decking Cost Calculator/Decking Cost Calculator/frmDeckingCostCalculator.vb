'Program:   Decking Cost Calculator'
'Developer: Izabella Fortunata'
'Date:      11/13/2023'
'Purpose:   This program allows use to select a decking type and calculates on type of wood.'

Public Class frmDeckingCostCalculator
    Private Sub frmDeckingCostCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim decSquareFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedwoodCost As Decimal = 7.74D
        Dim decCompositeCost As Decimal = 8.5D

        If IsNumeric(txtSquareFootage.Text) Then
            decSquareFootage = Convert.ToDecimal(txtSquareFootage.Text)

            If decSquareFootage > 0 Then
                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedwood Then

                End If
            End If





        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program'
        Close()
    End Sub
End Class
