<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartyPlatters
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
        Me.txtLoyaltyPoints = New System.Windows.Forms.TextBox()
        Me.lblLoyaltyPoints = New System.Windows.Forms.Label()
        Me.grpPayOptions = New System.Windows.Forms.GroupBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radMeatPlatter = New System.Windows.Forms.RadioButton()
        Me.radShrimpPlatter = New System.Windows.Forms.RadioButton()
        Me.radSushiPlatter = New System.Windows.Forms.RadioButton()
        Me.radFruitPlatter = New System.Windows.Forms.RadioButton()
        Me.radRiceBeans = New System.Windows.Forms.RadioButton()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picMeat = New System.Windows.Forms.PictureBox()
        Me.picShrimp = New System.Windows.Forms.PictureBox()
        Me.picSushi = New System.Windows.Forms.PictureBox()
        Me.picFruit = New System.Windows.Forms.PictureBox()
        Me.picBean = New System.Windows.Forms.PictureBox()
        Me.lblNoDiscount = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCostOutput = New System.Windows.Forms.Label()
        Me.txtCostOutput = New System.Windows.Forms.TextBox()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.lblPrice3 = New System.Windows.Forms.Label()
        Me.lblPrice4 = New System.Windows.Forms.Label()
        Me.lblPrice5 = New System.Windows.Forms.Label()
        Me.grpPayOptions.SuspendLayout()
        CType(Me.picMeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShrimp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSushi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLoyaltyPoints
        '
        Me.txtLoyaltyPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoyaltyPoints.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyaltyPoints.Location = New System.Drawing.Point(642, 309)
        Me.txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        Me.txtLoyaltyPoints.Size = New System.Drawing.Size(100, 26)
        Me.txtLoyaltyPoints.TabIndex = 30
        '
        'lblLoyaltyPoints
        '
        Me.lblLoyaltyPoints.AutoSize = True
        Me.lblLoyaltyPoints.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyaltyPoints.Location = New System.Drawing.Point(430, 312)
        Me.lblLoyaltyPoints.Name = "lblLoyaltyPoints"
        Me.lblLoyaltyPoints.Size = New System.Drawing.Size(206, 23)
        Me.lblLoyaltyPoints.TabIndex = 29
        Me.lblLoyaltyPoints.Text = "Enter Loyalty Points:"
        '
        'grpPayOptions
        '
        Me.grpPayOptions.Controls.Add(Me.radPickup)
        Me.grpPayOptions.Controls.Add(Me.radPrePay)
        Me.grpPayOptions.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPayOptions.Location = New System.Drawing.Point(467, 132)
        Me.grpPayOptions.Name = "grpPayOptions"
        Me.grpPayOptions.Size = New System.Drawing.Size(222, 111)
        Me.grpPayOptions.TabIndex = 28
        Me.grpPayOptions.TabStop = False
        Me.grpPayOptions.Text = "Type of Pay:"
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickup.Location = New System.Drawing.Point(16, 60)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(198, 35)
        Me.radPickup.TabIndex = 15
        Me.radPickup.Text = "Pay at pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Checked = True
        Me.radPrePay.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(16, 19)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(127, 35)
        Me.radPrePay.TabIndex = 14
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radMeatPlatter
        '
        Me.radMeatPlatter.AutoSize = True
        Me.radMeatPlatter.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMeatPlatter.Location = New System.Drawing.Point(24, 300)
        Me.radMeatPlatter.Name = "radMeatPlatter"
        Me.radMeatPlatter.Size = New System.Drawing.Size(179, 35)
        Me.radMeatPlatter.TabIndex = 26
        Me.radMeatPlatter.Text = "Meat Platter"
        Me.radMeatPlatter.UseVisualStyleBackColor = True
        '
        'radShrimpPlatter
        '
        Me.radShrimpPlatter.AutoSize = True
        Me.radShrimpPlatter.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radShrimpPlatter.Location = New System.Drawing.Point(24, 370)
        Me.radShrimpPlatter.Name = "radShrimpPlatter"
        Me.radShrimpPlatter.Size = New System.Drawing.Size(206, 35)
        Me.radShrimpPlatter.TabIndex = 24
        Me.radShrimpPlatter.Text = "Shrimp Platter"
        Me.radShrimpPlatter.UseVisualStyleBackColor = True
        '
        'radSushiPlatter
        '
        Me.radSushiPlatter.AutoSize = True
        Me.radSushiPlatter.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSushiPlatter.Location = New System.Drawing.Point(24, 440)
        Me.radSushiPlatter.Name = "radSushiPlatter"
        Me.radSushiPlatter.Size = New System.Drawing.Size(182, 35)
        Me.radSushiPlatter.TabIndex = 22
        Me.radSushiPlatter.Text = "Sushi Platter"
        Me.radSushiPlatter.UseVisualStyleBackColor = True
        '
        'radFruitPlatter
        '
        Me.radFruitPlatter.AutoSize = True
        Me.radFruitPlatter.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFruitPlatter.Location = New System.Drawing.Point(24, 230)
        Me.radFruitPlatter.Name = "radFruitPlatter"
        Me.radFruitPlatter.Size = New System.Drawing.Size(175, 35)
        Me.radFruitPlatter.TabIndex = 20
        Me.radFruitPlatter.Text = "Fruit Platter"
        Me.radFruitPlatter.UseVisualStyleBackColor = True
        '
        'radRiceBeans
        '
        Me.radRiceBeans.AutoSize = True
        Me.radRiceBeans.Checked = True
        Me.radRiceBeans.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRiceBeans.Location = New System.Drawing.Point(24, 160)
        Me.radRiceBeans.Name = "radRiceBeans"
        Me.radRiceBeans.Size = New System.Drawing.Size(217, 35)
        Me.radRiceBeans.TabIndex = 18
        Me.radRiceBeans.TabStop = True
        Me.radRiceBeans.Text = "Beans and Rice"
        Me.radRiceBeans.UseVisualStyleBackColor = True
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(18, 97)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(128, 32)
        Me.lblOptions.TabIndex = 17
        Me.lblOptions.Text = "Options:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(297, 35)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(233, 39)
        Me.lblHeading.TabIndex = 16
        Me.lblHeading.Text = "Party Platters"
        '
        'picMeat
        '
        Me.picMeat.Image = Global.Party_Platters2.My.Resources.Resources.antipasto_catering_platter_with_bacon_jerky_salami_cheese_grapes_wooden_table_scaled
        Me.picMeat.Location = New System.Drawing.Point(238, 271)
        Me.picMeat.Name = "picMeat"
        Me.picMeat.Size = New System.Drawing.Size(65, 64)
        Me.picMeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMeat.TabIndex = 27
        Me.picMeat.TabStop = False
        '
        'picShrimp
        '
        Me.picShrimp.Image = Global.Party_Platters2.My.Resources.Resources.IMG_1469_scaled
        Me.picShrimp.Location = New System.Drawing.Point(238, 341)
        Me.picShrimp.Name = "picShrimp"
        Me.picShrimp.Size = New System.Drawing.Size(65, 64)
        Me.picShrimp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShrimp.TabIndex = 25
        Me.picShrimp.TabStop = False
        '
        'picSushi
        '
        Me.picSushi.Image = Global.Party_Platters2.My.Resources.Resources._0000000924FES
        Me.picSushi.Location = New System.Drawing.Point(238, 411)
        Me.picSushi.Name = "picSushi"
        Me.picSushi.Size = New System.Drawing.Size(65, 64)
        Me.picSushi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSushi.TabIndex = 23
        Me.picSushi.TabStop = False
        '
        'picFruit
        '
        Me.picFruit.Image = Global.Party_Platters2.My.Resources.Resources.fruitcharcuterieboard
        Me.picFruit.Location = New System.Drawing.Point(238, 201)
        Me.picFruit.Name = "picFruit"
        Me.picFruit.Size = New System.Drawing.Size(65, 64)
        Me.picFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit.TabIndex = 21
        Me.picFruit.TabStop = False
        '
        'picBean
        '
        Me.picBean.Image = Global.Party_Platters2.My.Resources.Resources.Red_Beans_and_Rice_SQ
        Me.picBean.Location = New System.Drawing.Point(238, 129)
        Me.picBean.Name = "picBean"
        Me.picBean.Size = New System.Drawing.Size(65, 66)
        Me.picBean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBean.TabIndex = 19
        Me.picBean.TabStop = False
        '
        'lblNoDiscount
        '
        Me.lblNoDiscount.AutoSize = True
        Me.lblNoDiscount.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDiscount.Location = New System.Drawing.Point(390, 341)
        Me.lblNoDiscount.Name = "lblNoDiscount"
        Me.lblNoDiscount.Size = New System.Drawing.Size(401, 24)
        Me.lblNoDiscount.TabIndex = 31
        Me.lblNoDiscount.Text = "You need 10 or more points to recive a 5% discount."
        Me.lblNoDiscount.UseCompatibleTextRendering = True
        Me.lblNoDiscount.Visible = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCheckout.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCheckout.Location = New System.Drawing.Point(467, 392)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(88, 37)
        Me.btnCheckout.TabIndex = 32
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSalmon
        Me.btnClear.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(601, 392)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 37)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCostOutput
        '
        Me.lblCostOutput.AutoSize = True
        Me.lblCostOutput.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOutput.Location = New System.Drawing.Point(463, 452)
        Me.lblCostOutput.Name = "lblCostOutput"
        Me.lblCostOutput.Size = New System.Drawing.Size(115, 19)
        Me.lblCostOutput.TabIndex = 34
        Me.lblCostOutput.Text = "Cost of Order:"
        '
        'txtCostOutput
        '
        Me.txtCostOutput.BackColor = System.Drawing.Color.OldLace
        Me.txtCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostOutput.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostOutput.Location = New System.Drawing.Point(581, 452)
        Me.txtCostOutput.Name = "txtCostOutput"
        Me.txtCostOutput.Size = New System.Drawing.Size(100, 19)
        Me.txtCostOutput.TabIndex = 35
        '
        'lblPrice1
        '
        Me.lblPrice1.AutoSize = True
        Me.lblPrice1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice1.Location = New System.Drawing.Point(309, 170)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(40, 21)
        Me.lblPrice1.TabIndex = 36
        Me.lblPrice1.Text = "$15"
        '
        'lblPrice2
        '
        Me.lblPrice2.AutoSize = True
        Me.lblPrice2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice2.Location = New System.Drawing.Point(309, 244)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(40, 21)
        Me.lblPrice2.TabIndex = 37
        Me.lblPrice2.Text = "$20"
        '
        'lblPrice3
        '
        Me.lblPrice3.AutoSize = True
        Me.lblPrice3.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice3.Location = New System.Drawing.Point(309, 314)
        Me.lblPrice3.Name = "lblPrice3"
        Me.lblPrice3.Size = New System.Drawing.Size(40, 21)
        Me.lblPrice3.TabIndex = 38
        Me.lblPrice3.Text = "$25"
        '
        'lblPrice4
        '
        Me.lblPrice4.AutoSize = True
        Me.lblPrice4.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice4.Location = New System.Drawing.Point(309, 384)
        Me.lblPrice4.Name = "lblPrice4"
        Me.lblPrice4.Size = New System.Drawing.Size(40, 21)
        Me.lblPrice4.TabIndex = 39
        Me.lblPrice4.Text = "$30"
        '
        'lblPrice5
        '
        Me.lblPrice5.AutoSize = True
        Me.lblPrice5.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice5.Location = New System.Drawing.Point(309, 455)
        Me.lblPrice5.Name = "lblPrice5"
        Me.lblPrice5.Size = New System.Drawing.Size(40, 21)
        Me.lblPrice5.TabIndex = 40
        Me.lblPrice5.Text = "$35"
        '
        'PartyPlatters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(798, 529)
        Me.Controls.Add(Me.lblPrice5)
        Me.Controls.Add(Me.lblPrice4)
        Me.Controls.Add(Me.lblPrice3)
        Me.Controls.Add(Me.lblPrice2)
        Me.Controls.Add(Me.lblPrice1)
        Me.Controls.Add(Me.txtCostOutput)
        Me.Controls.Add(Me.lblCostOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblNoDiscount)
        Me.Controls.Add(Me.txtLoyaltyPoints)
        Me.Controls.Add(Me.lblLoyaltyPoints)
        Me.Controls.Add(Me.grpPayOptions)
        Me.Controls.Add(Me.picMeat)
        Me.Controls.Add(Me.radMeatPlatter)
        Me.Controls.Add(Me.picShrimp)
        Me.Controls.Add(Me.radShrimpPlatter)
        Me.Controls.Add(Me.picSushi)
        Me.Controls.Add(Me.radSushiPlatter)
        Me.Controls.Add(Me.picFruit)
        Me.Controls.Add(Me.radFruitPlatter)
        Me.Controls.Add(Me.picBean)
        Me.Controls.Add(Me.radRiceBeans)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "PartyPlatters"
        Me.Text = "Form1"
        Me.grpPayOptions.ResumeLayout(False)
        Me.grpPayOptions.PerformLayout()
        CType(Me.picMeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShrimp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSushi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents lblLoyaltyPoints As Label
    Friend WithEvents grpPayOptions As GroupBox
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents picMeat As PictureBox
    Friend WithEvents radMeatPlatter As RadioButton
    Friend WithEvents picShrimp As PictureBox
    Friend WithEvents radShrimpPlatter As RadioButton
    Friend WithEvents picSushi As PictureBox
    Friend WithEvents radSushiPlatter As RadioButton
    Friend WithEvents picFruit As PictureBox
    Friend WithEvents radFruitPlatter As RadioButton
    Friend WithEvents picBean As PictureBox
    Friend WithEvents radRiceBeans As RadioButton
    Friend WithEvents lblOptions As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNoDiscount As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCostOutput As Label
    Friend WithEvents txtCostOutput As TextBox
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblPrice4 As Label
    Friend WithEvents lblPrice5 As Label
End Class
