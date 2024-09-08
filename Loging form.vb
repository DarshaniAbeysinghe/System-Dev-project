Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization
Imports System.IO

Public Class Loging_form
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Private cmdd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter '("SELECT * From voter_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer






    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

        Me.Close()


    End Sub



    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If Txtnic.Text = String.Empty Then
            Lbl1.Text = "Please enter your NIC"
        Else
            Try
                dbconn.Open()


                cmd = New MySqlCommand("SELECT * FROM voter_registration WHERE Nic=@Nic AND Status=@Status", dbconn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nic", Txtnic.Text)
                cmd.Parameters.AddWithValue("@Status", "Un-Voted")

                da = New MySqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then

                    PVote.ShowDialog()
                    Me.Close()

                Else
                    cmd = New MySqlCommand("SELECT Status FROM voter_registration WHERE Nic=@Nic", dbconn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Nic", Txtnic.Text)

                    Dim status As String = Convert.ToString(cmd.ExecuteScalar())

                    If status = "Voted" Then
                        Lbl1.Text = "Already Voted"

                    Else
                        Lbl1.Text = "Invalid NIC"
                    End If
                End If

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                dbconn.Close()

            End Try
        End If
    End Sub

    Private Sub Loging_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtnic.Clear()
        Lbl1.Text = "Enter your NIC"

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class