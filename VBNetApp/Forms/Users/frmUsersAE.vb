

Option Explicit On

Public Class frmUsersAE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Label6.Text = "Create User Account") Then

            Dim u As New users

            u.u_fname = Me.fname.Text
            u.u_lname = Me.lname.Text
            u.u_mname = Me.mname.Text
            u.u_username = Me.username.Text
            u.u_password = Me.password.Text



            If AddUsers(u) Then
                MsgBox("REcord succesfully save")
            End If


        End If
        If (Label6.Text = "Update User Account") Then
            Dim u As New users
            u.u_id = Convert.ToInt32(Me.U_ID.Text)
            u.u_fname = Me.fname.Text
            u.u_lname = Me.lname.Text
            u.u_mname = Me.mname.Text
            u.u_username = Me.username.Text
            u.u_password = Me.password.Text

            If UpdateUsers(u) Then
                MsgBox("REcord Succesfully Updated")
            End If


        End If
    End Sub
End Class