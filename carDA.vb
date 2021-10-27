Imports System.Data
Imports System.Data.OleDb
Public Class carDA
    Private Shared con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\New folder\AMC1-2003.mdb")
    Private Shared car As New ArrayList
    Private Shared theCar As car

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

    Public Shared Sub AddNew(ByVal cr As car)
        Dim carID As Integer = cr.getcarId()
        Dim model As String = cr.getmodel()
        Dim manName As String = cr.getmanName()
        Dim manYear As Integer = cr.getmanYear()
        Dim cID As Integer = cr.getcusID()



        Dim sql As String = "Insert Into Car Values ('" & carID & "', '" & model & "', '" & manName & "', '" & manYear & "'," & cID & ")"
        Dim da As New OleDbDataAdapter()

        Try
            da.InsertCommand = New OleDbCommand(sql)
            da.InsertCommand.Connection = con
            da.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Update(ByVal cr As car)
        Dim carID As Integer = cr.getcarId()
        Dim model As String = cr.getmodel()
        Dim manName As String = cr.getmanName()
        Dim manYear As Integer = cr.getmanYear()
        Dim cID As Integer = cr.getcusID()

        Dim sql As String = "Update Car Set carID= '" & carID & "', carModel=" & model & ", manufactureName=" & manName & ", " &
            "'  Where carId ='" & carID & "'"
        Dim da As New OleDbDataAdapter()

        Try
            da.UpdateCommand = New OleDbCommand(sql)
            da.UpdateCommand.Connection = con
            da.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Delete(ByVal cr As car)
        Dim carID As Integer = cr.getcarId()
        Dim model As String = cr.getmodel()
        Dim manName As String = cr.getmanName()
        Dim manYear As Integer = cr.getmanYear()
        Dim cID As Integer = cr.getcusID()


        Dim sql As String = "Delete From Car Where carID ='" & carID & "'"
        Dim da As New OleDbDataAdapter()

        Try
            da.DeleteCommand = New OleDbCommand(sql)
            da.DeleteCommand.Connection = con
            da.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Function Find(ByVal carID As Integer) As car
        Dim ds As New DataSet
        Dim sql As String = "Select * from Car where carID ='" & carID & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Car")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If ds.Tables("Car").Rows.Count > 0 Then

            Dim model As String = ds.Tables("Car").Rows(0).Item(1)
            Dim manName As String = ds.Tables("Car").Rows(0).Item(2)
            Dim manYear As Integer = ds.Tables("Car").Rows(0).Item(3)
            Dim cusID As Integer = ds.Tables("Car").Rows(0).Item(4)
            theCar = New car(carID, model, manName, manYear, cusID)
        Else
            theCar = Nothing
        End If
        Return theCar
    End Function
    Public Shared Function GetAll() As ArrayList
        Dim ds As New DataSet
        Dim sql As String = "Select * from Car "
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Car")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        car.Clear()

        If ds.Tables("Car").Rows.Count > 0 Then
            Dim dr As DataRow
            For Each dr In ds.Tables("Car").Rows
                Dim carID As String = dr.Item(0)
                Dim model As String = dr.Item(1)
                Dim manName As String = dr.Item(2)
                Dim manYear As Integer = dr.Item(3)
                Dim cusID As Integer = dr.Item(4)
                car.Add(New car(carID, model, manName, manYear, cusID))
            Next
        End If
        Return car
    End Function



End Class
