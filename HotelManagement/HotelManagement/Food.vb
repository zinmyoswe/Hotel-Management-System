Public Class Food
    Dim objfood As New dsHotelManagementTableAdapters.FoodTableAdapter
    Dim dtfood As New DataTable

    Dim objfoodtype As New dsHotelManagementTableAdapters.FoodTypeTableAdapter
    Dim dtfoodtype As New DataTable

    Public Sub FillAutoID()
        If objfood.GetData.Rows.Count > 0 Then
            txtfoodID.Text = Format(CInt(objfood.GetData.Rows(objfood.GetData.Rows.Count - 1).Item(0).ToString.Substring(5) + 1), "FOOD-000000")
        Else
            txtfoodID.Text = "FOOD-000001"

        End If
    End Sub
    Private Sub Clear_Value()
        txtfoodID.Text = ""
        txtfoodN.Text = ""
        txtfoodPRICE.Text = ""
        FillAutoID()
        dtfood = objfood.GetData
        dgvfood.DataSource = dtfood
        dgvfood.Refresh()
    End Sub
   
    Private Sub Food_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillAutoID()
        Clear_Value()
        cbofoodtype_Load()
    End Sub
    Private Sub cbofoodtype_Load()
        dtfoodtype = objfoodtype.GetData
        cbofoodType.Items.Clear()
        For i As Integer = 0 To dtfoodtype.Rows.Count - 1
            If dtfoodtype.Rows.Count > 0 Then
                cbofoodType.Items.Add(dtfoodtype.Rows(i).Item("TypeName").ToString)
            End If
        Next
        cbofoodType.Items.Insert(0, "Select")
        cbofoodType.SelectedIndex = 0
    End Sub

    Private Sub dgvfood_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfood.CellContentClick
        If dgvfood.Rows.Count > 0 Then
            Dim rowindex = dgvfood.CurrentRow.Index
            txtfoodID.Text = dgvfood.Item(0, rowindex).Value.ToString
            cbofoodType.Text = dgvfood.Item(1, rowindex).Value.ToString
            txtfoodN.Text = dgvfood.Item(2, rowindex).Value.ToString
            txtfoodPRICE.Text = dgvfood.Item(3, rowindex).Value.ToString
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cbofoodType.Text = "" Then
            MessageBox.Show("Please choice food Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbofoodType.Focus()
        ElseIf txtfoodN.Text = "" Then
            MessageBox.Show("Please type food Name!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfoodN.Focus()
        
        ElseIf txtfoodPRICE.Text = "" Then
            MessageBox.Show("Please Type food price`", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfoodPRICE.Focus()

        ElseIf IsNumeric(txtfoodPRICE.Text) = False Then
            MessageBox.Show("Please type valid price", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfoodPRICE.Focus()
        Else
            dtfood = objfood.GetData
            For i As Integer = 0 To dtfood.Rows.Count - 1
                If txtfoodID.Text.Equals(dtfood.Rows(i).Item("FoodID")) Then
                    MessageBox.Show("This food No is already exits.", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtfoodID.Focus()
                    Exit Sub
                End If

            Next

            objfood.Insert(txtfoodID.Text, txtfoodtypeID.Text, txtfoodN.Text, txtfoodPRICE.Text)
            MessageBox.Show("food data save successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Value()

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If dgvfood.Rows.Count > 0 Then
            If txtfoodN.Text = "" Then
                MessageBox.Show("Please type food Name!", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfoodN.Focus()
            ElseIf cbofoodType.Text = "" Then
                MessageBox.Show("Please choice food Type", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofoodType.Focus()
            ElseIf txtfoodPRICE.Text = "" Then
                MessageBox.Show("Please Type food price`", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfoodPRICE.Focus()

            ElseIf IsNumeric(txtfoodPRICE.Text) = False Then
                MessageBox.Show("Please type valid price", "Error message box", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfoodPRICE.Focus()
            Else
                objfood.UpdateFood(txtfoodtypeID.Text, txtfoodN.Text, txtfoodPRICE.Text, txtfoodID.Text)
                MessageBox.Show("food data Update successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If dgvfood.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objfood.DeleteFood(txtfoodID.Text)
                MessageBox.Show("Food data Delete successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Value()
            End If

        End If
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Clear_Value()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dispose()
    End Sub

    Private Sub cbofoodType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofoodType.SelectedIndexChanged
        dtfoodtype = objfoodtype.GetData
        For i As Integer = 0 To dtfoodtype.Rows.Count - 1
            If dtfoodtype.Rows.Count > 0 Then
                If dtfoodtype.Rows(i).Item("TypeName").ToString.Equals(cbofoodType.SelectedItem.ToString) Then
                    txtfoodtypeID.Text = dtfoodtype.Rows(i).Item("FoodTypeID")
                End If
            End If
        Next
    End Sub
End Class