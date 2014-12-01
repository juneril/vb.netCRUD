Option Explicit On

Imports MySql.Data.MySqlClient




Module modUsers
    Public Structure users
        Dim u_id As Integer
        Dim u_fname As String
        Dim u_lname As String
        Dim u_mname As String
        Dim u_username As String
        Dim u_password As String
        Dim is_deleted As Short
    End Structure

    Public Function AddUsers(ByVal U As users) As Boolean

        On Error GoTo err
        Dim con As New MySqlConnection(DB_CONNECTION_STRING)
        con.Open()
        Dim sSQL As String = "INSERT INTO users VALUE (null,@u_fname,@u_lname,@u_mname,@u_username,md5(@u_password),'" & U.is_deleted & "')"
        Dim com As New MySqlCommand(sSQL, con)
        com.Parameters.AddWithValue("@u_fname", U.u_fname)
        com.Parameters.AddWithValue("@u_lname", U.u_lname)
        com.Parameters.AddWithValue("@u_mname", U.u_mname)
        com.Parameters.AddWithValue("@u_username", U.u_username)
        com.Parameters.AddWithValue("@u_password", U.u_password)
        com.ExecuteNonQuery()
        com.Parameters.Clear()
        con.Close()
        AddUsers = True
        Exit Function
err:
        AddUsers = False
        DisplayErrorMsg("modUsers", "AddUsers", Err.Number, Err.Description)
    End Function

    Public Function UpdateUsers(ByVal U As users) As Boolean
        On Error GoTo err
        Dim con As New MySqlConnection(DB_CONNECTION_STRING)
        con.Open()
        Dim sSQL As String = "UPDATE users SET u_fname=@u_fname,u_lname=@u_lname,u_mname=@u_mname,u_username=@u_username,u_password=md5(@u_password) WHERE e_id='" & U.u_id & "'"
        Dim com As New MySqlCommand(sSQL, con)
        com.Parameters.AddWithValue("@e_fname", U.u_fname)
        com.Parameters.AddWithValue("@e_lname", U.u_lname)
        com.Parameters.AddWithValue("@e_mname", U.u_mname)
        com.Parameters.AddWithValue("@e_username", U.u_username)
        com.Parameters.AddWithValue("@e_password", U.u_password)
        com.ExecuteNonQuery()
        com.Parameters.Clear()
        con.Close()
        UpdateUsers = True
        Exit Function
err:
        UpdateUsers = False
        DisplayErrorMsg("modUsers", "UpdateUsers", Err.Number, Err.Description)
    End Function
    Public Function Delete_Users(ByVal u_id As String) As Boolean
        If ExecuteQry("DELETE FROM users WHERE u_id='" & u_id & "'") Then
            Delete_Users = True
        Else
            Delete_Users = False
        End If
    End Function

    Public Function DeleteUser(ByVal usr As users) As Boolean
        On Error GoTo err
        Dim con As New MySqlConnection(DB_CONNECTION_STRING)
        con.Open()
        Dim sSQL As String = "UPDATE users SET is_deleted=1 WHERE u_id='" & usr.u_id & "'"
        Dim com As New MySqlCommand(sSQL, con)
        com.ExecuteNonQuery()
        com.Parameters.Clear()
        con.Close()
        DeleteUser = True
        Exit Function
err:
        DeleteUser = False
        DisplayErrorMsg("modEmployees", "DeleteEmployee", Err.Number, Err.Description)
    End Function
    Public Function CheckUserNameExisting(ByVal fname As String, ByVal lname As String, ByVal mname As String, _
                                   ByVal u_id As String) As Boolean

        Dim sSQL As String = "SELECT * FROM users WHERE u_fname='" & fname & _
                        "' AND u_lname='" & fname & "' AND u_mname='" & mname & "' "

        If Len(u_id) > 0 Then
            sSQL = sSQL & "WHERE e_id <> '" & u_id & "' "
        End If
        sSQL = sSQL & "LIMIT 1"

        If QueryHasRows(sSQL) Then
            CheckUserNameExisting = True
        Else
            CheckUserNameExisting = False
        End If
    End Function



End Module
