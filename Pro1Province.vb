Imports MySql.Data.MySqlClient

Public Class Pro1Province
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Private cmdd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter '("SELECT * From voter_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private electionCount As Integer

    Private Sub Pro1Province_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbconn.Open()

            Dim cmd As New MySqlCommand("SELECT Province FROM voter_registration WHERE Nic=@Nic", dbconn)
            cmd.Parameters.AddWithValue("@Nic", Provincial_Loging.Txtnic.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim provinceFromDatabase As String = reader("Province").ToString()
                reader.Close()

                Lbl1.Text = provinceFromDatabase

                Dim electionCheckCmd As New MySqlCommand("SELECT COUNT(*) FROM elections WHERE place=@Place", dbconn)
                electionCheckCmd.Parameters.AddWithValue("@Place", provinceFromDatabase)

                electionCount = CInt(electionCheckCmd.ExecuteScalar())
            Else
                reader.Close()
                MsgBox("NIC not found in voter registration")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            dbconn.Close()
        End Try
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        If electionCount > 0 Then
            Pro1.ShowDialog()
            Me.Close()

        Else
            MsgBox("This is not an election related to your province")
            Me.Close()
        End If
    End Sub
End Class