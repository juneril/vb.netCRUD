Public Class frmUsers

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        Dim frmuserA As New frmUsersAE
        frmuserA.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim frmuserE As New frmUsersAE
        frmuserE.Label6.Text = "Update User Account"


        frmuserE.Show()
    End Sub
End Class