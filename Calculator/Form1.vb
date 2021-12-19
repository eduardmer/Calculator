Public Class Form1

    Dim initialValue As Double
    Dim firstOperator As Boolean
    Dim operatorSelected As Boolean
    Dim operation As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialValue = 0
        firstOperator = True
        operatorSelected = False
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button11.Click, Button10.Click, Button1.Click
        Dim button = CType(sender, Button)
        If operatorSelected Then
            operatorSelected = False
            If button.Text.Equals(".") Then
                textView.Text = "0."
            Else
                textView.Text = button.Text
            End If
        Else
            If button.Text.Equals(".") Then
                If Not textView.Text.Contains(".") Then
                    textView.Text += "."
                End If
            Else
                If Not textView.Text.Equals("0") Then
                    textView.Text += button.Text
                Else
                    textView.Text = button.Text
                End If
            End If
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        textView.Text = "0"
        initialValue = 0
        firstOperator = True
        operatorSelected = False
    End Sub

    Private Sub Operator_Clicked(sender As Object, e As EventArgs) Handles multiplyButton.Click, plusButton.Click, minusButton.Click, dividerButton.Click
        Dim button = CType(sender, Button)
        operatorSelected = True
        If firstOperator Then
            initialValue = Double.Parse(textView.Text)
            firstOperator = False
        Else
            Select Case operation
                Case "+"
                    initialValue = initialValue + Double.Parse(textView.Text)
                Case "-"
                    initialValue = initialValue - Double.Parse(textView.Text)
                Case "/"
                    initialValue = initialValue / Double.Parse(textView.Text)
                Case "X"
                    initialValue = initialValue * Double.Parse(textView.Text)
            End Select
            textView.Text = initialValue.ToString
        End If
        operation = button.Text
    End Sub

    Private Sub Result_Clicked(sender As Object, e As EventArgs) Handles Button17.Click
        operatorSelected = True
        firstOperator = True
        Select Case operation
            Case "+"
                initialValue = initialValue + Double.Parse(textView.Text)
            Case "-"
                initialValue = initialValue - Double.Parse(textView.Text)
            Case "/"
                initialValue = initialValue / Double.Parse(textView.Text)
            Case "X"
                initialValue = initialValue * Double.Parse(textView.Text)
        End Select
        textView.Text = initialValue
    End Sub
End Class
