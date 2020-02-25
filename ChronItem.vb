Imports System.Text.RegularExpressions
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
    Public Property Time() As String
        Get
            Return cv_Time
        End Get
        Set(value As String)
            Dim lv_regex = New Regex("^([0-1][0-9]|[2][0-3]):([0-5][0-9]):([0-5][0-9])$")
            If lv_regex.Match(value).Success Then
                cv_Time = value
            Else
                MsgBox("Invalid time.")
            End If
        End Set
    End Property
    Public Property Symbol() As String
        Get
            Return cv_Symbol
        End Get
        Set(value As String)
            cv_Symbol = value.ToUpper
        End Set
    End Property
    Public Property Side() As String
        Get
            Return cv_Side
        End Get
        Set(value As String)
            If Sides.Values.ToArray.Contains(value) Then
                cv_Side = value
            Else
                MsgBox("Invalid side.")
            End If
        End Set
    End Property
    Public Property Quantity() As Integer
        Get
            Return cv_Quantity
        End Get
        Set(value As Integer)
            If value <= 0 Then
                MsgBox("Quantity must be a positive whole number.")
            Else
                cv_Quantity = value
            End If
        End Set
    End Property
    Public Property Destination() As String
        Get
            Return cv_Destination
        End Get
        Set(value As String)
            cv_Destination = value
        End Set
    End Property
    Public Property Account() As String
        Get
            Return cv_Account
        End Get
        Set(value As String)
            cv_Account = value
        End Set
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

    Public Shared Sub InitializeTable(ByRef sp_DataGridView As DataGridView, ByVal sp_Destination As Array, ByVal sp_Accounts As Array)
        Dim lv_Destinations() As String = sp_Destination.Clone()
        Dim lv_Accounts() As String = sp_Accounts.Clone()

        sp_DataGridView.AutoGenerateColumns = False
        sp_DataGridView.Columns.Clear()

        Dim lv_StatusColumn As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn() With {.DataPropertyName = "Status", .Name = "Status"}
        Dim lv_TimeColumn As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn() With {.DataPropertyName = "Time", .Name = "Time"}
        Dim lv_SymbolColumn As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn() With {.DataPropertyName = "Symbol", .Name = "Symbol"}
        Dim lv_SideColumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn() With {.DataSource = Sides.Values.ToArray, .DataPropertyName = "Side", .Name = "Side"}
        Dim lv_QuantityColumn As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn() With {.DataPropertyName = "Quantity", .Name = "Quantity"}
        Dim lv_DestinationColumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn() With {.DataSource = lv_Destinations, .DataPropertyName = "Destination", .Name = "Destination"}
        Dim lv_AccountColumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn() With {.DataSource = lv_Accounts, .DataPropertyName = "Account", .Name = "Account"}
        Dim lv_OrderResponseColumn As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn() With {.DataPropertyName = "OrderResponse", .Name = "OrderResponse"}

        sp_DataGridView.Columns.Add(lv_StatusColumn)
        sp_DataGridView.Columns.Add(lv_TimeColumn)
        sp_DataGridView.Columns.Add(lv_SymbolColumn)
        sp_DataGridView.Columns.Add(lv_SideColumn)
        sp_DataGridView.Columns.Add(lv_QuantityColumn)
        sp_DataGridView.Columns.Add(lv_DestinationColumn)
        sp_DataGridView.Columns.Add(lv_AccountColumn)
        sp_DataGridView.Columns.Add(lv_OrderResponseColumn)

        sp_DataGridView.AutoResizeColumns()
    End Sub

End Class
