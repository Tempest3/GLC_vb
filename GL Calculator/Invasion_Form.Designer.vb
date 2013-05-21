<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invasion_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invasion_Form))
        Me.calculate_button = New System.Windows.Forms.Button()
        Me.multi_form_label = New System.Windows.Forms.Label()
        Me.receive_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.invasion_strength = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.planetary_defense = New System.Windows.Forms.TextBox()
        Me.planetary_attack = New System.Windows.Forms.TextBox()
        Me.invade_chance = New System.Windows.Forms.TextBox()
        Me.planetary_special = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculate_button
        '
        Me.calculate_button.Location = New System.Drawing.Point(27, 275)
        Me.calculate_button.Name = "calculate_button"
        Me.calculate_button.Size = New System.Drawing.Size(85, 31)
        Me.calculate_button.TabIndex = 6
        Me.calculate_button.Text = "Calculate"
        Me.calculate_button.UseCompatibleTextRendering = True
        Me.calculate_button.UseVisualStyleBackColor = True
        '
        'multi_form_label
        '
        Me.multi_form_label.AutoSize = True
        Me.multi_form_label.BackColor = System.Drawing.Color.Transparent
        Me.multi_form_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multi_form_label.ForeColor = System.Drawing.Color.White
        Me.multi_form_label.Location = New System.Drawing.Point(27, 79)
        Me.multi_form_label.Name = "multi_form_label"
        Me.multi_form_label.Size = New System.Drawing.Size(172, 17)
        Me.multi_form_label.TabIndex = 1
        Me.multi_form_label.Text = "Use Attack Calculator's amount:"
        Me.multi_form_label.UseCompatibleTextRendering = True
        '
        'receive_button
        '
        Me.receive_button.Location = New System.Drawing.Point(231, 74)
        Me.receive_button.Name = "receive_button"
        Me.receive_button.Size = New System.Drawing.Size(66, 23)
        Me.receive_button.TabIndex = 1
        Me.receive_button.Text = "Receive"
        Me.receive_button.UseCompatibleTextRendering = True
        Me.receive_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Either calculate your attack on the Attack Calculator"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "to autofill the textbox or enter it manually"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'invasion_strength
        '
        Me.invasion_strength.Location = New System.Drawing.Point(171, 109)
        Me.invasion_strength.Name = "invasion_strength"
        Me.invasion_strength.Size = New System.Drawing.Size(126, 20)
        Me.invasion_strength.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "...or type in manually:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'planetary_defense
        '
        Me.planetary_defense.Location = New System.Drawing.Point(197, 158)
        Me.planetary_defense.Name = "planetary_defense"
        Me.planetary_defense.Size = New System.Drawing.Size(100, 20)
        Me.planetary_defense.TabIndex = 3
        '
        'planetary_attack
        '
        Me.planetary_attack.Location = New System.Drawing.Point(197, 184)
        Me.planetary_attack.Name = "planetary_attack"
        Me.planetary_attack.Size = New System.Drawing.Size(100, 20)
        Me.planetary_attack.TabIndex = 4
        '
        'invade_chance
        '
        Me.invade_chance.Location = New System.Drawing.Point(197, 281)
        Me.invade_chance.Name = "invade_chance"
        Me.invade_chance.ReadOnly = True
        Me.invade_chance.Size = New System.Drawing.Size(100, 20)
        Me.invade_chance.TabIndex = 7
        '
        'planetary_special
        '
        Me.planetary_special.Location = New System.Drawing.Point(197, 210)
        Me.planetary_special.Name = "planetary_special"
        Me.planetary_special.Size = New System.Drawing.Size(100, 20)
        Me.planetary_special.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total planetary defense:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total planetary attack:"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Planetary ""Invasion Defense:"""
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(143, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Calculated Invasion Chance:"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Invasion_Form
        '
        Me.AcceptButton = Me.calculate_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(365, 339)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.planetary_special)
        Me.Controls.Add(Me.invade_chance)
        Me.Controls.Add(Me.planetary_attack)
        Me.Controls.Add(Me.planetary_defense)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.invasion_strength)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.receive_button)
        Me.Controls.Add(Me.multi_form_label)
        Me.Controls.Add(Me.calculate_button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Invasion_Form"
        Me.Text = "Invasion Chance Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculate_button As System.Windows.Forms.Button
    Friend WithEvents multi_form_label As System.Windows.Forms.Label
    Friend WithEvents receive_button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents invasion_strength As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents planetary_defense As System.Windows.Forms.TextBox
    Friend WithEvents planetary_attack As System.Windows.Forms.TextBox
    Friend WithEvents invade_chance As System.Windows.Forms.TextBox
    Friend WithEvents planetary_special As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
