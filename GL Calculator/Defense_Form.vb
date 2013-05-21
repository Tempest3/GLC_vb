Public Class Defense_Form
    Dim specialdefense_number, researcheddefense_number, installeddefense_number As Integer
    Dim installeddefenses_string As String
    Dim sd_defense, rd_defense, helms_defense, md_defense As Integer
    Private Function RDDefenseStrength(ByVal IDCode As Integer) As Integer
        RDDefenseStrength = 0
        If IDCode = 0 Then
            RDDefenseStrength = 1
        ElseIf IDCode = 1 Then
            RDDefenseStrength = 2
        ElseIf IDCode = 2 Then
            RDDefenseStrength = 6
        ElseIf IDCode = 3 Then
            RDDefenseStrength = 10
        ElseIf IDCode = 4 Then
            RDDefenseStrength = 14
        ElseIf IDCode = 5 Then
            RDDefenseStrength = 24
        ElseIf IDCode = 6 Then
            RDDefenseStrength = 30
        ElseIf IDCode = 7 Then
            RDDefenseStrength = 36
        ElseIf IDCode = 8 Then
            RDDefenseStrength = 50
        ElseIf IDCode = 9 Then
            RDDefenseStrength = 58
        ElseIf IDCode = 10 Then
            RDDefenseStrength = 66
        ElseIf IDCode = 11 Then
            RDDefenseStrength = 84
        ElseIf IDCode = 12 Then
            RDDefenseStrength = 94
        ElseIf IDCode = 13 Then
            RDDefenseStrength = 104
        ElseIf IDCode = 14 Then
            RDDefenseStrength = 126
        ElseIf IDCode = 15 Then
            RDDefenseStrength = 138
        ElseIf IDCode = 16 Then
            RDDefenseStrength = 150
        ElseIf IDCode = 17 Then
            RDDefenseStrength = 176
        ElseIf IDCode = 18 Then
            RDDefenseStrength = 190
        ElseIf IDCode = 19 Then
            RDDefenseStrength = 204
        ElseIf IDCode = 20 Then
            RDDefenseStrength = 234
        ElseIf IDCode = 21 Then
            RDDefenseStrength = 250
            '266
        ElseIf IDCode = 22 Then
            RDDefenseStrength = 266
        ElseIf IDCode = 23 Then
            RDDefenseStrength = 300
        ElseIf IDCode = 24 Then
            RDDefenseStrength = 318
        ElseIf IDCode = 25 Then
            RDDefenseStrength = 336
        ElseIf IDCode = 26 Then
            RDDefenseStrength = 374
        ElseIf IDCode = 27 Then
            RDDefenseStrength = 394
        ElseIf IDCode = 28 Then
            RDDefenseStrength = 414
        ElseIf IDCode = 29 Then
            RDDefenseStrength = 456
        ElseIf IDCode = 30 Then
            RDDefenseStrength = 478
        ElseIf IDCode = 31 Then
            RDDefenseStrength = 500
        ElseIf IDCode = 32 Then
            RDDefenseStrength = 552
        ElseIf IDCode = 33 Then
            RDDefenseStrength = 590
        ElseIf IDCode = 34 Then
            RDDefenseStrength = 626
        ElseIf IDCode = 35 Then
            RDDefenseStrength = 720
        ElseIf IDCode = 36 Then
            RDDefenseStrength = 770
        ElseIf IDCode = 37 Then
            RDDefenseStrength = 820
        End If
        Return RDDefenseStrength
    End Function
    Private Function SDDefenseStrength(ByVal IDcode As Integer) As Integer
        SDDefenseStrength = 0
        If IDcode = 0 Then
            SDDefenseStrength = 15
        ElseIf IDcode = 1 Then
            SDDefenseStrength = 30
        ElseIf IDcode = 2 Then
            SDDefenseStrength = 20
        ElseIf IDcode = 3 Then
            SDDefenseStrength = 100
        ElseIf IDcode = 4 Then
            SDDefenseStrength = 150
        ElseIf IDcode = 5 Then
            SDDefenseStrength = 70
        ElseIf IDcode = 6 Then
            SDDefenseStrength = 25
        ElseIf IDcode = 7 Then
            SDDefenseStrength = 40
        ElseIf IDcode = 8 Then
            SDDefenseStrength = 25
        ElseIf IDcode = 9 Then
            SDDefenseStrength = 30
        ElseIf IDcode = 10 Then
            SDDefenseStrength = 50
        ElseIf IDcode = 11 Then
            SDDefenseStrength = 30
        ElseIf IDcode = 12 Then
            SDDefenseStrength = 140
        ElseIf IDcode = 13 Then
            SDDefenseStrength = 225
        ElseIf IDcode = 14 Then
            SDDefenseStrength = 125
        ElseIf IDcode = 15 Then
            SDDefenseStrength = 20
        ElseIf IDcode = 16 Then
            SDDefenseStrength = 25
        ElseIf IDcode = 17 Then
            SDDefenseStrength = 50
        End If
        Return SDDefenseStrength
    End Function
    Private Sub rd_add_button_Click(sender As System.Object, e As System.EventArgs) Handles rd_add_button.Click
        If rd_listbox.SelectedIndex > -1 Then
            If rd_numberselect_combobox.SelectedIndex > -1 Then
                researcheddefense_number = rd_numberselect_combobox.SelectedItem
                If researcheddefense_number + installeddefense_number < 9 Then
                    installeddefense_number += researcheddefense_number
                    installeddefenses_string += "Researched Defenses:"
                    
                    installeddefenses_string += rd_listbox.SelectedItem & "  x" & researcheddefense_number
                    installeddefenses_textbox.Text = installeddefenses_string
                    installeddefenses_string += Environment.NewLine
                    rd_defense += rd_numberselect_combobox.SelectedItem * RDDefenseStrength(IDCode:=rd_listbox.SelectedIndex)
                Else
                    MessageBox.Show("Your ship can only carry up to eight researched weapon modules." & Environment.NewLine & "Please adjust your selection accordingly.", "More than 8 weapons!")
                    rd_numberselect_combobox.Focus()
                    Return
                End If
            Else
                MessageBox.Show("Please select a number of installed modules" & Environment.NewLine & "before attempting calculations.", "No number of weapons selected")
                rd_numberselect_combobox.Focus()
                Return
            End If


        Else

            MessageBox.Show("Please select a weapon type" & Environment.NewLine & "attempting calculations.", "No selected weapon type")
            rd_listbox.Focus()
            Return
        End If
        rd_listbox.ClearSelected()
        rd_numberselect_combobox.SelectedIndex = -1
    End Sub

    Private Sub rw_reset_button_Click(sender As System.Object, e As System.EventArgs) Handles rw_reset_button.Click
        installeddefenses_textbox.Clear()
        installeddefenses_string = ""
        defense_textbox.Clear()
        helmsmen_textbox.Clear()
        mteir_combobox.SelectedIndex = -1
        installeddefense_number = 0
        researcheddefense_number = 0
        rd_listbox.ClearSelected()
        rd_numberselect_combobox.SelectedIndex = -1
        sd_listbox.ClearSelected()
        sd_numberselect_combobox.SelectedIndex = -1
        rd_defense = 0
        sd_defense = 0
        grid_console_check.Checked = False
        xrp_fuel_check.Checked = False
        tevrazon_check.Checked = False
        decoy_check.Checked = False
        eluder_matrix_check.Checked = False
        MegaCoil_ComboBox.SelectedIndex = -1
        bm50_combobox.SelectedIndex = -1
        velox_combobox.SelectedIndex = -1

    End Sub

    Private Sub attack_calc_button_Click(sender As System.Object, e As System.EventArgs) Handles defense_calc_button.Click

        'Standard Selected:
        If StandardToolStripMenuItem.Checked = True Then

            Dim defense_multiplier As Decimal = 1
            If tevrazon_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.25
            End If
            If xrp_fuel_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.2
            End If
            If grid_console_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.2
            End If
            If helmsmen_textbox.Text <> Nothing Then
                Try
                    helms_defense = Integer.Parse(helmsmen_textbox.Text)
                Catch ex As Exception
                    MessageBox.Show("Please enter only valid numeric data for helmsmen", "Helmsmen Data")
                    helmsmen_textbox.Focus()
                    Return
                End Try
            Else
                helms_defense = 0
            End If

            If helms_defense < 0 Then
                MessageBox.Show("Please do not enter negative crew members. This is impossible.", "Helmsmen Data")
                helmsmen_textbox.Focus()
                Return
            End If
            Dim bonus_defense As Integer = 0
            md_defense = mteir_combobox.SelectedItem
            Select Case md_defense
                Case 3 To 6
                    bonus_defense += 0
                Case 9 To 12
                    bonus_defense += 5
                Case 15
                    bonus_defense += 5
                Case 18 To 26
                    bonus_defense += 10 + 5
                Case 30 To 38
                    bonus_defense += 5 + 10 + 5
                Case 42 To 74
                    bonus_defense += 15 + 5 + 10 + 5
                Case 78 To 86
                    bonus_defense += 25 + 15 + 5 + 10 + 5
                Case 90
                    bonus_defense += 30 + 25 + 15 + 5 + 10 + 5
            End Select
            If bm50_combobox.SelectedIndex > -1 Then
                bonus_defense += bm50_combobox.SelectedItem * 100
            End If
            If velox_combobox.SelectedIndex > -1 Then
                defense_multiplier = defense_multiplier * (1.05 ^ (velox_combobox.SelectedItem))
                bonus_defense += velox_combobox.SelectedItem * 300
            End If
            defense_textbox.Text = (rd_defense + sd_defense + helms_defense + bonus_defense) * defense_multiplier
            Return
        End If

        'NPC Selected:
        If NPCToolStripMenuItem.Checked = True Then
            Dim defense_multiplier As Decimal = 1
            If decoy_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.1
            End If
            If tevrazon_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.25
            End If
            If xrp_fuel_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.2
            End If
            If grid_console_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.2
            End If
            If MegaCoil_ComboBox.SelectedIndex > 0 Then
                defense_multiplier = defense_multiplier * (1.05 ^ (MegaCoil_ComboBox.SelectedItem))
            End If
            If helmsmen_textbox.Text <> Nothing Then
                Try
                    helms_defense = Integer.Parse(helmsmen_textbox.Text)
                Catch ex As System.FormatException
                    MessageBox.Show("Please enter only valid numeric data for tactical officers", "Tactical Officer Data")
                    helmsmen_textbox.Focus()
                    Return
                End Try
            Else
                helms_defense = 0
            End If

            If helms_defense < 0 Then
                MessageBox.Show("Please do not enter negative crew members. This is impossible.", "Tactical Officer Data")
                helmsmen_textbox.Focus()
                Return
            End If
            Dim bonus_defense As Integer = 0
            Dim bonus_base_defense As Integer = 0
            If mteir_combobox.SelectedIndex > -1 Then
                md_defense = mteir_combobox.SelectedItem
                Select Case md_defense
                    Case 3 To 6
                        bonus_defense += 0
                    Case 9 To 12
                        bonus_defense += 5
                    Case 15
                        bonus_defense += 5
                    Case 18 To 26
                        bonus_defense += 10 + 5
                    Case 30 To 38
                        bonus_defense += 5 + 10 + 5
                    Case 42 To 74
                        bonus_defense += 15 + 5 + 10 + 5
                    Case 78 To 86
                        bonus_defense += 25 + 15 + 5 + 10 + 5
                    Case 90
                        bonus_defense += 30 + 25 + 15 + 5 + 10 + 5
                End Select
                If bm50_combobox.SelectedIndex > -1 Then
                    bonus_defense += bm50_combobox.SelectedItem * 100
                End If
                If velox_combobox.SelectedIndex > -1 Then
                    defense_multiplier = defense_multiplier * (1.05 ^ (velox_combobox.SelectedItem))
                    bonus_defense += velox_combobox.SelectedItem * 300
                End If
                If MegaCoil_ComboBox.SelectedIndex > -1 Then
                    defense_multiplier = defense_multiplier * (1.05 ^ (MegaCoil_ComboBox.SelectedItem))
                End If


            End If
            defense_textbox.Text = (rd_defense + sd_defense + helms_defense + bonus_defense) * defense_multiplier
            Return
        End If

        'Base Combat Selected:
        If BaseCombatToolStripMenuItem.Checked = True Then
            Dim bonus_defense As Integer = 0
            Dim bonus_base_defense As Integer = 0
            Dim defense_multiplier As Decimal = 1
            If eluder_matrix_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.1
            End If
            If decoy_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.1
            End If
            If tevrazon_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.25
            End If
            If xrp_fuel_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.2
            End If
            If grid_console_check.Checked = True Then
                defense_multiplier = defense_multiplier * 1.2
            End If
            If bm50_combobox.SelectedIndex > 0 Then
                defense_multiplier = defense_multiplier * (1.05 ^ (bm50_combobox.SelectedItem))
                bonus_base_defense += bm50_combobox.SelectedItem * 100
            End If
            If helmsmen_textbox.Text <> Nothing Then
                Try
                    helms_defense = Integer.Parse(helmsmen_textbox.Text)
                Catch ex As Exception
                    MessageBox.Show("Please enter only valid numeric data for tactical officers", "Tactical Officer Data")
                    helmsmen_textbox.Focus()
                    Return
                End Try
            Else
                helms_defense = 0
            End If

            If helms_defense < 0 Then
                MessageBox.Show("Please do not enter negative crew members. This is impossible.", "Helmsmen Data")
                helmsmen_textbox.Focus()
                Return
            End If

            If mteir_combobox.SelectedIndex > 0 Then
                md_defense = mteir_combobox.SelectedItem
                Select Case md_defense
                    Case 3 To 6
                        bonus_defense += 0
                    Case 9 To 12
                        bonus_defense += 5
                    Case 15
                        bonus_defense += 5
                    Case 18 To 26
                        bonus_defense += 10 + 5
                    Case 30 To 38
                        bonus_defense += 5 + 10 + 5
                    Case 42 To 74
                        bonus_defense += 15 + 5 + 10 + 5
                    Case 78 To 86
                        bonus_defense += 25 + 15 + 5 + 10 + 5
                    Case 90
                        bonus_defense += 30 + 25 + 15 + 5 + 10 + 5
                End Select
                If velox_combobox.SelectedIndex > -1 Then
                    defense_multiplier = defense_multiplier * (1.05 ^ (velox_combobox.SelectedItem))
                    bonus_defense += velox_combobox.SelectedItem * 300
                End If
            End If
            defense_textbox.Text = (rd_defense + sd_defense + helms_defense + bonus_defense + bonus_base_defense) * defense_multiplier
            Return
        End If
    End Sub

    Private Sub sw_add_button_Click(sender As System.Object, e As System.EventArgs) Handles sd_add_button.Click
        If sd_listbox.SelectedIndex > -1 Then
            If sd_numberselect_combobox.SelectedIndex > -1 Then
                If sd_listbox.SelectedIndex = 15 And sd_numberselect_combobox.SelectedItem > 2 Then
                    MessageBox.Show("Only 2 Stryll Transponders can be installed at one time.")
                    Return
                End If
                If sd_listbox.SelectedIndex > 14 And sd_numberselect_combobox.SelectedItem > 3 Then
                    MessageBox.Show("Only 3 Triaxial Arrays can be installed at one time.")
                    Return
                End If
                specialdefense_number = sd_numberselect_combobox.SelectedItem
                installeddefenses_string += "Special Weapons:"
                installeddefenses_string += sd_listbox.SelectedItem & " x" & specialdefense_number
                installeddefenses_string += Environment.NewLine
                installeddefenses_textbox.Text = installeddefenses_string
                sd_defense += sd_numberselect_combobox.SelectedItem * SDDefenseStrength(IDcode:=sd_listbox.SelectedIndex)
            Else
                MessageBox.Show("Please select a number of weapons to install.")
            End If

        Else
            MessageBox.Show("Please select a weapon type.")
        End If


    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StandardToolStripMenuItem.Click
        NPCToolStripMenuItem.Checked = False
        BaseCombatToolStripMenuItem.Checked = False
        mega_coil_label.Visible = False
        MegaCoil_ComboBox.Visible = False
        MegaCoil_ComboBox.Enabled = False
        bm50_label.Visible = True
        bm50_combobox.Visible = True
        velox_label.Visible = True
        velox_combobox.Visible = True
        bm50_combobox.Enabled = True
        velox_combobox.Enabled = True
        sd_listbox.Enabled = True
        sd_listbox.Visible = True
        sd_add_button.Visible = True
        sd_add_button.Enabled = True
        eluder_matrix_check.Visible = False
        eluder_matrix_check.Enabled = False
        decoy_check.Visible = False
        decoy_check.Enabled = False

    End Sub

    Private Sub NPCToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NPCToolStripMenuItem.Click
        StandardToolStripMenuItem.Checked = False
        BaseCombatToolStripMenuItem.Checked = False
        mega_coil_label.Visible = True
        MegaCoil_ComboBox.Visible = True
        MegaCoil_ComboBox.Enabled = True
        bm50_label.Visible = True
        bm50_combobox.Visible = True
        velox_label.Visible = True
        velox_combobox.Visible = True
        bm50_combobox.Enabled = True
        velox_combobox.Enabled = True
        sd_listbox.Enabled = True
        sd_listbox.Visible = True
        sd_add_button.Visible = True
        sd_add_button.Enabled = True
        eluder_matrix_check.Visible = False
        eluder_matrix_check.Enabled = False
        decoy_check.Visible = True
        decoy_check.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim MessageString As MsgBoxResult
        MessageString = MessageBox.Show("Click OK to close or Cancel to return to the form", "Confirm Exit", MessageBoxButtons.OKCancel)
        If MessageString = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub BaseCombatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BaseCombatToolStripMenuItem.Click
        StandardToolStripMenuItem.Checked = False
        NPCToolStripMenuItem.Checked = False
        mega_coil_label.Visible = False
        MegaCoil_ComboBox.Visible = False
        MegaCoil_ComboBox.Enabled = False
        bm50_label.Visible = True
        bm50_combobox.Visible = True
        velox_label.Visible = True
        velox_combobox.Visible = True
        bm50_combobox.Enabled = True
        velox_combobox.Enabled = True
        sd_listbox.Enabled = True
        sd_listbox.Visible = True
        sd_add_button.Visible = True
        sd_add_button.Enabled = True
        eluder_matrix_check.Visible = True
        eluder_matrix_check.Enabled = True
        decoy_check.Visible = True
        decoy_check.Enabled = True
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class