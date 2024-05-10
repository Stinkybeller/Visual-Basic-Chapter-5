<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckingCostCalculator
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
        Me.lblSquareFootage = New System.Windows.Forms.Label()
        Me.txtSquareFootage = New System.Windows.Forms.TextBox()
        Me.grpDeckType = New System.Windows.Forms.GroupBox()
        Me.radComposite = New System.Windows.Forms.RadioButton()
        Me.radRedwood = New System.Windows.Forms.RadioButton()
        Me.radLumber = New System.Windows.Forms.RadioButton()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.txtCostEstimate = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.grpDeckType.SuspendLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblHeading.Location = New System.Drawing.Point(31, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(304, 29)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Decking Cost Calculator"
        '
        'lblSquareFootage
        '
        Me.lblSquareFootage.AutoSize = True
        Me.lblSquareFootage.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareFootage.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblSquareFootage.Location = New System.Drawing.Point(33, 75)
        Me.lblSquareFootage.Name = "lblSquareFootage"
        Me.lblSquareFootage.Size = New System.Drawing.Size(162, 23)
        Me.lblSquareFootage.TabIndex = 1
        Me.lblSquareFootage.Text = "Square Footage:"
        '
        'txtSquareFootage
        '
        Me.txtSquareFootage.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSquareFootage.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.txtSquareFootage.Location = New System.Drawing.Point(202, 77)
        Me.txtSquareFootage.Name = "txtSquareFootage"
        Me.txtSquareFootage.Size = New System.Drawing.Size(46, 26)
        Me.txtSquareFootage.TabIndex = 2
        '
        'grpDeckType
        '
        Me.grpDeckType.BackColor = System.Drawing.Color.FloralWhite
        Me.grpDeckType.Controls.Add(Me.radComposite)
        Me.grpDeckType.Controls.Add(Me.radRedwood)
        Me.grpDeckType.Controls.Add(Me.radLumber)
        Me.grpDeckType.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeckType.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.grpDeckType.Location = New System.Drawing.Point(37, 135)
        Me.grpDeckType.Name = "grpDeckType"
        Me.grpDeckType.Size = New System.Drawing.Size(235, 108)
        Me.grpDeckType.TabIndex = 3
        Me.grpDeckType.TabStop = False
        Me.grpDeckType.Text = "Decking Type:"
        '
        'radComposite
        '
        Me.radComposite.AutoSize = True
        Me.radComposite.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radComposite.Location = New System.Drawing.Point(34, 78)
        Me.radComposite.Name = "radComposite"
        Me.radComposite.Size = New System.Drawing.Size(103, 21)
        Me.radComposite.TabIndex = 2
        Me.radComposite.Text = "Composite"
        Me.radComposite.UseVisualStyleBackColor = True
        '
        'radRedwood
        '
        Me.radRedwood.AutoSize = True
        Me.radRedwood.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRedwood.Location = New System.Drawing.Point(34, 51)
        Me.radRedwood.Name = "radRedwood"
        Me.radRedwood.Size = New System.Drawing.Size(92, 21)
        Me.radRedwood.TabIndex = 1
        Me.radRedwood.Text = "Redwood"
        Me.radRedwood.UseVisualStyleBackColor = True
        '
        'radLumber
        '
        Me.radLumber.AutoSize = True
        Me.radLumber.Checked = True
        Me.radLumber.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLumber.Location = New System.Drawing.Point(34, 24)
        Me.radLumber.Name = "radLumber"
        Me.radLumber.Size = New System.Drawing.Size(174, 20)
        Me.radLumber.TabIndex = 0
        Me.radLumber.TabStop = True
        Me.radLumber.Text = "Pressure-Treated Lumber"
        Me.radLumber.UseVisualStyleBackColor = True
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEstimate.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblCostEstimate.Location = New System.Drawing.Point(33, 271)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(143, 23)
        Me.lblCostEstimate.TabIndex = 4
        Me.lblCostEstimate.Text = "Cost Estimate"
        '
        'txtCostEstimate
        '
        Me.txtCostEstimate.BackColor = System.Drawing.SystemColors.Control
        Me.txtCostEstimate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostEstimate.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostEstimate.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.txtCostEstimate.Location = New System.Drawing.Point(182, 275)
        Me.txtCostEstimate.Name = "txtCostEstimate"
        Me.txtCostEstimate.Size = New System.Drawing.Size(46, 19)
        Me.txtCostEstimate.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FloralWhite
        Me.btnCalculate.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCalculate.Location = New System.Drawing.Point(25, 325)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(78, 35)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FloralWhite
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnExit.Location = New System.Drawing.Point(129, 325)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 35)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FloralWhite
        Me.btnClear.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnClear.Location = New System.Drawing.Point(235, 325)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 35)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picDeck
        '
        Me.picDeck.Image = Global.Decking_Cost_Calculator.My.Resources.Resources.deck1
        Me.picDeck.Location = New System.Drawing.Point(353, 0)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(322, 406)
        Me.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeck.TabIndex = 9
        Me.picDeck.TabStop = False
        '
        'frmDeckingCostCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 403)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picDeck)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCostEstimate)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.grpDeckType)
        Me.Controls.Add(Me.txtSquareFootage)
        Me.Controls.Add(Me.lblSquareFootage)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmDeckingCostCalculator"
        Me.grpDeckType.ResumeLayout(False)
        Me.grpDeckType.PerformLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSquareFootage As Label
    Friend WithEvents txtSquareFootage As TextBox
    Friend WithEvents grpDeckType As GroupBox
    Friend WithEvents lblCostEstimate As Label
    Friend WithEvents txtCostEstimate As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents picDeck As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents radComposite As RadioButton
    Friend WithEvents radRedwood As RadioButton
    Friend WithEvents radLumber As RadioButton
End Class
