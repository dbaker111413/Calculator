Public Class Calculator
    Private currentCalculation As String = String.Empty
    Private completedCalculation As String = String.Empty
    Private Const errorCode As Int32 = -999999

    ' sets the currentCalculation string
    Public Sub setCurrentCalculation(ByVal newCalculation As String)
        currentCalculation = newCalculation
    End Sub

    ' appends new content to the end of the current calculation string
    Public Sub appendCurrentCalculation(ByVal appendVal As String)
        currentCalculation += appendVal
    End Sub

    ' gets the current calculation string
    Public Function getCurrentCalculation() As String
        Return currentCalculation
    End Function

    ' gets the completed calculation string
    Public Function getCompletedCalculation() As String
        Return completedCalculation
    End Function

    ' performs the calculation. Returns true if calculation was successful, false otherwise
    Public Function startCalculation(ByVal operand1 As String, ByVal operand2 As String, ByVal opcode As String) As Boolean
        Dim first As Int32         ' first operand
        Dim second As Int32        ' second operand

        ' convert operands to integers, check for errors
        Try
            first = Int32.Parse(operand1)
            second = Int32.Parse(operand2)
        Catch ex As FormatException
            MessageBox.Show("Incorrect operands!")
            Return False
        End Try

        ' perform calculation based on the operation
        Select Case opcode.ElementAt(0)
            Case "+"
                first = add(first, second)
            Case "-"
                first = subtract(first, second)
            Case "*"
                first = multiply(first, second)
            Case "/"
                first = divide(first, second)
                If (first = errorCode) Then
                    errorMessage("Cannot divide by zero!")
                    completedCalculation += " Error"
                    Return False
                End If
            Case Else
                errorMessage("Invalid operation " + opcode)
        End Select

        Console.WriteLine(first.ToString + " " + opcode + " " + second.ToString)
        completedCalculation = first.ToString
        Return True
    End Function

    ' adds the two operands and returns the result
    Private Function add(ByVal first As Int32, ByVal second As Int32) As Int32
        Return first + second
    End Function

    ' subtracts the two operands and returns the result
    Private Function subtract(ByVal first As Int32, ByVal second As Int32) As Int32
        Return first - second
    End Function

    ' multiplies the two operands and returns the result
    Private Function multiply(ByVal first As Int32, ByVal second As Int32) As Int32
        Return first * second
    End Function

    ' divides first by second, returns error code if second is equal to 0
    Private Function divide(ByVal first As Int32, ByVal second As Int32) As Int32
        If second = 0 Then
            Return errorCode
        Else
            Return first / second
        End If
    End Function

    ' Used if there is an error with the input
    Private Sub errorMessage(ByVal message As String)
        currentCalculation = ""
        MessageBox.Show(message)
    End Sub
End Class
