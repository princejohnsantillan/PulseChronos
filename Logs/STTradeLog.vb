Imports SterlingLib

Public Class STTradeLog
    Inherits STMessage

    Private cv_ServerTime As String
    Private cv_Account As String
    Private cv_Symbol As String
    Private cv_Side As String
    Private cv_Quantity As Integer
    Private cv_LvsQuantity As Integer
    Private cv_ExecPrice As Double
    Private cv_Destination As String
    Private cv_PriceType As String

    Private cv_DBsNo As Integer
    Private cv_SeqNo As Integer
    Private cv_ClientOrderID As String
    Private cv_OrderRecordID As Integer
    Private cv_TradeRecordID As Integer

    Private cv_LogMessage As String

    Public ReadOnly Property Server_Time() As String
        Get
            Return cv_ServerTime
        End Get
    End Property
    Public ReadOnly Property Account() As String
        Get
            Return cv_Account
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
    Public ReadOnly Property LVS_Quantity() As Integer
        Get
            Return cv_LvsQuantity
        End Get
    End Property
    Public ReadOnly Property Exec_Price() As Double
        Get
            Return cv_ExecPrice
        End Get
    End Property
    Public ReadOnly Property Destination() As String
        Get
            Return cv_Destination
        End Get
    End Property
    Public ReadOnly Property Price_Type() As String
        Get
            Return cv_PriceType
        End Get
    End Property

    Public ReadOnly Property DB_No() As Integer
        Get
            Return cv_DBsNo
        End Get
    End Property
    Public ReadOnly Property Sequence_No() As Integer
        Get
            Return cv_SeqNo
        End Get
    End Property
    Public ReadOnly Property Client_Order_ID() As String
        Get
            Return cv_ClientOrderID
        End Get
    End Property
    Public ReadOnly Property Order_Record_ID() As Integer
        Get
            Return cv_OrderRecordID
        End Get
    End Property
    Public ReadOnly Property Trade_Record_ID() As Integer
        Get
            Return cv_TradeRecordID
        End Get
    End Property

    Public ReadOnly Property Log_Message() As String
        Get
            Return cv_LogMessage
        End Get
    End Property

    Public Sub New(ByVal sp_ServerTime As String, ByVal sp_xml As structSTITradeUpdate)
        cv_ServerTime = sp_ServerTime
        cv_Account = sp_xml.bstrAccount
        cv_Symbol = sp_xml.bstrSymbol
        cv_Side = InterpretSide(sp_xml.bstrSide)
        cv_Quantity = sp_xml.nQuantity
        cv_LvsQuantity = sp_xml.nLvsQuantity
        cv_ExecPrice = sp_xml.fExecPrice
        cv_Destination = sp_xml.bstrDestination
        cv_PriceType = InterpretPriceType(sp_xml.nPriceType)

        cv_DBsNo = sp_xml.nDbsNo
        cv_SeqNo = sp_xml.nSeqNo
        cv_ClientOrderID = sp_xml.bstrClOrderId
        cv_OrderRecordID = sp_xml.nOrderRecordId
        cv_TradeRecordID = sp_xml.nTradeRecordId

        cv_LogMessage = sp_xml.bstrLogMessage
    End Sub
End Class
