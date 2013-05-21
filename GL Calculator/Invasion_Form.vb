Public Class Invasion_Form

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles receive_button.Click
        If Attack_Form.InvasionToolStripMenuItem.Checked = False Or Attack_Form.full_attack = 0 Then
            MessageBox.Show("The Attack Calculator is not in Invasion Mode. Please prepare that form before attempting to access it")
            Return
        End If
        invasion_strength.Text = Convert.ToString(Attack_Form.full_attack)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles calculate_button.Click
        Dim attack_strength, planet_defense, planet_attack, planet_special, invasion_chance As Decimal
        Try
            If invasion_strength.Text <> Nothing Then
                attack_strength = invasion_strength.Text
            Else
                MessageBox.Show("Attack cannot be equal to zero")
                invasion_strength.Focus()
                Return
            End If
            If planetary_defense.Text <> Nothing Then
                planet_defense = planetary_defense.Text
            Else
                planet_defense = 0
            End If
            If planetary_attack.Text <> Nothing Then
                planet_attack = planetary_attack.Text
            Else
                planet_attack = 0
            End If
            If planetary_special.Text <> Nothing Then
                planet_special = planetary_special.Text
            Else
                planet_special = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Enter only numbers for the above textboxes and try again.")
            Return
        End Try

        attack_strength = attack_strength / 3
        planet_defense += planet_attack + planet_special
        If planet_defense <> 0 Then
            invasion_chance = (attack_strength / planet_defense) * 100
            If invasion_chance > 90.0 Then
                invasion_chance = 90.0
            End If
        Else
            invasion_chance = 90.0
        End If

        invade_chance.Text = Convert.ToString(Decimal.Round(invasion_chance, 4)) + "%"
    End Sub
End Class