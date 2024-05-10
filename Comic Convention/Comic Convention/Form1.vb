'Program: Comic Convention'
'Developer: Izabella Fortunata'
'Date: 11/16/23'
'Purpose: To provide options for the comic convention.'

Public Class frmComicConvention
    Private Sub frmComicConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clearing the form'
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'When the user hits the button and the radio button, it will calculate the price'
        'Defining variables'
        Dim decSuperheroExperience As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D
        Dim intGroupSize As Integer
        Dim decFinalCost As Decimal

        'Converting the variables'
        If IsNumeric(txtGroupSize.Text) Then
            intGroupSize = Convert.ToDecimal(txtGroupSize.Text)
            'If the user inputs a number from 1-20 then they will be able to calculate the price'
            If intGroupSize <= 20 Then
                If intGroupSize > 0 Then
                    If radSuperheroExp.Checked Then
                        'If this was chosen then it will calculate based on the group size'
                        decFinalCost = intGroupSize * decSuperheroExperience

                        'Displaying the final calculation'
                        txtRegistrationCost.Text = decFinalCost.ToString("C")
                    ElseIf radAutographs.Checked Then
                        'When the option is chosen, the calculation will take place'
                        decFinalCost = intGroupSize * decAutographs

                        txtRegistrationCost.Text = decFinalCost.ToString("C")
                    ElseIf radConvention.Checked Then
                        'When the option is chosen, the calculation will take place'
                        decFinalCost = intGroupSize * decConvention

                        txtRegistrationCost.Text = decFinalCost.ToString("C")
                    End If
                Else
                    MsgBox("You put in a negative number, please put in a postive value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
                End If
            Else
                MsgBox("Enter a number less than or equal to 20", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
            End If
        Else
            MsgBox("Please enter a numerical value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'
        txtGroupSize.Text = ""
        txtGroupSize.Focus()
        txtRegistrationCost.Text = ""
        txtRegistrationCost.Focus()
        txtGroupSize.Clear()
        txtRegistrationCost.Clear()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program'
        Close()
    End Sub
End Class
