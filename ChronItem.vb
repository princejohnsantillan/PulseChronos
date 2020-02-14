Imports SterlingLib
Public Class ChronItem

    Inherits STMessage

    Public Const QUEUED_STATUS As String = "Queued"
    Public Const PROCESSING_STATUS As String = "Processing"
    Public Const PROCESSED_STATUS As String = "Processed"
    Public Const FAILED_STATUS As String = "FAILED"

    Private cv_Status As String
    Private cv_Time As String
    Private cv_Symbol As String
    Private cv_Side As String
    Private cv_Quantity As Integer
    Private cv_Destination As String
    Private cv_Account As String
    Private cv_OrderResponse As String

    Private cv_structSTIOrder As structSTIOrder

    Public ReadOnly Property Status() As String
        Get
            Return cv_Status
        End Get
    End Property
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
    Public ReadOnly Property OrderResponse() As String
        Get
            Return cv_OrderResponse
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
        cv_Status = QUEUED_STATUS

        cv_structSTIOrder.bstrSymbol = cv_Symbol
        cv_structSTIOrder.bstrSide = EncodeSide(cv_Side)
        cv_structSTIOrder.nQuantity = cv_Quantity
        cv_structSTIOrder.bstrDestination = cv_Destination
        cv_structSTIOrder.bstrAccount = cv_Account

        'Additionl required fields
        cv_structSTIOrder.nPriceType = STIPriceTypes.ptSTIMkt 'MARKET
        cv_structSTIOrder.bstrTif = "D" 'DAY
        cv_structSTIOrder.bstrClOrderId = "PC-" + Guid.NewGuid.ToString()
    End Sub

    Public Function IsQueued() As Boolean
        Return cv_Status = QUEUED_STATUS
    End Function

    Public Function IsProcessed() As Boolean
        Return cv_Status = PROCESSED_STATUS
    End Function

    Public Function IsFailed() As Boolean
        Return cv_Status = FAILED_STATUS
    End Function

    Public Function IsOnTime(ByVal fp_Time As String) As Boolean
        Return cv_Time = fp_Time
    End Function

    Public Sub SetStatus(ByVal sp_status As String)
        cv_Status = sp_status
    End Sub

    Public Sub SubmitSTOrder()
        If IsQueued() Then
            SetStatus(PROCESSING_STATUS)

            Try
                Dim lv_STIOrder As New STIOrder
                Dim lv_OrderResponse As Integer = 0

                lv_OrderResponse = lv_STIOrder.SubmitOrderStruct(cv_structSTIOrder)
                cv_OrderResponse = InterpretOrderErrorCode(lv_OrderResponse)

                If (lv_OrderResponse = 0) Then
                    SetStatus(PROCESSED_STATUS)
                Else
                    SetStatus(FAILED_STATUS)
                End If
            Catch ex As Exception
                'To do: add to log list from separate thread
            End Try
        End If
    End Sub
End Class
