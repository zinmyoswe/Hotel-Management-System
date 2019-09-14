Public Class CheckOut
    Dim objguest As New dsHotelManagementTableAdapters.GuestTableAdapter
    Dim dtguest As DataTable

    Dim objreservation As New dsHotelManagementTableAdapters.ReservationTableAdapter
    Dim dtreservation As New DataTable

    Dim objfrmreservationcheckin As New dsHotelManagementTableAdapters.CheckInTableAdapter
    Dim dtfrmreservationcheckin As New DataTable

    Dim objdetail As New dsHotelManagementTableAdapters.DetailTableAdapter
    Dim dtdetail As New DataTable

    Dim objcheckout As New dsHotelManagementTableAdapters.CheckOutTableAdapter
    Dim dtcheckout As New DataTable

    Dim objroom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtroom As New DataTable

    Dim objorder As New dsHotelManagementTableAdapters.OrderfoodanddrinkTableAdapter
    Dim dtorder As New DataTable

    Dim dt As New DataTable
    Dim dr As DataRow

    Dim objexternal As New dsHotelManagementTableAdapters.orderdetailviewTableAdapter
    Dim dtexternal As New DataTable
    Public Sub FillAutoID()
        If objcheckout.GetData.Rows.Count > 0 Then
            txtCOUTID.Text = Format(CInt(objcheckout.GetData.Rows(objcheckout.GetData.Rows.Count - 1).Item(0).ToString.Substring(7) + 1), "COUTID-000000")
        Else
            txtCOUTID.Text = "COUTID-000001"
        End If
    End Sub
  
    Private Sub Clear_Value()
        txtCOUTID.Text = ""
        dtpCOutDATE.Text = Date.Today
        dtpCOutDATE.Enabled = False
        txtCOutTime.Text = TimeOfDay
        txtCOutTime.Enabled = False
        cboRN.Text = ""
        txtGN.Text = ""
        txtcheckindate.Text = ""
        txtcheckintime.Text = ""
        txtNOD.Text = "0"
        txtPRICE.Text = "0"
        txtTC.Text = "0"
        txtOC.Text = "0"
        txtST.Text = "0"
        txtDis.Text = "0"
        txtT.Text = "0"
        txtAP.Text = "0"
        txtChanging.Text = "0"
        FillAutoID()
        dtcheckout = objcheckout.GetData
        dgvexternal.DataSource = dtcheckout
        dgvexternal.Refresh()
    End Sub
    Private Sub CheckOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillAutoID()
        Clear_Value()
        cboRoomNo_Load()
        Detail()
    End Sub
    Public Sub Detail()
        dt.Columns.Clear()
        dr = dt.NewRow
        dr.Table.Columns.Add("OrderID")
        dr.Table.Columns.Add("OrderDate")
        dr.Table.Columns.Add("OrderName")
        dr.Table.Columns.Add("Quantity")
        dr.Table.Columns.Add("Amount")
        dt.Rows.Add(dr)
        dt.Rows.Clear()
    End Sub
    Private Sub cboRoomNo_Load()
        dtroom = objroom.GetData
        cboRN.Items.Clear()

        For i As Integer = 0 To dtroom.Rows.Count - 1
            If dtroom.Rows.Count > 0 Then
                If dtroom.Rows(i).Item("Status").ToString.Equals("C") Then
                    cboRN.Items.Add(dtroom.Rows(i).Item("RoomNo").ToString)
                End If
            End If
        Next
        cboRN.Items.Insert(0, "Select")
        cboRN.SelectedIndex = 0

    End Sub
    Private Sub cboRN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRN.SelectedIndexChanged
        If cboRN.SelectedIndex = 0 Then
            cboRN.SelectedIndex = 0
        ElseIf cboRN.SelectedIndex > 0 Then
            Dim RID As String
            dtroom = objroom.GetDataBy_RoomNo(cboRN.SelectedItem.ToString)
            RID = dtroom.Rows(0).Item("RoomID").ToString
            txtRID.Text = RID
            dtfrmreservationcheckin = objfrmreservationcheckin.GetDataBy_RoomID(RID)
            For i As Integer = 0 To dtfrmreservationcheckin.Rows.Count - 1

                txtGN.Text = dtfrmreservationcheckin.Rows(i).Item("GuestName")
                txtcheckindate.Text = dtfrmreservationcheckin.Rows(i).Item("CheckInDate")
                txtPRICE.Text = dtfrmreservationcheckin.Rows(i).Item("Price")
                txtTC.Text = dtfrmreservationcheckin.Rows(i).Item("Price") * txtNOD.Text
                txtST.Text = dtfrmreservationcheckin.Rows(i).Item("Price") * txtNOD.Text
                txtT.Text = dtfrmreservationcheckin.Rows(i).Item("Price") * txtNOD.Text
                txtcheckintime.Text = dtfrmreservationcheckin.Rows(i).Item("CheckInTime")
            Next

            dtexternal = objexternal.GetDataBy_RNo(cboRN.SelectedItem.ToString, "Remain")
            For i As Integer = 0 To dtexternal.Rows.Count - 1
                dr = dt.NewRow
                dr(0) = dtexternal.Rows(i).Item("OrderID")
                dr(1) = dtexternal.Rows(i).Item("OrderDate")
                dr(2) = dtexternal.Rows(i).Item("orderName")
                dr(3) = dtexternal.Rows(i).Item("Quantity")
                dr(4) = dtexternal.Rows(i).Item("Amount")
                dt.Rows.Add(dr)
            Next
            dgvexternal.Refresh()
            dgvexternal.DataSource = dt
            calculation()
        End If
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub txtcheckindate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcheckindate.TextChanged
        If txtcheckindate.Text = "" Then
            txtNOD.Text = 0
        Else
            Dim CheckinDate As Date = txtcheckindate.Text
            Dim CheckoutDate As Date = Date.Today
            txtNOD.Text = DateDiff(DateInterval.Day, CheckinDate, CheckoutDate)
        End If
    End Sub
    Private Sub calculation()
        Dim total As Integer
        For i As Integer = 0 To dtexternal.Rows.Count - 1
            total += CInt(dtexternal.Rows(i).Item("Amount"))
        Next
        txtOC.Text = total
    End Sub
    Private Sub txtOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOC.TextChanged
        If txtOC.Text = 0 Then
            txtST.Text = 0
        Else
            txtST.Text = CInt(txtOC.Text) + CInt(txtTC.Text)
        End If
    End Sub

    

    Private Sub txtST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtST.TextChanged
        txtT.Text = CInt(txtOC.Text) + CInt(txtTC.Text)
    End Sub

    Private Sub txtAP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAP.TextChanged
        If txtAP.Text = 0 Then
            txtChanging.Text = 0
        Else
            txtChanging.Text = CInt(txtAP.Text) - CInt(txtT.Text)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If txtT.Text = 0 Then
            MessageBox.Show("Please type Total Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtT.Focus()
        Else
            objroom.UpdateStatus("A", txtRID.Text)
            objcheckout.Insert(txtCOUTID.Text, dtpCOutDATE.Text, txtCOutTime.Text, cboRN.SelectedItem.ToString, txtGN.Text, txtcheckindate.Text, txtNOD.Text, txtTC.Text, txtOC.Text, txtDis.Text, txtT.Text)

            For i As Integer = 0 To dt.Rows.Count - 1
                objorder.UpdateStatus("Paid", dt.Rows(i).Item("OrderID"))
            Next

            MessageBox.Show("Check Out successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()
        End If
    End Sub

   

    
    Private Sub txtDis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDis.TextChanged
        If txtDis.Text = 0 Then
            txtT.Text = CInt(txtOC.Text) + CInt(txtTC.Text)
        Else
            txtT.Text = CInt(txtST.Text) - CInt(txtDis.Text)
        End If
    End Sub
End Class