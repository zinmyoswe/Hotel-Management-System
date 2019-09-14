Public Class Reservation
    Dim objguest As New dsHotelManagementTableAdapters.GuestTableAdapter
    Dim dtguest As DataTable

    Dim objroom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtroom As New DataTable

    Dim objreservation As New dsHotelManagementTableAdapters.ReservationTableAdapter
    Dim dtreservation As New DataTable

    Dim objdetail As New dsHotelManagementTableAdapters.DetailTableAdapter
    Dim dtdetail As New DataTable

    Dim objtype As New dsHotelManagementTableAdapters.RoomTypeTableAdapter
    Dim dtroomty As New DataTable

    Dim dt As New DataTable
    Dim dr As DataRow

    Public Sub FillAutoID()
        If objreservation.GetData.Rows.Count > 0 Then
            txtResID.Text = Format(CInt(objreservation.GetData.Rows(objreservation.GetData.Rows.Count - 1).Item(0).ToString.Substring(4) + 1), "RES-000000")
        Else
            txtResID.Text = "RES-000001"
        End If
    End Sub

    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillAutoID()
        Detail()
        Clear_Value()
        cboGuestID_Load()
        cboRoomType_Load()
    End Sub
    Private Sub Clear_Value()
        cboGID.Text = ""
        txtGN.Text = ""
        txtGTOTAL.Text = "0"
        txtResID.Text = ""
        dtptime.Text = TimeOfDay
        dtpDDATE.Text = Date.Today.AddDays(2)
        cboRTYPE.Text = ""
        cboRN.Text = ""
        txtQty.Text = "0"
        txtPRICE.Text = ""
        dtpRESDATE.Text = Date.Today
        txtTotalamt.Text = "0"
        FillAutoID()
        dtreservation = objreservation.GetData
        dgvRES.DataSource = dtreservation
        dgvRES.Refresh()
    End Sub

    Private Sub cboGuestID_Load()
        dtguest = objguest.GetData
        cboGID.Items.Clear()
        For i As Integer = 0 To dtguest.Rows.Count - 1
            If dtguest.Rows.Count > 0 Then
                cboGID.Items.Add(dtguest.Rows(i).Item("GuestID").ToString)
            End If
        Next
        cboGID.Items.Insert(0, "Select")
        cboGID.SelectedIndex = 0
    End Sub
    Private Sub cboRoomID_Load()
        dtroom = objroom.GetData
        cboRN.Items.Clear()
        For i As Integer = 0 To dtroom.Rows.Count - 1
            If dtroom.Rows.Count > 0 Then

                If dtroom.Rows(i).Item("RoomTypeID") = cboRTYPE.SelectedItem.ToString And dtroom.Rows(i).Item("Status") = "A" Then
                    cboRN.Items.Add(dtroom.Rows(i).Item("RoomID").ToString)
                End If
            End If
        Next
        cboRN.Items.Insert(0, "Select")
        cboRN.SelectedIndex = 0
    End Sub
    Private Sub cboRoomType_Load()
        dtroomty = objtype.GetData
        cboRTYPE.Items.Clear()
        For i As Integer = 0 To dtroomty.Rows.Count - 1
            If dtroomty.Rows.Count > 0 Then
                cboRTYPE.Items.Add(dtroomty.Rows(i).Item("RoomTypeID").ToString)
            End If
        Next
        cboRTYPE.Items.Insert(0, "Select")
        cboRTYPE.SelectedIndex = 0
    End Sub
    Private Sub calculation()
        Dim total As Integer
        For i As Integer = 0 To dt.Rows.Count - 1
            total += CInt(dt.Rows(i).Item("Price"))
        Next
        txtTotalamt.Text = total

        Dim Qty As Integer = dt.Rows.Count
        txtQty.Text = Qty

    End Sub
    Private Sub cboGID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGID.SelectedIndexChanged
        dtguest = objguest.GetData
        For i As Integer = 0 To dtguest.Rows.Count - 1
            If dtguest.Rows(i).Item("GuestID").ToString = cboGID.SelectedItem.ToString Then
                txtGN.Text = dtguest.Rows(i).Item("GuestName")
            End If
        Next
    End Sub
    Public Sub Detail()
        dt.Columns.Clear()
        dr = dt.NewRow
        dr.Table.Columns.Add("RoomNo")
        dr.Table.Columns.Add("Price")
        dt.Rows.Add(dr)
        dt.Rows.Clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dispose()
    End Sub
    Private Sub cboRTYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRTYPE.SelectedIndexChanged
        cboRoomID_Load()
        dtroomty = objtype.GetData
        For i As Integer = 0 To dtroomty.Rows.Count - 1
            If dtroomty.Rows(i).Item("RoomTypeID") = cboRTYPE.Text Then
                txtPRICE.Text = dtroomty.Rows(i).Item("Price")
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cboRN.SelectedIndex = 0 Then
            MessageBox.Show("Please select RoomType", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRN.Focus()
        ElseIf cboRN.SelectedIndex = 0 Then
            MessageBox.Show("Please select RoomType", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRN.Focus()
        ElseIf cboRTYPE.SelectedIndex = 0 Then
            MessageBox.Show("Please select RoomType", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRN.Focus()
        ElseIf cboRTYPE.SelectedIndex = 0 Then
            MessageBox.Show("Please select RoomType", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRTYPE.Focus()

        ElseIf cboGID.SelectedIndex = 0 Then
            MessageBox.Show("Please select GuestID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRN.Focus()
        ElseIf cboGID.SelectedIndex = 0 Then
            MessageBox.Show("Please select GuestID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboGID.Focus()
        Else
            For i As Integer = 0 To dt.Rows.Count - 1
                If cboRN.Text = dt.Rows(i).Item("RoomNo") Then
                    MessageBox.Show("Please select another", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            dr = dt.NewRow
            dr(0) = cboRN.Text
            dr(1) = txtPRICE.Text
            dt.Rows.Add(dr)
            dgvRES.Refresh()
            dgvRES.DataSource = dt
            calculation()
        End If
    End Sub

    Private Sub txtPRICE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPRICE.TextChanged

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cboGID.SelectedIndex = 0 Then
            MessageBox.Show("Please select GuestID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboGID.Focus()

        Else
            objreservation.Insert(txtResID.Text, dtpRESDATE.Text, dtptime.Text, dtpDDATE.Text, "R", cboGID.Text, CInt(txtQty.Text), CInt(txtTotalamt.Text), CInt(txtGTOTAL.Text))
            For i As Integer = 0 To dt.Rows.Count - 1
                objdetail.Insert(dt.Rows(i).Item("RoomNo"), txtResID.Text)
                objroom.UpdateStatus("R", dt.Rows(i).Item("RoomNo"))
            Next
            MessageBox.Show("Reserve information is successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvRES.DataSource = objreservation.GetData
            dgvRES.Refresh()
            Clear_Value()
        End If
    End Sub

    Private Sub txtResID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResID.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If dgvRES.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objreservation.Delete1(txtResID.Text)
                MessageBox.Show("Room data Delete successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If
        End If
    End Sub

    Private Sub dgvRES_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRES.CellContentClick
        If dgvRES.Rows.Count > 0 Then
            Dim rowindex = dgvRES.CurrentRow.Index
            txtResID.Text = dgvRES.Item(0, rowindex).Value.ToString
            dtpRESDATE.Text = dgvRES.Item(1, rowindex).Value.ToString
            dtptime.Text = dgvRES.Item(2, rowindex).Value.ToString
        End If
    End Sub

    Private Sub Button1_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Button1.ControlAdded

    End Sub
End Class

