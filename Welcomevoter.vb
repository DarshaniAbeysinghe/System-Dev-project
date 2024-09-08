Imports MySql.Data.MySqlClient

Public Class Vote1
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Private cmdd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter '("SELECT * From voter_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            dbconn.Open()

            cmd = New MySqlCommand("SELECT Name, StartDate FROM Elections", dbconn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim currentDate As DateTime = Date.Now
            Dim hasElections As Boolean = False ' Initialize the flag to False

            While reader.Read()
                Dim electionName As String = reader("Name").ToString()
                Dim startDate As Object = reader("StartDate")

                If startDate IsNot Nothing Then
                    Dim startDateTime As DateTime = Convert.ToDateTime(startDate)

                    If currentDate.Date = startDateTime.Date Then ' Compare only the Date part
                        If electionName = "Presidential Election" Then
                            Loging_form.ShowDialog()
                            hasElections = True ' Set the flag to True if elections are found

                            Exit While


                        ElseIf electionName = "Parliament Election" Then
                            Loging_Form_Par.ShowDialog()
                            hasElections = True ' Set the flag to True if elections are found

                            Exit While

                        ElseIf electionName = "Provincial Election" Then
                            Provincial_Loging.ShowDialog()
                            hasElections = True ' Set the flag to True if elections are found

                            Exit While

                        ElseIf electionName = "Pradeshiya Saba Election" Then
                            Psloging.ShowDialog()
                            hasElections = True ' Set the flag to True if elections are found

                            Exit While
                        End If
                    End If
                End If
            End While

            reader.Close()

            If Not hasElections Then
                MsgBox("No elections are sheduled")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconn.Close()



        End Try




    End Sub

    Private Sub Vote1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Date.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class