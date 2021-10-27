Imports System.Data
Imports System.Data.OleDb
Public Class technicianDA
    Private Shared con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\New folder\AMC1-2003.mdb")
    Private Shared technician As New ArrayList
    Private Shared theTechnician As technician

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

    Public Shared Sub AddNew(ByVal tech As technician)
        Dim techID As Integer = tech.gettechID()
        Dim techName As String = tech.gettechName()
        Dim techBirth As DateTime = tech.gettechBirth
        Dim techSpecialization As String = tech.gettechSpecialization()

        Dim sql As String = "Insert Into Technician ([tID],[tName],[birthDate],[specialization]) Values ('" & techID & "', '" & techName & "', '" & techBirth & "', '" & techSpecialization & "' )"
        Dim da As New OleDbDataAdapter()


        Try
            da.InsertCommand = New OleDbCommand(sql)
            da.InsertCommand.Connection = con
            da.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Update(ByVal tech As technician)
        Dim techID As Integer = tech.gettechID()
        Dim techName As String = tech.gettechName()
        Dim techBirth As DateTime = tech.gettechBirth
        Dim techSpecialization As String = tech.gettechSpecialization()

        Dim sql As String = "Update Technician Set techName= '" & techName & "', BirthDate=" & techBirth & ", techSpecialization=" & techSpecialization & "'  Where techID =" & techID
        Dim da As New OleDbDataAdapter()

        Try
            da.UpdateCommand = New OleDbCommand(sql)
            da.UpdateCommand.Connection = con
            da.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Delete(ByVal tech As technician)
        Dim techID As Integer = tech.gettechID()
        Dim techName As String = tech.gettechName()
        Dim techBirth As DateTime = tech.gettechBirth
        Dim techSpecialization As String = tech.gettechSpecialization()

        Dim sql As String = "Delete From Technician Where tID ='" & techID & "'"
        Dim da As New OleDbDataAdapter()

        Try
            da.DeleteCommand = New OleDbCommand(sql)
            da.DeleteCommand.Connection = con
            da.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Function Find(ByVal techID As Integer) As technician
        Dim ds As New DataSet
        Dim sql As String = "Select * from Technician where StudentID ='" & techID & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Technician")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If ds.Tables("Technician").Rows.Count > 0 Then

            Dim techName As String = ds.Tables("Technician").Rows(0).Item(1)
            Dim techBirth As DateTime = ds.Tables("Technician").Rows(0).Item(2)
            Dim techSpecialization As String = ds.Tables("Technician").Rows(0).Item(3)

            theTechnician = New technician(techID, techName, techBirth, techSpecialization)
        Else
            theTechnician = Nothing
        End If
        Return theTechnician
    End Function
    Public Shared Function GetAll() As ArrayList
        Dim ds As New DataSet
        Dim sql As String = "Select * from Technician "
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Technician")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        technician.Clear()

        If ds.Tables("Technician").Rows.Count > 0 Then
            Dim dr As DataRow
            For Each dr In ds.Tables("Technician").Rows
                Dim techID As Integer = dr.Item(0)
                Dim techName As String = dr.Item(1)
                Dim techBirth As DateTime = dr.Item(2)
                Dim techSpecialization As String = dr.Item(3)

                technician.Add(New technician(techID, techName, techBirth, techSpecialization))
            Next
        End If
        Return technician
    End Function




End Class
