Imports MySql.Data.MySqlClient

Module db_connection
    Public connect As MySqlConnection
    Public Sub con()
        Dim connectionstring As String
        connectionstring = "server =localhost;user id=root;database=db_sunshine_supermarket; password = Info.0515"
        connect = New MySqlConnection(connectionstring)

    End Sub
End Module
