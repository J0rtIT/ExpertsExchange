Imports System.Data.SqlClient

Public Class login
    Dim sqlconn As SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim spdr As SqlDataReader

    Public businessobj As New businesscls
    Public businesslst As New List(Of businesscls)

    Public Sub jj()
        sqlconn = New SqlConnection(
            "Server=M-PC\DBS;Initial Catalog=datranDb;Persist Security Info=True;User ID=datranuser;Password=MeatAlways@%_777;")
        sqlconn.Open()
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "select * business"
        spdr = sqlcmd.ExecuteReader
        If spdr.HasRows Then
            Do While spdr.Read
                businessobj.bid = spdr("bid")
                businesslst.Add(businessobj)
            Loop
        End If


    End Sub

    Public Class Businesscls
        Public bid As String
    End Class

End Class