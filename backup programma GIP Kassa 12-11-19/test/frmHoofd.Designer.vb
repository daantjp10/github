<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoofd
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tijd = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblTotaalTekst = New System.Windows.Forms.Label()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.btnKorting = New System.Windows.Forms.Button()
		Me.btnVerwijderen = New System.Windows.Forms.Button()
		Me.btnVoegToe = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblBedrag = New System.Windows.Forms.Label()
		Me.cboArtikels = New System.Windows.Forms.ComboBox()
		Me.btnInfo = New System.Windows.Forms.Button()
		Me.lstAssortiment = New System.Windows.Forms.ListBox()
		Me.picLaRo = New System.Windows.Forms.PictureBox()
		Me.picReken = New System.Windows.Forms.PictureBox()
		CType(Me.picLaRo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picReken, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tijd
		'
		Me.tijd.AutoSize = True
		Me.tijd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.8!)
		Me.tijd.Location = New System.Drawing.Point(799, 21)
		Me.tijd.Name = "tijd"
		Me.tijd.Size = New System.Drawing.Size(62, 39)
		Me.tijd.TabIndex = 28
		Me.tijd.Text = "tijd"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(960, 549)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(0, 29)
		Me.Label4.TabIndex = 27
		'
		'lblTotaalTekst
		'
		Me.lblTotaalTekst.AutoSize = True
		Me.lblTotaalTekst.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotaalTekst.Location = New System.Drawing.Point(811, 549)
		Me.lblTotaalTekst.Name = "lblTotaalTekst"
		Me.lblTotaalTekst.Size = New System.Drawing.Size(154, 29)
		Me.lblTotaalTekst.TabIndex = 26
		Me.lblTotaalTekst.Text = "Totaal prijs:"
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Red
		Me.Button4.Font = New System.Drawing.Font("Verdana", 20.8!)
		Me.Button4.ForeColor = System.Drawing.SystemColors.Control
		Me.Button4.Location = New System.Drawing.Point(974, 11)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(71, 57)
		Me.Button4.TabIndex = 25
		Me.Button4.Text = "X"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'btnKorting
		'
		Me.btnKorting.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnKorting.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnKorting.Location = New System.Drawing.Point(647, 378)
		Me.btnKorting.Name = "btnKorting"
		Me.btnKorting.Size = New System.Drawing.Size(122, 65)
		Me.btnKorting.TabIndex = 22
		Me.btnKorting.Text = "&Korting"
		Me.btnKorting.UseVisualStyleBackColor = False
		'
		'btnVerwijderen
		'
		Me.btnVerwijderen.BackColor = System.Drawing.Color.Red
		Me.btnVerwijderen.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnVerwijderen.Location = New System.Drawing.Point(303, 525)
		Me.btnVerwijderen.Name = "btnVerwijderen"
		Me.btnVerwijderen.Size = New System.Drawing.Size(206, 50)
		Me.btnVerwijderen.TabIndex = 21
		Me.btnVerwijderen.Text = "Verwijder artikel"
		Me.btnVerwijderen.UseVisualStyleBackColor = False
		'
		'btnVoegToe
		'
		Me.btnVoegToe.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnVoegToe.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnVoegToe.Location = New System.Drawing.Point(21, 525)
		Me.btnVoegToe.Name = "btnVoegToe"
		Me.btnVoegToe.Size = New System.Drawing.Size(206, 50)
		Me.btnVoegToe.TabIndex = 20
		Me.btnVoegToe.Text = "Voeg artikel toe"
		Me.btnVoegToe.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(35, 18)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(117, 29)
		Me.Label2.TabIndex = 19
		Me.Label2.Text = "Gekozen"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(362, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(187, 29)
		Me.Label1.TabIndex = 18
		Me.Label1.Text = "Kies uw artikel"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 1
		'
		'lblBedrag
		'
		Me.lblBedrag.AutoSize = True
		Me.lblBedrag.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBedrag.Location = New System.Drawing.Point(991, 549)
		Me.lblBedrag.Name = "lblBedrag"
		Me.lblBedrag.Size = New System.Drawing.Size(36, 29)
		Me.lblBedrag.TabIndex = 32
		Me.lblBedrag.Text = " 0"
		'
		'cboArtikels
		'
		Me.cboArtikels.FormattingEnabled = True
		Me.cboArtikels.Items.AddRange(New Object() {"S/FTP CAT8 kabel - 0.25 meter", "S/FTP CAT8 kabel - 0.5 meter", "S/FTP CAT8 kabel - 1 meter", "S/FTP CAT8 kabel - 2 meter", "S/FTP CAT8 kabel - 3 meter", "Netwerkkabel CAT 5e - U/UTP 0.5m", "Netwerkkabel CAT 5e - U/UTP 1m", "Netwerkkabel CAT 5e - U/UTP 1.5m", "Netwerkkabel CAT 5e - U/UTP 2m", "Netwerkkabel CAT 5e - U/UTP 5m", "Strontium Nitro Plus 64GB", "Strontium Nitro Plus 128GB", "Silicon Power Premium 4GB ", "Silicon Power Premium 8GB", "Silicon Power Premium 16GB", "Silicon Power Premium 32GB", "Silicon Power Elite 64GB", "Silicon Power Elite 128GB", "Silicon Power Elite 16GB", "Silicon Power Elite 32GB"})
		Me.cboArtikels.Location = New System.Drawing.Point(317, 61)
		Me.cboArtikels.Name = "cboArtikels"
		Me.cboArtikels.Size = New System.Drawing.Size(289, 24)
		Me.cboArtikels.TabIndex = 31
		'
		'btnInfo
		'
		Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnInfo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInfo.Location = New System.Drawing.Point(662, 37)
		Me.btnInfo.Name = "btnInfo"
		Me.btnInfo.Size = New System.Drawing.Size(80, 71)
		Me.btnInfo.TabIndex = 30
		Me.btnInfo.Text = "INFO?"
		Me.btnInfo.UseVisualStyleBackColor = False
		'
		'lstAssortiment
		'
		Me.lstAssortiment.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstAssortiment.FormattingEnabled = True
		Me.lstAssortiment.ItemHeight = 20
		Me.lstAssortiment.Items.AddRange(New Object() {""})
		Me.lstAssortiment.Location = New System.Drawing.Point(3, 61)
		Me.lstAssortiment.Name = "lstAssortiment"
		Me.lstAssortiment.Size = New System.Drawing.Size(308, 444)
		Me.lstAssortiment.TabIndex = 29
		'
		'picLaRo
		'
		Me.picLaRo.Image = Global.test.My.Resources.Resources.laro1
		Me.picLaRo.Location = New System.Drawing.Point(772, 204)
		Me.picLaRo.Name = "picLaRo"
		Me.picLaRo.Size = New System.Drawing.Size(289, 123)
		Me.picLaRo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picLaRo.TabIndex = 24
		Me.picLaRo.TabStop = False
		'
		'picReken
		'
		Me.picReken.Image = Global.test.My.Resources.Resources.icon1
		Me.picReken.Location = New System.Drawing.Point(647, 449)
		Me.picReken.Name = "picReken"
		Me.picReken.Size = New System.Drawing.Size(145, 94)
		Me.picReken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picReken.TabIndex = 23
		Me.picReken.TabStop = False
		'
		'frmHoofd
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Teal
		Me.ClientSize = New System.Drawing.Size(1048, 588)
		Me.Controls.Add(Me.tijd)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.lblTotaalTekst)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.picLaRo)
		Me.Controls.Add(Me.picReken)
		Me.Controls.Add(Me.btnKorting)
		Me.Controls.Add(Me.btnVerwijderen)
		Me.Controls.Add(Me.btnVoegToe)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblBedrag)
		Me.Controls.Add(Me.cboArtikels)
		Me.Controls.Add(Me.btnInfo)
		Me.Controls.Add(Me.lstAssortiment)
		Me.Name = "frmHoofd"
		Me.Text = "Form1"
		CType(Me.picLaRo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picReken, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tijd As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents lblTotaalTekst As Label
	Friend WithEvents Button4 As Button
	Friend WithEvents picLaRo As PictureBox
	Friend WithEvents picReken As PictureBox
	Friend WithEvents btnKorting As Button
	Friend WithEvents btnVerwijderen As Button
	Friend WithEvents btnVoegToe As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents lblBedrag As Label
	Friend WithEvents cboArtikels As ComboBox
	Friend WithEvents btnInfo As Button
	Friend WithEvents lstAssortiment As ListBox
End Class
