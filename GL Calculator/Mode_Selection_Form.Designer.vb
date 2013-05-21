<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mode_Selection_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mode_Selection_Form))
        Me.attack_launch = New System.Windows.Forms.Button()
        Me.defense_launch = New System.Windows.Forms.Button()
        Me.invade_launch = New System.Windows.Forms.Button()
        Me.intro_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'attack_launch
        '
        Me.attack_launch.Location = New System.Drawing.Point(79, 130)
        Me.attack_launch.Name = "attack_launch"
        Me.attack_launch.Size = New System.Drawing.Size(157, 30)
        Me.attack_launch.TabIndex = 0
        Me.attack_launch.Text = "Attack Strength Calculator"
        Me.attack_launch.UseCompatibleTextRendering = True
        Me.attack_launch.UseVisualStyleBackColor = True
        '
        'defense_launch
        '
        Me.defense_launch.Location = New System.Drawing.Point(79, 200)
        Me.defense_launch.Name = "defense_launch"
        Me.defense_launch.Size = New System.Drawing.Size(157, 30)
        Me.defense_launch.TabIndex = 1
        Me.defense_launch.Text = "Defense Strength Calculator"
        Me.defense_launch.UseCompatibleTextRendering = True
        Me.defense_launch.UseVisualStyleBackColor = True
        '
        'invade_launch
        '
        Me.invade_launch.Location = New System.Drawing.Point(79, 270)
        Me.invade_launch.Name = "invade_launch"
        Me.invade_launch.Size = New System.Drawing.Size(157, 30)
        Me.invade_launch.TabIndex = 2
        Me.invade_launch.Text = "Invasion Chance Calculator"
        Me.invade_launch.UseCompatibleTextRendering = True
        Me.invade_launch.UseVisualStyleBackColor = True
        '
        'intro_label
        '
        Me.intro_label.AutoSize = True
        Me.intro_label.BackColor = System.Drawing.Color.Transparent
        Me.intro_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intro_label.ForeColor = System.Drawing.Color.White
        Me.intro_label.Location = New System.Drawing.Point(45, 27)
        Me.intro_label.Name = "intro_label"
        Me.intro_label.Size = New System.Drawing.Size(224, 17)
        Me.intro_label.TabIndex = 3
        Me.intro_label.Text = "Welcome to the Galaxy Legion Calculator."
        Me.intro_label.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please select one of the buttons below to"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "launch the calculator you desire to use."
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(177, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "by Konrad Wiley"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Mode_Selection_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(321, 397)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.intro_label)
        Me.Controls.Add(Me.invade_launch)
        Me.Controls.Add(Me.defense_launch)
        Me.Controls.Add(Me.attack_launch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mode_Selection_Form"
        Me.Text = "Mode Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents attack_launch As System.Windows.Forms.Button
    Friend WithEvents defense_launch As System.Windows.Forms.Button
    Friend WithEvents invade_launch As System.Windows.Forms.Button
    Friend WithEvents intro_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
