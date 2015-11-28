Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TextBox3.Text += Me.TextBox1.Text + " on: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " : " + Me.TextBox2.Text + Environment.NewLine
    End Sub
End Class
