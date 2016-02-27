Imports System.Data.SqlClient
Imports System.Data
Module Helpper
    Public StringConnect As String = "workstation id=PS03332-INF205-GHOST.mssql.somee.com;packet size=4096;user id=demops03332_SQLLogin_1;pwd=iphaimgu7m;data source=PS03332-INF205-GHOST.mssql.somee.com;persist security info=False;initial catalog=PS03332-INF205-GHOST"
    'Public StringConnect As String = "Data Source=GHOST-PC;Initial Catalog=ANDDPS03332_Database_INF205;Integrated Security=True"
    Public Connect As SqlConnection = New SqlConnection(StringConnect)
End Module
