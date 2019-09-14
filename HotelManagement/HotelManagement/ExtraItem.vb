Public Class ExtraItem
    Dim objextra As New dsHotelManagementTableAdapters.ExtraItemTableAdapter
    Dim dtextra As New DataTable
    Public Sub FillAutoID()
        If objextra.GetData.Rows.Count > 0 Then
            txtextraID.Text = Format(CInt(objextra.GetData.Rows(objextra.GetData.Rows.Count - 1).Item(0).ToString.Substring(5) + 1), "EIID-000000")
        Else
            txtextraID.Text = "EIID-000001"

        End If
    End Sub
    Private Sub Clear_Value()
        txtextraID.Text = ""
        cboextraType.SelectedIndex = 0
        txtextraPRICE.Text = ""
        FillAutoID()
        dtextra = objextra.GetData
        dgvextra.DataSource = dtextra
        dgvextra.Refresh()
    End Sub
    Private Sub ExtraItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Value()
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Clear_Value()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If dgvextra.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objextra.DeleteExtra(txtextraID.Text)
                MessageBox.Show("ExtraItem data Delete successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If dgvextra.Rows.Count > 0 Then
        ElseIf cboextraType.Text = "" Then
            MessageBox.Show("Please select ExtraItem Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboextraType.Focus()
        Else
            objextra.UpdateExtra(cboextraType.Text, txtextraPRICE.Text, txtextraID.Text)
            MessageBox.Show("ExtraItem data Update successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
       
        If cboextraType.Text = "" Then
            MessageBox.Show("Please choice ExtraItem Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboextraType.Focus()
        Else
            dtextra = objextra.GetData
            For i As Integer = 0 To dtextra.Rows.Count - 1
                If txtextraID.Text.Equals(dtextra.Rows(i).Item("ExtraItemID")) Then
                    MessageBox.Show("This ExtraItem Type is already exits.", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboextraType.Focus()
                    Exit Sub
                End If

            Next

            objextra.Insert(txtextraID.Text, cboextraType.Text, txtextraPRICE.Text)
            MessageBox.Show("ExtraItem data save successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()

        End If
    End Sub

    Private Sub dgvextra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvextra.CellContentClick
        If dgvextra.Rows.Count > 0 Then
            Dim rowindex = dgvextra.CurrentRow.Index
            txtextraID.Text = dgvextra.Item(0, rowindex).Value.ToString
            cboextraType.Text = dgvextra.Item(1, rowindex).Value.ToString
            txtextraPRICE.Text = dgvextra.Item(2, rowindex).Value.ToString
        End If
    End Sub
End Class