Public Class ActivityLog
    Private cv_Time As String
    Private cv_Type As String
    Private cv_Details As String
    Public ReadOnly Property Time() As String
        Get
            Return cv_Time
        End Get
    End Property
    Public ReadOnly Property Type() As String
        Get
            Return cv_Type
        End Get
    End Property
    Public ReadOnly Property Details() As String
        Get
            Return cv_Details
        End Get
    End Property

    Public Sub New(ByVal sp_Type As String, ByVal sp_Details As String)
        cv_Time = Now.ToString("HH:mm:ss")
        cv_Type = sp_Type
        cv_Details = sp_Details
    End Sub
End Class
