Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports SterlingLib

Public Class MainForm

#Region "Class Variables"
    Private cv_STIApp As STIApp
    Private WithEvents cv_STIEvents As STIEvents
    Private cv_STIAcctMaint As STIAcctMaint

    Private cv_STServerTime As String = ""
    Private cv_TraderName As String = ""
    Private cv_AccountList As String() = Nothing
    Private cv_DestinationList As String() = Nothing

    Private cv_IsPulseRunning As Boolean = False

    Private cv_Logger As Logger
    Private WithEvents cv_ChronItemList As BindingList(Of ChronItem)
#End Region

    Private Delegate Sub DelegateRefreshDataGridView(ByRef dp_DataGridView As DataGridView)
    Private Sub RefreshDataGridView(ByRef sp_DataGridView As DataGridView)
        If (sp_DataGridView.InvokeRequired) Then
            Me.Invoke(New DelegateRefreshDataGridView(AddressOf RefreshDataGridView), sp_DataGridView)
        Else
            sp_DataGridView.Refresh()
            InQueueItemsLabel.Text = cv_ChronItemList.Count
            ProcessedItemsLabel.Text = cv_ChronItemList.Where(Function(fp_chronItem) fp_chronItem.IsProcessed).Count
            FailedItemsLabel.Text = cv_ChronItemList.Where(Function(fp_chronItem) fp_chronItem.IsFailed).Count
        End If
    End Sub

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

            cv_Logger = New Logger(cv_STServerTime) 'Timer should start before instantiating logger
            cv_ChronItemList = New BindingList(Of ChronItem)

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
        Catch ex As Exception
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
                    lv_item.Account,
                    lv_item.Symbol,
                    lv_item.Side,
                    lv_item.Quantity,
                    lv_item.Destination
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

    Private Sub LoadList(ByVal sp_File As String)
        Try
            If My.Computer.FileSystem.FileExists(sp_File) Then
                Dim lv_SerializableChronList As New List(Of SerializableChronItem)

                Dim fs As Stream = New FileStream(sp_File, FileMode.Open)
                Dim bf As BinaryFormatter = New BinaryFormatter()
                lv_SerializableChronList = bf.Deserialize(fs)
                fs.Close()

                cv_ChronItemList = New BindingList(Of ChronItem)
                BindChronItemGrid.DataSource = cv_ChronItemList

                For Each lv_item In lv_SerializableChronList
                    cv_ChronItemList.Add(New ChronItem(
                        lv_item.Time,
                        lv_item.Account,
                        lv_item.Symbol,
                        lv_item.Side,
                        lv_item.Quantity,
                        lv_item.Destination
                    ))
                Next

                cv_Logger.LogInfoActivity("Loaded queue list from: " + sp_File)
            Else
                cv_Logger.LogErrorActivity(sp_File + " does not exist.")
            End If
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@LoadList >>> " + ex.Message)
        End Try
    End Sub

#Region "Events"
    Private Sub cv_STIEvents_OnSTITradeUpdateXML(ByRef bstrTrade As String) Handles cv_STIEvents.OnSTITradeUpdateXML
        Try
            Dim lv_sr As New StringReader(bstrTrade)
            Dim lv_xs As XmlSerializer = New XmlSerializer(GetType(structSTITradeUpdate))
            Dim lv_STITradeUpdate As structSTITradeUpdate = lv_xs.Deserialize(lv_sr)

            cv_Logger.LogSTTrade(lv_STITradeUpdate)
            RefreshDataGridView(ChronItemGrid)
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@cv_STIEvents_OnSTITradeUpdateXML >>> " + ex.Message)
        End Try
    End Sub

    Private Sub cv_STIEvents_OnSTIOrderRejectXML(ByRef bstrOrder As String) Handles cv_STIEvents.OnSTIOrderRejectXML
        Try
            Dim lv_sr As New StringReader(bstrOrder)
            Dim lv_xs As XmlSerializer = New XmlSerializer(GetType(structSTIOrderReject))
            Dim lv_STIOrderReject As structSTIOrderReject = lv_xs.Deserialize(lv_sr)

            cv_Logger.LogSTError(lv_STIOrderReject)
            RefreshDataGridView(ChronItemGrid)
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@cv_STIEvents_OnSTIOrderRejectXML >>> " + ex.Message)
        End Try
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
                RefreshDataGridView(ChronItemGrid)
            End If
        Catch ex As Exception
            cv_Logger.LogErrorActivity("@STTimer_Tick >>> " + ex.Message)
        End Try
    End Sub

    Private Sub AddQueueButton_Click(sender As Object, e As EventArgs) Handles AddQueueButton.Click
        Try
            If (QuantityInput.Value > 0) Then
                BindChronItemGrid.Add(
                    New ChronItem(
                        TimeInput.Value.ToString("HH:mm:ss"),
                        AccountInput.SelectedValue,
                        SymbolInput.Text,
                        SideInput.SelectedValue,
                        Int(QuantityInput.Value),
                        DestinationInput.SelectedValue
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

    Private Sub cv_ChronItemList_ListChanged(sender As Object, e As ListChangedEventArgs) Handles cv_ChronItemList.ListChanged
        InQueueItemsLabel.Text = cv_ChronItemList.Count
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
                cv_ChronItemList = New BindingList(Of ChronItem)
                BindChronItemGrid.DataSource = cv_ChronItemList
            End If
        End If
    End Sub

    Private Sub RefreshChronListMenu_Click(sender As Object, e As EventArgs) Handles RefreshChronListMenu.Click
        RefreshDataGridView(ChronItemGrid)
        MsgBox("List refreshed.")
    End Sub

    Private Sub PulseSwitchMenu_Click(sender As Object, e As EventArgs) Handles PulseSwitchMenu.Click
        cv_IsPulseRunning = Not cv_IsPulseRunning
        If cv_IsPulseRunning Then
            PulseSwitchMenu.BackColor = Color.Green
            PulseSwitchMenu.Text = "Running"

            PulseStatusLabel.ForeColor = Color.Green
            PulseStatusLabel.Text = "RUNNING"
        Else
            PulseSwitchMenu.BackColor = Color.Red
            PulseSwitchMenu.Text = "Paused"

            PulseStatusLabel.ForeColor = Color.Red
            PulseStatusLabel.Text = "PAUSED"
        End If
    End Sub
#End Region
End Class
