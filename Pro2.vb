Imports MySql.Data.MySqlClient

Public Class Pro2
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
    Private Sub Pro2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlist()
    End Sub
    Sub loadp()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        p1 = New Panel
        p1.Width = 150
        p1.Height = 200
        p1.Tag = dr.Item("First_Name").ToString

        picc = New PictureBox
        picc.Width = 100
        picc.Height = 150
        picc.BackgroundImageLayout = ImageLayout.Stretch
        picc.Dock = DockStyle.Bottom
        picc.Tag = dr.Item("First_Name").ToString

        namelbl = New Label
        namelbl.ForeColor = Color.Black
        namelbl.BackColor = Color.White
        namelbl.TextAlign = ContentAlignment.MiddleCenter
        namelbl.Font = New Font("segoe UI", 8, FontStyle.Bold)
        namelbl.Dock = DockStyle.Top
        namelbl.Tag = dr.Item("First_Name").ToString
        namelbl.Text = dr.Item("First_Name").ToString



        namelbl1 = New Label
        namelbl1.ForeColor = Color.Black
        namelbl1.BackColor = Color.White
        namelbl1.TextAlign = ContentAlignment.MiddleCenter
        namelbl1.Font = New Font("segoe UI", 8, FontStyle.Bold)
        namelbl1.Dock = DockStyle.Top
        namelbl1.Tag = dr.Item("ID").ToString
        namelbl1.Text = dr.Item("ID").ToString

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        picc.BackgroundImage = bitmap

        AddHandler picc.Click, AddressOf picc_click




    End Sub
    ' Private selectedPictureBox As PictureBox = Nothing
    Private selectedPictureBox As PictureBox = Nothing
    ' Dim selectedPictureBox As PictureBox ' Declare a variable to store the selected picture box
    Dim firstClick As Boolean = True
    Dim ClickCount As Integer = 0
    Private Sub picc_click(sender As Object, e As EventArgs)
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)

        If clickedPictureBox.Enabled Then
            Dim selectedPartyName As String = clickedPictureBox.Tag.ToString()

            Dim dt As New DataTable()
            Dim query As String = "SELECT `ID`,`First_Name` FROM `provincial_election_candidate_registration` WHERE `First_Name` = @PartyName"
            Using cmd As New MySqlCommand(query, dbconn)
                cmd.Parameters.AddWithValue("@PartyName", selectedPartyName)
                Using dad As New MySqlDataAdapter(cmd)
                    dad.Fill(dt)
                End Using
            End Using

            If Dgv3.Rows.Count < 4 Then
                Dgv3.Rows.Add(dt.Rows(0)("ID").ToString(), dt.Rows(0)("First_Name").ToString())
                clickedPictureBox.Enabled = False
            End If

            If Dgv3.Rows.Count > 4 Then
                MsgBox("You have successfully selected 3 candidates, Vote Now!")
                UnsubscribeClickEvents(clickedPictureBox)
            End If
        End If

    End Sub
    Private Sub UnsubscribeClickEvents(exceptPictureBox As PictureBox)
        For Each pb As PictureBox In {picc}
            If pb IsNot exceptPictureBox Then
                RemoveHandler pb.Click, AddressOf picc_click
            End If
        Next
    End Sub
    Private Sub LoadDataForSelectedPictureBox(clickNumber As Integer)
        dbconn.Open()
        If selectedPictureBox IsNot Nothing Then
            Dim selectedPartyName As String = selectedPictureBox.Tag.ToString()

            Dim dt As New DataTable()
            Dim query As String = "SELECT `ID`,`First_Name` FROM `provincial_election_candidate_registration` WHERE `First_Name` = @PartyName"
            Using cmd As New MySqlCommand(query, dbconn)
                cmd.Parameters.AddWithValue("@PartyName", selectedPartyName) ' Remove "%" around selectedPartyName
                Using dad As New MySqlDataAdapter(cmd)
                    dad.Fill(dt)
                End Using
            End Using

            ' Load the data into Dgv1
            Dgv3.DataSource = dt

            ' Optionally, you can update other DataGridViews based on clickNumber if needed.
        End If

        dbconn.Close()
    End Sub

    Sub loadlist()
        FlowLayoutPanel1.Controls.Clear()
        Dgv3.DataSource = Nothing
        selectedPictureBox = Nothing
        ClickCount = Nothing
        Dgv3.Rows.Clear()
        Try

            dbconn.Open()
            Dim selectedParty As String = Pro1.Dgv1.CurrentRow.Cells("Name").Value.ToString()
            Dim selectedDistrict As String = Pro1.Dgv2.CurrentRow.Cells("District").Value.ToString()
            cmd = New MySqlCommand("SELECT `Img`,`ID`,`First_Name`FROM provincial_election_candidate_registration WHERE Party=@Party AND District=@District", dbconn)
            cmd.Parameters.AddWithValue("@Party", selectedParty)
            cmd.Parameters.AddWithValue("@District", selectedDistrict)
            dr = cmd.ExecuteReader
            While dr.Read
                loadp()
                p1.Controls.Add(picc)
                p1.Controls.Add(namelbl)
                p1.Controls.Add(namelbl1)
                FlowLayoutPanel1.Controls.Add(p1)



            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        dbconn.Close()

    End Sub

    Private Sub Pic2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Try
            dbconn.Open()
            For j As Integer = 0 To Dgv3.Rows.Count - 2
                Dim query As String
                query = "INSERT INTO provoting_details_2(Nic, Time,Selected_Candidate) VALUES (@Nic, @Time,@Selected_Candidate)"
                cmd = New MySqlCommand(query, dbconn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nic", Provincial_Loging.Txtnic.Text)
                cmd.Parameters.AddWithValue("@Time", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@Selected_Candidate", Dgv3.Rows(j).Cells(1).Value)

                i = cmd.ExecuteNonQuery()
            Next
            If i > 0 Then
                MsgBox("Thanks for voting")
                Me.Close()

            Else
                MsgBox("Please select candidates first")


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
        End Try

        '  update_votervotestatus()
        '  dbconn.Close()
        ' Dgv1.Rows.Clear()
        '  Loging_form.Txtnic.Clear()







    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
End Class