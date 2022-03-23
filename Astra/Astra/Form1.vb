Public Class Form1

    Dim Uo, Tx, n, val As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "Hello i am Astra, i'm gonna compute a total valorisation of an investment based on certain timeframe and interest rate. Even though, make sure to understand that this calculation is just a digit, some economical factors can reduce a little bit this valorisation, anyway this an approximative value of how much you can get at a fix inerest rate and an antifragil strategy in your investment"

        RichTextBox1.Enabled = False

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Uo = Convert.ToDouble(TextBox1.Text)
            Tx = Convert.ToDouble(TextBox2.Text)
            n = Convert.ToDouble(TextBox3.Text)

            val = Uo * Math.Pow((1 + Tx / 100), n)

            TextBox4.Text = val.ToString("##,##,###.00")

        Catch ex As Exception

            MsgBox("Please, fill accurate data type in")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
