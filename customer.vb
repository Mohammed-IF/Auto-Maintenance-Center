Public Class customer

    Private cusID As Integer
    Private cusName As String
    Private cusNat As String
    Private cusPhone As Integer
    Private theCars As ArrayList

    Public Sub New(ByVal id As Integer, ByVal n As String, ByVal nat As String, ByVal p As Integer)
        cusID = id : cusName = n
        cusNat = nat : cusPhone = p
        theCars = New ArrayList()
    End Sub

    Public Sub AddCars(ByVal c As car)
        theCars.Add(c)
    End Sub
    Public Sub SetCusomerId(ByVal I As Integer)
        cusID = I
    End Sub

    Public Sub SetcusName(ByVal n As String)
        cusName = n
    End Sub
    Public Sub SetusNationality(ByVal na As String)
        cusNat = na
    End Sub

    Public Sub SetcusPhone(ByVal p As Integer)
        cusPhone = p
    End Sub

    Public Function getcusID() As Integer
        Return cusID
    End Function
    Public Function getcusName() As String
        Return cusName
    End Function
    Public Function getcusNationality() As String
        Return cusNat
    End Function
    Public Function getcusPhone() As Integer
        Return cusPhone
    End Function

    ' Public Funcion getCars() As ArrayList
    'Return theCars
    'End Function

    Public Function tellAboutSelf() As String
        Return "ID = " & getcusID() & "  Name = " & getcusName() & " nationality = " & getcusNationality() & " phone = " & getcusPhone()
    End Function

    Public Shared Sub Initialize()
        customerDA.Initialize()
    End Sub

    Public Shared Sub Terminate()
        customerDA.Terminate()
    End Sub
    Public Sub AddNew()
        customerDA.AddNew(Me)
    End Sub
    Public Sub Update()
        customerDA.Update(Me)
    End Sub

    Public Sub Delete()
        customerDA.Delete(Me)
    End Sub
    Public Shared Function Find(ByVal cusID1 As Integer) As customer
        Return customerDA.Find(cusID1)
    End Function

    Public Shared Function GetAll() As ArrayList
        Return customerDA.GetAll()
    End Function



End Class
