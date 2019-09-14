Public Class RentItem
    Dim objrent As New dsHotelManagementTableAdapters.RentItemTableAdapter
    Dim dtrent As DataTable

    Dim objextra As New dsHotelManagementTableAdapters.ExtraItemTableAdapter
    Dim dtextra As New DataTable
    Public Sub FillAutoID()
        If objrent.GetData.Rows.Count > 0 Then
            txtrentID.Text = Format(CInt(objrent.GetData.Rows(objrent.GetData.Rows.Count - 1).Item(0).ToString.Substring(4) + 1), "RIID-000000")
        Else
            txtrentID.Text = "RIID-000001"
        End If
    End Sub
    Private Sub Clear_Value()
        cboextraID.Text = ""
        txtextraType.Text = ""
        txtextraPRICE.Text = "0"
        txtrentID.Text = ""
        dtprentDATE.Text = Date.Today
        txtRN.Text = ""
        txtrentQty.Text = "0"
        txtrentnight.Text = "0"
        txtrentamt.Text = "0"
        FillAutoID()
        dtrent = objrent.GetData
        dgvrent.DataSource = dtrent
        dgvrent.Refresh()
    End Sub
    Private Sub cboextraID_Load()
        dtextra = objextra.GetData
        cboextraID.Items.Clear()
        For i As Integer = 0 To dtextra.Rows.Count - 1
            If dtextra.Rows.Count > 0 Then
                cboextraID.Items.Add(dtextra.Rows(i).Item("ExtraItemID").ToString)
            End If
        Next
        cboextraID.Items.Insert(0, "Select")
        cboextraID.SelectedIndex = 0
    End Sub

    Private Sub RentItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Value()
        cboextraID_Load()
    End Sub

    Private Sub ExtramIteminfo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtramIteminfo.Enter, RentItemInfo.Enter, GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label6.Click, Label4.Click, Label7.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        
    End Sub

    Private Sub dgvrent_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvrent.CellContentClick
        If dgvrent.Rows.Count > 0 Then
            Dim rowindex = dgvrent.CurrentRow.Index
            txtrentID.Text = dgvrent.Item(0, rowindex).Value.ToString
            dtprentDATE.Text = dgvrent.Item(1, rowindex).Value.ToString

        End If
    End Sub

    Private Sub cboextraID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboextraID.SelectedIndexChanged
        dtextra = objextra.GetData
        For i As Integer = 0 To dtextra.Rows.Count - 1
            If dtextra.Rows(i).Item("ExtraItemID").ToString = cboextraID.SelectedItem.ToString Then
                txtextraType.Text = dtextra.Rows(i).Item("ExtraItemType")
                txtextraPRICE.Text = dtextra.Rows(i).Item("Price")
            End If
        Next
    End Sub
End Class