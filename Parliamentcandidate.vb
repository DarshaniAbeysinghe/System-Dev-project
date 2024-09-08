Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.IO
Imports System.Net

Public Class Parliamentcandidate
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim data As New MySqlDataAdapter("SELECT * From Parliament_election_candidate_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer

    Private First_Name, Last_Name, Nic, TpNo, Dob, Province, District, Territory, Party As String
    Private selectedRecordID As String
    Private Sub Picc_Click(sender As Object, e As EventArgs) Handles Picc.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Picc.Image = Image.FromFile(pop.FileName)


        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                dbconn.Open()

                Dim deleteQuery As String = "DELETE FROM Parliament_election_candidate_registration WHERE ID=@id"
                cmd = New MySqlCommand(deleteQuery, dbconn)

                cmd.Parameters.AddWithValue("@id", selectedRecordID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Candidate deleted successfully!")
                    Reset()
                    dt.Clear()
                    data.Fill(dt)
                    Dgv1.DataSource = dt
                Else
                    MsgBox("Error deleting Candidate")
                End If
                Txtfname.Clear()
                Txtlname.Clear()
                Txtnic.Clear()
                Txttpno.Clear()
                Cmbprovince.SelectedIndex = -1
                Cmbdistrict.SelectedIndex = -1

                Cmbparty.SelectedIndex = -1
                Picc.Image = Nothing
                Dtp1.Value = DateTime.Now


                Rdomale.Checked = False
                Rdofemale.Checked = False

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dbconn.Close()
            End Try
        End If

    End Sub

    Private Sub Dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Dgv1.Rows(e.RowIndex)
            ' Extract data from the selected row and populate form fields
            '  TxtID.Text = selectedRow.Cells("ID").Value.ToString()
            selectedRecordID = selectedRow.Cells("ID").Value.ToString()
            Txtfname.Text = selectedRow.Cells("First_Name").Value.ToString()
            Txtlname.Text = selectedRow.Cells("Last_Name").Value.ToString()
            Txtnic.Text = selectedRow.Cells("Nic").Value.ToString()
            Dtp1.Text = selectedRow.Cells("Dob").Value.ToString()
            Txttpno.Text = selectedRow.Cells("tpno").Value.ToString()
            Cmbprovince.Text = selectedRow.Cells("province").Value.ToString()
            Cmbdistrict.Text = selectedRow.Cells("district").Value.ToString()

            Cmbparty.Text = selectedRow.Cells("party").Value.ToString()
            Dim gender As String = selectedRow.Cells("Gender").Value.ToString()
            If gender = "Male" Then
                Rdomale.Checked = True
            ElseIf gender = "Female" Then
                Rdofemale.Checked = True
            Else

                Rdomale.Checked = False
                Rdofemale.Checked = False
            End If

        End If
    End Sub
    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        Try

            Dim ID, Fname, Lname, Nic, Dob, tpno, province, district, party As String
            Dim img As PictureBox
            ID = Txtnic.Text
            Nic = Txtnic.Text
            Fname = Txtfname.Text
            Lname = Txtlname.Text
            Dob = Dtp1.Text
            tpno = Txttpno.Text
            province = Cmbprovince.Text
            district = Cmbdistrict.Text
            party = Cmbparty.Text
            img = Picc


            dbconn.Open()

            Dim gender As String = If(Rdomale.Checked, Rdomale.Text, Rdofemale.Text)

            Dim pattern As String = "^\d{10}$"
            Dim pattern2 As String = "^\d{12}$"
            If Fname = "" OrElse Lname = "" OrElse Nic = "" OrElse Nic.Length <> 12 OrElse Not System.Text.RegularExpressions.Regex.IsMatch(Nic, pattern2) OrElse
           tpno = "" OrElse Not System.Text.RegularExpressions.Regex.IsMatch(tpno, pattern) OrElse
           Dob = "" OrElse (Rdomale.Checked = False AndAlso Rdofemale.Checked = False) OrElse
           Cmbprovince.SelectedIndex = -1 OrElse Cmbdistrict.SelectedIndex = -1 OrElse
           img.Image Is Nothing OrElse party = "" Then

                MsgBox("Please fill in all the required fields correctly.")
            Else

                Dim query As String = "UPDATE Parliament_election_candidate_registration " &
                                  "SET `First_Name`=@First_Name, `Last_Name`=@Last_Name, `Nic`=@Nic, `Dob`=@Dob, " &
                                  "`Gender`=@Gender, `Tpno`=@Tpno, `Province`=@Province, `District`=@District, " &
                                  " `Party`=@Party, `Img`=@Img " &
                                  "WHERE `ID`=@ID"
                cmd = New MySqlCommand(query, dbconn)
                cmd.Parameters.AddWithValue("@ID", selectedRecordID)
                cmd.Parameters.AddWithValue("@First_Name", Fname)
                cmd.Parameters.AddWithValue("@Last_Name", Lname)
                cmd.Parameters.AddWithValue("@Nic", Nic)
                cmd.Parameters.AddWithValue("@Dob", Dob)
                cmd.Parameters.AddWithValue("@Gender", gender)
                cmd.Parameters.AddWithValue("@TpNo", tpno)
                cmd.Parameters.AddWithValue("@Province", province)
                cmd.Parameters.AddWithValue("@District", district)
                cmd.Parameters.AddWithValue("@Party", party)

                Dim filesize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                Picc.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                filesize = mstream.Length
                mstream.Close()
                cmd.Parameters.AddWithValue("@Img", picture)

                Dim i As Integer = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Record successfully updated!")
                    Reset()
                    dt.Clear()
                    data.Fill(dt)
                    Dgv1.DataSource = dt
                Else
                    MsgBox("Update failed. Please try again.")
                End If

                ' Clear form fields
                Txtfname.Clear()
                Txtlname.Clear()
                Txtnic.Clear()
                Txttpno.Clear()
                Cmbprovince.SelectedIndex = -1
                Cmbdistrict.SelectedIndex = -1
                Cmbparty.SelectedIndex = -1
                Picc.Image = Nothing
                Dtp1.Value = DateTime.Now


                Rdomale.Checked = False
                Rdofemale.Checked = False

            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            dbconn.Close()
        End Try
        ' bindData()
    End Sub

    Private Sub Btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click

        Try
            Dim tpno As String
            Dim pattern As String = "^\d{10}$"
            Dim pattern2 As String = "^\d{12}$"
            Dim img As PictureBox
            Dim Fname, Lname, Nic, Dob, province, district, Party As String
            Nic = Txtnic.Text
            Fname = Txtfname.Text
            Lname = Txtlname.Text
            Dob = Dtp1.Text
            tpno = Txttpno.Text
            province = Cmbprovince.Text
            district = Cmbdistrict.Text

            Party = Cmbparty.Text
            img = Picc

            dbconn.Open()
            Dim sss As String = ""
            If Rdomale.Checked Then
                sss = Rdomale.Text
            Else
                sss = Rdofemale.Text
            End If

            If Fname = "" Then
                MsgBox("First name cannot be empty")
            ElseIf Lname = "" Then
                MsgBox("Last name cannot be empty")
            ElseIf Nic = "" Then
                MsgBox("nic cannot be empty")
            ElseIf Nic.Length > 12 Then
                MsgBox("invalid nic")
            ElseIf Nic.Length < 12 Then
                MsgBox("invalid nic")
            ElseIf tpno = "" Then
                MsgBox("tpno cannot be empty")
            ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(Nic, pattern2) Then
                MsgBox("Please add a valid Nic")
            ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(tpno, pattern) Then
                MsgBox("Please add a valid phone number")
            ElseIf Rdomale.Checked = False AndAlso Rdofemale.Checked = False Then
                MsgBox("Gender cannot be empty")
            ElseIf Cmbprovince.SelectedIndex = -1 Then
                MsgBox("province cannot be empty")
            ElseIf Cmbdistrict.SelectedIndex = -1 Then
                MsgBox("district cannot be empty")

            ElseIf Cmbparty.SelectedIndex = -1 Then
                MsgBox("party cannot be empty")
            ElseIf img.Image Is Nothing Then
                MsgBox("Please add a image")
            Else


                Dim query As String
                query = "INSERT INTO Parliament_election_candidate_registration(Img,First_Name,Last_Name,Nic,Dob,Gender,TpNo,province,district,Party)values(@Img,@First_Name,@Last_Name,@Nic,@Dob,@Gender,@TpNo,@province,@district,@Party)"
                cmd = New MySqlCommand(query, dbconn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@First_Name", Txtfname.Text)
                cmd.Parameters.AddWithValue("@Last_Name", Txtlname.Text)
                cmd.Parameters.AddWithValue("@Nic", Txtnic.Text)
                cmd.Parameters.AddWithValue("@Dob", Dtp1.Text)
                cmd.Parameters.AddWithValue("@Gender", sss)
                cmd.Parameters.AddWithValue("@TpNo", Txttpno.Text)
                cmd.Parameters.AddWithValue("@province", Cmbprovince.GetItemText(Cmbprovince.SelectedItem))
                cmd.Parameters.AddWithValue("@district", Cmbdistrict.GetItemText(Cmbdistrict.SelectedItem))

                cmd.Parameters.AddWithValue("@Party", Cmbparty.GetItemText(Cmbparty.SelectedItem))
                ' Cmbparty.SelectedIndex = 0
                Dim filesize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                Picc.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                filesize = mstream.Length
                mstream.Close()
                cmd.Parameters.AddWithValue("@Img", picture)
                i = cmd.ExecuteNonQuery()
            End If

            If i > 0 Then
                MsgBox("Successfully Added!")
                Reset()

                dt.Clear()
                data.Fill(dt)
                Dgv1.DataSource = dt
            Else
                Return

            End If
            ' Clear form fields
            Txtfname.Clear()
            Txtlname.Clear()
            Txtnic.Clear()
            Txttpno.Clear()
            Cmbprovince.SelectedIndex = -1
            Cmbdistrict.SelectedIndex = -1

            Cmbparty.SelectedIndex = -1
            Picc.Image = Nothing
            Dtp1.Value = DateTime.Now

            Rdomale.Checked = False
            Rdofemale.Checked = False

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
        End Try
        ' bindData()
    End Sub

    Private Sub Tp1_Click(sender As Object, e As EventArgs) Handles Tp1.Click

    End Sub

    Private Sub bindData()
        data.Fill(dt)
        Dgv1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnsearrch.Click
        Dim searchTerm As String = Txtsearch.Text.Trim()

        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim dv As New DataView(dt)
            dv.RowFilter = String.Format("First_Name LIKE '%{0}%' OR Last_Name LIKE '%{0}%' OR Nic LIKE '%{0}%' OR Gender LIKE '%{0}%' OR TpNo LIKE '%{0}%' OR province LIKE '%{0}%' OR district LIKE '%{0}%' OR Party LIKE '%{0}%'", searchTerm)

            Dgv1.DataSource = dv
        Else
            Dgv1.DataSource = dt
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private key As Integer
    Private Sub Parliamentcandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindData()

        LoadProvinceComboBox()
        LoadDistrictComboBox()
        LoadPartyComboBox()
        dt.Clear()
        data.Fill(dt)
        Dgv1.DataSource = dt
        Cmbprovince.SelectedIndex = -1
        Cmbdistrict.SelectedIndex = -1
        Cmbparty.SelectedIndex = -1




    End Sub
    Private Sub LoadProvinceComboBox()
        Dim dtb As New DataTable
        Dim dad As New MySqlDataAdapter("SELECT * FROM province", dbconn)
        dad.Fill(dtb)
        Cmbprovince.DataSource = dtb
        Cmbprovince.DisplayMember = "Sri_Lanka"
        Cmbprovince.ValueMember = "PID"
    End Sub
    Private Sub LoadPartyComboBox()
        Dim dtp As New DataTable
        Dim dadp As New MySqlDataAdapter("SELECT * From Party_registration", dbconn)
        dadp.Fill(dtp)
        Cmbparty.DataSource = dtp
        Cmbparty.DisplayMember = "Name"
        Cmbparty.ValueMember = "PAID"
    End Sub

    Private Sub LoadDistrictComboBox()
        Dim dtc As New DataTable
        Dim dada As New MySqlDataAdapter("SELECT * FROM Election_district WHERE PID=@ProvinceID", dbconn)
        If Cmbprovince.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(Cmbprovince.SelectedValue.ToString()) Then
            dada.SelectCommand.Parameters.AddWithValue("@ProvinceID", Cmbprovince.SelectedValue)
            dada.Fill(dtc)
        End If
        Cmbdistrict.DataSource = dtc
        Cmbdistrict.DisplayMember = "District"
        Cmbdistrict.ValueMember = "DID"
    End Sub



    Private Sub Cmbprovince_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmbprovince.SelectedValueChanged
        LoadDistrictComboBox()

    End Sub



End Class