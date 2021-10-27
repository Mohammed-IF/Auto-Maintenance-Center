Imports System.Data
Imports System.Data.OleDb
Public Class customerDA
    Private Shared con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\New folder\AMC1-2003.mdb")
    Private Shared customer As New ArrayList
    Private Shared theCustomer As customer

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

    Public Shared Sub AddNew(ByVal cus As customer)
        Dim cusID As Integer = cus.getcusID()
        Dim cusName As String = cus.getcusName()
        Dim cusNat As String = cus.getcusNationality()
        Dim cusPhone As Integer = cus.getcusPhone()

        Dim sql As String = "Insert Into Customer Values ('" & cusID & "', '" & cusName & "', '" & cusNat & "', " & cusPhone & " )"
        Dim da As New OleDbDataAdapter()

        Try
            da.InsertCommand = New OleDbCommand(sql)
            da.InsertCommand.Connection = con
            da.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Update(ByVal cus As customer)
        Dim cusID As Integer = cus.getcusID()
        Dim cusName As String = cus.getcusName()
        Dim cusNat As String = cus.getcusNationality()
        Dim cusPhone As Integer = cus.getcusPhone()

        Dim sql As String = "Update Customer Set cusName=" & cusName & ", nationality=" & cusNat & ", " & ", phoneNum=" & cusPhone & "'  Where cusID =" & cusID
        Dim da As New OleDbDataAdapter()

        Try
            da.UpdateCommand = New OleDbCommand(sql)
            da.UpdateCommand.Connection = con
            da.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Delete(ByVal cus As customer)
        Dim cusID As Integer = cus.getcusID()
        Dim cusName As String = cus.getcusName()
        Dim cusNat As String = cus.getcusNationality()
        Dim cusPhone As Integer = cus.getcusPhone()

        Dim sql As String = "Delete From Customer Where cusID ='" & cusID & "'"
        Dim da As New OleDbDataAdapter()

        Try
            da.DeleteCommand = New OleDbCommand(sql)
            da.DeleteCommand.Connection = con
            da.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Function Find(ByVal cusID As Integer) As customer
        Dim ds As New DataSet
        Dim sql As String = "Select * from Cusromer where cusID ='" & cusID & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Customer")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If ds.Tables("Customer").Rows.Count > 0 Then

            Dim cusName As String = ds.Tables("Customer").Rows(0).Item(1)
            Dim cusNat As String = ds.Tables("Customer").Rows(0).Item(2)
            Dim cusPhone As Integer = ds.Tables("Customer").Rows(0).Item(3)

            theCustomer = New customer(cusID, cusName, cusNat, cusPhone)
        Else
            theCustomer = Nothing
        End If
        Return theCustomer
    End Function
    Public Shared Function GetAll() As ArrayList
        Dim ds As New DataSet
        Dim sql As String = "Select * from Customer "
        Dim da As New OleDbDataAdapter(sql, con)
        Try
            da.Fill(ds, "Customer")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        customer.Clear()

        If ds.Tables("Customer").Rows.Count > 0 Then
            Dim dr As DataRow
            For Each dr In ds.Tables("Customer").Rows
                Dim cusID As Integer = dr.Item(0)
                Dim cusName As String = dr.Item(1)
                Dim cusNat As String = dr.Item(2)
                Dim cusPhone As Integer = dr.Item(3)

                customer.Add(New customer(cusID, cusName, cusNat, cusPhone))
            Next
        End If
        Return customer
    End Function

End Class
