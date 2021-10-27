Public Class Form3
    Private Sub form3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        technician.Initialize()
        ListRecords()

    End Sub
    Public Sub ListRecords()
        Dim technicians As ArrayList = technician.GetAll()
        Dim t1 As technician
        Dim data As String = ""
        For Each t1 In technicians
            data = data & t1.tellAboutSelf & vbCrLf
        Next
        txtDisplay.Text = data
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim techID As String = Int(TextBox1.Text)
        Dim techName As String = TextBox2.Text
        Dim techBirth As DateTime = DateTimePicker1.Text
        Dim techSpecialization As String = TextBox3.Text
        Dim theTechnician As New technician(techID, techName, techBirth, techSpecialization)
        theTechnician.AddNew()
        TextBox1.Clear()
        TextBox2.Clear()
        DateTimePicker1.Value = DateTime.Today
        TextBox3.Clear()
        MessageBox.Show("Technician Added")
        ListRecords()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim techID As String = Int(TextBox1.Text)
        Dim techName As String = TextBox2.Text
        Dim techBirth As DateTime = DateTimePicker1.Text
        Dim techSpecialization As String = TextBox3.Text
        Dim theTechnician As New technician(techID, techName, techBirth, techSpecialization)
        theTechnician.Delete()
        TextBox1.Clear()
        TextBox2.Clear()
        DateTimePicker1.Value = DateTime.Today
        TextBox3.Clear()
        MessageBox.Show("Technician Deleted")
        ListRecords()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub
End Class