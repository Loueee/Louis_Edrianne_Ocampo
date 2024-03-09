Public Class Form1

    Private Sub Evaluate_BTN_Click(sender As Object, e As EventArgs) Handles MyBase.Click

       

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim math As Integer
        Dim science As Integer
        Dim english As Integer
        Dim Grade As Double


        math = Val(Mathtextbox.Text)
        science = Val(Sciencetextbox.Text)
        english = Val(Englishtextbox.Text)

        Grade = (math + science + english)
        Grade = Grade / 3

        If Grade >= 90 Then
            MsgBox("A+")
        ElseIf Grade >= 80 Then
            MsgBox("B+")
        ElseIf Grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("failed")
        End If
    End Sub
End Class

