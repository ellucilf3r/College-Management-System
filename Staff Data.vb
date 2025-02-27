Imports System.Data.OleDb

Public Class frmStaffData

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Close()
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHomes.Click
        Me.Hide()
        ' frmMain.Show()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Me.Hide()
        ' frmStudLogin.Show()
    End Sub

    Dim con As New OleDbConnection
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb"
        con.Open()

        datashow()
    End Sub

    Private Sub datashow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from STAFF", con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

        con.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim ID = txtStaffID.Text

        da = New OleDbDataAdapter("select * from STAFF where STAFF_ID = '" + ID + "'", con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

        con.Close()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        frmStudData.Show()
        Me.Hide()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmMain.Show()
        Me.Hide()
    End Sub
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        datashow()
    End Sub
End Class