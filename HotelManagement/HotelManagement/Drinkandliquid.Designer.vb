<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Drinkandliquid
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
        Me.cbodrinkType = New System.Windows.Forms.ComboBox
        Me.dgvdrink = New System.Windows.Forms.DataGridView
        Me.txtdrinkPRICE = New System.Windows.Forms.TextBox
        Me.txtdrinkN = New System.Windows.Forms.TextBox
        Me.txtdrinkID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.txtdrinktypeID = New System.Windows.Forms.TextBox
        CType(Me.dgvdrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbodrinkType
        '
        Me.cbodrinkType.FormattingEnabled = True
        Me.cbodrinkType.Location = New System.Drawing.Point(151, 97)
        Me.cbodrinkType.Name = "cbodrinkType"
        Me.cbodrinkType.Size = New System.Drawing.Size(95, 21)
        Me.cbodrinkType.TabIndex = 39
        '
        'dgvdrink
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdrink.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdrink.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdrink.Location = New System.Drawing.Point(286, 44)
        Me.dgvdrink.Name = "dgvdrink"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdrink.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdrink.Size = New System.Drawing.Size(472, 188)
        Me.dgvdrink.TabIndex = 38
        '
        'txtdrinkPRICE
        '
        Me.txtdrinkPRICE.Location = New System.Drawing.Point(151, 186)
        Me.txtdrinkPRICE.Name = "txtdrinkPRICE"
        Me.txtdrinkPRICE.Size = New System.Drawing.Size(100, 20)
        Me.txtdrinkPRICE.TabIndex = 32
        '
        'txtdrinkN
        '
        Me.txtdrinkN.Location = New System.Drawing.Point(151, 133)
        Me.txtdrinkN.Name = "txtdrinkN"
        Me.txtdrinkN.Size = New System.Drawing.Size(100, 20)
        Me.txtdrinkN.TabIndex = 31
        '
        'txtdrinkID
        '
        Me.txtdrinkID.Location = New System.Drawing.Point(151, 55)
        Me.txtdrinkID.Name = "txtdrinkID"
        Me.txtdrinkID.Size = New System.Drawing.Size(100, 20)
        Me.txtdrinkID.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "DrinkandliquidType"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "DrinkandliquidName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "DrinkandliquidID"
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(421, 288)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 37
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(322, 288)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 36
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(227, 288)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 35
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(41, 288)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 33
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(136, 288)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 34
        Me.btnnew.Text = "&New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'txtdrinktypeID
        '
        Me.txtdrinktypeID.Location = New System.Drawing.Point(151, 29)
        Me.txtdrinktypeID.Name = "txtdrinktypeID"
        Me.txtdrinktypeID.Size = New System.Drawing.Size(100, 20)
        Me.txtdrinktypeID.TabIndex = 40
        Me.txtdrinktypeID.Visible = False
        '
        'Drinkandliquid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HotelManagement.My.Resources.Resources.Studio_20160207_125345
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 346)
        Me.Controls.Add(Me.txtdrinktypeID)
        Me.Controls.Add(Me.cbodrinkType)
        Me.Controls.Add(Me.dgvdrink)
        Me.Controls.Add(Me.txtdrinkPRICE)
        Me.Controls.Add(Me.txtdrinkN)
        Me.Controls.Add(Me.txtdrinkID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.DoubleBuffered = True
        Me.Name = "Drinkandliquid"
        Me.Text = "Drinkandliquid"
        CType(Me.dgvdrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbodrinkType As System.Windows.Forms.ComboBox
    Friend WithEvents dgvdrink As System.Windows.Forms.DataGridView
    Friend WithEvents txtdrinkPRICE As System.Windows.Forms.TextBox
    Friend WithEvents txtdrinkN As System.Windows.Forms.TextBox
    Friend WithEvents txtdrinkID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents txtdrinktypeID As System.Windows.Forms.TextBox
End Class
