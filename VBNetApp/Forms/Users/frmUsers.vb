
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmUsers

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        Dim frmuserA As New frmUsersAE
        frmuserA.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim frmuserE As New frmUsersAE
        frmuserE.Label6.Text = "Update User Account"
        frmuserE.fname.Text = lvUsers.SelectedItems(0).SubItems(0).Text
        frmuserE.lname.Text = lvUsers.SelectedItems(0).SubItems(1).Text
        frmuserE.mname.Text = lvUsers.SelectedItems(0).SubItems(2).Text
        frmuserE.username.Text = lvUsers.SelectedItems(0).SubItems(3).Text
        frmuserE.password.Text = lvUsers.SelectedItems(0).SubItems(4).Text
        frmuserE.U_ID.Text = lvUsers.SelectedItems(0).SubItems(5).Text



        frmuserE.Show()
    End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, ToolStripButton4.Click
        FillListView("SELECT u_fname,u_lname,u_mname,u_username,u_password,u_id FROM desk_app.users", lvUsers)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Delete_Users(lvUsers.SelectedItems(0).SubItems(5).Text) Then
            MsgBox("User Succesfully Deleted")

        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim frm As New frmPrintPreview
        frm.ShowPrintrpt2()
    End Sub
End Class