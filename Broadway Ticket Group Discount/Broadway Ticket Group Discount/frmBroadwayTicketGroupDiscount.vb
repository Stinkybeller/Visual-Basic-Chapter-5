'Program: Broadway Ticket Group Discount'
'Developer: Izabella Fortunata'
'Date: 11/17/23'
'Purpose: To provide tickets for groups for a broadway show.'
Public Class frmBroadwayTicketGroupDiscount
    Private Sub frmBroadwayTicketGroupDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'When the uer clicks the display button it calculates the cost'
        'Defining variables'
        Dim intGroupSize As Integer
        Dim decPrice As Decimal
        Dim decFinalCost As Decimal
        Dim decGroup1 As Decimal = 249D
        Dim decGroup2 As Decimal = 219D
        Dim decGroup3 As Decimal = 199D
        Dim decGroup4 As Decimal = 169D

        'Converting variable'
        'If the user inputs a numeric value it will calculate'
        If IsNumeric(txtGroupSize.Text) Then
            intGroupSize = Convert.ToInt32(txtGroupSize.Text)
            If intGroupSize > 0 And intGroupSize < 100 Then
                If (Integer.TryParse(txtGroupSize.Text, decPrice) = True) Then

                    'intGroupSize = Convert.ToInt32(txtGroupSize.Text)
                    'Using a case statement'
                    Select Case intGroupSize
                        Case Is < 9
                            decPrice = decGroup1
                        Case Is < 13
                            decPrice = decGroup2
                        Case Is < 25
                            decPrice = decGroup3
                        Case Is < 100
                            decPrice = decGroup4
                    End Select
                    'Final calculation'
                    decFinalCost = decPrice * intGroupSize
                    txtPrice.Text = decFinalCost.ToString("C")
                End If
            Else
                MsgBox("You put in a negative number, please put in a postive value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
            End If
        Else
            MsgBox("Please enter a numerical value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'
        txtGroupSize.Text = ""
        txtGroupSize.Focus()
        txtPrice.Text = ""
        txtPrice.Focus()
    End Sub
End Class
