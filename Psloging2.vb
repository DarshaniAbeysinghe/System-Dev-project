Imports MySql.Data.MySqlClient

Public Class Psloging2
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Private cmdd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter '("SELECT * From voter_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private electionCount As Integer ' Declare the variable at the class level

    Private Sub Psloging2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbconn.Open()

            Dim cmd As New MySqlCommand("SELECT pradeshiya_saba FROM voter_registration WHERE Nic=@Nic", dbconn)
            cmd.Parameters.AddWithValue("@Nic", Psloging.Txtnic.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim Pradeshiya_sabaFromDatabase As String = reader("pradeshiya_saba").ToString()
                reader.Close() ' Close the reader since you have the required data

                Lbl1.Text = Pradeshiya_sabaFromDatabase

                Dim electionCheckCmd As New MySqlCommand("SELECT COUNT(*) FROM elections WHERE place=@Place", dbconn)
                electionCheckCmd.Parameters.AddWithValue("@Place", Pradeshiya_sabaFromDatabase)

                electionCount = CInt(electionCheckCmd.ExecuteScalar())
            Else
                reader.Close() ' Close the reader since you didn't find the NIC
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
            ps1.ShowDialog()
            Me.Close()

        Else
            MsgBox("This is not an election related to your Pradeshiya saba")
            Me.Close()
        End If
    End Sub
End Class