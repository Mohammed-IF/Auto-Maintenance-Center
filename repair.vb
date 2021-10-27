Public Class repair

    Private carID As Integer
    Private tID As Integer
    Private numberOfHours As String
    Private carEntry As DateTime

    Public Sub New(ByVal c As Integer, ByVal t As Integer, ByVal nbh As String, ByVal en As DateTime)
        carID = c : tID = t
        numberOfHours = calculateHours().ToString() : carEntry = en
    End Sub

    Public Function calculateHours() As TimeSpan

        Dim d1 As DateTime = carEntry
        Dim d2 As DateTime = DateTime.Today

        Dim nbh As TimeSpan = d2.Subtract(d1)
        Return nbh

    End Function

    Public Sub SetnumberOfHour(ByVal nb As String)
        numberOfHours = nb
    End Sub

    Public Sub SetcarEntry(ByVal en As DateTime)
        carEntry = en
    End Sub

    Public Sub SetcarID(ByVal c As Integer)
        carID = c
    End Sub
    Public Sub SettID(ByVal t As Integer)
        tID = t
    End Sub
    Public Function getnumberOfHours() As String
        Return numberOfHours
    End Function
    Public Function getcarEntry() As DateTime
        Return carEntry
    End Function

    Public Function getcarID() As Integer
        Return carID
    End Function
    Public Function gettID() As Integer
        Return tID
    End Function

    Public Shared Sub Initialize()
        repairDA.Initialize()
    End Sub

    Public Shared Sub Terminate()
        repairDA.Terminate()
    End Sub
    Public Sub AddNew()
        repairDA.AddNew(Me)
    End Sub
    Public Sub Update()
        repairDA.Update(Me)
    End Sub

    Public Sub Delete()
        repairDA.Delete(Me)
    End Sub
    Public Shared Function Find(ByVal carID1 As Integer) As repair
        Return repairDA.Find(carID1)
    End Function

    Public Shared Function GetAll() As ArrayList
        Return repairDA.GetAll()
    End Function
    Public Function tellAboutSelf() As String
        Return "carID = " & carID & "tID = " & tID & "number of hours = " & getnumberOfHours() & "  date of entry = " & getcarEntry()
    End Function

End Class
