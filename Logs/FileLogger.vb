Imports System.IO

Public Class FileLogger

    Public Shared Sub LogError(ByVal sp_Details As String)
        Try
            Using v_StreamWriter As StreamWriter = File.AppendText("Errors.log")
                v_StreamWriter.WriteLine("[" & Now.ToString("MM-dd HH:mm:ss") & "] " & sp_Details)
            End Using
        Catch ex As Exception
            'To do: come up with a fallback
        End Try
    End Sub

End Class
