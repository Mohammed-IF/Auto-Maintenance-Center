Public Class Form4
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        repair.Initialize()
        ListRecords()

    End Sub
    Public Sub ListRecords()
        Dim rep As ArrayList = repair.GetAll()
        Dim r1 As repair
        Dim data As String = ""
        For Each r1 In rep
            data = data & r1.tellAboutSelf & vbCrLf
        Next
        txtDisplay.Text = data
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cID As Integer = Int(TextBox1.Text)
        Dim techID As Integer = Int(TextBox2.Text)
        Dim ent As DateTime = DateTimePicker1.Text
        Dim nb As Double = Nothing
        Dim theRepair As New repair(cID, techID, nb, ent)
        theRepair.AddNew()
        TextBox1.Clear()
        TextBox2.Clear()
        DateTimePicker1.Value = DateTime.Today
        MessageBox.Show("Car it's in repair")
        ListRecords()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cID As Integer = Int(TextBox1.Text)
        Dim techID As Integer = Int(TextBox2.Text)
        Dim ent As DateTime = DateTimePicker1.Text
        Dim nb As String = Nothing
        Dim theRepair As New repair(cID, techID, nb, ent)

        Dim h As String = theRepair.getnumberOfHours()
        theRepair.Delete()
        TextBox1.Clear()
        TextBox2.Clear()
        DateTimePicker1.Value = DateTime.Today
        MessageBox.Show("car repaired")
        ListRecords()

        MessageBox.Show(h)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c As Integer = TextBox1.Text
        Dim theRepair As repair = repair.Find(c)

        If Not IsNothing(theRepair) Then
            MessageBox.Show(theRepair.tellAboutSelf())


        Else MessageBox.Show("not Found")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' repair.Terminate()
        'Me.Hide()
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form3.ShowDialog()
        Me.Show()
    End Sub
End Class