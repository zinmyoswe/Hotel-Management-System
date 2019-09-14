<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtGN = New System.Windows.Forms.TextBox
        Me.txtCOUTID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNOD = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtChanging = New System.Windows.Forms.TextBox
        Me.txtAP = New System.Windows.Forms.TextBox
        Me.txtT = New System.Windows.Forms.TextBox
        Me.txtDis = New System.Windows.Forms.TextBox
        Me.txtST = New System.Windows.Forms.TextBox
        Me.txtOC = New System.Windows.Forms.TextBox
        Me.txtTC = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCOutTime = New System.Windows.Forms.TextBox
        Me.dtpCOutDATE = New System.Windows.Forms.DateTimePicker
        Me.cboRN = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcheckintime = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPRICE = New System.Windows.Forms.TextBox
        Me.txtcheckindate = New System.Windows.Forms.TextBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvexternal = New System.Windows.Forms.DataGridView
        Me.txtRID = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvexternal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGN
        '
        Me.txtGN.Location = New System.Drawing.Point(88, 66)
        Me.txtGN.Name = "txtGN"
        Me.txtGN.Size = New System.Drawing.Size(100, 20)
        Me.txtGN.TabIndex = 31
        '
        'txtCOUTID
        '
        Me.txtCOUTID.Location = New System.Drawing.Point(138, 30)
        Me.txtCOUTID.Name = "txtCOUTID"
        Me.txtCOUTID.Size = New System.Drawing.Size(100, 20)
        Me.txtCOUTID.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "GuestName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "RoomNo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "CheckInDate"
        '
        'txtNOD
        '
        Me.txtNOD.Location = New System.Drawing.Point(88, 184)
        Me.txtNOD.Name = "txtNOD"
        Me.txtNOD.Size = New System.Drawing.Size(32, 20)
        Me.txtNOD.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "No Of Days"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtChanging)
        Me.GroupBox1.Controls.Add(Me.txtAP)
        Me.GroupBox1.Controls.Add(Me.txtT)
        Me.GroupBox1.Controls.Add(Me.txtDis)
        Me.GroupBox1.Controls.Add(Me.txtST)
        Me.GroupBox1.Controls.Add(Me.txtOC)
        Me.GroupBox1.Controls.Add(Me.txtTC)
        Me.GroupBox1.Location = New System.Drawing.Point(497, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 237)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CheckOut"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Changing"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "AmountPaid"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Discount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "SubTotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Other Charges"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Total Charges"
        '
        'txtChanging
        '
        Me.txtChanging.Location = New System.Drawing.Point(100, 199)
        Me.txtChanging.Name = "txtChanging"
        Me.txtChanging.Size = New System.Drawing.Size(100, 20)
        Me.txtChanging.TabIndex = 26
        '
        'txtAP
        '
        Me.txtAP.Location = New System.Drawing.Point(100, 172)
        Me.txtAP.Name = "txtAP"
        Me.txtAP.Size = New System.Drawing.Size(100, 20)
        Me.txtAP.TabIndex = 26
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(100, 146)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(100, 20)
        Me.txtT.TabIndex = 26
        '
        'txtDis
        '
        Me.txtDis.Location = New System.Drawing.Point(100, 120)
        Me.txtDis.Name = "txtDis"
        Me.txtDis.Size = New System.Drawing.Size(100, 20)
        Me.txtDis.TabIndex = 26
        '
        'txtST
        '
        Me.txtST.Location = New System.Drawing.Point(99, 90)
        Me.txtST.Name = "txtST"
        Me.txtST.Size = New System.Drawing.Size(100, 20)
        Me.txtST.TabIndex = 26
        '
        'txtOC
        '
        Me.txtOC.Location = New System.Drawing.Point(100, 59)
        Me.txtOC.Name = "txtOC"
        Me.txtOC.Size = New System.Drawing.Size(100, 20)
        Me.txtOC.TabIndex = 26
        '
        'txtTC
        '
        Me.txtTC.Location = New System.Drawing.Point(99, 33)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(100, 20)
        Me.txtTC.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(110, 431)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 25)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "CheckOut"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(236, 431)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 25)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtCOutTime)
        Me.GroupBox2.Controls.Add(Me.dtpCOutDATE)
        Me.GroupBox2.Controls.Add(Me.txtCOUTID)
        Me.GroupBox2.Location = New System.Drawing.Point(225, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 138)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CheckOut"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "CheckOutTime"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(47, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "CheckOutDate"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(47, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(47, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "CheckOutID"
        '
        'txtCOutTime
        '
        Me.txtCOutTime.Location = New System.Drawing.Point(138, 91)
        Me.txtCOutTime.Name = "txtCOutTime"
        Me.txtCOutTime.Size = New System.Drawing.Size(100, 20)
        Me.txtCOutTime.TabIndex = 0
        '
        'dtpCOutDATE
        '
        Me.dtpCOutDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCOutDATE.Location = New System.Drawing.Point(138, 61)
        Me.dtpCOutDATE.Name = "dtpCOutDATE"
        Me.dtpCOutDATE.Size = New System.Drawing.Size(100, 20)
        Me.dtpCOutDATE.TabIndex = 0
        '
        'cboRN
        '
        Me.cboRN.FormattingEnabled = True
        Me.cboRN.Location = New System.Drawing.Point(88, 22)
        Me.cboRN.Name = "cboRN"
        Me.cboRN.Size = New System.Drawing.Size(95, 21)
        Me.cboRN.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "CheckInTime"
        '
        'txtcheckintime
        '
        Me.txtcheckintime.Location = New System.Drawing.Point(88, 155)
        Me.txtcheckintime.Name = "txtcheckintime"
        Me.txtcheckintime.Size = New System.Drawing.Size(100, 20)
        Me.txtcheckintime.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Price"
        '
        'txtPRICE
        '
        Me.txtPRICE.Location = New System.Drawing.Point(88, 95)
        Me.txtPRICE.Name = "txtPRICE"
        Me.txtPRICE.Size = New System.Drawing.Size(100, 20)
        Me.txtPRICE.TabIndex = 46
        '
        'txtcheckindate
        '
        Me.txtcheckindate.Location = New System.Drawing.Point(88, 125)
        Me.txtcheckindate.Name = "txtcheckindate"
        Me.txtcheckindate.Size = New System.Drawing.Size(100, 20)
        Me.txtcheckindate.TabIndex = 46
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(9, 431)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(61, 25)
        Me.btnclose.TabIndex = 40
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.dgvexternal)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(704, 157)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "External Charges Detail"
        '
        'dgvexternal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvexternal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvexternal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvexternal.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvexternal.Location = New System.Drawing.Point(35, 20)
        Me.dgvexternal.Name = "dgvexternal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvexternal.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvexternal.RowTemplate.Height = 24
        Me.dgvexternal.Size = New System.Drawing.Size(630, 122)
        Me.dgvexternal.TabIndex = 43
        '
        'txtRID
        '
        Me.txtRID.Location = New System.Drawing.Point(88, 41)
        Me.txtRID.Name = "txtRID"
        Me.txtRID.Size = New System.Drawing.Size(100, 20)
        Me.txtRID.TabIndex = 31
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 468)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtcheckindate)
        Me.Controls.Add(Me.txtPRICE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcheckintime)
        Me.Controls.Add(Me.cboRN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNOD)
        Me.Controls.Add(Me.txtRID)
        Me.Controls.Add(Me.txtGN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "CheckOut"
        Me.Text = "CheckOut"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvexternal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGN As System.Windows.Forms.TextBox
    Friend WithEvents txtCOUTID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNOD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOC As System.Windows.Forms.TextBox
    Friend WithEvents txtTC As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtST As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtT As System.Windows.Forms.TextBox
    Friend WithEvents txtAP As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtChanging As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCOutTime As System.Windows.Forms.TextBox
    Friend WithEvents dtpCOutDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboRN As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcheckintime As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPRICE As System.Windows.Forms.TextBox
    Friend WithEvents txtcheckindate As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvexternal As System.Windows.Forms.DataGridView
    Friend WithEvents txtRID As System.Windows.Forms.TextBox
    Friend WithEvents txtDis As System.Windows.Forms.TextBox
End Class
