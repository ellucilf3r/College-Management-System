Imports System.Data.OleDb

Public Class frmFeeInfo
    Dim strStudentID As String = SharedDataStudent.strStudentID
    Dim decParentIncome As Decimal = SharedDataStudent.decParentIncome
    Const _cdecDiscCollege As Decimal = 0.4D
    Const _cdecElectricItem As Decimal = 10D
    Const _cdecCollege As Decimal = 420D

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adlin\Desktop\SEM 3\CSC301\GROUP PROJECT\Database301 COLLEGE MANAGEMENT SYSTEM.accdb")
    Dim isSaved As Boolean = False
    Dim decTotalCollege As Decimal
    Dim decTotalElectricFee As Decimal
    Public Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intElectricItem As Integer = Convert.ToInt32(txtElectricalItem.Text)

        If intElectricItem >= 1 Then
            decTotalElectricFee = CalElectricFee(intElectricItem)
            lblElectricalFee.Text = decTotalElectricFee.ToString("C")
        Else
            MsgBox("Please enter a valid number for electrical items")
        End If

        decTotalCollege = CalCollegeFee(decParentIncome)
        If decParentIncome < 1500 Then
            lblCollegeFee.Text = decTotalCollege.ToString("C2") & "   (get 40% Discount)"
        Else
            lblCollegeFee.Text = decTotalCollege.ToString("C2")
        End If
        lblSubTotal.Text = (420 + decTotalElectricFee).ToString("C2")
        lblTotal.Text = (decTotalCollege + decTotalElectricFee).ToString("C2")

    End Sub

    Function CalCollegeFee(ByVal decParentIncome As Decimal) As Decimal
        Dim decTotalCollege As Decimal

        If decParentIncome < 1500 Then
            decTotalCollege = _cdecCollege - (_cdecCollege * _cdecDiscCollege)
        Else
            decTotalCollege = _cdecCollege
        End If


        Return decTotalCollege
    End Function

    Function CalElectricFee(intElectricItem As Integer) As Decimal
        Dim decTotalElectric As Decimal

        decTotalElectric = intElectricItem * _cdecElectricItem

        Return decTotalElectric

    End Function

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStudentID.Text = strStudentID
        lblParentIncome.Text = decParentIncome.ToString("C2")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            mycon.Open()
            Dim sql As String = "INSERT INTO [FEE] ([STUD_ID], [ELEC_ITEM], [COLLEGE_FEE], [ELEC_FEE], [SUB_TOTAL], [TOTAL]) VALUES ( @StudID,@ElecItem, @CollegeFee, @ElecFee, @SubTotal, @Total)"
            Dim cmd As New OleDbCommand(sql, mycon)
            cmd.Parameters.AddWithValue("@StudID", SharedDataStudent.strStudentID)
            cmd.Parameters.AddWithValue("@ElecItem", txtElectricalItem.Text)
            cmd.Parameters.AddWithValue("@CollegeFee", decTotalCollege)
            cmd.Parameters.AddWithValue("@ElecFee", decTotalElectricFee)
            cmd.Parameters.AddWithValue("@SubTotal", lblSubTotal.Text)
            cmd.Parameters.AddWithValue("@Total", lblTotal.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Done Save!")
            btnSave.Enabled = False
            isSaved = True
            btnNext.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            mycon.Close()
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If isSaved Then
            Me.Close()
            frmMain.Show()
            MsgBox("Thank You!")
        End If

    End Sub
End Class