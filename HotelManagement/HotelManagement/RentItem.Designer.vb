<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentItem
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
        Me.dgvrent = New System.Windows.Forms.DataGridView
        Me.txtrentID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ExtramIteminfo = New System.Windows.Forms.GroupBox
        Me.RentItemInfo = New System.Windows.Forms.GroupBox
        Me.txtextraPRICE = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtprentDATE = New System.Windows.Forms.DateTimePicker
        Me.cboextraID = New System.Windows.Forms.ComboBox
        Me.txtextraType = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRN = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtrentnight = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtrentamt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtrentQty = New System.Windows.Forms.TextBox
        CType(Me.dgvrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExtramIteminfo.SuspendLayout()
        Me.RentItemInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvrent
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvrent.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvrent.Location = New System.Drawing.Point(12, 183)
        Me.dgvrent.Name = "dgvrent"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrent.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvrent.Size = New System.Drawing.Size(904, 148)
        Me.dgvrent.TabIndex = 64
        '
        'txtrentID
        '
        Me.txtrentID.Location = New System.Drawing.Point(99, 33)
        Me.txtrentID.Name = "txtrentID"
        Me.txtrentID.Size = New System.Drawing.Size(100, 20)
        Me.txtrentID.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "RentDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "RentID"
        '
        'ExtramIteminfo
        '
        Me.ExtramIteminfo.Controls.Add(Me.txtextraType)
        Me.ExtramIteminfo.Controls.Add(Me.cboextraID)
        Me.ExtramIteminfo.Controls.Add(Me.Label6)
        Me.ExtramIteminfo.Controls.Add(Me.Label5)
        Me.ExtramIteminfo.Controls.Add(Me.txtextraPRICE)
        Me.ExtramIteminfo.Controls.Add(Me.Label2)
        Me.ExtramIteminfo.Location = New System.Drawing.Point(276, 35)
        Me.ExtramIteminfo.Name = "ExtramIteminfo"
        Me.ExtramIteminfo.Size = New System.Drawing.Size(206, 125)
        Me.ExtramIteminfo.TabIndex = 66
        Me.ExtramIteminfo.TabStop = False
        Me.ExtramIteminfo.Text = "ExtraItemInfo"
        '
        'RentItemInfo
        '
        Me.RentItemInfo.Controls.Add(Me.dtprentDATE)
        Me.RentItemInfo.Controls.Add(Me.Label4)
        Me.RentItemInfo.Controls.Add(Me.Label1)
        Me.RentItemInfo.Controls.Add(Me.Label3)
        Me.RentItemInfo.Controls.Add(Me.txtRN)
        Me.RentItemInfo.Controls.Add(Me.txtrentID)
        Me.RentItemInfo.Location = New System.Drawing.Point(39, 25)
        Me.RentItemInfo.Name = "RentItemInfo"
        Me.RentItemInfo.Size = New System.Drawing.Size(206, 135)
        Me.RentItemInfo.TabIndex = 66
        Me.RentItemInfo.TabStop = False
        Me.RentItemInfo.Text = "RentItemInfo"
        '
        'txtextraPRICE
        '
        Me.txtextraPRICE.Location = New System.Drawing.Point(87, 99)
        Me.txtextraPRICE.Name = "txtextraPRICE"
        Me.txtextraPRICE.Size = New System.Drawing.Size(100, 20)
        Me.txtextraPRICE.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "ExtraItemType"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "ExtraItemID"
        '
        'dtprentDATE
        '
        Me.dtprentDATE.Enabled = False
        Me.dtprentDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtprentDATE.Location = New System.Drawing.Point(99, 72)
        Me.dtprentDATE.Name = "dtprentDATE"
        Me.dtprentDATE.Size = New System.Drawing.Size(100, 20)
        Me.dtprentDATE.TabIndex = 58
        '
        'cboextraID
        '
        Me.cboextraID.FormattingEnabled = True
        Me.cboextraID.Location = New System.Drawing.Point(87, 18)
        Me.cboextraID.Name = "cboextraID"
        Me.cboextraID.Size = New System.Drawing.Size(95, 21)
        Me.cboextraID.TabIndex = 66
        '
        'txtextraType
        '
        Me.txtextraType.Location = New System.Drawing.Point(87, 57)
        Me.txtextraType.Name = "txtextraType"
        Me.txtextraType.Size = New System.Drawing.Size(100, 20)
        Me.txtextraType.TabIndex = 67
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
        'txtRN
        '
        Me.txtRN.Location = New System.Drawing.Point(100, 106)
        Me.txtRN.Name = "txtRN"
        Me.txtRN.Size = New System.Drawing.Size(100, 20)
        Me.txtRN.TabIndex = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtrentQty)
        Me.GroupBox1.Controls.Add(Me.txtrentnight)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtrentamt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 125)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ExtraItemInfo"
        '
        'txtrentnight
        '
        Me.txtrentnight.Location = New System.Drawing.Point(87, 57)
        Me.txtrentnight.Name = "txtrentnight"
        Me.txtrentnight.Size = New System.Drawing.Size(100, 20)
        Me.txtrentnight.TabIndex = 67
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
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Night"
        '
        'txtrentamt
        '
        Me.txtrentamt.Location = New System.Drawing.Point(87, 99)
        Me.txtrentamt.Name = "txtrentamt"
        Me.txtrentamt.Size = New System.Drawing.Size(100, 20)
        Me.txtrentamt.TabIndex = 58
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(462, 337)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 25)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(363, 337)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 25)
        Me.Button5.TabIndex = 71
        Me.Button5.Text = "New"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(267, 337)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 25)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 25)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 25)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Rent"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtrentQty
        '
        Me.txtrentQty.Location = New System.Drawing.Point(87, 18)
        Me.txtrentQty.Name = "txtrentQty"
        Me.txtrentQty.Size = New System.Drawing.Size(100, 20)
        Me.txtrentQty.TabIndex = 67
        '
        'RentItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 393)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RentItemInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExtramIteminfo)
        Me.Controls.Add(Me.dgvrent)
        Me.Name = "RentItem"
        Me.Text = "RentItem"
        CType(Me.dgvrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExtramIteminfo.ResumeLayout(False)
        Me.ExtramIteminfo.PerformLayout()
        Me.RentItemInfo.ResumeLayout(False)
        Me.RentItemInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvrent As System.Windows.Forms.DataGridView
    Friend WithEvents txtrentID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExtramIteminfo As System.Windows.Forms.GroupBox
    Friend WithEvents RentItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtextraPRICE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtprentDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtextraType As System.Windows.Forms.TextBox
    Friend WithEvents cboextraID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtrentnight As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtrentamt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtrentQty As System.Windows.Forms.TextBox
End Class
