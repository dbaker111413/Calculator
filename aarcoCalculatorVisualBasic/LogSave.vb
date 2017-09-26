Imports System
Imports System.IO

Public Class LogSave

    Private Const PATH = "log.txt"

    ' saves an array of strings which contain calculation history
    Public Shared Sub Save(ByVal logs() As String)
        Dim stream_out As StreamWriter = New StreamWriter(PATH)

        ' write out all the logs
        For Each log As String In logs
            stream_out.Write(log & Environment.NewLine)
        Next

        ' notify the user that the save has completed
        MessageBox.Show("Saved history to log.txt")

        stream_out.Close()  ' close the stream
    End Sub

End Class
