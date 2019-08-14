Public Class Form1
    Dim FirstNum As Decimal
    Dim SecNum As Decimal
    Dim Operations As String
    Dim Operator_Selector As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn7.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "7"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "7"
        Else
            TxtBox1.Text = "7"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn8.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "8"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "8"
        Else
            TxtBox1.Text = "8"
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtBox1.MaskInputRejected

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "1"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "1"
        Else
            TxtBox1.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "2"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "2"
        Else
            TxtBox1.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "3"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "3"
        Else
            TxtBox1.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "4"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "4"
        Else
            TxtBox1.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "5"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "5"
        Else
            TxtBox1.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "6"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "6"
        Else
            TxtBox1.Text = "6"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "9"
        If TxtBox1.Text <> "0" Then
            TxtBox1.Text += "9"
        Else
            TxtBox1.Text = "9"
        End If
    End Sub

    Private Sub btnDevide_Click(sender As Object, e As EventArgs) Handles btnDevide.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "/"
        FirstNum = TxtBox1.Text
        TxtBox1.Text = "0"
        Operator_Selector = True
        Operations = 4 ' = /

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TxtBox1.Text = CStr(TxtBox1.Text) + "0"
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        TxtBox1.Text = "0"
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        If Operator_Selector = True Then
            SecNum = TxtBox1.Text
            If Operations = 1 Then
                TxtBox1.Text = FirstNum + SecNum
            ElseIf Operations = 2 Then
                TxtBox1.Text = FirstNum - SecNum
            ElseIf Operations = 3 Then
                TxtBox1.Text = FirstNum * SecNum
            Else
                If SecNum = 0 Then
                    TxtBox1.Text = "Error !"
                Else
                    TxtBox1.Text = FirstNum / SecNum
                End If
            End If
            Operator_Selector = False
        End If
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "*"
        FirstNum = TxtBox1.Text
        TxtBox1.Text = "0"
        Operator_Selector = True
        Operations = 3 ' = *
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "-"
        FirstNum = TxtBox1.Text
        TxtBox1.Text = "0"
        Operator_Selector = True
        Operations = 2 ' = -
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        'TxtBox1.Text = CStr(TxtBox1.Text) + "+"
        FirstNum = TxtBox1.Text
        TxtBox1.Text = "0"
        Operator_Selector = True
        Operations = 1 ' = +
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (TxtBox1.Text = "") Then
            TxtBox1.AppendText("0.")
        ElseIf Not TxtBox1.Text.Contains(".") Then
            TxtBox1.AppendText(".")
        End If
    End Sub
End Class
