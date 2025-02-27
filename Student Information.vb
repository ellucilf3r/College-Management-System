Imports System.Data.OleDb

Public Class frmStudInfo

    ' Define and configure the connection string
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb")
    Dim isSaved As Boolean = False

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If isSaved Then
            Me.Hide()
            frmStudLogin.Show()
        End If
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Close()
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Me.Hide()
        frmStudLogin.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            mycon.Open()
            Dim sql As String = "INSERT INTO [STUDENT] ([STUD_ID], [PASSWORD], [STUD_NAME], [IC_NUM], [COURSE], [PHONE_NUM], [ADDRESS],  [PARENT_INCOME]) VALUES ( @StudID, @NewPass, @Name, @ICNum, @Course, @Phone,  @Address,   @ParentIncome)"
            Dim cmd As New OleDbCommand(sql, mycon)
            cmd.Parameters.AddWithValue("@StudID", txtStudID.Text)
            cmd.Parameters.AddWithValue("@NewPass", txtNewPass.Text)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@ICNum", txtICNum.Text)
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@ParentIncome", txtParentIncome.Text)
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



    Private Sub CheckFormCompletion()
        ' Enable the Save button only if all required fields are filled
        Dim allFieldsFilled As Boolean = Not String.IsNullOrEmpty(txtStudID.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtNewPass.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtName.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtICNum.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtCourse.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtPhone.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtAddress.Text) AndAlso
                                         Not String.IsNullOrEmpty(txtParentIncome.Text)

        btnSave.Enabled = allFieldsFilled
        btnNext.Enabled = allFieldsFilled And isSaved
    End Sub

    ' Add TextChanged event handlers for all input fields
    Private Sub txtStudID_TextChanged(sender As Object, e As EventArgs) Handles txtStudID.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtICNum_TextChanged(sender As Object, e As EventArgs) Handles txtICNum.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub txtParentIncome_TextChanged(sender As Object, e As EventArgs) Handles txtParentIncome.TextChanged
        CheckFormCompletion()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtName.Text = ""
        txtStudID.Text = ""
        txtICNum.Text = ""
        txtPhone.Text = ""
        txtCourse.Text = ""
        txtAddress.Text = ""
        txtNewPass.Text = ""
        txtParentIncome.Text = ""
    End Sub

    Private Sub frmStudInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckFormCompletion() 'The CheckFormCompletion method now also checks the isSaved flag to determine whether to enable the btnNext button.
    End Sub
End Class
