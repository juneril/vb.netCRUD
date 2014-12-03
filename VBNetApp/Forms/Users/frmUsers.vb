
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmUsers

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        Dim frmuserA As New frmUsersAE
        frmuserA.ShowDialog()
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
        GetPhoto("SELECT Pic FROM desk_app.users where u_id='" & lvUsers.SelectedItems(0).SubItems(5).Text & "';", frmuserE.pic_display)
        frmuserE.ShowDialog()
    End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, ToolStripButton4.Click
        FillListView("SELECT u_fname,u_lname,u_mname,u_username,u_password,u_id FROM desk_app.users", lvUsers)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim result As Integer = MessageBox.Show("Are You Sure?", "caption", MessageBoxButtons.YesNo)
       
        If result = DialogResult.No Then
            MessageBox.Show("Thanks")
        ElseIf result = DialogResult.Yes Then
            If Delete_Users(lvUsers.SelectedItems(0).SubItems(5).Text) Then
                MsgBox("User Succesfully Deleted")

            End If
        End If


    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim frm As New frmPrintPreview
        frm.ShowPrintrpt2()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        MsgBox(GetIPv4Address())

    End Sub

    Private Sub KkjhjToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KkjhjToolStripMenuItem.Click
        Dim frmuserA As New frmUsersAE
        frmuserA.ShowDialog()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are You Sure?", "caption", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            MessageBox.Show("Thanks")
        ElseIf result = DialogResult.Yes Then
            If Delete_Users(lvUsers.SelectedItems(0).SubItems(5).Text) Then
                MsgBox("User Succesfully Deleted")

            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FillListView("SELECT u_fname,u_lname,u_mname,u_username,u_password,u_id FROM desk_app.users", lvUsers)
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUserToolStripMenuItem.Click
        Dim frmuserE As New frmUsersAE


        frmuserE.Label6.Text = "Update User Account"
        frmuserE.fname.Text = lvUsers.SelectedItems(0).SubItems(0).Text
        frmuserE.lname.Text = lvUsers.SelectedItems(0).SubItems(1).Text
        frmuserE.mname.Text = lvUsers.SelectedItems(0).SubItems(2).Text
        frmuserE.username.Text = lvUsers.SelectedItems(0).SubItems(3).Text
        frmuserE.password.Text = lvUsers.SelectedItems(0).SubItems(4).Text
        frmuserE.U_ID.Text = lvUsers.SelectedItems(0).SubItems(5).Text
        GetPhoto("SELECT Pic FROM desk_app.users where u_id='" & lvUsers.SelectedItems(0).SubItems(5).Text & "';", frmuserE.pic_display)
        frmuserE.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim frmaddphoto As New frmUserPhoto
        frmaddphoto.u_id.Text = lvUsers.SelectedItems(0).SubItems(5).Text
        frmaddphoto.ShowDialog()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Dim frmPracticeGetPhotos As New frmPracticeGetPhoto
        GetPhoto("SELECT Pic FROM desk_app.users where u_id='" & lvUsers.SelectedItems(0).SubItems(5).Text & "';", frmPracticeGetPhotos.PictureBox1)
        frmPracticeGetPhotos.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FillListView("SELECT u_fname,u_lname,u_mname,u_username,u_password,u_id FROM desk_app.users where u_fname like  '" & TextBox1.Text & "%' or u_lname like '" & TextBox1.Text & "%'", lvUsers)
    End Sub
End Class