Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Election_Shedule
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter("SELECT * From elections", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private selectedRecordID As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub LoadProvinceComboBox()
        Dim dtb As New DataTable
        Dim dad As New MySqlDataAdapter("SELECT * FROM province", dbconn)
        dad.Fill(dtb)
        Cmbprovince.DataSource = dtb
        Cmbprovince.DisplayMember = "Sri_Lanka"
        Cmbprovince.ValueMember = "PID"
    End Sub

    Private Sub LoadpsComboBox()
        Dim dtb As New DataTable
        Dim dad As New MySqlDataAdapter("SELECT * FROM Election_ps", dbconn)
        dad.Fill(dtb)
        Cmbplace.DataSource = dtb
        Cmbplace.DisplayMember = "PS"
        Cmbplace.ValueMember = "PSID"
    End Sub


    Private Sub Election_Shedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadpsComboBox()
        LoadProvinceComboBox()
        dt.Clear()
        da.Fill(dt)
        Dgv1.DataSource = dt
        Cmbprovince.SelectedIndex = -1
        Cmbetype.SelectedIndex = -1
        Cmbplace.SelectedIndex = -1

        Txtplace.Clear()


    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim electionName As String = Cmbetype.Text
        Dim startDate As DateTime = Dtpsd.Value
        Dim endDate As DateTime = Dtped.Value

        If Cmbetype.Text = "" Then
            MsgBox("Please select the election type")
            Return
        End If
        If Txtplace.Text = "" Then
            MsgBox("Please select the place")
            Return
        End If

        If startDate > endDate Then
            MessageBox.Show("End date must be after start date.")
            Return
        End If
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to schedule this election?", "Confirm Scheduling", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then


            dbconn.Open()

            Dim query As String = "INSERT INTO Elections (Name, StartDate, EndDate,Place) VALUES (@Name, @StartDate, @EndDate,@Place)"
            cmd = New MySqlCommand(query, dbconn)
            cmd.Parameters.AddWithValue("@Name", electionName)
            cmd.Parameters.AddWithValue("@StartDate", startDate.ToString("MM-dd-yyyy"))
            cmd.Parameters.AddWithValue("@EndDate", endDate.ToString("MM-dd-yyyy"))
            cmd.Parameters.AddWithValue("@Place", Txtplace.Text)
            i = cmd.ExecuteNonQuery()



            ' Display a message indicating successful scheduling
            MessageBox.Show("Election scheduled successfully.")
            Reset()

            Txtplace.Clear()

            Cmbetype.SelectedIndex = -1
            dt.Clear()
            da.Fill(dt)
            Dgv1.DataSource = dt
            Reset()
            Cmbprovince.SelectedIndex = -1
            Cmbetype.SelectedIndex = -1
            Cmbplace.SelectedIndex = -1



        ElseIf response = DialogResult.No Then

            Return
        End If
        dbconn.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Dgv1.Rows(e.RowIndex)

            '  TxtID.Text = selectedRow.Cells("ID").Value.ToString()
            selectedRecordID = selectedRow.Cells("ID").Value.ToString()
            Txtplace.Text = selectedRow.Cells("Place").Value.ToString()
            Cmbetype.Text = selectedRow.Cells("Name").Value.ToString()
            ' Cmbdistrict.Text = selectedRow.Cells("district").Value.ToString()



        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                dbconn.Open()
                Dim dt As New DataTable
                Dim data As New MySqlDataAdapter
                Dim deleteQuery As String = "DELETE FROM elections WHERE ID=@id"
                cmd = New MySqlCommand(deleteQuery, dbconn)

                cmd.Parameters.AddWithValue("@ID", selectedRecordID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Election deleted successfully!")
                    Reset()

                    Txtplace.Clear()

                    Cmbetype.SelectedIndex = -1
                    dt.Clear()
                    da.Fill(dt)
                    Dgv1.DataSource = dt
                    Reset()
                    Cmbprovince.SelectedIndex = -1
                    Cmbetype.SelectedIndex = -1
                    Cmbplace.SelectedIndex = -1

                Else
                    MsgBox("Select First")
                End If

                ' ...
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dbconn.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
End Class