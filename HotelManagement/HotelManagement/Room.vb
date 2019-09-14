Public Class Room
    Dim objroom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtroom As New DataTable

    Dim objtype As New dsHotelManagementTableAdapters.RoomTypeTableAdapter
    Dim dtroomty As New DataTable

    Public Sub FillAutoID()
        If objroom.GetData.Rows.Count > 0 Then
            txtRID.Text = Format(CInt(objroom.GetData.Rows(objroom.GetData.Rows.Count - 1).Item(0).ToString.Substring(2) + 1), "R-000000")
        Else
            txtRID.Text = "R-000001"

        End If
    End Sub
    Private Sub Clear_Value()
        txtRID.Text = ""
        txtRN.Text = ""
        cboRTYPE.Text = ""
        txtPRICE.Text = ""
        FillAutoID()
        dtroom = objroom.GetData
        dgvRoom.DataSource = dtroom
        dgvRoom.Refresh()
    End Sub
    Private Sub Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Value()
        cboRTYPE_Load()
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Clear_Value()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtRN.Text = "" Then
            MessageBox.Show("Please type Room No!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRN.Focus()
        ElseIf cboRTYPE.Text = "" Then
            MessageBox.Show("Please choice Room Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRTYPE.Focus()
        Else
            dtroom = objroom.GetData
            For i As Integer = 0 To dtroom.Rows.Count - 1
                If txtRID.Text.Equals(dtroom.Rows(i).Item("RoomID")) Then
                    MessageBox.Show("This room number is already exits.", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtRN.Focus()
                    Exit Sub
                End If

            Next

            objroom.Insert(txtRID.Text, txtRN.Text, cboRTYPE.Text, "A")
            MessageBox.Show("Room data save successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If dgvRoom.Rows.Count > 0 Then
            If txtRN.Text = "" Then
                MessageBox.Show("Please type Room No!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRN.Focus()
            ElseIf cboRTYPE.Text = "" Then
                MessageBox.Show("Please select Room Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboRTYPE.Focus()
            Else
                objroom.UpdateRoom(txtRN.Text, cboRTYPE.Text, "A", txtRID.Text)
                MessageBox.Show("Room data Update successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If dgvRoom.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objroom.DeleteRoom(txtRID.Text)
                MessageBox.Show("Room data Delete successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub dgvRoom_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoom.CellContentClick
        If dgvRoom.Rows.Count > 0 Then
            Dim rowindex = dgvRoom.CurrentRow.Index
            txtRID.Text = dgvRoom.Item(0, rowindex).Value.ToString
            txtRN.Text = dgvRoom.Item(1, rowindex).Value.ToString
            cboRTYPE.Text = dgvRoom.Item(2, rowindex).Value.ToString
        End If
    End Sub

    Private Sub cboRTYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRTYPE.SelectedIndexChanged
        dtroomty = objtype.GetData
        For i As Integer = 0 To dtroomty.Rows.Count - 1
            If dtroomty.Rows(i).Item("RoomTypeID") = cboRTYPE.Text Then
                txtPRICE.Text = dtroomty.Rows(i).Item("Price")
            End If
        Next
    End Sub
    Private Sub cboRTYPE_Load()
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
End Class