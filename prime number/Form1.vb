Public Class Form1

    Sub CheckPrimeNumber(ByVal n As Integer)
        Dim isPrime As Boolean = True

        If (n <= 1) Then
            MsgBox("ไม่เป็นจำนวนเฉพาะ")
            Exit Sub
        End If

        If (n Mod 2 = 0 And n <> 2) Then
            isPrime = True
        ElseIf (n Mod 3 = 0 And n <> 3) Then
            isPrime = True
        ElseIf (n Mod 7 = 0 And n <> 7) Then
            isPrime = True
        ElseIf (n Mod 5 = 0 And n <> 5) Then
            isPrime = True
        Else
            isPrime = False
        End If


        If isPrime = False Then
            MsgBox("เป็นจำนวนเฉพาะ")
        Else
            MsgBox("ไม่เป็นจำนวนเฉพาะ")
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        CheckPrimeNumber(txtInput.Text) 'ส่งตัวเลขจาก text box ไปฟังชั่น
    End Sub
End Class
