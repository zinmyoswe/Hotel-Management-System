Public Class frmReservation
    Dim objguest As New dsHotelManagementTableAdapters.GuestTableAdapter
    Dim dtguest As New DataTable

    Dim objreservation As New dsHotelManagementTableAdapters.ReservationTableAdapter
    Dim dtreservation As New DataTable

    Dim objdetail As New dsHotelManagementTableAdapters.DetailTableAdapter
    Dim dtdetail As New DataTable

    Dim objroom As New dsHotelManagementTableAdapters.RoomTableAdapter
    Dim dtroom As New DataTable

    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub frmReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class