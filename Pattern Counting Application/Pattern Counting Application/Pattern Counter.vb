'Lucas Hauf 
'11/16/2015
'POS/408
'This program was made to display a pattern according to user specifications

Public Class frmCountingForm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'closes the application

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim intStartCheck As Integer 'the following variables store the parsed information from the text fields 
        Dim intNumberCheck As Integer
        Dim intStepCheck As Integer


        If txtStartingPosition.Text = "" Then 'these if statments tests to see if any information has been entered into the text fields
            MessageBox.Show("Please enter a value in the Starting Position field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStartingPosition.Focus()
            Exit Sub
        ElseIf txtHowManyTimes.Text = "" Then
            MessageBox.Show("Please enter a value in the Number of Times field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHowManyTimes.Focus()
            Exit Sub
        ElseIf txtStepThrough.Text = "" Then
            MessageBox.Show("Please enter a value in the Step field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStepThrough.Focus()
            Exit Sub
        End If

        Try 'the following try catches test to makes sure only integers are enterd into the text boxes
            intStartCheck = Integer.Parse(txtStartingPosition.Text)
        Catch FailedStart As Exception
            MessageBox.Show("Please enter a valid number in the Starting Position field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStartingPosition.Focus()
            Exit Sub
        End Try
        Try
            intNumberCheck = Integer.Parse(txtHowManyTimes.Text)
        Catch FailedNumber As Exception
            MessageBox.Show("Please enter a valid number in the Number of Times field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHowManyTimes.Focus()
            Exit Sub
        End Try
        Try
            intStepCheck = Integer.Parse(txtStepThrough.Text)
        Catch FailedStep As Exception
            MessageBox.Show("Please enter a valid number in the Step field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStepThrough.Focus()
            Exit Sub
        End Try

        If intNumberCheck < 1 Then 'these if statments make sure that 0 is not entered into the Number of Times and Step fields
            MessageBox.Show("Please enter 1 - 99 in the Number of Times field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHowManyTimes.Focus()
            Exit Sub
        ElseIf intStepCheck < 1 Then
            MessageBox.Show("Please enter 1 - 99 in the Step field", "Pattern Counter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStepThrough.Focus()
            Exit Sub
        End If

        Call Counter() 'this tells the program to use the Counter method
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.txtHowManyTimes.Clear() 'this clears all information from all fields
        Me.txtStartingPosition.Clear()
        Me.txtStepThrough.Clear()
        Me.LtbDisplay.Items.Clear()
    End Sub
    Private Sub Counter()
        Dim intNumberOfTimes As Integer 'this variable controls how many times the do while loop cycles through
        Dim intStep As Integer ' holds the parsed information from the text field
        Dim intCounter As Integer ' this variable holds the 0 starting point for the do while loop
        Dim intTotal As Integer 'this variable holds the added vaule of intFirst and intSecond
        Dim intFirst As Integer ' holds the parsed information from the text field
        Dim intSecond As Integer ' this variable holds the value of the second number in the pattern
        intFirst = Integer.Parse(Me.txtStartingPosition.Text) 'this converts the text information to an integer type
        intNumberOfTimes = Integer.Parse(Me.txtHowManyTimes.Text)
        intStep = Integer.Parse(Me.txtStepThrough.Text)
        intCounter = 0 'this sets the counter value to 0
        Do While intCounter < intNumberOfTimes 'this loop controls the amount of times the for loop will run
            For intCount As Integer = 0 To 0 Step intStep 'this loop controls what numbers will be displayed for the pattern
                intSecond = intFirst + intFirst
                intTotal = intFirst + intSecond
                Me.LtbDisplay.Items.Add(intFirst & "+" & intSecond & "=" & intTotal) 'this section adds the total to the list box
                intFirst += intStep ' this section changes the intfirst variable so that the next loop will continue the pattern that the user has specified
            Next
            intCounter += 1 'this causes the do while loop to cycle through
        Loop
    End Sub
End Class
