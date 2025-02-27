Imports System.Data.OleDb
Public Class frmStaffInfo
    Dim isSaved As Boolean = False


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If isSaved Then
            Me.Hide()
            frmStaffLogin.Show()
        End If
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Me.Hide()
        frmStaffLogin.Show()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb")

        Try
            mycon.Open()
            Dim sql As String = "INSERT INTO [STAFF] ([STAFF_NAME],[STAFF_ID],[IC_NUM], [PHONE_NUM], [PASSWORD], [SALARY] ) VALUES (@STAFF_NAME, @STAFF_ID, @IC_NUM, @PHONE_NUM, @PASSWORD, @SALARY)"
            Dim cmd As New OleDbCommand(sql, mycon)
            cmd.Parameters.AddWithValue("@STAFF_NAME", txtStaffName.Text)
            cmd.Parameters.AddWithValue("@STAFF_ID", txtStaffID.Text)
            cmd.Parameters.AddWithValue("@IC_NUM", txtICNum.Text)
            cmd.Parameters.AddWithValue("@PHONE_NUM", txtPhoneNum.Text)
            cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text)
            cmd.Parameters.AddWithValue("@SALARY", txtSalary.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration successful!")
            btnSave.Enabled = False
            isSaved = True
            btnNext.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            mycon.Close()
        End Try
    End Sub

    Private Sub frmStaffInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckFormCompletion()
    End Sub

    Private Sub CheckFormCompletion()
        ' Enable the Save button only if all required fields are filled
        Dim allFieldsFilled As Boolean = Not String.IsNullOrEmpty(txtStaffName.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtStaffID.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtICNum.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtPhoneNum.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtPassword.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtSalary.Text)




        btnSave.Enabled = allFieldsFilled
        btnNext.Enabled = allFieldsFilled And isSaved
    End Sub
    Private Sub txtStaffName_TextChanged(sender As Object, e As EventArgs) Handles txtStaffName.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtStaffID_TextChanged(sender As Object, e As EventArgs) Handles txtStaffID.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtICNum_TextChanged(sender As Object, e As EventArgs) Handles txtICNum.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtPhoneNum_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNum.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtStaffName.Text = ""
        txtStaffID.Text = ""
        txtICNum.Text = ""
        txtPhoneNum.Text = ""
        txtPassword.Text = ""
        txtSalary.Text = ""
    End Sub
End Class