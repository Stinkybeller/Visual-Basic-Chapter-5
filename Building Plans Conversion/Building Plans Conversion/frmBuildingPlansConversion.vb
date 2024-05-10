'Program: Building Plans Converion'
'Developer: Izabella Fortunata'
'Date: 11/17/23'
'Purpose: To provide an accurate conversion from the metric system to the imperial or vice versa.'
Public Class frmBuildingPlansConversion
    'Clearing the form'
    'txtNumberOfInches.Text = ""
    'txtNumberOfInches.Focus()
    'txtConvertedNumber.Text = ""
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'When the user clicks their choice then the convert button, it will display the final conversion'
        'Defining variables'
        Dim decNumberOfInches As Decimal
        Dim decConvertedNumber As Decimal
        Dim strInOrM As String
        Dim decInch As Decimal = 0.0254
        Dim decMeter As Decimal = 39.37008

        'Converting variables'
        If IsNumeric(txtNumberOfInches.Text) Then
            decNumberOfInches = Convert.ToDecimal(txtNumberOfInches.Text)

            'If the user eneterd a numeric value the program will execute'
            If decNumberOfInches > 0 Then
                If radImperialToMetric.Checked Then
                    'm = x * 0.0254'
                    decConvertedNumber = decNumberOfInches * decInch
                    txtConvertedNumber.Text = decConvertedNumber.ToString("G")
                    strInOrM = "Meters"
                ElseIf radMetricToImperial.Checked Then
                    'I = x * 39.37008
                    decConvertedNumber = decNumberOfInches * decMeter
                    txtConvertedNumber.Text = decConvertedNumber.ToString("G")
                    strInOrM = "Inches"
                End If
                'Displaying Inch or Meter'
                lblInOrM.Text = strInOrM
            Else
                'If the user enterd a negative number, it display an error'
                MsgBox("You entered " & decNumberOfInches.ToString() & ". Enter a Positive Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
                txtConvertedNumber.Text = ""
                txtConvertedNumber.Focus()
            End If
        Else
            'If the user entered anything else that is not a number than this message will be displayed'
            MsgBox("Enter a numerical value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
            txtConvertedNumber.Text = ""
            txtConvertedNumber.Focus()
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'
        txtNumberOfInches.Text = ""
        txtNumberOfInches.Focus()
        txtConvertedNumber.Text = ""
        txtConvertedNumber.Focus()
    End Sub
End Class
