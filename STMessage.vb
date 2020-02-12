Imports SterlingLib

Public Class STMessage

#Region "Shared"
    Public Shared Sides As New Dictionary(Of String, String) From
        {
            {"B", "BUY"},
            {"C", "BUY TO COVER"},
            {"S", "SELL"},
            {"T", "SHORT"},
            {"M", "BUY-"},
            {"P", "SELL+"},
            {"E", "SSHRTEX"}
        }
#End Region

#Region "STI Codes Encoder/Interpreter"
    Public Function EncodeSide(ByVal fp_code As String) As String
        If fp_code = "BUY" Then
            Return "B"
        ElseIf fp_code = "BUY TO COVER" Then
            Return "C"
        ElseIf fp_code = "SELL" Then
            Return "S"
        ElseIf fp_code = "SSHRT" Then
            Return "T"
        ElseIf fp_code = "BUY-" Then
            Return "M"
        ElseIf fp_code = "SELL+" Then
            Return "P"
        ElseIf fp_code = "SSHRTEX" Then
            Return "E"
        Else
            Return fp_code
        End If
    End Function
    Public Function InterpretSide(ByVal fp_code As String) As String
        If fp_code = "B" Then
            Return "BUY"
        ElseIf fp_code = "C" Then
            Return "BUY TO COVER"
        ElseIf fp_code = "S" Then
            Return "SELL"
        ElseIf fp_code = "T" Then
            Return "SSHRT"
        ElseIf fp_code = "M" Then
            Return "BUY-"
        ElseIf fp_code = "P" Then
            Return "SELL+"
        ElseIf fp_code = "E" Then
            Return "SSHRTEX"
        Else
            Return fp_code
        End If
    End Function
    Public Function InterpretPriceType(ByVal fp_code As Integer) As String
        If fp_code = STIPriceTypes.ptSTIBas Then
            Return "NYSE basis order"
        ElseIf fp_code = STIPriceTypes.ptSTIClo Then
            Return "Close order"
        ElseIf fp_code = STIPriceTypes.ptSTIFunari Then
            Return "Funari"
        ElseIf fp_code = STIPriceTypes.ptSTILast Then
            Return "Last"
        ElseIf fp_code = STIPriceTypes.ptSTILmt Then
            Return "Limit"
        ElseIf fp_code = STIPriceTypes.ptSTILmtClo Then
            Return "Limit on close"
        ElseIf fp_code = STIPriceTypes.ptSTILmtOb Then
            Return "Limit or better"
        ElseIf fp_code = STIPriceTypes.ptSTILmtStp Then
            Return "Stop order"
        ElseIf fp_code = STIPriceTypes.ptSTILmtStpLmt Then
            Return "Stop limit order"
        ElseIf fp_code = STIPriceTypes.ptSTILmtWow Then
            Return "Limit without waiting"
        ElseIf fp_code = STIPriceTypes.ptSTIMkt Then
            Return "Market order"
        ElseIf fp_code = STIPriceTypes.ptSTIMktClo Then
            Return "Market on close order"
        ElseIf fp_code = STIPriceTypes.ptSTIMktOb Then
            Return "Market or better"
        ElseIf fp_code = STIPriceTypes.ptSTIMktWow Then
            Return "Market without waiting"
        ElseIf fp_code = STIPriceTypes.ptSTIPegged Then
            Return "Peg order"
        ElseIf fp_code = STIPriceTypes.ptSTISvrStp Then
            Return "Server side stop order"
        ElseIf fp_code = STIPriceTypes.ptSTISvrStpLmt Then
            Return "Server side stop limit order"
        ElseIf fp_code = STIPriceTypes.ptSTITrailStp Then
            Return "Trailing stop order"
        ElseIf fp_code = STIPriceTypes.ptSTIUnknown Then
            Return "Unknown"
        ElseIf fp_code = STIPriceTypes.ptSTIWow Then
            Return "Without waiting"
        Else
            Return fp_code.ToString
        End If
    End Function
    Public Function InterpretTif(ByVal fp_code As String) As String
        If fp_code = "D" Then
            Return "DAY"
        ElseIf fp_code = "G" Then
            Return "D"
        ElseIf fp_code = "X" Then
            Return "GTX"
        ElseIf fp_code = "F" Then
            Return "FOK"
        ElseIf fp_code = "I" Then
            Return "IOC"
        ElseIf fp_code = "O" Then
            Return "OPG"
        ElseIf fp_code = "E" Then
            Return "EXT"
        ElseIf fp_code = "1" Then
            Return "OS"
        ElseIf fp_code = "A" Then
            Return "AEX"
        ElseIf fp_code = "N" Then
            Return "NOW"
        Else
            Return fp_code
        End If
    End Function
    Public Function InterpretAction(ByVal fp_code As String) As String
        If fp_code = "A" Then
            Return "Add"
        ElseIf fp_code = "C" Then
            Return "Change"
        ElseIf fp_code = "D" Then
            Return "Delete"
        ElseIf fp_code = "S" Then
            Return "Status"
        Else
            Return fp_code
        End If
    End Function
    Public Function InterpretOrderStatus(ByVal fp_code As Integer) As String
        If fp_code = STIOrderStatus.osSTIAcceptedForBidding Then
            Return "Accepted For Bidding"
        ElseIf fp_code = STIOrderStatus.osSTIAdjusted Then
            Return "Adjusted"
        ElseIf fp_code = STIOrderStatus.osSTICalculated Then
            Return "Calculated"
        ElseIf fp_code = STIOrderStatus.osSTICanceled Then
            Return "Canceled"
        ElseIf fp_code = STIOrderStatus.osSTIDoneForDay Then
            Return "Done For Day"
        ElseIf fp_code = STIOrderStatus.osSTIExpired Then
            Return "Expired"
        ElseIf fp_code = STIOrderStatus.osSTIFilled Then
            Return "Filled"
        ElseIf fp_code = STIOrderStatus.osSTINew Then
            Return "New"
        ElseIf fp_code = STIOrderStatus.osSTIPartiallyFilled Then
            Return "Partially Filled"
        ElseIf fp_code = STIOrderStatus.osSTIPendingCancel Then
            Return "Pending Cancel"
        ElseIf fp_code = STIOrderStatus.osSTIPendingNew Then
            Return "Pending New"
        ElseIf fp_code = STIOrderStatus.osSTIPendingReplace Then
            Return "Pending Replace"
        ElseIf fp_code = STIOrderStatus.osSTIRejected Then
            Return "Backend Rejection/Exchange Reject"
        ElseIf fp_code = STIOrderStatus.osSTIReplaced Then
            Return "Replaced"
        ElseIf fp_code = STIOrderStatus.osSTIStatused Then
            Return "Statused"
        ElseIf fp_code = STIOrderStatus.osSTIStopped Then
            Return "Stopped"
        ElseIf fp_code = STIOrderStatus.osSTISuspended Then
            Return "Suspended"
        ElseIf fp_code = STIOrderStatus.osSTIUnknown Then
            Return "Unknown"
        Else
            Return fp_code.ToString
        End If
    End Function
    Public Function InterpretOrderErrorCode(ByVal fp_code As Integer) As String
        If fp_code = 0 Then
            Return "No Errors"
        ElseIf fp_code = -1 Then
            Return "Invalid Account"
        ElseIf fp_code = -2 Then
            Return "Invalid Side"
        ElseIf fp_code = -3 Then
            Return "Invalid Quantity"
        ElseIf fp_code = -4 Then
            Return "Invalid Symbol"
        ElseIf fp_code = -5 Then
            Return "Invalid Price Type"
        ElseIf fp_code = -6 Then
            Return "Invalid TIF"
        ElseIf fp_code = -7 Then
            Return "Invalid Destination"
        ElseIf fp_code = -8 Then
            Return "Exposure Limit Violation"
        ElseIf fp_code = -9 Then
            Return "NYSE+ Rules Violation"
        ElseIf fp_code = -10 Then
            Return "NYSE+ 30-Second Violation"
        ElseIf fp_code = -11 Then
            Return "Disable Select Net Short Sales"
        ElseIf fp_code = -12 Then
            Return "Long Sale Position Rules Violation"
        ElseIf fp_code = -13 Then
            Return "Short Sale Position Rules Violation"
        ElseIf fp_code = -14 Then
            Return "GTC Orders Not Enabled"
        ElseIf fp_code = -15 Then
            Return "ActiveX API Not Enabled"
        ElseIf fp_code = -16 Then
            Return "Sterling Trader Pro is Offline"
        ElseIf fp_code = -17 Then
            Return "Security Not Marked as Located"
        ElseIf fp_code = -18 Then
            Return "Order Size Violation"
        ElseIf fp_code = -19 Then
            Return "Position Limit Violation"
        ElseIf fp_code = -20 Then
            Return "Buying Power/Margin Control Violation"
        ElseIf fp_code = -21 Then
            Return "P/L Control Violation"
        ElseIf fp_code = -22 Then
            Return "Account Not Enabled for this Product"
        ElseIf fp_code = -23 Then
            Return "Trader Not Enabled for Futures"
        ElseIf fp_code = -24 Then
            Return "Minimum Balance Violation"
        ElseIf fp_code = -25 Then
            Return "Trader Not Enabled for odd lots"
        ElseIf fp_code = -26 Then
            Return "Order dollar limit exceeded"
        ElseIf fp_code = -27 Then
            Return "Trader Not Enabled for Options"
        ElseIf fp_code = -28 Then
            Return "Soft share limit exceeded"
        ElseIf fp_code = -29 Then
            Return "Loss from max profit control violation"
        ElseIf fp_code = -30 Then
            Return "Desk quantity enforcement violation"
        ElseIf fp_code = -31 Then
            Return "Account not enabled for Sell to Open"
        ElseIf fp_code = -32 Then
            Return "Account allowed to 'Close/Cxl' only"
        ElseIf fp_code = -33 Then
            Return "Trader not enabled for security locating"
        ElseIf fp_code = -34 Then
            Return "Order not able to be replaced"
        ElseIf fp_code = -35 Then
            Return "Trader not enabled for 'Buy to Cover'"
        ElseIf fp_code = -36 Then
            Return "Invalid maturity date"
        ElseIf fp_code = -37 Then
            Return "Only one cancel and/or replace allowed per order per second"
        ElseIf fp_code = -38 Then
            Return "Account's maximum position value for this symbol exceeded"
        ElseIf fp_code = -39 Then
            Return "Symbol violates the account's min/max price settings"
        ElseIf fp_code = -40 Then
            Return "Quote Unavailable to calculate Order dollar limit"
        ElseIf fp_code = -41 Then
            Return "Quote Unavailable to calculate Maximum Position Cost"
        ElseIf fp_code = -42 Then
            Return "Quote Unavailable to calculate Buying Power"
        ElseIf fp_code = -43 Then
            Return "Quote Unavailable to calculate Margin Control"
        ElseIf fp_code = -44 Then
            Return "Floating BP Violation"
        ElseIf fp_code = -45 Then
            Return "Market order would remove liquidity"
        ElseIf fp_code = -46 Then
            Return "Not enabled for Server Stop orders"
        ElseIf fp_code = -47 Then
            Return "Not enabled for Trail Stop orders"
        ElseIf fp_code = -48 Then
            Return "Order would exceed the Max Open orders per side on this symbol"
        ElseIf fp_code = -49 Then
            Return "Quote Unavailable or Compliance threshold exceeded or quote unavailable"
        ElseIf fp_code = -50 Then
            Return "Neither last nor Close price available for MKT order"
        ElseIf fp_code = -51 Then
            Return "Quote Unavailable or Does not meet min average daily volume"
        Else
            Return fp_code.ToString
        End If
    End Function
    Public Function InterpretRejectReason(ByVal fp_code As Integer) As String
        If fp_code = STIRejectReason.rrSTIAccessDenied Then
            Return "Access Denied"
        ElseIf fp_code = STIRejectReason.rrSTIBulletNotRequired Then
            Return "Bullet Not Required"
        ElseIf fp_code = STIRejectReason.rrSTIBuyingPower Then
            Return "Buying Power"
        ElseIf fp_code = STIRejectReason.rrSTICannotCreate Then
            Return "Cannot Create"
        ElseIf fp_code = STIRejectReason.rrSTICannotRoute Then
            Return "Cannot Route"
        ElseIf fp_code = STIRejectReason.rrSTIDollarLimit Then
            Return "Dollar Limit"
        ElseIf fp_code = STIRejectReason.rrSTIDupeAcct Then
            Return "Duplicate Account"
        ElseIf fp_code = STIRejectReason.rrSTIDupeClOrdId Then
            Return "Duplicate CL Order ID"
        ElseIf fp_code = STIRejectReason.rrSTIDupeLogin Then
            Return "Duplicate Login"
        ElseIf fp_code = STIRejectReason.rrSTIDupeSeqNo Then
            Return "Duplicate Sequence Number"
        ElseIf fp_code = STIRejectReason.rrSTIDupeStation Then
            Return "Duplicate Station"
        ElseIf fp_code = STIRejectReason.rrSTIError Then
            Return "Error"
        ElseIf fp_code = STIRejectReason.rrSTIHardToBorrow Then
            Return "Hard To Borrow"
        ElseIf fp_code = STIRejectReason.rrSTIInvalidAcct Then
            Return "Invalid Account"
        ElseIf fp_code = STIRejectReason.rrSTIInvalidDest Then
            Return "Invalid Destination"
        ElseIf fp_code = STIRejectReason.rrSTIInvalidGroupId Then
            Return "Invalid Group ID"
        ElseIf fp_code = STIRejectReason.rrSTIInvalidPassword Then
            Return "Invalid Password"
        ElseIf fp_code = STIRejectReason.rrSTIInvalidQty Then
            Return "Invalid Quantity"
        ElseIf fp_code = STIRejectReason.rrSTIInvalidSeqNo Then
            Return "Invalid Sequence Number"
        ElseIf fp_code = STIRejectReason.rrSTIInvalidSym Then
            Return "Invalid Sysmbol"
        ElseIf fp_code = STIRejectReason.rrSTILast Then
            Return "Last"
        ElseIf fp_code = STIRejectReason.rrSTINoChange Then
            Return "No Change"
        ElseIf fp_code = STIRejectReason.rrSTINoSeqNoAvailable Then
            Return "No Sequence Number Available"
        ElseIf fp_code = STIRejectReason.rrSTINotFound Then
            Return "Not Found"
        ElseIf fp_code = STIRejectReason.rrSTINotSupported Then
            Return "Not Supported"
        ElseIf fp_code = STIRejectReason.rrSTINxRules Then
            Return "NX Rules"
        ElseIf fp_code = STIRejectReason.rrSTIOrderClosed Then
            Return "Order Closed"
        ElseIf fp_code = STIRejectReason.rrSTIPendingCancel Then
            Return "Pending Cancel"
        ElseIf fp_code = STIRejectReason.rrSTIPendingReplace Then
            Return "Pending Replace"
        ElseIf fp_code = STIRejectReason.rrSTIPosTradingLmt Then
            Return "Position Pending Limit"
        ElseIf fp_code = STIRejectReason.rrSTIShareLimit Then
            Return "Share Limit"
        ElseIf fp_code = STIRejectReason.rrSTITenSecRule Then
            Return "Ten Seconds Rule"
        ElseIf fp_code = STIRejectReason.rrSTITltc Then
            Return "Too Late To Cancel"
        ElseIf fp_code = STIRejectReason.rrSTITltcMoc Then
            Return "Too Late To Cancel MOC"
        ElseIf fp_code = STIRejectReason.rrSTIUnknown Then
            Return "Unknow"
        ElseIf fp_code = STIRejectReason.rrSTIUnknownPid Then
            Return "Unknown PID"
        ElseIf fp_code = STIRejectReason.rrSTIVersion Then
            Return "Version"
        ElseIf fp_code = STIRejectReason.rrSTIMocMktImb Then
            Return "MOC Market Imbalance"
        ElseIf fp_code = STIRejectReason.rrSTINx30SecRule Then
            Return "NX 30 Seconds Rule"
        ElseIf fp_code = STIRejectReason.rrSTIEasyToBorrowOnly Then
            Return "Easy To Borrow Only"
        ElseIf fp_code = STIRejectReason.rrSTIStaleOrder Then
            Return "Stale Order"
        ElseIf fp_code = STIRejectReason.rrSTIMaxFailedLogins Then
            Return "Max Failed Logins"
        ElseIf fp_code = STIRejectReason.rrSTICritical Then
            Return "Critical"
        Else
            Return fp_code.ToString
        End If
    End Function
#End Region

End Class
