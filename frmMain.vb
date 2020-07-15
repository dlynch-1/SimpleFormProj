Public Class frmMain
    Private Sub btnClick_Me_Click(sender As Object, e As EventArgs) Handles btnClick_Me.Click
        MessageBox.Show("Thanks for clicking me!", "Testing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
