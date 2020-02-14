<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.ControlTabPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PulseSwitchButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FailedItemsLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProcessedItemsLabel = New System.Windows.Forms.Label()
        Me.InQueueItemsLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LoginTraderLabel = New System.Windows.Forms.Label()
        Me.STAPIEnabledLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PulseStatusLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddQueueButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeInput = New System.Windows.Forms.DateTimePicker()
        Me.AccountInput = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SymbolInput = New System.Windows.Forms.TextBox()
        Me.SideInput = New System.Windows.Forms.ComboBox()
        Me.QuantityInput = New System.Windows.Forms.NumericUpDown()
        Me.DestinationInput = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ServerTimeLabel = New System.Windows.Forms.Label()
        Me.ChronItemGrid = New System.Windows.Forms.DataGridView()
        Me.ChronGridMenu = New System.Windows.Forms.MenuStrip()
        Me.SaveChronListMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadChronListMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearChronListMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshChronListMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsTabPage = New System.Windows.Forms.TabPage()
        Me.LogsTabControl = New System.Windows.Forms.TabControl()
        Me.ActivityTabPage = New System.Windows.Forms.TabPage()
        Me.ActivityLogGrid = New System.Windows.Forms.DataGridView()
        Me.STTradeTabPage = New System.Windows.Forms.TabPage()
        Me.STTradeGrid = New System.Windows.Forms.DataGridView()
        Me.STErrorTabPage = New System.Windows.Forms.TabPage()
        Me.STErrorGrid = New System.Windows.Forms.DataGridView()
        Me.STTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BindActivityGrid = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindSTTradeGrid = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindSTErrorGrid = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindChronItemGrid = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileChronList = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileChronList = New System.Windows.Forms.SaveFileDialog()
        Me.MainTabControl.SuspendLayout()
        Me.ControlTabPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.QuantityInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ChronItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChronGridMenu.SuspendLayout()
        Me.LogsTabPage.SuspendLayout()
        Me.LogsTabControl.SuspendLayout()
        Me.ActivityTabPage.SuspendLayout()
        CType(Me.ActivityLogGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STTradeTabPage.SuspendLayout()
        CType(Me.STTradeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STErrorTabPage.SuspendLayout()
        CType(Me.STErrorGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindActivityGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindSTTradeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindSTErrorGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindChronItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.ControlTabPage)
        Me.MainTabControl.Controls.Add(Me.LogsTabPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(2, 2)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(980, 657)
        Me.MainTabControl.TabIndex = 0
        Me.MainTabControl.TabStop = False
        '
        'ControlTabPage
        '
        Me.ControlTabPage.Controls.Add(Me.SplitContainer1)
        Me.ControlTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ControlTabPage.Name = "ControlTabPage"
        Me.ControlTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ControlTabPage.Size = New System.Drawing.Size(972, 631)
        Me.ControlTabPage.TabIndex = 0
        Me.ControlTabPage.Text = "Control"
        Me.ControlTabPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PulseSwitchButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChronItemGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChronGridMenu)
        Me.SplitContainer1.Size = New System.Drawing.Size(966, 625)
        Me.SplitContainer1.SplitterDistance = 255
        Me.SplitContainer1.TabIndex = 0
        '
        'PulseSwitchButton
        '
        Me.PulseSwitchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseSwitchButton.Location = New System.Drawing.Point(8, 10)
        Me.PulseSwitchButton.Name = "PulseSwitchButton"
        Me.PulseSwitchButton.Size = New System.Drawing.Size(240, 23)
        Me.PulseSwitchButton.TabIndex = 0
        Me.PulseSwitchButton.TabStop = False
        Me.PulseSwitchButton.Text = "TURN ON"
        Me.PulseSwitchButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 240)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.FailedItemsLabel, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ProcessedItemsLabel, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.InQueueItemsLabel, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LoginTraderLabel, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.STAPIEnabledLabel, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PulseStatusLabel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(234, 221)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 35)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Failed : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FailedItemsLabel
        '
        Me.FailedItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FailedItemsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FailedItemsLabel.ForeColor = System.Drawing.Color.Red
        Me.FailedItemsLabel.Location = New System.Drawing.Point(83, 175)
        Me.FailedItemsLabel.Name = "FailedItemsLabel"
        Me.FailedItemsLabel.Size = New System.Drawing.Size(148, 35)
        Me.FailedItemsLabel.TabIndex = 11
        Me.FailedItemsLabel.Text = "0"
        Me.FailedItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 35)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Processed : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProcessedItemsLabel
        '
        Me.ProcessedItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProcessedItemsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessedItemsLabel.ForeColor = System.Drawing.Color.Green
        Me.ProcessedItemsLabel.Location = New System.Drawing.Point(83, 140)
        Me.ProcessedItemsLabel.Name = "ProcessedItemsLabel"
        Me.ProcessedItemsLabel.Size = New System.Drawing.Size(148, 35)
        Me.ProcessedItemsLabel.TabIndex = 7
        Me.ProcessedItemsLabel.Text = "0"
        Me.ProcessedItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InQueueItemsLabel
        '
        Me.InQueueItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InQueueItemsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InQueueItemsLabel.Location = New System.Drawing.Point(83, 105)
        Me.InQueueItemsLabel.Name = "InQueueItemsLabel"
        Me.InQueueItemsLabel.Size = New System.Drawing.Size(148, 35)
        Me.InQueueItemsLabel.TabIndex = 5
        Me.InQueueItemsLabel.Text = "0"
        Me.InQueueItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 35)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "In Queue : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 35)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Login Trader : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginTraderLabel
        '
        Me.LoginTraderLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginTraderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTraderLabel.Location = New System.Drawing.Point(83, 70)
        Me.LoginTraderLabel.Name = "LoginTraderLabel"
        Me.LoginTraderLabel.Size = New System.Drawing.Size(148, 35)
        Me.LoginTraderLabel.TabIndex = 3
        Me.LoginTraderLabel.Text = "---"
        Me.LoginTraderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'STAPIEnabledLabel
        '
        Me.STAPIEnabledLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STAPIEnabledLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STAPIEnabledLabel.ForeColor = System.Drawing.Color.Red
        Me.STAPIEnabledLabel.Location = New System.Drawing.Point(83, 35)
        Me.STAPIEnabledLabel.Name = "STAPIEnabledLabel"
        Me.STAPIEnabledLabel.Size = New System.Drawing.Size(148, 35)
        Me.STAPIEnabledLabel.TabIndex = 2
        Me.STAPIEnabledLabel.Text = "FALSE"
        Me.STAPIEnabledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 35)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "API Enabled : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 35)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Pulse Status : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PulseStatusLabel
        '
        Me.PulseStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PulseStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.PulseStatusLabel.Location = New System.Drawing.Point(83, 0)
        Me.PulseStatusLabel.Name = "PulseStatusLabel"
        Me.PulseStatusLabel.Size = New System.Drawing.Size(148, 35)
        Me.PulseStatusLabel.TabIndex = 13
        Me.PulseStatusLabel.Text = "PAUSED"
        Me.PulseStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 125)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(240, 230)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AddQueueButton, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TimeInput, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AccountInput, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.SymbolInput, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SideInput, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.QuantityInput, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DestinationInput, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(232, 209)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'AddQueueButton
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.AddQueueButton, 2)
        Me.AddQueueButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddQueueButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddQueueButton.Location = New System.Drawing.Point(3, 177)
        Me.AddQueueButton.Name = "AddQueueButton"
        Me.AddQueueButton.Size = New System.Drawing.Size(226, 29)
        Me.AddQueueButton.TabIndex = 7
        Me.AddQueueButton.Text = "Add to Queue"
        Me.AddQueueButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimeInput
        '
        Me.TimeInput.CustomFormat = "HH:mm:ss"
        Me.TimeInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeInput.Location = New System.Drawing.Point(88, 3)
        Me.TimeInput.Name = "TimeInput"
        Me.TimeInput.ShowUpDown = True
        Me.TimeInput.Size = New System.Drawing.Size(141, 22)
        Me.TimeInput.TabIndex = 1
        Me.TimeInput.Value = New Date(2020, 2, 2, 0, 0, 0, 0)
        '
        'AccountInput
        '
        Me.AccountInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccountInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountInput.FormattingEnabled = True
        Me.AccountInput.Location = New System.Drawing.Point(88, 148)
        Me.AccountInput.Name = "AccountInput"
        Me.AccountInput.Size = New System.Drawing.Size(141, 24)
        Me.AccountInput.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Symbol"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Side"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Destination"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Account"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SymbolInput
        '
        Me.SymbolInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SymbolInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SymbolInput.Location = New System.Drawing.Point(88, 32)
        Me.SymbolInput.Name = "SymbolInput"
        Me.SymbolInput.Size = New System.Drawing.Size(141, 22)
        Me.SymbolInput.TabIndex = 2
        '
        'SideInput
        '
        Me.SideInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SideInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SideInput.FormattingEnabled = True
        Me.SideInput.Location = New System.Drawing.Point(88, 61)
        Me.SideInput.Name = "SideInput"
        Me.SideInput.Size = New System.Drawing.Size(141, 24)
        Me.SideInput.TabIndex = 3
        '
        'QuantityInput
        '
        Me.QuantityInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuantityInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityInput.Location = New System.Drawing.Point(88, 90)
        Me.QuantityInput.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.QuantityInput.Name = "QuantityInput"
        Me.QuantityInput.Size = New System.Drawing.Size(141, 22)
        Me.QuantityInput.TabIndex = 4
        '
        'DestinationInput
        '
        Me.DestinationInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DestinationInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinationInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationInput.FormattingEnabled = True
        Me.DestinationInput.Location = New System.Drawing.Point(88, 119)
        Me.DestinationInput.Name = "DestinationInput"
        Me.DestinationInput.Size = New System.Drawing.Size(141, 24)
        Me.DestinationInput.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ServerTimeLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(240, 80)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Server Time"
        '
        'ServerTimeLabel
        '
        Me.ServerTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServerTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerTimeLabel.ForeColor = System.Drawing.Color.Green
        Me.ServerTimeLabel.Location = New System.Drawing.Point(2, 15)
        Me.ServerTimeLabel.Name = "ServerTimeLabel"
        Me.ServerTimeLabel.Size = New System.Drawing.Size(236, 63)
        Me.ServerTimeLabel.TabIndex = 0
        Me.ServerTimeLabel.Text = "00:00:00"
        Me.ServerTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChronItemGrid
        '
        Me.ChronItemGrid.AllowUserToAddRows = False
        Me.ChronItemGrid.AllowUserToResizeColumns = False
        Me.ChronItemGrid.AllowUserToResizeRows = False
        Me.ChronItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ChronItemGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChronItemGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ChronItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ChronItemGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.ChronItemGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChronItemGrid.EnableHeadersVisualStyles = False
        Me.ChronItemGrid.Location = New System.Drawing.Point(0, 24)
        Me.ChronItemGrid.MultiSelect = False
        Me.ChronItemGrid.Name = "ChronItemGrid"
        Me.ChronItemGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChronItemGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ChronItemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.ChronItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ChronItemGrid.Size = New System.Drawing.Size(707, 601)
        Me.ChronItemGrid.TabIndex = 0
        Me.ChronItemGrid.TabStop = False
        '
        'ChronGridMenu
        '
        Me.ChronGridMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveChronListMenu, Me.LoadChronListMenu, Me.ClearChronListMenu, Me.RefreshChronListMenu})
        Me.ChronGridMenu.Location = New System.Drawing.Point(0, 0)
        Me.ChronGridMenu.Name = "ChronGridMenu"
        Me.ChronGridMenu.Size = New System.Drawing.Size(707, 24)
        Me.ChronGridMenu.TabIndex = 1
        Me.ChronGridMenu.Text = "MenuStrip1"
        '
        'SaveChronListMenu
        '
        Me.SaveChronListMenu.Name = "SaveChronListMenu"
        Me.SaveChronListMenu.Size = New System.Drawing.Size(64, 20)
        Me.SaveChronListMenu.Text = "Save List"
        '
        'LoadChronListMenu
        '
        Me.LoadChronListMenu.Name = "LoadChronListMenu"
        Me.LoadChronListMenu.Size = New System.Drawing.Size(66, 20)
        Me.LoadChronListMenu.Text = "Load List"
        '
        'ClearChronListMenu
        '
        Me.ClearChronListMenu.Name = "ClearChronListMenu"
        Me.ClearChronListMenu.Size = New System.Drawing.Size(67, 20)
        Me.ClearChronListMenu.Text = "Clear List"
        '
        'RefreshChronListMenu
        '
        Me.RefreshChronListMenu.Name = "RefreshChronListMenu"
        Me.RefreshChronListMenu.Size = New System.Drawing.Size(58, 20)
        Me.RefreshChronListMenu.Text = "Refresh"
        '
        'LogsTabPage
        '
        Me.LogsTabPage.Controls.Add(Me.LogsTabControl)
        Me.LogsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.LogsTabPage.Name = "LogsTabPage"
        Me.LogsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LogsTabPage.Size = New System.Drawing.Size(972, 631)
        Me.LogsTabPage.TabIndex = 1
        Me.LogsTabPage.Text = "Logs"
        Me.LogsTabPage.UseVisualStyleBackColor = True
        '
        'LogsTabControl
        '
        Me.LogsTabControl.Controls.Add(Me.ActivityTabPage)
        Me.LogsTabControl.Controls.Add(Me.STTradeTabPage)
        Me.LogsTabControl.Controls.Add(Me.STErrorTabPage)
        Me.LogsTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogsTabControl.Location = New System.Drawing.Point(3, 3)
        Me.LogsTabControl.Name = "LogsTabControl"
        Me.LogsTabControl.SelectedIndex = 0
        Me.LogsTabControl.Size = New System.Drawing.Size(966, 625)
        Me.LogsTabControl.TabIndex = 0
        '
        'ActivityTabPage
        '
        Me.ActivityTabPage.Controls.Add(Me.ActivityLogGrid)
        Me.ActivityTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ActivityTabPage.Name = "ActivityTabPage"
        Me.ActivityTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ActivityTabPage.Size = New System.Drawing.Size(958, 599)
        Me.ActivityTabPage.TabIndex = 0
        Me.ActivityTabPage.Text = "Activities"
        Me.ActivityTabPage.UseVisualStyleBackColor = True
        '
        'ActivityLogGrid
        '
        Me.ActivityLogGrid.AllowUserToAddRows = False
        Me.ActivityLogGrid.AllowUserToDeleteRows = False
        Me.ActivityLogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ActivityLogGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ActivityLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActivityLogGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivityLogGrid.Location = New System.Drawing.Point(3, 3)
        Me.ActivityLogGrid.Name = "ActivityLogGrid"
        Me.ActivityLogGrid.ReadOnly = True
        Me.ActivityLogGrid.RowHeadersVisible = False
        Me.ActivityLogGrid.Size = New System.Drawing.Size(952, 593)
        Me.ActivityLogGrid.TabIndex = 0
        Me.ActivityLogGrid.TabStop = False
        '
        'STTradeTabPage
        '
        Me.STTradeTabPage.Controls.Add(Me.STTradeGrid)
        Me.STTradeTabPage.Location = New System.Drawing.Point(4, 22)
        Me.STTradeTabPage.Name = "STTradeTabPage"
        Me.STTradeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.STTradeTabPage.Size = New System.Drawing.Size(958, 599)
        Me.STTradeTabPage.TabIndex = 1
        Me.STTradeTabPage.Text = "Sterling Trades"
        Me.STTradeTabPage.UseVisualStyleBackColor = True
        '
        'STTradeGrid
        '
        Me.STTradeGrid.AllowUserToAddRows = False
        Me.STTradeGrid.AllowUserToDeleteRows = False
        Me.STTradeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.STTradeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.STTradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STTradeGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STTradeGrid.Location = New System.Drawing.Point(3, 3)
        Me.STTradeGrid.Name = "STTradeGrid"
        Me.STTradeGrid.ReadOnly = True
        Me.STTradeGrid.RowHeadersVisible = False
        Me.STTradeGrid.Size = New System.Drawing.Size(952, 593)
        Me.STTradeGrid.TabIndex = 0
        Me.STTradeGrid.TabStop = False
        '
        'STErrorTabPage
        '
        Me.STErrorTabPage.Controls.Add(Me.STErrorGrid)
        Me.STErrorTabPage.Location = New System.Drawing.Point(4, 22)
        Me.STErrorTabPage.Name = "STErrorTabPage"
        Me.STErrorTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.STErrorTabPage.Size = New System.Drawing.Size(958, 599)
        Me.STErrorTabPage.TabIndex = 2
        Me.STErrorTabPage.Text = "Sterling Errors"
        Me.STErrorTabPage.UseVisualStyleBackColor = True
        '
        'STErrorGrid
        '
        Me.STErrorGrid.AllowUserToAddRows = False
        Me.STErrorGrid.AllowUserToDeleteRows = False
        Me.STErrorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.STErrorGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.STErrorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STErrorGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STErrorGrid.Location = New System.Drawing.Point(3, 3)
        Me.STErrorGrid.Name = "STErrorGrid"
        Me.STErrorGrid.ReadOnly = True
        Me.STErrorGrid.RowHeadersVisible = False
        Me.STErrorGrid.Size = New System.Drawing.Size(952, 593)
        Me.STErrorGrid.TabIndex = 0
        Me.STErrorGrid.TabStop = False
        '
        'STTimer
        '
        '
        'BindChronItemGrid
        '
        '
        'OpenFileChronList
        '
        Me.OpenFileChronList.Filter = "Pulse Chronos Queue List|*.pcql"
        '
        'SaveFileChronList
        '
        Me.SaveFileChronList.Filter = "Pulse Chronos Queue List|*.pcql"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.MainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ChronGridMenu
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 700)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pulse Chronos"
        Me.MainTabControl.ResumeLayout(False)
        Me.ControlTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.QuantityInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ChronItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChronGridMenu.ResumeLayout(False)
        Me.ChronGridMenu.PerformLayout()
        Me.LogsTabPage.ResumeLayout(False)
        Me.LogsTabControl.ResumeLayout(False)
        Me.ActivityTabPage.ResumeLayout(False)
        CType(Me.ActivityLogGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STTradeTabPage.ResumeLayout(False)
        CType(Me.STTradeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STErrorTabPage.ResumeLayout(False)
        CType(Me.STErrorGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindActivityGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindSTTradeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindSTErrorGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindChronItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents ControlTabPage As TabPage
    Friend WithEvents LogsTabPage As TabPage
    Friend WithEvents LogsTabControl As TabControl
    Friend WithEvents ActivityTabPage As TabPage
    Friend WithEvents STTradeTabPage As TabPage
    Friend WithEvents STErrorTabPage As TabPage
    Friend WithEvents STTimer As Timer
    Friend WithEvents ActivityLogGrid As DataGridView
    Friend WithEvents STTradeGrid As DataGridView
    Friend WithEvents STErrorGrid As DataGridView
    Friend WithEvents BindActivityGrid As BindingSource
    Friend WithEvents BindSTTradeGrid As BindingSource
    Friend WithEvents BindSTErrorGrid As BindingSource
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ServerTimeLabel As Label
    Friend WithEvents ChronItemGrid As DataGridView
    Friend WithEvents BindChronItemGrid As BindingSource
    Friend WithEvents ChronGridMenu As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TimeInput As DateTimePicker
    Friend WithEvents SymbolInput As TextBox
    Friend WithEvents SideInput As ComboBox
    Friend WithEvents QuantityInput As NumericUpDown
    Friend WithEvents DestinationInput As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AddQueueButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents STAPIEnabledLabel As Label
    Friend WithEvents LoginTraderLabel As Label
    Friend WithEvents SaveChronListMenu As ToolStripMenuItem
    Friend WithEvents LoadChronListMenu As ToolStripMenuItem
    Friend WithEvents FailedItemsLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents InQueueItemsLabel As Label
    Friend WithEvents ProcessedItemsLabel As Label
    Friend WithEvents RefreshChronListMenu As ToolStripMenuItem
    Friend WithEvents OpenFileChronList As OpenFileDialog
    Friend WithEvents SaveFileChronList As SaveFileDialog
    Friend WithEvents ClearChronListMenu As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents PulseStatusLabel As Label
    Friend WithEvents AccountInput As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PulseSwitchButton As Button
End Class
