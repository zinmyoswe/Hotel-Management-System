Public Class Drinkandliquid
    Dim objdrink As New dsHotelManagementTableAdapters.DrinkandliquidTableAdapter
    Dim dtdrink As New DataTable

    Dim objdrinktype As New dsHotelManagementTableAdapters.DrinkTypeTableAdapter
    Dim dtdrinktype As New DataTable

    Private Sub FillAutoID()
        If objdrink.GetData.Rows.Count > 0 Then
            txtdrinkID.Text = Format(CInt(objdrink.GetData.Rows(objdrink.GetData.Rows.Count - 1).Item(0).ToString.Substring(6) + 1), "DRINK-000000")
        Else
            txtdrinkID.Text = "DRINK-000001"
        End If
    End Sub

    Private Sub Drinkandliquid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillAutoID()
        Clear_Value()
        cbodrinktype_Load()
    End Sub
    Private Sub Clear_Value()
        txtdrinkID.Text = ""
        txtdrinkN.Text = ""
        txtdrinkPRICE.Text = ""
        FillAutoID()
        dtdrink = objdrink.GetData
        dgvdrink.DataSource = dtdrink
        dgvdrink.Refresh()
    End Sub
    Private Sub cbodrinktype_Load()
        dtdrinktype = objdrinktype.GetData
        cbodrinkType.Items.Clear()
        For i As Integer = 0 To dtdrinktype.Rows.Count - 1
            If dtdrinktype.Rows.Count > 0 Then
                cbodrinkType.Items.Add(dtdrinktype.Rows(i).Item("TypeName").ToString)
            End If
        Next
        cbodrinkType.Items.Insert(0, "Select")
        cbodrinkType.SelectedIndex = 0
    End Sub

    Private Sub cbodrinkType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodrinkType.SelectedIndexChanged
        dtdrinktype = objdrinktype.GetData
        For i As Integer = 0 To dtdrinktype.Rows.Count - 1
            If dtdrinktype.Rows.Count > 0 Then
                If dtdrinktype.Rows(i).Item("TypeName").ToString.Equals(cbodrinkType.SelectedItem.ToString) Then
                    txtdrinktypeID.Text = dtdrinktype.Rows(i).Item("DrinkTypeID")
                End If
            End If
        Next
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Clear_Value()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub dgvdrink_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdrink.CellContentClick
        If dgvdrink.Rows.Count > 0 Then
            Dim rowindex = dgvdrink.CurrentRow.Index
            txtdrinkID.Text = dgvdrink.Item(0, rowindex).Value.ToString
            cbodrinkType.Text = dgvdrink.Item(1, rowindex).Value.ToString
            txtdrinkN.Text = dgvdrink.Item(2, rowindex).Value.ToString
            txtdrinkPRICE.Text = dgvdrink.Item(3, rowindex).Value.ToString
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtdrinkN.Text = "" Then
            MessageBox.Show("Please type drink Name!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdrinkN.Focus()
        ElseIf cbodrinkType.Text = "" Then
            MessageBox.Show("Please choice drink Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbodrinkType.Focus()
        ElseIf txtdrinkPRICE.Text = "" Then
            MessageBox.Show("Please Type drink price`", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdrinkPRICE.Focus()

        ElseIf IsNumeric(txtdrinkPRICE.Text) = False Then
            MessageBox.Show("Please type valid price", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdrinkPRICE.Focus()
        Else
            dtdrink = objdrink.GetData
            For i As Integer = 0 To dtdrink.Rows.Count - 1
                If txtdrinkID.Text.Equals(dtdrink.Rows(i).Item("DrinkandliquidID")) Then
                    MessageBox.Show("This drink No is already exits.", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtdrinkID.Focus()
                    Exit Sub
                End If

            Next

            objdrink.Insert(txtdrinkID.Text, txtdrinktypeID.Text, txtdrinkN.Text, txtdrinkPRICE.Text)
            MessageBox.Show("drink data save successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If dgvdrink.Rows.Count > 0 Then
            If txtdrinkN.Text = "" Then
                MessageBox.Show("Please type drink Name!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdrinkN.Focus()
            ElseIf cbodrinkType.Text = "" Then
                MessageBox.Show("Please choice drink Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbodrinkType.Focus()
            ElseIf txtdrinkPRICE.Text = "" Then
                MessageBox.Show("Please Type drink price`", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdrinkPRICE.Focus()

            ElseIf IsNumeric(txtdrinkPRICE.Text) = False Then
                MessageBox.Show("Please type valid price", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdrinkPRICE.Focus()
            Else
                objdrink.UpdateDrink(txtdrinktypeID.Text, txtdrinkN.Text, txtdrinkPRICE.Text, txtdrinkID.Text)
                MessageBox.Show("Drink data Update successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If dgvdrink.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objdrink.DeleteDrink(txtdrinkID.Text)
                MessageBox.Show("Drink data Delete successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If

        End If
    End Sub
End Class