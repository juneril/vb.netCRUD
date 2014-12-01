

Option Explicit On

Public Class frmUsersAE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Label6.Text = "Create User Account") Then

            Dim u As New users

            u.u_fname = Me.TextBox1.Text
            u.u_lname = Me.TextBox2.Text
            u.u_mname = Me.TextBox3.Text
            u.u_username = Me.TextBox4.Text
            u.u_password = Me.TextBox5.Text



            If AddUsers(u) Then
                MsgBox("REcord succesfully save")
            End If


        End If
    End Sub
End Class