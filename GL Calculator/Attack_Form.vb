Public Class Attack_Form

    Dim specialweapon_number, researchedweapon_number, installedweapon_number As Integer
    Dim installedweapons_string As String
    Dim sw_attack, rw_attack, tac_attack, mw_attack As Integer
    Public full_attack As Decimal
    Private Function RWAttackStrength(ByVal IDCode As Integer) As Integer
        RWAttackStrength = 0
        If IDCode = 0 Then
            RWAttackStrength = 1
        ElseIf IDCode = 1 Then
            RWAttackStrength = 2
        ElseIf IDCode = 2 Then
            RWAttackStrength = 3
        ElseIf IDCode = 3 Then
            RWAttackStrength = 5
        ElseIf IDCode = 4 Then
            RWAttackStrength = 7
        ElseIf IDCode = 5 Then
            RWAttackStrength = 12
        ElseIf IDCode = 6 Then
            RWAttackStrength = 15
        ElseIf IDCode = 7 Then
            RWAttackStrength = 18
        ElseIf IDCode = 8 Then
            RWAttackStrength = 25
        ElseIf IDCode = 9 Then
            RWAttackStrength = 29
        ElseIf IDCode = 10 Then
            RWAttackStrength = 33
        ElseIf IDCode = 11 Then
            RWAttackStrength = 42
        ElseIf IDCode = 12 Then
            RWAttackStrength = 47
        ElseIf IDCode = 13 Then
            RWAttackStrength = 52
        ElseIf IDCode = 14 Then
            RWAttackStrength = 63
        ElseIf IDCode = 15 Then
            RWAttackStrength = 69
        ElseIf IDCode = 16 Then
            RWAttackStrength = 75
        ElseIf IDCode = 17 Then
            RWAttackStrength = 88
        ElseIf IDCode = 18 Then
            RWAttackStrength = 95
        ElseIf IDCode = 19 Then
            RWAttackStrength = 102
        ElseIf IDCode = 20 Then
            RWAttackStrength = 117
        ElseIf IDCode = 21 Then
            RWAttackStrength = 125
        ElseIf IDCode = 22 Then
            RWAttackStrength = 133
        ElseIf IDCode = 23 Then
            RWAttackStrength = 150
        ElseIf IDCode = 24 Then
            RWAttackStrength = 159
        ElseIf IDCode = 25 Then
            RWAttackStrength = 168
        ElseIf IDCode = 26 Then
            RWAttackStrength = 187
        ElseIf IDCode = 27 Then
            RWAttackStrength = 197
        ElseIf IDCode = 28 Then
            RWAttackStrength = 207
        ElseIf IDCode = 29 Then
            RWAttackStrength = 228
        ElseIf IDCode = 30 Then
            RWAttackStrength = 239
        ElseIf IDCode = 31 Then
            RWAttackStrength = 250
        ElseIf IDCode = 32 Then
            RWAttackStrength = 274
        ElseIf IDCode = 33 Then
            RWAttackStrength = 287
        ElseIf IDCode = 34 Then
            RWAttackStrength = 300
        ElseIf IDCode = 35 Then
            RWAttackStrength = 328
        ElseIf IDCode = 36 Then
            RWAttackStrength = 343
        ElseIf IDCode = 37 Then
            RWAttackStrength = 358
        ElseIf IDCode = 38 Then
            RWAttackStrength = 391
        ElseIf IDCode = 39 Then
            RWAttackStrength = 409
        ElseIf IDCode = 40 Then
            RWAttackStrength = 430
        End If
        Return RWAttackStrength
    End Function
    Private Function SWAttackStrength(ByVal IDcode As Integer) As Integer
        SWAttackStrength = 0
        If IDcode = 0 Then
            SWAttackStrength = 20
        ElseIf IDcode = 1 Then
            SWAttackStrength = 30
        ElseIf IDcode = 2 Then
            SWAttackStrength = 80
        ElseIf IDcode = 3 Then
            SWAttackStrength = 80
        ElseIf IDcode = 4 Then
            SWAttackStrength = 25
        ElseIf IDcode = 5 Then
            SWAttackStrength = 40
        ElseIf IDcode = 6 Then
            SWAttackStrength = 230
        ElseIf IDcode = 7 Then
            SWAttackStrength = 50
        ElseIf IDcode = 8 Then
            SWAttackStrength = 90
        ElseIf IDcode = 9 Then
            SWAttackStrength = 150
        ElseIf IDcode = 10 Then
            SWAttackStrength = 30
        ElseIf IDcode = 11 Then
            SWAttackStrength = 60
        ElseIf IDcode = 12 Then
            SWAttackStrength = 80
        ElseIf IDcode = 13 Then
            SWAttackStrength = 100
        ElseIf IDcode = 14 Then
            SWAttackStrength = 35
        ElseIf IDcode = 15 Then
            SWAttackStrength = 40
        ElseIf IDcode = 16 Then
            SWAttackStrength = 30
        ElseIf IDcode = 17 Then
            SWAttackStrength = 30
        ElseIf IDcode = 18 Then
            SWAttackStrength = 75
        ElseIf IDcode = 19 Then
            SWAttackStrength = 20
        ElseIf IDcode = 20 Then
            SWAttackStrength = 40
        ElseIf IDcode = 21 Then
            SWAttackStrength = 20
        ElseIf IDcode = 22 Then
            SWAttackStrength = 45
        ElseIf IDcode = 23 Then
            SWAttackStrength = 30
        ElseIf IDcode = 24 Then
            SWAttackStrength = 40
        ElseIf IDcode = 25 Then
            SWAttackStrength = 60
        ElseIf IDcode = 26 Then
            SWAttackStrength = 100
        ElseIf IDcode = 27 Then
            SWAttackStrength = 150
        ElseIf IDcode = 28 Then
            SWAttackStrength = 200
        ElseIf IDcode = 29 Then
            SWAttackStrength = 300
        ElseIf IDcode = 30 Then
            SWAttackStrength = 400
        ElseIf IDcode = 31 Then
            SWAttackStrength = 550
        ElseIf IDcode = 32 Then
            SWAttackStrength = 675
        ElseIf IDcode = 33 Then
            SWAttackStrength = 75
        ElseIf IDcode = 34 Then
            SWAttackStrength = 55
        ElseIf IDcode = 35 Then
            SWAttackStrength = 160
        ElseIf IDcode = 36 Then
            SWAttackStrength = 75
        End If
        Return SWAttackStrength
    End Function
    Private Function PLAttackStrength(ByVal IDcode As Integer) As Integer
        PLAttackStrength = 0
        If IDcode = 0 Then
            PLAttackStrength = 20
        ElseIf IDcode = 1 Then
            PLAttackStrength = 30
        ElseIf IDcode = 2 Then
            PLAttackStrength = 80
        ElseIf IDcode = 3 Then
            PLAttackStrength = 80
        ElseIf IDcode = 4 Then
            PLAttackStrength = 25
        ElseIf IDcode = 5 Then
            PLAttackStrength = 40
        ElseIf IDcode = 6 Then
            PLAttackStrength = 230
        ElseIf IDcode = 7 Then
            PLAttackStrength = 50
        ElseIf IDcode = 8 Then
            PLAttackStrength = 90
        ElseIf IDcode = 9 Then
            PLAttackStrength = 150
        ElseIf IDcode = 10 Then
            PLAttackStrength = 60
        ElseIf IDcode = 11 Then
            PLAttackStrength = 30
        ElseIf IDcode = 12 Then
            PLAttackStrength = 60
        ElseIf IDcode = 13 Then
            PLAttackStrength = 80
        ElseIf IDcode = 14 Then
            PLAttackStrength = 100
        ElseIf IDcode = 15 Then
            PLAttackStrength = 35
        ElseIf IDcode = 16 Then
            PLAttackStrength = 40
        ElseIf IDcode = 17 Then
            PLAttackStrength = 30
        ElseIf IDcode = 18 Then
            PLAttackStrength = 30
        ElseIf IDcode = 19 Then
            PLAttackStrength = 75
        ElseIf IDcode = 20 Then
            PLAttackStrength = 20
        ElseIf IDcode = 21 Then
            PLAttackStrength = 40
        ElseIf IDcode = 22 Then
            PLAttackStrength = 20
        ElseIf IDcode = 23 Then
            PLAttackStrength = 45
        ElseIf IDcode = 24 Then
            PLAttackStrength = 30
        ElseIf IDcode = 25 Then
            PLAttackStrength = 40
        ElseIf IDcode = 26 Then
            PLAttackStrength = 60
        ElseIf IDcode = 27 Then
            PLAttackStrength = 100
        ElseIf IDcode = 28 Then
            PLAttackStrength = 150
        ElseIf IDcode = 29 Then
            PLAttackStrength = 200
        ElseIf IDcode = 30 Then
            PLAttackStrength = 300
        ElseIf IDcode = 31 Then
            PLAttackStrength = 400
        ElseIf IDcode = 32 Then
            PLAttackStrength = 550
        ElseIf IDcode = 33 Then
            PLAttackStrength = 675
        ElseIf IDcode = 34 Then
            PLAttackStrength = 75
        ElseIf IDcode = 35 Then
            PLAttackStrength = 200
        ElseIf IDcode = 36 Then
            PLAttackStrength = 55
        ElseIf IDcode = 37 Then
            PLAttackStrength = 160
        ElseIf IDcode = 38 Then
            PLAttackStrength = 75
        End If
        Return PLAttackStrength
    End Function
    Private Sub rw_add_button_Click(sender As System.Object, e As System.EventArgs) Handles rw_add_button.Click
        If rw_listbox.SelectedIndex > -1 Then
            If rw_numberselect_combobox.SelectedIndex > -1 Then
                researchedweapon_number = rw_numberselect_combobox.SelectedItem
                If researchedweapon_number + installedweapon_number < 9 Then

                    installedweapon_number += researchedweapon_number
                    installedweapons_string += "Researched Weapons:" & Environment.NewLine
                    installedweapons_string += rw_listbox.SelectedItem & "  x" & researchedweapon_number
                    installedweapons_textbox.Text = installedweapons_string
                    installedweapons_string += Environment.NewLine
                    rw_attack += rw_numberselect_combobox.SelectedItem * RWAttackStrength(IDCode:=rw_listbox.SelectedIndex)

                Else
                    MessageBox.Show("Your ship can only carry up to eight researched weapon modules." & Environment.NewLine & "Please adjust your selection accordingly.", "More than 8 weapons!")
                    rw_numberselect_combobox.Focus()
                    Return
                End If
            Else
                MessageBox.Show("Please select a number of installed modules" & Environment.NewLine & "before attempting calculations.", "No number of weapons selected")
                rw_numberselect_combobox.Focus()
                Return
            End If


        Else

            MessageBox.Show("Please select a weapon type" & Environment.NewLine & "attempting calculations.", "No selected weapon type")
            rw_listbox.Focus()
            Return
        End If
        rw_listbox.ClearSelected()
        rw_numberselect_combobox.SelectedIndex = -1
    End Sub

    Private Sub rw_reset_button_Click(sender As System.Object, e As System.EventArgs) Handles rw_reset_button.Click
        installedweapons_textbox.Clear()
        installedweapons_string = ""
        attack_textbox.Clear()
        tac_officers_textbox.Clear()
        mteir_combobox.SelectedIndex = -1
        installedweapon_number = 0
        researchedweapon_number = 0
        rw_listbox.ClearSelected()
        rw_numberselect_combobox.SelectedIndex = -1
        sw_listbox.ClearSelected()
        sw_numberselect_combobox.SelectedIndex = -1
        rw_attack = 0
        sw_attack = 0
        full_attack = 0
        InvasionBox.ClearSelected()
        five_percent_check.Checked = False
        ten_percent_check.Checked = False
        fifteen_percent_check.Checked = False
        crux_amp_check.Checked = False
        shockpulse_check.Checked = False
        mutagenic_check.Checked = False
        stryllpathogen_check.Checked = False
        kulgox_check.Checked = False
        SurgePlexus_ComboBox.SelectedIndex = -1
        tetra_combobox.SelectedIndex = -1
        atmos_combobox.SelectedIndex = -1

    End Sub

    Private Sub attack_calc_button_Click(sender As System.Object, e As System.EventArgs) Handles attack_calc_button.Click

        'Standard Selected:
        If StandardToolStripMenuItem.Checked = True Then

            Dim attack_multiplier As Decimal = 1
            If fifteen_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.15
            End If
            If crux_amp_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.1
            End If
            If ten_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.1
            End If
            If five_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.05
            End If
            If tac_officers_textbox.Text <> Nothing Then
                Try
                    tac_attack = Integer.Parse(tac_officers_textbox.Text)
                Catch ex As Exception
                    MessageBox.Show("Please enter only valid numeric data for tactical officers", "Tactical Officer Data")
                    tac_officers_textbox.Focus()
                    Return
                End Try
            Else
                tac_attack = 0
            End If

            If tac_attack < 0 Then
                MessageBox.Show("Please do not enter negative crew members. This is impossible.", "Tactical Officer Data")
                tac_officers_textbox.Focus()
                Return
            End If
            Dim bonus_attack As Integer = 0
            Dim bonus_pl_attack As Integer = 0
            mw_attack = mteir_combobox.SelectedItem
            Select Case mw_attack
                Case 3 To 6
                    bonus_attack += 0
                Case 9 To 12
                    bonus_attack = 5
                Case 15 To 22
                    bonus_attack = 5
                    bonus_pl_attack = 15
                Case 26
                    bonus_attack = 10 + 5
                    bonus_pl_attack = 15
                Case 30 To 54
                    bonus_attack = 15 + 10 + 5
                    bonus_pl_attack = 15
                Case 58 To 62
                    bonus_attack = 15 + 15 + 10 + 5
                    bonus_pl_attack = 15
                Case 66 To 82
                    bonus_attack = 20 + 15 + 15 + 10 + 5
                    bonus_pl_attack = 40 + 15
                Case 86 To 90
                    bonus_attack = 30 + 20 + 15 + 15 + 10 + 5
                    bonus_pl_attack = 40 + 15
            End Select

            'Bioship Ally...
            If bioship_dropdown.SelectedIndex > 0 Then
                Dim bioship_attack As Integer = 80
                Dim bioship_rank As Integer = bioship_dropdown.SelectedIndex
                If bioship_rank > 1 Then
                    'Add 2% bonus per rank past 1
                    Dim bioship_multiplier As Double = 0.02
                    bioship_attack = ((bioship_multiplier * (bioship_rank - 1)) + 1) * bioship_attack
                End If
                bonus_attack += bioship_attack
            End If

            'Apparitious Ally...
            If apparitious_dropdown.SelectedIndex > 0 Then
                Dim bane_attack As Integer = 60
                Dim bane_rank As Integer = apparitious_dropdown.SelectedIndex
                If bane_rank > 1 Then
                    'Add 2% bonus per rank past 1
                    Dim bane_multiplier As Double = 0.02
                    bane_attack = ((bane_multiplier * (bane_rank - 1)) + 1) * bane_attack
                End If
                bonus_attack += bane_attack
            End If

            'Anubix Ally...
            If anubix_dropdown.SelectedIndex = 100 Then
                attack_multiplier = attack_multiplier * 1.03

            End If
            If cerulean_checkbox.Checked = True Then
                bonus_attack += 100
            End If

            If nightclaw_checkbox.Checked = True Then
                bonus_attack += 250
            End If

            'Race Bonus...
            If race_dropdown.SelectedIndex = 5 Then
                attack_multiplier = attack_multiplier * 1.2
            End If


            attack_textbox.Text = (rw_attack + sw_attack + tac_attack + bonus_attack) * attack_multiplier
            Return
        End If

        'NPC Selected:
        If NPCToolStripMenuItem.Checked = True Then
            Dim attack_multiplier As Decimal = 1
            If shockpulse_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.2
            End If
            If fifteen_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.15
            End If
            If crux_amp_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.1
            End If
            If ten_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.1
            End If
            If five_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.05
            End If
            If SurgePlexus_ComboBox.SelectedIndex > 0 Then
                attack_multiplier = attack_multiplier * (1.05 ^ (SurgePlexus_ComboBox.SelectedItem))
            End If
            If tac_officers_textbox.Text <> Nothing Then
                Try
                    tac_attack = Integer.Parse(tac_officers_textbox.Text)
                Catch ex As System.FormatException
                    MessageBox.Show("Please enter only valid numeric data for tactical officers", "Tactical Officer Data")
                    tac_officers_textbox.Focus()
                    Return
                End Try
            Else
                tac_attack = 0
            End If

            If tac_attack < 0 Then
                MessageBox.Show("Please do not enter negative crew members. This is impossible.", "Tactical Officer Data")
                tac_officers_textbox.Focus()
                Return
            End If
            Dim bonus_attack As Integer = 0
            Dim bonus_pl_attack As Integer = 0
            If mteir_combobox.SelectedIndex > -1 Then
                mw_attack = mteir_combobox.SelectedItem
                Select Case mw_attack
                    Case 3 To 6
                        bonus_attack += 0
                    Case 9 To 12
                        bonus_attack = 5
                    Case 15 To 22
                        bonus_attack = 5
                        bonus_pl_attack = 15
                    Case 26
                        bonus_attack = 10 + 5
                        bonus_pl_attack = 15
                    Case 30 To 54
                        bonus_attack = 15 + 10 + 5
                        bonus_pl_attack = 15
                    Case 58 To 62
                        bonus_attack = 15 + 15 + 10 + 5
                        bonus_pl_attack = 15
                    Case 66 To 82
                        bonus_attack = 20 + 15 + 15 + 10 + 5
                        bonus_pl_attack = 40 + 15
                    Case 86 To 90
                        bonus_attack = 30 + 20 + 15 + 15 + 10 + 5
                        bonus_pl_attack = 40 + 15
                End Select
                If mutagenic_check.Checked = True Then
                    bonus_pl_attack += 1500
                End If
                If stryllpathogen_check.Checked = True Then
                    bonus_pl_attack += 800
                End If
            End If

            'Bioship Ally...
            If bioship_dropdown.SelectedIndex > 0 Then
                Dim bioship_attack As Integer = 80
                Dim bioship_rank As Integer = bioship_dropdown.SelectedIndex
                If bioship_rank > 1 Then
                    'Add 2% bonus per rank past 1
                    Dim bioship_multiplier As Double = 0.02
                    bioship_attack = ((bioship_multiplier * (bioship_rank - 1)) + 1) * bioship_attack
                End If
                bonus_attack += bioship_attack
            End If

            'Apparitious Ally...
            If apparitious_dropdown.SelectedIndex > 0 Then
                Dim bane_attack As Integer = 60
                Dim bane_rank As Integer = apparitious_dropdown.SelectedIndex
                If bane_rank > 1 Then
                    'Add 2% bonus per rank past 1
                    Dim bane_multiplier As Double = 0.02
                    bane_attack = ((bane_multiplier * (bane_rank - 1)) + 1) * bane_attack
                End If
                bonus_attack += bane_attack
            End If

            'Anubix Ally...
            If anubix_dropdown.SelectedIndex = 100 Then
                attack_multiplier = attack_multiplier * 1.03

            End If
            If cerulean_checkbox.Checked = True Then
                bonus_attack += 100
            End If

            If nightclaw_checkbox.Checked = True Then
                bonus_attack += 250
            End If

            'Race Bonus...
            If race_dropdown.SelectedIndex = 1 Then
                attack_multiplier = attack_multiplier * 1.4
            ElseIf race_dropdown.SelectedIndex = 5 Then
                attack_multiplier = attack_multiplier * 1.2
            End If

            'Final Calculation
            attack_textbox.Text = (rw_attack + sw_attack + tac_attack + bonus_attack) * attack_multiplier
            Return
        End If


        'Invasion Selected:
        If InvasionToolStripMenuItem.Checked = True Then
            Dim bonus_attack As Integer = 0
            Dim bonus_pl_attack As Integer = 0
            Dim attack_multiplier As Decimal = 1
            If kulgox_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.1
            End If
            If fifteen_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.15
            End If
            If crux_amp_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.1
            End If
            If ten_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.1
            End If
            If five_percent_check.Checked = True Then
                attack_multiplier = attack_multiplier * 1.05
            End If
            If atmos_combobox.SelectedIndex > 0 Then
                attack_multiplier = attack_multiplier * (1.07 ^ (atmos_combobox.SelectedItem))
                bonus_pl_attack += atmos_combobox.SelectedItem * 100
            End If
            If tac_officers_textbox.Text <> Nothing Then
                Try
                    tac_attack = Integer.Parse(tac_officers_textbox.Text)
                Catch ex As Exception
                    MessageBox.Show("Please enter only valid numeric data for tactical officers", "Tactical Officer Data")
                    tac_officers_textbox.Focus()
                    Return
                End Try
            Else
                tac_attack = 0
            End If

            If tac_attack < 0 Then
                MessageBox.Show("Please do not enter negative crew members. This is impossible.", "Tactical Officer Data")
                tac_officers_textbox.Focus()
                Return
            End If

            If mteir_combobox.SelectedIndex > -1 Then
                mw_attack = mteir_combobox.SelectedItem
                Select Case mw_attack
                    Case 3 To 6
                        bonus_attack += 0
                    Case 9 To 12
                        bonus_attack += 5
                    Case 15 To 22
                        bonus_attack += 5
                        bonus_pl_attack += 15
                    Case 26
                        bonus_attack += 10 + 5
                        bonus_pl_attack = 15
                    Case 30 To 54
                        bonus_attack += 15 + 10 + 5
                        bonus_pl_attack += 15
                    Case 58 To 62
                        bonus_attack += 15 + 15 + 10 + 5
                        bonus_pl_attack += 15
                    Case 66 To 82
                        bonus_attack += 20 + 15 + 15 + 10 + 5
                        bonus_pl_attack += 40 + 15
                    Case 86 To 90
                        bonus_attack += 30 + 20 + 15 + 15 + 10 + 5
                        bonus_pl_attack += 40 + 15
                End Select
            End If

            'Bioship Ally...
            If bioship_dropdown.SelectedIndex > 0 Then
                Dim bioship_attack As Integer = 80
                Dim bioship_rank As Integer = bioship_dropdown.SelectedIndex
                If bioship_rank > 1 Then
                    'Add 2% bonus per rank past 1
                    Dim bioship_multiplier As Double = 0.02
                    bioship_attack = ((bioship_multiplier * (bioship_rank - 1)) + 1) * bioship_attack
                End If
                bonus_attack += bioship_attack
            End If

            'Apparitious Ally...
            If apparitious_dropdown.SelectedIndex > 0 Then
                Dim bane_attack As Integer = 60
                Dim bane_rank As Integer = apparitious_dropdown.SelectedIndex
                If bane_rank > 1 Then
                    'Add 2% bonus per rank past 1
                    Dim bane_multiplier As Double = 0.02
                    bane_attack = ((bane_multiplier * (bane_rank - 1)) + 1) * bane_attack
                    If apparitious_dropdown.SelectedIndex = 100 Then
                        attack_multiplier = attack_multiplier * 1.1
                    End If
                End If
                bonus_attack += bane_attack
            End If

            'Anubix Ally...
            If anubix_dropdown.SelectedIndex > 0 Then
                Dim anubix_attack As Integer = 160
                Dim anubix_rank As Integer = anubix_dropdown.SelectedIndex
                If anubix_rank > 1 Then
                    'Add 2% bonus per rank past 1
                    Dim anubix_multiplier As Double = 0.02
                    anubix_attack = ((anubix_multiplier * (anubix_rank - 1)) + 1) * anubix_attack
                End If
                If anubix_dropdown.SelectedIndex = 100 Then
                    attack_multiplier = attack_multiplier * 1.03
                End If
                bonus_pl_attack += anubix_attack
            End If
            If cerulean_checkbox.Checked = True Then
                bonus_attack += 100
            End If

            If nightclaw_checkbox.Checked = True Then
                bonus_attack += 250
            End If
            If dark_chassis_checkbox.Checked = True Then
                bonus_pl_attack += 600
            End If

            'Race Bonus...
            If race_dropdown.SelectedIndex = 5 Then
                attack_multiplier = attack_multiplier * 1.2
            End If

            'Final Calculation
            full_attack = (rw_attack + sw_attack + tac_attack + bonus_attack + bonus_pl_attack) * attack_multiplier
            attack_textbox.Text = full_attack
            Return
        End If
    End Sub

    Private Sub sw_add_button_Click(sender As System.Object, e As System.EventArgs) Handles sw_add_button.Click
        If sw_listbox.SelectedIndex = 14 And sw_numberselect_combobox.SelectedItem = 4 Then
            MessageBox.Show("Only 3 Lazuli Mind Controllers can be installed at once")
            Return
        End If
        If sw_listbox.SelectedIndex = 10 And sw_numberselect_combobox.SelectedItem = 4 Then
            MessageBox.Show("Only 3 Exotic Pulsers can be installed at once")
            Return
        End If
        If sw_listbox.SelectedIndex = 23 And sw_numberselect_combobox.SelectedItem > 1 Then
            MessageBox.Show("Only 1 Psionic Amplifier can be installed at once")
            Return
        End If
        If (sw_listbox.SelectedIndex > 23 And sw_listbox.SelectedIndex < 33) And sw_numberselect_combobox.SelectedItem > 2 Then
            MessageBox.Show("Only 2 Radiant Surge weapons can be installed at once")
            Return
        End If
        If sw_listbox.SelectedIndex > -1 Then
            If sw_numberselect_combobox.SelectedIndex > -1 Then

                specialweapon_number = sw_numberselect_combobox.SelectedItem
                installedweapons_string += "Special Weapons:" & Environment.NewLine

                installedweapons_string += sw_listbox.SelectedItem & " x" & specialweapon_number
                installedweapons_string += Environment.NewLine
                installedweapons_textbox.Text = installedweapons_string
                sw_attack += sw_numberselect_combobox.SelectedItem * SWAttackStrength(IDcode:=sw_listbox.SelectedIndex)
            Else
                MessageBox.Show("Please select a number of weapons to install.")
            End If

        Else
            MessageBox.Show("Please select a weapon type.")
        End If


    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StandardToolStripMenuItem.Click
        NPCToolStripMenuItem.Checked = False
        InvasionToolStripMenuItem.Checked = False
        InvasionBox.Visible = False
        mutagenic_check.Visible = False
        stryllpathogen_check.Visible = False
        kulgox_check.Visible = False
        shockpulse_check.Visible = False
        surge_plexus_label.Visible = False
        SurgePlexus_ComboBox.Visible = False
        InvasionBox.Enabled = False
        SurgePlexus_ComboBox.Enabled = False
        tetra_label.Visible = False
        tetra_combobox.Visible = False
        atmos_label.Visible = False
        atmos_combobox.Visible = False
        tetra_combobox.Enabled = False
        atmos_combobox.Enabled = False
        inv_add_button.Visible = False
        inv_add_button.Enabled = False
        sw_listbox.Enabled = True
        sw_listbox.Visible = True
        sw_add_button.Visible = True
        sw_add_button.Enabled = True
        dark_chassis_checkbox.Visible = False
        dark_chassis_checkbox.Enabled = False

    End Sub

    Private Sub NPCToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NPCToolStripMenuItem.Click
        StandardToolStripMenuItem.Checked = False
        InvasionToolStripMenuItem.Checked = False
        mutagenic_check.Visible = False
        stryllpathogen_check.Visible = False
        kulgox_check.Visible = False
        shockpulse_check.Visible = True
        surge_plexus_label.Visible = True
        SurgePlexus_ComboBox.Visible = True
        InvasionBox.Enabled = False
        InvasionBox.Visible = False
        SurgePlexus_ComboBox.Enabled = True
        tetra_label.Visible = False
        tetra_combobox.Visible = False
        atmos_label.Visible = False
        atmos_combobox.Visible = False
        tetra_combobox.Enabled = False
        atmos_combobox.Enabled = False
        inv_add_button.Visible = False
        inv_add_button.Enabled = False
        sw_listbox.Enabled = True
        sw_listbox.Visible = True
        sw_add_button.Visible = True
        sw_add_button.Enabled = True
        dark_chassis_checkbox.Visible = False
        dark_chassis_checkbox.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim MessageString As MsgBoxResult
        MessageString = MessageBox.Show("Click OK to close or Cancel to return to the form", "Confirm Exit", MessageBoxButtons.OKCancel)
        If MessageString = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub InvasionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InvasionToolStripMenuItem.Click
        StandardToolStripMenuItem.Checked = False
        NPCToolStripMenuItem.Checked = False
        mutagenic_check.Visible = True
        stryllpathogen_check.Visible = True
        kulgox_check.Visible = True
        shockpulse_check.Visible = False
        surge_plexus_label.Visible = False
        SurgePlexus_ComboBox.Visible = False
        InvasionBox.Enabled = True
        InvasionBox.Visible = True
        SurgePlexus_ComboBox.Enabled = False
        tetra_label.Visible = False
        tetra_combobox.Visible = False
        atmos_label.Visible = True
        atmos_combobox.Visible = True
        tetra_combobox.Enabled = False
        atmos_combobox.Enabled = True
        inv_add_button.Visible = True
        inv_add_button.Enabled = True
        sw_listbox.Enabled = False
        sw_listbox.Visible = False
        sw_add_button.Visible = False
        sw_add_button.Enabled = False
        dark_chassis_checkbox.Visible = True
        dark_chassis_checkbox.Enabled = True
    End Sub

    Private Sub inv_add_button_Click(sender As System.Object, e As System.EventArgs) Handles inv_add_button.Click
        installedweapons_string = Nothing
        If InvasionBox.SelectedIndex = 15 And sw_numberselect_combobox.SelectedItem = 4 Then
            MessageBox.Show("Only 3 Lazuli Mind Controllers can be installed at once")
            Return
        End If
        If InvasionBox.SelectedIndex = 11 And sw_numberselect_combobox.SelectedItem = 4 Then
            MessageBox.Show("Only 3 Exotic Pulsers can be installed at once")
            Return
        End If
        If InvasionBox.SelectedIndex = 24 And sw_numberselect_combobox.SelectedItem > 1 Then
            MessageBox.Show("Only 1 Psionic Amplifier can be installed at once")
            Return
        End If
        If (InvasionBox.SelectedIndex > 24 And InvasionBox.SelectedIndex < 34) And sw_numberselect_combobox.SelectedItem > 2 Then
            MessageBox.Show("Only 2 Radiant Surge weapons can be installed at once")
            Return
        End If
        If InvasionBox.SelectedIndex > -1 Then
            If sw_numberselect_combobox.SelectedIndex > -1 Then

                specialweapon_number = sw_numberselect_combobox.SelectedItem
                Dim textbox_check As String
                Dim index As Integer
                textbox_check = installedweapons_textbox.Text
                If (index = textbox_check.IndexOf("Special")) <> -1 Then
                    installedweapons_string += "Special Weapons:" & Environment.NewLine
                Else

                    installedweapons_string += Environment.NewLine
                End If

                installedweapons_string += InvasionBox.SelectedItem & " x" & specialweapon_number
                installedweapons_textbox.Text += installedweapons_string
                sw_attack += sw_numberselect_combobox.SelectedItem * PLAttackStrength(IDcode:=InvasionBox.SelectedIndex)
                installedweapons_textbox.Text += Environment.NewLine
            Else
                MessageBox.Show("Please select a number of weapons to install.")
            End If

        Else
            MessageBox.Show("Please select a weapon type.")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class