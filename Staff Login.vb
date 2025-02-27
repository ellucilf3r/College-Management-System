Imports System.Data.OleDb
Public Module SharedDataStaff
    Public strStaffID As String
    Public strPasswordStaff As String
    Public decSalary As Decimal
End Module
Public Class frmStaffLogin
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        SharedDataStaff.strStaffID = txtStaffID.Text
        SharedDataStaff.strPasswordStaff = txtPasswordStaff.Text
        Dim strStaffID As String = txtStaffID.Text
        Dim strPasswordStaff As String = txtPasswordStaff.Text

        ' Define and configure the connection string
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb")

        Try
            conn.Open()

            Dim strDataStaffID As String = "SELECT [STAFF_ID],[STAFF_NAME],[PASSWORD] FROM [STAFF] WHERE [STAFF_ID] = ?"
            Dim cmd As New OleDbCommand(strDataStaffID, conn)
            cmd.Parameters.AddWithValue("@STAFF_ID", strStaffID)
            cmd.Parameters.AddWithValue("@PASSWORD", strPasswordStaff)

            Dim myreader As OleDbDataReader = cmd.ExecuteReader()

            If Not myreader.HasRows Then
                MessageBox.Show("Staff ID does not exist in the database. Please register.")
            Else
                myreader.Read()
                If myreader("STAFF_ID").ToString() = strStaffID AndAlso myreader("PASSWORD").ToString() = strPasswordStaff Then
                    ' Successful login
                    MessageBox.Show("Login successful. Welcome, " & myreader("STAFF_NAME").ToString())
                    frmStudData.Show()
                    Me.Hide() ' Hide the login form
                Else
                    MessageBox.Show("Password or ID is incorrect. Please try again.")
                End If
            End If
            myreader.Close()
        Catch ex As Exception
            ' Handle potential exceptions
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing Then
                conn.Close()
            End If
            txtStaffID.Clear()
            txtPasswordStaff.Clear()
        End Try
        Me.Hide()
        frmStudData.Show()
    End Sub

    Private Sub btnNewStaff_Click(sender As Object, e As EventArgs) Handles btnNewStaff.Click
        Me.Hide()
        frmStaffInfo.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPasswordStaff.UseSystemPasswordChar = False
        Else
            txtPasswordStaff.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class