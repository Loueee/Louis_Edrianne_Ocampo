Public Class Form1
    Dim firstval As Double
    Dim secondval As Double
    Dim [Operator] As String



    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        txt_total.Text = txt_total.Text & sender.text

    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        txt_total.Text = txt_total.Text & sender.text

    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub multiply_btn_Click(sender As Object, e As EventArgs) Handles multiplication_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "*"
        txt_total.Text = ""


    End Sub

    Private Sub total_btn_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        secondval = Val(txt_total.Text)
        Select Case [Operator]
            Case Is = "+"
                Result = firstval + secondval
                txt_total.Text = Result.ToString()
            Case Is = "-"
                Result = firstval - secondval
                txt_total.Text = Result.ToString()
            Case Is = "*"
                Result = firstval * secondval
                txt_total.Text = Result.ToString()
            Case Is = "/"
                Result = firstval / secondval
                txt_total.Text = Result.ToString()

        End Select
    End Sub



    Private Sub slash_btn_Click(sender As Object, e As EventArgs) Handles division_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "/"
        txt_total.Text = ""

    End Sub

    Private Sub subtraction_btn_Click(sender As Object, e As EventArgs) Handles subtraction_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "-"
        txt_total.Text = ""

    End Sub

    Private Sub addition_btn_Click(sender As Object, e As EventArgs) Handles addition_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "+"
        txt_total.Text = ""
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
  
        txt_total.Text = ""
        firstval = 0
        secondval = 0
        [Operator] = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
