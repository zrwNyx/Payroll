Public Class Form1

    Sub childForm(ByVal form As Form)
        pnlMain.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlMain.Controls.Add(form)
        form.Show()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        childForm(HomeForm)
    End Sub

    Private Sub btnWorker_Click(sender As Object, e As EventArgs) Handles btnWorker.Click

        childForm(DetailForm)
    End Sub
End Class
