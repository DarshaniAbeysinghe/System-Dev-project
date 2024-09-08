Imports MySql.Data.MySqlClient

Public Class Loging_Form_Par
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Private cmdd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter '("SELECT * From voter_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private txtLbl1 As Object
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub



    Private Sub Loging_Form_Par_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtnic.Clear()
        Lbl1.Text = "Enter your NIC"


    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub



    Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If Txtnic.Text = String.Empty Then
            Lbl1.Text = "Please enter your NIC"

        Else
            Try
                dbconn.Open()


                cmd = New MySqlCommand("SELECT * FROM voter_registration WHERE Nic=@Nic AND Parstatus=@Parstatus", dbconn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nic", Txtnic.Text)
                cmd.Parameters.AddWithValue("@Parstatus", "Un-Voted")

                da = New MySqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Me.Hide()
                    Par1Vote.ShowDialog()


                Else
                    cmd = New MySqlCommand("SELECT Parstatus FROM voter_registration WHERE Nic=@Nic", dbconn)
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

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub
End Class