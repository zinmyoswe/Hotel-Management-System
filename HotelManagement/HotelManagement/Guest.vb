Public Class Guest
    Dim objguest As New dsHotelManagementTableAdapters.GuestTableAdapter
    Dim dtguest As New DataTable
    Public Sub FillAutoID()
        If objguest.GetData.Rows.Count > 0 Then
            txtGID.Text = Format(CInt(objguest.GetData.Rows(objguest.GetData.Rows.Count - 1).Item(0).ToString.Substring(2) + 1), "G-000000")
        Else
            txtGID.Text = "G-000001"
        End If
    End Sub
    Private Sub Clear_Value()
        txtGID.Text = ""
        txtGN.Text = ""
        txtGadd.Text = ""
        txtNRC.Text = ""
        FillAutoID()
        dtguest = objguest.GetData
        dgvGuest.DataSource = dtguest
        dgvGuest.Refresh()
    End Sub
    Private Sub Guest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Value()
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Clear_Value()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtGN.Text = "" Then
            MessageBox.Show("Please type Guest Name!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGN.Focus()
        ElseIf txtNRC.Text = "" Then
            MessageBox.Show("Please type NRC", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNRC.Focus()
        Else
            objguest.Insert(txtGID.Text, txtGN.Text, txtNRC.Text, txtGadd.Text)
            MessageBox.Show("Guest data save successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If dgvGuest.Rows.Count > 0 Then
            If txtGN.Text = "" Then
                MessageBox.Show("Please type Guest Name!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtGN.Focus()
            ElseIf txtNRC.Text = "" Then
                MessageBox.Show("Please type NRC", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNRC.Focus()
            Else
                objguest.UpdateGuest(txtGN.Text, txtNRC.Text, txtGadd.Text, txtGID.Text)
                MessageBox.Show("Guest data Update successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If dgvGuest.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objguest.DeleteGuest(txtGID.Text)
                MessageBox.Show("Guest data Delete successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub dgvGuest_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGuest.CellContentClick
        If dgvGuest.Rows.Count > 0 Then
            Dim rowindex = dgvGuest.CurrentRow.Index
            txtGID.Text = dgvGuest.Item(0, rowindex).Value.ToString
            txtGN.Text = dgvGuest.Item(1, rowindex).Value.ToString
            txtNRC.Text = dgvGuest.Item(2, rowindex).Value.ToString
            txtGadd.Text = dgvGuest.Item(3, rowindex).Value.ToString
        End If
    End Sub
End Class
