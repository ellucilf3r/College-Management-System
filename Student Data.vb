Imports System.Data.OleDb

Public Class frmStudData

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Close()
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        datashow()
        Me.Hide()
        frmStudLogin.Show()
    End Sub

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb"

    Private Sub frmStudData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datashow()
    End Sub

    Private Sub datashow()
        Using con As New OleDbConnection(connectionString)
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("SELECT * FROM STUDENT", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Using con As New OleDbConnection(connectionString)
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("SELECT * FROM STUDENT WHERE STUD_ID = ?", con)
            da.SelectCommand.Parameters.AddWithValue("@STUD_ID", txtStudID.Text)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End Using
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmStaffData.Show()
        Me.Hide()
    End Sub
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        datashow()
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        frmStaffInfo.Show()
        Me.Hide()

    End Sub
End Class
