Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Public Class PVote
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
    Private WithEvents namelbl2 As New Label
    Private sender As Object
    Private Sub PVote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlist()




    End Sub
    Sub loadp()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        p1 = New Panel
        p1.Width = 200
        p1.Height = 250
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


        namelbl2 = New Label
        namelbl2.ForeColor = Color.Black
        namelbl2.BackColor = Color.White
        namelbl2.TextAlign = ContentAlignment.MiddleCenter
        namelbl2.Font = New Font("segoe UI", 8, FontStyle.Bold)
        namelbl2.Dock = DockStyle.Top
        namelbl2.Tag = dr.Item("Party").ToString
        namelbl2.Text = dr.Item("Party").ToString

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        picc.BackgroundImage = bitmap

        AddHandler picc.Click, AddressOf picc_click




    End Sub
    Private selectedPictureBox As PictureBox = Nothing

    Dim firstClick As Boolean = True
    Dim ClickCount As Integer = 0
    Private Sub picc_click(sender As Object, e As EventArgs)
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)

        If selectedPictureBox IsNot Nothing Then
            selectedPictureBox.Enabled = True
            UnsubscribeClickEvents(selectedPictureBox)
        End If

        clickedPictureBox.Enabled = False
        selectedPictureBox = clickedPictureBox

        RemoveHandler selectedPictureBox.Click, AddressOf picc_click

        ClickCount += 1

        LoadDataForSelectedPictureBox(ClickCount)

        If ClickCount > 3 Then
            MsgBox("You have successfully selected 3 candidates, Vote Now!.")
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
        ' dbconn.Open()
        If selectedPictureBox IsNot Nothing Then
            Dim selectedPartyName As String = selectedPictureBox.Tag.ToString()

            Dim dt As New DataTable()

            Dim query As String = "SELECT `ID`, `First_Name`, `Last_Name`, `Party` FROM `presidential_election_candidate_registration` WHERE `First_Name` LIKE @PartyName"

            Using cmd As New MySqlCommand(query, dbconn)
                cmd.Parameters.AddWithValue("@PartyName", "%" & selectedPartyName & "%")
                Using dad As New MySqlDataAdapter(cmd)
                    dad.Fill(dt)
                End Using
            End Using

            If clickNumber = 1 Then
                Dgv1.DataSource = dt
            ElseIf clickNumber = 2 Then
                Dgv2.DataSource = dt
            ElseIf clickNumber = 3 Then
                Dgv3.DataSource = dt
            End If
        End If

        ' dbconn.Close()
    End Sub

    Sub loadlist()
        FlowLayoutPanel1.Controls.Clear()
        Dgv1.DataSource = Nothing
        Dgv2.DataSource = Nothing
        Dgv3.DataSource = Nothing
        ClickCount = Nothing
        Try

            dbconn.Open()
            cmd = New MySqlCommand("SELECT Img,ID,First_Name,Party FROM Presidential_election_candidate_registration", dbconn)
            dr = cmd.ExecuteReader
            While dr.Read
                loadp()
                p1.Controls.Add(picc)
                p1.Controls.Add(namelbl)
                p1.Controls.Add(namelbl1)
                p1.Controls.Add(namelbl2)
                FlowLayoutPanel1.Controls.Add(p1)



            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        dbconn.Close()

    End Sub


    Private Sub Pic2_Click(sender As Object, e As EventArgs)


    End Sub

    Sub update_votervotestatus()
        Try

            Dim query As String
            query = "UPDATE voter_registration SET Status=@Status WHERE Nic=@Nic"
            cmd = New MySqlCommand(query, dbconn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Status", "Voted")
            cmd.Parameters.AddWithValue("@Nic", Loging_form.Txtnic.Text)
            i = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim pVote As PVote = Me
        pVote.Close()

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Try
            Dim selectedCandidatesCount As Integer = Dgv1.Rows.Cast(Of DataGridViewRow)().Count(Function(row) CBool(row.Cells(0).Value))

            If selectedCandidatesCount = 0 Then
                MsgBox("Please select at least one candidate to vote.")
            Else
                dbconn.Open()

                For j As Integer = 0 To Math.Min(Dgv1.Rows.Count - 2, Math.Min(Dgv2.Rows.Count - 2, Dgv3.Rows.Count - 2))
                    Dim query As String
                    query = "INSERT INTO voting_details(Nic, Time, First_Vote, Second_Vote, Third_Vote) VALUES (@Nic, @Time, @First_Vote, @Second_Vote, @Third_Vote)"
                    cmd = New MySqlCommand(query, dbconn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Nic", Loging_form.Txtnic.Text)
                    cmd.Parameters.AddWithValue("@Time", Date.Now.ToString("yyyy-MM-dd hh:mm:ss:tt"))
                    cmd.Parameters.AddWithValue("@First_Vote", Dgv1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@Second_Vote", Dgv2.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@Third_Vote", Dgv3.Rows(j).Cells(1).Value)

                    i = cmd.ExecuteNonQuery()
                Next

                If i > 0 Then
                    MsgBox("Thanks for voting")
                    '   FlowLayoutPanel1.Controls.Clear()
                    ' Vote1.ShowDialog()
                    ' Dim form2 As New Vote1()
                    ' form2.Show()
                    ' Reset()
                    Me.Close()



                Else
                    MsgBox("Please select 3 candidates to vote!")
                    Return


                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            update_votervotestatus()
            Loging_form.Txtnic.Clear()
            dbconn.Close()
        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class