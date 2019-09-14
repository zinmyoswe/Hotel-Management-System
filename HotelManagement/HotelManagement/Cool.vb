Public Class Cool
    Dim objcool As New dsHotelManagementTableAdapters.CoolTableAdapter
    Dim dtcool As New DataTable

    Public Sub FillAutoID()
        If objcool.GetData.Rows.Count > 0 Then
            txtcoolID.Text = Format(CInt(objcool.GetData.Rows(objcool.GetData.Rows.Count - 1).Item(0).ToString.Substring(5) + 1), "COID-000000")
        Else
            txtcoolID.Text = "COID-000001"

        End If
    End Sub
    Private Sub Clear_Value()
        txtcoolID.Text = ""
        cbocoolType.SelectedIndex = 0
        txtcoolN.Text = ""
        txtcoolPRICE.Text = ""
        FillAutoID()
        dtcool = objcool.GetData
        dgvcool.DataSource = dtcool
        dgvcool.Refresh()
    End Sub

    Private Sub Cool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Value()
    End Sub

    Private Sub dgvcool_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcool.CellContentClick
        If dgvcool.Rows.Count > 0 Then
            Dim rowindex = dgvcool.CurrentRow.Index
            txtcoolID.Text = dgvcool.Item(0, rowindex).Value.ToString
            cbocoolType.Text = dgvcool.Item(1, rowindex).Value.ToString
            txtcoolN.Text = dgvcool.Item(2, rowindex).Value.ToString
            txtcoolPRICE.Text = dgvcool.Item(3, rowindex).Value.ToString
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtcoolN.Text = "" Then
            MessageBox.Show("Please type Cool No!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcoolN.Focus()
        ElseIf cbocoolType.Text = "" Then
            MessageBox.Show("Please choice Cool Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbocoolType.Focus()
        Else
            dtcool = objcool.GetData
            For i As Integer = 0 To dtcool.Rows.Count - 1
                If txtcoolID.Text.Equals(dtcool.Rows(i).Item("CoolID")) Then
                    MessageBox.Show("This Cool No is already exits.", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtcoolN.Focus()
                    Exit Sub
                End If

            Next

            objcool.Insert(txtcoolID.Text, cbocoolType.Text, txtcoolN.Text, txtcoolPRICE.Text)
            MessageBox.Show("Cool data save successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If dgvcool.Rows.Count > 0 Then
            If txtcoolN.Text = "" Then
                MessageBox.Show("Please type Cool No!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcoolN.Focus()
            ElseIf cbocoolType.Text = "" Then
                MessageBox.Show("Please select Cool Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbocoolType.Focus()
            Else
                objcool.UpdateCool(cbocoolType.Text, txtcoolN.Text, txtcoolPRICE.Text, txtcoolID.Text)
                MessageBox.Show("Food data Update successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Clear_Value()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If dgvcool.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objcool.DeleteCool(txtcoolID.Text)
                MessageBox.Show("Cool data Delete successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If

        End If
    End Sub
End Class