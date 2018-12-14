'FlightPlanner.vb
' (C) D.Parsons 2008
'
'Enables rough calculation of fuel required for flight
' and direction to allow for average wind condition
'
' 1.00 DAP 01/01/08 Initial Version
' 1.01 DAP 11/06/08 Tidy error messages and help, Add tooltips
' 1.02 DAP 28/08/09 Correct Wind correction calculation and allow for larger aircraft
'
Imports System.Math
Public Class Form1
    Dim bLoaded = False ' to prevent start up causing validation failures
    Dim iWindX As Double
    Dim iWindY As Double
    Dim iInter As Double
    Dim iHeadX As Double
    Dim iHeadY As Double
    Dim iTrackX As Double
    Dim itrackY As Double
    Dim sConnectChar = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlbVersion.Text = "1.02"
        bLoaded = False
        cbxPlane.SelectedItem = "Cessna C172SP Skyhawk"
        nudHeadDir.Visible = True
        nudHeadSpd.Visible = True
        nudTrackDir.Visible = False
        nudTrackSpd.Visible = False
        txtTrackDir.Visible = True
        txtTrackSpd.Visible = True
        txtHeadDir.Visible = False
        txtHeadSpd.Visible = False
        rbuTrack.Checked = True
        nudHeadSpd.Value = nudCruiseSpeed.Value
        FuelSub1()
        bLoaded = True
        sCalcDescDist()
    End Sub

    Sub WeightSub1()
        txtTOWeight.Text = Round(txtFuelNeeded.Text + nudEmptyWeight.Value + nudCabinWeight.Value + nudCargo.Value, 0)
        txtSpareWeight.Text = Round(nudAircraftMaxTO.Value - txtTOWeight.Text, 0)
        StatusBar1.Text = ""
        sConnectChar = ""
        If txtFuelNeeded.Text > nudMaxFuel.Value Then
            StatusBar1.Text = "OVER Fuel Capacity (lbs)"
            lblFuelNeeded.ForeColor = Color.Red
            txtFuelNeeded.BackColor = Color.Red
            epFuel.SetError(txtFuelNeeded, "Cannot over-fill fuel tank")
            epFuel.SetError(nudPlannedDistance, "Select closer destination to reduce fuel requirement")
            epFuel.SetError(nudDistToAlternate, "Select nearer alternative to reduce fuel requirment")
            epFuel.SetError(nudReserve, "Reduce Reserve time to reduce fuel requirement")
            sConnectChar = ": "
        Else
            lblFuelNeeded.ForeColor = Color.Green
            txtFuelNeeded.BackColor = Color.Gainsboro
            epFuel.Clear()
        End If
        If txtSpareWeight.Text < 0 Then
            StatusBar1.Text = StatusBar1.Text & sConnectChar & "OVER T/O Weight (lbs)"
            lblSpareWeight.ForeColor = Color.Red
            txtSpareWeight.BackColor = Color.Red
            sConnectChar = ": "
            epWeight.SetError(txtTOWeight, "Over maximum Take-Off Weight")
            epWeight.SetError(nudCabinWeight, "Reduce number of Passengers to lower cabin weight")
            epWeight.SetError(nudCargo, "Lighten cargo weight")
            epWeight.SetError(txtCalcRange, "Select closer destination or alternative or Reserve to lighten fuel load")
        Else
            lblSpareWeight.ForeColor = Color.Black
            txtSpareWeight.BackColor = Color.Gainsboro
            epWeight.Clear()
        End If
        txtCalcRange.Text = Round(nudPlannedDistance.Value + nudDistToAlternate.Value + (nudCruiseSpeed.Value * nudReserve.Value / 60), 2)
        If txtCalcRange.Text > nudMaxRange.Value Then
            StatusBar1.Text = StatusBar1.Text & sConnectChar & "BEYOND Maximum Range (NM)"
            lblCalcRange.ForeColor = Color.Red
            txtCalcRange.BackColor = Color.Red
            epRange.SetError(txtCalcRange, "Total Distance greater than maximum range")
            epRange.SetError(nudPlannedDistance, "Select closer destination to reduce range")
            epRange.SetError(nudDistToAlternate, "Select nearer alternative to reduce range")
            epRange.SetError(nudReserve, "Reduce Reserve to reduce range")
            sConnectChar = ": "
        Else
            lblCalcRange.ForeColor = Color.Black
            txtCalcRange.BackColor = Color.Gainsboro
            epRange.Clear()
        End If
        If nudDistToAlternate.Value = 0 Then
            nudDistToAlternate.ForeColor() = Color.Red
            StatusBar1.Text = StatusBar1.Text & sConnectChar & "No Alternative Destination Selected"
            epAlternative.SetError(nudDistToAlternate, "No alternative destination distance entered")
            sConnectChar = ": "
        Else
            nudDistToAlternate.ForeColor() = Color.Black
            epAlternative.Clear()
        End If
        txtEstTime.Text = Round(txtCalcRange.Text / nudCruiseSpeed.Value, 2)
    End Sub
    Sub FuelSub1()
        txtTimeAloft.Text = Round(nudMaxRange.Value / nudCruiseSpeed.Value, 2)
        txtFlowRate.Text = Round(nudMaxFuel.Value / txtTimeAloft.Text, 2)
        txtFuelNeeded.Text = Round((((nudPlannedDistance.Value + nudDistToAlternate.Value) / nudCruiseSpeed.Value) + (nudReserve.Value / 60)) * txtFlowRate.Text, 0)
        WeightSub1()
    End Sub
    Sub sCalcDescDist()
        If bLoaded Then
            epDescentRange.Clear()
            Dim iDrop As Integer
            Dim iTimetoDesc As Double
            Dim iAveSpd As Integer
            Dim IDtoDesc As Integer
            iDrop = nudCruiseAlt.Value - nudAiportAlt.Value     ' in feet
            iTimetoDesc = iDrop / nudRoD.Value            ' in Minutes
            iAveSpd = (nudLandSpd.Value + nudCruiseSpeed.Value) / 2 'in Nm per hour
            IDtoDesc = Int(iTimetoDesc * iAveSpd / 60)
            txtDtoDesc.Text = IDtoDesc.ToString()
            If IDtoDesc > nudPlannedDistance.Value Then
                epDescentRange.SetError(txtDtoDesc, "Check Altitude/Rate of Desc: Distance greater than planned journey")
            ElseIf IDtoDesc > nudPlannedDistance.Value / 2 Then
                epDescentRange.SetError(txtDtoDesc, "Check Altitude/Rate of Desc: Distance greater than half the planned journey")
            Else
                epDescentRange.Clear()
            End If
        End If
    End Sub
    Private Sub Range_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMaxRange.ValueChanged, nudCruiseSpeed.ValueChanged, nudMaxFuel.ValueChanged, nudReserve.ValueChanged, nudPlannedDistance.ValueChanged, nudDistToAlternate.ValueChanged
        If bLoaded Then
            FuelSub1()
            sCalcDescDist()
        End If
    End Sub
    Private Sub Weight_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCargo.ValueChanged, nudAircraftMaxTO.ValueChanged, nudEmptyWeight.ValueChanged, nudCabinWeight.ValueChanged
        If bLoaded Then
            WeightSub1()
        End If
    End Sub
    Private Sub cbxPlane_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPlane.SelectedIndexChanged
        If cbxPlane.SelectedItem = "Beechcraft Baron 58" Then
            nudCruiseSpeed.Value = 200
            nudMaxRange.Value = 1569
            nudMaxFuel.Value = 2224
            nudEmptyWeight.Value = 3911
            nudAircraftMaxTO.Value = 5524
            nudCruiseAlt.Value = 10000
        ElseIf cbxPlane.SelectedItem = "Beechcraft King Air 350" Then
            nudCruiseSpeed.Value = 315
            nudMaxRange.Value = 1765
            nudMaxFuel.Value = 3610
            nudEmptyWeight.Value = 9090
            nudAircraftMaxTO.Value = 15000
            nudCruiseAlt.Value = 10000
        ElseIf cbxPlane.SelectedItem = "Cessna C172SP Skyhawk" Then
            nudCruiseSpeed.Value = 124
            nudMaxRange.Value = 638
            nudMaxFuel.Value = 318
            nudEmptyWeight.Value = 1665
            nudAircraftMaxTO.Value = 2550
            nudCruiseAlt.Value = 8000
        ElseIf cbxPlane.SelectedItem = "Cessna C182S Skylane" Then
            nudCruiseSpeed.Value = 140
            nudMaxRange.Value = 968
            nudMaxFuel.Value = 552
            nudEmptyWeight.Value = 1810
            nudAircraftMaxTO.Value = 3110
            nudCruiseAlt.Value = 8000
        ElseIf cbxPlane.SelectedItem = "Cessna C208 Caravan Amphibian" Then
            nudCruiseSpeed.Value = 143
            nudMaxRange.Value = 638
            nudMaxFuel.Value = 2224
            nudEmptyWeight.Value = 4895
            nudAircraftMaxTO.Value = 8035
            nudCruiseAlt.Value = 6000
        ElseIf cbxPlane.SelectedItem = "Cessna C208B Grand Caravan" Then
            nudCruiseSpeed.Value = 164
            nudMaxRange.Value = 638
            nudMaxFuel.Value = 2224
            nudEmptyWeight.Value = 4575
            nudAircraftMaxTO.Value = 8785
            nudCruiseAlt.Value = 7000
        ElseIf cbxPlane.SelectedItem = "Mooney(Bravo)" Then
            nudCruiseSpeed.Value = 195
            nudMaxRange.Value = 1050
            nudMaxFuel.Value = 570
            nudEmptyWeight.Value = 2189
            nudAircraftMaxTO.Value = 3368
            nudCruiseAlt.Value = 8000
        Else
            nudCruiseSpeed.Value = 100
            nudMaxRange.Value = 500
            nudMaxFuel.Value = 100
            nudEmptyWeight.Value = 1000
            nudAircraftMaxTO.Value = 2000
            nudCruiseAlt.Value = 3000
        End If
        nudHeadSpd.Value = nudCruiseSpeed.Value
        FuelSub1()
    End Sub

    Private Sub Vectors_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudHeadDir.ValueChanged, nudWindSpd.ValueChanged, nudWindDir.ValueChanged, nudTrackSpd.ValueChanged, nudTrackDir.ValueChanged, nudHeadSpd.ValueChanged
        If bLoaded Then
            If nudHeadDir.Value < 1 Then
                nudHeadDir.Value = 360
            ElseIf nudHeadDir.Value > 360 Then
                nudHeadDir.Value = nudHeadDir.Value - 360
            End If
            If nudWindDir.Value < 1 Then
                nudWindDir.Value = 360
            ElseIf nudWindDir.Value > 360 Then
                nudWindDir.Value = nudWindDir.Value - 360
            End If
            If nudTrackDir.Value < 1 Then
                nudTrackDir.Value = 360
            ElseIf nudTrackDir.Value > 360 Then
                nudTrackDir.Value = nudTrackDir.Value - 360
            End If
            iWindX = nudWindSpd.Value * Cos(nudWindDir.Value * PI / 180)
            iWindY = nudWindSpd.Value * Sin(nudWindDir.Value * PI / 180)
            If rbuTrack.Checked = True Then
                iHeadX = nudHeadSpd.Value * Cos(nudHeadDir.Value * PI / 180)
                iHeadY = nudHeadSpd.Value * Sin(nudHeadDir.Value * PI / 180)
                iInter = Round(Atan2(-iWindY + iHeadY, -iWindX + iHeadX) * 180 / PI, 0)
                If iInter < 1 Then
                    txtTrackDir.Text = iInter + 360
                Else
                    txtTrackDir.Text = iInter
                End If
                txtTrackSpd.Text = Round(Sqrt((-iWindX + iHeadX) ^ 2 + (-iWindY + iHeadY) ^ 2), 0)
                If txtTrackSpd.Text < 1 Then
                    txtTrackSpd.Text = 1
                End If
                nudTrackDir.Value = txtTrackDir.Text
                nudTrackSpd.Value = txtTrackSpd.Text
                txtHeadDir.Text = nudHeadDir.Value
                txtHeadSpd.Text = nudHeadSpd.Value
            Else
                iTrackX = nudTrackSpd.Value * Cos(nudTrackDir.Value * PI / 180)
                itrackY = nudTrackSpd.Value * Sin(nudTrackDir.Value * PI / 180)
                iInter = Round(Atan2(itrackY + iWindY, iTrackX + iWindX) * 180 / PI, 0)
                If iInter < 1 Then
                    txtHeadDir.Text = iInter + 360
                Else
                    txtHeadDir.Text = iInter
                End If
                txtHeadSpd.Text = Round(Sqrt((iTrackX + iWindX) ^ 2 + (itrackY + iWindY) ^ 2), 0)
                If txtHeadSpd.Text < 1 Then
                    txtHeadSpd.Text = 1
                End If
                nudHeadDir.Value = txtHeadDir.Text
                nudHeadSpd.Value = txtHeadSpd.Text
                txtTrackDir.Text = nudTrackDir.Value
                txtTrackSpd.Text = nudTrackSpd.Value
            End If
        End If
    End Sub

    Private Sub rbuHead_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbuHead.CheckedChanged
        If bLoaded Then
            nudHeadDir.Visible = False
            nudHeadSpd.Visible = False
            nudTrackDir.Visible = True
            nudTrackSpd.Visible = True
            txtTrackDir.Visible = False
            txtTrackSpd.Visible = False
            txtHeadDir.Visible = True
            txtHeadSpd.Visible = True
        End If
    End Sub

    Private Sub rbuTrack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbuTrack.CheckedChanged
        If bLoaded Then
            nudHeadDir.Visible = True
            nudHeadSpd.Visible = True
            nudTrackDir.Visible = False
            nudTrackSpd.Visible = False
            txtTrackDir.Visible = True
            txtTrackSpd.Visible = True
            txtHeadDir.Visible = False
            txtHeadSpd.Visible = False
        End If
    End Sub

    Private Sub Descent_Range(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCruiseAlt.ValueChanged, nudAiportAlt.ValueChanged, nudRoD.ValueChanged, nudLandSpd.ValueChanged
        sCalcDescDist()
    End Sub

    Private Sub btnReview(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtEstJnyTime.Text = Round(nudPlannedDistance.Value / txtTrackSpd.Text, 2)
        txtExtJnyFuel.Text = Round(txtEstJnyTime.Text * txtFlowRate.Text, 0)
        txtAdjustedFuel.Text = Round(((nudDistToAlternate.Value / nudCruiseSpeed.Value) + (nudReserve.Value / 60) + txtEstJnyTime.Text) * txtFlowRate.Text, 0)
        txtAdj_TOW.Text = Round(txtAdjustedFuel.Text + nudEmptyWeight.Value + nudCabinWeight.Value + nudCargo.Value, 0)
        If txtAdj_TOW.Text > nudAircraftMaxTO.Value Then
            txtAdj_TOW.BackColor = Color.Red
        Else
            txtAdj_TOW.BackColor = Color.Gainsboro
        End If
        If txtAdjustedFuel.Text > nudMaxFuel.Value Then
            txtAdjustedFuel.BackColor = Color.Red
        Else
            txtAdjustedFuel.BackColor = Color.Gainsboro
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click, HelpToolStripMenuItem.Click
        MsgBox("General Help" & vbCr & _
               "Select an Aircraft to set up standard aircraft parameter" & vbCr & _
               "these can be changed to match your parameters" & vbCr & _
               "Provide Journey details and Takeoff requirements" & vbCr & _
               "Use current weather to modify flight speed and time" & vbCr & _
               "(not wind direction is that the wind is blowing to" & vbCr & _
               "not coming from as is the ususal convention) and " & _
               "review selected fuel requirements with the [Review] button" & _
               "When to start descent and slowing down can be calculated by providing the details" & vbCr & _
               "Rollover each field for appropriate tool tips", _
               , "Help")
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        MsgBox("Flight and Fuel Planner Version " & LlbVersion.Text & " by D.Parsons", , "About")
    End Sub


    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
