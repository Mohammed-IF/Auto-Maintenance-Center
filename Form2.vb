Public Class Form2
    Private Sub form2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        car.Initialize()
        ListRecords()

    End Sub
    Public Sub ListRecords()
        Dim cars As ArrayList = car.GetAll()
        Dim c1 As car
        Dim data As String = ""
        For Each c1 In cars
            data = data & c1.tellAboutSelf & vbCrLf
        Next
        txtDisplay.Text = data
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim carID As Integer = TextBox1.Text
        Dim model As String = TextBox2.Text
        Dim manuName As String = TextBox3.Text
        Dim manuYear As Integer = TextBox4.Text
        Dim cusID As Integer = TextBox5.Text
        Dim theCar As New car(carID, model, manuName, manuYear, cusID)
        theCar.AddNew()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        MessageBox.Show("Car Added")
        ListRecords()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim carID As Integer = TextBox1.Text
        Dim model As String = TextBox2.Text
        Dim manuName As String = TextBox3.Text
        Dim manuYear As Integer = TextBox4.Text
        Dim cusID As Integer = TextBox5.Text
        Dim theCar As New car(carID, model, manuName, manuYear, cusID)
        theCar.Delete()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        MessageBox.Show("Car deleted")
        ListRecords()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub
End Class