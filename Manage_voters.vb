Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational



Public Class Manage_voters

    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter("SELECT * From voter_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer

    Private Nic As String
    Private key As Integer
    Private selectedRecordID As String
    Private Sub Btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        Try

            Dim tpno As String
            Dim pattern As String = "^\d{10}$"
            Dim pattern2 As String = "^\d{12}$"
            Dim Fname, Mname, Lname, Nic, Dob, address, province, district, pradeshiya_saba As String
            Nic = Txtnic.Text
            Fname = Txtfname.Text
            Mname = Txtmname.Text
            Lname = Txtlname.Text
            Dob = Dtp1.Text
            tpno = Txttpno.Text
            address = Txtadd.Text
            province = Cmbprovince.Text
            district = Cmbdistrict.Text
            pradeshiya_saba = Cmbps.Text


            dbconn.Open()
            Dim sss As String = ""
            If Rdomale.Checked Then
                sss = Rdomale.Text
            Else
                sss = Rdofemale.Text
            End If

            If Fname = "" Then
                MsgBox("First name cannot be empty")
            ElseIf Mname = "" Then
                MsgBox("Middle name cannot be empty")
            ElseIf Lname = "" Then
                MsgBox("Last name cannot be empty")
            ElseIf Nic = "" Then
                MsgBox("nic cannot be empty")
            ElseIf Nic.Length > 12 Then
                MsgBox("invalid nic")
            ElseIf Nic.Length < 12 Then
                MsgBox("invalid nic")
            ElseIf Dob = "" Then
                MsgBox("dob cannot be empty")
            ElseIf tpno = "" Then
                MsgBox("Tpno cannot be empty")
            ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(Nic, pattern2) Then
                MsgBox("Please add a valid Nic")
            ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(tpno, pattern) Then
                MsgBox("Please add a valid phone number")
            ElseIf address = "" Then
                MsgBox("address cannot be empty")
            ElseIf province = "" Then
                MsgBox("province cannot be empty")
            ElseIf district = "" Then
                MsgBox("district cannot be empty")
            ElseIf pradeshiya_saba = "" Then
                MsgBox("Pradeshiya Saba cannot be empty")

            Else



                Dim query As String
                query = "INSERT INTO voter_registration(First_Name,Middle_Name,Last_Name,Nic,Dob,Gender,TpNo,Address,province,district,pradeshiya_saba)values(@First_Name,@Middle_Name,@Last_Name,@Nic,@Dob,@Gender,@TpNo,@Address,@province,@district,@pradeshiya_saba)"
                cmd = New MySqlCommand(query, dbconn)

                cmd.Parameters.AddWithValue("@First_Name", Txtfname.Text)
                cmd.Parameters.AddWithValue("@Middle_Name", Txtmname.Text)
                cmd.Parameters.AddWithValue("@Last_Name", Txtlname.Text)
                cmd.Parameters.AddWithValue("@Nic", Txtnic.Text)
                cmd.Parameters.AddWithValue("@Dob", Dtp1.Text)
                cmd.Parameters.AddWithValue("@Gender", sss)
                cmd.Parameters.AddWithValue("@TpNo", Txttpno.Text)
                cmd.Parameters.AddWithValue("@Address", Txtadd.Text)
                cmd.Parameters.AddWithValue("@province", Cmbprovince.GetItemText(Cmbprovince.SelectedItem))
                cmd.Parameters.AddWithValue("@district", Cmbdistrict.GetItemText(Cmbdistrict.SelectedItem))
                cmd.Parameters.AddWithValue("@pradeshiya_saba", Cmbps.GetItemText(Cmbps.SelectedItem))
                i = cmd.ExecuteNonQuery()
            End If

            If i > 0 Then
                MsgBox("Successfully Added!")
                Reset()
                dt.Clear()
                da.Fill(dt)
                Dgv1.DataSource = dt
            Else
                MsgBox("Registration failed. Please try again.")
                Return

            End If

            Txtfname.Clear()
            Txtmname.Clear()
            Txtlname.Clear()
            Txtnic.Clear()
            Txttpno.Clear()
            Txtadd.Clear()
            Cmbprovince.SelectedIndex = -1
            Cmbdistrict.SelectedIndex = -1
            Cmbps.SelectedIndex = -1

            Dtp1.Value = DateTime.Now


            Rdomale.Checked = False
            Rdofemale.Checked = False




        Catch ex As Exception

            MsgBox(ex.Message)

        Finally
            dbconn.Close()


        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                dbconn.Open()
                Dim dt As New DataTable
                Dim data As New MySqlDataAdapter
                Dim deleteQuery As String = "DELETE FROM voter_registration WHERE ID=@id"
                cmd = New MySqlCommand(deleteQuery, dbconn)

                cmd.Parameters.AddWithValue("@id", selectedRecordID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Voter deleted successfully!")
                    Reset()
                    dt.Clear()
                    da.Fill(dt)
                    Dgv1.DataSource = dt
                    ' Clear form fields
                    Txtfname.Clear()
                    Txtmname.Clear()
                    Txtlname.Clear()
                    Txtnic.Clear()
                    Txttpno.Clear()
                    Txtadd.Clear()
                    Cmbprovince.SelectedIndex = -1
                    Cmbdistrict.SelectedIndex = -1
                    Cmbps.SelectedIndex = -1

                    Dtp1.Value = DateTime.Now


                    Rdomale.Checked = False
                    Rdofemale.Checked = False

                Else
                    MsgBox("Error deleting voter")
                End If

                ' ...
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

            selectedRecordID = selectedRow.Cells("ID").Value.ToString()
            Txtfname.Text = selectedRow.Cells("First_Name").Value.ToString()
            Txtmname.Text = selectedRow.Cells("Middle_Name").Value.ToString()
            Txtlname.Text = selectedRow.Cells("Last_Name").Value.ToString()
            Txtnic.Text = selectedRow.Cells("Nic").Value.ToString()
            Dtp1.Text = selectedRow.Cells("Dob").Value.ToString()
            Txttpno.Text = selectedRow.Cells("tpno").Value.ToString()
            Txtadd.Text = selectedRow.Cells("Address").Value.ToString()
            Cmbprovince.Text = selectedRow.Cells("province").Value.ToString()
            Cmbdistrict.Text = selectedRow.Cells("district").Value.ToString()
            Cmbps.Text = selectedRow.Cells("pradeshiya_saba").Value.ToString()
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
        If ValidateForm() Then
            Try

                Dim ID, Fname, Mname, Lname, Nic, Dob, tpno, Address, province, district, pradeshiya_saba As String

                ID = Txtnic.Text
                Nic = Txtnic.Text
                Fname = Txtfname.Text
                Mname = Txtmname.Text
                Lname = Txtlname.Text
                Dob = Dtp1.Text
                tpno = Txttpno.Text
                Address = Txtadd.Text
                province = Cmbprovince.Text
                district = Cmbdistrict.Text
                pradeshiya_saba = Cmbps.Text


                dbconn.Open()


                Dim gender As String = If(Rdomale.Checked, Rdomale.Text, Rdofemale.Text)

                If IsDBNull(Fname) OrElse Fname = "" OrElse
                    IsDBNull(Mname) OrElse Mname = "" OrElse
                  IsDBNull(Lname) OrElse Lname = "" OrElse
                IsDBNull(Nic) OrElse Nic = "" OrElse
                 IsDBNull(Dob) OrElse Dob = "" OrElse
                 IsDBNull(tpno) OrElse tpno = "" OrElse
                  IsDBNull(Address) OrElse Address = "" OrElse
                 IsDBNull(province) OrElse province = "" OrElse
                IsDBNull(district) OrElse district = "" OrElse
                  IsDBNull(pradeshiya_saba) OrElse pradeshiya_saba = "" Then


                    MsgBox("All fields are required.")
                ElseIf Nic.Length <> 12 Then
                    MsgBox("Invalid NIC length. NIC should be 12 characters.")
                Else

                    Dim query As String = "UPDATE voter_registration " &
                                      "SET `First_Name`=@First_Name,`Middle_Name`=@Middle_Name, `Last_Name`=@Last_Name, `Nic`=@Nic, `Dob`=@Dob, " &
                                      "`Gender`=@Gender, `Tpno`=@Tpno, `Address`=@Address,`Province`=@Province, `District`=@District, " &
                                      "`pradeshiya_saba`=@pradeshiya_saba " &
                                      "WHERE `ID`=@ID"
                    cmd = New MySqlCommand(query, dbconn)
                    cmd.Parameters.AddWithValue("@ID", selectedRecordID)
                    cmd.Parameters.AddWithValue("@First_Name", Fname)
                    cmd.Parameters.AddWithValue("@Middle_Name", Mname)
                    cmd.Parameters.AddWithValue("@Last_Name", Lname)
                    cmd.Parameters.AddWithValue("@Nic", Nic)
                    cmd.Parameters.AddWithValue("@Dob", Dob)
                    cmd.Parameters.AddWithValue("@Gender", gender)
                    cmd.Parameters.AddWithValue("@TpNo", tpno)
                    cmd.Parameters.AddWithValue("@Address", Address)
                    cmd.Parameters.AddWithValue("@Province", province)
                    cmd.Parameters.AddWithValue("@District", district)
                    cmd.Parameters.AddWithValue("@pradeshiya_saba", pradeshiya_saba)


                    Dim i As Integer = cmd.ExecuteNonQuery()

                    If i > 0 Then
                        MsgBox("Record successfully updated!")
                        Reset()
                        dt.Clear()
                        da.Fill(dt)
                        Dgv1.DataSource = dt
                    Else
                        MsgBox("Update failed. Please try again.")
                    End If

                    Txtfname.Clear()
                    Txtmname.Clear()
                    Txtlname.Clear()
                    Txtnic.Clear()
                    Txttpno.Clear()
                    Txtadd.Clear()
                    Cmbprovince.SelectedIndex = -1
                    Cmbdistrict.SelectedIndex = -1
                    Cmbps.SelectedIndex = -1

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
        End If

    End Sub
    Private Function ValidateForm() As Boolean
        Dim tpno As String
        Dim pattern As String = "^\d{10}$"
        Dim pattern2 As String = "^\d{12}$"
        Dim Fname, Mname, Lname, Nic, Dob, address, province, district, pradeshiya_saba As String
        Nic = Txtnic.Text
        Fname = Txtfname.Text
        Mname = Txtmname.Text
        Lname = Txtlname.Text
        Dob = Dtp1.Text
        tpno = Txttpno.Text
        address = Txtadd.Text
        province = Cmbprovince.Text
        district = Cmbdistrict.Text
        pradeshiya_saba = Cmbps.Text

        If Fname = "" Then
            MsgBox("First name cannot be empty")
            Return False
        ElseIf Mname = "" Then
            MsgBox("Middle name cannot be empty")
            Return False
        ElseIf Lname = "" Then
            MsgBox("Last name cannot be empty")
            Return False
        ElseIf Nic = "" Then
            MsgBox("NIC cannot be empty")
            Return False
        ElseIf Nic.Length <> 12 Or Not System.Text.RegularExpressions.Regex.IsMatch(Nic, pattern2) Then
            MsgBox("Please add a valid NIC with 12 characters")
            Return False
        ElseIf Dob = "" Then
            MsgBox("Date of birth cannot be empty")
            Return False
        ElseIf tpno = "" Or Not System.Text.RegularExpressions.Regex.IsMatch(tpno, pattern) Then
            MsgBox("Please add a valid phone number with 10 digits")
            Return False
        ElseIf address = "" Then
            MsgBox("Address cannot be empty")
            Return False
        ElseIf province = "" Then
            MsgBox("Province cannot be empty")
            Return False
        ElseIf district = "" Then
            MsgBox("District cannot be empty")
            Return False
        ElseIf pradeshiya_saba = "" Then
            MsgBox("Pradeshiya Saba cannot be empty")
            Return False
        End If

        Return True
    End Function

    Private Sub bindData()


        da.Fill(dt)

        Dgv1.DataSource = dt
        Dgv1.EnableHeadersVisualStyles = False
        Dgv1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkTurquoise
        Dgv1.RowHeadersDefaultCellStyle.BackColor = Color.DarkTurquoise
        Dgv1.DefaultCellStyle.BackColor = Color.DarkTurquoise


    End Sub


    Private Sub DDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindData()

        LoadProvinceComboBox()
        LoadDistrictComboBox()

        LoadpsComboBox()
        dt.Clear()
        da.Fill(dt)
        Dgv1.DataSource = dt

        Cmbprovince.SelectedIndex = -1
        Cmbdistrict.SelectedIndex = -1

        Cmbps.SelectedIndex = -1
        ' Clear form fields
        Txtfname.Clear()
        Txtmname.Clear()
        Txtlname.Clear()
        Txtnic.Clear()
        Txttpno.Clear()
        Txtadd.Clear()
        Cmbprovince.SelectedIndex = -1
        Cmbdistrict.SelectedIndex = -1
        Cmbps.SelectedIndex = -1

        Dtp1.Value = DateTime.Now

        ' Clear radio button selection
        Rdomale.Checked = False
        Rdofemale.Checked = False
        ' Refresh your DataGridView or data display after update

        ' ...
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

        Dim dtp As New DataTable
        Dim dadap As New MySqlDataAdapter("SELECT * FROM Election_ps WHERE DID=@DistrictID", dbconn)
        dadap.SelectCommand.Parameters.AddWithValue("@DistrictID", selectedDistrictId)
        dadap.Fill(dtp)
        Cmbps.DataSource = dtp
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



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub Btnsearch_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click

        Dim searchTerm As String = Txtsearch.Text.Trim()

        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim dv As New DataView(dt) ' Assuming 'dt' is the DataTable that is bound to your DataGridView
            dv.RowFilter = String.Format("First_Name LIKE '%{0}%'  OR Middle_Name LIKE '%{0}%' OR Last_Name LIKE '%{0}%' OR Nic LIKE '%{0}%' OR Gender LIKE '%{0}%' OR TpNo LIKE '%{0}%' OR province LIKE '%{0}%' OR district LIKE '%{0}%' OR Pradeshiay_saba LIKE '%{0}%' OR Status LIKE '%{0}%' OR Parstatus LIKE '%{0}%' OR ProstatusLIKE '%{0}%'", searchTerm)

            Dgv1.DataSource = dv
        Else
            Dgv1.DataSource = dt ' Reset the DataGridView to show all data
        End If

    End Sub
End Class