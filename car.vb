Public Class car

    Private carId As Integer
    Private model As String
    Private manName As String
    Private manYear As Integer
    Private cusID As Integer

    Public Sub New(ByVal id As Integer, ByVal m As String, ByVal na As String, ByVal y As Integer, ByVal cid As Integer)
        carId = id : model = m
        manName = m : manYear = y : cusID = cid
    End Sub

    Public Sub SetcarId(ByVal I As Integer)
        carId = I
    End Sub

    Public Sub SetModel(ByVal m As String)
        model = m
    End Sub
    Public Sub SetmanName(ByVal na As String)
        manName = na
    End Sub

    Public Sub SetmanYear(ByVal y As Integer)
        manYear = y
    End Sub

    Public Sub SetcusID(ByVal cis As Integer)
        cusID = cis
    End Sub
    Public Function getcarId() As Integer
        Return carId
    End Function
    Public Function getmodel() As String
        Return model
    End Function
    Public Function getmanName() As String
        Return manName
    End Function
    Public Function getmanYear() As Integer
        Return manYear
    End Function
    Public Function getcusID() As Integer
        Return cusID
    End Function

    Public Shared Sub Initialize()
        carDA.Initialize()
    End Sub

    Public Shared Sub Terminate()
        carDA.Terminate()
    End Sub
    Public Sub AddNew()
        carDA.AddNew(Me)
    End Sub
    Public Sub Update()
        carDA.Update(Me)
    End Sub

    Public Sub Delete()
        carDA.Delete(Me)
    End Sub
    Public Shared Function Find(ByVal carID1 As Integer) As car
        Return carDA.Find(carID1)
    End Function

    Public Shared Function GetAll() As ArrayList
        Return carDA.GetAll()
    End Function
    Public Function tellAboutSelf() As String
        Return "ID = " & getcarId() & "  model = " & getmodel() & " manufactue name = " & getmanName() & " manufacture year = " & getmanYear() & " customer id = " & getcusID()
    End Function



End Class
