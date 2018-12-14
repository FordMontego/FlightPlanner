<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTimeAloft = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudMaxRange = New System.Windows.Forms.NumericUpDown()
        Me.nudCruiseSpeed = New System.Windows.Forms.NumericUpDown()
        Me.txtFlowRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudPlannedDistance = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpConsumption = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudMaxFuel = New System.Windows.Forms.NumericUpDown()
        Me.nudDistToAlternate = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudReserve = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFuelNeeded = New System.Windows.Forms.TextBox()
        Me.lblFuelNeeded = New System.Windows.Forms.Label()
        Me.grpFuel = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEstTime = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCalcRange = New System.Windows.Forms.TextBox()
        Me.lblCalcRange = New System.Windows.Forms.Label()
        Me.grpWeight = New System.Windows.Forms.GroupBox()
        Me.lblSpareWeight = New System.Windows.Forms.Label()
        Me.txtSpareWeight = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nudAircraftMaxTO = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTOWeight = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudCargo = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudCabinWeight = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudEmptyWeight = New System.Windows.Forms.NumericUpDown()
        Me.cbxPlane = New System.Windows.Forms.ComboBox()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.nudHeadDir = New System.Windows.Forms.NumericUpDown()
        Me.nudWindDir = New System.Windows.Forms.NumericUpDown()
        Me.nudTrackDir = New System.Windows.Forms.NumericUpDown()
        Me.nudHeadSpd = New System.Windows.Forms.NumericUpDown()
        Me.nudWindSpd = New System.Windows.Forms.NumericUpDown()
        Me.nudTrackSpd = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rbuHead = New System.Windows.Forms.RadioButton()
        Me.rbuTrack = New System.Windows.Forms.RadioButton()
        Me.grpTrack = New System.Windows.Forms.GroupBox()
        Me.txtHeadSpd = New System.Windows.Forms.TextBox()
        Me.txtHeadDir = New System.Windows.Forms.TextBox()
        Me.txtTrackSpd = New System.Windows.Forms.TextBox()
        Me.txtTrackDir = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtEstJnyTime = New System.Windows.Forms.TextBox()
        Me.txtExtJnyFuel = New System.Windows.Forms.TextBox()
        Me.txtAdjustedFuel = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtAdj_TOW = New System.Windows.Forms.TextBox()
        Me.grpReview = New System.Windows.Forms.GroupBox()
        Me.epFuel = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epRange = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epWeight = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epAlternative = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudCruiseAlt = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.nudAiportAlt = New System.Windows.Forms.NumericUpDown()
        Me.grbDescent = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtDtoDesc = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.nudLandSpd = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.nudRoD = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.epDescentRange = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.LlbVersion = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudMaxRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCruiseSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlannedDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsumption.SuspendLayout()
        CType(Me.nudMaxFuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDistToAlternate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFuel.SuspendLayout()
        Me.grpWeight.SuspendLayout()
        CType(Me.nudAircraftMaxTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCabinWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEmptyWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeadDir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWindDir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTrackDir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeadSpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWindSpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTrackSpd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTrack.SuspendLayout()
        Me.grpReview.SuspendLayout()
        CType(Me.epFuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epAlternative, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCruiseAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAiportAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDescent.SuspendLayout()
        CType(Me.nudLandSpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epDescentRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Max Range"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cruise Spd"
        '
        'txtTimeAloft
        '
        Me.txtTimeAloft.Location = New System.Drawing.Point(89, 68)
        Me.txtTimeAloft.Name = "txtTimeAloft"
        Me.txtTimeAloft.ReadOnly = True
        Me.txtTimeAloft.Size = New System.Drawing.Size(54, 20)
        Me.txtTimeAloft.TabIndex = 5
        Me.txtTimeAloft.TabStop = False
        Me.txtTimeAloft.Text = "5"
        Me.txtTimeAloft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtTimeAloft, "Shows maximum time aloft")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time aloft"
        '
        'nudMaxRange
        '
        Me.nudMaxRange.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMaxRange.Location = New System.Drawing.Point(76, 17)
        Me.nudMaxRange.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMaxRange.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudMaxRange.Name = "nudMaxRange"
        Me.nudMaxRange.Size = New System.Drawing.Size(67, 20)
        Me.nudMaxRange.TabIndex = 1
        Me.nudMaxRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudMaxRange, "Select maximum flying range")
        Me.nudMaxRange.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'nudCruiseSpeed
        '
        Me.nudCruiseSpeed.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudCruiseSpeed.Location = New System.Drawing.Point(89, 43)
        Me.nudCruiseSpeed.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCruiseSpeed.Minimum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.nudCruiseSpeed.Name = "nudCruiseSpeed"
        Me.nudCruiseSpeed.Size = New System.Drawing.Size(54, 20)
        Me.nudCruiseSpeed.TabIndex = 3
        Me.nudCruiseSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudCruiseSpeed, "Select Cruise speed")
        Me.nudCruiseSpeed.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'txtFlowRate
        '
        Me.txtFlowRate.Location = New System.Drawing.Point(89, 139)
        Me.txtFlowRate.Name = "txtFlowRate"
        Me.txtFlowRate.ReadOnly = True
        Me.txtFlowRate.Size = New System.Drawing.Size(54, 20)
        Me.txtFlowRate.TabIndex = 9
        Me.txtFlowRate.TabStop = False
        Me.txtFlowRate.Text = "12"
        Me.txtFlowRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtFlowRate, "shows calculated fuel flow rate")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Flow rate (lb/hr)"
        '
        'nudPlannedDistance
        '
        Me.nudPlannedDistance.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPlannedDistance.Location = New System.Drawing.Point(111, 17)
        Me.nudPlannedDistance.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPlannedDistance.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPlannedDistance.Name = "nudPlannedDistance"
        Me.nudPlannedDistance.Size = New System.Drawing.Size(58, 20)
        Me.nudPlannedDistance.TabIndex = 1
        Me.nudPlannedDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudPlannedDistance, "Planned journet distance")
        Me.nudPlannedDistance.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "planned (nm)"
        '
        'grpConsumption
        '
        Me.grpConsumption.Controls.Add(Me.Label5)
        Me.grpConsumption.Controls.Add(Me.txtFlowRate)
        Me.grpConsumption.Controls.Add(Me.Label4)
        Me.grpConsumption.Controls.Add(Me.nudMaxFuel)
        Me.grpConsumption.Controls.Add(Me.nudCruiseSpeed)
        Me.grpConsumption.Controls.Add(Me.nudMaxRange)
        Me.grpConsumption.Controls.Add(Me.Label3)
        Me.grpConsumption.Controls.Add(Me.txtTimeAloft)
        Me.grpConsumption.Controls.Add(Me.Label2)
        Me.grpConsumption.Controls.Add(Me.Label1)
        Me.grpConsumption.Location = New System.Drawing.Point(12, 39)
        Me.grpConsumption.Name = "grpConsumption"
        Me.grpConsumption.Size = New System.Drawing.Size(169, 181)
        Me.grpConsumption.TabIndex = 1
        Me.grpConsumption.TabStop = False
        Me.grpConsumption.Text = "Fuel Consumption"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Max Fuel (lb)"
        '
        'nudMaxFuel
        '
        Me.nudMaxFuel.Location = New System.Drawing.Point(89, 113)
        Me.nudMaxFuel.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.nudMaxFuel.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudMaxFuel.Name = "nudMaxFuel"
        Me.nudMaxFuel.Size = New System.Drawing.Size(54, 20)
        Me.nudMaxFuel.TabIndex = 7
        Me.nudMaxFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudMaxFuel, "Select total fuel capacity (all tanks)")
        Me.nudMaxFuel.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudDistToAlternate
        '
        Me.nudDistToAlternate.Location = New System.Drawing.Point(111, 43)
        Me.nudDistToAlternate.Name = "nudDistToAlternate"
        Me.nudDistToAlternate.Size = New System.Drawing.Size(58, 20)
        Me.nudDistToAlternate.TabIndex = 3
        Me.nudDistToAlternate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudDistToAlternate, "distance from destination to alternative")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "To Alternative (nm)"
        '
        'nudReserve
        '
        Me.nudReserve.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudReserve.Location = New System.Drawing.Point(111, 69)
        Me.nudReserve.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudReserve.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudReserve.Name = "nudReserve"
        Me.nudReserve.Size = New System.Drawing.Size(58, 20)
        Me.nudReserve.TabIndex = 5
        Me.nudReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudReserve, "Reserve flying time to be left in tank upon landing (FAA/CAA requirements) + fuel" &
        " for pre and post flight operations")
        Me.nudReserve.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Reserve (mins)"
        '
        'txtFuelNeeded
        '
        Me.txtFuelNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelNeeded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFuelNeeded.Location = New System.Drawing.Point(111, 149)
        Me.txtFuelNeeded.Name = "txtFuelNeeded"
        Me.txtFuelNeeded.ReadOnly = True
        Me.txtFuelNeeded.Size = New System.Drawing.Size(58, 20)
        Me.txtFuelNeeded.TabIndex = 1
        Me.txtFuelNeeded.TabStop = False
        Me.txtFuelNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtFuelNeeded, "Minimum fuel requirements for flight + diversion at cruise  flow rate + reserve")
        '
        'lblFuelNeeded
        '
        Me.lblFuelNeeded.AutoSize = True
        Me.lblFuelNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelNeeded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFuelNeeded.Location = New System.Drawing.Point(6, 152)
        Me.lblFuelNeeded.Name = "lblFuelNeeded"
        Me.lblFuelNeeded.Size = New System.Drawing.Size(103, 13)
        Me.lblFuelNeeded.TabIndex = 0
        Me.lblFuelNeeded.Text = "Fuel Needed(lbs)"
        '
        'grpFuel
        '
        Me.grpFuel.Controls.Add(Me.Panel1)
        Me.grpFuel.Controls.Add(Me.lblFuelNeeded)
        Me.grpFuel.Controls.Add(Me.txtFuelNeeded)
        Me.grpFuel.Controls.Add(Me.txtEstTime)
        Me.grpFuel.Controls.Add(Me.Label15)
        Me.grpFuel.Controls.Add(Me.txtCalcRange)
        Me.grpFuel.Controls.Add(Me.lblCalcRange)
        Me.grpFuel.Controls.Add(Me.Label8)
        Me.grpFuel.Controls.Add(Me.nudReserve)
        Me.grpFuel.Controls.Add(Me.Label7)
        Me.grpFuel.Controls.Add(Me.nudDistToAlternate)
        Me.grpFuel.Controls.Add(Me.Label6)
        Me.grpFuel.Controls.Add(Me.nudPlannedDistance)
        Me.grpFuel.Location = New System.Drawing.Point(187, 39)
        Me.grpFuel.Name = "grpFuel"
        Me.grpFuel.Size = New System.Drawing.Size(183, 181)
        Me.grpFuel.TabIndex = 2
        Me.grpFuel.TabStop = False
        Me.grpFuel.Text = "Fuel Requirement"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Location = New System.Drawing.Point(0, 142)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 1)
        Me.Panel1.TabIndex = 10
        '
        'txtEstTime
        '
        Me.txtEstTime.Location = New System.Drawing.Point(111, 117)
        Me.txtEstTime.Name = "txtEstTime"
        Me.txtEstTime.ReadOnly = True
        Me.txtEstTime.Size = New System.Drawing.Size(58, 20)
        Me.txtEstTime.TabIndex = 9
        Me.txtEstTime.TabStop = False
        Me.txtEstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtEstTime, "estimated flying time at cruise speed to cover range (will be longer due to lower" &
        " take off and landing speeds)")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Estimated Time"
        '
        'txtCalcRange
        '
        Me.txtCalcRange.Location = New System.Drawing.Point(111, 94)
        Me.txtCalcRange.Name = "txtCalcRange"
        Me.txtCalcRange.ReadOnly = True
        Me.txtCalcRange.Size = New System.Drawing.Size(58, 20)
        Me.txtCalcRange.TabIndex = 7
        Me.txtCalcRange.TabStop = False
        Me.txtCalcRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCalcRange, "estimated range of flight, plus diversion plus using reserve (Will be less due to" &
        " greater burn rate at take off and climbing)")
        '
        'lblCalcRange
        '
        Me.lblCalcRange.AutoSize = True
        Me.lblCalcRange.Location = New System.Drawing.Point(6, 97)
        Me.lblCalcRange.Name = "lblCalcRange"
        Me.lblCalcRange.Size = New System.Drawing.Size(63, 13)
        Me.lblCalcRange.TabIndex = 6
        Me.lblCalcRange.Text = "Calc Range"
        '
        'grpWeight
        '
        Me.grpWeight.Controls.Add(Me.lblSpareWeight)
        Me.grpWeight.Controls.Add(Me.txtSpareWeight)
        Me.grpWeight.Controls.Add(Me.Label14)
        Me.grpWeight.Controls.Add(Me.nudAircraftMaxTO)
        Me.grpWeight.Controls.Add(Me.Label13)
        Me.grpWeight.Controls.Add(Me.txtTOWeight)
        Me.grpWeight.Controls.Add(Me.Label12)
        Me.grpWeight.Controls.Add(Me.nudCargo)
        Me.grpWeight.Controls.Add(Me.Label11)
        Me.grpWeight.Controls.Add(Me.nudCabinWeight)
        Me.grpWeight.Controls.Add(Me.Label10)
        Me.grpWeight.Controls.Add(Me.nudEmptyWeight)
        Me.grpWeight.Location = New System.Drawing.Point(379, 39)
        Me.grpWeight.Name = "grpWeight"
        Me.grpWeight.Size = New System.Drawing.Size(183, 181)
        Me.grpWeight.TabIndex = 4
        Me.grpWeight.TabStop = False
        Me.grpWeight.Text = "Take Off Weight"
        '
        'lblSpareWeight
        '
        Me.lblSpareWeight.AutoSize = True
        Me.lblSpareWeight.Location = New System.Drawing.Point(6, 152)
        Me.lblSpareWeight.Name = "lblSpareWeight"
        Me.lblSpareWeight.Size = New System.Drawing.Size(101, 13)
        Me.lblSpareWeight.TabIndex = 10
        Me.lblSpareWeight.Text = "Spare Capacity (lbs)"
        '
        'txtSpareWeight
        '
        Me.txtSpareWeight.Location = New System.Drawing.Point(108, 149)
        Me.txtSpareWeight.Name = "txtSpareWeight"
        Me.txtSpareWeight.ReadOnly = True
        Me.txtSpareWeight.Size = New System.Drawing.Size(58, 20)
        Me.txtSpareWeight.TabIndex = 11
        Me.txtSpareWeight.TabStop = False
        Me.txtSpareWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtSpareWeight, "calculated spare capacity (maximum less calculated take off weight)")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Specified T/O (lbs)"
        '
        'nudAircraftMaxTO
        '
        Me.nudAircraftMaxTO.Location = New System.Drawing.Point(108, 123)
        Me.nudAircraftMaxTO.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudAircraftMaxTO.Name = "nudAircraftMaxTO"
        Me.nudAircraftMaxTO.Size = New System.Drawing.Size(58, 20)
        Me.nudAircraftMaxTO.TabIndex = 9
        Me.nudAircraftMaxTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudAircraftMaxTO, "maximum takeoff weight")
        Me.nudAircraftMaxTO.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Take-Off Weight"
        '
        'txtTOWeight
        '
        Me.txtTOWeight.Location = New System.Drawing.Point(108, 97)
        Me.txtTOWeight.Name = "txtTOWeight"
        Me.txtTOWeight.ReadOnly = True
        Me.txtTOWeight.Size = New System.Drawing.Size(58, 20)
        Me.txtTOWeight.TabIndex = 7
        Me.txtTOWeight.TabStop = False
        Me.txtTOWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtTOWeight, "calculated weight at take off (plane, fuel, passengers and cargo)")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Cargo (lbs)"
        '
        'nudCargo
        '
        Me.nudCargo.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCargo.Location = New System.Drawing.Point(108, 71)
        Me.nudCargo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudCargo.Name = "nudCargo"
        Me.nudCargo.Size = New System.Drawing.Size(58, 20)
        Me.nudCargo.TabIndex = 5
        Me.nudCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudCargo, "total weight of cargo")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "People (lbs)"
        '
        'nudCabinWeight
        '
        Me.nudCabinWeight.Increment = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudCabinWeight.Location = New System.Drawing.Point(108, 45)
        Me.nudCabinWeight.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.nudCabinWeight.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCabinWeight.Name = "nudCabinWeight"
        Me.nudCabinWeight.Size = New System.Drawing.Size(58, 20)
        Me.nudCabinWeight.TabIndex = 3
        Me.nudCabinWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudCabinWeight, "total weight of pilot, crew and passengers")
        Me.nudCabinWeight.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Empty Weight (lb)"
        '
        'nudEmptyWeight
        '
        Me.nudEmptyWeight.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudEmptyWeight.Location = New System.Drawing.Point(108, 19)
        Me.nudEmptyWeight.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudEmptyWeight.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudEmptyWeight.Name = "nudEmptyWeight"
        Me.nudEmptyWeight.Size = New System.Drawing.Size(58, 20)
        Me.nudEmptyWeight.TabIndex = 1
        Me.nudEmptyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudEmptyWeight, "Empty weight of aircraft")
        Me.nudEmptyWeight.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'cbxPlane
        '
        Me.cbxPlane.FormattingEnabled = True
        Me.cbxPlane.Items.AddRange(New Object() {"Beechcraft Baron 58", "Beechcraft King Air 350", "Cessna C172SP Skyhawk", "Cessna C182S Skylane", "Cessna C208 Caravan Amphibian", "Cessna C208B Grand Caravan", "Mooney Bravo", "Other"})
        Me.cbxPlane.Location = New System.Drawing.Point(23, 12)
        Me.cbxPlane.Name = "cbxPlane"
        Me.cbxPlane.Size = New System.Drawing.Size(191, 21)
        Me.cbxPlane.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cbxPlane, "Select Plane for Standard Parameters")
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 430)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(565, 22)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(65, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Direction"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(141, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Speed (Kn)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Wind (from)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Heading"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Track"
        '
        'nudHeadDir
        '
        Me.nudHeadDir.Location = New System.Drawing.Point(68, 30)
        Me.nudHeadDir.Maximum = New Decimal(New Integer() {361, 0, 0, 0})
        Me.nudHeadDir.Name = "nudHeadDir"
        Me.nudHeadDir.Size = New System.Drawing.Size(61, 20)
        Me.nudHeadDir.TabIndex = 6
        Me.nudHeadDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudHeadDir, "direction of flight")
        Me.nudHeadDir.Value = New Decimal(New Integer() {360, 0, 0, 0})
        '
        'nudWindDir
        '
        Me.nudWindDir.Location = New System.Drawing.Point(68, 56)
        Me.nudWindDir.Maximum = New Decimal(New Integer() {361, 0, 0, 0})
        Me.nudWindDir.Name = "nudWindDir"
        Me.nudWindDir.Size = New System.Drawing.Size(61, 20)
        Me.nudWindDir.TabIndex = 9
        Me.nudWindDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudWindDir, "direction of wind (ie its head to not from as the usual notation)")
        Me.nudWindDir.Value = New Decimal(New Integer() {360, 0, 0, 0})
        '
        'nudTrackDir
        '
        Me.nudTrackDir.Location = New System.Drawing.Point(68, 82)
        Me.nudTrackDir.Maximum = New Decimal(New Integer() {361, 0, 0, 0})
        Me.nudTrackDir.Name = "nudTrackDir"
        Me.nudTrackDir.Size = New System.Drawing.Size(61, 20)
        Me.nudTrackDir.TabIndex = 12
        Me.nudTrackDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudTrackDir, "track over ground")
        Me.nudTrackDir.Value = New Decimal(New Integer() {360, 0, 0, 0})
        '
        'nudHeadSpd
        '
        Me.nudHeadSpd.Location = New System.Drawing.Point(144, 30)
        Me.nudHeadSpd.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudHeadSpd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudHeadSpd.Name = "nudHeadSpd"
        Me.nudHeadSpd.Size = New System.Drawing.Size(57, 20)
        Me.nudHeadSpd.TabIndex = 7
        Me.nudHeadSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudHeadSpd, "Airspeed")
        Me.nudHeadSpd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudWindSpd
        '
        Me.nudWindSpd.Location = New System.Drawing.Point(144, 56)
        Me.nudWindSpd.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudWindSpd.Name = "nudWindSpd"
        Me.nudWindSpd.Size = New System.Drawing.Size(57, 20)
        Me.nudWindSpd.TabIndex = 10
        Me.nudWindSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudWindSpd, "speed of wind")
        '
        'nudTrackSpd
        '
        Me.nudTrackSpd.Location = New System.Drawing.Point(144, 82)
        Me.nudTrackSpd.Maximum = New Decimal(New Integer() {361, 0, 0, 0})
        Me.nudTrackSpd.Name = "nudTrackSpd"
        Me.nudTrackSpd.Size = New System.Drawing.Size(57, 20)
        Me.nudTrackSpd.TabIndex = 13
        Me.nudTrackSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudTrackSpd, "groundspeed")
        Me.nudTrackSpd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(222, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Calculate"
        '
        'rbuHead
        '
        Me.rbuHead.AutoSize = True
        Me.rbuHead.Location = New System.Drawing.Point(243, 32)
        Me.rbuHead.Name = "rbuHead"
        Me.rbuHead.Size = New System.Drawing.Size(14, 13)
        Me.rbuHead.TabIndex = 3
        Me.rbuHead.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbuHead, "calculate heading and speed to acheive track")
        Me.rbuHead.UseVisualStyleBackColor = True
        '
        'rbuTrack
        '
        Me.rbuTrack.AutoSize = True
        Me.rbuTrack.Location = New System.Drawing.Point(243, 84)
        Me.rbuTrack.Name = "rbuTrack"
        Me.rbuTrack.Size = New System.Drawing.Size(14, 13)
        Me.rbuTrack.TabIndex = 4
        Me.rbuTrack.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbuTrack, "calculate track over ground")
        Me.rbuTrack.UseVisualStyleBackColor = True
        '
        'grpTrack
        '
        Me.grpTrack.Controls.Add(Me.txtHeadSpd)
        Me.grpTrack.Controls.Add(Me.txtHeadDir)
        Me.grpTrack.Controls.Add(Me.txtTrackSpd)
        Me.grpTrack.Controls.Add(Me.txtTrackDir)
        Me.grpTrack.Controls.Add(Me.rbuTrack)
        Me.grpTrack.Controls.Add(Me.Label21)
        Me.grpTrack.Controls.Add(Me.rbuHead)
        Me.grpTrack.Controls.Add(Me.nudTrackSpd)
        Me.grpTrack.Controls.Add(Me.nudWindSpd)
        Me.grpTrack.Controls.Add(Me.nudHeadSpd)
        Me.grpTrack.Controls.Add(Me.nudTrackDir)
        Me.grpTrack.Controls.Add(Me.nudWindDir)
        Me.grpTrack.Controls.Add(Me.nudHeadDir)
        Me.grpTrack.Controls.Add(Me.Label20)
        Me.grpTrack.Controls.Add(Me.Label19)
        Me.grpTrack.Controls.Add(Me.Label18)
        Me.grpTrack.Controls.Add(Me.Label17)
        Me.grpTrack.Controls.Add(Me.Label16)
        Me.grpTrack.Location = New System.Drawing.Point(12, 226)
        Me.grpTrack.Name = "grpTrack"
        Me.grpTrack.Size = New System.Drawing.Size(297, 110)
        Me.grpTrack.TabIndex = 5
        Me.grpTrack.TabStop = False
        Me.grpTrack.Text = "Heading/Track Calculator"
        '
        'txtHeadSpd
        '
        Me.txtHeadSpd.BackColor = System.Drawing.Color.White
        Me.txtHeadSpd.Location = New System.Drawing.Point(145, 30)
        Me.txtHeadSpd.Name = "txtHeadSpd"
        Me.txtHeadSpd.ReadOnly = True
        Me.txtHeadSpd.Size = New System.Drawing.Size(41, 20)
        Me.txtHeadSpd.TabIndex = 7
        Me.txtHeadSpd.Text = "1"
        Me.txtHeadSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtHeadSpd, "Airspeed")
        '
        'txtHeadDir
        '
        Me.txtHeadDir.BackColor = System.Drawing.Color.White
        Me.txtHeadDir.Location = New System.Drawing.Point(68, 29)
        Me.txtHeadDir.Name = "txtHeadDir"
        Me.txtHeadDir.ReadOnly = True
        Me.txtHeadDir.Size = New System.Drawing.Size(46, 20)
        Me.txtHeadDir.TabIndex = 6
        Me.txtHeadDir.Text = "1"
        Me.txtHeadDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtHeadDir, "Direction of flight")
        '
        'txtTrackSpd
        '
        Me.txtTrackSpd.BackColor = System.Drawing.Color.White
        Me.txtTrackSpd.Location = New System.Drawing.Point(145, 81)
        Me.txtTrackSpd.Name = "txtTrackSpd"
        Me.txtTrackSpd.ReadOnly = True
        Me.txtTrackSpd.Size = New System.Drawing.Size(41, 20)
        Me.txtTrackSpd.TabIndex = 13
        Me.txtTrackSpd.Text = "1"
        Me.txtTrackSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtTrackSpd, "groundspeed")
        '
        'txtTrackDir
        '
        Me.txtTrackDir.BackColor = System.Drawing.Color.White
        Me.txtTrackDir.Location = New System.Drawing.Point(68, 82)
        Me.txtTrackDir.Name = "txtTrackDir"
        Me.txtTrackDir.ReadOnly = True
        Me.txtTrackDir.Size = New System.Drawing.Size(46, 20)
        Me.txtTrackDir.TabIndex = 12
        Me.txtTrackDir.Text = "1"
        Me.txtTrackDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtTrackDir, "track over ground")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(22, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Est Time for Jny"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(22, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 13)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Adjusted Fuel"
        '
        'txtEstJnyTime
        '
        Me.txtEstJnyTime.Location = New System.Drawing.Point(121, 55)
        Me.txtEstJnyTime.Name = "txtEstJnyTime"
        Me.txtEstJnyTime.ReadOnly = True
        Me.txtEstJnyTime.Size = New System.Drawing.Size(77, 20)
        Me.txtEstJnyTime.TabIndex = 2
        Me.txtEstJnyTime.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtEstJnyTime, "estimate journey time based on planned distance and groundspeed (track)")
        '
        'txtExtJnyFuel
        '
        Me.txtExtJnyFuel.Location = New System.Drawing.Point(121, 80)
        Me.txtExtJnyFuel.Name = "txtExtJnyFuel"
        Me.txtExtJnyFuel.ReadOnly = True
        Me.txtExtJnyFuel.Size = New System.Drawing.Size(77, 20)
        Me.txtExtJnyFuel.TabIndex = 4
        Me.txtExtJnyFuel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtExtJnyFuel, "estimated fule for journey (ignores diversion and reserve)")
        '
        'txtAdjustedFuel
        '
        Me.txtAdjustedFuel.Location = New System.Drawing.Point(121, 106)
        Me.txtAdjustedFuel.Name = "txtAdjustedFuel"
        Me.txtAdjustedFuel.ReadOnly = True
        Me.txtAdjustedFuel.Size = New System.Drawing.Size(77, 20)
        Me.txtAdjustedFuel.TabIndex = 6
        Me.txtAdjustedFuel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtAdjustedFuel, "Adjusted total fuel requirement for new journey file, diversion and reserve")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(22, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Est Fuel for Jny"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Review"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(22, 135)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Adjusted T/O Wt"
        '
        'txtAdj_TOW
        '
        Me.txtAdj_TOW.Location = New System.Drawing.Point(121, 132)
        Me.txtAdj_TOW.Name = "txtAdj_TOW"
        Me.txtAdj_TOW.ReadOnly = True
        Me.txtAdj_TOW.Size = New System.Drawing.Size(77, 20)
        Me.txtAdj_TOW.TabIndex = 8
        Me.txtAdj_TOW.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtAdj_TOW, "Adjusted take off weight using revised fuel weight")
        '
        'grpReview
        '
        Me.grpReview.Controls.Add(Me.txtAdj_TOW)
        Me.grpReview.Controls.Add(Me.Label25)
        Me.grpReview.Controls.Add(Me.Button1)
        Me.grpReview.Controls.Add(Me.Label23)
        Me.grpReview.Controls.Add(Me.txtAdjustedFuel)
        Me.grpReview.Controls.Add(Me.txtExtJnyFuel)
        Me.grpReview.Controls.Add(Me.txtEstJnyTime)
        Me.grpReview.Controls.Add(Me.Label24)
        Me.grpReview.Controls.Add(Me.Label22)
        Me.grpReview.Location = New System.Drawing.Point(343, 226)
        Me.grpReview.Name = "grpReview"
        Me.grpReview.Size = New System.Drawing.Size(219, 169)
        Me.grpReview.TabIndex = 6
        Me.grpReview.TabStop = False
        Me.grpReview.Text = "Review Fuel/Weight"
        '
        'epFuel
        '
        Me.epFuel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epFuel.ContainerControl = Me
        '
        'epRange
        '
        Me.epRange.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epRange.ContainerControl = Me
        '
        'epWeight
        '
        Me.epWeight.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epWeight.ContainerControl = Me
        '
        'epAlternative
        '
        Me.epAlternative.ContainerControl = Me
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Cruise Alt"
        '
        'nudCruiseAlt
        '
        Me.nudCruiseAlt.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCruiseAlt.Location = New System.Drawing.Point(82, 14)
        Me.nudCruiseAlt.Maximum = New Decimal(New Integer() {40000, 0, 0, 0})
        Me.nudCruiseAlt.Name = "nudCruiseAlt"
        Me.nudCruiseAlt.Size = New System.Drawing.Size(61, 20)
        Me.nudCruiseAlt.TabIndex = 8
        Me.nudCruiseAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(154, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "A/port Alt"
        '
        'nudAiportAlt
        '
        Me.nudAiportAlt.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudAiportAlt.Location = New System.Drawing.Point(212, 14)
        Me.nudAiportAlt.Maximum = New Decimal(New Integer() {25000, 0, 0, 0})
        Me.nudAiportAlt.Name = "nudAiportAlt"
        Me.nudAiportAlt.Size = New System.Drawing.Size(70, 20)
        Me.nudAiportAlt.TabIndex = 10
        Me.nudAiportAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grbDescent
        '
        Me.grbDescent.Controls.Add(Me.Label30)
        Me.grbDescent.Controls.Add(Me.txtDtoDesc)
        Me.grbDescent.Controls.Add(Me.Label29)
        Me.grbDescent.Controls.Add(Me.nudLandSpd)
        Me.grbDescent.Controls.Add(Me.Label28)
        Me.grbDescent.Controls.Add(Me.nudRoD)
        Me.grbDescent.Controls.Add(Me.Label27)
        Me.grbDescent.Controls.Add(Me.nudAiportAlt)
        Me.grbDescent.Controls.Add(Me.Label26)
        Me.grbDescent.Controls.Add(Me.nudCruiseAlt)
        Me.grbDescent.Controls.Add(Me.Label9)
        Me.grbDescent.Location = New System.Drawing.Point(12, 339)
        Me.grbDescent.Name = "grbDescent"
        Me.grbDescent.Size = New System.Drawing.Size(297, 91)
        Me.grbDescent.TabIndex = 11
        Me.grbDescent.TabStop = False
        Me.grbDescent.Text = "Start of Descent"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(149, 66)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(0, 13)
        Me.Label30.TabIndex = 17
        '
        'txtDtoDesc
        '
        Me.txtDtoDesc.Location = New System.Drawing.Point(115, 63)
        Me.txtDtoDesc.Name = "txtDtoDesc"
        Me.txtDtoDesc.ReadOnly = True
        Me.txtDtoDesc.Size = New System.Drawing.Size(71, 20)
        Me.txtDtoDesc.TabIndex = 16
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(41, 66)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 13)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "Dist for Desc"
        '
        'nudLandSpd
        '
        Me.nudLandSpd.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLandSpd.Location = New System.Drawing.Point(212, 39)
        Me.nudLandSpd.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudLandSpd.Minimum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.nudLandSpd.Name = "nudLandSpd"
        Me.nudLandSpd.Size = New System.Drawing.Size(70, 20)
        Me.nudLandSpd.TabIndex = 14
        Me.nudLandSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudLandSpd.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(154, 39)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 13)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Land spd"
        '
        'nudRoD
        '
        Me.nudRoD.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudRoD.Location = New System.Drawing.Point(82, 37)
        Me.nudRoD.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.nudRoD.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudRoD.Name = "nudRoD"
        Me.nudRoD.Size = New System.Drawing.Size(61, 20)
        Me.nudRoD.TabIndex = 12
        Me.nudRoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudRoD.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 39)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 13)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Rate of Desc"
        '
        'epDescentRange
        '
        Me.epDescentRange.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epDescentRange.ContainerControl = Me
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(406, 10)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 12
        Me.btnHelp.Text = "&Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Location = New System.Drawing.Point(487, 10)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 13
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'LlbVersion
        '
        Me.LlbVersion.AutoSize = True
        Me.LlbVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbVersion.Location = New System.Drawing.Point(538, 441)
        Me.LlbVersion.Name = "LlbVersion"
        Me.LlbVersion.Size = New System.Drawing.Size(24, 9)
        Me.LlbVersion.TabIndex = 14
        Me.LlbVersion.Text = "V1.00"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(575, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 452)
        Me.Controls.Add(Me.LlbVersion)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.grbDescent)
        Me.Controls.Add(Me.grpReview)
        Me.Controls.Add(Me.grpTrack)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.cbxPlane)
        Me.Controls.Add(Me.grpWeight)
        Me.Controls.Add(Me.grpFuel)
        Me.Controls.Add(Me.grpConsumption)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(585, 495)
        Me.MinimumSize = New System.Drawing.Size(585, 495)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fuel and Weight Planner"
        CType(Me.nudMaxRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCruiseSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlannedDistance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsumption.ResumeLayout(False)
        Me.grpConsumption.PerformLayout()
        CType(Me.nudMaxFuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDistToAlternate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudReserve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFuel.ResumeLayout(False)
        Me.grpFuel.PerformLayout()
        Me.grpWeight.ResumeLayout(False)
        Me.grpWeight.PerformLayout()
        CType(Me.nudAircraftMaxTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCabinWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEmptyWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeadDir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWindDir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTrackDir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeadSpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWindSpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTrackSpd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTrack.ResumeLayout(False)
        Me.grpTrack.PerformLayout()
        Me.grpReview.ResumeLayout(False)
        Me.grpReview.PerformLayout()
        CType(Me.epFuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epAlternative, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCruiseAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAiportAlt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDescent.ResumeLayout(False)
        Me.grbDescent.PerformLayout()
        CType(Me.nudLandSpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epDescentRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTimeAloft As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudMaxRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCruiseSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtFlowRate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudPlannedDistance As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpConsumption As System.Windows.Forms.GroupBox
    Friend WithEvents nudDistToAlternate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudReserve As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFuelNeeded As System.Windows.Forms.TextBox
    Friend WithEvents lblFuelNeeded As System.Windows.Forms.Label
    Friend WithEvents grpFuel As System.Windows.Forms.GroupBox
    Friend WithEvents grpWeight As System.Windows.Forms.GroupBox
    Friend WithEvents nudEmptyWeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTOWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nudCargo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nudCabinWeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSpareWeight As System.Windows.Forms.Label
    Friend WithEvents txtSpareWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nudAircraftMaxTO As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxPlane As System.Windows.Forms.ComboBox
    Friend WithEvents txtCalcRange As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcRange As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents txtEstTime As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents nudHeadDir As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudWindDir As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudTrackDir As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHeadSpd As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudWindSpd As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudTrackSpd As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents rbuHead As System.Windows.Forms.RadioButton
    Friend WithEvents rbuTrack As System.Windows.Forms.RadioButton
    Friend WithEvents grpTrack As System.Windows.Forms.GroupBox
    Friend WithEvents txtTrackDir As System.Windows.Forms.TextBox
    Friend WithEvents txtTrackSpd As System.Windows.Forms.TextBox
    Friend WithEvents txtHeadSpd As System.Windows.Forms.TextBox
    Friend WithEvents txtHeadDir As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtEstJnyTime As System.Windows.Forms.TextBox
    Friend WithEvents txtExtJnyFuel As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustedFuel As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtAdj_TOW As System.Windows.Forms.TextBox
    Friend WithEvents grpReview As System.Windows.Forms.GroupBox
    Friend WithEvents epFuel As System.Windows.Forms.ErrorProvider
    Friend WithEvents epRange As System.Windows.Forms.ErrorProvider
    Friend WithEvents epWeight As System.Windows.Forms.ErrorProvider
    Friend WithEvents epAlternative As System.Windows.Forms.ErrorProvider
    Friend WithEvents nudCruiseAlt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grbDescent As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents nudAiportAlt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents nudLandSpd As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents nudRoD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtDtoDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents epDescentRange As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudMaxFuel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents LlbVersion As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
