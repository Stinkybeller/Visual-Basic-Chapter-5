<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanetaryWeight
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
        Me.picPlanets = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblEnterWeight = New System.Windows.Forms.Label()
        Me.txtEnterWeight = New System.Windows.Forms.TextBox()
        Me.grpConvertWeight = New System.Windows.Forms.GroupBox()
        Me.radConvertToMars = New System.Windows.Forms.RadioButton()
        Me.radConvertToVenus = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFinalWeight = New System.Windows.Forms.Label()
        CType(Me.picPlanets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConvertWeight.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlanets
        '
        Me.picPlanets.Image = Global.Planetary_Weight.My.Resources.Resources.planets
        Me.picPlanets.Location = New System.Drawing.Point(379, -1)
        Me.picPlanets.Name = "picPlanets"
        Me.picPlanets.Size = New System.Drawing.Size(393, 417)
        Me.picPlanets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlanets.TabIndex = 0
        Me.picPlanets.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHeading.Location = New System.Drawing.Point(93, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(195, 29)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Venus or Mars?"
        '
        'lblEnterWeight
        '
        Me.lblEnterWeight.AutoSize = True
        Me.lblEnterWeight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEnterWeight.Location = New System.Drawing.Point(50, 65)
        Me.lblEnterWeight.Name = "lblEnterWeight"
        Me.lblEnterWeight.Size = New System.Drawing.Size(143, 19)
        Me.lblEnterWeight.TabIndex = 2
        Me.lblEnterWeight.Text = "Enter Weight (lbs):"
        '
        'txtEnterWeight
        '
        Me.txtEnterWeight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterWeight.Location = New System.Drawing.Point(199, 65)
        Me.txtEnterWeight.MaxLength = 6
        Me.txtEnterWeight.Name = "txtEnterWeight"
        Me.txtEnterWeight.Size = New System.Drawing.Size(75, 22)
        Me.txtEnterWeight.TabIndex = 3
        '
        'grpConvertWeight
        '
        Me.grpConvertWeight.BackColor = System.Drawing.Color.White
        Me.grpConvertWeight.Controls.Add(Me.radConvertToMars)
        Me.grpConvertWeight.Controls.Add(Me.radConvertToVenus)
        Me.grpConvertWeight.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvertWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpConvertWeight.Location = New System.Drawing.Point(64, 117)
        Me.grpConvertWeight.Name = "grpConvertWeight"
        Me.grpConvertWeight.Size = New System.Drawing.Size(237, 111)
        Me.grpConvertWeight.TabIndex = 4
        Me.grpConvertWeight.TabStop = False
        Me.grpConvertWeight.Text = "Convert Weight:"
        '
        'radConvertToMars
        '
        Me.radConvertToMars.AutoSize = True
        Me.radConvertToMars.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvertToMars.Location = New System.Drawing.Point(6, 70)
        Me.radConvertToMars.Name = "radConvertToMars"
        Me.radConvertToMars.Size = New System.Drawing.Size(193, 23)
        Me.radConvertToMars.TabIndex = 1
        Me.radConvertToMars.TabStop = True
        Me.radConvertToMars.Text = "Convert to Mars Weight"
        Me.radConvertToMars.UseVisualStyleBackColor = True
        '
        'radConvertToVenus
        '
        Me.radConvertToVenus.AutoSize = True
        Me.radConvertToVenus.Checked = True
        Me.radConvertToVenus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvertToVenus.Location = New System.Drawing.Point(6, 29)
        Me.radConvertToVenus.Name = "radConvertToVenus"
        Me.radConvertToVenus.Size = New System.Drawing.Size(203, 23)
        Me.radConvertToVenus.TabIndex = 0
        Me.radConvertToVenus.TabStop = True
        Me.radConvertToVenus.Text = "Convert to Venus Weight"
        Me.radConvertToVenus.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(64, 258)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(108, 23)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(193, 258)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(143, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFinalWeight
        '
        Me.lblFinalWeight.AutoSize = True
        Me.lblFinalWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFinalWeight.Location = New System.Drawing.Point(51, 318)
        Me.lblFinalWeight.Name = "lblFinalWeight"
        Me.lblFinalWeight.Size = New System.Drawing.Size(0, 16)
        Me.lblFinalWeight.TabIndex = 8
        Me.lblFinalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinalWeight.UseMnemonic = False
        '
        'frmPlanetaryWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(737, 410)
        Me.Controls.Add(Me.lblFinalWeight)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grpConvertWeight)
        Me.Controls.Add(Me.txtEnterWeight)
        Me.Controls.Add(Me.lblEnterWeight)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picPlanets)
        Me.Name = "frmPlanetaryWeight"
        Me.Text = "Planetary Weight"
        CType(Me.picPlanets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConvertWeight.ResumeLayout(False)
        Me.grpConvertWeight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlanets As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblEnterWeight As Label
    Friend WithEvents txtEnterWeight As TextBox
    Friend WithEvents grpConvertWeight As GroupBox
    Friend WithEvents radConvertToMars As RadioButton
    Friend WithEvents radConvertToVenus As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFinalWeight As Label
End Class
