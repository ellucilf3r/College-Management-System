Imports System.Data.OleDb
Public Class frmRoomInfo
    Public Shared _intSizeOfArray As Integer = 59
    Public Shared _strRoomAvailable(_intSizeOfArray)
    Public Shared _strRoomNum(_intSizeOfArray)
    Dim intCount As Integer = 0
    Dim strStudentID As String = frmStudLogin.txtStudentID.Text
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb")

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        frmFeeInfo.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStudentID.Text = SharedDataStudent.strStudentID

        Try
            mycon.Open()
            Dim sql As String = "SELECT * FROM [ROOM]"
            Dim cmd As New OleDbCommand(sql, mycon)
            Dim myReader As OleDbDataReader = cmd.ExecuteReader()
            While myReader.Read
                If myReader.HasRows Then
                    cmbRoomID.Items.Add(myReader("COLLEGE").ToString() & " - " & myReader("ROOM_NUM").ToString())
                    _strRoomAvailable(intCount) = myReader("ROOM_AVAILABILITY").ToString()
                    _strRoomNum(intCount) = (myReader("ROOM_NUM").ToString())
                    intCount += 1
                End If
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If mycon IsNot Nothing Then
                mycon.Close()
            End If
        End Try

    End Sub


    Dim strRoomNumStudentChoose As String
    Private Sub cmbRoomID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomID.SelectedIndexChanged
        If cmbRoomID.SelectedIndex > -1 Then
            Dim intSelectRoomID = cmbRoomID.SelectedIndex
            lblAvailable.Text = _strRoomAvailable(intSelectRoomID).ToString()
            strRoomNumStudentChoose = _strRoomNum(intSelectRoomID)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Database connection string
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb"
        Dim strReserved As String = "No"
        Try
            ' Create a connection to the database
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Check if the student has already reserved a room
                Dim sqlCheck As String = "SELECT COUNT(*) FROM ROOM WHERE [STUD_ID] = ?"
                Using checkCommand As New OleDbCommand(sqlCheck, connection)
                    checkCommand.Parameters.AddWithValue("@STUD_ID", SharedDataStudent.strStudentID.ToString())

                    Dim count As Integer = CInt(checkCommand.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("You have already reserved a room.")
                        Me.Close()
                        frmMain.Show()
                        Return
                    End If
                End Using

                ' Check if the room is available and update ROOM_AVAILIBILITY if available
                Dim sqlUpdate As String = "UPDATE ROOM SET [STUD_ID] = ?, [ROOM_AVAILABILITY] = ? WHERE [ROOM_NUM] = ? AND [ROOM_AVAILABILITY] = 'Yes'"
                Using command As New OleDbCommand(sqlUpdate, connection)
                    command.Parameters.AddWithValue("@STUD_ID", SharedDataStudent.strStudentID.ToString())
                    command.Parameters.AddWithValue("@ROOM_AVAILABILITY", strReserved)
                    command.Parameters.AddWithValue("@ROOM_NUM", strRoomNumStudentChoose)

                    ' Execute the update command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"Room {strRoomNumStudentChoose} is Reserved.")

                        cmbRoomID.Items.Clear()
                        lblAvailable.Text = "-"
                        lblStudentID.Text = "-"
                        Me.Hide()
                        frmFeeInfo.Show()

                    Else
                        MessageBox.Show($"Room {strRoomNumStudentChoose} is already reserved.")
                        Return
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating room availability: {ex.Message}")
        End Try
    End Sub



End Class