<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoProduct
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
		Me.txtInfOmsch = New System.Windows.Forms.TextBox()
		Me.lblOmschrijving = New System.Windows.Forms.Label()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.txtInfPrijs = New System.Windows.Forms.TextBox()
		Me.txtInfSnelheid = New System.Windows.Forms.TextBox()
		Me.txtInfType = New System.Windows.Forms.TextBox()
		Me.txtInfNaam = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.picArtikel = New System.Windows.Forms.PictureBox()
		CType(Me.picArtikel, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtInfOmsch
		'
		Me.txtInfOmsch.Enabled = False
		Me.txtInfOmsch.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.txtInfOmsch.Location = New System.Drawing.Point(202, 352)
		Me.txtInfOmsch.Multiline = True
		Me.txtInfOmsch.Name = "txtInfOmsch"
		Me.txtInfOmsch.ReadOnly = True
		Me.txtInfOmsch.Size = New System.Drawing.Size(391, 96)
		Me.txtInfOmsch.TabIndex = 26
		Me.txtInfOmsch.Text = "€40.00"
		'
		'lblOmschrijving
		'
		Me.lblOmschrijving.AutoSize = True
		Me.lblOmschrijving.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.lblOmschrijving.Location = New System.Drawing.Point(16, 355)
		Me.lblOmschrijving.Name = "lblOmschrijving"
		Me.lblOmschrijving.Size = New System.Drawing.Size(136, 22)
		Me.lblOmschrijving.TabIndex = 25
		Me.lblOmschrijving.Text = "Omschrijving:"
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Red
		Me.Button4.Font = New System.Drawing.Font("Verdana", 20.8!)
		Me.Button4.ForeColor = System.Drawing.SystemColors.Control
		Me.Button4.Location = New System.Drawing.Point(662, 58)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(71, 57)
		Me.Button4.TabIndex = 24
		Me.Button4.Text = "X"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'txtInfPrijs
		'
		Me.txtInfPrijs.Enabled = False
		Me.txtInfPrijs.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.txtInfPrijs.Location = New System.Drawing.Point(202, 518)
		Me.txtInfPrijs.Multiline = True
		Me.txtInfPrijs.Name = "txtInfPrijs"
		Me.txtInfPrijs.ReadOnly = True
		Me.txtInfPrijs.Size = New System.Drawing.Size(391, 33)
		Me.txtInfPrijs.TabIndex = 23
		Me.txtInfPrijs.Text = "€40.00"
		'
		'txtInfSnelheid
		'
		Me.txtInfSnelheid.Enabled = False
		Me.txtInfSnelheid.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.txtInfSnelheid.Location = New System.Drawing.Point(202, 302)
		Me.txtInfSnelheid.Multiline = True
		Me.txtInfSnelheid.Name = "txtInfSnelheid"
		Me.txtInfSnelheid.ReadOnly = True
		Me.txtInfSnelheid.Size = New System.Drawing.Size(391, 33)
		Me.txtInfSnelheid.TabIndex = 22
		Me.txtInfSnelheid.Text = "2.80 Ghz"
		'
		'txtInfType
		'
		Me.txtInfType.AcceptsReturn = True
		Me.txtInfType.Enabled = False
		Me.txtInfType.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.txtInfType.Location = New System.Drawing.Point(202, 255)
		Me.txtInfType.Multiline = True
		Me.txtInfType.Name = "txtInfType"
		Me.txtInfType.ReadOnly = True
		Me.txtInfType.Size = New System.Drawing.Size(391, 33)
		Me.txtInfType.TabIndex = 21
		Me.txtInfType.Text = "Desktop processor"
		'
		'txtInfNaam
		'
		Me.txtInfNaam.Enabled = False
		Me.txtInfNaam.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.txtInfNaam.Location = New System.Drawing.Point(202, 208)
		Me.txtInfNaam.Multiline = True
		Me.txtInfNaam.Name = "txtInfNaam"
		Me.txtInfNaam.ReadOnly = True
		Me.txtInfNaam.Size = New System.Drawing.Size(391, 33)
		Me.txtInfNaam.TabIndex = 20
		Me.txtInfNaam.Text = "Intel i5 4440 CPU"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.Label4.Location = New System.Drawing.Point(7, 521)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(57, 22)
		Me.Label4.TabIndex = 19
		Me.Label4.Text = "Prijs:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.Label3.Location = New System.Drawing.Point(16, 305)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 22)
		Me.Label3.TabIndex = 18
		Me.Label3.Text = "Snelheid:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.Label2.Location = New System.Drawing.Point(16, 255)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 22)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Type:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 10.5!)
		Me.Label1.Location = New System.Drawing.Point(16, 211)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(135, 22)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Naam artikel:"
		'
		'picArtikel
		'
		Me.picArtikel.Location = New System.Drawing.Point(153, 58)
		Me.picArtikel.Name = "picArtikel"
		Me.picArtikel.Size = New System.Drawing.Size(229, 131)
		Me.picArtikel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picArtikel.TabIndex = 16
		Me.picArtikel.TabStop = False
		'
		'frmInfoProduct
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Teal
		Me.ClientSize = New System.Drawing.Size(741, 609)
		Me.Controls.Add(Me.txtInfOmsch)
		Me.Controls.Add(Me.lblOmschrijving)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.txtInfPrijs)
		Me.Controls.Add(Me.txtInfSnelheid)
		Me.Controls.Add(Me.txtInfType)
		Me.Controls.Add(Me.txtInfNaam)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.picArtikel)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmInfoProduct"
		Me.Text = "frmInfoProduct"
		CType(Me.picArtikel, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtInfOmsch As TextBox
	Friend WithEvents lblOmschrijving As Label
	Friend WithEvents Button4 As Button
	Friend WithEvents txtInfPrijs As TextBox
	Friend WithEvents txtInfSnelheid As TextBox
	Friend WithEvents txtInfType As TextBox
	Friend WithEvents txtInfNaam As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents picArtikel As PictureBox
	Friend WithEvents Label1 As Label
End Class
