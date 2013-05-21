<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Defense_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Defense_Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseCombatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.installed_label = New System.Windows.Forms.Label()
        Me.velox_label = New System.Windows.Forms.Label()
        Me.bm50_label = New System.Windows.Forms.Label()
        Me.sd_add_button = New System.Windows.Forms.Button()
        Me.velox_combobox = New System.Windows.Forms.ComboBox()
        Me.bm50_combobox = New System.Windows.Forms.ComboBox()
        Me.decoy_check = New System.Windows.Forms.CheckBox()
        Me.sd_listbox = New System.Windows.Forms.ListBox()
        Me.mega_coil_label = New System.Windows.Forms.Label()
        Me.MegaCoil_ComboBox = New System.Windows.Forms.ComboBox()
        Me.eluder_matrix_check = New System.Windows.Forms.CheckBox()
        Me.special_label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mteir_combobox = New System.Windows.Forms.ComboBox()
        Me.sd_numberselect_combobox = New System.Windows.Forms.ComboBox()
        Me.Helmsmen_Label = New System.Windows.Forms.Label()
        Me.helmsmen_textbox = New System.Windows.Forms.TextBox()
        Me.tevrazon_check = New System.Windows.Forms.CheckBox()
        Me.xrp_fuel_check = New System.Windows.Forms.CheckBox()
        Me.grid_console_check = New System.Windows.Forms.CheckBox()
        Me.defense_calc_button = New System.Windows.Forms.Button()
        Me.defense_textbox = New System.Windows.Forms.TextBox()
        Me.rw_reset_button = New System.Windows.Forms.Button()
        Me.rd_numberselect_combobox = New System.Windows.Forms.ComboBox()
        Me.rd_add_button = New System.Windows.Forms.Button()
        Me.installeddefenses_textbox = New System.Windows.Forms.TextBox()
        Me.researched_label = New System.Windows.Forms.Label()
        Me.rd_listbox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(763, 24)
        Me.MenuStrip1.TabIndex = 104
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.NPCToolStripMenuItem, Me.BaseCombatToolStripMenuItem})
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
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        Me.StandardToolStripMenuItem.ToolTipText = "Use this setting for PvP calculations"
        '
        'NPCToolStripMenuItem
        '
        Me.NPCToolStripMenuItem.CheckOnClick = True
        Me.NPCToolStripMenuItem.Name = "NPCToolStripMenuItem"
        Me.NPCToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NPCToolStripMenuItem.Text = "NPC"
        Me.NPCToolStripMenuItem.ToolTipText = "Use this setting for NPC calculations"
        '
        'BaseCombatToolStripMenuItem
        '
        Me.BaseCombatToolStripMenuItem.CheckOnClick = True
        Me.BaseCombatToolStripMenuItem.Name = "BaseCombatToolStripMenuItem"
        Me.BaseCombatToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BaseCombatToolStripMenuItem.Text = "Base Combat"
        Me.BaseCombatToolStripMenuItem.ToolTipText = "Use this setting for invasion strength calculations"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(628, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Calculated Defense:"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'installed_label
        '
        Me.installed_label.AutoSize = True
        Me.installed_label.BackColor = System.Drawing.Color.Transparent
        Me.installed_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installed_label.ForeColor = System.Drawing.Color.White
        Me.installed_label.Location = New System.Drawing.Point(43, 204)
        Me.installed_label.Name = "installed_label"
        Me.installed_label.Size = New System.Drawing.Size(100, 17)
        Me.installed_label.TabIndex = 102
        Me.installed_label.Text = "Installed Modules:"
        Me.installed_label.UseCompatibleTextRendering = True
        '
        'velox_label
        '
        Me.velox_label.AutoSize = True
        Me.velox_label.BackColor = System.Drawing.Color.Transparent
        Me.velox_label.ForeColor = System.Drawing.Color.White
        Me.velox_label.Location = New System.Drawing.Point(336, 380)
        Me.velox_label.Name = "velox_label"
        Me.velox_label.Size = New System.Drawing.Size(87, 17)
        Me.velox_label.TabIndex = 101
        Me.velox_label.Text = "Velox Thrusters:"
        Me.velox_label.UseCompatibleTextRendering = True
        '
        'bm50_label
        '
        Me.bm50_label.AutoSize = True
        Me.bm50_label.BackColor = System.Drawing.Color.Transparent
        Me.bm50_label.ForeColor = System.Drawing.Color.White
        Me.bm50_label.Location = New System.Drawing.Point(303, 407)
        Me.bm50_label.Name = "bm50_label"
        Me.bm50_label.Size = New System.Drawing.Size(122, 17)
        Me.bm50_label.TabIndex = 100
        Me.bm50_label.Text = "BM50 Convoy Shuttles:"
        Me.bm50_label.UseCompatibleTextRendering = True
        '
        'sd_add_button
        '
        Me.sd_add_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sd_add_button.Location = New System.Drawing.Point(374, 170)
        Me.sd_add_button.Name = "sd_add_button"
        Me.sd_add_button.Size = New System.Drawing.Size(75, 23)
        Me.sd_add_button.TabIndex = 88
        Me.sd_add_button.Text = "Add SD"
        Me.sd_add_button.UseCompatibleTextRendering = True
        Me.sd_add_button.UseVisualStyleBackColor = True
        '
        'velox_combobox
        '
        Me.velox_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.velox_combobox.FormattingEnabled = True
        Me.velox_combobox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.velox_combobox.Location = New System.Drawing.Point(429, 377)
        Me.velox_combobox.Name = "velox_combobox"
        Me.velox_combobox.Size = New System.Drawing.Size(61, 21)
        Me.velox_combobox.TabIndex = 99
        '
        'bm50_combobox
        '
        Me.bm50_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bm50_combobox.FormattingEnabled = True
        Me.bm50_combobox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.bm50_combobox.Location = New System.Drawing.Point(429, 404)
        Me.bm50_combobox.Name = "bm50_combobox"
        Me.bm50_combobox.Size = New System.Drawing.Size(61, 21)
        Me.bm50_combobox.TabIndex = 98
        '
        'decoy_check
        '
        Me.decoy_check.AutoSize = True
        Me.decoy_check.BackColor = System.Drawing.Color.Transparent
        Me.decoy_check.ForeColor = System.Drawing.Color.White
        Me.decoy_check.Location = New System.Drawing.Point(289, 293)
        Me.decoy_check.Name = "decoy_check"
        Me.decoy_check.Size = New System.Drawing.Size(118, 18)
        Me.decoy_check.TabIndex = 93
        Me.decoy_check.Text = "Customized Decoy"
        Me.decoy_check.UseCompatibleTextRendering = True
        Me.decoy_check.UseVisualStyleBackColor = False
        Me.decoy_check.Visible = False
        '
        'sd_listbox
        '
        Me.sd_listbox.FormattingEnabled = True
        Me.sd_listbox.Items.AddRange(New Object() {"BioMimetic Sealer", "BioMimetic Sealer II", "Bio-Signature Scrambler", "Dark Complex Thruster", "Dark Phase Engine", "Dark Ring Thruster", "Datastream Compiler", "Kronyn Anomaly Engine", "Octafari Deflector", "Phase Interceptor Drive", "Prejoran Power-Diffuser", "Scruuge X-Deflector", "Sha'din Forcevoider", "Sha'din Hypervoider", "Silthion T-Phase Utricle", "Stryll Transponder", "Triaxial Array - Mk I", "Triaxial Array - Mk II"})
        Me.sd_listbox.Location = New System.Drawing.Point(289, 69)
        Me.sd_listbox.Name = "sd_listbox"
        Me.sd_listbox.Size = New System.Drawing.Size(161, 95)
        Me.sd_listbox.TabIndex = 83
        '
        'mega_coil_label
        '
        Me.mega_coil_label.AutoSize = True
        Me.mega_coil_label.BackColor = System.Drawing.Color.Transparent
        Me.mega_coil_label.ForeColor = System.Drawing.Color.White
        Me.mega_coil_label.Location = New System.Drawing.Point(316, 434)
        Me.mega_coil_label.Name = "mega_coil_label"
        Me.mega_coil_label.Size = New System.Drawing.Size(107, 17)
        Me.mega_coil_label.TabIndex = 92
        Me.mega_coil_label.Text = "Mega-Coil Repulsor:"
        Me.mega_coil_label.UseCompatibleTextRendering = True
        Me.mega_coil_label.Visible = False
        '
        'MegaCoil_ComboBox
        '
        Me.MegaCoil_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MegaCoil_ComboBox.FormattingEnabled = True
        Me.MegaCoil_ComboBox.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.MegaCoil_ComboBox.Location = New System.Drawing.Point(429, 431)
        Me.MegaCoil_ComboBox.Name = "MegaCoil_ComboBox"
        Me.MegaCoil_ComboBox.Size = New System.Drawing.Size(61, 21)
        Me.MegaCoil_ComboBox.TabIndex = 91
        Me.MegaCoil_ComboBox.Visible = False
        '
        'eluder_matrix_check
        '
        Me.eluder_matrix_check.AutoSize = True
        Me.eluder_matrix_check.BackColor = System.Drawing.Color.Transparent
        Me.eluder_matrix_check.ForeColor = System.Drawing.Color.White
        Me.eluder_matrix_check.Location = New System.Drawing.Point(289, 316)
        Me.eluder_matrix_check.Name = "eluder_matrix_check"
        Me.eluder_matrix_check.Size = New System.Drawing.Size(117, 18)
        Me.eluder_matrix_check.TabIndex = 90
        Me.eluder_matrix_check.Text = "Dark Eluder Matrix"
        Me.eluder_matrix_check.UseCompatibleTextRendering = True
        Me.eluder_matrix_check.UseVisualStyleBackColor = False
        Me.eluder_matrix_check.Visible = False
        '
        'special_label
        '
        Me.special_label.AutoSize = True
        Me.special_label.BackColor = System.Drawing.Color.Transparent
        Me.special_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.special_label.ForeColor = System.Drawing.Color.White
        Me.special_label.Location = New System.Drawing.Point(288, 49)
        Me.special_label.Name = "special_label"
        Me.special_label.Size = New System.Drawing.Size(99, 17)
        Me.special_label.TabIndex = 87
        Me.special_label.Text = "Special Defenses:"
        Me.special_label.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(349, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Mission Tiers:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'mteir_combobox
        '
        Me.mteir_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mteir_combobox.FormattingEnabled = True
        Me.mteir_combobox.Items.AddRange(New Object() {"3", "6", "9", "12", "15", "22", "26", "30", "34", "38", "42", "46", "50", "54", "58", "62", "66", "70", "74", "78", "82", "86", "90"})
        Me.mteir_combobox.Location = New System.Drawing.Point(429, 349)
        Me.mteir_combobox.Name = "mteir_combobox"
        Me.mteir_combobox.Size = New System.Drawing.Size(61, 21)
        Me.mteir_combobox.TabIndex = 85
        '
        'sd_numberselect_combobox
        '
        Me.sd_numberselect_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sd_numberselect_combobox.FormattingEnabled = True
        Me.sd_numberselect_combobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.sd_numberselect_combobox.Location = New System.Drawing.Point(455, 69)
        Me.sd_numberselect_combobox.Name = "sd_numberselect_combobox"
        Me.sd_numberselect_combobox.Size = New System.Drawing.Size(45, 21)
        Me.sd_numberselect_combobox.TabIndex = 84
        '
        'Helmsmen_Label
        '
        Me.Helmsmen_Label.AutoSize = True
        Me.Helmsmen_Label.BackColor = System.Drawing.Color.Transparent
        Me.Helmsmen_Label.ForeColor = System.Drawing.Color.White
        Me.Helmsmen_Label.Location = New System.Drawing.Point(361, 465)
        Me.Helmsmen_Label.Name = "Helmsmen_Label"
        Me.Helmsmen_Label.Size = New System.Drawing.Size(62, 17)
        Me.Helmsmen_Label.TabIndex = 82
        Me.Helmsmen_Label.Text = "Helmsmen:"
        Me.Helmsmen_Label.UseCompatibleTextRendering = True
        '
        'helmsmen_textbox
        '
        Me.helmsmen_textbox.Location = New System.Drawing.Point(429, 462)
        Me.helmsmen_textbox.Name = "helmsmen_textbox"
        Me.helmsmen_textbox.Size = New System.Drawing.Size(100, 20)
        Me.helmsmen_textbox.TabIndex = 81
        '
        'tevrazon_check
        '
        Me.tevrazon_check.AutoSize = True
        Me.tevrazon_check.BackColor = System.Drawing.Color.Transparent
        Me.tevrazon_check.ForeColor = System.Drawing.Color.White
        Me.tevrazon_check.Location = New System.Drawing.Point(289, 270)
        Me.tevrazon_check.Name = "tevrazon_check"
        Me.tevrazon_check.Size = New System.Drawing.Size(122, 18)
        Me.tevrazon_check.TabIndex = 80
        Me.tevrazon_check.Text = "Tevrazon Gas Tank"
        Me.tevrazon_check.UseCompatibleTextRendering = True
        Me.tevrazon_check.UseVisualStyleBackColor = False
        '
        'xrp_fuel_check
        '
        Me.xrp_fuel_check.AutoSize = True
        Me.xrp_fuel_check.BackColor = System.Drawing.Color.Transparent
        Me.xrp_fuel_check.ForeColor = System.Drawing.Color.White
        Me.xrp_fuel_check.Location = New System.Drawing.Point(289, 247)
        Me.xrp_fuel_check.Name = "xrp_fuel_check"
        Me.xrp_fuel_check.Size = New System.Drawing.Size(102, 18)
        Me.xrp_fuel_check.TabIndex = 79
        Me.xrp_fuel_check.Text = "XRP Warp Fuel"
        Me.xrp_fuel_check.UseCompatibleTextRendering = True
        Me.xrp_fuel_check.UseVisualStyleBackColor = False
        '
        'grid_console_check
        '
        Me.grid_console_check.AutoSize = True
        Me.grid_console_check.BackColor = System.Drawing.Color.Transparent
        Me.grid_console_check.ForeColor = System.Drawing.Color.White
        Me.grid_console_check.Location = New System.Drawing.Point(289, 224)
        Me.grid_console_check.Name = "grid_console_check"
        Me.grid_console_check.Size = New System.Drawing.Size(89, 18)
        Me.grid_console_check.TabIndex = 78
        Me.grid_console_check.Text = "Grid Console"
        Me.grid_console_check.UseCompatibleTextRendering = True
        Me.grid_console_check.UseVisualStyleBackColor = False
        '
        'defense_calc_button
        '
        Me.defense_calc_button.BackColor = System.Drawing.Color.Transparent
        Me.defense_calc_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.defense_calc_button.Location = New System.Drawing.Point(557, 506)
        Me.defense_calc_button.Name = "defense_calc_button"
        Me.defense_calc_button.Size = New System.Drawing.Size(75, 23)
        Me.defense_calc_button.TabIndex = 77
        Me.defense_calc_button.Text = "Calculate"
        Me.defense_calc_button.UseCompatibleTextRendering = True
        Me.defense_calc_button.UseVisualStyleBackColor = False
        '
        'defense_textbox
        '
        Me.defense_textbox.Location = New System.Drawing.Point(624, 462)
        Me.defense_textbox.Name = "defense_textbox"
        Me.defense_textbox.Size = New System.Drawing.Size(114, 20)
        Me.defense_textbox.TabIndex = 76
        '
        'rw_reset_button
        '
        Me.rw_reset_button.BackColor = System.Drawing.Color.Transparent
        Me.rw_reset_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rw_reset_button.Location = New System.Drawing.Point(663, 506)
        Me.rw_reset_button.Name = "rw_reset_button"
        Me.rw_reset_button.Size = New System.Drawing.Size(75, 23)
        Me.rw_reset_button.TabIndex = 75
        Me.rw_reset_button.Text = "Clear/Reset"
        Me.rw_reset_button.UseCompatibleTextRendering = True
        Me.rw_reset_button.UseVisualStyleBackColor = False
        '
        'rd_numberselect_combobox
        '
        Me.rd_numberselect_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rd_numberselect_combobox.FormattingEnabled = True
        Me.rd_numberselect_combobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.rd_numberselect_combobox.Location = New System.Drawing.Point(229, 69)
        Me.rd_numberselect_combobox.Name = "rd_numberselect_combobox"
        Me.rd_numberselect_combobox.Size = New System.Drawing.Size(41, 21)
        Me.rd_numberselect_combobox.TabIndex = 74
        '
        'rd_add_button
        '
        Me.rd_add_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rd_add_button.Location = New System.Drawing.Point(148, 170)
        Me.rd_add_button.Name = "rd_add_button"
        Me.rd_add_button.Size = New System.Drawing.Size(75, 23)
        Me.rd_add_button.TabIndex = 73
        Me.rd_add_button.Text = "Add RD"
        Me.rd_add_button.UseCompatibleTextRendering = True
        Me.rd_add_button.UseVisualStyleBackColor = True
        '
        'installeddefenses_textbox
        '
        Me.installeddefenses_textbox.Location = New System.Drawing.Point(43, 224)
        Me.installeddefenses_textbox.Multiline = True
        Me.installeddefenses_textbox.Name = "installeddefenses_textbox"
        Me.installeddefenses_textbox.ReadOnly = True
        Me.installeddefenses_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.installeddefenses_textbox.Size = New System.Drawing.Size(240, 215)
        Me.installeddefenses_textbox.TabIndex = 72
        '
        'researched_label
        '
        Me.researched_label.AutoSize = True
        Me.researched_label.BackColor = System.Drawing.Color.Transparent
        Me.researched_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.researched_label.ForeColor = System.Drawing.Color.White
        Me.researched_label.Location = New System.Drawing.Point(43, 49)
        Me.researched_label.Name = "researched_label"
        Me.researched_label.Size = New System.Drawing.Size(124, 17)
        Me.researched_label.TabIndex = 71
        Me.researched_label.Text = "Researched Defenses:"
        Me.researched_label.UseCompatibleTextRendering = True
        '
        'rd_listbox
        '
        Me.rd_listbox.FormattingEnabled = True
        Me.rd_listbox.Items.AddRange(New Object() {"Autopilot Console", "Autopilot Console - Mk II", "Manuevering Thrusters", "Manuevering Thrusters - Mk II", "Manuevering Thrusters - Mk III", "Motion Compensator", "Motion Compensator - Mk II", "Motion Compensator - Mk III", "Inertial Dampener", "Inertial Dampener - Mk II", "Inertial Dampener - Mk III", "Spacial Thrusters", "Spacial Thrusters - Mk II", "Spacial Thrusters - Mk III", "Inertial Canceler", "Inertial Canceler - Mk II", "Inertial Canceler - Mk III", "Microwarp Nacelle", "Microwarp Nacelle - Mk II", "Microwarp Nacelle - Mk III", "Phase Shift Engine", "Phase Shift Engine - Mk II", "Phase Shift Engine - Mk III", "Quantum Overlay Engine", "Quantum Overlay Engine - Mk II", "Quantum Overlay Engine - Mk III", "Energy Nullifier", "Energy Nullifier - Mk II", "Energy Nullifier - Mk III", "Trans-Temporal Nacelle", "Trans-Temporal Nacelle - Mk II", "Trans-Temporal Nacelle - Mk III", "Exergonic Inverter", "Exergonic Inverter - Mk II", "Exergonic Inverter - Mk III", "Trans-Entropy Drive", "Trans-Entropy Drive - Mk II", "Trans-Entropy Drive - Mk III"})
        Me.rd_listbox.Location = New System.Drawing.Point(43, 69)
        Me.rd_listbox.Name = "rd_listbox"
        Me.rd_listbox.Size = New System.Drawing.Size(180, 95)
        Me.rd_listbox.TabIndex = 70
        '
        'Defense_Form
        '
        Me.AcceptButton = Me.defense_calc_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(763, 541)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.installed_label)
        Me.Controls.Add(Me.velox_label)
        Me.Controls.Add(Me.bm50_label)
        Me.Controls.Add(Me.sd_add_button)
        Me.Controls.Add(Me.velox_combobox)
        Me.Controls.Add(Me.bm50_combobox)
        Me.Controls.Add(Me.decoy_check)
        Me.Controls.Add(Me.sd_listbox)
        Me.Controls.Add(Me.mega_coil_label)
        Me.Controls.Add(Me.MegaCoil_ComboBox)
        Me.Controls.Add(Me.eluder_matrix_check)
        Me.Controls.Add(Me.special_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mteir_combobox)
        Me.Controls.Add(Me.sd_numberselect_combobox)
        Me.Controls.Add(Me.Helmsmen_Label)
        Me.Controls.Add(Me.helmsmen_textbox)
        Me.Controls.Add(Me.tevrazon_check)
        Me.Controls.Add(Me.xrp_fuel_check)
        Me.Controls.Add(Me.grid_console_check)
        Me.Controls.Add(Me.defense_calc_button)
        Me.Controls.Add(Me.defense_textbox)
        Me.Controls.Add(Me.rw_reset_button)
        Me.Controls.Add(Me.rd_numberselect_combobox)
        Me.Controls.Add(Me.rd_add_button)
        Me.Controls.Add(Me.installeddefenses_textbox)
        Me.Controls.Add(Me.researched_label)
        Me.Controls.Add(Me.rd_listbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Defense_Form"
        Me.Text = "Defense Strength Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseCombatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents installed_label As System.Windows.Forms.Label
    Friend WithEvents velox_label As System.Windows.Forms.Label
    Friend WithEvents bm50_label As System.Windows.Forms.Label
    Friend WithEvents sd_add_button As System.Windows.Forms.Button
    Friend WithEvents velox_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents bm50_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents decoy_check As System.Windows.Forms.CheckBox
    Friend WithEvents sd_listbox As System.Windows.Forms.ListBox
    Friend WithEvents mega_coil_label As System.Windows.Forms.Label
    Friend WithEvents MegaCoil_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents eluder_matrix_check As System.Windows.Forms.CheckBox
    Friend WithEvents special_label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mteir_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents sd_numberselect_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents Helmsmen_Label As System.Windows.Forms.Label
    Friend WithEvents helmsmen_textbox As System.Windows.Forms.TextBox
    Friend WithEvents tevrazon_check As System.Windows.Forms.CheckBox
    Friend WithEvents xrp_fuel_check As System.Windows.Forms.CheckBox
    Friend WithEvents grid_console_check As System.Windows.Forms.CheckBox
    Friend WithEvents defense_calc_button As System.Windows.Forms.Button
    Friend WithEvents defense_textbox As System.Windows.Forms.TextBox
    Friend WithEvents rw_reset_button As System.Windows.Forms.Button
    Friend WithEvents rd_numberselect_combobox As System.Windows.Forms.ComboBox
    Friend WithEvents rd_add_button As System.Windows.Forms.Button
    Friend WithEvents installeddefenses_textbox As System.Windows.Forms.TextBox
    Friend WithEvents researched_label As System.Windows.Forms.Label
    Friend WithEvents rd_listbox As System.Windows.Forms.ListBox
End Class
