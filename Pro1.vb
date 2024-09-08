Imports MySql.Data.MySqlClient

Public Class Pro1
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer


    Private WithEvents p1 As New Panel
    Private WithEvents picc As New PictureBox
    Private WithEvents namelbl As New Label
    Private WithEvents namelbl1 As New Label
    Private sender As Object
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Sub loadp()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        p1 = New Panel
        p1.Width = 150
        p1.Height = 200
        p1.Tag = dr.Item("Name").ToString

        picc = New PictureBox
        picc.Width = 100
        picc.Height = 150
        picc.BackgroundImageLayout = ImageLayout.Stretch
        picc.Dock = DockStyle.Bottom
        picc.Tag = dr.Item("Name").ToString

        namelbl = New Label
        namelbl.ForeColor = Color.Black
        namelbl.BackColor = Color.White
        namelbl.TextAlign = ContentAlignment.MiddleCenter
        namelbl.Font = New Font("segoe UI", 8, FontStyle.Bold)
        namelbl.Dock = DockStyle.Top
        namelbl.Tag = dr.Item("Name").ToString
        namelbl.Text = dr.Item("Name").ToString


        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        picc.BackgroundImage = bitmap

        AddHandler picc.Click, AddressOf picc_click




    End Sub
    Private selectedPictureBox As PictureBox = Nothing
    Public Property Voter_registration_District_Variable As Object
    Private Sub picc_click(sender As Object, e As EventArgs)
        If Dgv1.RowCount > 1 Then
            MsgBox("alredy Selected")

        Else

            Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)
            If clickedPictureBox Is selectedPictureBox Then
                Return
            End If
            If selectedPictureBox IsNot Nothing Then

                selectedPictureBox.Enabled = True
            End If

            clickedPictureBox.Enabled = False

            selectedPictureBox = clickedPictureBox
        End If

        LoadDataForSelectedPictureBox()
    End Sub
    Private Sub LoadDataForSelectedPictureBox()
        If selectedPictureBox IsNot Nothing Then
            Dim selectedPartyName As String = selectedPictureBox.Tag.ToString()

            Dim dtParty As New DataTable
            Dim dtVoter As New DataTable


            dbconn.Open()

            Dim partyQuery As String = "SELECT `Name` FROM `party_registration` WHERE `Name` = @PartyName"
            Using cmdParty As New MySqlCommand(partyQuery, dbconn)
                cmdParty.Parameters.AddWithValue("@PartyName", selectedPartyName)
                Using dadParty As New MySqlDataAdapter(cmdParty)
                    dadParty.Fill(dtParty)
                End Using
            End Using


            Dim voterQuery As String = "SELECT `First_Name`, `District` FROM `voter_registration` WHERE Nic = @Nic"
            Using cmdVoter As New MySqlCommand(voterQuery, dbconn)
                cmdVoter.Parameters.AddWithValue("@Nic", Provincial_Loging.Txtnic.Text)
                Using dadVoter As New MySqlDataAdapter(cmdVoter)
                    dadVoter.Fill(dtVoter)
                End Using
            End Using


            Dgv1.DataSource = dtParty
            Dgv2.DataSource = dtVoter
            dbconn.Close()

        End If
    End Sub
    Sub loadlist()
        FlowLayoutPanel1.Controls.Clear()
        Dgv1.DataSource = Nothing
        Dgv2.DataSource = Nothing
        selectedPictureBox = Nothing
        Try

            dbconn.Open()
            cmd = New MySqlCommand("SELECT Defamation,Name FROM party_registration", dbconn)
            dr = cmd.ExecuteReader
            While dr.Read
                loadp()
                p1.Controls.Add(picc)
                p1.Controls.Add(namelbl)
                ' p1.Controls.Add(namelbl1)
                FlowLayoutPanel1.Controls.Add(p1)



            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        dbconn.Close()

    End Sub


    Private Sub Pro1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlist()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub update_votervotestatus()
        Try

            Dim query As String
            query = "UPDATE voter_registration SET Prostatus=@Prostatus WHERE Nic=@Nic"
            cmd = New MySqlCommand(query, dbconn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Prostatus", "Voted")
            cmd.Parameters.AddWithValue("@Nic", value:=Provincial_Loging.Txtnic.Text)
            i = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Try
            dbconn.Open()

            For j As Integer = 0 To Dgv1.Rows.Count - 2
                Dim query As String
                query = "INSERT INTO provoting_details(Nic, Time,District,Selected_Party) VALUES (@Nic, @Time,@District, @Selected_Party)"
                cmd = New MySqlCommand(query, dbconn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nic", Provincial_Loging.Txtnic.Text)
                cmd.Parameters.AddWithValue("@District", Dgv2.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@Time", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@Selected_Party", Dgv1.Rows(j).Cells(0).Value)

                i = cmd.ExecuteNonQuery()
            Next
            If i = 1 Then

                Pro2.ShowDialog()
                Me.Close()


            ElseIf i < 1 Then
                MsgBox("If you want to vote a candidate, please first give your vote for a party")
            Else
                MsgBox("no")

            End If

        Catch ex As Exception
            ' MsgBox($"Error at row {j}: {ex.Message}")
            MsgBox(ex.Message)

        Finally
            update_votervotestatus()
            dbconn.Close()
        End Try



        ' Provincial_Loging.Txtnic.Clear()

        'Me.Hide()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class