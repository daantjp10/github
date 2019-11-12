<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBootscreen
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
		Me.lblProcent = New System.Windows.Forms.Label()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.timerBoot = New System.Windows.Forms.Timer(Me.components)
		Me.btnOpen = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblProcent
		'
		Me.lblProcent.AutoSize = True
		Me.lblProcent.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.lblProcent.Location = New System.Drawing.Point(216, 297)
		Me.lblProcent.Name = "lblProcent"
		Me.lblProcent.Size = New System.Drawing.Size(0, 22)
		Me.lblProcent.TabIndex = 20
		'
		'ProgressBar1
		'
		Me.ProgressBar1.ForeColor = System.Drawing.Color.White
		Me.ProgressBar1.Location = New System.Drawing.Point(23, 333)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(419, 23)
		Me.ProgressBar1.TabIndex = 19
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Red
		Me.Button4.Font = New System.Drawing.Font("Verdana", 20.8!)
		Me.Button4.ForeColor = System.Drawing.SystemColors.Control
		Me.Button4.Location = New System.Drawing.Point(455, 1)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(71, 57)
		Me.Button4.TabIndex = 18
		Me.Button4.Text = "X"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'btnOpen
		'
		Me.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.btnOpen.BackColor = System.Drawing.Color.Lime
		Me.btnOpen.ForeColor = System.Drawing.Color.Black
		Me.btnOpen.Location = New System.Drawing.Point(39, 362)
		Me.btnOpen.Name = "btnOpen"
		Me.btnOpen.Size = New System.Drawing.Size(391, 63)
		Me.btnOpen.TabIndex = 21
		Me.btnOpen.Text = "&Klaar! Klik hier"
		Me.btnOpen.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.test.My.Resources.Resources.laro
		Me.PictureBox1.Location = New System.Drawing.Point(13, 73)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(484, 179)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 17
		Me.PictureBox1.TabStop = False
		'
		'frmBootscreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Teal
		Me.ClientSize = New System.Drawing.Size(539, 426)
		Me.Controls.Add(Me.lblProcent)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnOpen)
		Me.Name = "frmBootscreen"
		Me.Text = "bootscreen"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblProcent As Label
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents Button4 As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents timerBoot As Timer
	Friend WithEvents btnOpen As Button
End Class
