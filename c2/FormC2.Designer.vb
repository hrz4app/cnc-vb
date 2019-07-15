<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormC2
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

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
        Me.TabSatu = New MetroFramework.Controls.MetroTabControl()
        Me.TabPageConnection = New MetroFramework.Controls.MetroTabPage()
        Me.ButtonRefreshPorts = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelComPort = New System.Windows.Forms.Label()
        Me.ButtonConnect = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DropdownPorts = New Bunifu.Framework.UI.BunifuDropdown()
        Me.TabDua = New MetroFramework.Controls.MetroTabControl()
        Me.TabPageManual = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckboxSpindleWithPID = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.LabelManualSpindleStop = New System.Windows.Forms.Label()
        Me.LabelManualSpindleCW = New System.Windows.Forms.Label()
        Me.LabelManualSpindleCCW = New System.Windows.Forms.Label()
        Me.ButtonManualSpindleStop = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonManualSpindleCCW = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonManualSpindleCW = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SliderSpindle = New Bunifu.Framework.UI.BunifuSlider()
        Me.LabelManualRpm = New System.Windows.Forms.Label()
        Me.TextboxManualRpm = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelSpindle = New System.Windows.Forms.Label()
        Me.GroupBoxAxis = New System.Windows.Forms.GroupBox()
        Me.TextboxSemiZ = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelGoToOrigin = New System.Windows.Forms.Label()
        Me.ButtonGoInc = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonGoToOrigin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelSetOrigin = New System.Windows.Forms.Label()
        Me.LabelSemiZ = New System.Windows.Forms.Label()
        Me.ButtonSetOrigin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextboxSemiX = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SliderManualFeedRate = New Bunifu.Framework.UI.BunifuSlider()
        Me.ButtonGoAbs = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelSemiX = New System.Windows.Forms.Label()
        Me.LabelFeedRate = New System.Windows.Forms.Label()
        Me.TextboxSemiY = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TextboxManualFeedRate = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelSemiY = New System.Windows.Forms.Label()
        Me.LabelManualZmin = New System.Windows.Forms.Label()
        Me.LabelManualFeedRate = New System.Windows.Forms.Label()
        Me.LabelManualZplus = New System.Windows.Forms.Label()
        Me.ButtonManualZmin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonManualYplus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonManualZplus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonManualYmin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonManualHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonManualXmin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelManualYplus = New System.Windows.Forms.Label()
        Me.ButtonManualXplus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelManualXmin = New System.Windows.Forms.Label()
        Me.LabelManualXplus = New System.Windows.Forms.Label()
        Me.LabelManualYmin = New System.Windows.Forms.Label()
        Me.TabPageAuto = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelAutoSpindleRPM = New System.Windows.Forms.Label()
        Me.LabelAutoFeedrateMMMIN = New System.Windows.Forms.Label()
        Me.LabelAutoSpindle = New System.Windows.Forms.Label()
        Me.TextboxAutoSpindle = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelAutoFeedrate = New System.Windows.Forms.Label()
        Me.TextboxAutoFeedrate = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.ButtonGcodeRun = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBoxGcode = New System.Windows.Forms.GroupBox()
        Me.ButtonGcodeSaveAs = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RichTextBoxGCode = New System.Windows.Forms.RichTextBox()
        Me.ButtonOpenFusion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonGcodeNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonGcodeSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonGcodeEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBoxFile = New System.Windows.Forms.GroupBox()
        Me.ButtonGcodeBrowse = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextBoxGcodeFile = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextboxGcodeShow = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TabTiga = New MetroFramework.Controls.MetroTabControl()
        Me.TabPageWorkingCoord = New MetroFramework.Controls.MetroTabPage()
        Me.LabelWorkingZ = New System.Windows.Forms.Label()
        Me.TextboxWorkingZ = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelWorkingY = New System.Windows.Forms.Label()
        Me.TextboxWorkingY = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelWorkingX = New System.Windows.Forms.Label()
        Me.TextboxWorkingX = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TabEmpat = New MetroFramework.Controls.MetroTabControl()
        Me.TabPageSpeed = New MetroFramework.Controls.MetroTabPage()
        Me.LabelMachineY = New System.Windows.Forms.Label()
        Me.TextboxWorkingRPM = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelMachineX = New System.Windows.Forms.Label()
        Me.TextboxWorkingFeedrate = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TabLima = New MetroFramework.Controls.MetroTabControl()
        Me.TabPageControl = New MetroFramework.Controls.MetroTabPage()
        Me.ButtonResume = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonEmergency = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonPause = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonReset = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MegaSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelO = New System.Windows.Forms.Label()
        Me.TabEnam = New MetroFramework.Controls.MetroTabControl()
        Me.TabPageAxisGraph = New MetroFramework.Controls.MetroTabPage()
        Me.PanelAxisGraph = New System.Windows.Forms.Panel()
        Me.TabPagePIDGraph = New MetroFramework.Controls.MetroTabPage()
        Me.PanelPidGraph = New System.Windows.Forms.Panel()
        Me.TabPageDiagnostics = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextBoxKirim = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxDiagnostics = New System.Windows.Forms.RichTextBox()
        Me.ButtonResetGraph = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.OpenFileGcode = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileGcode = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonClearMonitor = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabSatu.SuspendLayout()
        Me.TabPageConnection.SuspendLayout()
        Me.TabDua.SuspendLayout()
        Me.TabPageManual.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxAxis.SuspendLayout()
        Me.TabPageAuto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxGcode.SuspendLayout()
        Me.GroupBoxFile.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabTiga.SuspendLayout()
        Me.TabPageWorkingCoord.SuspendLayout()
        Me.TabEmpat.SuspendLayout()
        Me.TabPageSpeed.SuspendLayout()
        Me.TabLima.SuspendLayout()
        Me.TabPageControl.SuspendLayout()
        Me.TabEnam.SuspendLayout()
        Me.TabPageAxisGraph.SuspendLayout()
        Me.TabPagePIDGraph.SuspendLayout()
        Me.TabPageDiagnostics.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabSatu
        '
        Me.TabSatu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabSatu.Controls.Add(Me.TabPageConnection)
        Me.TabSatu.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.TabSatu.Location = New System.Drawing.Point(24, 70)
        Me.TabSatu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabSatu.Multiline = True
        Me.TabSatu.Name = "TabSatu"
        Me.TabSatu.SelectedIndex = 0
        Me.TabSatu.Size = New System.Drawing.Size(381, 194)
        Me.TabSatu.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabSatu.TabIndex = 0
        Me.TabSatu.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabSatu.UseSelectable = True
        '
        'TabPageConnection
        '
        Me.TabPageConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageConnection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageConnection.Controls.Add(Me.ButtonRefreshPorts)
        Me.TabPageConnection.Controls.Add(Me.LabelComPort)
        Me.TabPageConnection.Controls.Add(Me.ButtonConnect)
        Me.TabPageConnection.Controls.Add(Me.DropdownPorts)
        Me.TabPageConnection.HorizontalScrollbarBarColor = True
        Me.TabPageConnection.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageConnection.HorizontalScrollbarSize = 10
        Me.TabPageConnection.Location = New System.Drawing.Point(4, 41)
        Me.TabPageConnection.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageConnection.Name = "TabPageConnection"
        Me.TabPageConnection.Size = New System.Drawing.Size(373, 149)
        Me.TabPageConnection.TabIndex = 3
        Me.TabPageConnection.Text = "CONNECTION"
        Me.TabPageConnection.UseCustomBackColor = True
        Me.TabPageConnection.VerticalScrollbarBarColor = True
        Me.TabPageConnection.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageConnection.VerticalScrollbarSize = 3
        '
        'ButtonRefreshPorts
        '
        Me.ButtonRefreshPorts.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRefreshPorts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRefreshPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonRefreshPorts.BorderRadius = 4
        Me.ButtonRefreshPorts.ButtonText = "REFRESH"
        Me.ButtonRefreshPorts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefreshPorts.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonRefreshPorts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshPorts.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonRefreshPorts.Iconimage = Nothing
        Me.ButtonRefreshPorts.Iconimage_right = Nothing
        Me.ButtonRefreshPorts.Iconimage_right_Selected = Nothing
        Me.ButtonRefreshPorts.Iconimage_Selected = Nothing
        Me.ButtonRefreshPorts.IconMarginLeft = 0
        Me.ButtonRefreshPorts.IconMarginRight = 0
        Me.ButtonRefreshPorts.IconRightVisible = False
        Me.ButtonRefreshPorts.IconRightZoom = 0R
        Me.ButtonRefreshPorts.IconVisible = False
        Me.ButtonRefreshPorts.IconZoom = 30.0R
        Me.ButtonRefreshPorts.IsTab = False
        Me.ButtonRefreshPorts.Location = New System.Drawing.Point(254, 43)
        Me.ButtonRefreshPorts.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonRefreshPorts.Name = "ButtonRefreshPorts"
        Me.ButtonRefreshPorts.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRefreshPorts.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRefreshPorts.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonRefreshPorts.selected = False
        Me.ButtonRefreshPorts.Size = New System.Drawing.Size(93, 30)
        Me.ButtonRefreshPorts.TabIndex = 9
        Me.ButtonRefreshPorts.Text = "REFRESH"
        Me.ButtonRefreshPorts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonRefreshPorts.Textcolor = System.Drawing.Color.White
        Me.ButtonRefreshPorts.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelComPort
        '
        Me.LabelComPort.AutoSize = True
        Me.LabelComPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelComPort.ForeColor = System.Drawing.Color.Black
        Me.LabelComPort.Location = New System.Drawing.Point(23, 14)
        Me.LabelComPort.Name = "LabelComPort"
        Me.LabelComPort.Size = New System.Drawing.Size(105, 20)
        Me.LabelComPort.TabIndex = 8
        Me.LabelComPort.Text = "COM PORT:"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonConnect.BorderRadius = 4
        Me.ButtonConnect.ButtonText = "CONNECT"
        Me.ButtonConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonConnect.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonConnect.Iconimage = Nothing
        Me.ButtonConnect.Iconimage_right = Nothing
        Me.ButtonConnect.Iconimage_right_Selected = Nothing
        Me.ButtonConnect.Iconimage_Selected = Nothing
        Me.ButtonConnect.IconMarginLeft = 0
        Me.ButtonConnect.IconMarginRight = 0
        Me.ButtonConnect.IconRightVisible = False
        Me.ButtonConnect.IconRightZoom = 0R
        Me.ButtonConnect.IconVisible = False
        Me.ButtonConnect.IconZoom = 90.0R
        Me.ButtonConnect.IsTab = False
        Me.ButtonConnect.Location = New System.Drawing.Point(23, 87)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConnect.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConnect.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonConnect.selected = False
        Me.ButtonConnect.Size = New System.Drawing.Size(324, 42)
        Me.ButtonConnect.TabIndex = 7
        Me.ButtonConnect.Text = "CONNECT"
        Me.ButtonConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonConnect.Textcolor = System.Drawing.Color.White
        Me.ButtonConnect.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DropdownPorts
        '
        Me.DropdownPorts.BackColor = System.Drawing.Color.Transparent
        Me.DropdownPorts.BorderRadius = 4
        Me.DropdownPorts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DropdownPorts.DisabledColor = System.Drawing.Color.Gray
        Me.DropdownPorts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropdownPorts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DropdownPorts.Items = New String(-1) {}
        Me.DropdownPorts.Location = New System.Drawing.Point(27, 39)
        Me.DropdownPorts.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DropdownPorts.Name = "DropdownPorts"
        Me.DropdownPorts.NomalColor = System.Drawing.Color.White
        Me.DropdownPorts.onHoverColor = System.Drawing.Color.White
        Me.DropdownPorts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DropdownPorts.selectedIndex = -1
        Me.DropdownPorts.Size = New System.Drawing.Size(217, 38)
        Me.DropdownPorts.TabIndex = 5
        '
        'TabDua
        '
        Me.TabDua.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabDua.Controls.Add(Me.TabPageManual)
        Me.TabDua.Controls.Add(Me.TabPageAuto)
        Me.TabDua.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.TabDua.Location = New System.Drawing.Point(945, 70)
        Me.TabDua.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabDua.Multiline = True
        Me.TabDua.Name = "TabDua"
        Me.TabDua.SelectedIndex = 0
        Me.TabDua.Size = New System.Drawing.Size(494, 605)
        Me.TabDua.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabDua.TabIndex = 1
        Me.TabDua.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabDua.UseSelectable = True
        '
        'TabPageManual
        '
        Me.TabPageManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageManual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageManual.Controls.Add(Me.GroupBox2)
        Me.TabPageManual.Controls.Add(Me.GroupBoxAxis)
        Me.TabPageManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageManual.HorizontalScrollbarBarColor = True
        Me.TabPageManual.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageManual.HorizontalScrollbarSize = 10
        Me.TabPageManual.Location = New System.Drawing.Point(4, 41)
        Me.TabPageManual.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageManual.Name = "TabPageManual"
        Me.TabPageManual.Size = New System.Drawing.Size(486, 560)
        Me.TabPageManual.TabIndex = 1
        Me.TabPageManual.Text = "MANUAL"
        Me.TabPageManual.UseCustomBackColor = True
        Me.TabPageManual.VerticalScrollbarBarColor = True
        Me.TabPageManual.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageManual.VerticalScrollbarSize = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CheckboxSpindleWithPID)
        Me.GroupBox2.Controls.Add(Me.LabelManualSpindleStop)
        Me.GroupBox2.Controls.Add(Me.LabelManualSpindleCW)
        Me.GroupBox2.Controls.Add(Me.LabelManualSpindleCCW)
        Me.GroupBox2.Controls.Add(Me.ButtonManualSpindleStop)
        Me.GroupBox2.Controls.Add(Me.ButtonManualSpindleCCW)
        Me.GroupBox2.Controls.Add(Me.ButtonManualSpindleCW)
        Me.GroupBox2.Controls.Add(Me.SliderSpindle)
        Me.GroupBox2.Controls.Add(Me.LabelManualRpm)
        Me.GroupBox2.Controls.Add(Me.TextboxManualRpm)
        Me.GroupBox2.Controls.Add(Me.LabelSpindle)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 208)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SPINDLE CONTROL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "PID"
        '
        'CheckboxSpindleWithPID
        '
        Me.CheckboxSpindleWithPID.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckboxSpindleWithPID.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckboxSpindleWithPID.Checked = False
        Me.CheckboxSpindleWithPID.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckboxSpindleWithPID.Enabled = False
        Me.CheckboxSpindleWithPID.ForeColor = System.Drawing.Color.White
        Me.CheckboxSpindleWithPID.Location = New System.Drawing.Point(19, 44)
        Me.CheckboxSpindleWithPID.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckboxSpindleWithPID.Name = "CheckboxSpindleWithPID"
        Me.CheckboxSpindleWithPID.Size = New System.Drawing.Size(20, 20)
        Me.CheckboxSpindleWithPID.TabIndex = 43
        '
        'LabelManualSpindleStop
        '
        Me.LabelManualSpindleStop.AutoSize = True
        Me.LabelManualSpindleStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualSpindleStop.ForeColor = System.Drawing.Color.Black
        Me.LabelManualSpindleStop.Location = New System.Drawing.Point(195, 174)
        Me.LabelManualSpindleStop.Name = "LabelManualSpindleStop"
        Me.LabelManualSpindleStop.Size = New System.Drawing.Size(55, 20)
        Me.LabelManualSpindleStop.TabIndex = 37
        Me.LabelManualSpindleStop.Text = "STOP"
        '
        'LabelManualSpindleCW
        '
        Me.LabelManualSpindleCW.AutoSize = True
        Me.LabelManualSpindleCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualSpindleCW.ForeColor = System.Drawing.Color.Black
        Me.LabelManualSpindleCW.Location = New System.Drawing.Point(302, 137)
        Me.LabelManualSpindleCW.Name = "LabelManualSpindleCW"
        Me.LabelManualSpindleCW.Size = New System.Drawing.Size(37, 20)
        Me.LabelManualSpindleCW.TabIndex = 36
        Me.LabelManualSpindleCW.Text = "CW"
        '
        'LabelManualSpindleCCW
        '
        Me.LabelManualSpindleCCW.AutoSize = True
        Me.LabelManualSpindleCCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualSpindleCCW.ForeColor = System.Drawing.Color.Black
        Me.LabelManualSpindleCCW.Location = New System.Drawing.Point(91, 138)
        Me.LabelManualSpindleCCW.Name = "LabelManualSpindleCCW"
        Me.LabelManualSpindleCCW.Size = New System.Drawing.Size(49, 20)
        Me.LabelManualSpindleCCW.TabIndex = 35
        Me.LabelManualSpindleCCW.Text = "CCW"
        '
        'ButtonManualSpindleStop
        '
        Me.ButtonManualSpindleStop.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualSpindleStop.BorderRadius = 4
        Me.ButtonManualSpindleStop.ButtonText = ""
        Me.ButtonManualSpindleStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualSpindleStop.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualSpindleStop.Enabled = False
        Me.ButtonManualSpindleStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualSpindleStop.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualSpindleStop.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_stop_circle_o
        Me.ButtonManualSpindleStop.Iconimage_right = Nothing
        Me.ButtonManualSpindleStop.Iconimage_right_Selected = Nothing
        Me.ButtonManualSpindleStop.Iconimage_Selected = Nothing
        Me.ButtonManualSpindleStop.IconMarginLeft = 0
        Me.ButtonManualSpindleStop.IconMarginRight = 0
        Me.ButtonManualSpindleStop.IconRightVisible = False
        Me.ButtonManualSpindleStop.IconRightZoom = 0R
        Me.ButtonManualSpindleStop.IconVisible = True
        Me.ButtonManualSpindleStop.IconZoom = 50.0R
        Me.ButtonManualSpindleStop.IsTab = False
        Me.ButtonManualSpindleStop.Location = New System.Drawing.Point(197, 123)
        Me.ButtonManualSpindleStop.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualSpindleStop.Name = "ButtonManualSpindleStop"
        Me.ButtonManualSpindleStop.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleStop.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleStop.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualSpindleStop.selected = False
        Me.ButtonManualSpindleStop.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualSpindleStop.TabIndex = 34
        Me.ButtonManualSpindleStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualSpindleStop.Textcolor = System.Drawing.Color.White
        Me.ButtonManualSpindleStop.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonManualSpindleCCW
        '
        Me.ButtonManualSpindleCCW.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCCW.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualSpindleCCW.BorderRadius = 4
        Me.ButtonManualSpindleCCW.ButtonText = ""
        Me.ButtonManualSpindleCCW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualSpindleCCW.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualSpindleCCW.Enabled = False
        Me.ButtonManualSpindleCCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualSpindleCCW.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualSpindleCCW.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_rotate_left
        Me.ButtonManualSpindleCCW.Iconimage_right = Nothing
        Me.ButtonManualSpindleCCW.Iconimage_right_Selected = Nothing
        Me.ButtonManualSpindleCCW.Iconimage_Selected = Nothing
        Me.ButtonManualSpindleCCW.IconMarginLeft = 0
        Me.ButtonManualSpindleCCW.IconMarginRight = 0
        Me.ButtonManualSpindleCCW.IconRightVisible = False
        Me.ButtonManualSpindleCCW.IconRightZoom = 0R
        Me.ButtonManualSpindleCCW.IconVisible = True
        Me.ButtonManualSpindleCCW.IconZoom = 50.0R
        Me.ButtonManualSpindleCCW.IsTab = False
        Me.ButtonManualSpindleCCW.Location = New System.Drawing.Point(142, 123)
        Me.ButtonManualSpindleCCW.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualSpindleCCW.Name = "ButtonManualSpindleCCW"
        Me.ButtonManualSpindleCCW.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCCW.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCCW.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualSpindleCCW.selected = False
        Me.ButtonManualSpindleCCW.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualSpindleCCW.TabIndex = 33
        Me.ButtonManualSpindleCCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualSpindleCCW.Textcolor = System.Drawing.Color.White
        Me.ButtonManualSpindleCCW.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonManualSpindleCW
        '
        Me.ButtonManualSpindleCW.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCW.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualSpindleCW.BorderRadius = 4
        Me.ButtonManualSpindleCW.ButtonText = ""
        Me.ButtonManualSpindleCW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualSpindleCW.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualSpindleCW.Enabled = False
        Me.ButtonManualSpindleCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualSpindleCW.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualSpindleCW.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_rotate_right
        Me.ButtonManualSpindleCW.Iconimage_right = Nothing
        Me.ButtonManualSpindleCW.Iconimage_right_Selected = Nothing
        Me.ButtonManualSpindleCW.Iconimage_Selected = Nothing
        Me.ButtonManualSpindleCW.IconMarginLeft = 0
        Me.ButtonManualSpindleCW.IconMarginRight = 0
        Me.ButtonManualSpindleCW.IconRightVisible = False
        Me.ButtonManualSpindleCW.IconRightZoom = 0R
        Me.ButtonManualSpindleCW.IconVisible = True
        Me.ButtonManualSpindleCW.IconZoom = 50.0R
        Me.ButtonManualSpindleCW.IsTab = False
        Me.ButtonManualSpindleCW.Location = New System.Drawing.Point(252, 123)
        Me.ButtonManualSpindleCW.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualSpindleCW.Name = "ButtonManualSpindleCW"
        Me.ButtonManualSpindleCW.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCW.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualSpindleCW.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualSpindleCW.selected = False
        Me.ButtonManualSpindleCW.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualSpindleCW.TabIndex = 32
        Me.ButtonManualSpindleCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualSpindleCW.Textcolor = System.Drawing.Color.White
        Me.ButtonManualSpindleCW.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SliderSpindle
        '
        Me.SliderSpindle.BackColor = System.Drawing.Color.Transparent
        Me.SliderSpindle.BackgroudColor = System.Drawing.Color.Silver
        Me.SliderSpindle.BorderRadius = 0
        Me.SliderSpindle.Enabled = False
        Me.SliderSpindle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SliderSpindle.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SliderSpindle.Location = New System.Drawing.Point(18, 73)
        Me.SliderSpindle.Margin = New System.Windows.Forms.Padding(5)
        Me.SliderSpindle.MaximumValue = 5000
        Me.SliderSpindle.Name = "SliderSpindle"
        Me.SliderSpindle.Size = New System.Drawing.Size(417, 30)
        Me.SliderSpindle.TabIndex = 31
        Me.SliderSpindle.Value = 2000
        '
        'LabelManualRpm
        '
        Me.LabelManualRpm.AutoSize = True
        Me.LabelManualRpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualRpm.ForeColor = System.Drawing.Color.Black
        Me.LabelManualRpm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelManualRpm.Location = New System.Drawing.Point(396, 21)
        Me.LabelManualRpm.Name = "LabelManualRpm"
        Me.LabelManualRpm.Size = New System.Drawing.Size(39, 20)
        Me.LabelManualRpm.TabIndex = 30
        Me.LabelManualRpm.Text = "rpm"
        '
        'TextboxManualRpm
        '
        Me.TextboxManualRpm.BackColor = System.Drawing.Color.White
        Me.TextboxManualRpm.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxManualRpm.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxManualRpm.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxManualRpm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxManualRpm.BorderThickness = 4
        Me.TextboxManualRpm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxManualRpm.Enabled = False
        Me.TextboxManualRpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxManualRpm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxManualRpm.isPassword = False
        Me.TextboxManualRpm.Location = New System.Drawing.Point(334, 19)
        Me.TextboxManualRpm.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxManualRpm.Name = "TextboxManualRpm"
        Me.TextboxManualRpm.Size = New System.Drawing.Size(54, 25)
        Me.TextboxManualRpm.TabIndex = 29
        Me.TextboxManualRpm.Text = "2000"
        Me.TextboxManualRpm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSpindle
        '
        Me.LabelSpindle.AutoSize = True
        Me.LabelSpindle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSpindle.ForeColor = System.Drawing.Color.Black
        Me.LabelSpindle.Location = New System.Drawing.Point(198, 23)
        Me.LabelSpindle.Name = "LabelSpindle"
        Me.LabelSpindle.Size = New System.Drawing.Size(134, 17)
        Me.LabelSpindle.TabIndex = 11
        Me.LabelSpindle.Text = "SPINDLE SPEED:"
        '
        'GroupBoxAxis
        '
        Me.GroupBoxAxis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxAxis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GroupBoxAxis.Controls.Add(Me.TextboxSemiZ)
        Me.GroupBoxAxis.Controls.Add(Me.LabelGoToOrigin)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonGoInc)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonGoToOrigin)
        Me.GroupBoxAxis.Controls.Add(Me.LabelSetOrigin)
        Me.GroupBoxAxis.Controls.Add(Me.LabelSemiZ)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonSetOrigin)
        Me.GroupBoxAxis.Controls.Add(Me.TextboxSemiX)
        Me.GroupBoxAxis.Controls.Add(Me.SliderManualFeedRate)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonGoAbs)
        Me.GroupBoxAxis.Controls.Add(Me.LabelSemiX)
        Me.GroupBoxAxis.Controls.Add(Me.LabelFeedRate)
        Me.GroupBoxAxis.Controls.Add(Me.TextboxSemiY)
        Me.GroupBoxAxis.Controls.Add(Me.TextboxManualFeedRate)
        Me.GroupBoxAxis.Controls.Add(Me.LabelSemiY)
        Me.GroupBoxAxis.Controls.Add(Me.LabelManualZmin)
        Me.GroupBoxAxis.Controls.Add(Me.LabelManualFeedRate)
        Me.GroupBoxAxis.Controls.Add(Me.LabelManualZplus)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonManualZmin)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonManualYplus)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonManualZplus)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonManualYmin)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonManualHome)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonManualXmin)
        Me.GroupBoxAxis.Controls.Add(Me.LabelManualYplus)
        Me.GroupBoxAxis.Controls.Add(Me.ButtonManualXplus)
        Me.GroupBoxAxis.Controls.Add(Me.LabelManualXmin)
        Me.GroupBoxAxis.Controls.Add(Me.LabelManualXplus)
        Me.GroupBoxAxis.Controls.Add(Me.LabelManualYmin)
        Me.GroupBoxAxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxAxis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxAxis.Location = New System.Drawing.Point(14, 22)
        Me.GroupBoxAxis.Name = "GroupBoxAxis"
        Me.GroupBoxAxis.Size = New System.Drawing.Size(451, 296)
        Me.GroupBoxAxis.TabIndex = 29
        Me.GroupBoxAxis.TabStop = False
        Me.GroupBoxAxis.Text = "AXIS CONTROL"
        '
        'TextboxSemiZ
        '
        Me.TextboxSemiZ.BackColor = System.Drawing.Color.White
        Me.TextboxSemiZ.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxSemiZ.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxSemiZ.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxSemiZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxSemiZ.BorderThickness = 4
        Me.TextboxSemiZ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxSemiZ.Enabled = False
        Me.TextboxSemiZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxSemiZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxSemiZ.isPassword = False
        Me.TextboxSemiZ.Location = New System.Drawing.Point(226, 245)
        Me.TextboxSemiZ.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxSemiZ.Name = "TextboxSemiZ"
        Me.TextboxSemiZ.Size = New System.Drawing.Size(70, 31)
        Me.TextboxSemiZ.TabIndex = 41
        Me.TextboxSemiZ.Text = "0"
        Me.TextboxSemiZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelGoToOrigin
        '
        Me.LabelGoToOrigin.AutoSize = True
        Me.LabelGoToOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGoToOrigin.ForeColor = System.Drawing.Color.Black
        Me.LabelGoToOrigin.Location = New System.Drawing.Point(329, 216)
        Me.LabelGoToOrigin.Name = "LabelGoToOrigin"
        Me.LabelGoToOrigin.Size = New System.Drawing.Size(110, 20)
        Me.LabelGoToOrigin.TabIndex = 35
        Me.LabelGoToOrigin.Text = "Go To Origin"
        '
        'ButtonGoInc
        '
        Me.ButtonGoInc.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGoInc.BorderRadius = 4
        Me.ButtonGoInc.ButtonText = "INC"
        Me.ButtonGoInc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGoInc.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGoInc.Enabled = False
        Me.ButtonGoInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoInc.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGoInc.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_plus
        Me.ButtonGoInc.Iconimage_right = Nothing
        Me.ButtonGoInc.Iconimage_right_Selected = Nothing
        Me.ButtonGoInc.Iconimage_Selected = Nothing
        Me.ButtonGoInc.IconMarginLeft = 0
        Me.ButtonGoInc.IconMarginRight = 0
        Me.ButtonGoInc.IconRightVisible = False
        Me.ButtonGoInc.IconRightZoom = 0R
        Me.ButtonGoInc.IconVisible = True
        Me.ButtonGoInc.IconZoom = 25.0R
        Me.ButtonGoInc.IsTab = False
        Me.ButtonGoInc.Location = New System.Drawing.Point(371, 245)
        Me.ButtonGoInc.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGoInc.Name = "ButtonGoInc"
        Me.ButtonGoInc.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoInc.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoInc.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGoInc.selected = False
        Me.ButtonGoInc.Size = New System.Drawing.Size(61, 31)
        Me.ButtonGoInc.TabIndex = 44
        Me.ButtonGoInc.Text = "INC"
        Me.ButtonGoInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGoInc.Textcolor = System.Drawing.Color.White
        Me.ButtonGoInc.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonGoToOrigin
        '
        Me.ButtonGoToOrigin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoToOrigin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoToOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGoToOrigin.BorderRadius = 4
        Me.ButtonGoToOrigin.ButtonText = ""
        Me.ButtonGoToOrigin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGoToOrigin.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGoToOrigin.Enabled = False
        Me.ButtonGoToOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoToOrigin.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGoToOrigin.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_ship
        Me.ButtonGoToOrigin.Iconimage_right = Nothing
        Me.ButtonGoToOrigin.Iconimage_right_Selected = Nothing
        Me.ButtonGoToOrigin.Iconimage_Selected = Nothing
        Me.ButtonGoToOrigin.IconMarginLeft = 0
        Me.ButtonGoToOrigin.IconMarginRight = 0
        Me.ButtonGoToOrigin.IconRightVisible = False
        Me.ButtonGoToOrigin.IconRightZoom = 0R
        Me.ButtonGoToOrigin.IconVisible = True
        Me.ButtonGoToOrigin.IconZoom = 50.0R
        Me.ButtonGoToOrigin.IsTab = False
        Me.ButtonGoToOrigin.Location = New System.Drawing.Point(358, 164)
        Me.ButtonGoToOrigin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGoToOrigin.Name = "ButtonGoToOrigin"
        Me.ButtonGoToOrigin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoToOrigin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoToOrigin.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGoToOrigin.selected = False
        Me.ButtonGoToOrigin.Size = New System.Drawing.Size(48, 48)
        Me.ButtonGoToOrigin.TabIndex = 34
        Me.ButtonGoToOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGoToOrigin.Textcolor = System.Drawing.Color.White
        Me.ButtonGoToOrigin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelSetOrigin
        '
        Me.LabelSetOrigin.AutoSize = True
        Me.LabelSetOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSetOrigin.ForeColor = System.Drawing.Color.Black
        Me.LabelSetOrigin.Location = New System.Drawing.Point(338, 82)
        Me.LabelSetOrigin.Name = "LabelSetOrigin"
        Me.LabelSetOrigin.Size = New System.Drawing.Size(89, 20)
        Me.LabelSetOrigin.TabIndex = 33
        Me.LabelSetOrigin.Text = "Set Origin"
        '
        'LabelSemiZ
        '
        Me.LabelSemiZ.AutoSize = True
        Me.LabelSemiZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSemiZ.ForeColor = System.Drawing.Color.Black
        Me.LabelSemiZ.Location = New System.Drawing.Point(203, 249)
        Me.LabelSemiZ.Name = "LabelSemiZ"
        Me.LabelSemiZ.Size = New System.Drawing.Size(20, 20)
        Me.LabelSemiZ.TabIndex = 42
        Me.LabelSemiZ.Text = "Z"
        '
        'ButtonSetOrigin
        '
        Me.ButtonSetOrigin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSetOrigin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSetOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSetOrigin.BorderRadius = 4
        Me.ButtonSetOrigin.ButtonText = ""
        Me.ButtonSetOrigin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSetOrigin.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonSetOrigin.Enabled = False
        Me.ButtonSetOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSetOrigin.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonSetOrigin.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_anchor
        Me.ButtonSetOrigin.Iconimage_right = Nothing
        Me.ButtonSetOrigin.Iconimage_right_Selected = Nothing
        Me.ButtonSetOrigin.Iconimage_Selected = Nothing
        Me.ButtonSetOrigin.IconMarginLeft = 0
        Me.ButtonSetOrigin.IconMarginRight = 0
        Me.ButtonSetOrigin.IconRightVisible = False
        Me.ButtonSetOrigin.IconRightZoom = 0R
        Me.ButtonSetOrigin.IconVisible = True
        Me.ButtonSetOrigin.IconZoom = 50.0R
        Me.ButtonSetOrigin.IsTab = False
        Me.ButtonSetOrigin.Location = New System.Drawing.Point(358, 105)
        Me.ButtonSetOrigin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonSetOrigin.Name = "ButtonSetOrigin"
        Me.ButtonSetOrigin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSetOrigin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSetOrigin.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonSetOrigin.selected = False
        Me.ButtonSetOrigin.Size = New System.Drawing.Size(48, 48)
        Me.ButtonSetOrigin.TabIndex = 32
        Me.ButtonSetOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonSetOrigin.Textcolor = System.Drawing.Color.White
        Me.ButtonSetOrigin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextboxSemiX
        '
        Me.TextboxSemiX.BackColor = System.Drawing.Color.White
        Me.TextboxSemiX.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxSemiX.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxSemiX.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxSemiX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxSemiX.BorderThickness = 4
        Me.TextboxSemiX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxSemiX.Enabled = False
        Me.TextboxSemiX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxSemiX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxSemiX.isPassword = False
        Me.TextboxSemiX.Location = New System.Drawing.Point(37, 245)
        Me.TextboxSemiX.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxSemiX.Name = "TextboxSemiX"
        Me.TextboxSemiX.Size = New System.Drawing.Size(70, 31)
        Me.TextboxSemiX.TabIndex = 37
        Me.TextboxSemiX.Text = "50"
        Me.TextboxSemiX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SliderManualFeedRate
        '
        Me.SliderManualFeedRate.BackColor = System.Drawing.Color.Transparent
        Me.SliderManualFeedRate.BackgroudColor = System.Drawing.Color.Silver
        Me.SliderManualFeedRate.BorderRadius = 0
        Me.SliderManualFeedRate.Enabled = False
        Me.SliderManualFeedRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SliderManualFeedRate.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SliderManualFeedRate.Location = New System.Drawing.Point(18, 50)
        Me.SliderManualFeedRate.Margin = New System.Windows.Forms.Padding(5)
        Me.SliderManualFeedRate.MaximumValue = 800
        Me.SliderManualFeedRate.Name = "SliderManualFeedRate"
        Me.SliderManualFeedRate.Size = New System.Drawing.Size(410, 30)
        Me.SliderManualFeedRate.TabIndex = 29
        Me.SliderManualFeedRate.Value = 500
        '
        'ButtonGoAbs
        '
        Me.ButtonGoAbs.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoAbs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoAbs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGoAbs.BorderRadius = 4
        Me.ButtonGoAbs.ButtonText = "ABS"
        Me.ButtonGoAbs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGoAbs.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGoAbs.Enabled = False
        Me.ButtonGoAbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoAbs.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGoAbs.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_bullseye
        Me.ButtonGoAbs.Iconimage_right = Nothing
        Me.ButtonGoAbs.Iconimage_right_Selected = Nothing
        Me.ButtonGoAbs.Iconimage_Selected = Nothing
        Me.ButtonGoAbs.IconMarginLeft = 0
        Me.ButtonGoAbs.IconMarginRight = 0
        Me.ButtonGoAbs.IconRightVisible = False
        Me.ButtonGoAbs.IconRightZoom = 0R
        Me.ButtonGoAbs.IconVisible = True
        Me.ButtonGoAbs.IconZoom = 25.0R
        Me.ButtonGoAbs.IsTab = False
        Me.ButtonGoAbs.Location = New System.Drawing.Point(303, 247)
        Me.ButtonGoAbs.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGoAbs.Name = "ButtonGoAbs"
        Me.ButtonGoAbs.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoAbs.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoAbs.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGoAbs.selected = False
        Me.ButtonGoAbs.Size = New System.Drawing.Size(61, 29)
        Me.ButtonGoAbs.TabIndex = 43
        Me.ButtonGoAbs.Text = "ABS"
        Me.ButtonGoAbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGoAbs.Textcolor = System.Drawing.Color.White
        Me.ButtonGoAbs.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelSemiX
        '
        Me.LabelSemiX.AutoSize = True
        Me.LabelSemiX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSemiX.ForeColor = System.Drawing.Color.Black
        Me.LabelSemiX.Location = New System.Drawing.Point(14, 249)
        Me.LabelSemiX.Name = "LabelSemiX"
        Me.LabelSemiX.Size = New System.Drawing.Size(21, 20)
        Me.LabelSemiX.TabIndex = 38
        Me.LabelSemiX.Text = "X"
        '
        'LabelFeedRate
        '
        Me.LabelFeedRate.AutoSize = True
        Me.LabelFeedRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFeedRate.ForeColor = System.Drawing.Color.Black
        Me.LabelFeedRate.Location = New System.Drawing.Point(206, 24)
        Me.LabelFeedRate.Name = "LabelFeedRate"
        Me.LabelFeedRate.Size = New System.Drawing.Size(103, 17)
        Me.LabelFeedRate.TabIndex = 13
        Me.LabelFeedRate.Text = "AXIS SPEED:"
        '
        'TextboxSemiY
        '
        Me.TextboxSemiY.BackColor = System.Drawing.Color.White
        Me.TextboxSemiY.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxSemiY.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxSemiY.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxSemiY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxSemiY.BorderThickness = 4
        Me.TextboxSemiY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxSemiY.Enabled = False
        Me.TextboxSemiY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxSemiY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxSemiY.isPassword = False
        Me.TextboxSemiY.Location = New System.Drawing.Point(132, 245)
        Me.TextboxSemiY.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxSemiY.Name = "TextboxSemiY"
        Me.TextboxSemiY.Size = New System.Drawing.Size(70, 31)
        Me.TextboxSemiY.TabIndex = 39
        Me.TextboxSemiY.Text = "75"
        Me.TextboxSemiY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextboxManualFeedRate
        '
        Me.TextboxManualFeedRate.BackColor = System.Drawing.Color.White
        Me.TextboxManualFeedRate.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxManualFeedRate.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxManualFeedRate.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxManualFeedRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxManualFeedRate.BorderThickness = 4
        Me.TextboxManualFeedRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxManualFeedRate.Enabled = False
        Me.TextboxManualFeedRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxManualFeedRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxManualFeedRate.isPassword = False
        Me.TextboxManualFeedRate.Location = New System.Drawing.Point(312, 20)
        Me.TextboxManualFeedRate.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxManualFeedRate.Name = "TextboxManualFeedRate"
        Me.TextboxManualFeedRate.Size = New System.Drawing.Size(54, 25)
        Me.TextboxManualFeedRate.TabIndex = 28
        Me.TextboxManualFeedRate.Text = "500"
        Me.TextboxManualFeedRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSemiY
        '
        Me.LabelSemiY.AutoSize = True
        Me.LabelSemiY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSemiY.ForeColor = System.Drawing.Color.Black
        Me.LabelSemiY.Location = New System.Drawing.Point(109, 249)
        Me.LabelSemiY.Name = "LabelSemiY"
        Me.LabelSemiY.Size = New System.Drawing.Size(21, 20)
        Me.LabelSemiY.TabIndex = 40
        Me.LabelSemiY.Text = "Y"
        '
        'LabelManualZmin
        '
        Me.LabelManualZmin.AutoSize = True
        Me.LabelManualZmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualZmin.ForeColor = System.Drawing.Color.Black
        Me.LabelManualZmin.Location = New System.Drawing.Point(262, 215)
        Me.LabelManualZmin.Name = "LabelManualZmin"
        Me.LabelManualZmin.Size = New System.Drawing.Size(26, 20)
        Me.LabelManualZmin.TabIndex = 26
        Me.LabelManualZmin.Text = "Z-"
        '
        'LabelManualFeedRate
        '
        Me.LabelManualFeedRate.AutoSize = True
        Me.LabelManualFeedRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualFeedRate.ForeColor = System.Drawing.Color.Black
        Me.LabelManualFeedRate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelManualFeedRate.Location = New System.Drawing.Point(369, 22)
        Me.LabelManualFeedRate.Name = "LabelManualFeedRate"
        Me.LabelManualFeedRate.Size = New System.Drawing.Size(70, 20)
        Me.LabelManualFeedRate.TabIndex = 27
        Me.LabelManualFeedRate.Text = "mm/min"
        '
        'LabelManualZplus
        '
        Me.LabelManualZplus.AutoSize = True
        Me.LabelManualZplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualZplus.ForeColor = System.Drawing.Color.Black
        Me.LabelManualZplus.Location = New System.Drawing.Point(257, 81)
        Me.LabelManualZplus.Name = "LabelManualZplus"
        Me.LabelManualZplus.Size = New System.Drawing.Size(30, 20)
        Me.LabelManualZplus.TabIndex = 25
        Me.LabelManualZplus.Text = "Z+"
        '
        'ButtonManualZmin
        '
        Me.ButtonManualZmin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualZmin.BorderRadius = 4
        Me.ButtonManualZmin.ButtonText = ""
        Me.ButtonManualZmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualZmin.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualZmin.Enabled = False
        Me.ButtonManualZmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualZmin.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualZmin.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_arrow_down
        Me.ButtonManualZmin.Iconimage_right = Nothing
        Me.ButtonManualZmin.Iconimage_right_Selected = Nothing
        Me.ButtonManualZmin.Iconimage_Selected = Nothing
        Me.ButtonManualZmin.IconMarginLeft = 0
        Me.ButtonManualZmin.IconMarginRight = 0
        Me.ButtonManualZmin.IconRightVisible = False
        Me.ButtonManualZmin.IconRightZoom = 0R
        Me.ButtonManualZmin.IconVisible = True
        Me.ButtonManualZmin.IconZoom = 50.0R
        Me.ButtonManualZmin.IsTab = False
        Me.ButtonManualZmin.Location = New System.Drawing.Point(249, 164)
        Me.ButtonManualZmin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualZmin.Name = "ButtonManualZmin"
        Me.ButtonManualZmin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZmin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZmin.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualZmin.selected = False
        Me.ButtonManualZmin.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualZmin.TabIndex = 24
        Me.ButtonManualZmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualZmin.Textcolor = System.Drawing.Color.White
        Me.ButtonManualZmin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonManualYplus
        '
        Me.ButtonManualYplus.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYplus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualYplus.BorderRadius = 4
        Me.ButtonManualYplus.ButtonText = ""
        Me.ButtonManualYplus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualYplus.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualYplus.Enabled = False
        Me.ButtonManualYplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualYplus.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualYplus.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_arrow_up
        Me.ButtonManualYplus.Iconimage_right = Nothing
        Me.ButtonManualYplus.Iconimage_right_Selected = Nothing
        Me.ButtonManualYplus.Iconimage_Selected = Nothing
        Me.ButtonManualYplus.IconMarginLeft = 0
        Me.ButtonManualYplus.IconMarginRight = 0
        Me.ButtonManualYplus.IconRightVisible = False
        Me.ButtonManualYplus.IconRightZoom = 0R
        Me.ButtonManualYplus.IconVisible = True
        Me.ButtonManualYplus.IconZoom = 50.0R
        Me.ButtonManualYplus.IsTab = False
        Me.ButtonManualYplus.Location = New System.Drawing.Point(101, 105)
        Me.ButtonManualYplus.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualYplus.Name = "ButtonManualYplus"
        Me.ButtonManualYplus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYplus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYplus.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualYplus.selected = False
        Me.ButtonManualYplus.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualYplus.TabIndex = 14
        Me.ButtonManualYplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualYplus.Textcolor = System.Drawing.Color.White
        Me.ButtonManualYplus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonManualZplus
        '
        Me.ButtonManualZplus.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZplus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualZplus.BorderRadius = 4
        Me.ButtonManualZplus.ButtonText = ""
        Me.ButtonManualZplus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualZplus.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualZplus.Enabled = False
        Me.ButtonManualZplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualZplus.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualZplus.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_arrow_up
        Me.ButtonManualZplus.Iconimage_right = Nothing
        Me.ButtonManualZplus.Iconimage_right_Selected = Nothing
        Me.ButtonManualZplus.Iconimage_Selected = Nothing
        Me.ButtonManualZplus.IconMarginLeft = 0
        Me.ButtonManualZplus.IconMarginRight = 0
        Me.ButtonManualZplus.IconRightVisible = False
        Me.ButtonManualZplus.IconRightZoom = 0R
        Me.ButtonManualZplus.IconVisible = True
        Me.ButtonManualZplus.IconZoom = 50.0R
        Me.ButtonManualZplus.IsTab = False
        Me.ButtonManualZplus.Location = New System.Drawing.Point(249, 105)
        Me.ButtonManualZplus.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualZplus.Name = "ButtonManualZplus"
        Me.ButtonManualZplus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZplus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualZplus.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualZplus.selected = False
        Me.ButtonManualZplus.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualZplus.TabIndex = 23
        Me.ButtonManualZplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualZplus.Textcolor = System.Drawing.Color.White
        Me.ButtonManualZplus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonManualYmin
        '
        Me.ButtonManualYmin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualYmin.BorderRadius = 4
        Me.ButtonManualYmin.ButtonText = ""
        Me.ButtonManualYmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualYmin.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualYmin.Enabled = False
        Me.ButtonManualYmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualYmin.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualYmin.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_arrow_down
        Me.ButtonManualYmin.Iconimage_right = Nothing
        Me.ButtonManualYmin.Iconimage_right_Selected = Nothing
        Me.ButtonManualYmin.Iconimage_Selected = Nothing
        Me.ButtonManualYmin.IconMarginLeft = 0
        Me.ButtonManualYmin.IconMarginRight = 0
        Me.ButtonManualYmin.IconRightVisible = False
        Me.ButtonManualYmin.IconRightZoom = 0R
        Me.ButtonManualYmin.IconVisible = True
        Me.ButtonManualYmin.IconZoom = 50.0R
        Me.ButtonManualYmin.IsTab = False
        Me.ButtonManualYmin.Location = New System.Drawing.Point(101, 164)
        Me.ButtonManualYmin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualYmin.Name = "ButtonManualYmin"
        Me.ButtonManualYmin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYmin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualYmin.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualYmin.selected = False
        Me.ButtonManualYmin.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualYmin.TabIndex = 15
        Me.ButtonManualYmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualYmin.Textcolor = System.Drawing.Color.White
        Me.ButtonManualYmin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonManualHome
        '
        Me.ButtonManualHome.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualHome.BorderRadius = 4
        Me.ButtonManualHome.ButtonText = ""
        Me.ButtonManualHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualHome.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualHome.Enabled = False
        Me.ButtonManualHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualHome.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualHome.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_home
        Me.ButtonManualHome.Iconimage_right = Nothing
        Me.ButtonManualHome.Iconimage_right_Selected = Nothing
        Me.ButtonManualHome.Iconimage_Selected = Nothing
        Me.ButtonManualHome.IconMarginLeft = 0
        Me.ButtonManualHome.IconMarginRight = 0
        Me.ButtonManualHome.IconRightVisible = False
        Me.ButtonManualHome.IconRightZoom = 0R
        Me.ButtonManualHome.IconVisible = True
        Me.ButtonManualHome.IconZoom = 50.0R
        Me.ButtonManualHome.IsTab = False
        Me.ButtonManualHome.Location = New System.Drawing.Point(43, 105)
        Me.ButtonManualHome.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualHome.Name = "ButtonManualHome"
        Me.ButtonManualHome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualHome.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualHome.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualHome.selected = False
        Me.ButtonManualHome.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualHome.TabIndex = 22
        Me.ButtonManualHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualHome.Textcolor = System.Drawing.Color.White
        Me.ButtonManualHome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonManualXmin
        '
        Me.ButtonManualXmin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualXmin.BorderRadius = 4
        Me.ButtonManualXmin.ButtonText = ""
        Me.ButtonManualXmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualXmin.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualXmin.Enabled = False
        Me.ButtonManualXmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualXmin.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualXmin.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_arrow_left
        Me.ButtonManualXmin.Iconimage_right = Nothing
        Me.ButtonManualXmin.Iconimage_right_Selected = Nothing
        Me.ButtonManualXmin.Iconimage_Selected = Nothing
        Me.ButtonManualXmin.IconMarginLeft = 0
        Me.ButtonManualXmin.IconMarginRight = 0
        Me.ButtonManualXmin.IconRightVisible = False
        Me.ButtonManualXmin.IconRightZoom = 0R
        Me.ButtonManualXmin.IconVisible = True
        Me.ButtonManualXmin.IconZoom = 50.0R
        Me.ButtonManualXmin.IsTab = False
        Me.ButtonManualXmin.Location = New System.Drawing.Point(43, 164)
        Me.ButtonManualXmin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualXmin.Name = "ButtonManualXmin"
        Me.ButtonManualXmin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXmin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXmin.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualXmin.selected = False
        Me.ButtonManualXmin.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualXmin.TabIndex = 16
        Me.ButtonManualXmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualXmin.Textcolor = System.Drawing.Color.White
        Me.ButtonManualXmin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelManualYplus
        '
        Me.LabelManualYplus.AutoSize = True
        Me.LabelManualYplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualYplus.ForeColor = System.Drawing.Color.Black
        Me.LabelManualYplus.Location = New System.Drawing.Point(110, 81)
        Me.LabelManualYplus.Name = "LabelManualYplus"
        Me.LabelManualYplus.Size = New System.Drawing.Size(31, 20)
        Me.LabelManualYplus.TabIndex = 21
        Me.LabelManualYplus.Text = "Y+"
        '
        'ButtonManualXplus
        '
        Me.ButtonManualXplus.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXplus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonManualXplus.BorderRadius = 4
        Me.ButtonManualXplus.ButtonText = ""
        Me.ButtonManualXplus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonManualXplus.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonManualXplus.Enabled = False
        Me.ButtonManualXplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualXplus.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonManualXplus.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_arrow_right
        Me.ButtonManualXplus.Iconimage_right = Nothing
        Me.ButtonManualXplus.Iconimage_right_Selected = Nothing
        Me.ButtonManualXplus.Iconimage_Selected = Nothing
        Me.ButtonManualXplus.IconMarginLeft = 0
        Me.ButtonManualXplus.IconMarginRight = 0
        Me.ButtonManualXplus.IconRightVisible = False
        Me.ButtonManualXplus.IconRightZoom = 0R
        Me.ButtonManualXplus.IconVisible = True
        Me.ButtonManualXplus.IconZoom = 50.0R
        Me.ButtonManualXplus.IsTab = False
        Me.ButtonManualXplus.Location = New System.Drawing.Point(159, 164)
        Me.ButtonManualXplus.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonManualXplus.Name = "ButtonManualXplus"
        Me.ButtonManualXplus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXplus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonManualXplus.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonManualXplus.selected = False
        Me.ButtonManualXplus.Size = New System.Drawing.Size(48, 48)
        Me.ButtonManualXplus.TabIndex = 17
        Me.ButtonManualXplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonManualXplus.Textcolor = System.Drawing.Color.White
        Me.ButtonManualXplus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelManualXmin
        '
        Me.LabelManualXmin.AutoSize = True
        Me.LabelManualXmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualXmin.ForeColor = System.Drawing.Color.Black
        Me.LabelManualXmin.Location = New System.Drawing.Point(12, 178)
        Me.LabelManualXmin.Name = "LabelManualXmin"
        Me.LabelManualXmin.Size = New System.Drawing.Size(27, 20)
        Me.LabelManualXmin.TabIndex = 20
        Me.LabelManualXmin.Text = "X-"
        '
        'LabelManualXplus
        '
        Me.LabelManualXplus.AutoSize = True
        Me.LabelManualXplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualXplus.ForeColor = System.Drawing.Color.Black
        Me.LabelManualXplus.Location = New System.Drawing.Point(210, 178)
        Me.LabelManualXplus.Name = "LabelManualXplus"
        Me.LabelManualXplus.Size = New System.Drawing.Size(31, 20)
        Me.LabelManualXplus.TabIndex = 18
        Me.LabelManualXplus.Text = "X+"
        '
        'LabelManualYmin
        '
        Me.LabelManualYmin.AutoSize = True
        Me.LabelManualYmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelManualYmin.ForeColor = System.Drawing.Color.Black
        Me.LabelManualYmin.Location = New System.Drawing.Point(113, 215)
        Me.LabelManualYmin.Name = "LabelManualYmin"
        Me.LabelManualYmin.Size = New System.Drawing.Size(27, 20)
        Me.LabelManualYmin.TabIndex = 19
        Me.LabelManualYmin.Text = "Y-"
        '
        'TabPageAuto
        '
        Me.TabPageAuto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageAuto.Controls.Add(Me.GroupBox3)
        Me.TabPageAuto.Controls.Add(Me.ButtonGcodeRun)
        Me.TabPageAuto.Controls.Add(Me.GroupBoxGcode)
        Me.TabPageAuto.Controls.Add(Me.GroupBoxFile)
        Me.TabPageAuto.Controls.Add(Me.GroupBox1)
        Me.TabPageAuto.HorizontalScrollbarBarColor = True
        Me.TabPageAuto.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageAuto.HorizontalScrollbarSize = 10
        Me.TabPageAuto.Location = New System.Drawing.Point(4, 41)
        Me.TabPageAuto.Name = "TabPageAuto"
        Me.TabPageAuto.Size = New System.Drawing.Size(486, 560)
        Me.TabPageAuto.TabIndex = 3
        Me.TabPageAuto.Text = "AUTO"
        Me.TabPageAuto.UseCustomBackColor = True
        Me.TabPageAuto.VerticalScrollbarBarColor = True
        Me.TabPageAuto.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageAuto.VerticalScrollbarSize = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.LabelAutoSpindleRPM)
        Me.GroupBox3.Controls.Add(Me.LabelAutoFeedrateMMMIN)
        Me.GroupBox3.Controls.Add(Me.LabelAutoSpindle)
        Me.GroupBox3.Controls.Add(Me.TextboxAutoSpindle)
        Me.GroupBox3.Controls.Add(Me.LabelAutoFeedrate)
        Me.GroupBox3.Controls.Add(Me.TextboxAutoFeedrate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(17, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(451, 71)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SPEED"
        '
        'LabelAutoSpindleRPM
        '
        Me.LabelAutoSpindleRPM.AutoSize = True
        Me.LabelAutoSpindleRPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutoSpindleRPM.ForeColor = System.Drawing.Color.Black
        Me.LabelAutoSpindleRPM.Location = New System.Drawing.Point(388, 29)
        Me.LabelAutoSpindleRPM.Name = "LabelAutoSpindleRPM"
        Me.LabelAutoSpindleRPM.Size = New System.Drawing.Size(39, 20)
        Me.LabelAutoSpindleRPM.TabIndex = 33
        Me.LabelAutoSpindleRPM.Text = "rpm"
        '
        'LabelAutoFeedrateMMMIN
        '
        Me.LabelAutoFeedrateMMMIN.AutoSize = True
        Me.LabelAutoFeedrateMMMIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutoFeedrateMMMIN.ForeColor = System.Drawing.Color.Black
        Me.LabelAutoFeedrateMMMIN.Location = New System.Drawing.Point(153, 29)
        Me.LabelAutoFeedrateMMMIN.Name = "LabelAutoFeedrateMMMIN"
        Me.LabelAutoFeedrateMMMIN.Size = New System.Drawing.Size(70, 20)
        Me.LabelAutoFeedrateMMMIN.TabIndex = 32
        Me.LabelAutoFeedrateMMMIN.Text = "mm/min"
        '
        'LabelAutoSpindle
        '
        Me.LabelAutoSpindle.AutoSize = True
        Me.LabelAutoSpindle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutoSpindle.ForeColor = System.Drawing.Color.Black
        Me.LabelAutoSpindle.Location = New System.Drawing.Point(249, 31)
        Me.LabelAutoSpindle.Name = "LabelAutoSpindle"
        Me.LabelAutoSpindle.Size = New System.Drawing.Size(26, 20)
        Me.LabelAutoSpindle.TabIndex = 31
        Me.LabelAutoSpindle.Text = "S:"
        '
        'TextboxAutoSpindle
        '
        Me.TextboxAutoSpindle.BackColor = System.Drawing.Color.White
        Me.TextboxAutoSpindle.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxAutoSpindle.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxAutoSpindle.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxAutoSpindle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxAutoSpindle.BorderThickness = 4
        Me.TextboxAutoSpindle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxAutoSpindle.Enabled = False
        Me.TextboxAutoSpindle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxAutoSpindle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxAutoSpindle.isPassword = False
        Me.TextboxAutoSpindle.Location = New System.Drawing.Point(279, 25)
        Me.TextboxAutoSpindle.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxAutoSpindle.Name = "TextboxAutoSpindle"
        Me.TextboxAutoSpindle.Size = New System.Drawing.Size(106, 31)
        Me.TextboxAutoSpindle.TabIndex = 30
        Me.TextboxAutoSpindle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelAutoFeedrate
        '
        Me.LabelAutoFeedrate.AutoSize = True
        Me.LabelAutoFeedrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutoFeedrate.ForeColor = System.Drawing.Color.Black
        Me.LabelAutoFeedrate.Location = New System.Drawing.Point(17, 31)
        Me.LabelAutoFeedrate.Name = "LabelAutoFeedrate"
        Me.LabelAutoFeedrate.Size = New System.Drawing.Size(25, 20)
        Me.LabelAutoFeedrate.TabIndex = 29
        Me.LabelAutoFeedrate.Text = "F:"
        '
        'TextboxAutoFeedrate
        '
        Me.TextboxAutoFeedrate.BackColor = System.Drawing.Color.White
        Me.TextboxAutoFeedrate.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxAutoFeedrate.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxAutoFeedrate.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxAutoFeedrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxAutoFeedrate.BorderThickness = 4
        Me.TextboxAutoFeedrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxAutoFeedrate.Enabled = False
        Me.TextboxAutoFeedrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxAutoFeedrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxAutoFeedrate.isPassword = False
        Me.TextboxAutoFeedrate.Location = New System.Drawing.Point(46, 25)
        Me.TextboxAutoFeedrate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxAutoFeedrate.Name = "TextboxAutoFeedrate"
        Me.TextboxAutoFeedrate.Size = New System.Drawing.Size(106, 31)
        Me.TextboxAutoFeedrate.TabIndex = 28
        Me.TextboxAutoFeedrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonGcodeRun
        '
        Me.ButtonGcodeRun.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGcodeRun.BorderRadius = 4
        Me.ButtonGcodeRun.ButtonText = "RUN"
        Me.ButtonGcodeRun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGcodeRun.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGcodeRun.Enabled = False
        Me.ButtonGcodeRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGcodeRun.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGcodeRun.Iconimage = Nothing
        Me.ButtonGcodeRun.Iconimage_right = Nothing
        Me.ButtonGcodeRun.Iconimage_right_Selected = Nothing
        Me.ButtonGcodeRun.Iconimage_Selected = Nothing
        Me.ButtonGcodeRun.IconMarginLeft = 0
        Me.ButtonGcodeRun.IconMarginRight = 0
        Me.ButtonGcodeRun.IconRightVisible = False
        Me.ButtonGcodeRun.IconRightZoom = 0R
        Me.ButtonGcodeRun.IconVisible = False
        Me.ButtonGcodeRun.IconZoom = 90.0R
        Me.ButtonGcodeRun.IsTab = False
        Me.ButtonGcodeRun.Location = New System.Drawing.Point(17, 499)
        Me.ButtonGcodeRun.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGcodeRun.Name = "ButtonGcodeRun"
        Me.ButtonGcodeRun.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeRun.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeRun.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGcodeRun.selected = False
        Me.ButtonGcodeRun.Size = New System.Drawing.Size(451, 48)
        Me.ButtonGcodeRun.TabIndex = 10
        Me.ButtonGcodeRun.Text = "RUN"
        Me.ButtonGcodeRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGcodeRun.Textcolor = System.Drawing.Color.White
        Me.ButtonGcodeRun.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBoxGcode
        '
        Me.GroupBoxGcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GroupBoxGcode.Controls.Add(Me.ButtonGcodeSaveAs)
        Me.GroupBoxGcode.Controls.Add(Me.RichTextBoxGCode)
        Me.GroupBoxGcode.Controls.Add(Me.ButtonOpenFusion)
        Me.GroupBoxGcode.Controls.Add(Me.ButtonGcodeNew)
        Me.GroupBoxGcode.Controls.Add(Me.ButtonGcodeSave)
        Me.GroupBoxGcode.Controls.Add(Me.ButtonGcodeEdit)
        Me.GroupBoxGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxGcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxGcode.Location = New System.Drawing.Point(17, 248)
        Me.GroupBoxGcode.Name = "GroupBoxGcode"
        Me.GroupBoxGcode.Size = New System.Drawing.Size(451, 242)
        Me.GroupBoxGcode.TabIndex = 35
        Me.GroupBoxGcode.TabStop = False
        Me.GroupBoxGcode.Text = "G-CODE"
        '
        'ButtonGcodeSaveAs
        '
        Me.ButtonGcodeSaveAs.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGcodeSaveAs.BorderRadius = 4
        Me.ButtonGcodeSaveAs.ButtonText = "SAVE AS"
        Me.ButtonGcodeSaveAs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGcodeSaveAs.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGcodeSaveAs.Enabled = False
        Me.ButtonGcodeSaveAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGcodeSaveAs.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGcodeSaveAs.Iconimage = Nothing
        Me.ButtonGcodeSaveAs.Iconimage_right = Nothing
        Me.ButtonGcodeSaveAs.Iconimage_right_Selected = Nothing
        Me.ButtonGcodeSaveAs.Iconimage_Selected = Nothing
        Me.ButtonGcodeSaveAs.IconMarginLeft = 0
        Me.ButtonGcodeSaveAs.IconMarginRight = 0
        Me.ButtonGcodeSaveAs.IconRightVisible = False
        Me.ButtonGcodeSaveAs.IconRightZoom = 0R
        Me.ButtonGcodeSaveAs.IconVisible = False
        Me.ButtonGcodeSaveAs.IconZoom = 90.0R
        Me.ButtonGcodeSaveAs.IsTab = False
        Me.ButtonGcodeSaveAs.Location = New System.Drawing.Point(323, 150)
        Me.ButtonGcodeSaveAs.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGcodeSaveAs.Name = "ButtonGcodeSaveAs"
        Me.ButtonGcodeSaveAs.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSaveAs.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSaveAs.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGcodeSaveAs.selected = False
        Me.ButtonGcodeSaveAs.Size = New System.Drawing.Size(107, 35)
        Me.ButtonGcodeSaveAs.TabIndex = 34
        Me.ButtonGcodeSaveAs.Text = "SAVE AS"
        Me.ButtonGcodeSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGcodeSaveAs.Textcolor = System.Drawing.Color.White
        Me.ButtonGcodeSaveAs.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RichTextBoxGCode
        '
        Me.RichTextBoxGCode.Location = New System.Drawing.Point(20, 28)
        Me.RichTextBoxGCode.Name = "RichTextBoxGCode"
        Me.RichTextBoxGCode.ReadOnly = True
        Me.RichTextBoxGCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxGCode.Size = New System.Drawing.Size(293, 198)
        Me.RichTextBoxGCode.TabIndex = 9
        Me.RichTextBoxGCode.Text = ""
        '
        'ButtonOpenFusion
        '
        Me.ButtonOpenFusion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonOpenFusion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonOpenFusion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonOpenFusion.BorderRadius = 4
        Me.ButtonOpenFusion.ButtonText = "FUSION"
        Me.ButtonOpenFusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOpenFusion.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonOpenFusion.Enabled = False
        Me.ButtonOpenFusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpenFusion.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonOpenFusion.Iconimage = Nothing
        Me.ButtonOpenFusion.Iconimage_right = Nothing
        Me.ButtonOpenFusion.Iconimage_right_Selected = Nothing
        Me.ButtonOpenFusion.Iconimage_Selected = Nothing
        Me.ButtonOpenFusion.IconMarginLeft = 0
        Me.ButtonOpenFusion.IconMarginRight = 0
        Me.ButtonOpenFusion.IconRightVisible = False
        Me.ButtonOpenFusion.IconRightZoom = 0R
        Me.ButtonOpenFusion.IconVisible = False
        Me.ButtonOpenFusion.IconZoom = 90.0R
        Me.ButtonOpenFusion.IsTab = False
        Me.ButtonOpenFusion.Location = New System.Drawing.Point(323, 28)
        Me.ButtonOpenFusion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonOpenFusion.Name = "ButtonOpenFusion"
        Me.ButtonOpenFusion.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonOpenFusion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonOpenFusion.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonOpenFusion.selected = False
        Me.ButtonOpenFusion.Size = New System.Drawing.Size(107, 35)
        Me.ButtonOpenFusion.TabIndex = 32
        Me.ButtonOpenFusion.Text = "FUSION"
        Me.ButtonOpenFusion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonOpenFusion.Textcolor = System.Drawing.Color.White
        Me.ButtonOpenFusion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonGcodeNew
        '
        Me.ButtonGcodeNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGcodeNew.BorderRadius = 4
        Me.ButtonGcodeNew.ButtonText = "NEW"
        Me.ButtonGcodeNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGcodeNew.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGcodeNew.Enabled = False
        Me.ButtonGcodeNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGcodeNew.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGcodeNew.Iconimage = Nothing
        Me.ButtonGcodeNew.Iconimage_right = Nothing
        Me.ButtonGcodeNew.Iconimage_right_Selected = Nothing
        Me.ButtonGcodeNew.Iconimage_Selected = Nothing
        Me.ButtonGcodeNew.IconMarginLeft = 0
        Me.ButtonGcodeNew.IconMarginRight = 0
        Me.ButtonGcodeNew.IconRightVisible = False
        Me.ButtonGcodeNew.IconRightZoom = 0R
        Me.ButtonGcodeNew.IconVisible = False
        Me.ButtonGcodeNew.IconZoom = 90.0R
        Me.ButtonGcodeNew.IsTab = False
        Me.ButtonGcodeNew.Location = New System.Drawing.Point(323, 68)
        Me.ButtonGcodeNew.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGcodeNew.Name = "ButtonGcodeNew"
        Me.ButtonGcodeNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeNew.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGcodeNew.selected = False
        Me.ButtonGcodeNew.Size = New System.Drawing.Size(107, 35)
        Me.ButtonGcodeNew.TabIndex = 30
        Me.ButtonGcodeNew.Text = "NEW"
        Me.ButtonGcodeNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGcodeNew.Textcolor = System.Drawing.Color.White
        Me.ButtonGcodeNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonGcodeSave
        '
        Me.ButtonGcodeSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGcodeSave.BorderRadius = 4
        Me.ButtonGcodeSave.ButtonText = "SAVE"
        Me.ButtonGcodeSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGcodeSave.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGcodeSave.Enabled = False
        Me.ButtonGcodeSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGcodeSave.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGcodeSave.Iconimage = Nothing
        Me.ButtonGcodeSave.Iconimage_right = Nothing
        Me.ButtonGcodeSave.Iconimage_right_Selected = Nothing
        Me.ButtonGcodeSave.Iconimage_Selected = Nothing
        Me.ButtonGcodeSave.IconMarginLeft = 0
        Me.ButtonGcodeSave.IconMarginRight = 0
        Me.ButtonGcodeSave.IconRightVisible = False
        Me.ButtonGcodeSave.IconRightZoom = 0R
        Me.ButtonGcodeSave.IconVisible = False
        Me.ButtonGcodeSave.IconZoom = 90.0R
        Me.ButtonGcodeSave.IsTab = False
        Me.ButtonGcodeSave.Location = New System.Drawing.Point(323, 191)
        Me.ButtonGcodeSave.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGcodeSave.Name = "ButtonGcodeSave"
        Me.ButtonGcodeSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeSave.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGcodeSave.selected = False
        Me.ButtonGcodeSave.Size = New System.Drawing.Size(107, 35)
        Me.ButtonGcodeSave.TabIndex = 33
        Me.ButtonGcodeSave.Text = "SAVE"
        Me.ButtonGcodeSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGcodeSave.Textcolor = System.Drawing.Color.White
        Me.ButtonGcodeSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonGcodeEdit
        '
        Me.ButtonGcodeEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGcodeEdit.BorderRadius = 4
        Me.ButtonGcodeEdit.ButtonText = "EDIT"
        Me.ButtonGcodeEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGcodeEdit.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGcodeEdit.Enabled = False
        Me.ButtonGcodeEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGcodeEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGcodeEdit.Iconimage = Nothing
        Me.ButtonGcodeEdit.Iconimage_right = Nothing
        Me.ButtonGcodeEdit.Iconimage_right_Selected = Nothing
        Me.ButtonGcodeEdit.Iconimage_Selected = Nothing
        Me.ButtonGcodeEdit.IconMarginLeft = 0
        Me.ButtonGcodeEdit.IconMarginRight = 0
        Me.ButtonGcodeEdit.IconRightVisible = False
        Me.ButtonGcodeEdit.IconRightZoom = 0R
        Me.ButtonGcodeEdit.IconVisible = False
        Me.ButtonGcodeEdit.IconZoom = 90.0R
        Me.ButtonGcodeEdit.IsTab = False
        Me.ButtonGcodeEdit.Location = New System.Drawing.Point(323, 109)
        Me.ButtonGcodeEdit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGcodeEdit.Name = "ButtonGcodeEdit"
        Me.ButtonGcodeEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGcodeEdit.selected = False
        Me.ButtonGcodeEdit.Size = New System.Drawing.Size(107, 35)
        Me.ButtonGcodeEdit.TabIndex = 31
        Me.ButtonGcodeEdit.Text = "EDIT"
        Me.ButtonGcodeEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGcodeEdit.Textcolor = System.Drawing.Color.White
        Me.ButtonGcodeEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBoxFile
        '
        Me.GroupBoxFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GroupBoxFile.Controls.Add(Me.ButtonGcodeBrowse)
        Me.GroupBoxFile.Controls.Add(Me.TextBoxGcodeFile)
        Me.GroupBoxFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxFile.Location = New System.Drawing.Point(17, 171)
        Me.GroupBoxFile.Name = "GroupBoxFile"
        Me.GroupBoxFile.Size = New System.Drawing.Size(451, 70)
        Me.GroupBoxFile.TabIndex = 36
        Me.GroupBoxFile.TabStop = False
        Me.GroupBoxFile.Text = "OPEN FILE"
        '
        'ButtonGcodeBrowse
        '
        Me.ButtonGcodeBrowse.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonGcodeBrowse.BorderRadius = 4
        Me.ButtonGcodeBrowse.ButtonText = "BROWSE"
        Me.ButtonGcodeBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGcodeBrowse.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGcodeBrowse.Enabled = False
        Me.ButtonGcodeBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGcodeBrowse.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonGcodeBrowse.Iconimage = Nothing
        Me.ButtonGcodeBrowse.Iconimage_right = Nothing
        Me.ButtonGcodeBrowse.Iconimage_right_Selected = Nothing
        Me.ButtonGcodeBrowse.Iconimage_Selected = Nothing
        Me.ButtonGcodeBrowse.IconMarginLeft = 0
        Me.ButtonGcodeBrowse.IconMarginRight = 0
        Me.ButtonGcodeBrowse.IconRightVisible = False
        Me.ButtonGcodeBrowse.IconRightZoom = 0R
        Me.ButtonGcodeBrowse.IconVisible = False
        Me.ButtonGcodeBrowse.IconZoom = 90.0R
        Me.ButtonGcodeBrowse.IsTab = False
        Me.ButtonGcodeBrowse.Location = New System.Drawing.Point(323, 23)
        Me.ButtonGcodeBrowse.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonGcodeBrowse.Name = "ButtonGcodeBrowse"
        Me.ButtonGcodeBrowse.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeBrowse.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGcodeBrowse.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonGcodeBrowse.selected = False
        Me.ButtonGcodeBrowse.Size = New System.Drawing.Size(107, 35)
        Me.ButtonGcodeBrowse.TabIndex = 29
        Me.ButtonGcodeBrowse.Text = "BROWSE"
        Me.ButtonGcodeBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonGcodeBrowse.Textcolor = System.Drawing.Color.White
        Me.ButtonGcodeBrowse.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextBoxGcodeFile
        '
        Me.TextBoxGcodeFile.BackColor = System.Drawing.Color.White
        Me.TextBoxGcodeFile.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextBoxGcodeFile.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextBoxGcodeFile.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextBoxGcodeFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxGcodeFile.BorderThickness = 4
        Me.TextBoxGcodeFile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxGcodeFile.Enabled = False
        Me.TextBoxGcodeFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGcodeFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxGcodeFile.isPassword = False
        Me.TextBoxGcodeFile.Location = New System.Drawing.Point(21, 25)
        Me.TextBoxGcodeFile.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextBoxGcodeFile.Name = "TextBoxGcodeFile"
        Me.TextBoxGcodeFile.Size = New System.Drawing.Size(292, 31)
        Me.TextBoxGcodeFile.TabIndex = 34
        Me.TextBoxGcodeFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TextboxGcodeShow)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 71)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "WORKING G-CODE"
        '
        'TextboxGcodeShow
        '
        Me.TextboxGcodeShow.BackColor = System.Drawing.Color.White
        Me.TextboxGcodeShow.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxGcodeShow.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxGcodeShow.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxGcodeShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxGcodeShow.BorderThickness = 4
        Me.TextboxGcodeShow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxGcodeShow.Enabled = False
        Me.TextboxGcodeShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxGcodeShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxGcodeShow.isPassword = False
        Me.TextboxGcodeShow.Location = New System.Drawing.Point(20, 24)
        Me.TextboxGcodeShow.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxGcodeShow.Name = "TextboxGcodeShow"
        Me.TextboxGcodeShow.Size = New System.Drawing.Size(410, 31)
        Me.TextboxGcodeShow.TabIndex = 28
        Me.TextboxGcodeShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabTiga
        '
        Me.TabTiga.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabTiga.Controls.Add(Me.TabPageWorkingCoord)
        Me.TabTiga.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.TabTiga.Location = New System.Drawing.Point(28, 467)
        Me.TabTiga.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabTiga.Multiline = True
        Me.TabTiga.Name = "TabTiga"
        Me.TabTiga.SelectedIndex = 0
        Me.TabTiga.Size = New System.Drawing.Size(183, 208)
        Me.TabTiga.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabTiga.TabIndex = 2
        Me.TabTiga.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabTiga.UseSelectable = True
        '
        'TabPageWorkingCoord
        '
        Me.TabPageWorkingCoord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageWorkingCoord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageWorkingCoord.Controls.Add(Me.LabelWorkingZ)
        Me.TabPageWorkingCoord.Controls.Add(Me.TextboxWorkingZ)
        Me.TabPageWorkingCoord.Controls.Add(Me.LabelWorkingY)
        Me.TabPageWorkingCoord.Controls.Add(Me.TextboxWorkingY)
        Me.TabPageWorkingCoord.Controls.Add(Me.LabelWorkingX)
        Me.TabPageWorkingCoord.Controls.Add(Me.TextboxWorkingX)
        Me.TabPageWorkingCoord.HorizontalScrollbarBarColor = True
        Me.TabPageWorkingCoord.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageWorkingCoord.HorizontalScrollbarSize = 10
        Me.TabPageWorkingCoord.Location = New System.Drawing.Point(4, 41)
        Me.TabPageWorkingCoord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageWorkingCoord.Name = "TabPageWorkingCoord"
        Me.TabPageWorkingCoord.Size = New System.Drawing.Size(175, 163)
        Me.TabPageWorkingCoord.TabIndex = 2
        Me.TabPageWorkingCoord.Text = "WORKING COORDINATE"
        Me.TabPageWorkingCoord.UseCustomBackColor = True
        Me.TabPageWorkingCoord.VerticalScrollbarBarColor = True
        Me.TabPageWorkingCoord.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageWorkingCoord.VerticalScrollbarSize = 3
        '
        'LabelWorkingZ
        '
        Me.LabelWorkingZ.AutoSize = True
        Me.LabelWorkingZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkingZ.ForeColor = System.Drawing.Color.Black
        Me.LabelWorkingZ.Location = New System.Drawing.Point(15, 115)
        Me.LabelWorkingZ.Name = "LabelWorkingZ"
        Me.LabelWorkingZ.Size = New System.Drawing.Size(25, 20)
        Me.LabelWorkingZ.TabIndex = 8
        Me.LabelWorkingZ.Text = "Z:"
        '
        'TextboxWorkingZ
        '
        Me.TextboxWorkingZ.BackColor = System.Drawing.Color.White
        Me.TextboxWorkingZ.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxWorkingZ.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxWorkingZ.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxWorkingZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxWorkingZ.BorderThickness = 4
        Me.TextboxWorkingZ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxWorkingZ.Enabled = False
        Me.TextboxWorkingZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxWorkingZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxWorkingZ.isPassword = False
        Me.TextboxWorkingZ.Location = New System.Drawing.Point(47, 108)
        Me.TextboxWorkingZ.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxWorkingZ.Name = "TextboxWorkingZ"
        Me.TextboxWorkingZ.Size = New System.Drawing.Size(105, 37)
        Me.TextboxWorkingZ.TabIndex = 9
        Me.TextboxWorkingZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelWorkingY
        '
        Me.LabelWorkingY.AutoSize = True
        Me.LabelWorkingY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkingY.ForeColor = System.Drawing.Color.Black
        Me.LabelWorkingY.Location = New System.Drawing.Point(15, 68)
        Me.LabelWorkingY.Name = "LabelWorkingY"
        Me.LabelWorkingY.Size = New System.Drawing.Size(26, 20)
        Me.LabelWorkingY.TabIndex = 6
        Me.LabelWorkingY.Text = "Y:"
        '
        'TextboxWorkingY
        '
        Me.TextboxWorkingY.BackColor = System.Drawing.Color.White
        Me.TextboxWorkingY.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxWorkingY.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxWorkingY.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxWorkingY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxWorkingY.BorderThickness = 4
        Me.TextboxWorkingY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxWorkingY.Enabled = False
        Me.TextboxWorkingY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxWorkingY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxWorkingY.isPassword = False
        Me.TextboxWorkingY.Location = New System.Drawing.Point(47, 61)
        Me.TextboxWorkingY.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxWorkingY.Name = "TextboxWorkingY"
        Me.TextboxWorkingY.Size = New System.Drawing.Size(105, 37)
        Me.TextboxWorkingY.TabIndex = 7
        Me.TextboxWorkingY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelWorkingX
        '
        Me.LabelWorkingX.AutoSize = True
        Me.LabelWorkingX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWorkingX.ForeColor = System.Drawing.Color.Black
        Me.LabelWorkingX.Location = New System.Drawing.Point(15, 21)
        Me.LabelWorkingX.Name = "LabelWorkingX"
        Me.LabelWorkingX.Size = New System.Drawing.Size(26, 20)
        Me.LabelWorkingX.TabIndex = 5
        Me.LabelWorkingX.Text = "X:"
        '
        'TextboxWorkingX
        '
        Me.TextboxWorkingX.BackColor = System.Drawing.Color.White
        Me.TextboxWorkingX.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxWorkingX.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxWorkingX.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxWorkingX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxWorkingX.BorderThickness = 4
        Me.TextboxWorkingX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxWorkingX.Enabled = False
        Me.TextboxWorkingX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxWorkingX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxWorkingX.isPassword = False
        Me.TextboxWorkingX.Location = New System.Drawing.Point(47, 14)
        Me.TextboxWorkingX.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxWorkingX.Name = "TextboxWorkingX"
        Me.TextboxWorkingX.Size = New System.Drawing.Size(105, 37)
        Me.TextboxWorkingX.TabIndex = 5
        Me.TextboxWorkingX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabEmpat
        '
        Me.TabEmpat.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabEmpat.Controls.Add(Me.TabPageSpeed)
        Me.TabEmpat.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.TabEmpat.Location = New System.Drawing.Point(222, 467)
        Me.TabEmpat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabEmpat.Multiline = True
        Me.TabEmpat.Name = "TabEmpat"
        Me.TabEmpat.SelectedIndex = 0
        Me.TabEmpat.Size = New System.Drawing.Size(183, 208)
        Me.TabEmpat.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabEmpat.TabIndex = 3
        Me.TabEmpat.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabEmpat.UseSelectable = True
        '
        'TabPageSpeed
        '
        Me.TabPageSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageSpeed.Controls.Add(Me.LabelMachineY)
        Me.TabPageSpeed.Controls.Add(Me.TextboxWorkingRPM)
        Me.TabPageSpeed.Controls.Add(Me.LabelMachineX)
        Me.TabPageSpeed.Controls.Add(Me.TextboxWorkingFeedrate)
        Me.TabPageSpeed.HorizontalScrollbarBarColor = True
        Me.TabPageSpeed.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageSpeed.HorizontalScrollbarSize = 10
        Me.TabPageSpeed.Location = New System.Drawing.Point(4, 41)
        Me.TabPageSpeed.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageSpeed.Name = "TabPageSpeed"
        Me.TabPageSpeed.Size = New System.Drawing.Size(175, 163)
        Me.TabPageSpeed.TabIndex = 2
        Me.TabPageSpeed.Text = "WORKING SPEED"
        Me.TabPageSpeed.UseCustomBackColor = True
        Me.TabPageSpeed.VerticalScrollbarBarColor = True
        Me.TabPageSpeed.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageSpeed.VerticalScrollbarSize = 3
        '
        'LabelMachineY
        '
        Me.LabelMachineY.AutoSize = True
        Me.LabelMachineY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMachineY.ForeColor = System.Drawing.Color.Black
        Me.LabelMachineY.Location = New System.Drawing.Point(20, 82)
        Me.LabelMachineY.Name = "LabelMachineY"
        Me.LabelMachineY.Size = New System.Drawing.Size(52, 20)
        Me.LabelMachineY.TabIndex = 12
        Me.LabelMachineY.Text = "RPM:"
        '
        'TextboxWorkingRPM
        '
        Me.TextboxWorkingRPM.BackColor = System.Drawing.Color.White
        Me.TextboxWorkingRPM.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxWorkingRPM.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxWorkingRPM.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxWorkingRPM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxWorkingRPM.BorderThickness = 4
        Me.TextboxWorkingRPM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxWorkingRPM.Enabled = False
        Me.TextboxWorkingRPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxWorkingRPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxWorkingRPM.isPassword = False
        Me.TextboxWorkingRPM.Location = New System.Drawing.Point(23, 109)
        Me.TextboxWorkingRPM.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxWorkingRPM.Name = "TextboxWorkingRPM"
        Me.TextboxWorkingRPM.Size = New System.Drawing.Size(130, 37)
        Me.TextboxWorkingRPM.TabIndex = 13
        Me.TextboxWorkingRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMachineX
        '
        Me.LabelMachineX.AutoSize = True
        Me.LabelMachineX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMachineX.ForeColor = System.Drawing.Color.Black
        Me.LabelMachineX.Location = New System.Drawing.Point(19, 11)
        Me.LabelMachineX.Name = "LabelMachineX"
        Me.LabelMachineX.Size = New System.Drawing.Size(56, 20)
        Me.LabelMachineX.TabIndex = 10
        Me.LabelMachineX.Text = "AXIS:"
        '
        'TextboxWorkingFeedrate
        '
        Me.TextboxWorkingFeedrate.BackColor = System.Drawing.Color.White
        Me.TextboxWorkingFeedrate.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TextboxWorkingFeedrate.BorderColorIdle = System.Drawing.Color.Transparent
        Me.TextboxWorkingFeedrate.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TextboxWorkingFeedrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextboxWorkingFeedrate.BorderThickness = 4
        Me.TextboxWorkingFeedrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxWorkingFeedrate.Enabled = False
        Me.TextboxWorkingFeedrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxWorkingFeedrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextboxWorkingFeedrate.isPassword = False
        Me.TextboxWorkingFeedrate.Location = New System.Drawing.Point(23, 36)
        Me.TextboxWorkingFeedrate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextboxWorkingFeedrate.Name = "TextboxWorkingFeedrate"
        Me.TextboxWorkingFeedrate.Size = New System.Drawing.Size(130, 37)
        Me.TextboxWorkingFeedrate.TabIndex = 11
        Me.TextboxWorkingFeedrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabLima
        '
        Me.TabLima.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabLima.Controls.Add(Me.TabPageControl)
        Me.TabLima.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.TabLima.Location = New System.Drawing.Point(28, 270)
        Me.TabLima.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabLima.Multiline = True
        Me.TabLima.Name = "TabLima"
        Me.TabLima.SelectedIndex = 0
        Me.TabLima.Size = New System.Drawing.Size(377, 191)
        Me.TabLima.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabLima.TabIndex = 5
        Me.TabLima.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabLima.UseSelectable = True
        '
        'TabPageControl
        '
        Me.TabPageControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageControl.Controls.Add(Me.ButtonResume)
        Me.TabPageControl.Controls.Add(Me.ButtonEmergency)
        Me.TabPageControl.Controls.Add(Me.ButtonPause)
        Me.TabPageControl.Controls.Add(Me.ButtonReset)
        Me.TabPageControl.HorizontalScrollbarBarColor = True
        Me.TabPageControl.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageControl.HorizontalScrollbarSize = 10
        Me.TabPageControl.Location = New System.Drawing.Point(4, 41)
        Me.TabPageControl.Name = "TabPageControl"
        Me.TabPageControl.Size = New System.Drawing.Size(369, 146)
        Me.TabPageControl.TabIndex = 4
        Me.TabPageControl.Text = "CONTROL"
        Me.TabPageControl.UseCustomBackColor = True
        Me.TabPageControl.VerticalScrollbarBarColor = True
        Me.TabPageControl.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageControl.VerticalScrollbarSize = 3
        '
        'ButtonResume
        '
        Me.ButtonResume.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResume.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonResume.BorderRadius = 4
        Me.ButtonResume.ButtonText = "RESUME"
        Me.ButtonResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonResume.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonResume.Enabled = False
        Me.ButtonResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResume.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonResume.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_play_circle_o
        Me.ButtonResume.Iconimage_right = Nothing
        Me.ButtonResume.Iconimage_right_Selected = Nothing
        Me.ButtonResume.Iconimage_Selected = Nothing
        Me.ButtonResume.IconMarginLeft = 0
        Me.ButtonResume.IconMarginRight = 0
        Me.ButtonResume.IconRightVisible = False
        Me.ButtonResume.IconRightZoom = 0R
        Me.ButtonResume.IconVisible = True
        Me.ButtonResume.IconZoom = 70.0R
        Me.ButtonResume.IsTab = False
        Me.ButtonResume.Location = New System.Drawing.Point(190, 78)
        Me.ButtonResume.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonResume.Name = "ButtonResume"
        Me.ButtonResume.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResume.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResume.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonResume.selected = False
        Me.ButtonResume.Size = New System.Drawing.Size(164, 60)
        Me.ButtonResume.TabIndex = 28
        Me.ButtonResume.Text = "RESUME"
        Me.ButtonResume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonResume.Textcolor = System.Drawing.Color.White
        Me.ButtonResume.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonEmergency
        '
        Me.ButtonEmergency.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEmergency.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEmergency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEmergency.BorderRadius = 4
        Me.ButtonEmergency.ButtonText = "EMERGENCY"
        Me.ButtonEmergency.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEmergency.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonEmergency.Enabled = False
        Me.ButtonEmergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEmergency.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonEmergency.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_stop_circle_o
        Me.ButtonEmergency.Iconimage_right = Nothing
        Me.ButtonEmergency.Iconimage_right_Selected = Nothing
        Me.ButtonEmergency.Iconimage_Selected = Nothing
        Me.ButtonEmergency.IconMarginLeft = 0
        Me.ButtonEmergency.IconMarginRight = 0
        Me.ButtonEmergency.IconRightVisible = False
        Me.ButtonEmergency.IconRightZoom = 0R
        Me.ButtonEmergency.IconVisible = True
        Me.ButtonEmergency.IconZoom = 70.0R
        Me.ButtonEmergency.IsTab = False
        Me.ButtonEmergency.Location = New System.Drawing.Point(16, 8)
        Me.ButtonEmergency.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonEmergency.Name = "ButtonEmergency"
        Me.ButtonEmergency.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEmergency.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEmergency.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonEmergency.selected = False
        Me.ButtonEmergency.Size = New System.Drawing.Size(163, 60)
        Me.ButtonEmergency.TabIndex = 26
        Me.ButtonEmergency.Text = "EMERGENCY"
        Me.ButtonEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonEmergency.Textcolor = System.Drawing.Color.White
        Me.ButtonEmergency.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonPause
        '
        Me.ButtonPause.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPause.BorderRadius = 4
        Me.ButtonPause.ButtonText = "PAUSE"
        Me.ButtonPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPause.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonPause.Enabled = False
        Me.ButtonPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPause.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonPause.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_pause_circle_o
        Me.ButtonPause.Iconimage_right = Nothing
        Me.ButtonPause.Iconimage_right_Selected = Nothing
        Me.ButtonPause.Iconimage_Selected = Nothing
        Me.ButtonPause.IconMarginLeft = 0
        Me.ButtonPause.IconMarginRight = 0
        Me.ButtonPause.IconRightVisible = False
        Me.ButtonPause.IconRightZoom = 0R
        Me.ButtonPause.IconVisible = True
        Me.ButtonPause.IconZoom = 70.0R
        Me.ButtonPause.IsTab = False
        Me.ButtonPause.Location = New System.Drawing.Point(16, 78)
        Me.ButtonPause.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPause.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPause.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonPause.selected = False
        Me.ButtonPause.Size = New System.Drawing.Size(163, 60)
        Me.ButtonPause.TabIndex = 27
        Me.ButtonPause.Text = "PAUSE"
        Me.ButtonPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonPause.Textcolor = System.Drawing.Color.White
        Me.ButtonPause.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonReset
        '
        Me.ButtonReset.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonReset.BorderRadius = 4
        Me.ButtonReset.ButtonText = "RESET"
        Me.ButtonReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReset.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonReset.Enabled = False
        Me.ButtonReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonReset.Iconimage = Global.c2.My.Resources.Resources.font_awesome_4_7_0_refresh
        Me.ButtonReset.Iconimage_right = Nothing
        Me.ButtonReset.Iconimage_right_Selected = Nothing
        Me.ButtonReset.Iconimage_Selected = Nothing
        Me.ButtonReset.IconMarginLeft = 0
        Me.ButtonReset.IconMarginRight = 0
        Me.ButtonReset.IconRightVisible = False
        Me.ButtonReset.IconRightZoom = 0R
        Me.ButtonReset.IconVisible = True
        Me.ButtonReset.IconZoom = 70.0R
        Me.ButtonReset.IsTab = False
        Me.ButtonReset.Location = New System.Drawing.Point(191, 8)
        Me.ButtonReset.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonReset.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonReset.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonReset.selected = False
        Me.ButtonReset.Size = New System.Drawing.Size(163, 60)
        Me.ButtonReset.TabIndex = 25
        Me.ButtonReset.Text = "RESET"
        Me.ButtonReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonReset.Textcolor = System.Drawing.Color.White
        Me.ButtonReset.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MegaSerialPort
        '
        '
        'LabelO
        '
        Me.LabelO.AutoSize = True
        Me.LabelO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LabelO.ForeColor = System.Drawing.Color.White
        Me.LabelO.Location = New System.Drawing.Point(41, 13)
        Me.LabelO.Name = "LabelO"
        Me.LabelO.Size = New System.Drawing.Size(14, 13)
        Me.LabelO.TabIndex = 9
        Me.LabelO.Text = "o"
        '
        'TabEnam
        '
        Me.TabEnam.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabEnam.Controls.Add(Me.TabPageAxisGraph)
        Me.TabEnam.Controls.Add(Me.TabPagePIDGraph)
        Me.TabEnam.Controls.Add(Me.TabPageDiagnostics)
        Me.TabEnam.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.TabEnam.Location = New System.Drawing.Point(411, 70)
        Me.TabEnam.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabEnam.Multiline = True
        Me.TabEnam.Name = "TabEnam"
        Me.TabEnam.SelectedIndex = 0
        Me.TabEnam.Size = New System.Drawing.Size(530, 566)
        Me.TabEnam.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabEnam.TabIndex = 11
        Me.TabEnam.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabEnam.UseSelectable = True
        '
        'TabPageAxisGraph
        '
        Me.TabPageAxisGraph.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageAxisGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageAxisGraph.Controls.Add(Me.PanelAxisGraph)
        Me.TabPageAxisGraph.HorizontalScrollbarBarColor = True
        Me.TabPageAxisGraph.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageAxisGraph.HorizontalScrollbarSize = 10
        Me.TabPageAxisGraph.Location = New System.Drawing.Point(4, 41)
        Me.TabPageAxisGraph.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageAxisGraph.Name = "TabPageAxisGraph"
        Me.TabPageAxisGraph.Size = New System.Drawing.Size(522, 521)
        Me.TabPageAxisGraph.TabIndex = 3
        Me.TabPageAxisGraph.Text = "AXIS"
        Me.TabPageAxisGraph.UseCustomBackColor = True
        Me.TabPageAxisGraph.VerticalScrollbarBarColor = True
        Me.TabPageAxisGraph.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageAxisGraph.VerticalScrollbarSize = 3
        '
        'PanelAxisGraph
        '
        Me.PanelAxisGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAxisGraph.Location = New System.Drawing.Point(0, 0)
        Me.PanelAxisGraph.Name = "PanelAxisGraph"
        Me.PanelAxisGraph.Size = New System.Drawing.Size(518, 517)
        Me.PanelAxisGraph.TabIndex = 2
        '
        'TabPagePIDGraph
        '
        Me.TabPagePIDGraph.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPagePIDGraph.Controls.Add(Me.PanelPidGraph)
        Me.TabPagePIDGraph.HorizontalScrollbarBarColor = True
        Me.TabPagePIDGraph.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPagePIDGraph.HorizontalScrollbarSize = 10
        Me.TabPagePIDGraph.Location = New System.Drawing.Point(4, 41)
        Me.TabPagePIDGraph.Name = "TabPagePIDGraph"
        Me.TabPagePIDGraph.Size = New System.Drawing.Size(522, 521)
        Me.TabPagePIDGraph.TabIndex = 4
        Me.TabPagePIDGraph.Text = "PID"
        Me.TabPagePIDGraph.UseCustomBackColor = True
        Me.TabPagePIDGraph.VerticalScrollbarBarColor = True
        Me.TabPagePIDGraph.VerticalScrollbarHighlightOnWheel = False
        Me.TabPagePIDGraph.VerticalScrollbarSize = 3
        '
        'PanelPidGraph
        '
        Me.PanelPidGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPidGraph.Location = New System.Drawing.Point(0, 0)
        Me.PanelPidGraph.Name = "PanelPidGraph"
        Me.PanelPidGraph.Size = New System.Drawing.Size(522, 521)
        Me.PanelPidGraph.TabIndex = 2
        '
        'TabPageDiagnostics
        '
        Me.TabPageDiagnostics.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TabPageDiagnostics.Controls.Add(Me.RichTextBoxKirim)
        Me.TabPageDiagnostics.Controls.Add(Me.RichTextBoxDiagnostics)
        Me.TabPageDiagnostics.HorizontalScrollbarBarColor = True
        Me.TabPageDiagnostics.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPageDiagnostics.HorizontalScrollbarSize = 10
        Me.TabPageDiagnostics.Location = New System.Drawing.Point(4, 41)
        Me.TabPageDiagnostics.Name = "TabPageDiagnostics"
        Me.TabPageDiagnostics.Size = New System.Drawing.Size(522, 521)
        Me.TabPageDiagnostics.TabIndex = 5
        Me.TabPageDiagnostics.Text = "MONITOR"
        Me.TabPageDiagnostics.UseCustomBackColor = True
        Me.TabPageDiagnostics.VerticalScrollbarBarColor = True
        Me.TabPageDiagnostics.VerticalScrollbarHighlightOnWheel = False
        Me.TabPageDiagnostics.VerticalScrollbarSize = 3
        '
        'RichTextBoxKirim
        '
        Me.RichTextBoxKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RichTextBoxKirim.Location = New System.Drawing.Point(3, 2)
        Me.RichTextBoxKirim.Name = "RichTextBoxKirim"
        Me.RichTextBoxKirim.ReadOnly = True
        Me.RichTextBoxKirim.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxKirim.Size = New System.Drawing.Size(516, 255)
        Me.RichTextBoxKirim.TabIndex = 12
        Me.RichTextBoxKirim.Text = ""
        '
        'RichTextBoxDiagnostics
        '
        Me.RichTextBoxDiagnostics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RichTextBoxDiagnostics.Location = New System.Drawing.Point(3, 263)
        Me.RichTextBoxDiagnostics.Name = "RichTextBoxDiagnostics"
        Me.RichTextBoxDiagnostics.ReadOnly = True
        Me.RichTextBoxDiagnostics.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxDiagnostics.Size = New System.Drawing.Size(516, 255)
        Me.RichTextBoxDiagnostics.TabIndex = 11
        Me.RichTextBoxDiagnostics.Text = ""
        '
        'ButtonResetGraph
        '
        Me.ButtonResetGraph.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResetGraph.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResetGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonResetGraph.BorderRadius = 4
        Me.ButtonResetGraph.ButtonText = "RESET GRAPH"
        Me.ButtonResetGraph.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonResetGraph.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonResetGraph.Enabled = False
        Me.ButtonResetGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResetGraph.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonResetGraph.Iconimage = Nothing
        Me.ButtonResetGraph.Iconimage_right = Nothing
        Me.ButtonResetGraph.Iconimage_right_Selected = Nothing
        Me.ButtonResetGraph.Iconimage_Selected = Nothing
        Me.ButtonResetGraph.IconMarginLeft = 0
        Me.ButtonResetGraph.IconMarginRight = 0
        Me.ButtonResetGraph.IconRightVisible = False
        Me.ButtonResetGraph.IconRightZoom = 0R
        Me.ButtonResetGraph.IconVisible = True
        Me.ButtonResetGraph.IconZoom = 35.0R
        Me.ButtonResetGraph.IsTab = False
        Me.ButtonResetGraph.Location = New System.Drawing.Point(417, 644)
        Me.ButtonResetGraph.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonResetGraph.Name = "ButtonResetGraph"
        Me.ButtonResetGraph.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResetGraph.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResetGraph.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonResetGraph.selected = False
        Me.ButtonResetGraph.Size = New System.Drawing.Size(255, 27)
        Me.ButtonResetGraph.TabIndex = 18
        Me.ButtonResetGraph.Text = "RESET GRAPH"
        Me.ButtonResetGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonResetGraph.Textcolor = System.Drawing.Color.White
        Me.ButtonResetGraph.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'OpenFileGcode
        '
        Me.OpenFileGcode.FileName = "gcode"
        '
        'ButtonClearMonitor
        '
        Me.ButtonClearMonitor.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonClearMonitor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonClearMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonClearMonitor.BorderRadius = 4
        Me.ButtonClearMonitor.ButtonText = "CLEAR MONITOR"
        Me.ButtonClearMonitor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClearMonitor.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonClearMonitor.Enabled = False
        Me.ButtonClearMonitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearMonitor.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonClearMonitor.Iconimage = Nothing
        Me.ButtonClearMonitor.Iconimage_right = Nothing
        Me.ButtonClearMonitor.Iconimage_right_Selected = Nothing
        Me.ButtonClearMonitor.Iconimage_Selected = Nothing
        Me.ButtonClearMonitor.IconMarginLeft = 0
        Me.ButtonClearMonitor.IconMarginRight = 0
        Me.ButtonClearMonitor.IconRightVisible = False
        Me.ButtonClearMonitor.IconRightZoom = 0R
        Me.ButtonClearMonitor.IconVisible = True
        Me.ButtonClearMonitor.IconZoom = 35.0R
        Me.ButtonClearMonitor.IsTab = False
        Me.ButtonClearMonitor.Location = New System.Drawing.Point(680, 644)
        Me.ButtonClearMonitor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonClearMonitor.Name = "ButtonClearMonitor"
        Me.ButtonClearMonitor.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonClearMonitor.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonClearMonitor.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonClearMonitor.selected = False
        Me.ButtonClearMonitor.Size = New System.Drawing.Size(255, 27)
        Me.ButtonClearMonitor.TabIndex = 19
        Me.ButtonClearMonitor.Text = "CLEAR MONITOR"
        Me.ButtonClearMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonClearMonitor.Textcolor = System.Drawing.Color.White
        Me.ButtonClearMonitor.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FormC2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1470, 702)
        Me.Controls.Add(Me.ButtonClearMonitor)
        Me.Controls.Add(Me.ButtonResetGraph)
        Me.Controls.Add(Me.TabEnam)
        Me.Controls.Add(Me.LabelO)
        Me.Controls.Add(Me.TabLima)
        Me.Controls.Add(Me.TabEmpat)
        Me.Controls.Add(Me.TabTiga)
        Me.Controls.Add(Me.TabDua)
        Me.Controls.Add(Me.TabSatu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormC2"
        Me.Padding = New System.Windows.Forms.Padding(24, 60, 24, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "C2NGDOGAN"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabSatu.ResumeLayout(False)
        Me.TabPageConnection.ResumeLayout(False)
        Me.TabPageConnection.PerformLayout()
        Me.TabDua.ResumeLayout(False)
        Me.TabPageManual.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxAxis.ResumeLayout(False)
        Me.GroupBoxAxis.PerformLayout()
        Me.TabPageAuto.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBoxGcode.ResumeLayout(False)
        Me.GroupBoxFile.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabTiga.ResumeLayout(False)
        Me.TabPageWorkingCoord.ResumeLayout(False)
        Me.TabPageWorkingCoord.PerformLayout()
        Me.TabEmpat.ResumeLayout(False)
        Me.TabPageSpeed.ResumeLayout(False)
        Me.TabPageSpeed.PerformLayout()
        Me.TabLima.ResumeLayout(False)
        Me.TabPageControl.ResumeLayout(False)
        Me.TabEnam.ResumeLayout(False)
        Me.TabPageAxisGraph.ResumeLayout(False)
        Me.TabPagePIDGraph.ResumeLayout(False)
        Me.TabPageDiagnostics.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabSatu As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabDua As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPageManual As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabTiga As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPageWorkingCoord As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabEmpat As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPageSpeed As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabLima As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPageConnection As MetroFramework.Controls.MetroTabPage
    Friend WithEvents LabelComPort As Label
    Friend WithEvents ButtonConnect As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DropdownPorts As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents LabelFeedRate As Label
    Friend WithEvents LabelSpindle As Label
    Friend WithEvents TabPageControl As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MegaSerialPort As IO.Ports.SerialPort
    Friend WithEvents ButtonManualYplus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonManualYmin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonManualXmin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonManualXplus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelManualYplus As Label
    Friend WithEvents LabelManualXmin As Label
    Friend WithEvents LabelManualYmin As Label
    Friend WithEvents LabelManualXplus As Label
    Friend WithEvents ButtonManualHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelManualZmin As Label
    Friend WithEvents LabelManualZplus As Label
    Friend WithEvents ButtonManualZmin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonManualZplus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelO As Label
    Friend WithEvents TabEnam As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPageAxisGraph As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPagePIDGraph As MetroFramework.Controls.MetroTabPage
    Friend WithEvents RichTextBoxDiagnostics As RichTextBox
    Friend WithEvents LabelManualFeedRate As Label
    Friend WithEvents GroupBoxAxis As GroupBox
    Friend WithEvents TextboxManualFeedRate As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents SliderManualFeedRate As Bunifu.Framework.UI.BunifuSlider
    Friend WithEvents ButtonRefreshPorts As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonGcodeRun As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RichTextBoxGCode As RichTextBox
    Friend WithEvents ButtonReset As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonEmergency As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelGoToOrigin As Label
    Friend WithEvents ButtonGoToOrigin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelSetOrigin As Label
    Friend WithEvents ButtonSetOrigin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonResume As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonPause As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelAxisGraph As Panel
    Friend WithEvents ButtonGoAbs As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelSemiZ As Label
    Friend WithEvents TextboxSemiZ As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelSemiY As Label
    Friend WithEvents TextboxSemiY As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelSemiX As Label
    Friend WithEvents TextboxSemiX As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents ButtonGoInc As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonResetGraph As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextboxGcodeShow As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents GroupBoxFile As GroupBox
    Friend WithEvents ButtonGcodeBrowse As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextBoxGcodeFile As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents GroupBoxGcode As GroupBox
    Friend WithEvents ButtonOpenFusion As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonGcodeNew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonGcodeSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonGcodeEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents OpenFileGcode As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPageDiagnostics As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ButtonGcodeSaveAs As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SaveFileGcode As SaveFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextboxManualRpm As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelManualRpm As Label
    Friend WithEvents SliderSpindle As Bunifu.Framework.UI.BunifuSlider
    Friend WithEvents TabPageAuto As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelAutoFeedrate As Label
    Friend WithEvents TextboxAutoFeedrate As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelAutoSpindleRPM As Label
    Friend WithEvents LabelAutoFeedrateMMMIN As Label
    Friend WithEvents LabelAutoSpindle As Label
    Friend WithEvents TextboxAutoSpindle As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelWorkingZ As Label
    Friend WithEvents TextboxWorkingZ As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelWorkingY As Label
    Friend WithEvents TextboxWorkingY As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelWorkingX As Label
    Friend WithEvents TextboxWorkingX As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelMachineY As Label
    Friend WithEvents TextboxWorkingRPM As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelMachineX As Label
    Friend WithEvents TextboxWorkingFeedrate As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents ButtonManualSpindleStop As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonManualSpindleCCW As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonManualSpindleCW As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelManualSpindleStop As Label
    Friend WithEvents LabelManualSpindleCW As Label
    Friend WithEvents LabelManualSpindleCCW As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckboxSpindleWithPID As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents PanelPidGraph As Panel
    Friend WithEvents RichTextBoxKirim As RichTextBox
    Friend WithEvents ButtonClearMonitor As Bunifu.Framework.UI.BunifuFlatButton
End Class
