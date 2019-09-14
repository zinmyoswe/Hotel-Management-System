Public Class frmroom
    Dim objroom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtroom As New DataTable
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
        FillAutoID()
        dtroom = objroom.GetData
        dgvRoom.DataSource = dtroom
        dgvRoom.Refresh()
    End Sub

    Private Sub frmroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class