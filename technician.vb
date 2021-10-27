Public Class technician

    Private techID As Integer
    Private techName As String
    Private techBirth As DateTime
    Private techSpecialization As String

    Public Sub New(ByVal id As Integer, ByVal na As String, ByVal b As DateTime, ByVal s As String)
        techID = id : techName = na
        techBirth = b : techSpecialization = s
    End Sub

    Public Sub SettechID(ByVal I As Integer)
        techID = I
    End Sub

    Public Sub SettechName(ByVal na As String)
        techName = na
    End Sub
    Public Sub SettechBirth(ByVal b As DateTime)
        techBirth = b
    End Sub

    Public Sub SettechSpecialization(ByVal s As String)
        techSpecialization = s
    End Sub

    Public Function gettechID() As Integer
        Return techID
    End Function
    Public Function gettechName() As String
        Return techName
    End Function
    Public Function gettechBirth() As DateTime
        Return techBirth
    End Function
    Public Function gettechSpecialization() As String
        Return techSpecialization
    End Function

    Public Function tellAboutSelf() As String
        Return "ID = " & gettechID() & "  name = " & gettechName() & " birth = " & gettechBirth() & "specialization= " & gettechSpecialization()
    End Function

    Public Shared Sub Initialize()
        technicianDA.Initialize()
    End Sub

    Public Shared Sub Terminate()
        technicianDA.Terminate()
    End Sub
    Public Sub AddNew()
        technicianDA.AddNew(Me)
    End Sub
    Public Sub Update()
        technicianDA.Update(Me)
    End Sub

    Public Sub Delete()
        technicianDA.Delete(Me)
    End Sub
    Public Shared Function Find(ByVal techID1 As Integer) As technician
        Return technicianDA.Find(techID1)
    End Function

    Public Shared Function GetAll() As ArrayList
        Return technicianDA.GetAll()
    End Function


End Class
