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
        Me.components = New System.ComponentModel.Container()
        Me.rw_listbox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.installedweapons_textbox = New System.Windows.Forms.TextBox()
        Me.rw_add_button = New System.Windows.Forms.Button()
        Me.rw_numberselect_combobox = New System.Windows.Forms.ComboBox()
        Me.rw_reset_button = New System.Windows.Forms.Button()
        Me.attack_textbox = New System.Windows.Forms.TextBox()
        Me.attack_calc_button = New System.Windows.Forms.Button()
        Me.five_percent_check = New System.Windows.Forms.CheckBox()
        Me.ten_percent_check = New System.Windows.Forms.CheckBox()
        Me.fifteen_percent_check = New System.Windows.Forms.CheckBox()
        Me.tac_officers_textbox = New System.Windows.Forms.TextBox()
        Me.Officers_Label = New System.Windows.Forms.Label()
        Me.sw_listbox = New System.Windows.Forms.ListBox()
        Me.sw_numberselect_combobox = New System.Windows.Forms.ComboBox()
        Me.mteir_combobox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sw_add_button = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvasionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvasionBox = New System.Windows.Forms.ListBox()
        Me.shockpulse_check = New System.Windows.Forms.CheckBox()
        Me.SurgePlexus_ComboBox = New System.Windows.Forms.ComboBox()
        Me.surge_plexus_label = New System.Windows.Forms.Label()
        Me.crux_amp_check = New System.Windows.Forms.CheckBox()
        Me.mutagenic_check = New System.Windows.Forms.CheckBox()
        Me.stryllpathogen_check = New System.Windows.Forms.CheckBox()
        Me.kulgox_check = New System.Windows.Forms.CheckBox()
        Me.inv_add_button = New System.Windows.Forms.Button()
        Me.tetra_combobox = New System.Windows.Forms.ComboBox()
        Me.atmos_combobox = New System.Windows.Forms.ComboBox()
        Me.tetra_label = New System.Windows.Forms.Label()
        Me.atmos_label = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rw_listbox
        '
        Me.rw_listbox.FormattingEnabled = True
        Me.rw_listbox.Items.AddRange(New Object() {"Autocannon", "Heavy Autocannon", "Light Mass Driver", "Mass Driver", "Heavy Mass Driver", "Light Laser Cannon", "Laser Cannon", "Heavy Laser Cannon", "Light Ion Cannon", "Ion Cannon", "Heavy Ion Cannon", "Light Plasma Cannon", "Plasma Cannon", "Heavy Plasma Cannon", "Light Phase Cannon", "Phase Cannon", "Heavy Phase Cannon", "Light Graviton Shearer", "Graviton Shearer", "Heavy Graviton Shearer", "Light Disuptor Cannon", "Disruptor Cannon", "Heavy Disruptor Cannon", "Light Quantum Devastator", "Quantum Devastator", "Heavy Quantum Devastator", "Light Singularity Launcher", "Singularity Launcher", "Heavy Singularity Launcher", "Light Antiproton Cannon", "Antiproton Cannon", "Heavy Antiproton Cannon", "Light Null Ray", "Null Ray", "Heavy Null Ray", "Light Thetachron Cannon", "Thetachron Cannon", "Heavy Thetachron Cannon", "Light Quasi-Chaotic Blaster", "Quasi-Chaotic Blaster", "Heavy Quasi-Chaotic Blaster"})
        Me.rw_listbox.Location = New System.Drawing.Point(42, 50)
        Me.rw_listbox.Name = "rw_listbox"
        Me.rw_listbox.Size = New System.Drawing.Size(164, 95)
        Me.rw_listbox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.rw_listbox, "Select a weapon type and the quantity to install")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Researched Weapons:"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'installedweapons_textbox
        '
        Me.installedweapons_textbox.Location = New System.Drawing.Point(42, 205)
        Me.installedweapons_textbox.Multiline = True
        Me.installedweapons_textbox.Name = "installedweapons_textbox"
        Me.installedweapons_textbox.ReadOnly = True
        Me.installedweapons_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.installedweapons_textbox.Size = New System.Drawing.Size(240, 215)
        Me.installedweapons_textbox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.installedweapons_textbox, "This area displays your entered weapon configuration. If there is a problem, pres" & _
        "s ""Clear/Reset""")
        '
        'rw_add_button
        '
        Me.rw_add_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rw_add_button.Location = New System.Drawing.Point(131, 151)
        Me.rw_add_button.Name = "rw_add_button"
        Me.rw_add_button.Size = New System.Drawing.Size(75, 23)
        Me.rw_add_button.TabIndex = 3
        Me.rw_add_button.Text = "Add RW"
        Me.ToolTip1.SetToolTip(Me.rw_add_button, "Click to add selected weapon and quantity to your configuration")
        Me.rw_add_button.UseCompatibleTextRendering = True
        Me.rw_add_button.UseVisualStyleBackColor = True
        '
        'rw_numberselect_combobox
        '
        Me.rw_numberselect_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rw_numberselect_combobox.FormattingEnabled = True
        Me.rw_numberselect_combobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.rw_numberselect_combobox.Location = New System.Drawing.Point(212, 50)
        Me.rw_numberselect_combobox.Name = "rw_numberselect_combobox"
        Me.rw_numberselect_combobox.Size = New System.Drawing.Size(41, 21)
        Me.rw_numberselect_combobox.TabIndex = 4
        '
        'rw_reset_button
        '
        Me.rw_reset_button.BackColor = System.Drawing.Color.Transparent
        Me.rw_reset_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rw_reset_button.Location = New System.Drawing.Point(662, 487)
        Me.rw_reset_button.Name = "rw_reset_button"
        Me.rw_reset_button.Size = New System.Drawing.Size(75, 23)
        Me.rw_reset_button.TabIndex = 5
        Me.rw_reset_button.Text = "Clear/Reset"
        Me.ToolTip1.SetToolTip(Me.rw_reset_button, "Click to reset the screen")
        Me.rw_reset_button.UseCompatibleTextRendering = True
        Me.rw_reset_button.UseVisualStyleBackColor = False
        '
        'attack_textbox
        '
        Me.attack_textbox.Location = New System.Drawing.Point(623, 443)
        Me.attack_textbox.Name = "attack_textbox"
        Me.attack_textbox.Size = New System.Drawing.Size(114, 20)
        Me.attack_textbox.TabIndex = 6
        '
        'attack_calc_button
        '
        Me.attack_calc_button.BackColor = System.Drawing.Color.Transparent
        Me.attack_calc_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.attack_calc_button.Location = New System.Drawing.Point(556, 487)
        Me.attack_calc_button.Name = "attack_calc_button"
        Me.attack_calc_button.Size = New System.Drawing.Size(75, 23)
        Me.attack_calc_button.TabIndex = 7
        Me.attack_calc_button.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.attack_calc_button, "Click to perform the weapon calculation")
        Me.attack_calc_button.UseCompatibleTextRendering = True
        Me.attack_calc_button.UseVisualStyleBackColor = False
        '
        'five_percent_check
        '
        Me.five_percent_check.AutoSize = True
        Me.five_percent_check.Location = New System.Drawing.Point(288, 205)
        Me.five_percent_check.Name = "five_percent_check"
        Me.five_percent_check.Size = New System.Drawing.Size(124, 18)
        Me.five_percent_check.TabIndex = 8
        Me.five_percent_check.Text = "Ancient Crystal Foci"
        Me.five_percent_check.UseCompatibleTextRendering = True
        Me.five_percent_check.UseVisualStyleBackColor = True
        '
        'ten_percent_check
        '
        Me.ten_percent_check.AutoSize = True
        Me.ten_percent_check.Location = New System.Drawing.Point(288, 228)
        Me.ten_percent_check.Name = "ten_percent_check"
        Me.ten_percent_check.Size = New System.Drawing.Size(106, 18)
        Me.ten_percent_check.TabIndex = 9
        Me.ten_percent_check.Text = "Crimson Obelisk"
        Me.ten_percent_check.UseCompatibleTextRendering = True
        Me.ten_percent_check.UseVisualStyleBackColor = True
        '
        'fifteen_percent_check
        '
        Me.fifteen_percent_check.AutoSize = True
        Me.fifteen_percent_check.Location = New System.Drawing.Point(288, 251)
        Me.fifteen_percent_check.Name = "fifteen_percent_check"
        Me.fifteen_percent_check.Size = New System.Drawing.Size(113, 18)
        Me.fifteen_percent_check.TabIndex = 10
        Me.fifteen_percent_check.Text = "Crimson Amplifier"
        Me.fifteen_percent_check.UseCompatibleTextRendering = True
        Me.fifteen_percent_check.UseVisualStyleBackColor = True
        '
        'tac_officers_textbox
        '
        Me.tac_officers_textbox.Location = New System.Drawing.Point(428, 443)
        Me.tac_officers_textbox.Name = "tac_officers_textbox"
        Me.tac_officers_textbox.Size = New System.Drawing.Size(100, 20)
        Me.tac_officers_textbox.TabIndex = 11
        '
        'Officers_Label
        '
        Me.Officers_Label.AutoSize = True
        Me.Officers_Label.Location = New System.Drawing.Point(335, 446)
        Me.Officers_Label.Name = "Officers_Label"
        Me.Officers_Label.Size = New System.Drawing.Size(89, 17)
        Me.Officers_Label.TabIndex = 12
        Me.Officers_Label.Text = "Tactical Officers:"
        Me.Officers_Label.UseCompatibleTextRendering = True
        '
        'sw_listbox
        '
        Me.sw_listbox.FormattingEnabled = True
        Me.sw_listbox.Items.AddRange(New Object() {"Bane Emiter", "Charged Bane Emitter", "Overcharged Bane Emitter", "Hypercharged Bane Emitter", "Crimson Auto-Laser", "Crimson Auto-Phaser", "Vortul Blast Phaser", "Korteth Twin-Blaster", "Dominion Cannon", "Dominion Cannon Mk II", "Dominion Cannon Mk III", "Dominion Auto-Blaster", "Lazuli Mind Controller", "Ion Pulse Ballistae", "Exotic Pulser", "Psionic Amplifier", "Leviathan Rift-Emitter", "Taltherian Sentry", "Mod Xecti Disruptor", "**Mod Xecti Disruptor", "Composite Ray", "Mylarai Plasma Lance", "Radiant Mk I", "Radiant Mk II", "Radiant Mk III", "Radiant Mk IV", "Radiant Mk V", "Radiant Mk VI", "Radiant Mk VII", "Radiant Mk VIII", "Radiant Mk IX"})
        Me.sw_listbox.Location = New System.Drawing.Point(287, 50)
        Me.sw_listbox.Name = "sw_listbox"
        Me.sw_listbox.Size = New System.Drawing.Size(161, 95)
        Me.sw_listbox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.sw_listbox, "Select a weapon type and the quantity to install")
        '
        'sw_numberselect_combobox
        '
        Me.sw_numberselect_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sw_numberselect_combobox.FormattingEnabled = True
        Me.sw_numberselect_combobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.sw_numberselect_combobox.Location = New System.Drawing.Point(454, 50)
        Me.sw_numberselect_combobox.Name = "sw_numberselect_combobox"
        Me.sw_numberselect_combobox.Size = New System.Drawing.Size(45, 21)
        Me.sw_numberselect_combobox.TabIndex = 14
        '
        'mteir_combobox
        '
        Me.mteir_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mteir_combobox.FormattingEnabled = True
        Me.mteir_combobox.Items.AddRange(New Object() {"3", "6", "9", "12", "15", "22", "26", "30", "34", "38", "42", "46", "50", "54", "58", "62", "66", "70", "74", "78", "82", "86", "90"})
        Me.mteir_combobox.Location = New System.Drawing.Point(428, 330)
        Me.mteir_combobox.Name = "mteir_combobox"
        Me.mteir_combobox.Size = New System.Drawing.Size(61, 21)
        Me.mteir_combobox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Mission Teirs:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Special Weapons:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'sw_add_button
        '
        Me.sw_add_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sw_add_button.Location = New System.Drawing.Point(373, 151)
        Me.sw_add_button.Name = "sw_add_button"
        Me.sw_add_button.Size = New System.Drawing.Size(75, 23)
        Me.sw_add_button.TabIndex = 18
        Me.sw_add_button.Text = "Add SW"
        Me.ToolTip1.SetToolTip(Me.sw_add_button, "Click to add selected weapon and quantity to your configuration")
        Me.sw_add_button.UseCompatibleTextRendering = True
        Me.sw_add_button.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(748, 24)
        Me.MenuStrip1.TabIndex = 19
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
        'InvasionBox
        '
        Me.InvasionBox.FormattingEnabled = True
        Me.InvasionBox.Items.AddRange(New Object() {"Bane Emiter", "Charged Bane Emitter", "Overcharged Bane Emitter", "Hypercharged Bane Emitter", "Crimson Auto-Laser", "Crimson Auto-Phaser", "Vortul Blast Phaser", "Korteth Twin-Blaster", "Dominion Cannon", "Dominion Cannon Mk II", "Dominion Cannon Mk III", "Dominion Auto-Blaster", "Lazuli Mind Controller", "Ion Pulse Ballistae", "Exotic Pulser", "Psionic Amplifier", "Leviathan Rift-Emitter", "Taltherian Sentry", "Mod Xecti Disruptor", "**Mod Xecti Disruptor", "Composite Ray", "Mylarai Plasma Lance", "Radiant Mk I", "Radiant Mk II", "Radiant Mk III", "Radiant Mk IV", "Radiant Mk V", "Radiant Mk VI", "Radiant Mk VII", "Radiant Mk VIII", "Radiant Mk IX", "Exo-Temporal Translator"})
        Me.InvasionBox.Location = New System.Drawing.Point(287, 50)
        Me.InvasionBox.Name = "InvasionBox"
        Me.InvasionBox.Size = New System.Drawing.Size(161, 95)
        Me.InvasionBox.TabIndex = 20
        Me.InvasionBox.Visible = False
        '
        'shockpulse_check
        '
        Me.shockpulse_check.AutoSize = True
        Me.shockpulse_check.Location = New System.Drawing.Point(288, 297)
        Me.shockpulse_check.Name = "shockpulse_check"
        Me.shockpulse_check.Size = New System.Drawing.Size(127, 18)
        Me.shockpulse_check.TabIndex = 21
        Me.shockpulse_check.Text = "ShockPulse Charger"
        Me.shockpulse_check.UseCompatibleTextRendering = True
        Me.shockpulse_check.UseVisualStyleBackColor = True
        Me.shockpulse_check.Visible = False
        '
        'SurgePlexus_ComboBox
        '
        Me.SurgePlexus_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SurgePlexus_ComboBox.FormattingEnabled = True
        Me.SurgePlexus_ComboBox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.SurgePlexus_ComboBox.Location = New System.Drawing.Point(428, 362)
        Me.SurgePlexus_ComboBox.Name = "SurgePlexus_ComboBox"
        Me.SurgePlexus_ComboBox.Size = New System.Drawing.Size(61, 21)
        Me.SurgePlexus_ComboBox.TabIndex = 22
        Me.SurgePlexus_ComboBox.Visible = False
        '
        'surge_plexus_label
        '
        Me.surge_plexus_label.AutoSize = True
        Me.surge_plexus_label.Location = New System.Drawing.Point(350, 365)
        Me.surge_plexus_label.Name = "surge_plexus_label"
        Me.surge_plexus_label.Size = New System.Drawing.Size(75, 17)
        Me.surge_plexus_label.TabIndex = 23
        Me.surge_plexus_label.Text = "Surge Plexus:"
        Me.surge_plexus_label.UseCompatibleTextRendering = True
        Me.surge_plexus_label.Visible = False
        '
        'crux_amp_check
        '
        Me.crux_amp_check.AutoSize = True
        Me.crux_amp_check.Location = New System.Drawing.Point(288, 274)
        Me.crux_amp_check.Name = "crux_amp_check"
        Me.crux_amp_check.Size = New System.Drawing.Size(94, 18)
        Me.crux_amp_check.TabIndex = 24
        Me.crux_amp_check.Text = "Crux Amplifier"
        Me.crux_amp_check.UseCompatibleTextRendering = True
        Me.crux_amp_check.UseVisualStyleBackColor = True
        '
        'mutagenic_check
        '
        Me.mutagenic_check.AutoSize = True
        Me.mutagenic_check.Location = New System.Drawing.Point(413, 205)
        Me.mutagenic_check.Name = "mutagenic_check"
        Me.mutagenic_check.Size = New System.Drawing.Size(125, 18)
        Me.mutagenic_check.TabIndex = 25
        Me.mutagenic_check.Text = "Mutagenic Cartridge"
        Me.mutagenic_check.UseCompatibleTextRendering = True
        Me.mutagenic_check.UseVisualStyleBackColor = True
        Me.mutagenic_check.Visible = False
        '
        'stryllpathogen_check
        '
        Me.stryllpathogen_check.AutoSize = True
        Me.stryllpathogen_check.Location = New System.Drawing.Point(413, 228)
        Me.stryllpathogen_check.Name = "stryllpathogen_check"
        Me.stryllpathogen_check.Size = New System.Drawing.Size(100, 18)
        Me.stryllpathogen_check.TabIndex = 26
        Me.stryllpathogen_check.Text = "Stryll Pathogen"
        Me.stryllpathogen_check.UseCompatibleTextRendering = True
        Me.stryllpathogen_check.UseVisualStyleBackColor = True
        Me.stryllpathogen_check.Visible = False
        '
        'kulgox_check
        '
        Me.kulgox_check.AutoSize = True
        Me.kulgox_check.Location = New System.Drawing.Point(413, 251)
        Me.kulgox_check.Name = "kulgox_check"
        Me.kulgox_check.Size = New System.Drawing.Size(110, 18)
        Me.kulgox_check.TabIndex = 27
        Me.kulgox_check.Text = "Kulgox Octal Sac"
        Me.kulgox_check.UseCompatibleTextRendering = True
        Me.kulgox_check.UseVisualStyleBackColor = True
        Me.kulgox_check.Visible = False
        '
        'inv_add_button
        '
        Me.inv_add_button.BackColor = System.Drawing.Color.Transparent
        Me.inv_add_button.ForeColor = System.Drawing.SystemColors.Desktop
        Me.inv_add_button.Location = New System.Drawing.Point(373, 151)
        Me.inv_add_button.Name = "inv_add_button"
        Me.inv_add_button.Size = New System.Drawing.Size(75, 23)
        Me.inv_add_button.TabIndex = 28
        Me.inv_add_button.Text = "Add SW"
        Me.ToolTip1.SetToolTip(Me.inv_add_button, "Click to add the selected weapon and quantity to your configuration")
        Me.inv_add_button.UseCompatibleTextRendering = True
        Me.inv_add_button.UseVisualStyleBackColor = False
        Me.inv_add_button.Visible = False
        '
        'tetra_combobox
        '
        Me.tetra_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tetra_combobox.FormattingEnabled = True
        Me.tetra_combobox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.tetra_combobox.Location = New System.Drawing.Point(428, 389)
        Me.tetra_combobox.Name = "tetra_combobox"
        Me.tetra_combobox.Size = New System.Drawing.Size(61, 21)
        Me.tetra_combobox.TabIndex = 29
        Me.tetra_combobox.Visible = False
        '
        'atmos_combobox
        '
        Me.atmos_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.atmos_combobox.FormattingEnabled = True
        Me.atmos_combobox.Items.AddRange(New Object() {"0", "1", "2"})
        Me.atmos_combobox.Location = New System.Drawing.Point(428, 416)
        Me.atmos_combobox.Name = "atmos_combobox"
        Me.atmos_combobox.Size = New System.Drawing.Size(61, 21)
        Me.atmos_combobox.TabIndex = 30
        Me.atmos_combobox.Visible = False
        '
        'tetra_label
        '
        Me.tetra_label.AutoSize = True
        Me.tetra_label.Location = New System.Drawing.Point(311, 392)
        Me.tetra_label.Name = "tetra_label"
        Me.tetra_label.Size = New System.Drawing.Size(115, 17)
        Me.tetra_label.TabIndex = 31
        Me.tetra_label.Text = "Tetra-Seek Targeters:"
        Me.tetra_label.UseCompatibleTextRendering = True
        Me.tetra_label.Visible = False
        '
        'atmos_label
        '
        Me.atmos_label.AutoSize = True
        Me.atmos_label.Location = New System.Drawing.Point(298, 419)
        Me.atmos_label.Name = "atmos_label"
        Me.atmos_label.Size = New System.Drawing.Size(131, 17)
        Me.atmos_label.TabIndex = 32
        Me.atmos_label.Text = "Atmospheric Decimators:"
        Me.atmos_label.UseCompatibleTextRendering = True
        Me.atmos_label.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Installed Modules:"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(623, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Calculated Attack:"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Attack_Form
        '
        Me.AcceptButton = Me.attack_calc_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(748, 522)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.Label3)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rw_listbox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Attack_Form"
        Me.Text = "Calculate Attack Strength"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rw_listbox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents installedweapons_textbox As System.Windows.Forms.TextBox
    Friend WithEvents rw_add_button As System.Windows.Forms.Button
    Friend WithEvents rw_numberselect_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents rw_reset_button As System.Windows.Forms.Button
    Friend WithEvents attack_textbox As System.Windows.Forms.TextBox
    Friend WithEvents attack_calc_button As System.Windows.Forms.Button
    Friend WithEvents five_percent_check As System.Windows.Forms.CheckBox
    Friend WithEvents ten_percent_check As System.Windows.Forms.CheckBox
    Friend WithEvents fifteen_percent_check As System.Windows.Forms.CheckBox
    Friend WithEvents tac_officers_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Officers_Label As System.Windows.Forms.Label
    Friend WithEvents sw_listbox As System.Windows.Forms.ListBox
    Friend WithEvents sw_numberselect_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents mteir_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sw_add_button As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvasionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvasionBox As System.Windows.Forms.ListBox
    Friend WithEvents shockpulse_check As System.Windows.Forms.CheckBox
    Friend WithEvents SurgePlexus_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents surge_plexus_label As System.Windows.Forms.Label
    Friend WithEvents crux_amp_check As System.Windows.Forms.CheckBox
    Friend WithEvents mutagenic_check As System.Windows.Forms.CheckBox
    Friend WithEvents stryllpathogen_check As System.Windows.Forms.CheckBox
    Friend WithEvents kulgox_check As System.Windows.Forms.CheckBox
    Friend WithEvents inv_add_button As System.Windows.Forms.Button
    Friend WithEvents tetra_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents atmos_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents tetra_label As System.Windows.Forms.Label
    Friend WithEvents atmos_label As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
