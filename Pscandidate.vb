Imports MySql.Data.MySqlClient

Public Class Pscandidate
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim data As New MySqlDataAdapter("SELECT ID,First_Name,Last_Name,Nic,Gender,TpNo,Dob,Province,District,pradeshiya_saba,Party From pradeshiya_saba_election_candidate", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer

    Private First_Name, Last_Name, Nic, TpNo, Dob, Province, District, Pradeshiya_saba, Party As String

    Private Sub Btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        Try
            Dim tpno As String
            Dim pattern As String = "^\d{10}$"
            Dim pattern2 As String = "^\d{12}$"
            Dim img As PictureBox
            Dim Fname, Lname, Nic, Dob, province, district, Pradeshiya_saba, Party As String
            Nic = Txtnic.Text
            Fname = Txtfname.Text
            Lname = Txtlname.Text
            Dob = Dtp1.Text
            tpno = Txttpno.Text
            province = Cmbprovince.Text
            district = Cmbdistrict.Text
            Pradeshiya_saba = Cmbps.Text
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
            ElseIf Cmbps.SelectedIndex = -1 Then
                MsgBox("Pradeshiya saba cannot be empty")
            ElseIf Cmbparty.SelectedIndex = -1 Then
                MsgBox("party cannot be empty")
            ElseIf img.Image Is Nothing Then
                MsgBox("Please add a image")
            Else


                Dim query As String
                query = "INSERT INTO pradeshiya_saba_election_candidate(Img,First_Name,Last_Name,Nic,Dob,Gender,TpNo,province,district,Pradeshiya_saba,Party)values(@Img,@First_Name,@Last_Name,@Nic,@Dob,@Gender,@TpNo,@province,@district,@Pradeshiya_saba,@Party)"
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
                cmd.Parameters.AddWithValue("@Pradeshiya_saba", Cmbps.GetItemText(Cmbps.SelectedItem))
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
            Txtfname.Clear()
            Txtlname.Clear()
            Txtnic.Clear()
            Txttpno.Clear()
            Cmbprovince.SelectedIndex = -1
            Cmbdistrict.SelectedIndex = -1
            Cmbps.SelectedIndex = -1
            Cmbparty.SelectedIndex = -1
            Picc.Image = Nothing
            Dtp1.Value = DateTime.Now

            ' Clear radio button selection
            Rdomale.Checked = False
            Rdofemale.Checked = False
            ' Refresh your DataGridView or data display after update
            ' ...

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
        End Try
        ' bindData()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        If ValidateCandidateForm() Then
            Try
                ' Retrieve data from the form controls
                Dim ID, Fname, Lname, Nic, Dob, tpno, province, district, Pradeshiya_saba, party As String
                Dim img As PictureBox
                ID = Txtnic.Text ' Get the ID of the record you want to update
                Nic = Txtnic.Text
                Fname = Txtfname.Text
                Lname = Txtlname.Text
                Dob = Dtp1.Text
                tpno = Txttpno.Text
                province = Cmbprovince.Text
                district = Cmbdistrict.Text
                Pradeshiya_saba = Cmbps.Text
                party = Cmbparty.Text
                img = Picc

                ' Open the database connection
                dbconn.Open()

                ' Determine the gender based on the selected radio button
                Dim gender As String = If(Rdomale.Checked, Rdomale.Text, Rdofemale.Text)

                If IsDBNull(Fname) OrElse Fname = "" OrElse
       IsDBNull(Lname) OrElse Lname = "" OrElse
                    IsDBNull(Nic) OrElse Nic = "" OrElse
                     IsDBNull(Dob) OrElse Dob = "" OrElse
                     IsDBNull(tpno) OrElse tpno = "" OrElse
                     IsDBNull(province) OrElse province = "" OrElse
                    IsDBNull(district) OrElse district = "" OrElse
                      IsDBNull(Pradeshiya_saba) OrElse Pradeshiya_saba = "" OrElse
                       IsDBNull(img) OrElse Pradeshiya_saba = "" OrElse
                    IsDBNull(party) OrElse party = "" Then

                    MsgBox("All fields are required.")
                ElseIf Nic.Length <> 12 Then
                    MsgBox("Invalid NIC length. NIC should be 12 characters.")
                Else
                    ' Construct the SQL query for updating the record
                    Dim query As String = "UPDATE pradeshiya_saba_election_candidate " &
                                          "SET `First_Name`=@First_Name, `Last_Name`=@Last_Name, `Nic`=@Nic, `Dob`=@Dob, " &
                                          "`Gender`=@Gender, `Tpno`=@Tpno, `Province`=@Province, `District`=@District, " &
                                          "`Pradeshiya_saba`=@Pradeshiya_saba, `Party`=@Party, `Img`=@Img " &
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
                    cmd.Parameters.AddWithValue("@Pradeshiya_saba", Pradeshiya_saba)
                    cmd.Parameters.AddWithValue("@Party", party)
                    ' Convert the PictureBox image to a byte array
                    Dim filesize As New UInt32
                    Dim mstream As New System.IO.MemoryStream
                    Picc.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim picture() As Byte = mstream.GetBuffer
                    filesize = mstream.Length
                    mstream.Close()
                    cmd.Parameters.AddWithValue("@Img", picture)


                    ' Execute the update query
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
                    Cmbps.SelectedIndex = -1
                    Cmbparty.SelectedIndex = -1
                    Picc.Image = Nothing
                    Dtp1.Value = DateTime.Now

                    ' Clear radio button selection
                    Rdomale.Checked = False
                    Rdofemale.Checked = False
                    ' Refresh your DataGridView or data display after update
                    ' ...

                End If
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                dbconn.Close()
            End Try
            ' bindData()
        End If
    End Sub
    Private Function ValidateCandidateForm() As Boolean
        Dim pattern2 As String = "^\d{12}$"

        If Txtfname.Text = "" Then
            MsgBox("First name cannot be empty")
            Return False
        ElseIf Txtlname.Text = "" Then
            MsgBox("Last name cannot be empty")
            Return False
        ElseIf Txtnic.Text = "" Then
            MsgBox("NIC cannot be empty")
            Return False
        ElseIf Txtnic.Text.Length <> 12 Or Not System.Text.RegularExpressions.Regex.IsMatch(Txtnic.Text, pattern2) Then
            MsgBox("Please add a valid NIC with 12 characters")
            Return False
        ElseIf Dtp1.Text = "" Then
            MsgBox("Date of birth cannot be empty")
            Return False
        ElseIf Txttpno.Text = "" Or Not System.Text.RegularExpressions.Regex.IsMatch(Txttpno.Text, "^\d{10}$") Then
            MsgBox("Please add a valid phone number with 10 digits")
            Return False
        ElseIf Not Rdomale.Checked AndAlso Not Rdofemale.Checked Then
            MsgBox("Gender cannot be empty")
            Return False
        ElseIf Cmbprovince.SelectedIndex = -1 Then
            MsgBox("Province cannot be empty")
            Return False
        ElseIf Cmbdistrict.SelectedIndex = -1 Then
            MsgBox("District cannot be empty")
            Return False
        ElseIf Cmbps.SelectedIndex = -1 Then
            MsgBox("Pradeshiya saba cannot be empty")
            Return False
        ElseIf Cmbparty.SelectedIndex = -1 Then
            MsgBox("Party cannot be empty")
            Return False
        ElseIf Picc.Image Is Nothing Then
            MsgBox("Please add an image")
            Return False
        End If

        Return True
    End Function


    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private key As Integer
    Private selectedRecordID As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                dbconn.Open()

                Dim deleteQuery As String = "DELETE FROM pradeshiya_saba_election_candidate WHERE ID=@id"
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
                Cmbps.SelectedIndex = -1
                Cmbparty.SelectedIndex = -1
                Picc.Image = Nothing
                Dtp1.Value = DateTime.Now

                ' Clear radio button selection
                Rdomale.Checked = False
                Rdofemale.Checked = False
                ' Refresh your DataGridView or data display after update
                ' ...
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dbconn.Close()
            End Try
        End If
    End Sub
    Private Sub Dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        If e.RowIndex >= 0 Then ' Ensure a valid row index is clicked
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
            Cmbps.Text = selectedRow.Cells("Pradeshiya_saba").Value.ToString()
            Cmbparty.Text = selectedRow.Cells("party").Value.ToString()
            Dim gender As String = selectedRow.Cells("Gender").Value.ToString()
            If gender = "Male" Then
                Rdomale.Checked = True
            ElseIf gender = "Female" Then
                Rdofemale.Checked = True
            Else
                ' Handle the case if gender is not recognized
                Rdomale.Checked = False
                Rdofemale.Checked = False
            End If

        End If
    End Sub

    Private Sub bindData()
        data.Fill(dt)
        Dgv1.DataSource = dt
    End Sub
    Private Sub Pscandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindData()


        LoadProvinceComboBox()
        LoadDistrictComboBox()
        LoadpsComboBox()
        LoadPartyComboBox()
        dt.Clear()
        data.Fill(dt)
        Dgv1.DataSource = dt

        Cmbprovince.SelectedIndex = -1
        Cmbdistrict.SelectedIndex = -1
        Cmbps.SelectedIndex = -1
        Cmbparty.SelectedIndex = -1

    End Sub
    Private Sub LoadPartyComboBox()
        Dim dtp As New DataTable
        Dim dadp As New MySqlDataAdapter("SELECT * From Party_registration", dbconn)
        dadp.Fill(dtp)
        Cmbparty.DataSource = dtp
        Cmbparty.DisplayMember = "Name"
        Cmbparty.ValueMember = "PAID"
    End Sub
    Private Sub LoadProvinceComboBox()
        Dim dtb As New DataTable
        Dim dad As New MySqlDataAdapter("SELECT * FROM province", dbconn)
        dad.Fill(dtb)
        Cmbprovince.DataSource = dtb
        Cmbprovince.DisplayMember = "Sri_Lanka"
        Cmbprovince.ValueMember = "PID"
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

    Private Sub LoadpsComboBox()
        Dim selectedDistrictId As Integer
        If Cmbdistrict.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(Cmbdistrict.SelectedValue.ToString()) Then
            selectedDistrictId = Convert.ToInt32(Cmbdistrict.SelectedValue)
        Else
            selectedDistrictId = -1 ' Or any appropriate default value
        End If
        Cmbps.DataSource = Nothing

        Dim dtd As New DataTable
        Dim dadaa As New MySqlDataAdapter("SELECT * FROM Election_ps WHERE DID=@DistrictID", dbconn)
        dadaa.SelectCommand.Parameters.AddWithValue("@DistrictID", selectedDistrictId)
        dadaa.Fill(dtd)
        Cmbps.DataSource = dtd
        Cmbps.DisplayMember = "PS"
        Cmbps.ValueMember = "PSID"
    End Sub

    Private Sub Cmbprovince_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmbprovince.SelectedValueChanged
        LoadDistrictComboBox()
        LoadpsComboBox()
    End Sub

    Private Sub Cmbdistrict_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmbdistrict.SelectedValueChanged
        LoadpsComboBox()
    End Sub


    Private Sub Picc_Click(sender As Object, e As EventArgs) Handles Picc.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Picc.Image = Image.FromFile(pop.FileName)


        End If
    End Sub
    Public Sub load_data()
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class