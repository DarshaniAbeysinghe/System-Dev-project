﻿Imports MySql.Data.MySqlClient

Public Class Provincial_Loging
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Provincial_Loging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtnic.Clear()
        Lbl1.Text = "Enter your NIC"

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If Txtnic.Text = String.Empty Then
            Lbl1.Text = "Please enter your NIC"

        Else
            Try
                dbconn.Open()

                ' Check if the NIC exists in voter_registration and has "Un-Voted" status
                cmd = New MySqlCommand("SELECT * FROM voter_registration WHERE Nic=@Nic AND Prostatus=@Prostatus", dbconn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nic", Txtnic.Text)
                cmd.Parameters.AddWithValue("@Prostatus", "Un-Voted")

                da = New MySqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Me.Hide()
                    Pro1Province.ShowDialog()


                Else
                    cmd = New MySqlCommand("SELECT Prostatus FROM voter_registration WHERE Nic=@Nic", dbconn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Nic", Txtnic.Text)

                    Dim Parstatus As String = Convert.ToString(cmd.ExecuteScalar())

                    If Parstatus = "Voted" Then
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

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub
End Class