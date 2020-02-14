<Serializable()>
Public Class SerializableChronItem
    Private cv_Time As String
    Private cv_Symbol As String
    Private cv_Side As String
    Private cv_Quantity As Integer
    Private cv_Destination As String
    Private cv_Account As String

    Public ReadOnly Property Time() As String
        Get
            Return cv_Time
        End Get
    End Property
    Public ReadOnly Property Symbol() As String
        Get
            Return cv_Symbol
        End Get
    End Property
    Public ReadOnly Property Side() As String
        Get
            Return cv_Side
        End Get
    End Property
    Public ReadOnly Property Quantity() As Integer
        Get
            Return cv_Quantity
        End Get
    End Property
    Public ReadOnly Property Destination() As String
        Get
            Return cv_Destination
        End Get
    End Property
    Public ReadOnly Property Account() As String
        Get
            Return cv_Account
        End Get
    End Property

    Public Sub New(
                  ByVal sp_Time As String,
                  ByVal sp_Symbol As String,
                  ByVal sp_Side As String,
                  ByVal sp_Quantity As Integer,
                  ByVal sp_Destination As String,
                  ByVal sp_Account As String)

        cv_Time = sp_Time
        cv_Symbol = sp_Symbol
        cv_Side = sp_Side
        cv_Quantity = sp_Quantity
        cv_Destination = sp_Destination
        cv_Account = sp_Account
    End Sub
End Class
