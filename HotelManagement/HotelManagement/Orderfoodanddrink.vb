Public Class Order
    Dim objorder As New dsHotelManagementTableAdapters.OrderfoodanddrinkTableAdapter
    Dim dtorder As New DataTable

    Dim objroom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtroom As New DataTable

    Dim objdtype As New dsHotelManagementTableAdapters.DrinkTypeTableAdapter
    Dim dtdtype As New DataTable

    Dim objftype As New dsHotelManagementTableAdapters.FoodTypeTableAdapter
    Dim dtftype As New DataTable

    Dim objfood As New dsHotelManagementTableAdapters.FoodTableAdapter
    Dim dtfood As New DataTable

    Dim objdrink As New dsHotelManagementTableAdapters.DrinkandliquidTableAdapter
    Dim dtdrink As New DataTable

    Dim objorderfood As New dsHotelManagementTableAdapters.OrderFoodTableAdapter
    Dim dtof As New DataTable

    Dim obrorderdrink As New dsHotelManagementTableAdapters.OrderDrinkTableAdapter
    Dim dtod As New DataTable

    Dim dt As New DataTable
    Dim dr As DataRow
    Dim orderitemid As String
    Public Sub FillAutoID()
        If objorder.GetData.Rows.Count > 0 Then
            txtorderID.Text = Format(CInt(objorder.GetData.Rows(objorder.GetData.Rows.Count - 1).Item(0).ToString.Substring(5) + 1), "ORID-000000")
        Else
            txtorderID.Text = "ORID-000001"

        End If
    End Sub
    Private Sub Clear_Value()
        txtorderID.Text = ""
        dtporderDATE.Text = Date.Today
        cboRN.Text = ""
        cboRN.Enabled = True
        cboorderfd.Text = ""
        cboorderType.Text = ""
        cboorderN.Text = ""
        txtorderQty.Text = "0"
        txtorderPRICE.Text = "0"
        txtorderamt.Text = "0"
        FillAutoID()
        dtorder = objorder.GetData
        dgvorder.DataSource = dtorder
        dgvorder.Refresh()
    End Sub
    Public Sub Detail()
        dt.Columns.Clear()
        dr = dt.NewRow
        dr.Table.Columns.Add("Order_ItemID")
        dr.Table.Columns.Add("Order_ItemName")
        dr.Table.Columns.Add("Order_Type")
        dr.Table.Columns.Add("Price")
        dr.Table.Columns.Add("Quantity")
        dr.Table.Columns.Add("Amount")
        dt.Rows.Add(dr)
        dt.Rows.Clear()
    End Sub
    Private Sub calculation()
        Dim total As Integer
        For i As Integer = 0 To dt.Rows.Count - 1
            total += CInt(dt.Rows(i).Item("Amount"))
        Next
        txttotalamt.Text = total
    End Sub
    Private Sub Orderfoodanddrink_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Value()
        cboRoomNo_Load()
        Detail()
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
    Private Sub cboFoodType_Load()
        dtftype = objftype.GetData
        cboorderType.Items.Clear()
        For i As Integer = 0 To dtftype.Rows.Count - 1
            If dtftype.Rows.Count > 0 Then
                cboorderType.Items.Add(dtftype.Rows(i).Item("TypeName").ToString)
            End If
        Next
        cboorderType.Items.Insert(0, "Select")
        cboorderType.SelectedIndex = 0
    End Sub
    Private Sub cboDrinkType_Load()
        dtdtype = objdtype.GetData
        cboorderType.Items.Clear()
        For i As Integer = 0 To dtdtype.Rows.Count - 1
            If dtdtype.Rows.Count > 0 Then
                cboorderType.Items.Add(dtdtype.Rows(i).Item("TypeName").ToString)
            End If
        Next
        cboorderType.Items.Insert(0, "Select")
        cboorderType.SelectedIndex = 0
    End Sub
    Private Sub cboDrinkName_Load()
        dtdtype = objdtype.GetData
        dtdrink = objdrink.GetData
        cboorderN.Items.Clear()
        For i As Integer = 0 To dtdtype.Rows.Count - 1
            If dtdtype.Rows(i).Item("TypeName").Equals(cboorderType.SelectedItem.ToString) Then
                For j As Integer = 0 To dtdrink.Rows.Count - 1
                    If dtdrink.Rows(j).Item("DrinkandliquidType") = dtdtype.Rows(i).Item("DrinkTypeID") Then
                        cboorderN.Items.Add(dtdrink.Rows(j).Item("DrinkandliquidName").ToString)
                    End If
                Next
            End If
        Next
        cboorderN.Items.Insert(0, "Select")
        cboorderN.SelectedIndex = 0
    End Sub
    Private Sub cboFoodName_Load()
        dtftype = objftype.GetData
        dtfood = objfood.GetData
        cboorderN.Items.Clear()
        For i As Integer = 0 To dtftype.Rows.Count - 1
            If dtftype.Rows(i).Item("TypeName").Equals(cboorderType.SelectedItem.ToString) Then
                For j As Integer = 0 To dtfood.Rows.Count - 1
                    If dtfood.Rows(j).Item("FoodType") = dtftype.Rows(i).Item("FoodTypeID") Then
                        cboorderN.Items.Add(dtfood.Rows(j).Item("FoodName").ToString)
                    End If
                Next
            End If
        Next
        cboorderN.Items.Insert(0, "Select")
        cboorderN.SelectedIndex = 0
    End Sub
    Private Sub cboorderfd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboorderfd.SelectedIndexChanged
        If cboorderfd.SelectedItem.ToString.Equals("Food") Then
            cboFoodType_Load()
        ElseIf cboorderfd.SelectedItem.ToString.Equals("Drink") Then
            cboDrinkType_Load()
        ElseIf cboorderfd.SelectedIndex = 0 Then
            cboorderType.Items.Clear()
            cboorderType.Items.Insert(0, "Select")
            cboorderType.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboorderType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboorderType.SelectedIndexChanged
        If cboorderType.SelectedIndex = 0 Then
            cboorderN.Items.Clear()
            cboorderN.Items.Insert(0, "Select")
            cboorderN.SelectedIndex = 0
        ElseIf cboorderfd.SelectedItem.ToString.Equals("Drink") Then
            cboDrinkName_Load()
        ElseIf cboorderfd.SelectedItem.ToString.Equals("Food") Then
            cboFoodName_Load()
        End If
    End Sub

    Private Sub cboorderN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboorderN.SelectedIndexChanged
        dtfood = objfood.GetData
        dtdrink = objdrink.GetData
        For i As Integer = 0 To dtfood.Rows.Count - 1
            If dtfood.Rows(i).Item("FoodName") = cboorderN.SelectedItem.ToString Then
                txtorderPRICE.Text = dtfood.Rows(i).Item("Price")
                orderitemid = dtfood.Rows(i).Item("FoodID")
            Else
                For j As Integer = 0 To dtdrink.Rows.Count - 1
                    If dtdrink.Rows(j).Item("DrinkandliquidName") = cboorderN.SelectedItem.ToString Then
                        txtorderPRICE.Text = dtdrink.Rows(j).Item("Price")
                        orderitemid = dtdrink.Rows(j).Item("DrinkandliquidID")
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub txtorderQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtorderQty.TextChanged
        Dim amount As Integer = 0
        If txtorderQty.Text = 0 Then
            txtorderamt.Text = 0
        ElseIf IsNumeric(txtorderQty.Text) = False Then
            MessageBox.Show("Please type valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtorderQty.Focus()
        Else
            amount = CInt(txtorderQty.Text) * CInt(txtorderPRICE.Text)
            txtorderamt.Text = amount
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Clear_Value()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cboRN.SelectedIndex = 0 Then
            MessageBox.Show("Please select Room No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRN.Focus()
        ElseIf cboorderN.SelectedIndex = 0 Then
            MessageBox.Show("Please select Order Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboorderN.Focus()
        ElseIf txtorderQty.Text = "" Then
            MessageBox.Show("Please type quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtorderQty.Focus()

        ElseIf txtorderQty.Text = 0 Then
            MessageBox.Show("Please type quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtorderQty.Focus()

        Else
            For i As Integer = 0 To dt.Rows.Count - 1
                If cboorderN.Text = dt.Rows(i).Item("Order_ItemName") Then
                    MessageBox.Show("Please select another", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next

            dr = dt.NewRow
            dr(0) = orderitemid
            dr(1) = cboorderN.SelectedItem.ToString
            dr(2) = cboorderType.SelectedItem.ToString
            dr(3) = CInt(txtorderPRICE.Text)
            dr(4) = CInt(txtorderQty.Text)
            dr(5) = CInt(txtorderamt.Text)
            dt.Rows.Add(dr)
            dgvorder.Refresh()
            dgvorder.DataSource = dt
            cboRN.Enabled = False
            calculation()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows.RemoveAt(i)
        Next
        calculation()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        objorder.Insert(txtorderID.Text, dtporderDATE.Text, cboRN.SelectedItem.ToString, CInt(txttotalamt.Text), "Remain")
        For i As Integer = 0 To dt.Rows.Count - 1
            dtfood = objfood.GetData
            dtdrink = objdrink.GetData

            For f As Integer = 0 To dtfood.Rows.Count - 1
                If dtfood.Rows(f).Item("FoodName") = dt.Rows(i).Item("Order_ItemName").ToString Then
                    objorderfood.Insert(txtorderID.Text, dt.Rows(i).Item("Order_ItemID").ToString, CInt(dt.Rows(i).Item("Quantity")), CInt(dt.Rows(i).Item("Amount")))
                End If
            Next

            For d As Integer = 0 To dtdrink.Rows.Count - 1
                If dtdrink.Rows(d).Item("DrinkandliquidName") = dt.Rows(i).Item("Order_ItemName").ToString Then
                    obrorderdrink.Insert(txtorderID.Text, dt.Rows(i).Item("Order_ItemID").ToString, CInt(dt.Rows(i).Item("Quantity")), CInt(dt.Rows(i).Item("Amount")))
                End If
            Next
                
        Next
        MessageBox.Show("Order information is successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clear_Value()
    End Sub

End Class