Imports System.Text.RegularExpressions
Imports System.IO.Ports
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports CefSharp.WinForms

Public Class FormC2
#Region "constructor"
    Private activeComPort As String

    Private gcodeToSend As New List(Of String)()
    Private gcodeToShow As New List(Of String)()

    Private fHi, fXp, fXm, fYp, fYm, fZp, fZm As Boolean
    Private workingX, workingY, workingZ As Double
    Private zeroIsSet As Boolean

    Private spindleCWing, spindleCCWing As Boolean
    Private spindleHadOn As Boolean = False
    Private lastSpindleDir As String
    Private cooldownLongMillis As Integer = 3000
    Private timerCooldownManualSpindle As New Stopwatch

    Private setPoint As Long = 2000
    Private workingRPM As Long
    Private timerAutoProses As New Stopwatch

    Private hostServerStepper As String = "http://192.168.43.236:3005/"
    Private hostServerSpindle As String = "http://192.168.43.236:3006/"
    Private WithEvents axisGraphBrowser As ChromiumWebBrowser
    Private WithEvents pidGraphBrowser As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        Me.axisGraphBrowser = New ChromiumWebBrowser(Me.hostServerStepper & "axis") With {
            .Dock = DockStyle.Fill
        }
        PanelAxisGraph.Controls.Add(axisGraphBrowser)

        Me.pidGraphBrowser = New ChromiumWebBrowser(Me.hostServerSpindle & "pid") With {
            .Dock = DockStyle.Fill
        }
        PanelPidGraph.Controls.Add(pidGraphBrowser)
        Me.zeroIsSet = False
        Me.fHi = False
        Me.fXp = False
        Me.fXm = False
        Me.fYp = False
        Me.fYm = False
        Me.fZp = False
        Me.fZm = False
        Me.activeComPort = ""
    End Sub

    Private Sub FormC2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        For Each availableSerialPorts As String In My.Computer.Ports.SerialPortNames
            DropdownPorts.AddItem(availableSerialPorts)
        Next
        Dim r As New System.Threading.Thread(Sub() Me.resetAxisChart())
        r.Start()
        Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(0), CStr(0)))
        pid.Start()
    End Sub
#End Region
#Region "connection"
    Private Sub Connection(ByVal conn As Boolean)
        ButtonRefreshPorts.Enabled = Not conn
        DropdownPorts.Enabled = Not conn
        SliderManualFeedRate.Enabled = conn
        ButtonManualHome.Enabled = conn
        ButtonManualXplus.Enabled = conn
        ButtonManualXmin.Enabled = conn
        ButtonManualYplus.Enabled = conn
        ButtonManualYmin.Enabled = conn
        ButtonManualZplus.Enabled = conn
        ButtonManualZmin.Enabled = conn
        ButtonEmergency.Enabled = conn
        ButtonReset.Enabled = conn
        ButtonPause.Enabled = conn
        ButtonResume.Enabled = conn
        ButtonSetOrigin.Enabled = conn
        ButtonGoToOrigin.Enabled = conn
        ButtonGcodeBrowse.Enabled = conn
        ButtonOpenFusion.Enabled = conn
        ButtonGcodeNew.Enabled = conn
        ButtonGcodeRun.Enabled = conn
        SliderSpindle.Enabled = conn
        ButtonManualSpindleCCW.Enabled = conn
        ButtonManualSpindleCW.Enabled = conn
        ButtonManualSpindleStop.Enabled = conn
        ButtonResetGraph.Enabled = conn
        ButtonClearMonitor.Enabled = conn
        TextboxSemiX.Enabled = conn
        TextboxSemiY.Enabled = conn
        TextboxSemiZ.Enabled = conn
        ButtonGoAbs.Enabled = conn
        ButtonGoInc.Enabled = conn
        CheckboxSpindleWithPID.Enabled = conn
        If conn Then 'connect handler
            If Not Me.fHi Then
                sendToMega("@HI;")
                Me.fHi = True
            End If
            Me.workingX = Nothing
            Me.workingY = Nothing
            Me.workingZ = Nothing
            Me.zeroIsSet = False
            TextboxWorkingX.Text = ""
            TextboxWorkingY.Text = ""
            TextboxWorkingZ.Text = ""
        End If
        If Not conn Then 'disconnect handler

        End If
    End Sub
    Private Sub DropdownPorts_onItemSelected(sender As Object, e As EventArgs) Handles DropdownPorts.onItemSelected
        If DropdownPorts.selectedValue <> "" Then
            Me.activeComPort = DropdownPorts.selectedValue
        End If
    End Sub
    Private Sub ButtonRefreshPorts_Click(sender As Object, e As EventArgs) Handles ButtonRefreshPorts.Click
        DropdownPorts.Clear()
        For Each availableSerialPorts As String In My.Computer.Ports.SerialPortNames
            DropdownPorts.AddItem(availableSerialPorts)
        Next
    End Sub
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        If ButtonConnect.Text = "CONNECT" Then
            If Me.activeComPort <> "" Then
                MegaSerialPort.Close()
                MegaSerialPort.PortName = Me.activeComPort
                MegaSerialPort.BaudRate = 115200
                MegaSerialPort.ReadTimeout = 10000
                MegaSerialPort.Encoding = System.Text.Encoding.Default
                Try
                    MegaSerialPort.Open()
                    ButtonConnect.Text = "DISCONNECT"
                    Me.Connection(True)
                Catch err As Exception
                    MessageBox.Show("Unable to assign commport", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Select a COM port first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            If spindleCWing Or spindleCCWing Then
                MessageBox.Show("Stop spindle first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MegaSerialPort.Close()
                Me.fHi = False
                ButtonConnect.Text = "CONNECT"
                Me.Connection(False)
            End If
        End If
    End Sub
#End Region
#Region "communication"
    Private Delegate Sub StreamResponseCallback(ByVal responseData As String)
    Private Function ReadResponse() As String
        Try
            Dim responseData As String = MegaSerialPort.ReadExisting()
            If Not responseData Is Nothing Then
                Return responseData
            End If
            Return Nothing
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function
    Private Sub MegaSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles MegaSerialPort.DataReceived
        Dim responseData As String = Me.ReadResponse()
        If responseData <> "" Then
            'Dim s As New System.Threading.Thread(Sub() Me.StreamResponse(responseData))
            's.Start()
            Me.ResponseHandler(responseData)
            responseData = ""
        End If
    End Sub
    Private Sub sendToMega(ByVal requestData As String)
        MegaSerialPort.Write(requestData)
        RichTextBoxKirim.Text &= " WRITE: " & requestData & vbNewLine
        RichTextBoxKirim.SelectionStart = Len(RichTextBoxKirim.Text)
        RichTextBoxKirim.ScrollToCaret()
    End Sub
    Private Sub StreamResponse(ByVal msg As String)
        If Me.InvokeRequired Then
            Me.Invoke(New StreamResponseCallback(AddressOf StreamResponse), New Object() {msg})
            RichTextBoxDiagnostics.Text &= " READ: " & msg & vbNewLine
            RichTextBoxDiagnostics.SelectionStart = Len(RichTextBoxDiagnostics.Text)
            RichTextBoxDiagnostics.ScrollToCaret()
        End If
    End Sub
    Private Sub ResponseHandler(ByVal msg As String)
        Dim patternHomingResetDone As String = "#0D;"
        Dim patternCoordinate As String = "#CC(?<wx>[-+]?\d+\.\d{1,2}),(?<wy>[-+]?\d+\.\d{1,2}),(?<wz>[-+]?\d+\.\d{1,2});"
        Dim patternRPM As String = "#FF(?<rpm>\d+);"
        Dim patternOrigin As String = "#OS(?<ox>[-+]?\d+\.\d{1,2}),(?<oy>[-+]?\d+\.\d{1,2}),(?<oz>[-+]?\d+\.\d{1,2});"
        'Dim patternAutoNextline As String = "(?:#CC(?:[-+]?\d+\.\d{1,2},){2}[-+]?\d+\.\d{1,2},\d+;)?#NL(?<index>\d+);(?:#CC(?:[-+]?\d+\.\d{1,2},){2}[-+]?\d+\.\d{1,2},\d+;)?"
        Dim patternAutoNextline As String = "#NL(?<index>\d+);"
        Dim patternAutoDone As String = "#GD(?<emg>[012]),(?<wx>[-+]?\d+\.\d{1,2}),(?<wy>[-+]?\d+\.\d{1,2}),(?<wz>[-+]?\d+\.\d{1,2});"
        Dim patternEmergency As String = "#EG;"
        If Regex.Match(msg, patternHomingResetDone).Success Then
            Me.zeroIsSet = False
            Me.spindleHadOn = False
            Me.fHi = False
            Me.workingX = 0
            Me.workingY = 0
            Me.workingZ = 0
            TextboxWorkingX.Text = CStr(Me.workingX)
            TextboxWorkingY.Text = CStr(Me.workingY)
            TextboxWorkingZ.Text = CStr(Me.workingZ)
            Dim r As New System.Threading.Thread(Sub() Me.resetAxisChart())
            r.Start()
            Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(0), CStr(0)))
            pid.Start()
        End If
        If Regex.Match(msg, patternCoordinate).Success Then
            For Each m As Match In Regex.Matches(msg, patternCoordinate)
                Me.workingX = CDbl(m.Groups("wx").Value)
                Me.workingY = CDbl(m.Groups("wy").Value)
                Me.workingZ = CDbl(m.Groups("wz").Value)
                TextboxWorkingX.Text = CStr(Me.workingX)
                TextboxWorkingY.Text = CStr(Me.workingY)
                TextboxWorkingZ.Text = CStr(Me.workingZ)
                Dim u As New System.Threading.Thread(Sub() Me.updateAxisChart(CStr(Me.workingX), CStr(Me.workingY), CStr(Me.workingZ)))
                u.Start()
            Next
        End If
        If Regex.Match(msg, patternRPM).Success Then
            Me.workingRPM = CDbl(Regex.Match(msg, patternRPM).Groups("rpm").Value)
            TextboxWorkingRPM.Text = CStr(Me.workingRPM)
            Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(Me.setPoint), CStr(Me.workingRPM)))
            pid.Start()
        End If
        If Regex.Match(msg, patternOrigin).Success Then
            MessageBox.Show("Successfully Set origin On X: " & Regex.Match(msg, patternOrigin).Groups("ox").Value &
                            ", Y:" & Regex.Match(msg, patternOrigin).Groups("oy").Value &
                            ", Z:" & Regex.Match(msg, patternOrigin).Groups("oz").Value & " machine",
                            "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.workingX = 0
            Me.workingY = 0
            Me.workingZ = 0
            TextboxWorkingX.Text = CStr(Me.workingX)
            TextboxWorkingY.Text = CStr(Me.workingY)
            TextboxWorkingZ.Text = CStr(Me.workingZ)
        End If
        If Regex.Match(msg, patternAutoNextline).Success Then
            Dim i As Integer = CInt(Regex.Match(msg, patternAutoNextline).Groups("index").Value)
            sendToMega(Me.gcodeToSend(i))
            If Me.gcodeToSend(i).StartsWith("@ETSP") Then 'update setpoint m13 spindle on
                Dim ing As String = Me.gcodeToSend(i)
                Dim rpmwsemicolon As String = ing.Substring(6)
                Dim jadi = rpmwsemicolon.Remove(rpmwsemicolon.Length - 1)
                Me.setPoint = CLng(jadi)
                TextboxAutoSpindle.Text = CStr(Me.setPoint)
                Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(Me.setPoint), CStr(0)))
                pid.Start()
            End If
            If Me.gcodeToSend(i).StartsWith("@ETM5") Then 'update setpoint m5 spindle off
                TextboxAutoSpindle.Text = CStr(Me.setPoint)
                Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(0), CStr(0)))
                pid.Start()
            End If
            TextboxGcodeShow.Text = Me.gcodeToShow(i) & Me.gcodeToShow.LongCount & ")"
            Dim fr As String
            Try
                fr = Me.gcodeToSend(i).Split({","c}, StringSplitOptions.RemoveEmptyEntries)(7)
            Catch ex As Exception
                fr = "0"
            End Try
            If fr.Contains(";") Then
                fr = fr.Remove(fr.Length - 1)
            End If
            If fr = "-1" Then
                fr = "800"
            End If
            TextboxAutoFeedrate.Text = fr
            TextboxWorkingFeedrate.Text = fr
        End If
        If Regex.Match(msg, patternAutoDone).Success Then
            Me.gcodeToSend.Clear()
            Me.gcodeToSend = New List(Of String)()
            Me.gcodeToShow = New List(Of String)()
            runningAuto(False)
            Dim ts As TimeSpan = TimeSpan.FromMilliseconds(timerAutoProses.ElapsedMilliseconds())
            timerAutoProses.Stop()
            Dim m As Match = Regex.Match(msg, patternAutoDone)
            Me.workingX = m.Groups("wx").Value
            Me.workingY = m.Groups("wy").Value
            Me.workingZ = m.Groups("wz").Value
            TextboxWorkingX.Text = CStr(Me.workingX)
            TextboxWorkingY.Text = CStr(Me.workingY)
            TextboxWorkingZ.Text = CStr(Me.workingZ)
            If m.Groups("emg").Value = "1" Then
                MessageBox.Show("Job error, emergency (G-Code line: " & TextboxGcodeShow.Text & ")",
                                 "Emergency!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf m.Groups("emg").Value = "0" Then
                MessageBox.Show("Job completed after " & ts.Hours.ToString & " hours " & ts.Minutes.ToString & " minutes " & ts.Seconds.ToString & " seconds",
                                "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf m.Groups("emg").Value = "2" Then
                MessageBox.Show("Coordinate offset (G-Code line: " & TextboxGcodeShow.Text & ")",
                                "Emergency!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            TextboxGcodeShow.Text = ""
            TextboxAutoFeedrate.Text = ""
            TextboxWorkingFeedrate.Text = ""
            TextboxWorkingRPM.Text = CStr(0)
            Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(0), CStr(0)))
            pid.Start()
        End If
        If Regex.Match(msg, patternEmergency).Success Then
            MessageBox.Show("Emergency active",
                            "Interrupt!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ButtonClearMonitor_Click(sender As Object, e As EventArgs) Handles ButtonClearMonitor.Click
        RichTextBoxDiagnostics.Clear()
        RichTextBoxKirim.Clear()
    End Sub
#End Region
#Region "control"
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        sendToMega("@RS;")
        runningAuto(False)
    End Sub

    Private Sub ButtonEmergency_Click(sender As Object, e As EventArgs) Handles ButtonEmergency.Click
        sendToMega("@EM;")
    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        sendToMega("@PS;")
    End Sub

    Private Sub ButtonResume_Click(sender As Object, e As EventArgs) Handles ButtonResume.Click
        sendToMega("@RM;")
    End Sub
#End Region
#Region "manual jog stepper"
    Private Sub ButtonManualHome_MouseDown(sender As Object, e As EventArgs) Handles ButtonManualHome.MouseDown
        sendToMega("@HM;")
    End Sub
    Private Sub SliderManualFeedRate_ValueChanged(sender As Object, e As EventArgs) Handles SliderManualFeedRate.ValueChanged
        If SliderManualFeedRate.Value < 20 Then
            TextboxManualFeedRate.Text = "20"
        Else
            TextboxManualFeedRate.Text = SliderManualFeedRate.Value
        End If
    End Sub
    Private Sub ButtonManualXplus_MouseDown(sender As Object, e As EventArgs) Handles ButtonManualXplus.MouseDown
        If Not fXp Then
            sendToMega("@X+" & TextboxManualFeedRate.Text & ";")
            fXp = True
        End If
        TextboxWorkingFeedrate.Text = TextboxManualFeedRate.Text
    End Sub
    Private Sub ButtonManualXmin_MouseDown(sender As Object, e As EventArgs) Handles ButtonManualXmin.MouseDown
        If Not fXm Then
            sendToMega("@X-" & TextboxManualFeedRate.Text & ";")
            fXm = True
        End If
        TextboxWorkingFeedrate.Text = TextboxManualFeedRate.Text
    End Sub
    Private Sub ButtonManualYplus_MouseDown(sender As Object, e As EventArgs) Handles ButtonManualYplus.MouseDown
        If Not fYp Then
            sendToMega("@Y+" & TextboxManualFeedRate.Text & ";")
            fYp = True
        End If
        TextboxWorkingFeedrate.Text = TextboxManualFeedRate.Text
    End Sub
    Private Sub ButtonManualYmin_MouseDown(sender As Object, e As EventArgs) Handles ButtonManualYmin.MouseDown
        If Not fYm Then
            sendToMega("@Y-" & TextboxManualFeedRate.Text & ";")
            fYm = True
        End If
        TextboxWorkingFeedrate.Text = TextboxManualFeedRate.Text
    End Sub
    Private Sub ButtonManualZplus_MouseDown(sender As Object, e As EventArgs) Handles ButtonManualZplus.MouseDown
        If Not fZp Then
            sendToMega("@Z+" & TextboxManualFeedRate.Text & ";")
            fZp = True
        End If
        TextboxWorkingFeedrate.Text = TextboxManualFeedRate.Text
    End Sub
    Private Sub ButtonManualZmin_MouseDown(sender As Object, e As EventArgs) Handles ButtonManualZmin.MouseDown
        If Not fZm Then
            sendToMega("@Z-" & TextboxManualFeedRate.Text & ";")
            fZm = True
        End If
        TextboxWorkingFeedrate.Text = TextboxManualFeedRate.Text
    End Sub
    Private Sub ButtonManual_MouseUp(sender As Object, e As EventArgs) Handles ButtonManualXplus.MouseUp, ButtonManualXmin.MouseUp,
        ButtonManualYplus.MouseUp, ButtonManualYmin.MouseUp, ButtonManualZplus.MouseUp, ButtonManualZmin.MouseUp
        sendToMega("@RL;")
        Me.fXp = False
        Me.fXm = False
        Me.fYp = False
        Me.fYm = False
        Me.fZp = False
        Me.fZm = False
        TextboxWorkingFeedrate.Text = ""
    End Sub
#End Region
#Region "manual jog spindle"
    Private Sub SliderSpindle_ValueChanged(sender As Object, e As EventArgs) Handles SliderSpindle.ValueChanged
        If (spindleCWing Or spindleCCWing) And CheckboxSpindleWithPID.Checked Then
            MessageBox.Show("Stop spindle first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If SliderSpindle.Value < 500 Then
                TextboxManualRpm.Text = 500
            Else
                If SliderSpindle.Value <= 5000 And SliderSpindle.Value > 4500 Then
                    TextboxManualRpm.Text = 4800
                Else
                    TextboxManualRpm.Text = Format(CInt(SliderSpindle.Value) / 500, "0") * 500
                End If
            End If
            Me.setPoint = CLng(TextboxManualRpm.Text)
            Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(Me.setPoint), CStr(0)))
            pid.Start()
        End If
    End Sub
    Private Sub SliderSpindle_ValueChangeComplete(sender As Object, e As EventArgs) Handles SliderSpindle.ValueChangeComplete
        If (spindleCWing Or spindleCCWing) And (TextboxManualRpm.Text <> "") Then
            If spindleCWing Then
                If CheckboxSpindleWithPID.Checked Then
                    sendToMega("@PC" & TextboxManualRpm.Text & ";")
                Else
                    sendToMega("@SC" & TextboxManualRpm.Text & ";")
                End If
            End If
            If spindleCCWing Then
                If CheckboxSpindleWithPID.Checked Then
                    sendToMega("@PW" & TextboxManualRpm.Text & ";")
                Else
                    sendToMega("@SW" & TextboxManualRpm.Text & ";")
                End If
            End If
        End If
    End Sub
    Private Sub ButtonManualSpindleCW_Click(sender As Object, e As EventArgs) Handles ButtonManualSpindleCW.Click
        If Not spindleCWing Then
            If spindleCCWing Then
                MessageBox.Show("Stop spindle first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If timerCooldownManualSpindle.ElapsedMilliseconds >= cooldownLongMillis Or Not spindleHadOn Or lastSpindleDir = "CW" Then
                    spindleCWing = True
                    spindleHadOn = True
                    lastSpindleDir = "CW"
                    timerCooldownManualSpindle.Stop()
                    If CheckboxSpindleWithPID.Checked Then
                        sendToMega("@PC" & TextboxManualRpm.Text & ";")
                    Else
                        sendToMega("@SC" & TextboxManualRpm.Text & ";")
                    End If
                Else
                    MessageBox.Show("Try again in " & CInt((cooldownLongMillis - timerCooldownManualSpindle.ElapsedMilliseconds) / 1000) & " sec.",
                                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
    Private Sub ButtonManualSpindleCCW_Click(sender As Object, e As EventArgs) Handles ButtonManualSpindleCCW.Click
        If Not spindleCCWing Then
            If spindleCWing Then
                MessageBox.Show("Stop spindle first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If timerCooldownManualSpindle.ElapsedMilliseconds >= cooldownLongMillis Or Not spindleHadOn Or lastSpindleDir = "CCW" Then
                    spindleCCWing = True
                    spindleHadOn = True
                    lastSpindleDir = "CCW"
                    timerCooldownManualSpindle.Stop()
                    If CheckboxSpindleWithPID.Checked Then
                        sendToMega("@PW" & TextboxManualRpm.Text & ";")
                    Else
                        sendToMega("@SW" & TextboxManualRpm.Text & ";")
                    End If
                Else
                    MessageBox.Show("Try again in " & CInt((cooldownLongMillis - timerCooldownManualSpindle.ElapsedMilliseconds) / 1000) & " sec.",
                                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
    Private Sub ButtonManualSpindleStop_Click(sender As Object, e As EventArgs) Handles ButtonManualSpindleStop.Click
        If spindleCWing Or spindleCCWing Then
            sendToMega("@SM;")
            timerCooldownManualSpindle.Reset()
            timerCooldownManualSpindle.Start()
            spindleCWing = False
            spindleCCWing = False
        End If
        TextboxWorkingRPM.Text = ""
        Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(0), CStr(0)))
        pid.Start()
    End Sub
#End Region
#Region "manual control"
    Private Sub ButtonSetOrigin_Click(sender As Object, e As EventArgs) Handles ButtonSetOrigin.Click
        sendToMega("@SO;")
        zeroIsSet = True
        Dim r As New System.Threading.Thread(Sub() Me.resetAxisChart())
        r.Start()
    End Sub
    Private Sub ButtonGoToOrigin_Click(sender As Object, e As EventArgs) Handles ButtonGoToOrigin.Click
        If zeroIsSet Then
            sendToMega("@GO;")
        Else
            MessageBox.Show("Origin Is Not set yet", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ButtonGoAbs_Click(sender As Object, e As EventArgs) Handles ButtonGoAbs.Click
        If IsNumeric(TextboxSemiX.Text) And IsNumeric(TextboxSemiY.Text) And IsNumeric(TextboxSemiZ.Text) Then
            sendToMega("@SA" & TextboxSemiX.Text & "," & TextboxSemiY.Text & "," & TextboxSemiZ.Text & "," & TextboxManualFeedRate.Text & ";")
        Else
            MessageBox.Show("Coordinate value must be number", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ButtonGoInc_Click(sender As Object, e As EventArgs) Handles ButtonGoInc.Click
        If IsNumeric(TextboxSemiX.Text) And IsNumeric(TextboxSemiY.Text) And IsNumeric(TextboxSemiZ.Text) Then
            sendToMega("@SI" & TextboxSemiX.Text & "," & TextboxSemiY.Text & "," & TextboxSemiZ.Text & "," & TextboxManualFeedRate.Text & ";")
        Else
            MessageBox.Show("Coordinate value must be number", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region
#Region "parsing"
    Private Function preParsingGcode(ByRef raw As List(Of String), ByRef collect As List(Of String)) As Boolean
        Dim result As Boolean = False
        For i As Integer = 0 To raw.LongCount - 1
            If Regex.IsMatch(raw(i), "(?:^(?:[XYZ]|G[0123]\s|G17\s|G28\sG91\s).*)|(?:.*(?:M30|M13|M14|M[2345]|S).*)") Then
                result = True
                If Regex.IsMatch(raw(i), "^G17\s.*") Then
                    raw(i) = raw(i).Substring(4)
                End If
                If Regex.IsMatch(raw(i), "G[23]\s.*") Then
                    Return False
                End If
                If Regex.IsMatch(raw(i), "^[XYZ].*") Then
                    Dim gBefore = raw(i - 1).Substring(0, 3)
                    If gBefore = "G0 " Or gBefore = "G1 " Or gBefore = "G2 " Or gBefore = "G3 " Then
                        Try
                            raw(i) = gBefore & raw(i)
                        Catch ex As Exception
                            Return False
                        End Try
                    End If
                End If
                collect.Add(raw(i))
            End If
        Next
        Return result
    End Function
    Private Function parsingGcode(ByVal currentLine As String, ByVal param As String, ByVal listToApppend As List(Of String), ByVal lastIndex As Integer) As String
        Dim result As String = ""
        Dim search As Match = Regex.Match(currentLine, "(?:" & param & ")([-+]?\d+(?:\.\d+)?)")
        If search.Success Then
            result = search.Groups(1).Value
        Else
            If param = "X" Or param = "Y" Or param = "Z" Then
                Try
                    result = listToApppend(lastIndex)
                Catch ex As ArgumentOutOfRangeException
                    result = "0"
                End Try
            ElseIf param = "F" Then
                If Regex.IsMatch(currentLine, "^G0\s.*") Then
                    result = "-1"
                Else
                    Try
                        result = listToApppend(lastIndex)
                    Catch ex As ArgumentOutOfRangeException
                        result = "-1"
                    End Try
                End If
            End If
        End If
        Return result
    End Function
#End Region
#Region "chart"
    Private Function httpPost(ByVal url As String, ByVal data As String) As Boolean
        Dim result As Boolean
        Dim byteData As Byte() = (New UTF8Encoding).GetBytes(data)

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/x-www-form-urlencoded"
        request.AllowAutoRedirect = False
        request.ContentLength = byteData.Length
        Try
            Dim requestStream As IO.Stream = request.GetRequestStream()
            requestStream.Write(byteData, 0, byteData.Length)
            requestStream.Close()

            Dim respponse As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim respponseReader As String = (New IO.StreamReader(respponse.GetResponseStream())).ReadToEnd()

            result = (New JavaScriptSerializer()).Deserialize(Of Dictionary(Of String, String))(respponseReader)("success")
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function
    Private Delegate Function updateAxisChartCallback(ByVal x As String, ByVal y As String, ByVal z As String) As Boolean
    Private Function updateAxisChart(ByVal x As String, ByVal y As String, ByVal z As String) As Boolean
        Dim result As Boolean = False
        If Me.InvokeRequired Then
            Me.Invoke(New updateAxisChartCallback(AddressOf updateAxisChart), New Object() {x, y, z})
            result = Me.httpPost(Me.hostServerStepper & "api/update-stepper", "xpos=" & x & "&ypos=" & y & "&zpos=" & z & "&key=H1r2ig4nT3ng#69")
        End If
        Return result
    End Function
    Private Delegate Function updateSpindleChartCallback(ByVal sp As String, ByVal rpm As String) As Boolean
    Private Function updateSpindleChart(ByVal sp As String, ByVal rpm As String) As Boolean
        Dim result As Boolean = False
        If Me.InvokeRequired Then
            Me.Invoke(New updateSpindleChartCallback(AddressOf updateSpindleChart), New Object() {sp, rpm})
            result = Me.httpPost(Me.hostServerSpindle & "api/update-spindle", "setpoint=" & sp & "&rpm=" & rpm & "&key=H1r2ig4nT3ng#69")
        End If
        Return result
    End Function
    Private Delegate Function resetAxisChartCallback() As Boolean
    Private Function resetAxisChart() As Boolean
        Dim result As Boolean = False
        Dim updatedzero As Boolean = False
        If Me.InvokeRequired Then
            Me.Invoke(New resetAxisChartCallback(AddressOf resetAxisChart))
            result = Me.httpPost(Me.hostServerStepper & "api/reset-stepper", "key=H1r2ig4nT3ng#69")
            updatedzero = Me.httpPost(Me.hostServerStepper & "api/update-stepper", "xpos=0&ypos=0&zpos=0&key=H1r2ig4nT3ng#69")
        End If
        Return result And updatedzero
    End Function
    Private Sub ButtonResetGraph_Click(sender As Object, e As EventArgs) Handles ButtonResetGraph.Click
        Dim r As New System.Threading.Thread(Sub() Me.resetAxisChart())
        r.Start()
    End Sub
#End Region
#Region "auto"
    Private Sub ButtonOpenFusion_Click(sender As Object, e As EventArgs) Handles ButtonOpenFusion.Click
        'System.Diagnostics.Process.Start(
        '    "C:\Users\nurfakhrian\AppData\Local\Autodesk\webdeploy\production\6a0c9611291d45bb9226980209917c3d\FusionLauncher.exe", vbMaximizedFocus)
        System.Diagnostics.Process.Start(
            "C:\Program Files\Autodesk\webdeploy\production\6a0c9611291d45bb9226980209917c3d\FusionLauncher.exe", vbMaximizedFocus)
    End Sub
    Private Sub ButtonGcodeNew_Click(sender As Object, e As EventArgs) Handles ButtonGcodeNew.Click
        RichTextBoxGCode.Clear()
        TextBoxGcodeFile.Text = ""
        RichTextBoxGCode.ReadOnly = False
        ButtonGcodeSave.Enabled = False
        ButtonGcodeSaveAs.Enabled = True
        ButtonGcodeEdit.Enabled = False
    End Sub
    Private Sub ButtonGcodeBrowse_Click(sender As Object, e As EventArgs) Handles ButtonGcodeBrowse.Click
        OpenFileGcode.InitialDirectory = "Documents"
        OpenFileGcode.Filter = "gcode file|*.nc;*.txt;*.gcode;*.tap"
        OpenFileGcode.Title = "Select file"
        If OpenFileGcode.ShowDialog = DialogResult.OK Then
            TextBoxGcodeFile.Text = OpenFileGcode.FileName
            RichTextBoxGCode.Clear()
            RichTextBoxGCode.LoadFile(OpenFileGcode.FileName, RichTextBoxStreamType.PlainText)
            RichTextBoxGCode.ReadOnly = True
            ButtonGcodeSave.Enabled = False
            ButtonGcodeSaveAs.Enabled = False
            ButtonGcodeEdit.Enabled = True
            OpenFileGcode.FileName = ""
        End If
    End Sub
    Private Sub ButtonGcodeEdit_Click(sender As Object, e As EventArgs) Handles ButtonGcodeEdit.Click
        RichTextBoxGCode.ReadOnly = False
        ButtonGcodeSave.Enabled = True
        ButtonGcodeSaveAs.Enabled = True
    End Sub
    Private Sub ButtonGcodeSave_Click(sender As Object, e As EventArgs) Handles ButtonGcodeSave.Click
        RichTextBoxGCode.ReadOnly = True
        ButtonGcodeSave.Enabled = False
        ButtonGcodeSaveAs.Enabled = False
        RichTextBoxGCode.SaveFile(TextBoxGcodeFile.Text, RichTextBoxStreamType.PlainText)
        MessageBox.Show("File successfully saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ButtonGcodeSaveAs_Click(sender As Object, e As EventArgs) Handles ButtonGcodeSaveAs.Click
        If RichTextBoxGCode.Text <> "" Then
            SaveFileGcode.InitialDirectory = "Documents"
            SaveFileGcode.Filter = "nc file|*.nc|text file|*.txt|gcode file|*.gcode|tap file|*.tap"
            SaveFileGcode.Title = "Save as"
            If SaveFileGcode.ShowDialog <> DialogResult.Cancel Then
                RichTextBoxGCode.SaveFile(SaveFileGcode.FileName, RichTextBoxStreamType.PlainText)
                RichTextBoxGCode.ReadOnly = True
                TextBoxGcodeFile.Text = SaveFileGcode.FileName
                ButtonGcodeEdit.Enabled = True
                ButtonGcodeSave.Enabled = False
                ButtonGcodeSaveAs.Enabled = False
                SaveFileGcode.FileName = ""
            End If
        Else
            MessageBox.Show("File cannot be empty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ButtonGcodeRun_Click(sender As Object, e As EventArgs) Handles ButtonGcodeRun.Click
        If (Not spindleCWing) Or (Not spindleCCWing) Then
            If zeroIsSet Then
                If RichTextBoxGCode.Text <> "" Then
                    Me.gcodeToSend.Clear()
                    Me.gcodeToShow.Clear()

                    Dim preGcodeOK As Boolean = False
                    Dim gcodeOK As Boolean = False
                    Dim gcodeRaw As List(Of String) = RichTextBoxGCode.Lines.ToList
                    Dim gcodeCollectParams As New List(Of String)
                    Dim spindleSpeed As String = "-1" '-1 untuk default, 0 untuk tanpa spindle

                    If preParsingGcode(gcodeRaw, gcodeCollectParams) Then 'line mengandung format gcode benar

                        preGcodeOK = True

                        Dim gcodeInterpolasi As New Dictionary(Of String, List(Of String)) From {
                            {"X", New List(Of String)},
                            {"Y", New List(Of String)},
                            {"Z", New List(Of String)},
                            {"F", New List(Of String)}
                        }

                        Dim indexInterpolasi As Integer = 0
                        Dim indexTotWork As Integer = 0
                        Do
                            For i As Integer = 0 To gcodeCollectParams.LongCount - 1
                                If Regex.IsMatch(gcodeCollectParams(i), "S\d+(?:\.\d+)?") Then
                                    Dim m As Match = Regex.Match(gcodeCollectParams(i), "(?:S)(\d+(?:\.\d+)?)")
                                    If m.Success Then
                                        indexTotWork += 1
                                        Me.gcodeToShow.Add(gcodeCollectParams(i) & " (" & indexTotWork & "/")
                                        Me.gcodeToSend.Add("@ETSP," & m.Groups(1).Value & ";")
                                    End If
                                End If
                                If Regex.IsMatch(gcodeCollectParams(i), "\s?(?:M30|M13|M14|M[2345])") Then
                                    Dim M As String = Regex.Match(gcodeCollectParams(i), "(M30|M13|M14|M[2345])").Groups(1).Value
                                    indexTotWork += 1
                                    Me.gcodeToShow.Add(gcodeCollectParams(i) & " (" & indexTotWork & "/")
                                    Me.gcodeToSend.Add("@ET" & M & ";")
                                End If
                                If Regex.IsMatch(gcodeCollectParams(i), "G28\sG91\s") Then
                                    indexTotWork += 1
                                    Me.gcodeToShow.Add(gcodeCollectParams(i) & " (" & indexTotWork & "/")
                                    Dim machineX As Match = Regex.Match(gcodeCollectParams(i), "(?:X)(0(?:\.\d+)?)")
                                    Dim machineY As Match = Regex.Match(gcodeCollectParams(i), "(?:Y)(0(?:\.\d+)?)")
                                    Dim machineZ As Match = Regex.Match(gcodeCollectParams(i), "(?:Z)(0(?:\.\d+)?)")
                                    If machineZ.Success Then
                                        Me.gcodeToSend.Add("@WEZD;")
                                    End If
                                    If machineX.Success And machineY.Success Then
                                        Me.gcodeToSend.Add("@WEXY;")
                                    End If
                                End If
                                If Regex.IsMatch(gcodeCollectParams(i), "^G[01]\s.*") Then

                                    gcodeOK = True

                                    Dim checkX, checkY, checkZ, checkF As String

                                    checkX = parsingGcode(gcodeCollectParams(i), "X", gcodeInterpolasi("X"), indexInterpolasi - 1)
                                    If Not Regex.IsMatch(checkX, "^[-]?\d+(\.\d{1,2})?") Then
                                        gcodeOK = False
                                    End If

                                    checkY = parsingGcode(gcodeCollectParams(i), "Y", gcodeInterpolasi("Y"), indexInterpolasi - 1)
                                    If Not Regex.IsMatch(checkY, "^[-]?\d+(\.\d{1,2})?") Then
                                        gcodeOK = False
                                    End If

                                    checkZ = parsingGcode(gcodeCollectParams(i), "Z", gcodeInterpolasi("Z"), indexInterpolasi - 1)
                                    If Not Regex.IsMatch(checkZ, "^[-]?\d+(\.\d{1,2})?") Then
                                        gcodeOK = False
                                    End If

                                    checkF = parsingGcode(gcodeCollectParams(i), "F", gcodeInterpolasi("F"), indexInterpolasi - 1)
                                    If Regex.IsMatch(checkF, "^([-]?\d+(?:\.\d+)?)") Then
                                        If CLng(Regex.Match(checkF, "^([-]?\d+(?:\.\d+)?)").Groups(1).Value) > 800 Then
                                            gcodeOK = False
                                        End If
                                    End If

                                    If Not gcodeOK Then
                                        Exit Do
                                    End If

                                    gcodeInterpolasi("X").Add(checkX)
                                    gcodeInterpolasi("Y").Add(checkY)
                                    gcodeInterpolasi("Z").Add(checkZ)
                                    gcodeInterpolasi("F").Add(checkF)

                                    Dim G, X0, Y0, Z0, X1, Y1, Z1, F As String

                                    G = Regex.Match(gcodeCollectParams(i), "(G[01])").Groups(1).Value

                                    Try
                                        X0 = gcodeInterpolasi("X")(indexInterpolasi - 1)
                                        Y0 = gcodeInterpolasi("Y")(indexInterpolasi - 1)
                                        Z0 = gcodeInterpolasi("Z")(indexInterpolasi - 1)
                                    Catch ex As Exception
                                        X0 = 0
                                        Y0 = 0
                                        Z0 = 0
                                    End Try

                                    X1 = gcodeInterpolasi("X")(indexInterpolasi)
                                    Y1 = gcodeInterpolasi("Y")(indexInterpolasi)
                                    Z1 = gcodeInterpolasi("Z")(indexInterpolasi)
                                    F = gcodeInterpolasi("F")(indexInterpolasi)

                                    indexTotWork += 1
                                    Me.gcodeToShow.Add(gcodeCollectParams(i) & " (" & indexTotWork & "/")
                                    Me.gcodeToSend.Add("@IT" & G & "," & X0 & "," & Y0 & "," & Z0 & "," & X1 & "," & Y1 & "," & Z1 & "," & F & ";")

                                    indexInterpolasi += 1
                                End If
                            Next
                        Loop While False
                    Else
                        MessageBox.Show("Format error (make sure there is no circular interpolation)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    If preGcodeOK And gcodeOK Then 'line mengandung format gcode benar DAN maksimal 2 angka dibelakang koma
                        Dim continueGcode As DialogResult = MessageBox.Show("Continue Run G-Code?",
                                                                            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If continueGcode = DialogResult.Yes Then
                            runningAuto(True)
                            sendToMega("@IA;")
                            timerAutoProses.Reset()
                            timerAutoProses.Start()
                            Dim r As New System.Threading.Thread(Sub() Me.resetAxisChart())
                            r.Start()
                            Dim pid As New System.Threading.Thread(Sub() Me.updateSpindleChart(CStr(0), CStr(0)))
                            pid.Start()
                        Else
                            MessageBox.Show("Job canceled", "Cancel!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    ElseIf preGcodeOK Then
                        MessageBox.Show("G-Code format error (check coordinate digit after decimal, feedrate or interpolation)",
                                        "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("G-Code cannot be empty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Set origin first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Stop spindle first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub runningAuto(ByVal cond As Boolean)
        SliderManualFeedRate.Enabled = Not cond
        ButtonManualHome.Enabled = Not cond
        ButtonManualXplus.Enabled = Not cond
        ButtonManualXmin.Enabled = Not cond
        ButtonManualYplus.Enabled = Not cond
        ButtonManualYmin.Enabled = Not cond
        ButtonManualZplus.Enabled = Not cond
        ButtonManualZmin.Enabled = Not cond
        ButtonSetOrigin.Enabled = Not cond
        ButtonGoToOrigin.Enabled = Not cond
        TextboxSemiX.Enabled = Not cond
        TextboxSemiY.Enabled = Not cond
        TextboxSemiZ.Enabled = Not cond
        ButtonGoAbs.Enabled = Not cond
        ButtonGoInc.Enabled = Not cond
        SliderSpindle.Enabled = Not cond
        ButtonManualSpindleCCW.Enabled = Not cond
        ButtonManualSpindleCW.Enabled = Not cond
        ButtonManualSpindleStop.Enabled = Not cond
        ButtonResetGraph.Enabled = Not cond
        ButtonClearMonitor.Enabled = Not cond
        ButtonGcodeRun.Enabled = Not cond
        CheckboxSpindleWithPID.Enabled = Not cond
    End Sub
#End Region
End Class
