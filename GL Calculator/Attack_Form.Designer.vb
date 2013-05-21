<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attack_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attack_Form))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.installed_label = New System.Windows.Forms.Label()
        Me.atmos_label = New System.Windows.Forms.Label()
        Me.tetra_label = New System.Windows.Forms.Label()
        Me.sw_add_button = New System.Windows.Forms.Button()
        Me.atmos_combobox = New System.Windows.Forms.ComboBox()
        Me.tetra_combobox = New System.Windows.Forms.ComboBox()
        Me.inv_add_button = New System.Windows.Forms.Button()
        Me.kulgox_check = New System.Windows.Forms.CheckBox()
        Me.stryllpathogen_check = New System.Windows.Forms.CheckBox()
        Me.mutagenic_check = New System.Windows.Forms.CheckBox()
        Me.crux_amp_check = New System.Windows.Forms.CheckBox()
        Me.sw_listbox = New System.Windows.Forms.ListBox()
        Me.surge_plexus_label = New System.Windows.Forms.Label()
        Me.SurgePlexus_ComboBox = New System.Windows.Forms.ComboBox()
        Me.shockpulse_check = New System.Windows.Forms.CheckBox()
        Me.InvasionBox = New System.Windows.Forms.ListBox()
        Me.special_label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mteir_combobox = New System.Windows.Forms.ComboBox()
        Me.sw_numberselect_combobox = New System.Windows.Forms.ComboBox()
        Me.Officers_Label = New System.Windows.Forms.Label()
        Me.tac_officers_textbox = New System.Windows.Forms.TextBox()
        Me.fifteen_percent_check = New System.Windows.Forms.CheckBox()
        Me.ten_percent_check = New System.Windows.Forms.CheckBox()
        Me.five_percent_check = New System.Windows.Forms.CheckBox()
        Me.attack_calc_button = New System.Windows.Forms.Button()
        Me.attack_textbox = New System.Windows.Forms.TextBox()
        Me.rw_reset_button = New System.Windows.Forms.Button()
        Me.rw_numberselect_combobox = New System.Windows.Forms.ComboBox()
        Me.rw_add_button = New System.Windows.Forms.Button()
        Me.installedweapons_textbox = New System.Windows.Forms.TextBox()
        Me.researched_label = New System.Windows.Forms.Label()
        Me.rw_listbox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvasionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bioship_dropdown = New System.Windows.Forms.ComboBox()
        Me.apparitious_dropdown = New System.Windows.Forms.ComboBox()
        Me.anubix_dropdown = New System.Windows.Forms.ComboBox()
        Me.bioship_label = New System.Windows.Forms.Label()
        Me.apparitious_label = New System.Windows.Forms.Label()
        Me.anubix_label = New System.Windows.Forms.Label()
        Me.cerulean_checkbox = New System.Windows.Forms.CheckBox()
        Me.nightclaw_checkbox = New System.Windows.Forms.CheckBox()
        Me.dark_chassis_checkbox = New System.Windows.Forms.CheckBox()
        Me.race_label = New System.Windows.Forms.Label()
        Me.race_dropdown = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(653, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Calculated Attack:"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'installed_label
        '
        Me.installed_label.AutoSize = True
        Me.installed_label.BackColor = System.Drawing.Color.Transparent
        Me.installed_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installed_label.ForeColor = System.Drawing.Color.White
        Me.installed_label.Location = New System.Drawing.Point(54, 200)
        Me.installed_label.Name = "installed_label"
        Me.installed_label.Size = New System.Drawing.Size(100, 17)
        Me.installed_label.TabIndex = 67
        Me.installed_label.Text = "Installed Modules:"
        Me.installed_label.UseCompatibleTextRendering = True
        '
        'atmos_label
        '
        Me.atmos_label.AutoSize = True
        Me.atmos_label.BackColor = System.Drawing.Color.Transparent
        Me.atmos_label.ForeColor = System.Drawing.Color.White
        Me.atmos_label.Location = New System.Drawing.Point(310, 434)
        Me.atmos_label.Name = "atmos_label"
        Me.atmos_label.Size = New System.Drawing.Size(131, 17)
        Me.atmos_label.TabIndex = 66
        Me.atmos_label.Text = "Atmospheric Decimators:"
        Me.atmos_label.UseCompatibleTextRendering = True
        Me.atmos_label.Visible = False
        '
        'tetra_label
        '
        Me.tetra_label.AutoSize = True
        Me.tetra_label.BackColor = System.Drawing.Color.Transparent
        Me.tetra_label.ForeColor = System.Drawing.Color.White
        Me.tetra_label.Location = New System.Drawing.Point(326, 407)
        Me.tetra_label.Name = "tetra_label"
        Me.tetra_label.Size = New System.Drawing.Size(115, 17)
        Me.tetra_label.TabIndex = 65
        Me.tetra_label.Text = "Tetra-Seek Targeters:"
        Me.tetra_label.UseCompatibleTextRendering = True
        Me.tetra_label.Visible = False
        '
        'sw_add_button
        '
        Me.sw_add_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sw_add_button.Location = New System.Drawing.Point(388, 166)
        Me.sw_add_button.Name = "sw_add_button"
        Me.sw_add_button.Size = New System.Drawing.Size(75, 23)
        Me.sw_add_button.TabIndex = 53
        Me.sw_add_button.Text = "Add SW"
        Me.sw_add_button.UseCompatibleTextRendering = True
        Me.sw_add_button.UseVisualStyleBackColor = True
        '
        'atmos_combobox
        '
        Me.atmos_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.atmos_combobox.FormattingEnabled = True
        Me.atmos_combobox.Items.AddRange(New Object() {"0", "1", "2"})
        Me.atmos_combobox.Location = New System.Drawing.Point(443, 431)
        Me.atmos_combobox.Name = "atmos_combobox"
        Me.atmos_combobox.Size = New System.Drawing.Size(61, 21)
        Me.atmos_combobox.TabIndex = 64
        Me.atmos_combobox.Visible = False
        '
        'tetra_combobox
        '
        Me.tetra_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tetra_combobox.FormattingEnabled = True
        Me.tetra_combobox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.tetra_combobox.Location = New System.Drawing.Point(443, 404)
        Me.tetra_combobox.Name = "tetra_combobox"
        Me.tetra_combobox.Size = New System.Drawing.Size(61, 21)
        Me.tetra_combobox.TabIndex = 63
        Me.tetra_combobox.Visible = False
        '
        'inv_add_button
        '
        Me.inv_add_button.BackColor = System.Drawing.Color.Transparent
        Me.inv_add_button.ForeColor = System.Drawing.SystemColors.Desktop
        Me.inv_add_button.Location = New System.Drawing.Point(388, 166)
        Me.inv_add_button.Name = "inv_add_button"
        Me.inv_add_button.Size = New System.Drawing.Size(75, 23)
        Me.inv_add_button.TabIndex = 62
        Me.inv_add_button.Text = "Add SW"
        Me.inv_add_button.UseCompatibleTextRendering = True
        Me.inv_add_button.UseVisualStyleBackColor = False
        Me.inv_add_button.Visible = False
        '
        'kulgox_check
        '
        Me.kulgox_check.AutoSize = True
        Me.kulgox_check.BackColor = System.Drawing.Color.Transparent
        Me.kulgox_check.ForeColor = System.Drawing.Color.White
        Me.kulgox_check.Location = New System.Drawing.Point(428, 266)
        Me.kulgox_check.Name = "kulgox_check"
        Me.kulgox_check.Size = New System.Drawing.Size(110, 18)
        Me.kulgox_check.TabIndex = 61
        Me.kulgox_check.Text = "Kulgox Octal Sac"
        Me.kulgox_check.UseCompatibleTextRendering = True
        Me.kulgox_check.UseVisualStyleBackColor = False
        Me.kulgox_check.Visible = False
        '
        'stryllpathogen_check
        '
        Me.stryllpathogen_check.AutoSize = True
        Me.stryllpathogen_check.BackColor = System.Drawing.Color.Transparent
        Me.stryllpathogen_check.ForeColor = System.Drawing.Color.White
        Me.stryllpathogen_check.Location = New System.Drawing.Point(428, 243)
        Me.stryllpathogen_check.Name = "stryllpathogen_check"
        Me.stryllpathogen_check.Size = New System.Drawing.Size(100, 18)
        Me.stryllpathogen_check.TabIndex = 60
        Me.stryllpathogen_check.Text = "Stryll Pathogen"
        Me.stryllpathogen_check.UseCompatibleTextRendering = True
        Me.stryllpathogen_check.UseVisualStyleBackColor = False
        Me.stryllpathogen_check.Visible = False
        '
        'mutagenic_check
        '
        Me.mutagenic_check.AutoSize = True
        Me.mutagenic_check.BackColor = System.Drawing.Color.Transparent
        Me.mutagenic_check.ForeColor = System.Drawing.Color.White
        Me.mutagenic_check.Location = New System.Drawing.Point(428, 220)
        Me.mutagenic_check.Name = "mutagenic_check"
        Me.mutagenic_check.Size = New System.Drawing.Size(125, 18)
        Me.mutagenic_check.TabIndex = 59
        Me.mutagenic_check.Text = "Mutagenic Cartridge"
        Me.mutagenic_check.UseCompatibleTextRendering = True
        Me.mutagenic_check.UseVisualStyleBackColor = False
        Me.mutagenic_check.Visible = False
        '
        'crux_amp_check
        '
        Me.crux_amp_check.AutoSize = True
        Me.crux_amp_check.BackColor = System.Drawing.Color.Transparent
        Me.crux_amp_check.ForeColor = System.Drawing.Color.White
        Me.crux_amp_check.Location = New System.Drawing.Point(303, 289)
        Me.crux_amp_check.Name = "crux_amp_check"
        Me.crux_amp_check.Size = New System.Drawing.Size(94, 18)
        Me.crux_amp_check.TabIndex = 58
        Me.crux_amp_check.Text = "Crux Amplifier"
        Me.crux_amp_check.UseCompatibleTextRendering = True
        Me.crux_amp_check.UseVisualStyleBackColor = False
        '
        'sw_listbox
        '
        Me.sw_listbox.FormattingEnabled = True
        Me.sw_listbox.Items.AddRange(New Object() {"Bane Emiter", "Charged Bane Emitter", "Composite Ray", "Continuum Parser", "Crimson Auto-Laser", "Crimson Auto-Phaser", "Dominion Auto-Blaster", "Dominion Cannon", "Dominion Cannon Mk II", "Dominion Cannon Mk III", "Exotic Pulser", "Hypercharged Bane Emitter", "Ion Pulse Ballistae", "Korteth Twin-Blaster", "Lazuli Mind Controller", "Lazuli Tevrazon Core", "Leviathan Rift-Emitter", "Litheor Data Interface", "Megacharged Bane Emitter", "Mod Xecti Disruptor +20", "Mod Xecti Disruptor +40", "Mylarai Plasma Lance", "Overcharged Bane Emitter", "Psionic Amplifier", "Radiant Mk I", "Radiant Mk II", "Radiant Mk III", "Radiant Mk IV", "Radiant Mk V", "Radiant Mk VI", "Radiant Mk VII", "Radiant Mk VIII", "Radiant Mk IX", "Sha’din Terminal +75", "Taltherian Sentry", "T-Plasma Gemini", "Vortul Blast Phaser"})
        Me.sw_listbox.Location = New System.Drawing.Point(302, 65)
        Me.sw_listbox.Name = "sw_listbox"
        Me.sw_listbox.Size = New System.Drawing.Size(161, 95)
        Me.sw_listbox.TabIndex = 48
        '
        'surge_plexus_label
        '
        Me.surge_plexus_label.AutoSize = True
        Me.surge_plexus_label.BackColor = System.Drawing.Color.Transparent
        Me.surge_plexus_label.ForeColor = System.Drawing.Color.White
        Me.surge_plexus_label.Location = New System.Drawing.Point(366, 380)
        Me.surge_plexus_label.Name = "surge_plexus_label"
        Me.surge_plexus_label.Size = New System.Drawing.Size(75, 17)
        Me.surge_plexus_label.TabIndex = 57
        Me.surge_plexus_label.Text = "Surge Plexus:"
        Me.surge_plexus_label.UseCompatibleTextRendering = True
        Me.surge_plexus_label.Visible = False
        '
        'SurgePlexus_ComboBox
        '
        Me.SurgePlexus_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SurgePlexus_ComboBox.FormattingEnabled = True
        Me.SurgePlexus_ComboBox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.SurgePlexus_ComboBox.Location = New System.Drawing.Point(443, 377)
        Me.SurgePlexus_ComboBox.Name = "SurgePlexus_ComboBox"
        Me.SurgePlexus_ComboBox.Size = New System.Drawing.Size(61, 21)
        Me.SurgePlexus_ComboBox.TabIndex = 56
        Me.SurgePlexus_ComboBox.Visible = False
        '
        'shockpulse_check
        '
        Me.shockpulse_check.AutoSize = True
        Me.shockpulse_check.BackColor = System.Drawing.Color.Transparent
        Me.shockpulse_check.ForeColor = System.Drawing.Color.White
        Me.shockpulse_check.Location = New System.Drawing.Point(303, 312)
        Me.shockpulse_check.Name = "shockpulse_check"
        Me.shockpulse_check.Size = New System.Drawing.Size(127, 18)
        Me.shockpulse_check.TabIndex = 55
        Me.shockpulse_check.Text = "ShockPulse Charger"
        Me.shockpulse_check.UseCompatibleTextRendering = True
        Me.shockpulse_check.UseVisualStyleBackColor = False
        Me.shockpulse_check.Visible = False
        '
        'InvasionBox
        '
        Me.InvasionBox.FormattingEnabled = True
        Me.InvasionBox.Items.AddRange(New Object() {"Bane Emiter", "Charged Bane Emitter", "Composite Ray", "Continuum Parser", "Crimson Auto-Laser", "Crimson Auto-Phaser", "Dominion Auto-Blaster", "Dominion Cannon", "Dominion Cannon Mk II", "Dominion Cannon Mk III", "Exo-Temporal Translator", "Exotic Pulser", "Hypercharged Bane Emitter", "Ion Pulse Ballistae", "Korteth Twin-Blaster", "Lazuli Mind Controller", "Lazuli Tevrazon Core", "Leviathan Rift-Emitter", "Litheor Data Interface", "Megacharged Bane Emitter", "Mod Xecti Disruptor +20", "Mod Xecti Disruptor +40", "Mylarai Plasma Lance", "Overcharged Bane Emitter", "Psionic Amplifier", "Radiant Mk I", "Radiant Mk II", "Radiant Mk III", "Radiant Mk IV", "Radiant Mk V", "Radiant Mk VI", "Radiant Mk VII", "Radiant Mk VIII", "Radiant Mk IX", "Sha’din Terminal +75", "Sha’din Terminal +200", "Taltherian Sentry", "T-Plasma Gemini", "Vortul Blast Phaser"})
        Me.InvasionBox.Location = New System.Drawing.Point(302, 65)
        Me.InvasionBox.Name = "InvasionBox"
        Me.InvasionBox.Size = New System.Drawing.Size(161, 95)
        Me.InvasionBox.TabIndex = 54
        Me.InvasionBox.Visible = False
        '
        'special_label
        '
        Me.special_label.AutoSize = True
        Me.special_label.BackColor = System.Drawing.Color.Transparent
        Me.special_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.special_label.ForeColor = System.Drawing.Color.White
        Me.special_label.Location = New System.Drawing.Point(302, 45)
        Me.special_label.Name = "special_label"
        Me.special_label.Size = New System.Drawing.Size(99, 17)
        Me.special_label.TabIndex = 52
        Me.special_label.Text = "Special Weapons:"
        Me.special_label.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(365, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Mission Tiers:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'mteir_combobox
        '
        Me.mteir_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mteir_combobox.FormattingEnabled = True
        Me.mteir_combobox.Items.AddRange(New Object() {"3", "6", "9", "12", "15", "22", "26", "30", "34", "38", "42", "46", "50", "54", "58", "62", "66", "70", "74", "78", "82", "86", "90"})
        Me.mteir_combobox.Location = New System.Drawing.Point(443, 345)
        Me.mteir_combobox.Name = "mteir_combobox"
        Me.mteir_combobox.Size = New System.Drawing.Size(61, 21)
        Me.mteir_combobox.TabIndex = 50
        '
        'sw_numberselect_combobox
        '
        Me.sw_numberselect_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sw_numberselect_combobox.FormattingEnabled = True
        Me.sw_numberselect_combobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.sw_numberselect_combobox.Location = New System.Drawing.Point(469, 65)
        Me.sw_numberselect_combobox.Name = "sw_numberselect_combobox"
        Me.sw_numberselect_combobox.Size = New System.Drawing.Size(45, 21)
        Me.sw_numberselect_combobox.TabIndex = 49
        '
        'Officers_Label
        '
        Me.Officers_Label.AutoSize = True
        Me.Officers_Label.BackColor = System.Drawing.Color.Transparent
        Me.Officers_Label.ForeColor = System.Drawing.Color.White
        Me.Officers_Label.Location = New System.Drawing.Point(350, 461)
        Me.Officers_Label.Name = "Officers_Label"
        Me.Officers_Label.Size = New System.Drawing.Size(89, 17)
        Me.Officers_Label.TabIndex = 47
        Me.Officers_Label.Text = "Tactical Officers:"
        Me.Officers_Label.UseCompatibleTextRendering = True
        '
        'tac_officers_textbox
        '
        Me.tac_officers_textbox.Location = New System.Drawing.Point(443, 458)
        Me.tac_officers_textbox.Name = "tac_officers_textbox"
        Me.tac_officers_textbox.Size = New System.Drawing.Size(100, 20)
        Me.tac_officers_textbox.TabIndex = 46
        '
        'fifteen_percent_check
        '
        Me.fifteen_percent_check.AutoSize = True
        Me.fifteen_percent_check.BackColor = System.Drawing.Color.Transparent
        Me.fifteen_percent_check.ForeColor = System.Drawing.Color.White
        Me.fifteen_percent_check.Location = New System.Drawing.Point(303, 266)
        Me.fifteen_percent_check.Name = "fifteen_percent_check"
        Me.fifteen_percent_check.Size = New System.Drawing.Size(113, 18)
        Me.fifteen_percent_check.TabIndex = 45
        Me.fifteen_percent_check.Text = "Crimson Amplifier"
        Me.fifteen_percent_check.UseCompatibleTextRendering = True
        Me.fifteen_percent_check.UseVisualStyleBackColor = False
        '
        'ten_percent_check
        '
        Me.ten_percent_check.AutoSize = True
        Me.ten_percent_check.BackColor = System.Drawing.Color.Transparent
        Me.ten_percent_check.ForeColor = System.Drawing.Color.White
        Me.ten_percent_check.Location = New System.Drawing.Point(303, 243)
        Me.ten_percent_check.Name = "ten_percent_check"
        Me.ten_percent_check.Size = New System.Drawing.Size(106, 18)
        Me.ten_percent_check.TabIndex = 44
        Me.ten_percent_check.Text = "Crimson Obelisk"
        Me.ten_percent_check.UseCompatibleTextRendering = True
        Me.ten_percent_check.UseVisualStyleBackColor = False
        '
        'five_percent_check
        '
        Me.five_percent_check.AutoSize = True
        Me.five_percent_check.BackColor = System.Drawing.Color.Transparent
        Me.five_percent_check.ForeColor = System.Drawing.Color.White
        Me.five_percent_check.Location = New System.Drawing.Point(303, 220)
        Me.five_percent_check.Name = "five_percent_check"
        Me.five_percent_check.Size = New System.Drawing.Size(124, 18)
        Me.five_percent_check.TabIndex = 43
        Me.five_percent_check.Text = "Ancient Crystal Foci"
        Me.five_percent_check.UseCompatibleTextRendering = True
        Me.five_percent_check.UseVisualStyleBackColor = False
        '
        'attack_calc_button
        '
        Me.attack_calc_button.BackColor = System.Drawing.Color.Transparent
        Me.attack_calc_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.attack_calc_button.Location = New System.Drawing.Point(571, 502)
        Me.attack_calc_button.Name = "attack_calc_button"
        Me.attack_calc_button.Size = New System.Drawing.Size(75, 23)
        Me.attack_calc_button.TabIndex = 42
        Me.attack_calc_button.Text = "Calculate"
        Me.attack_calc_button.UseCompatibleTextRendering = True
        Me.attack_calc_button.UseVisualStyleBackColor = False
        '
        'attack_textbox
        '
        Me.attack_textbox.Location = New System.Drawing.Point(638, 458)
        Me.attack_textbox.Name = "attack_textbox"
        Me.attack_textbox.Size = New System.Drawing.Size(114, 20)
        Me.attack_textbox.TabIndex = 41
        '
        'rw_reset_button
        '
        Me.rw_reset_button.BackColor = System.Drawing.Color.Transparent
        Me.rw_reset_button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.rw_reset_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rw_reset_button.Location = New System.Drawing.Point(677, 502)
        Me.rw_reset_button.Name = "rw_reset_button"
        Me.rw_reset_button.Size = New System.Drawing.Size(75, 23)
        Me.rw_reset_button.TabIndex = 40
        Me.rw_reset_button.Text = "Clear/Reset"
        Me.rw_reset_button.UseCompatibleTextRendering = True
        Me.rw_reset_button.UseVisualStyleBackColor = False
        '
        'rw_numberselect_combobox
        '
        Me.rw_numberselect_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rw_numberselect_combobox.FormattingEnabled = True
        Me.rw_numberselect_combobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.rw_numberselect_combobox.Location = New System.Drawing.Point(227, 65)
        Me.rw_numberselect_combobox.Name = "rw_numberselect_combobox"
        Me.rw_numberselect_combobox.Size = New System.Drawing.Size(41, 21)
        Me.rw_numberselect_combobox.TabIndex = 39
        '
        'rw_add_button
        '
        Me.rw_add_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rw_add_button.Location = New System.Drawing.Point(146, 166)
        Me.rw_add_button.Name = "rw_add_button"
        Me.rw_add_button.Size = New System.Drawing.Size(75, 23)
        Me.rw_add_button.TabIndex = 38
        Me.rw_add_button.Text = "Add RW"
        Me.rw_add_button.UseCompatibleTextRendering = True
        Me.rw_add_button.UseVisualStyleBackColor = True
        '
        'installedweapons_textbox
        '
        Me.installedweapons_textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.installedweapons_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.installedweapons_textbox.Location = New System.Drawing.Point(57, 220)
        Me.installedweapons_textbox.Multiline = True
        Me.installedweapons_textbox.Name = "installedweapons_textbox"
        Me.installedweapons_textbox.ReadOnly = True
        Me.installedweapons_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.installedweapons_textbox.Size = New System.Drawing.Size(240, 215)
        Me.installedweapons_textbox.TabIndex = 37
        '
        'researched_label
        '
        Me.researched_label.AutoSize = True
        Me.researched_label.BackColor = System.Drawing.Color.Transparent
        Me.researched_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.researched_label.ForeColor = System.Drawing.Color.White
        Me.researched_label.Location = New System.Drawing.Point(54, 45)
        Me.researched_label.Name = "researched_label"
        Me.researched_label.Size = New System.Drawing.Size(123, 17)
        Me.researched_label.TabIndex = 36
        Me.researched_label.Text = "Researched Weapons:"
        Me.researched_label.UseCompatibleTextRendering = True
        '
        'rw_listbox
        '
        Me.rw_listbox.FormattingEnabled = True
        Me.rw_listbox.Items.AddRange(New Object() {"Autocannon", "Heavy Autocannon", "Light Mass Driver", "Mass Driver", "Heavy Mass Driver", "Light Laser Cannon", "Laser Cannon", "Heavy Laser Cannon", "Light Ion Cannon", "Ion Cannon", "Heavy Ion Cannon", "Light Plasma Cannon", "Plasma Cannon", "Heavy Plasma Cannon", "Light Phase Cannon", "Phase Cannon", "Heavy Phase Cannon", "Light Graviton Shearer", "Graviton Shearer", "Heavy Graviton Shearer", "Light Disuptor Cannon", "Disruptor Cannon", "Heavy Disruptor Cannon", "Light Quantum Devastator", "Quantum Devastator", "Heavy Quantum Devastator", "Light Singularity Launcher", "Singularity Launcher", "Heavy Singularity Launcher", "Light Antiproton Cannon", "Antiproton Cannon", "Heavy Antiproton Cannon", "Light Null Ray", "Null Ray", "Heavy Null Ray", "Light Thetachron Cannon", "Thetachron Cannon", "Heavy Thetachron Cannon", "Light Quasi-Chaotic Blaster", "Quasi-Chaotic Blaster", "Heavy Quasi-Chaotic Blaster"})
        Me.rw_listbox.Location = New System.Drawing.Point(57, 65)
        Me.rw_listbox.Name = "rw_listbox"
        Me.rw_listbox.Size = New System.Drawing.Size(164, 95)
        Me.rw_listbox.TabIndex = 35
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(776, 24)
        Me.MenuStrip1.TabIndex = 69
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.NPCToolStripMenuItem, Me.InvasionToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Checked = True
        Me.StandardToolStripMenuItem.CheckOnClick = True
        Me.StandardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        Me.StandardToolStripMenuItem.ToolTipText = "Use this setting for PvP calculations"
        '
        'NPCToolStripMenuItem
        '
        Me.NPCToolStripMenuItem.CheckOnClick = True
        Me.NPCToolStripMenuItem.Name = "NPCToolStripMenuItem"
        Me.NPCToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.NPCToolStripMenuItem.Text = "NPC"
        Me.NPCToolStripMenuItem.ToolTipText = "Use this setting for NPC calculations"
        '
        'InvasionToolStripMenuItem
        '
        Me.InvasionToolStripMenuItem.CheckOnClick = True
        Me.InvasionToolStripMenuItem.Name = "InvasionToolStripMenuItem"
        Me.InvasionToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.InvasionToolStripMenuItem.Text = "Invasion"
        Me.InvasionToolStripMenuItem.ToolTipText = "Use this setting for invasion strength calculations"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'bioship_dropdown
        '
        Me.bioship_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bioship_dropdown.FormattingEnabled = True
        Me.bioship_dropdown.Items.AddRange(New Object() {"(none)", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.bioship_dropdown.Location = New System.Drawing.Point(638, 65)
        Me.bioship_dropdown.Name = "bioship_dropdown"
        Me.bioship_dropdown.Size = New System.Drawing.Size(66, 21)
        Me.bioship_dropdown.TabIndex = 70
        '
        'apparitious_dropdown
        '
        Me.apparitious_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.apparitious_dropdown.FormattingEnabled = True
        Me.apparitious_dropdown.Items.AddRange(New Object() {"(none)", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.apparitious_dropdown.Location = New System.Drawing.Point(638, 105)
        Me.apparitious_dropdown.Name = "apparitious_dropdown"
        Me.apparitious_dropdown.Size = New System.Drawing.Size(66, 21)
        Me.apparitious_dropdown.TabIndex = 71
        '
        'anubix_dropdown
        '
        Me.anubix_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.anubix_dropdown.FormattingEnabled = True
        Me.anubix_dropdown.Items.AddRange(New Object() {"(none)", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.anubix_dropdown.Location = New System.Drawing.Point(638, 145)
        Me.anubix_dropdown.Name = "anubix_dropdown"
        Me.anubix_dropdown.Size = New System.Drawing.Size(66, 21)
        Me.anubix_dropdown.TabIndex = 72
        '
        'bioship_label
        '
        Me.bioship_label.AutoSize = True
        Me.bioship_label.BackColor = System.Drawing.Color.Transparent
        Me.bioship_label.ForeColor = System.Drawing.Color.White
        Me.bioship_label.Location = New System.Drawing.Point(566, 68)
        Me.bioship_label.Name = "bioship_label"
        Me.bioship_label.Size = New System.Drawing.Size(66, 17)
        Me.bioship_label.TabIndex = 73
        Me.bioship_label.Text = "Bioship Ally:"
        Me.bioship_label.UseCompatibleTextRendering = True
        '
        'apparitious_label
        '
        Me.apparitious_label.AutoSize = True
        Me.apparitious_label.BackColor = System.Drawing.Color.Transparent
        Me.apparitious_label.ForeColor = System.Drawing.Color.White
        Me.apparitious_label.Location = New System.Drawing.Point(546, 108)
        Me.apparitious_label.Name = "apparitious_label"
        Me.apparitious_label.Size = New System.Drawing.Size(86, 17)
        Me.apparitious_label.TabIndex = 74
        Me.apparitious_label.Text = "Apparitious Ally:"
        Me.apparitious_label.UseCompatibleTextRendering = True
        '
        'anubix_label
        '
        Me.anubix_label.AutoSize = True
        Me.anubix_label.BackColor = System.Drawing.Color.Transparent
        Me.anubix_label.ForeColor = System.Drawing.Color.White
        Me.anubix_label.Location = New System.Drawing.Point(556, 148)
        Me.anubix_label.Name = "anubix_label"
        Me.anubix_label.Size = New System.Drawing.Size(76, 17)
        Me.anubix_label.TabIndex = 75
        Me.anubix_label.Text = "Anubix Drone:"
        Me.anubix_label.UseCompatibleTextRendering = True
        '
        'cerulean_checkbox
        '
        Me.cerulean_checkbox.AutoSize = True
        Me.cerulean_checkbox.BackColor = System.Drawing.Color.Transparent
        Me.cerulean_checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cerulean_checkbox.ForeColor = System.Drawing.Color.White
        Me.cerulean_checkbox.Location = New System.Drawing.Point(590, 221)
        Me.cerulean_checkbox.Name = "cerulean_checkbox"
        Me.cerulean_checkbox.Size = New System.Drawing.Size(114, 18)
        Me.cerulean_checkbox.TabIndex = 76
        Me.cerulean_checkbox.Text = "Cerulean Fighter: "
        Me.cerulean_checkbox.UseCompatibleTextRendering = True
        Me.cerulean_checkbox.UseVisualStyleBackColor = False
        '
        'nightclaw_checkbox
        '
        Me.nightclaw_checkbox.AutoSize = True
        Me.nightclaw_checkbox.BackColor = System.Drawing.Color.Transparent
        Me.nightclaw_checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nightclaw_checkbox.ForeColor = System.Drawing.Color.White
        Me.nightclaw_checkbox.Location = New System.Drawing.Point(587, 243)
        Me.nightclaw_checkbox.Name = "nightclaw_checkbox"
        Me.nightclaw_checkbox.Size = New System.Drawing.Size(117, 18)
        Me.nightclaw_checkbox.TabIndex = 77
        Me.nightclaw_checkbox.Text = "Nightclaw Fighter: "
        Me.nightclaw_checkbox.UseCompatibleTextRendering = True
        Me.nightclaw_checkbox.UseVisualStyleBackColor = False
        '
        'dark_chassis_checkbox
        '
        Me.dark_chassis_checkbox.AutoSize = True
        Me.dark_chassis_checkbox.BackColor = System.Drawing.Color.Transparent
        Me.dark_chassis_checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dark_chassis_checkbox.ForeColor = System.Drawing.Color.White
        Me.dark_chassis_checkbox.Location = New System.Drawing.Point(562, 267)
        Me.dark_chassis_checkbox.Name = "dark_chassis_checkbox"
        Me.dark_chassis_checkbox.Size = New System.Drawing.Size(142, 18)
        Me.dark_chassis_checkbox.TabIndex = 78
        Me.dark_chassis_checkbox.Text = "Dark Smuggler Chassis"
        Me.dark_chassis_checkbox.UseCompatibleTextRendering = True
        Me.dark_chassis_checkbox.UseVisualStyleBackColor = False
        '
        'race_label
        '
        Me.race_label.AutoSize = True
        Me.race_label.BackColor = System.Drawing.Color.Transparent
        Me.race_label.ForeColor = System.Drawing.Color.White
        Me.race_label.Location = New System.Drawing.Point(598, 349)
        Me.race_label.Name = "race_label"
        Me.race_label.Size = New System.Drawing.Size(34, 17)
        Me.race_label.TabIndex = 80
        Me.race_label.Text = "Race:"
        Me.race_label.UseCompatibleTextRendering = True
        '
        'race_dropdown
        '
        Me.race_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.race_dropdown.FormattingEnabled = True
        Me.race_dropdown.Items.AddRange(New Object() {"Aerlen", "Drannik", "Genetarr", "Human", "Inergon", "Konqul", "Kronyn", "Litheor", "Mylarai", "Sillixx", "Taltherian", "Vygoid", "Xecti", "Zolazin"})
        Me.race_dropdown.Location = New System.Drawing.Point(638, 345)
        Me.race_dropdown.Name = "race_dropdown"
        Me.race_dropdown.Size = New System.Drawing.Size(66, 21)
        Me.race_dropdown.TabIndex = 81
        '
        'Attack_Form
        '
        Me.AcceptButton = Me.attack_calc_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 544)
        Me.Controls.Add(Me.race_dropdown)
        Me.Controls.Add(Me.race_label)
        Me.Controls.Add(Me.dark_chassis_checkbox)
        Me.Controls.Add(Me.nightclaw_checkbox)
        Me.Controls.Add(Me.cerulean_checkbox)
        Me.Controls.Add(Me.anubix_label)
        Me.Controls.Add(Me.apparitious_label)
        Me.Controls.Add(Me.bioship_label)
        Me.Controls.Add(Me.anubix_dropdown)
        Me.Controls.Add(Me.apparitious_dropdown)
        Me.Controls.Add(Me.bioship_dropdown)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.installed_label)
        Me.Controls.Add(Me.atmos_label)
        Me.Controls.Add(Me.tetra_label)
        Me.Controls.Add(Me.sw_add_button)
        Me.Controls.Add(Me.atmos_combobox)
        Me.Controls.Add(Me.tetra_combobox)
        Me.Controls.Add(Me.inv_add_button)
        Me.Controls.Add(Me.kulgox_check)
        Me.Controls.Add(Me.stryllpathogen_check)
        Me.Controls.Add(Me.mutagenic_check)
        Me.Controls.Add(Me.crux_amp_check)
        Me.Controls.Add(Me.sw_listbox)
        Me.Controls.Add(Me.surge_plexus_label)
        Me.Controls.Add(Me.SurgePlexus_ComboBox)
        Me.Controls.Add(Me.shockpulse_check)
        Me.Controls.Add(Me.InvasionBox)
        Me.Controls.Add(Me.special_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mteir_combobox)
        Me.Controls.Add(Me.sw_numberselect_combobox)
        Me.Controls.Add(Me.Officers_Label)
        Me.Controls.Add(Me.tac_officers_textbox)
        Me.Controls.Add(Me.fifteen_percent_check)
        Me.Controls.Add(Me.ten_percent_check)
        Me.Controls.Add(Me.five_percent_check)
        Me.Controls.Add(Me.attack_calc_button)
        Me.Controls.Add(Me.attack_textbox)
        Me.Controls.Add(Me.rw_reset_button)
        Me.Controls.Add(Me.rw_numberselect_combobox)
        Me.Controls.Add(Me.rw_add_button)
        Me.Controls.Add(Me.installedweapons_textbox)
        Me.Controls.Add(Me.researched_label)
        Me.Controls.Add(Me.rw_listbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Attack_Form"
        Me.Text = "Attack Strength Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents installed_label As System.Windows.Forms.Label
    Friend WithEvents atmos_label As System.Windows.Forms.Label
    Friend WithEvents tetra_label As System.Windows.Forms.Label
    Friend WithEvents sw_add_button As System.Windows.Forms.Button
    Friend WithEvents atmos_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents tetra_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents inv_add_button As System.Windows.Forms.Button
    Friend WithEvents kulgox_check As System.Windows.Forms.CheckBox
    Friend WithEvents stryllpathogen_check As System.Windows.Forms.CheckBox
    Friend WithEvents mutagenic_check As System.Windows.Forms.CheckBox
    Friend WithEvents crux_amp_check As System.Windows.Forms.CheckBox
    Friend WithEvents sw_listbox As System.Windows.Forms.ListBox
    Friend WithEvents surge_plexus_label As System.Windows.Forms.Label
    Friend WithEvents SurgePlexus_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents shockpulse_check As System.Windows.Forms.CheckBox
    Friend WithEvents InvasionBox As System.Windows.Forms.ListBox
    Friend WithEvents special_label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mteir_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents sw_numberselect_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents Officers_Label As System.Windows.Forms.Label
    Friend WithEvents tac_officers_textbox As System.Windows.Forms.TextBox
    Friend WithEvents fifteen_percent_check As System.Windows.Forms.CheckBox
    Friend WithEvents ten_percent_check As System.Windows.Forms.CheckBox
    Friend WithEvents five_percent_check As System.Windows.Forms.CheckBox
    Friend WithEvents attack_calc_button As System.Windows.Forms.Button
    Friend WithEvents attack_textbox As System.Windows.Forms.TextBox
    Friend WithEvents rw_reset_button As System.Windows.Forms.Button
    Friend WithEvents rw_numberselect_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents rw_add_button As System.Windows.Forms.Button
    Friend WithEvents installedweapons_textbox As System.Windows.Forms.TextBox
    Friend WithEvents researched_label As System.Windows.Forms.Label
    Friend WithEvents rw_listbox As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvasionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bioship_dropdown As System.Windows.Forms.ComboBox
    Friend WithEvents apparitious_dropdown As System.Windows.Forms.ComboBox
    Friend WithEvents anubix_dropdown As System.Windows.Forms.ComboBox
    Friend WithEvents bioship_label As System.Windows.Forms.Label
    Friend WithEvents apparitious_label As System.Windows.Forms.Label
    Friend WithEvents anubix_label As System.Windows.Forms.Label
    Friend WithEvents cerulean_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents nightclaw_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents dark_chassis_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents race_label As System.Windows.Forms.Label
    Friend WithEvents race_dropdown As System.Windows.Forms.ComboBox
End Class
