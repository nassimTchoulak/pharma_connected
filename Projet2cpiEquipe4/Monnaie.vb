Public Class Monnaie

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) = False Then
            If TextBox2.Text.Length = 0 Then
                TextBox2.Text = ""
            Else

                TextBox2.Text = TextBox2.Text.Substring(0, TextBox2.Text.Length - 1)
            End If
        End If
        mnt.Text = (Val(TextBox1.Text) - Val(TextBox2.Text)) & "DA"
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False Then
            If TextBox1.Text.Length = 0 Then
                TextBox1.Text = ""
            Else

                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
            End If
        End If
        mnt.Text = (Val(TextBox1.Text) - Val(TextBox2.Text)) & "DA"
    End Sub
End Class