Public Class frmreservationcheckIn

    Dim objguest As New dsHotelManagementTableAdapters.GuestTableAdapter
    Dim dtguest As DataTable

    Dim objroom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtroom As DataTable

    Dim objtype As New dsHotelManagementTableAdapters.RoomTypeTableAdapter
    Dim dtroomty As New DataTable

    Dim objreservation As New dsHotelManagementTableAdapters.ReservationTableAdapter
    Dim dtreservation As New DataTable

    Dim objreservationcheckin As New dsHotelManagementTableAdapters.CheckInTableAdapter
    Dim dtreservationcheckin As New DataTable

    Dim objdetail As New dsHotelManagementTableAdapters.DetailTableAdapter
    Dim dtdetail As New DataTable

    Dim dt As New DataTable
    Dim dr As DataRow

    Public Sub FillAutoID()
        If objreservationcheckin.GetData.Rows.Count > 0 Then
            txtCINID.Text = Format(CInt(objreservationcheckin.GetData.Rows(objreservationcheckin.GetData.Rows.Count - 1).Item(0).ToString.Substring(6) + 1), "CINID-000000")
        Else
            txtCINID.Text = "CINID-000001"
        End If
    End Sub

    Private Sub Clear_Value()
        txtCINID.Text = ""
        dtpCInDATE.Text = Date.Today
        txtCInTime.Text = TimeOfDay
        cboRESID.Text = ""
        txtGN.Text = ""
        txtQty.Text = "0"
        lstroom.Items.Clear()
        FillAutoID()
        dtreservationcheckin = objreservationcheckin.GetData
        dgvCIn.DataSource = dtreservationcheckin
        dgvCIn.Refresh()
    End Sub


    Private Sub cboRESID_Load()
        dtreservation = objreservation.GetData
        cboRESID.Items.Clear()
        For i As Integer = 0 To dtreservation.Rows.Count - 1
            If dtreservation.Rows.Count > 0 Then
                If dtreservation.Rows(i).Item("Status") = "R" Then
                    cboRESID.Items.Add(dtreservation.Rows(i).Item("ReservationID").ToString)
                End If
            End If
        Next
        cboRESID.Items.Insert(0, "Select")
        cboRESID.SelectedIndex = 0
    End Sub
    Private Sub frmreservationcheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Value()
        cboRESID_Load()
    End Sub
    Public Sub roomno_load()
        dtdetail = objdetail.GetData
        dtroom = objroom.GetData
        lstroom.Items.Clear()
        For i As Integer = 0 To dtdetail.Rows.Count - 1
            If dtdetail.Rows(i).Item("ReservationID").ToString = cboRESID.SelectedItem.ToString Then

                For r As Integer = 0 To dtroom.Rows.Count - 1
                    If dtroom.Rows(r).Item("RoomID").ToString = dtdetail.Rows(i).Item("RoomID") Then
                        lstroom.Items.Add(dtroom.Rows(r).Item("RoomNo"))
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub cboRESID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRESID.SelectedIndexChanged
        dtreservation = objreservation.GetData
        dtguest = objguest.GetData
        For i As Integer = 0 To dtreservation.Rows.Count - 1
            If dtreservation.Rows(i).Item("ReservationID").ToString = cboRESID.SelectedItem.ToString Then
                txtQty.Text = dtreservation.Rows(i).Item("TotalRoom")
                For c As Integer = 0 To dtguest.Rows.Count - 1
                    If dtguest.Rows(c).Item("GuestID").ToString = dtreservation.Rows(i).Item("GuestID").ToString Then
                        txtGN.Text = dtguest.Rows(c).Item("GuestName")
                    End If
                Next
            End If

        Next
        roomno_load()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cboRESID.SelectedIndex = 0 Then
            MessageBox.Show("Please select ReservationID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRESID.Focus()
        Else
            dtroom = objroom.GetData
            Dim roomno As String = ""
            For r As Integer = 0 To dtroom.Rows.Count - 1
                For i As Integer = 0 To lstroom.Items.Count - 1
                    If dtroom.Rows(r).Item("RoomNo") = lstroom.Items.Item(i) Then
                        objroom.UpdateStatus("C", dtroom.Rows(r).Item("RoomID"))
                        If roomno = "" Then
                            roomno = lstroom.Items.Item(i)
                        Else
                            roomno = roomno + "+" + lstroom.Items.Item(i)
                        End If
                    End If
                Next
            Next

            objreservationcheckin.Insert(txtCINID.Text, dtpCInDATE.Text, txtCInTime.Text, cboRESID.Text, txtGN.Text, txtQty.Text, roomno)
            objreservation.UpdateQuery("C", cboRESID.SelectedItem.ToString)

            MessageBox.Show("CheckIn information is successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvCIn.DataSource = objreservationcheckin.GetData
            dgvCIn.Refresh()
            Clear_Value()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dispose()
    End Sub
End Class

