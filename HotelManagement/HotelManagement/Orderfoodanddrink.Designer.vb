<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.RentItemInfo = New System.Windows.Forms.GroupBox
        Me.cboRN = New System.Windows.Forms.ComboBox
        Me.dtporderDATE = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtorderID = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtorderQty = New System.Windows.Forms.TextBox
        Me.txtorderPRICE = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtorderamt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ExtramIteminfo = New System.Windows.Forms.GroupBox
        Me.cboorderN = New System.Windows.Forms.ComboBox
        Me.cboorderType = New System.Windows.Forms.ComboBox
        Me.cboorderfd = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvorder = New System.Windows.Forms.DataGridView
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttotalamt = New System.Windows.Forms.TextBox
        Me.RentItemInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ExtramIteminfo.SuspendLayout()
        CType(Me.dgvorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(442, 338)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 25)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(343, 338)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 25)
        Me.Button5.TabIndex = 80
        Me.Button5.Text = "New"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(247, 338)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 25)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 25)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 25)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RentItemInfo
        '
        Me.RentItemInfo.BackgroundImage = Global.HotelManagement.My.Resources.Resources.Studio_20160207_175903
        Me.RentItemInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RentItemInfo.Controls.Add(Me.cboRN)
        Me.RentItemInfo.Controls.Add(Me.dtporderDATE)
        Me.RentItemInfo.Controls.Add(Me.Label4)
        Me.RentItemInfo.Controls.Add(Me.Label1)
        Me.RentItemInfo.Controls.Add(Me.Label3)
        Me.RentItemInfo.Controls.Add(Me.txtorderID)
        Me.RentItemInfo.Location = New System.Drawing.Point(19, 23)
        Me.RentItemInfo.Name = "RentItemInfo"
        Me.RentItemInfo.Size = New System.Drawing.Size(206, 135)
        Me.RentItemInfo.TabIndex = 73
        Me.RentItemInfo.TabStop = False
        Me.RentItemInfo.Text = "OrderItemInfo"
        '
        'cboRN
        '
        Me.cboRN.FormattingEnabled = True
        Me.cboRN.Location = New System.Drawing.Point(104, 101)
        Me.cboRN.Name = "cboRN"
        Me.cboRN.Size = New System.Drawing.Size(95, 21)
        Me.cboRN.TabIndex = 67
        '
        'dtporderDATE
        '
        Me.dtporderDATE.Enabled = False
        Me.dtporderDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtporderDATE.Location = New System.Drawing.Point(99, 72)
        Me.dtporderDATE.Name = "dtporderDATE"
        Me.dtporderDATE.Size = New System.Drawing.Size(100, 20)
        Me.dtporderDATE.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "RoomNo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "OrderID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "OrderDate"
        '
        'txtorderID
        '
        Me.txtorderID.Location = New System.Drawing.Point(99, 33)
        Me.txtorderID.Name = "txtorderID"
        Me.txtorderID.Size = New System.Drawing.Size(100, 20)
        Me.txtorderID.TabIndex = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.HotelManagement.My.Resources.Resources.Studio_20160207_175903
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtorderQty)
        Me.GroupBox1.Controls.Add(Me.txtorderPRICE)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtorderamt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(537, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 125)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GenerateInfo"
        '
        'txtorderQty
        '
        Me.txtorderQty.Location = New System.Drawing.Point(87, 18)
        Me.txtorderQty.Name = "txtorderQty"
        Me.txtorderQty.Size = New System.Drawing.Size(100, 20)
        Me.txtorderQty.TabIndex = 67
        '
        'txtorderPRICE
        '
        Me.txtorderPRICE.Location = New System.Drawing.Point(87, 57)
        Me.txtorderPRICE.Name = "txtorderPRICE"
        Me.txtorderPRICE.Size = New System.Drawing.Size(100, 20)
        Me.txtorderPRICE.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Price"
        '
        'txtorderamt
        '
        Me.txtorderamt.Location = New System.Drawing.Point(87, 99)
        Me.txtorderamt.Name = "txtorderamt"
        Me.txtorderamt.Size = New System.Drawing.Size(100, 20)
        Me.txtorderamt.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Amount"
        '
        'ExtramIteminfo
        '
        Me.ExtramIteminfo.BackgroundImage = Global.HotelManagement.My.Resources.Resources.Studio_20160207_175903
        Me.ExtramIteminfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExtramIteminfo.Controls.Add(Me.cboorderN)
        Me.ExtramIteminfo.Controls.Add(Me.cboorderType)
        Me.ExtramIteminfo.Controls.Add(Me.cboorderfd)
        Me.ExtramIteminfo.Controls.Add(Me.Label6)
        Me.ExtramIteminfo.Controls.Add(Me.Label5)
        Me.ExtramIteminfo.Controls.Add(Me.Label2)
        Me.ExtramIteminfo.Location = New System.Drawing.Point(256, 33)
        Me.ExtramIteminfo.Name = "ExtramIteminfo"
        Me.ExtramIteminfo.Size = New System.Drawing.Size(247, 125)
        Me.ExtramIteminfo.TabIndex = 75
        Me.ExtramIteminfo.TabStop = False
        Me.ExtramIteminfo.Text = "OrderTypeInfo"
        '
        'cboorderN
        '
        Me.cboorderN.FormattingEnabled = True
        Me.cboorderN.Location = New System.Drawing.Point(125, 88)
        Me.cboorderN.Name = "cboorderN"
        Me.cboorderN.Size = New System.Drawing.Size(95, 21)
        Me.cboorderN.TabIndex = 66
        '
        'cboorderType
        '
        Me.cboorderType.FormattingEnabled = True
        Me.cboorderType.Location = New System.Drawing.Point(125, 56)
        Me.cboorderType.Name = "cboorderType"
        Me.cboorderType.Size = New System.Drawing.Size(95, 21)
        Me.cboorderType.TabIndex = 66
        '
        'cboorderfd
        '
        Me.cboorderfd.FormattingEnabled = True
        Me.cboorderfd.Items.AddRange(New Object() {"Select", "Food", "Drink"})
        Me.cboorderfd.Location = New System.Drawing.Point(125, 19)
        Me.cboorderfd.Name = "cboorderfd"
        Me.cboorderfd.Size = New System.Drawing.Size(95, 21)
        Me.cboorderfd.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "OrderFoodandDrink"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "OrderType"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "OrderName"
        '
        'dgvorder
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvorder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvorder.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvorder.Location = New System.Drawing.Point(19, 181)
        Me.dgvorder.Name = "dgvorder"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvorder.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvorder.Size = New System.Drawing.Size(877, 148)
        Me.dgvorder.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(692, 338)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Total Amount"
        '
        'txttotalamt
        '
        Me.txttotalamt.Location = New System.Drawing.Point(785, 335)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.Size = New System.Drawing.Size(100, 20)
        Me.txttotalamt.TabIndex = 58
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HotelManagement.My.Resources.Resources.Studio_20160207_175903
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(924, 389)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txttotalamt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RentItemInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExtramIteminfo)
        Me.Controls.Add(Me.dgvorder)
        Me.DoubleBuffered = True
        Me.Name = "Order"
        Me.Text = "Order"
        Me.RentItemInfo.ResumeLayout(False)
        Me.RentItemInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ExtramIteminfo.ResumeLayout(False)
        Me.ExtramIteminfo.PerformLayout()
        CType(Me.dgvorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RentItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents dtporderDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtorderID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtorderQty As System.Windows.Forms.TextBox
    Friend WithEvents txtorderPRICE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtorderamt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ExtramIteminfo As System.Windows.Forms.GroupBox
    Friend WithEvents cboorderfd As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvorder As System.Windows.Forms.DataGridView
    Friend WithEvents cboorderN As System.Windows.Forms.ComboBox
    Friend WithEvents cboorderType As System.Windows.Forms.ComboBox
    Friend WithEvents cboRN As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttotalamt As System.Windows.Forms.TextBox
End Class
