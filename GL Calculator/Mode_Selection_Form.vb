Public Class Mode_Selection_Form
    Private Sub attack_launch_Click(sender As System.Object, e As System.EventArgs) Handles attack_launch.Click
        Attack_Form.Show()
    End Sub

    Private Sub defense_launch_Click(sender As System.Object, e As System.EventArgs) Handles defense_launch.Click
        Defense_Form.Show()
    End Sub

    Private Sub invade_launch_Click(sender As System.Object, e As System.EventArgs) Handles invade_launch.Click
        Invasion_Form.Show()
    End Sub
End Class