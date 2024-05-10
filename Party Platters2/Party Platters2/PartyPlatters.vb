'Program: Party Platters'
'Date: 11/29/23'
'Developer: Izabella Fortunata
'Purpose: To select a party platter and purchase it, the user has an option to purhase before or at pickup. If they have discount points they can use them.'
Public Class PartyPlatters
    Private Sub PartyPlatters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clear out values and set focus'

        txtCostOutput.Text = ""
        txtLoyaltyPoints.Focus()
        lblNoDiscount.Visible = False
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'Defining variables'
        Dim intLoyaltyPoints As Integer
        Dim decCalculatePoints As Decimal
        Dim decCalculatePercent As Decimal
        Dim decPlatterCost As Decimal
        Dim decFinalCost As Decimal

        'Setting values to the platters'
        Dim decRiceBeans As Decimal = 15D
        Dim decFruitPlatter As Decimal = 25D
        Dim decMeatPlatter As Decimal = 30D
        Dim decShrimpPlatter As Decimal = 30D
        Dim decSushiPlatter As Decimal = 35D
        Dim intResult As Integer = 0

        'Makes discount lable invisible'
        lblNoDiscount.Visible = False

        'Did user enter a numeric value?'
        If (Integer.TryParse(txtLoyaltyPoints.Text, intResult) = True) Then
            If IsNumeric(txtLoyaltyPoints.Text) Then
                intLoyaltyPoints = Convert.ToInt32(txtLoyaltyPoints.Text)
                'If the user enters a zero'
                If intLoyaltyPoints >= 0 Then
                    'Did the user enter a positive value?'
                    If intLoyaltyPoints > 9 Then
                        'did user enter 10 or above?'
                        If radRiceBeans.Checked Then
                            decPlatterCost = decRiceBeans
                        ElseIf radFruitPlatter.Checked Then
                            decPlatterCost = decFruitPlatter
                        ElseIf radMeatPlatter.Checked Then
                            decPlatterCost = decMeatPlatter
                        ElseIf radShrimpPlatter.Checked Then
                            decPlatterCost = decShrimpPlatter
                        ElseIf radSushiPlatter.Checked Then
                            decPlatterCost = decSushiPlatter
                        End If


                        'calculate and display final cost'
                        decCalculatePercent = (decPlatterCost * 0.05)
                        decCalculatePoints = (intLoyaltyPoints / 10)
                        decFinalCost = decPlatterCost - (decCalculatePercent * decCalculatePoints)

                        If decFinalCost <= 0 Then
                            txtCostOutput.Text = ("FREE")
                        Else
                            txtCostOutput.Text = decFinalCost.ToString("C")
                        End If
                    Else
                        'tell user to enter a value above 10'
                        lblNoDiscount.Visible = True
                        If radRiceBeans.Checked Then
                            decPlatterCost = decRiceBeans
                        ElseIf radFruitPlatter.Checked Then
                            decPlatterCost = decFruitPlatter
                        ElseIf radMeatPlatter.Checked Then
                            decPlatterCost = decMeatPlatter
                        ElseIf radShrimpPlatter.Checked Then
                            decPlatterCost = decShrimpPlatter
                        ElseIf radSushiPlatter.Checked Then
                            decPlatterCost = decSushiPlatter
                        End If

                        'Calculate'
                        decFinalCost = decPlatterCost
                        txtCostOutput.Text = decFinalCost.ToString("C")
                    End If
                Else
                    'Tell user to enter a positive value'
                    MsgBox("You put in a negative number, please put in a postive value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
                    txtLoyaltyPoints.Text = ""
                    txtLoyaltyPoints.Focus()
                End If

            Else
                'Tell ueser to enter a whole number'
                MsgBox("Enter a numerical value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
                txtLoyaltyPoints.Text = ""
                txtLoyaltyPoints.Focus()
            End If

        Else
            'Tell user to enter a numeric value'
            MsgBox("Enter a number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
            txtLoyaltyPoints.Text = ""
            txtLoyaltyPoints.Focus()
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear out values'
        txtLoyaltyPoints.Clear()
        txtCostOutput.Text = ""
        txtLoyaltyPoints.Focus()
        lblNoDiscount.Visible = False
    End Sub
End Class
