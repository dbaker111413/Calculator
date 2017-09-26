Public Class Form1

    Private calculator As New Calculator
    Private history As New History

    ' used to store input
    Private firstOperand As String = ""
    Private secondOperand As String = ""
    Private result As String = ""
    Private op As Char

    ' used to format output
    Private typedNumber As String = ""
    Private currentEquation As String = ""

    ' clears current entry and current calculation
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        firstOperand = ""
        secondOperand = ""
        result = ""
        op = ""
        typedNumber = ""
        currentEquation = ""
        updateNumberText("")
    End Sub

    ' clears the current entry but does not clear the current calculation
    Private Sub clearEntryButton_Click(sender As Object, e As EventArgs) Handles clearEntryButton.Click
        typedNumber = ""
        updateNumberText("")
    End Sub

    ' deletes the latest character in the user's input
    Private Sub backspaceButton_Click(sender As Object, e As EventArgs) Handles backspaceButton.Click
        If (typedNumber.Length > 0) Then
            typedNumber = typedNumber.Substring(0, typedNumber.Length - 1)
            updateNumberText("")
        End If
    End Sub

    ' sets addition
    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        updateoperator("+")
    End Sub

    ' sets subtraction
    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        updateoperator("-")
    End Sub

    ' sets multiplication
    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        updateoperator("*")
    End Sub

    ' sets division
    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        updateoperator("/")
    End Sub

    ' number buttons simply add the number to the typedNumber string
    Private Sub nineButton_Click(sender As Object, e As EventArgs) Handles nineButton.Click
        updateNumberText("9")
    End Sub

    Private Sub eightButton_Click(sender As Object, e As EventArgs) Handles eightButton.Click
        updateNumberText("8")
    End Sub

    Private Sub sevenButton_Click(sender As Object, e As EventArgs) Handles sevenButton.Click
        updateNumberText("7")
    End Sub

    Private Sub fourButton_Click(sender As Object, e As EventArgs) Handles fourButton.Click
        updateNumberText("4")
    End Sub

    Private Sub fiveButton_Click(sender As Object, e As EventArgs) Handles fiveButton.Click
        updateNumberText("5")
    End Sub

    Private Sub sixButton_Click(sender As Object, e As EventArgs) Handles sixButton.Click
        updateNumberText("6")
    End Sub

    Private Sub oneButton_Click(sender As Object, e As EventArgs) Handles oneButton.Click
        updateNumberText("1")
    End Sub

    Private Sub twoButton_Click(sender As Object, e As EventArgs) Handles twoButton.Click
        updateNumberText("2")
    End Sub

    Private Sub threeButton_Click(sender As Object, e As EventArgs) Handles threeButton.Click
        updateNumberText("3")
    End Sub

    Private Sub zeroButton_Click(sender As Object, e As EventArgs) Handles zeroButton.Click
        updateNumberText("0")
    End Sub

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalButton.Click
        calculate()
    End Sub

    ' updates the typed number
    Private Sub updateNumberText(ByVal num As String)
        If (result.Length > 0) Then
            ' this occurs if there is a displayed result and the user is not continuing with it
            typedNumber = ""
            result = ""
        End If
        typedNumber += num    ' update the typed number
        ' update the output
        calculationTextBox.Text = ""
        calculationTextBox.AppendText(typedNumber & Environment.NewLine & currentEquation)

    End Sub

    ' updates the operator and equation 
    Private Sub updateoperator(ByVal operation As String)
        ' check if an equation has already been set up
        If (currentEquation.Length > 0) Then
            ' check if the user has entered a second number for the equation
            If (typedNumber.Length > 0) Then
                ' Perform calculation using typedNumber as second operand
                calculate()
                firstOperand = result
            End If
            'otherwise, simply update the operator
            op = operation
            currentEquation = firstOperand & " " & op
            updateNumberText("")

        ElseIf (typedNumber.Length > 0) Then ' if there is not an equation set up yet, start one
            firstOperand = typedNumber
            typedNumber = ""
            op = operation
            currentEquation = firstOperand & " " & op
            updateNumberText("")
        End If
    End Sub

    ' performs the calculation
    Private Sub calculate()
        ' perform the calculation and update the output
        If (currentEquation.Length > 0) Then
            ' get the second operand
            secondOperand = typedNumber
            typedNumber = ""
            If (calculator.startCalculation(firstOperand, secondOperand, op)) Then
                result = calculator.getCompletedCalculation()
                history.Log(firstOperand & " " & op & " " & secondOperand & " = " & result)
                historyTextBox.AppendText(firstOperand & " " & op & " " & secondOperand & " = " & result & Environment.NewLine)
                firstOperand = ""
                secondOperand = ""
                op = ""
                currentEquation = ""
                calculationTextBox.Text = result
                typedNumber = result
            Else
                calculationTextBox.Text = firstOperand
                typedNumber = firstOperand
                firstOperand = ""
                currentEquation = ""
                op = ""
            End If
        End If
    End Sub

    ' saves the history
    Private Sub saveHistoryButton_Click(sender As Object, e As EventArgs) Handles saveHistoryButton.Click
        history.SaveLogs()
    End Sub
End Class
