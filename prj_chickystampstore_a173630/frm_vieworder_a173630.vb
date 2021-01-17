﻿Public Class frm_vieworder_a173630
    Private Sub frm_orderlist_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT *  FROM TBL_ORDER_A173630 ORDER BY FLD_ORDER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grid_orders.DataSource = mydatatable

        grid_orders.Columns(0).HeaderText = "Order ID"
        grid_orders.Columns(1).HeaderText = "Order Date"
        grid_orders.Columns(2).HeaderText = "Customer ID"
        grid_orders.Columns(3).HeaderText = "Staff ID"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_orderlist_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class