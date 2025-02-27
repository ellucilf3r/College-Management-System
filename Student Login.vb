Imports System.Data.OleDb
Public Module SharedDataStudent
    Public strStudentID As String
    Public strPassword As String
    Public decParentIncome As Decimal
End Module
Public Class frmStudLogin

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        SharedDataStudent.strStudentID = txtStudentID.Text
        SharedDataStudent.strPassword = txtPassword.Text
        'Dim strPassword As String = txtPassword.Text

        ' Define and configure the connection string
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb")

        Try
            conn.Open()

            Dim strDataStudentID As String = "SELECT [STUD_ID], [PASSWORD], [STUD_NAME] ,[PARENT_INCOME] FROM [STUDENT] WHERE [STUD_ID] = ?"
            Dim cmd As New OleDbCommand(strDataStudentID, conn)
            cmd.Parameters.AddWithValue("@STUD_ID", strStudentID)
            cmd.Parameters.AddWithValue("@PASSWORD", strPassword)

            Dim myreader As OleDbDataReader = cmd.ExecuteReader()

            If Not myreader.HasRows Then
                MessageBox.Show("Username does not exist in the database. Please register.")
            Else
                myreader.Read()
                If myreader("STUD_ID").ToString() = strStudentID AndAlso myreader("PASSWORD").ToString() = strPassword Then
                    ' Successful login
                    MessageBox.Show("Login successful. Welcome, " & myreader("STUD_NAME").ToString())
                    SharedDataStudent.strStudentID = myreader("STUD_ID").ToString()
                    SharedDataStudent.strPassword = myreader("PASSWORD").ToString()
                    SharedDataStudent.decParentIncome = Convert.ToDecimal(myreader("PARENT_INCOME").ToString())

                    txtStudentID.Clear()
                    txtPassword.Clear()
                    frmRoomInfo.Show()
                    Me.Hide() ' Hide the login form
                Else
                    MessageBox.Show("Password or username is incorrect. Please try again.")
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
        End Try
    End Sub

    Private Sub btnNewStud_Click(sender As Object, e As EventArgs) Handles btnNewStud.Click
        Me.Hide()
        frmStudInfo.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMain.Show()
    End Sub

End Class