Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Number As Integer

        If IsNumeric(txtNumber.Text) Then
            Number = CInt(txtNumber.Text)

        Else
            MsgBox("Incorrect Pin!")
        End If
    End Sub
End Class
