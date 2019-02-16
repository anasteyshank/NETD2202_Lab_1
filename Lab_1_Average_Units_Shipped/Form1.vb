' *********************************************************************************************************
' * Name: Anastasiia Kononirenko
' * ID: 100717670
' * Date: 25/01/2019
' * Purpose: Lab_1_Average_Units_Shipped
' * Description: A windows forms application that calculates the average number of units shipped per 
' *              week. The application takes an input for each day in the week numbered from 1 to 7.
' *              User input is then validated and, if it passes validation, the data is displayed 
' *              to the user. Once the number of units has been entered for the 7th day, the program 
' *              calculates and displays the average to the user. The application doesn't allow
' *              the user to strike the enter key or input any more data until the form is reset.
' *********************************************************************************************************

Option Strict On

Public Class frmAverageUnitsShipped

    ' CONSTANTS DECLARATION         
    Const NUMBER_OF_DAYS As Integer = 7
    Const MINIMUM_NUMBER_OF_UNITS As Integer = 0
    Const MAXIMUM_NUMBER_OF_UNITS As Integer = 1000

    ' VARIABLES DECLARATION
    Dim dayNumber As Integer = 1
    Dim unitsShipped() As Integer = New Integer(NUMBER_OF_DAYS - 1) {}
    Dim numberOfUnits As Integer
    Dim averageUnitsShipped As Double = 0

#Region "btnEnter"
    ''' <summary>
    ''' The Click event of the btnEnter button that validates the user input.
    ''' If it passes validation, the data is displayed to the user in txtDisplayUnitsShipped textbox.
    ''' Once the number of units has been entered for the 7th day, the average is calculated and
    ''' displayed to the user. If the user input doesn't pass validation, the user is prompt to
    ''' enter a number again.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' INPUT VALIDATION
        ' Check that the number of units was entered in the txtUserInput and it’s an integer
        If (Integer.TryParse(txtUserInput.Text, numberOfUnits)) Then
            ' Check that the entered number is between the required range
            If (numberOfUnits >= MINIMUM_NUMBER_OF_UNITS And numberOfUnits <= MAXIMUM_NUMBER_OF_UNITS) Then
                ' Display the number in txtDisplayUnitsShipped
                txtDisplayUnitsShipped.Text += numberOfUnits.ToString & vbCrLf
                ' Store the number in the array
                unitsShipped(dayNumber - 1) = numberOfUnits
                ' Clear the txtUserInput textbox
                txtUserInput.Clear()
                ' Check if the number was entered for the last day
                If (dayNumber = NUMBER_OF_DAYS) Then
                    ' Calculate the average usinf a For Loop
                    For counter As Integer = 0 To NUMBER_OF_DAYS - 1
                        averageUnitsShipped += unitsShipped(counter) / NUMBER_OF_DAYS
                    Next
                    ' Display the calculated average
                    lblDisplayAverage.Text = "Average per day: " & Math.Round(averageUnitsShipped, 2).ToString
                    ' Set the ReadOnly property of txtUserInput textbox to True
                    txtUserInput.ReadOnly = True
                    ' Disabel the btnEnter button
                    btnEnter.Enabled = False
                    ' If the number wasn't enetered for the last day, do
                Else
                    ' Increase the dayNumber by 1
                    dayNumber += 1
                    ' Display the day number in lblDays lable
                    lblDays.Text = "Day " & dayNumber.ToString
                End If
                ' If the entered number isn't within the range, display the error message in the MessageBox
            Else
                MessageBox.Show("Number of units must be between " & MINIMUM_NUMBER_OF_UNITS.ToString & " and " & MAXIMUM_NUMBER_OF_UNITS.ToString & ". Please try again.")
            End If
            ' If the enetred input isn't an integer, display the error message in the MessageBox
        Else
            MessageBox.Show("Input must be numeric, whole numbers only, no decimals. Please try again.")
        End If
        ' Select the text in the entry text box
        txtUserInput.SelectAll()
    End Sub
#End Region

#Region "btnReset"
    ''' <summary>
    ''' Click event of the reset button that resets the form using a subroutine
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub

    ''' <summary>
    ''' Private function that resets the form (clears text boxes and lables, if necessary, enables the txtUserInput text box 
    ''' and the btnenter button)
    ''' </summary>
    Private Sub resetForm()
        ' Assign the averageUnitsShipped value to 0
        averageUnitsShipped = 0
        ' Assign the dayNumber value to 1
        dayNumber = 1
        ' Set the ReadOnly property of txtUserInput textbox to False
        txtUserInput.ReadOnly = False
        ' Set the Focus to the txtUserInput text box
        txtUserInput.Focus()
        ' Display the day number in lblDays lable 
        lblDays.Text = "Day " & dayNumber.ToString
        ' Clear the txtDisplayUnitsShipped text box
        txtDisplayUnitsShipped.Clear()
        ' Set the Text properrty of lblDisplayAverage lable to ""
        lblDisplayAverage.Text = ""
        ' Enable the btnEnter button
        btnEnter.Enabled = True
    End Sub
#End Region

#Region "btnExit"
    ''' <summary>
    ''' Click event of the exit button that exits the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
#End Region

End Class
