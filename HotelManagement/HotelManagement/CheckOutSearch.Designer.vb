<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutSearch
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
        Me.rdoCID = New System.Windows.Forms.RadioButton
        Me.rdoGN = New System.Windows.Forms.RadioButton
        Me.rdoRN = New System.Windows.Forms.RadioButton
        Me.rdoCD = New System.Windows.Forms.RadioButton
        Me.rdobtw = New System.Windows.Forms.RadioButton
        Me.cboCID = New System.Windows.Forms.ComboBox
        Me.cboGN = New System.Windows.Forms.ComboBox
        Me.cboRN = New System.Windows.Forms.ComboBox
        Me.dtpCD = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.btnsearch = New System.Windows.Forms.Button
        Me.btnall = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.tbcheckout = New System.Windows.Forms.TabControl
        Me.tbP1 = New System.Windows.Forms.TabPage
        Me.dgvCheckout = New System.Windows.Forms.DataGridView
        Me.tbP2 = New System.Windows.Forms.TabPage
        Me.dgvdetail = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.tbcheckout.SuspendLayout()
        Me.tbP1.SuspendLayout()
        CType(Me.dgvCheckout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbP2.SuspendLayout()
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoCID
        '
        Me.rdoCID.AutoSize = True
        Me.rdoCID.Location = New System.Drawing.Point(34, 26)
        Me.rdoCID.Name = "rdoCID"
        Me.rdoCID.Size = New System.Drawing.Size(90, 17)
        Me.rdoCID.TabIndex = 0
        Me.rdoCID.TabStop = True
        Me.rdoCID.Text = "Check Out ID"
        Me.rdoCID.UseVisualStyleBackColor = True
        '
        'rdoGN
        '
        Me.rdoGN.AutoSize = True
        Me.rdoGN.Location = New System.Drawing.Point(34, 65)
        Me.rdoGN.Name = "rdoGN"
        Me.rdoGN.Size = New System.Drawing.Size(84, 17)
        Me.rdoGN.TabIndex = 0
        Me.rdoGN.TabStop = True
        Me.rdoGN.Text = "Guest Name"
        Me.rdoGN.UseVisualStyleBackColor = True
        '
        'rdoRN
        '
        Me.rdoRN.AutoSize = True
        Me.rdoRN.Location = New System.Drawing.Point(34, 112)
        Me.rdoRN.Name = "rdoRN"
        Me.rdoRN.Size = New System.Drawing.Size(70, 17)
        Me.rdoRN.TabIndex = 0
        Me.rdoRN.TabStop = True
        Me.rdoRN.Text = "Room No"
        Me.rdoRN.UseVisualStyleBackColor = True
        '
        'rdoCD
        '
        Me.rdoCD.AutoSize = True
        Me.rdoCD.Location = New System.Drawing.Point(470, 26)
        Me.rdoCD.Name = "rdoCD"
        Me.rdoCD.Size = New System.Drawing.Size(102, 17)
        Me.rdoCD.TabIndex = 0
        Me.rdoCD.TabStop = True
        Me.rdoCD.Text = "Check Out Date"
        Me.rdoCD.UseVisualStyleBackColor = True
        '
        'rdobtw
        '
        Me.rdobtw.AutoSize = True
        Me.rdobtw.Location = New System.Drawing.Point(470, 65)
        Me.rdobtw.Name = "rdobtw"
        Me.rdobtw.Size = New System.Drawing.Size(147, 17)
        Me.rdobtw.TabIndex = 0
        Me.rdobtw.TabStop = True
        Me.rdobtw.Text = "Check Out Date Between"
        Me.rdobtw.UseVisualStyleBackColor = True
        '
        'cboCID
        '
        Me.cboCID.FormattingEnabled = True
        Me.cboCID.Location = New System.Drawing.Point(200, 25)
        Me.cboCID.Name = "cboCID"
        Me.cboCID.Size = New System.Drawing.Size(121, 21)
        Me.cboCID.TabIndex = 1
        '
        'cboGN
        '
        Me.cboGN.FormattingEnabled = True
        Me.cboGN.Location = New System.Drawing.Point(200, 64)
        Me.cboGN.Name = "cboGN"
        Me.cboGN.Size = New System.Drawing.Size(121, 21)
        Me.cboGN.TabIndex = 1
        '
        'cboRN
        '
        Me.cboRN.FormattingEnabled = True
        Me.cboRN.Location = New System.Drawing.Point(200, 111)
        Me.cboRN.Name = "cboRN"
        Me.cboRN.Size = New System.Drawing.Size(121, 21)
        Me.cboRN.TabIndex = 1
        '
        'dtpCD
        '
        Me.dtpCD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCD.Location = New System.Drawing.Point(653, 26)
        Me.dtpCD.Name = "dtpCD"
        Me.dtpCD.Size = New System.Drawing.Size(150, 20)
        Me.dtpCD.TabIndex = 2
        '
        'dtpfrom
        '
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(653, 62)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(150, 20)
        Me.dtpfrom.TabIndex = 2
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(43, 417)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "&Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnall
        '
        Me.btnall.Location = New System.Drawing.Point(169, 417)
        Me.btnall.Name = "btnall"
        Me.btnall.Size = New System.Drawing.Size(75, 23)
        Me.btnall.TabIndex = 4
        Me.btnall.Text = "Search&All"
        Me.btnall.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(308, 417)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 4
        Me.btnreport.Text = "&Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(553, 417)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'dtpto
        '
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(653, 99)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(150, 20)
        Me.dtpto.TabIndex = 2
        '
        'tbcheckout
        '
        Me.tbcheckout.Controls.Add(Me.tbP1)
        Me.tbcheckout.Controls.Add(Me.tbP2)
        Me.tbcheckout.Location = New System.Drawing.Point(34, 151)
        Me.tbcheckout.Name = "tbcheckout"
        Me.tbcheckout.SelectedIndex = 0
        Me.tbcheckout.Size = New System.Drawing.Size(779, 251)
        Me.tbcheckout.TabIndex = 5
        '
        'tbP1
        '
        Me.tbP1.Controls.Add(Me.dgvCheckout)
        Me.tbP1.Location = New System.Drawing.Point(4, 22)
        Me.tbP1.Name = "tbP1"
        Me.tbP1.Padding = New System.Windows.Forms.Padding(3)
        Me.tbP1.Size = New System.Drawing.Size(771, 225)
        Me.tbP1.TabIndex = 0
        Me.tbP1.Text = "Check Out View"
        Me.tbP1.UseVisualStyleBackColor = True
        '
        'dgvCheckout
        '
        Me.dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckout.Location = New System.Drawing.Point(1, 11)
        Me.dgvCheckout.Name = "dgvCheckout"
        Me.dgvCheckout.Size = New System.Drawing.Size(769, 203)
        Me.dgvCheckout.TabIndex = 4
        '
        'tbP2
        '
        Me.tbP2.Controls.Add(Me.dgvdetail)
        Me.tbP2.Location = New System.Drawing.Point(4, 22)
        Me.tbP2.Name = "tbP2"
        Me.tbP2.Padding = New System.Windows.Forms.Padding(3)
        Me.tbP2.Size = New System.Drawing.Size(771, 225)
        Me.tbP2.TabIndex = 1
        Me.tbP2.Text = "External Charges"
        Me.tbP2.UseVisualStyleBackColor = True
        '
        'dgvdetail
        '
        Me.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetail.Location = New System.Drawing.Point(1, 11)
        Me.dgvdetail.Name = "dgvdetail"
        Me.dgvdetail.Size = New System.Drawing.Size(769, 203)
        Me.dgvdetail.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Report &Detail"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckOutSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 463)
        Me.Controls.Add(Me.tbcheckout)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnall)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dtpto)
        Me.Controls.Add(Me.dtpfrom)
        Me.Controls.Add(Me.dtpCD)
        Me.Controls.Add(Me.cboRN)
        Me.Controls.Add(Me.cboGN)
        Me.Controls.Add(Me.cboCID)
        Me.Controls.Add(Me.rdobtw)
        Me.Controls.Add(Me.rdoCD)
        Me.Controls.Add(Me.rdoRN)
        Me.Controls.Add(Me.rdoGN)
        Me.Controls.Add(Me.rdoCID)
        Me.Name = "CheckOutSearch"
        Me.Text = "CheckOutSearch"
        Me.tbcheckout.ResumeLayout(False)
        Me.tbP1.ResumeLayout(False)
        CType(Me.dgvCheckout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbP2.ResumeLayout(False)
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoCID As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGN As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRN As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCD As System.Windows.Forms.RadioButton
    Friend WithEvents rdobtw As System.Windows.Forms.RadioButton
    Friend WithEvents cboCID As System.Windows.Forms.ComboBox
    Friend WithEvents cboGN As System.Windows.Forms.ComboBox
    Friend WithEvents cboRN As System.Windows.Forms.ComboBox
    Friend WithEvents dtpCD As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnall As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbcheckout As System.Windows.Forms.TabControl
    Friend WithEvents tbP1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvCheckout As System.Windows.Forms.DataGridView
    Friend WithEvents tbP2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvdetail As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
