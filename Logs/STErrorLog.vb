Imports SterlingLib

Public Class STErrorLog
    Inherits STMessage

    Private cv_ServerTime As String
    Private cv_rejectReason As String
    Private cv_Text As String

    Private cv_Account As String
    Private cv_Symbol As String
    Private cv_Side As String
    Private cv_Quantity As Integer
    Private cv_Destination As String

    Private cv_CLOrderID As String

    Public ReadOnly Property Server_Time() As String
        Get
            Return cv_ServerTime
        End Get
    End Property
    Public ReadOnly Property Reject_Reason() As String
        Get
            Return cv_rejectReason
        End Get
    End Property
    Public ReadOnly Property Text() As String
        Get
            Return cv_Text
        End Get
    End Property

    Public ReadOnly Property Account() As String
        Get
            Return cv_Account
        End Get
    End Property
    Public ReadOnly Property Side() As String
        Get
            Return cv_Side
        End Get
    End Property
    Public ReadOnly Property Symbol() As String
        Get
            Return cv_Symbol
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

    Public ReadOnly Property CL_Order_ID() As String
        Get
            Return cv_CLOrderID
        End Get
    End Property


    Public Sub New(ByVal sp_ServerTime As String, ByVal sp_xml As structSTIOrderReject)
        cv_ServerTime = sp_ServerTime
        cv_rejectReason = InterpretRejectReason(sp_xml.nRejectReason)
        cv_Text = sp_xml.bstrText

        cv_Account = sp_xml.bstrAccount
        cv_Symbol = sp_xml.bstrSymbol
        cv_Side = InterpretSide(sp_xml.bstrSide)
        cv_Quantity = sp_xml.nQuantity
        cv_Destination = sp_xml.bstrDestination

        cv_CLOrderID = sp_xml.bstrClOrderId

        FileLogger.LogError(cv_rejectReason & " >>> " & cv_Text)
    End Sub
End Class
