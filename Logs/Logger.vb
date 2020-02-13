Imports System.ComponentModel
Imports SterlingLib

Public Class Logger

    Private cv_ActivityList As BindingList(Of ActivityLog)
    Private cv_STTradeList As BindingList(Of STTradeLog)
    Private cv_STErroList As BindingList(Of STErrorLog)

    Public Property ActivityList() As BindingList(Of ActivityLog)
        Get
            Return cv_ActivityList
        End Get
        Set(ByVal value As BindingList(Of ActivityLog))
            cv_ActivityList = value
        End Set
    End Property
    Public Property STTradeList() As BindingList(Of STTradeLog)
        Get
            Return cv_STTradeList
        End Get
        Set(ByVal value As BindingList(Of STTradeLog))
            cv_STTradeList = value
        End Set
    End Property
    Public Property STErrorList() As BindingList(Of STErrorLog)
        Get
            Return cv_STErroList
        End Get
        Set(ByVal value As BindingList(Of STErrorLog))
            cv_STErroList = value
        End Set
    End Property

    Public Sub New()
        cv_ActivityList = New BindingList(Of ActivityLog)
        cv_STTradeList = New BindingList(Of STTradeLog)
        cv_STErroList = New BindingList(Of STErrorLog)
    End Sub

    Public Sub LogInfoActivity(ByVal sp_Details As String)
        If (cv_ActivityList.Count = 0) Then
            cv_ActivityList.Add(New ActivityLog("INFO", sp_Details))
        Else
            cv_ActivityList.Insert(0, New ActivityLog("INFO", sp_Details))
        End If
    End Sub
    Public Sub LogErrorActivity(ByVal sp_Details As String)
        If (cv_ActivityList.Count = 0) Then
            cv_ActivityList.Add(New ActivityLog("ERROR", sp_Details))
        Else
            cv_ActivityList.Insert(0, New ActivityLog("ERROR", sp_Details))
        End If

        FileLogger.LogError(sp_Details)
    End Sub

    Public Sub LogSTTrade(ByVal sp_ServerTime As String, ByVal sp_Trade As structSTITradeUpdate)
        Try
            If (cv_STTradeList.Count = 0) Then
                cv_STTradeList.Add(New STTradeLog(sp_ServerTime, sp_Trade))
            Else
                cv_STTradeList.Insert(0, New STTradeLog(sp_ServerTime, sp_Trade))
            End If
        Catch ex As Exception
            LogErrorActivity("@LogSTTrade >>> " + ex.Message)
        End Try
    End Sub
    Public Sub LogSTError(ByVal sp_ServerTime As String, ByVal sp_Error As structSTIOrderReject)
        Try
            If (cv_STErroList.Count = 0) Then
                cv_STErroList.Add(New STErrorLog(sp_ServerTime, sp_Error))
            Else
                cv_STErroList.Insert(0, New STErrorLog(sp_ServerTime, sp_Error))
            End If
        Catch ex As Exception
            LogErrorActivity("@LogSTError >>> " + ex.Message)
        End Try
    End Sub
End Class
