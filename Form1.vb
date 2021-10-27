Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        customer.Initialize()
        ListRecords()

    End Sub
    Public Sub ListRecords()
        Dim csts As ArrayList = customer.GetAll()
        Dim s1 As customer
        Dim data As String = ""
        For Each s1 In csts
            data = data & s1.tellAboutSelf & vbCrLf
        Next
        txtDisplay.Text = data
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cID As Integer = TextBox1.Text
        Dim name As String = TextBox2.Text
        Dim nat As String = TextBox3.Text
        Dim phone As Integer = TextBox4.Text
        Dim theCustomer As New customer(cID, name, nat, phone)
        theCustomer.AddNew()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        MessageBox.Show("Customer Added")
        ListRecords()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim cID As Integer = TextBox1.Text
        Dim name As String = TextBox2.Text
        Dim nat As String = TextBox3.Text
        Dim phone As Integer = TextBox4.Text
        Dim theCustomer As New customer(cID, name, nat, phone)
        theCustomer.Delete()
        MessageBox.Show("Customer Deleted")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        ListRecords()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub
End Class
