<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTicketGroupDiscount
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
        Me.pnlGroup = New System.Windows.Forms.Panel()
        Me.lbl25To99Price = New System.Windows.Forms.Label()
        Me.lbl25To99 = New System.Windows.Forms.Label()
        Me.lbl13To24Price = New System.Windows.Forms.Label()
        Me.lbl13To24 = New System.Windows.Forms.Label()
        Me.lbl9To12Price = New System.Windows.Forms.Label()
        Me.lbl9To12 = New System.Windows.Forms.Label()
        Me.lbl1To8Price = New System.Windows.Forms.Label()
        Me.lbl1To8 = New System.Windows.Forms.Label()
        Me.lblTicketsPerPersonPrice = New System.Windows.Forms.Label()
        Me.lblGroupSizeGrid = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.picBroadway = New System.Windows.Forms.PictureBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlGroup.SuspendLayout()
        CType(Me.picBroadway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGroup
        '
        Me.pnlGroup.Controls.Add(Me.lbl25To99Price)
        Me.pnlGroup.Controls.Add(Me.lbl25To99)
        Me.pnlGroup.Controls.Add(Me.lbl13To24Price)
        Me.pnlGroup.Controls.Add(Me.lbl13To24)
        Me.pnlGroup.Controls.Add(Me.lbl9To12Price)
        Me.pnlGroup.Controls.Add(Me.lbl9To12)
        Me.pnlGroup.Controls.Add(Me.lbl1To8Price)
        Me.pnlGroup.Controls.Add(Me.lbl1To8)
        Me.pnlGroup.Controls.Add(Me.lblTicketsPerPersonPrice)
        Me.pnlGroup.Controls.Add(Me.lblGroupSizeGrid)
        Me.pnlGroup.Location = New System.Drawing.Point(40, 112)
        Me.pnlGroup.Name = "pnlGroup"
        Me.pnlGroup.Size = New System.Drawing.Size(303, 199)
        Me.pnlGroup.TabIndex = 0
        '
        'lbl25To99Price
        '
        Me.lbl25To99Price.BackColor = System.Drawing.Color.Snow
        Me.lbl25To99Price.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl25To99Price.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl25To99Price.Location = New System.Drawing.Point(151, 160)
        Me.lbl25To99Price.Name = "lbl25To99Price"
        Me.lbl25To99Price.Size = New System.Drawing.Size(154, 37)
        Me.lbl25To99Price.TabIndex = 9
        Me.lbl25To99Price.Text = "$169"
        Me.lbl25To99Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl25To99
        '
        Me.lbl25To99.BackColor = System.Drawing.Color.Snow
        Me.lbl25To99.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl25To99.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl25To99.Location = New System.Drawing.Point(-3, 160)
        Me.lbl25To99.Name = "lbl25To99"
        Me.lbl25To99.Size = New System.Drawing.Size(154, 37)
        Me.lbl25To99.TabIndex = 8
        Me.lbl25To99.Text = "25-99"
        Me.lbl25To99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl13To24Price
        '
        Me.lbl13To24Price.BackColor = System.Drawing.Color.Snow
        Me.lbl13To24Price.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13To24Price.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl13To24Price.Location = New System.Drawing.Point(151, 123)
        Me.lbl13To24Price.Name = "lbl13To24Price"
        Me.lbl13To24Price.Size = New System.Drawing.Size(154, 37)
        Me.lbl13To24Price.TabIndex = 7
        Me.lbl13To24Price.Text = "$199"
        Me.lbl13To24Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl13To24
        '
        Me.lbl13To24.BackColor = System.Drawing.Color.Snow
        Me.lbl13To24.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13To24.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl13To24.Location = New System.Drawing.Point(0, 123)
        Me.lbl13To24.Name = "lbl13To24"
        Me.lbl13To24.Size = New System.Drawing.Size(154, 37)
        Me.lbl13To24.TabIndex = 6
        Me.lbl13To24.Text = "13-24"
        Me.lbl13To24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl9To12Price
        '
        Me.lbl9To12Price.BackColor = System.Drawing.Color.Snow
        Me.lbl9To12Price.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9To12Price.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl9To12Price.Location = New System.Drawing.Point(151, 86)
        Me.lbl9To12Price.Name = "lbl9To12Price"
        Me.lbl9To12Price.Size = New System.Drawing.Size(154, 37)
        Me.lbl9To12Price.TabIndex = 5
        Me.lbl9To12Price.Text = "$219"
        Me.lbl9To12Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl9To12
        '
        Me.lbl9To12.BackColor = System.Drawing.Color.Snow
        Me.lbl9To12.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9To12.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl9To12.Location = New System.Drawing.Point(-3, 86)
        Me.lbl9To12.Name = "lbl9To12"
        Me.lbl9To12.Size = New System.Drawing.Size(154, 37)
        Me.lbl9To12.TabIndex = 4
        Me.lbl9To12.Text = "9-12"
        Me.lbl9To12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1To8Price
        '
        Me.lbl1To8Price.BackColor = System.Drawing.Color.Snow
        Me.lbl1To8Price.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1To8Price.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl1To8Price.Location = New System.Drawing.Point(149, 49)
        Me.lbl1To8Price.Name = "lbl1To8Price"
        Me.lbl1To8Price.Size = New System.Drawing.Size(154, 37)
        Me.lbl1To8Price.TabIndex = 3
        Me.lbl1To8Price.Text = "$249"
        Me.lbl1To8Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1To8
        '
        Me.lbl1To8.BackColor = System.Drawing.Color.Snow
        Me.lbl1To8.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1To8.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl1To8.Location = New System.Drawing.Point(0, 49)
        Me.lbl1To8.Name = "lbl1To8"
        Me.lbl1To8.Size = New System.Drawing.Size(151, 37)
        Me.lbl1To8.TabIndex = 2
        Me.lbl1To8.Text = "1-8"
        Me.lbl1To8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTicketsPerPersonPrice
        '
        Me.lblTicketsPerPersonPrice.BackColor = System.Drawing.Color.LightCoral
        Me.lblTicketsPerPersonPrice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketsPerPersonPrice.ForeColor = System.Drawing.Color.Snow
        Me.lblTicketsPerPersonPrice.Location = New System.Drawing.Point(152, 0)
        Me.lblTicketsPerPersonPrice.Name = "lblTicketsPerPersonPrice"
        Me.lblTicketsPerPersonPrice.Size = New System.Drawing.Size(151, 49)
        Me.lblTicketsPerPersonPrice.TabIndex = 1
        Me.lblTicketsPerPersonPrice.Text = "Broadway Tickets per Person"
        Me.lblTicketsPerPersonPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGroupSizeGrid
        '
        Me.lblGroupSizeGrid.BackColor = System.Drawing.Color.LightCoral
        Me.lblGroupSizeGrid.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSizeGrid.ForeColor = System.Drawing.Color.Snow
        Me.lblGroupSizeGrid.Location = New System.Drawing.Point(0, 0)
        Me.lblGroupSizeGrid.Name = "lblGroupSizeGrid"
        Me.lblGroupSizeGrid.Size = New System.Drawing.Size(151, 49)
        Me.lblGroupSizeGrid.TabIndex = 0
        Me.lblGroupSizeGrid.Text = "Group Size"
        Me.lblGroupSizeGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Snow
        Me.lblHeading.Location = New System.Drawing.Point(71, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(546, 35)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Broadway Ticket Group Discount"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Snow
        Me.lblGroupSize.Location = New System.Drawing.Point(362, 87)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(189, 32)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.ForeColor = System.Drawing.Color.IndianRed
        Me.txtGroupSize.Location = New System.Drawing.Point(547, 87)
        Me.txtGroupSize.MaxLength = 2
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(100, 37)
        Me.txtGroupSize.TabIndex = 3
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Snow
        Me.btnDisplay.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.IndianRed
        Me.btnDisplay.Location = New System.Drawing.Point(381, 156)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(92, 37)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'picBroadway
        '
        Me.picBroadway.Image = Global.Broadway_Ticket_Group_Discount.My.Resources.Resources.Screenshot_2023_11_17_094201
        Me.picBroadway.Location = New System.Drawing.Point(381, 219)
        Me.picBroadway.Name = "picBroadway"
        Me.picBroadway.Size = New System.Drawing.Size(266, 205)
        Me.picBroadway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBroadway.TabIndex = 6
        Me.picBroadway.TabStop = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Snow
        Me.lblPrice.Location = New System.Drawing.Point(57, 336)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(108, 35)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.IndianRed
        Me.txtPrice.Location = New System.Drawing.Point(171, 336)
        Me.txtPrice.MaxLength = 50
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(172, 40)
        Me.txtPrice.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Snow
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.IndianRed
        Me.btnClear.Location = New System.Drawing.Point(555, 156)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmBroadwayTicketGroupDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(688, 459)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.picBroadway)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.pnlGroup)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmBroadwayTicketGroupDiscount"
        Me.Text = "Broadway Ticket Group Discount"
        Me.pnlGroup.ResumeLayout(False)
        CType(Me.picBroadway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlGroup As Panel
    Friend WithEvents lbl1To8 As Label
    Friend WithEvents lblTicketsPerPersonPrice As Label
    Friend WithEvents lblGroupSizeGrid As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lbl25To99Price As Label
    Friend WithEvents lbl25To99 As Label
    Friend WithEvents lbl13To24Price As Label
    Friend WithEvents lbl13To24 As Label
    Friend WithEvents lbl9To12Price As Label
    Friend WithEvents lbl9To12 As Label
    Friend WithEvents lbl1To8Price As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents picBroadway As PictureBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnClear As Button
End Class
