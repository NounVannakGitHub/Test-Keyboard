Public Class Form1

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(1)
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(0)
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(1)
    End Sub
    
End Class
