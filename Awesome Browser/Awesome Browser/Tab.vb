Imports Awesomium.Core

Public Class Tab
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        'Show settings
        Settings.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        'HomePage load
        WebControl1.Source = New Uri(My.Settings.HomePage)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Go Homepage...you drunk
        WebControl1.Source = New Uri(My.Settings.HomePage)
    End Sub

    Private Sub TheProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheProgramToolStripMenuItem.Click
        'Abut the program
        MsgBox("This is an average web browser made for a school project....thats it")
    End Sub

    Private Sub TheCreatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheCreatorToolStripMenuItem.Click
        'Abut me
        MsgBox("The creator of this browser is Theodore Giannakidis...a guy who watched a tutorial on Youtube....for making this program...thats all")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Leam Back....aha
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Forward
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Combo.Click
        'Stop...Hammer Time
        If WebControl1.IsNavigating Then
            WebControl1.Stop()
            PictureBox1.Visible = False
            Parent.Text = "Navigation Stop"
            Combo.Text = "R"
        End If
        If Not WebControl1.IsNavigating Then
            WebControl1.Reload(ignoreCache:=True)
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else : WebControl1.Source = New Uri("https://www.google.gr/webhp#q=" & TextBox1.Text)

            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'I need Ammo


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        'Enter Button
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = ("http://" + TextBox1.Text)
            End Try
        Else : WebControl1.Source = New Uri("https://www.google.gr/webhp#q=" & TextBox1.Text)

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        'Enter in text bar
        'The google search code changes some times...so i hope it works
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else : WebControl1.Source = New Uri("https://www.google.gr/webhp#q=" & TextBox1.Text)

            End If
        End If

    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        'Load Complete
        Combo.Text = "R"
        PictureBox1.Visible = False
        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString
    End Sub

    Private Sub ThingsToFixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThingsToFixToolStripMenuItem.Click
        MsgBox("There is a strange bug when push enter in Web Control...(like in google).First you must push enter in the url,then it works in the web controller.")
    End Sub

    Private Sub WebControl1_LoadingFrame(sender As Object, e As LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        'Loading
        Combo.Text = "X"
        PictureBox1.Visible = True
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        'New Tab
        Dim tab As New TabPage
        Dim newtab As New Tab
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(tab)
        Form1.TabControl1.SelectedTab = tab


    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        'Remove Tab
        If Form1.TabControl1.TabCount = 1 Then
            Dim tab As New TabPage
            Dim newtab As New Tab
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab)
            Form1.TabControl1.SelectedTab = tab
            Form1.TabControl1.SelectedTab.Dispose()
        Else : Form1.TabControl1.SelectedTab.Dispose()
        End If


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        'Just a button test. XD
        MsgBox("You shall not pass")
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView_1(sender As Object, e As ShowCreatedWebViewEventArgs) Handles WebControl2.ShowCreatedWebView

    End Sub
End Class