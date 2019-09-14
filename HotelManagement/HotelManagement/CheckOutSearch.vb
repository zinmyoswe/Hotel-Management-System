Public Class CheckOutSearch
    Dim objRoom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtRoom As New DataTable

    Dim objGuest As New dsHotelManagementTableAdapters.GuestTableAdapter
    Dim dtGuest As New DataTable

    Dim objCheckout As New dsHotelManagementTableAdapters.CheckOutTableAdapter
    Dim dtCheckout As New DataTable

    Dim objexternal As New dsHotelManagementTableAdapters.orderdetailviewTableAdapter
    Dim dtexternal As New DataTable

    Dim dt As New DataTable
    Private Sub rdoCID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCID.CheckedChanged
        cboCID.Items.Clear()
        dtCheckout = objCheckout.GetData

        For i As Integer = 0 To dtCheckout.Rows.Count - 1
            cboCID.Items.Add(dtCheckout.Rows(i).Item(0))
        Next
        cboCID.Items.Insert(0, "Select")
        cboCID.SelectedIndex = 0

        cboGN.Items.Clear()
        cboGN.Text = ""
        cboRN.Items.Clear()
        cboRN.Text = ""
        dtpCD.Enabled = False
        dtpfrom.Enabled = False
        dtpto.Enabled = False
    End Sub

    Private Sub rdoGN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoGN.CheckedChanged
        cboGN.Items.Clear()
        dtGuest = objGuest.GetData

        For i As Integer = 0 To dtGuest.Rows.Count - 1
            cboGN.Items.Add(dtGuest.Rows(i).Item("GuestName"))
        Next
        cboGN.Items.Insert(0, "Select")
        cboGN.SelectedIndex = 0

        cboCID.Items.Clear()
        cboCID.Text = ""
        cboRN.Items.Clear()
        cboRN.Text = ""
        dtpCD.Enabled = False
        dtpfrom.Enabled = False
        dtpto.Enabled = False
    End Sub

    Private Sub rdoRN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRN.CheckedChanged
        cboRN.Items.Clear()
        dtRoom = objRoom.GetData

        For i As Integer = 0 To dtRoom.Rows.Count - 1
            cboRN.Items.Add(dtRoom.Rows(i).Item("RoomNo"))
        Next
        cboRN.Items.Insert(0, "Select")
        cboRN.SelectedIndex = 0

        cboCID.Items.Clear()
        cboCID.Text = ""
        cboGN.Items.Clear()
        cboGN.Text = ""
        dtpCD.Enabled = False
        dtpfrom.Enabled = False
        dtpto.Enabled = False
    End Sub

    Private Sub rdoCD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCD.CheckedChanged
        cboCID.Items.Clear()
        cboCID.Text = ""
        cboGN.Items.Clear()
        cboGN.Text = ""
        cboRN.Items.Clear()
        cboRN.Text = ""
        dtpCD.Enabled = True
        dtpfrom.Enabled = False
        dtpto.Enabled = False
    End Sub

    Private Sub rdobtw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdobtw.CheckedChanged
        cboCID.Items.Clear()
        cboCID.Text = ""
        cboGN.Items.Clear()
        cboGN.Text = ""
        cboRN.Items.Clear()
        cboRN.Text = ""
        dtpCD.Enabled = False
        dtpfrom.Enabled = True
        dtpto.Enabled = True
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If rdoCID.Checked = True Then
            If cboCID.SelectedIndex = 0 Then
                MessageBox.Show("Please select Checkout ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                dt = objCheckout.GetDataBy_CID(cboCID.Text)
                dgvCheckout.DataSource = dt
            End If
        End If

        If rdoGN.Checked = True Then
            If cboGN.SelectedIndex = 0 Then
                MessageBox.Show("Please select Guest name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                dt = objCheckout.GetDataBy_GN(cboGN.Text)
                dgvCheckout.DataSource = dt
            End If
        End If

        If rdoRN.Checked = True Then
            If cboRN.SelectedIndex = 0 Then
                MessageBox.Show("Please select Room no", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                dt = objCheckout.GetDataBy_RN(cboRN.Text)
                dgvCheckout.DataSource = dt
                dtexternal = objexternal.GetDataBy_RN(cboRN.Text)
                dgvdetail.DataSource = dtexternal
            End If
        End If

        If rdoCD.Checked = True Then
            dt = objCheckout.GetDataBy_CDate(dtpCD.Value.Date)
            dgvCheckout.DataSource = dt
        End If

        If rdobtw.Checked = True Then
            dt = objCheckout.GetDataBy_DBtw(dtpto.Value.Date, dtpfrom.Value.Date)
            dgvCheckout.DataSource = dt
        End If
    End Sub

    Private Sub btnall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnall.Click
        dt = objCheckout.GetData
        dgvCheckout.DataSource = dt
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        If dgvCheckout.RowCount > 0 Then
            Dim objreport As New crvCheckOut
            Dim Report_Viewer As New ReportViewer
            objreport.SetDataSource(dt)
            Report_Viewer.reportview.ReportSource = objreport
            Report_Viewer.reportview.Refresh()
            Report_Viewer.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dgvdetail.RowCount > 0 Then
            Dim objreport As New crvexternal
            Dim Report_Viewer As New ReportViewer
            objreport.SetDataSource(dtexternal)
            Report_Viewer.reportview.ReportSource = objreport
            Report_Viewer.reportview.Refresh()
            Report_Viewer.ShowDialog()
        End If
    End Sub
End Class