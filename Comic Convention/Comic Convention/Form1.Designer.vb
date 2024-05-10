<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpConventionType = New System.Windows.Forms.GroupBox()
        Me.radSuperheroExp = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.lblRegistrationCost = New System.Windows.Forms.Label()
        Me.txtRegistrationCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConventionType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.Image = Global.Comic_Convention.My.Resources.Resources.comic
        Me.picComic.Location = New System.Drawing.Point(-5, -5)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(484, 183)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("MS PGothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblHeading.Location = New System.Drawing.Point(29, 194)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(420, 29)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.BackColor = System.Drawing.Color.Transparent
        Me.lblGroupSize.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblGroupSize.Location = New System.Drawing.Point(114, 239)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(115, 20)
        Me.lblGroupSize.TabIndex = 3
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtGroupSize.Location = New System.Drawing.Point(235, 239)
        Me.txtGroupSize.MaxLength = 2
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(72, 24)
        Me.txtGroupSize.TabIndex = 1
        '
        'grpConventionType
        '
        Me.grpConventionType.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grpConventionType.Controls.Add(Me.radConvention)
        Me.grpConventionType.Controls.Add(Me.radAutographs)
        Me.grpConventionType.Controls.Add(Me.radSuperheroExp)
        Me.grpConventionType.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConventionType.ForeColor = System.Drawing.Color.OrangeRed
        Me.grpConventionType.Location = New System.Drawing.Point(92, 290)
        Me.grpConventionType.Name = "grpConventionType"
        Me.grpConventionType.Size = New System.Drawing.Size(295, 123)
        Me.grpConventionType.TabIndex = 5
        Me.grpConventionType.TabStop = False
        Me.grpConventionType.Text = "Select Badge Type:"
        '
        'radSuperheroExp
        '
        Me.radSuperheroExp.AutoSize = True
        Me.radSuperheroExp.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuperheroExp.Location = New System.Drawing.Point(26, 25)
        Me.radSuperheroExp.Name = "radSuperheroExp"
        Me.radSuperheroExp.Size = New System.Drawing.Size(267, 19)
        Me.radSuperheroExp.TabIndex = 0
        Me.radSuperheroExp.Text = "Convention + Superhero Experience"
        Me.radSuperheroExp.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Location = New System.Drawing.Point(26, 54)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(242, 23)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Checked = True
        Me.radConvention.Location = New System.Drawing.Point(26, 83)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(122, 23)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'lblRegistrationCost
        '
        Me.lblRegistrationCost.AutoSize = True
        Me.lblRegistrationCost.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistrationCost.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegistrationCost.Location = New System.Drawing.Point(52, 465)
        Me.lblRegistrationCost.Name = "lblRegistrationCost"
        Me.lblRegistrationCost.Size = New System.Drawing.Size(177, 20)
        Me.lblRegistrationCost.TabIndex = 6
        Me.lblRegistrationCost.Text = "Registration Cost:"
        '
        'txtRegistrationCost
        '
        Me.txtRegistrationCost.BackColor = System.Drawing.SystemColors.Control
        Me.txtRegistrationCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegistrationCost.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtRegistrationCost.Location = New System.Drawing.Point(235, 468)
        Me.txtRegistrationCost.MaxLength = 2
        Me.txtRegistrationCost.Name = "txtRegistrationCost"
        Me.txtRegistrationCost.Size = New System.Drawing.Size(72, 17)
        Me.txtRegistrationCost.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCalculate.Location = New System.Drawing.Point(55, 503)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 33)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnClear.Location = New System.Drawing.Point(197, 503)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnExit.Location = New System.Drawing.Point(339, 503)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 33)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 557)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtRegistrationCost)
        Me.Controls.Add(Me.lblRegistrationCost)
        Me.Controls.Add(Me.grpConventionType)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picComic)
        Me.Name = "frmComicConvention"
        Me.Text = "Comic Convention"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConventionType.ResumeLayout(False)
        Me.grpConventionType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpConventionType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperheroExp As RadioButton
    Friend WithEvents lblRegistrationCost As Label
    Friend WithEvents txtRegistrationCost As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
