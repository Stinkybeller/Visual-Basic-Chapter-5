'Program: Planetary Weight'
'Developer: Izabella Fortunata'
'Date: 11/14/23'
'Purpose: This application lets the user enter their weight to see what their weight would be on the two planets that they are able to choose from.'

Public Class frmPlanetaryWeight
    Private Sub frmPlanetaryWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clearing the form'
        txtEnterWeight.Text = ""
        txtEnterWeight.Focus()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'When the user clicks the button, it calculates the users weight depending on the planet that they pick, then it converts to kgs'
        'Defining the variables'
        Dim decVenusWeight As Decimal = 0.907D
        Dim decMarsWeight As Decimal = 0.377D
        Dim decPoundToKilogram As Decimal = 0.454D
        Dim decWeightInKilograms As Decimal
        Dim decEnterWeight As Decimal
        Dim decFinalWeight As Decimal
        Dim strPlanet As String

        'Converting the varibles'
        If IsNumeric(txtEnterWeight.Text) Then
            decEnterWeight = Convert.ToDecimal(txtEnterWeight.Text)

            'If the user entered a numeric value the program will execute'
            If decEnterWeight > 0 Then
                If radConvertToVenus.Checked Then
                    'If Venus was chosen, the calculation will take place'

                    decFinalWeight = decEnterWeight * decVenusWeight
                    lblFinalWeight.Text = decFinalWeight.ToString("F")
                    strPlanet = "Venus"
                    'Converting calculations from pounds to kilograms'
                    decWeightInKilograms = decFinalWeight * decPoundToKilogram
                ElseIf radConvertToMars.Checked Then
                    'If Mars was chosen, the calulation will take place'

                    decFinalWeight = decEnterWeight * decMarsWeight
                    lblFinalWeight.Text = decFinalWeight.ToString("F")
                    strPlanet = "Mars"
                    'Converting calculations from pounds to kilograms'
                    decWeightInKilograms = decFinalWeight * decPoundToKilogram
                End If
                'Displaying the final calculation'
                lblFinalWeight.Text = "Your weight on " & strPlanet & " is " & decFinalWeight.ToString("F1") & " lbs, " & "or " & decWeightInKilograms.ToString("F1") & " kgs. "
            Else
                'If the user entered a negative number it will display an error'
                MsgBox("You entered " & decEnterWeight.ToString() & ". Enter a Positive Number", , "Input Error")
                lblFinalWeight.Text = ""
                lblFinalWeight.Focus()
            End If
        Else
            'If the user did not enter a numerical value or left it blank, an error will appear'
            MsgBox("Enter your weight", , "Input Error")
            lblFinalWeight.Text = ""
            lblFinalWeight.Focus()

        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'
        txtEnterWeight.Text = ""
        txtEnterWeight.Focus()
        lblFinalWeight.Text = ""
        lblFinalWeight.Focus()
        txtEnterWeight.Clear()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the application'
        Close()
    End Sub


End Class
