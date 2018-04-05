Public Class Form1

    'Joseph Sanger

    Dim userInput As String


    Sub AlphaSort()
        userInput = txtUserInput.Text
        Dim charArray() As Char = userInput.ToCharArray
        Array.Sort(charArray)
        Dim result As String
        result = New String(userInput.OrderBy(Function(c) c).ToArray())
        MessageBox.Show("Your text sorted alphabetically is: " & result)
    End Sub

    Sub NonRepeat()
        userInput = txtUserInput.Text
        For Each ch As Char In userInput
            If userInput.Contains(ch & ch) = False Then
                MessageBox.Show("First non-repeating character is: " & ch)
                Exit For
            Else
                MessageBox.Show("No non-repeating characters")
                Exit For
            End If
        Next
    End Sub

    Private Sub btnAlpha_Click(sender As Object, e As EventArgs) Handles btnAlpha.Click
        AlphaSort()
    End Sub

    Private Sub btnFNR_Click(sender As Object, e As EventArgs) Handles btnFNR.Click
        NonRepeat()
    End Sub

End Class
