<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildingPlansConversion
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfInches = New System.Windows.Forms.Label()
        Me.grpConversionType = New System.Windows.Forms.GroupBox()
        Me.radMetricToImperial = New System.Windows.Forms.RadioButton()
        Me.radImperialToMetric = New System.Windows.Forms.RadioButton()
        Me.lblConvertedNumber = New System.Windows.Forms.Label()
        Me.txtNumberOfInches = New System.Windows.Forms.TextBox()
        Me.txtConvertedNumber = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblInOrM = New System.Windows.Forms.Label()
        Me.grpConversionType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.LightCyan
        Me.lblHeading.Location = New System.Drawing.Point(79, 30)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(474, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Building Plans Conversion"
        '
        'lblNumberOfInches
        '
        Me.lblNumberOfInches.AutoSize = True
        Me.lblNumberOfInches.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfInches.ForeColor = System.Drawing.Color.LightCyan
        Me.lblNumberOfInches.Location = New System.Drawing.Point(121, 85)
        Me.lblNumberOfInches.Name = "lblNumberOfInches"
        Me.lblNumberOfInches.Size = New System.Drawing.Size(290, 25)
        Me.lblNumberOfInches.TabIndex = 1
        Me.lblNumberOfInches.Text = "Number of Inches/Meters:"
        '
        'grpConversionType
        '
        Me.grpConversionType.Controls.Add(Me.radMetricToImperial)
        Me.grpConversionType.Controls.Add(Me.radImperialToMetric)
        Me.grpConversionType.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversionType.ForeColor = System.Drawing.Color.LightCyan
        Me.grpConversionType.Location = New System.Drawing.Point(86, 143)
        Me.grpConversionType.Name = "grpConversionType"
        Me.grpConversionType.Size = New System.Drawing.Size(292, 146)
        Me.grpConversionType.TabIndex = 3
        Me.grpConversionType.TabStop = False
        Me.grpConversionType.Text = "Conversion Type:"
        '
        'radMetricToImperial
        '
        Me.radMetricToImperial.AutoSize = True
        Me.radMetricToImperial.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMetricToImperial.Location = New System.Drawing.Point(40, 77)
        Me.radMetricToImperial.Name = "radMetricToImperial"
        Me.radMetricToImperial.Size = New System.Drawing.Size(219, 29)
        Me.radMetricToImperial.TabIndex = 1
        Me.radMetricToImperial.Text = "Metric to Imperial"
        Me.radMetricToImperial.UseVisualStyleBackColor = True
        '
        'radImperialToMetric
        '
        Me.radImperialToMetric.AutoSize = True
        Me.radImperialToMetric.BackColor = System.Drawing.SystemColors.Highlight
        Me.radImperialToMetric.Checked = True
        Me.radImperialToMetric.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radImperialToMetric.Location = New System.Drawing.Point(40, 42)
        Me.radImperialToMetric.Name = "radImperialToMetric"
        Me.radImperialToMetric.Size = New System.Drawing.Size(219, 29)
        Me.radImperialToMetric.TabIndex = 0
        Me.radImperialToMetric.TabStop = True
        Me.radImperialToMetric.Text = "Imperial to Metric"
        Me.radImperialToMetric.UseVisualStyleBackColor = False
        '
        'lblConvertedNumber
        '
        Me.lblConvertedNumber.AutoSize = True
        Me.lblConvertedNumber.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedNumber.ForeColor = System.Drawing.Color.LightCyan
        Me.lblConvertedNumber.Location = New System.Drawing.Point(109, 310)
        Me.lblConvertedNumber.Name = "lblConvertedNumber"
        Me.lblConvertedNumber.Size = New System.Drawing.Size(302, 35)
        Me.lblConvertedNumber.TabIndex = 4
        Me.lblConvertedNumber.Text = "Converted Number:"
        '
        'txtNumberOfInches
        '
        Me.txtNumberOfInches.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfInches.Location = New System.Drawing.Point(417, 84)
        Me.txtNumberOfInches.MaxLength = 10
        Me.txtNumberOfInches.Name = "txtNumberOfInches"
        Me.txtNumberOfInches.Size = New System.Drawing.Size(100, 30)
        Me.txtNumberOfInches.TabIndex = 0
        '
        'txtConvertedNumber
        '
        Me.txtConvertedNumber.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtConvertedNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConvertedNumber.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvertedNumber.ForeColor = System.Drawing.Color.LightCyan
        Me.txtConvertedNumber.Location = New System.Drawing.Point(417, 322)
        Me.txtConvertedNumber.Name = "txtConvertedNumber"
        Me.txtConvertedNumber.Size = New System.Drawing.Size(87, 23)
        Me.txtConvertedNumber.TabIndex = 6
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnConvert.Location = New System.Drawing.Point(451, 171)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(102, 43)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.Location = New System.Drawing.Point(451, 233)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 43)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblInOrM
        '
        Me.lblInOrM.AutoSize = True
        Me.lblInOrM.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOrM.ForeColor = System.Drawing.Color.LightCyan
        Me.lblInOrM.Location = New System.Drawing.Point(523, 320)
        Me.lblInOrM.Name = "lblInOrM"
        Me.lblInOrM.Size = New System.Drawing.Size(67, 25)
        Me.lblInOrM.TabIndex = 9
        Me.lblInOrM.Text = "Units"
        '
        'frmBuildingPlansConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(633, 383)
        Me.Controls.Add(Me.lblInOrM)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtConvertedNumber)
        Me.Controls.Add(Me.txtNumberOfInches)
        Me.Controls.Add(Me.lblConvertedNumber)
        Me.Controls.Add(Me.grpConversionType)
        Me.Controls.Add(Me.lblNumberOfInches)
        Me.Controls.Add(Me.lblHeading)
        Me.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Name = "frmBuildingPlansConversion"
        Me.Text = "Building Plans Conversion"
        Me.grpConversionType.ResumeLayout(False)
        Me.grpConversionType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumberOfInches As Label
    Friend WithEvents grpConversionType As GroupBox
    Friend WithEvents radMetricToImperial As RadioButton
    Friend WithEvents radImperialToMetric As RadioButton
    Friend WithEvents lblConvertedNumber As Label
    Friend WithEvents txtNumberOfInches As TextBox
    Friend WithEvents txtConvertedNumber As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblInOrM As Label
End Class
