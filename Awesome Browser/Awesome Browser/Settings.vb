Public Class Settings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Default Homepage
        My.Settings.HomePage = ("http://www.google.com")
        TextBox1.Text = ("http://www.google.com")
        MsgBox("Done")
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.HomePage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Sets Homepage
        My.Settings.HomePage = TextBox1.Text
        MsgBox("Done")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Ok button....closes the settings
        Me.Visible = False
    End Sub
End Class
