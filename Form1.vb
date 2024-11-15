Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim Query As String
            Query = "select * from test.edata WHERE user_name = '" & NameUser.Text & "' and password = '" & WordPass.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim COUNT As Integer
            COUNT = 0
            While READER.Read
                COUNT = COUNT + 1
            End While

            If COUNT = 1 Then
                MessageBox.Show("UserName and password are correct")
            ElseIf COUNT > 1 Then
                MessageBox.Show("UserName and password are Duplicate")
            Else
                MessageBox.Show("UserName and password are not correct")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

End Class
