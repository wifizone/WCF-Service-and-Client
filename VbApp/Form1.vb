
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numbers As ServiceReference1.Numbers = new ServiceReference1.Numbers()
        Dim myService As ServiceReference1.Service1Client = New ServiceReference1.Service1Client()

        MessageBox.Show(myService.CalculateNumbers(Convert.ToInt32(NumericUpDown1.Value), Convert.ToInt32(NumericUpDown2.Value)).Sum)

    End Sub
End Class
