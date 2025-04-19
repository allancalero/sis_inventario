Imports MySql.Data.MySqlClient
Module conexionbase
    Public conex As New MySqlConnection
    Public ds As DataSet = New DataSet
    Public da As MySqlDataAdapter
    Public comando As MySqlCommand
    Dim conectar As String

    Sub conexion()
        conectar = "server=localhost;user=root;password='2';database=inventario"
        Try
            conex.ConnectionString = conectar
            conex.Open()
            MsgBox("Conexion Sastifactoria")

        Catch ex As Exception
            MsgBox("Error en la contraseña" + ex.Message)

        End Try
    End Sub



End Module
