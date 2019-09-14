Public Class Main

    Private Sub EntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub GuestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestToolStripMenuItem.Click
        Dim objguest As New Guest
        objguest.ShowDialog()
    End Sub

    Private Sub RoomFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomFormToolStripMenuItem.Click
        Dim objroom As New Room
        objroom.ShowDialog()
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem.Click
        Dim objreservation As New Reservation
        objreservation.ShowDialog()
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem.Click
        Dim objreservationcheckin As New frmreservationcheckIn
        objreservationcheckin.ShowDialog()
    End Sub

    Private Sub CoolFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoolFormToolStripMenuItem.Click
        Dim objcool As New Cool
        objcool.ShowDialog()
    End Sub

    Private Sub FoodFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodFormToolStripMenuItem.Click
        Dim objfood As New Food
        objfood.ShowDialog()
    End Sub

    Private Sub DrinkandliquidFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrinkandliquidFormToolStripMenuItem.Click
        Dim objdrinkandliquid As New Drinkandliquid

        objdrinkandliquid.ShowDialog()
    End Sub

    Private Sub OrderfoodandDrinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderfoodandDrinkToolStripMenuItem.Click
        Dim objorderfoodanddrink As New Order
        objorderfoodanddrink.ShowDialog()
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutToolStripMenuItem.Click
        Dim objcheckout As New CheckOut
        objcheckout.ShowDialog()
    End Sub

    Private Sub CheckOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutToolStripMenuItem1.Click
        Dim objcoreport As New CheckOutSearch
        objcoreport.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("UserManualhotel.pdf")
    End Sub
End Class