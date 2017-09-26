Public Class History
    Private logs() As String

    ' adds a new log to the logs array
    Public Sub Log(ByVal log As String)
        Try
            ReDim Preserve logs(UBound(logs) + 1)  ' resize the array
            logs(logs.Count - 1) = log  ' add to the log
        Catch ex As ArgumentNullException
            logs = New String() {log}   ' initialize the log
        End Try
    End Sub

    ' saves all the logs in the history
    Public Sub SaveLogs()
        LogSave.Save(logs)
    End Sub
End Class
