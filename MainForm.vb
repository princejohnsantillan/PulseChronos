﻿Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports SterlingLib
Imports Microsoft.Office.Interop.Excel

Public Class MainForm

#Region "Class Variables"
    Private Const AUTOSAVE_FILE = "AutoSave.pcql"

    Private cv_STIApp As STIApp
    Private WithEvents cv_STIEvents As STIEvents
    Private cv_STIAcctMaint As STIAcctMaint

    Private cv_STServerTime As String = ""
    Private cv_TraderName As String = ""
    Private cv_AccountList As String() = Nothing
    Private cv_DestinationList As String() = Nothing

    Private cv_IsPulseRunning As Boolean = False

    Private cv_Logger As Logger
    Private WithEvents cv_ChronItemList As List(Of ChronItem)
#End Region

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ProductName & " " & ProductVersion

        ActivityLogGrid.DataSource = BindActivityGrid
        STTradeGrid.DataSource = BindSTTradeGrid
        STErrorGrid.DataSource = BindSTErrorGrid
        ChronItemGrid.DataSource = BindChronItemGrid

        Try
            cv_STIApp = New STIApp
            cv_STIEvents = New STIEvents
            cv_STIAcctMaint = New STIAcctMaint

            STTimer.Start()

            cv_Logger = New Logger() 'Timer should start before instantiating logger
            cv_ChronItemList = New List(Of ChronItem)

            BindActivityGrid.DataSource = cv_Logger.ActivityList
            BindSTTradeGrid.DataSource = cv_Logger.STTradeList
            BindSTErrorGrid.DataSource = cv_Logger.STErrorList
            BindChronItemGrid.DataSource = cv_ChronItemList

            cv_STIApp.SetModeXML(True)
            cv_STIEvents.SetOrderEventsAsStructs(True)
            cv_Logger.LogInfoActivity("Pulse Chronos Initialized.")

            cv_TraderName = cv_STIApp.GetTraderName()
            cv_STIAcctMaint.GetAccountList(cv_AccountList)
            cv_STIApp.GetDestinationList(cv_DestinationList)
            cv_Logger.LogInfoActivity("Successfully fetched Trader name, Account list, and Destination list.")

            If (cv_STIApp.IsApiEnabled) Then
                STAPIEnabledLabel.Text = "TRUE"
                STAPIEnabledLabel.ForeColor = Color.Green
            Else
                STAPIEnabledLabel.Text = "FALSE"
                STAPIEnabledLabel.ForeColor = Color.Red
            End If
            LoginTraderLabel.Text = cv_TraderName
            AccountInput.DataSource = cv_AccountList
            DestinationInput.DataSource = cv_DestinationList
            SideInput.DataSource = STMessage.Sides.Values.ToArray

            ChronItem.InitializeGrid(ChronItemGrid, cv_DestinationList, cv_AccountList)

            If My.Computer.FileSystem.FileExists(AUTOSAVE_FILE) Then
                If LoadList(AUTOSAVE_FILE) Then
                    My.Computer.FileSystem.DeleteFile(AUTOSAVE_FILE)
                    MsgBox("Loaded auto saved list. (Note: Status not included)")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("No running Sterling Trader Pro detected.")
            Environment.Exit(0)
        End Try
    End Sub

    Private Sub SaveList(ByVal sp_File As String)
        Try
            If My.Computer.FileSystem.FileExists(sp_File) = True Then
                My.Computer.FileSystem.DeleteFile(sp_File)
            End If

            Dim lv_SerializableChronList As New List(Of SerializableChronItem)

            For Each lv_item In cv_ChronItemList
                lv_SerializableChronList.Add(New SerializableChronItem(
                    lv_item.Time,
                    lv_item.Symbol,
                    lv_item.Side,
                    lv_item.Quantity,
                    lv_item.Destination,
                    lv_item.Account
                ))
            Next

            Dim fs As Stream = New FileStream(sp_File, FileMode.Create)
            Dim bf As BinaryFormatter = New BinaryFormatter()
            bf.Serialize(fs, lv_SerializableChronList)
            fs.Close()

            cv_Logger.LogInfoActivity("Saved queue list to: " + sp_File)
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@SaveList >>> " + ex.Message)
        End Try
    End Sub

    Private Function LoadList(ByVal sp_File As String) As Boolean
        Try
            If My.Computer.FileSystem.FileExists(sp_File) Then

                Dim lv_FileExtension As String = Path.GetExtension(sp_File)

                If lv_FileExtension = ".pcql" Then
                    Dim lv_SerializableChronList As New List(Of SerializableChronItem)

                    Dim fs As Stream = New FileStream(sp_File, FileMode.Open)
                    Dim bf As BinaryFormatter = New BinaryFormatter()
                    lv_SerializableChronList = bf.Deserialize(fs)
                    fs.Close()

                    cv_ChronItemList = New List(Of ChronItem)
                    BindChronItemGrid.DataSource = cv_ChronItemList

                    For Each lv_item In lv_SerializableChronList
                        BindChronItemGrid.Add(New ChronItem(
                            lv_item.Time,
                            lv_item.Symbol,
                            lv_item.Side,
                            lv_item.Quantity,
                            lv_item.Destination,
                            lv_item.Account
                        ))
                    Next
                ElseIf lv_FileExtension = ".xls" Or lv_FileExtension = ".xlsx" Then
                    MsgBox("Improperly plotted Excel files might generate a wrong or incomplete list. PLease review your list.")
                Else
                    cv_Logger.LogErrorActivity("Invalid file type.")
                    Return False
                End If

                cv_Logger.LogInfoActivity("Loaded queue list from: " + sp_File)
                Return True
            Else
                cv_Logger.LogErrorActivity(sp_File + " does not exist.")
                Return False
            End If
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@LoadList >>> " + ex.Message)
            Return False
        End Try
    End Function

    Private Sub RefreshGrid(ByRef sp_DataGridView As DataGridView)
        sp_DataGridView.Refresh()
        sp_DataGridView.AutoResizeColumns()
    End Sub

    Private Sub RecountChronStats()
        InQueueItemsLabel.Text = cv_ChronItemList.Count
        ProcessedItemsLabel.Text = cv_ChronItemList.Where(Function(fp_chronItem) fp_chronItem.IsProcessed).Count
        FailedItemsLabel.Text = cv_ChronItemList.Where(Function(fp_chronItem) fp_chronItem.IsFailed).Count
    End Sub

#Region "Events"
    Private Sub PulseSwitchButton_Click(sender As Object, e As EventArgs) Handles PulseSwitchButton.Click
        cv_IsPulseRunning = Not cv_IsPulseRunning
        If cv_IsPulseRunning Then
            PulseSwitchButton.Text = "TURN OFF"
            PulseStatusLabel.ForeColor = Color.Green
            PulseStatusLabel.Text = "RUNNING"
        Else
            PulseSwitchButton.Text = "TURN ON"
            PulseStatusLabel.ForeColor = Color.Red
            PulseStatusLabel.Text = "PAUSED"
        End If
    End Sub

    Private Sub STTimer_Tick(sender As Object, e As EventArgs) Handles STTimer.Tick
        Try
            cv_STServerTime = cv_STIApp.GetServerTime
            Dim lv_Time As String = Regex.Replace(cv_STServerTime, "(\w{8})(\w{2})(\w{2})(\w{2})", "$2:$3:$4")
            ServerTimeLabel.Text = lv_Time

            If (cv_IsPulseRunning) Then
                For Each lv_item In cv_ChronItemList.Where(Function(fp_chronItem) fp_chronItem.IsQueued And fp_chronItem.IsOnTime(lv_Time))
                    lv_item.SubmitSTOrder()
                Next
            End If
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@STTimer_Tick >>> " + ex.Message)
        End Try
    End Sub

    Private Sub cv_STIEvents_OnSTITradeUpdateXML(ByRef bstrTrade As String) Handles cv_STIEvents.OnSTITradeUpdateXML
        Try
            Dim lv_sr As New StringReader(bstrTrade)
            Dim lv_xs As XmlSerializer = New XmlSerializer(GetType(structSTITradeUpdate))
            Dim lv_STITradeUpdate As structSTITradeUpdate = lv_xs.Deserialize(lv_sr)

            cv_Logger.LogSTTrade(cv_STServerTime, lv_STITradeUpdate)
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@cv_STIEvents_OnSTITradeUpdateXML >>> " + ex.Message)
        End Try
    End Sub

    Private Sub cv_STIEvents_OnSTIOrderRejectXML(ByRef bstrOrder As String) Handles cv_STIEvents.OnSTIOrderRejectXML
        Try
            Dim lv_sr As New StringReader(bstrOrder)
            Dim lv_xs As XmlSerializer = New XmlSerializer(GetType(structSTIOrderReject))
            Dim lv_STIOrderReject As structSTIOrderReject = lv_xs.Deserialize(lv_sr)

            cv_Logger.LogSTError(cv_STServerTime, lv_STIOrderReject)
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@cv_STIEvents_OnSTIOrderRejectXML >>> " + ex.Message)
        End Try
    End Sub

    Private Sub AddQueueButton_Click(sender As Object, e As EventArgs) Handles AddQueueButton.Click
        Try
            If (QuantityInput.Value > 0 And SymbolInput.Text <> "") Then
                BindChronItemGrid.Add(
                    New ChronItem(
                        TimeInput.Value.ToString("HH:mm:ss"),
                        SymbolInput.Text.ToUpper,
                        SideInput.SelectedValue,
                        Int(QuantityInput.Value),
                        DestinationInput.SelectedValue,
                        AccountInput.SelectedValue
                    )
                )

                cv_Logger.LogInfoActivity("Added item to queue.")
            End If
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@AddQueueButton_Click >>> " + ex.Message)
        End Try
    End Sub

    Private Sub ChronItemGrid_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles ChronItemGrid.UserDeletingRow
        e.Cancel = (MessageBox.Show("Deleted items cannot be restored. Continue?", "Deleting Items", MessageBoxButtons.YesNo) = DialogResult.No)
    End Sub

    Private Sub ChronItemGrid_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ChronItemGrid.UserDeletedRow
        cv_Logger.LogInfoActivity("Deleted item from queue.")
    End Sub

    Private Sub SaveChronListMenu_Click(sender As Object, e As EventArgs) Handles SaveChronListMenu.Click
        If cv_ChronItemList.Count = 0 Then
            MsgBox("Nothing to save.")
        Else
            Dim lv_DialogResult As DialogResult = SaveFileChronList.ShowDialog()
            If lv_DialogResult = DialogResult.OK Then
                SaveList(SaveFileChronList.FileName)
            End If
        End If
    End Sub

    Private Sub LoadChronListMenu_Click(sender As Object, e As EventArgs) Handles LoadChronListMenu.Click
        Dim lv_DialogResult As DialogResult = OpenFileChronList.ShowDialog()
        If lv_DialogResult = DialogResult.OK Then
            LoadList(OpenFileChronList.FileName)
        End If
    End Sub

    Private Sub ClearChronListMenu_Click(sender As Object, e As EventArgs) Handles ClearChronListMenu.Click
        If cv_ChronItemList.Count = 0 Then
            MsgBox("List is already cleared.")
        Else
            If (MessageBox.Show("Clearing the list cannot be undone. Continue?", "Clearing List", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                cv_ChronItemList = New List(Of ChronItem)
                BindChronItemGrid.DataSource = cv_ChronItemList
            End If
        End If
    End Sub

    Private Sub RefreshChronListMenu_Click(sender As Object, e As EventArgs) Handles RefreshChronListMenu.Click
        RefreshGrid(ChronItemGrid)
        MsgBox("List refreshed.")
    End Sub

    Private Sub ChronItemGrid_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ChronItemGrid.ColumnHeaderMouseClick
        Dim lv_OriginalSortOrder As SortOrder = ChronItemGrid.Columns.Item(e.ColumnIndex).HeaderCell.SortGlyphDirection
        Dim lv_NewSortOrder As SortOrder = SortOrder.Ascending

        For Each lv_Column As DataGridViewColumn In ChronItemGrid.Columns
            lv_Column.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        If lv_OriginalSortOrder <> SortOrder.Descending Then
            lv_NewSortOrder = SortOrder.Descending
        Else
            lv_NewSortOrder = SortOrder.Ascending
        End If
        ChronItemGrid.Columns.Item(e.ColumnIndex).HeaderCell.SortGlyphDirection = lv_NewSortOrder

        If lv_NewSortOrder <> SortOrder.Descending Then
            If e.ColumnIndex = 0 Then
                cv_ChronItemList.Sort(Function(x, y) x.Status.CompareTo(y.Status))
            ElseIf e.ColumnIndex = 1 Then
                cv_ChronItemList.Sort(Function(x, y) x.Time.CompareTo(y.Time))
            ElseIf e.ColumnIndex = 2 Then
                cv_ChronItemList.Sort(Function(x, y) x.Symbol.CompareTo(y.Symbol))
            ElseIf e.ColumnIndex = 3 Then
                cv_ChronItemList.Sort(Function(x, y) x.Side.CompareTo(y.Side))
            ElseIf e.ColumnIndex = 4 Then
                cv_ChronItemList.Sort(Function(x, y) x.Quantity.CompareTo(y.Quantity))
            ElseIf e.ColumnIndex = 5 Then
                cv_ChronItemList.Sort(Function(x, y) x.Destination.CompareTo(y.Destination))
            ElseIf e.ColumnIndex = 6 Then
                cv_ChronItemList.Sort(Function(x, y) x.Account.CompareTo(y.Account))
            ElseIf e.ColumnIndex = 7 Then
                cv_ChronItemList.Sort(Function(x, y) x.OrderResponse.CompareTo(y.OrderResponse))
            End If
        Else
            If e.ColumnIndex = 0 Then
                cv_ChronItemList.Sort(Function(y, x) x.Status.CompareTo(y.Status))
            ElseIf e.ColumnIndex = 1 Then
                cv_ChronItemList.Sort(Function(y, x) x.Time.CompareTo(y.Time))
            ElseIf e.ColumnIndex = 2 Then
                cv_ChronItemList.Sort(Function(y, x) x.Symbol.CompareTo(y.Symbol))
            ElseIf e.ColumnIndex = 3 Then
                cv_ChronItemList.Sort(Function(y, x) x.Side.CompareTo(y.Side))
            ElseIf e.ColumnIndex = 4 Then
                cv_ChronItemList.Sort(Function(y, x) x.Quantity.CompareTo(y.Quantity))
            ElseIf e.ColumnIndex = 5 Then
                cv_ChronItemList.Sort(Function(y, x) x.Destination.CompareTo(y.Destination))
            ElseIf e.ColumnIndex = 6 Then
                cv_ChronItemList.Sort(Function(y, x) x.Account.CompareTo(y.Account))
            ElseIf e.ColumnIndex = 7 Then
                cv_ChronItemList.Sort(Function(y, x) x.OrderResponse.CompareTo(y.OrderResponse))
            End If
        End If

        RefreshGrid(ChronItemGrid)
    End Sub

    Private Sub ChronItemGrid_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ChronItemGrid.DataError
        MsgBox("Invalid value.")
    End Sub

    Private Sub BindChronItemGrid_ListChanged(sender As Object, e As ListChangedEventArgs) Handles BindChronItemGrid.ListChanged
        RecountChronStats()
    End Sub

    Private Sub BindSTTradeGrid_ListChanged(sender As Object, e As ListChangedEventArgs) Handles BindSTTradeGrid.ListChanged
        RecountChronStats()
    End Sub

    Private Sub BindSTErrorGrid_ListChanged(sender As Object, e As ListChangedEventArgs) Handles BindSTErrorGrid.ListChanged
        RecountChronStats()
    End Sub

    Private Sub cv_STIEvents_OnSTIShutdown() Handles cv_STIEvents.OnSTIShutdown
        If cv_ChronItemList.Count > 0 Then
            SaveList(AUTOSAVE_FILE)
        End If
        MsgBox("Sterling Trader Pro no longer detected.")
        Environment.Exit(0)
    End Sub
#End Region
End Class
