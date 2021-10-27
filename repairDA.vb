Imports System.Data
Imports System.Data.OleDb
Public Class repairDA

    Private Shared con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\New folder\AMC1-2003.mdb")
    Private Shared repairs As New ArrayList
    Private Shared theRepair As repair

    Public Shared Sub Initialize()
        Try
            con.Open()
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub Terminate()
        Try
            con.Close()
            con = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub AddNew(ByVal rep As repair)
        Dim carID As Integer = rep.getcarID()
        Dim tID As Integer = rep.gettID()
        Dim numOfHours As String = rep.getnumberOfHours()
        Dim carEntry As DateTime = rep.getcarEntry()

        Dim sql As String = "Insert Into Repairs Values ('" & carID & "', '" & tID & "', '" & numOfHours & "', " & carEntry & " )"

        Dim da As New OleDbDataAdapter()

        Try
            da.InsertCommand = New OleDbCommand(sql)
            da.InsertCommand.Connection = con
            da.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Update(ByVal rep As repair)
        Dim carID As Integer = rep.getcarID()
        Dim tID As Integer = rep.gettID()
        Dim numOfHours As String = rep.getnumberOfHours()
        Dim carEntry As DateTime = rep.getcarEntry()

        Dim sql As String = "Update Repairs Set numOfHours= '" & numOfHours & "', carEntry=" & carEntry &
            "'  Where carID =" & carID & "'  and tID =" & tID
        Dim da As New OleDbDataAdapter()

        Try
            da.UpdateCommand = New OleDbCommand(sql)
            da.UpdateCommand.Connection = con
            da.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Delete(ByVal rep As repair)
        Dim carID As Integer = rep.getcarID()
        Dim tID As Integer = rep.gettID()
        Dim numOfHours As String = rep.getnumberOfHours()
        Dim carEntry As DateTime = rep.getcarEntry()

        Dim sql As String = "Delete From Repairs Where carID ='" & carID & "'and tID='" & tID & "'"
        Dim da As New OleDbDataAdapter()

        Try
            da.DeleteCommand = New OleDbCommand(sql)
            da.DeleteCommand.Connection = con
            da.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Function Find(ByVal carID As Integer) As repair
        Dim ds As New DataSet
        Dim sql As String = "Select * from Repairs Where carID = '" & carID & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Repairs")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If ds.Tables("Repairs").Rows.Count > 0 Then
            Dim tID As Integer = ds.Tables("Repairs").Rows(0).Item(1)
            Dim numOfHours As String = ds.Tables("Repairs").Rows(0).Item(2)
            Dim carEntry As DateTime = ds.Tables("Repairs").Rows(0).Item(3)
            theRepair = New repair(carID, tID, numOfHours, carEntry)
        Else
            theRepair = Nothing
        End If
        Return theRepair
    End Function
    Public Shared Function GetAll() As ArrayList
        Dim ds As New DataSet
        Dim sql As String = "Select * from Repairs "
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Repairs")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        repairs.Clear()

        If ds.Tables("Repairs").Rows.Count > 0 Then
            Dim dr As DataRow
            For Each dr In ds.Tables("Repairs").Rows
                Dim carID As Integer = dr.Item(0)
                Dim tID As Integer = dr.Item(1)
                Dim numOfHours As String = dr.Item(2)
                Dim carEntry As DateTime = dr.Item(3)

                repairs.Add(New repair(carID, tID, numOfHours, carEntry))
            Next
        End If
        Return repairs
    End Function


End Class
