﻿Public Class frm_stafflist_a173630
    Private Sub frm_stafflist_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT *  FROM TBL_STAFF_A173630 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grid_staff.DataSource = mydatatable

        grid_staff.Columns(0).HeaderText = "ID"
        grid_staff.Columns(1).HeaderText = "Name"
        grid_staff.Columns(2).HeaderText = "Phone No"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a173630.Show()
        Me.Close()
    End Sub

    Private Sub frm_stafflist_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class