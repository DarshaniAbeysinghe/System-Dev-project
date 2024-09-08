Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Manage_party
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim data As New MySqlDataAdapter("SELECT * FROM party_registration", dbconn)
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private selectedRecordPAID As String
    Private Sub Btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click

        Try
            dbconn.Open()

            Dim query As String
            query = "INSERT INTO party_registration(Name,Defamation,president)values(@Name,@Defamation,@president)"
            cmd = New MySqlCommand(query, dbconn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@Name", Txtname.Text)
            cmd.Parameters.AddWithValue("@president", Txtpresident.Text)

            Dim filesize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            Picd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            filesize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@defamation", picture)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Successfully Added!")
                dt.Clear()
                data.Fill(dt)
                Dgv1.DataSource = dt
            Else
                MsgBox("Try Again!")
            End If
            Txtname.Clear()
            Txtpresident.Clear()
            Picd.Image = Nothing

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally
            dbconn.Close()


        End Try
        ' bindData()

    End Sub

    ' Private Sub bindData()
    ' data.Fill(dt)

    ' Dgv1.DataSource = dt
    ' End Sub

    Private Sub Manage_party_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' bindData()
        dt.Clear()
        data.Fill(dt)
        Dgv1.DataSource = dt
    End Sub

    Private Sub Picd_Click(sender As Object, e As EventArgs) Handles Picd.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Picd.Image = Image.FromFile(pop.FileName)


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub



    Private Sub Btnsearch_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click

        Dim searchTerm As String = Txtsearch.Text.Trim()

        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim dv As New DataView(dt)
            dv.RowFilter = String.Format("Name LIKE '%{0}%'  OR President LIKE '%{0}%' ", searchTerm)

            Dgv1.DataSource = dv
        Else
            Dgv1.DataSource = dt
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                dbconn.Open()

                Dim deleteQuery As String = "DELETE FROM party_registration WHERE PAID=@PAID"
                cmd = New MySqlCommand(deleteQuery, dbconn)

                cmd.Parameters.AddWithValue("@PAID", selectedRecordPAID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If MsgBox("Election deleted successfully!") Then
                    Reset()

                    dt.Clear()
                    data.Fill(dt)
                    Dgv1.DataSource = dt
                    Reset()

                Else
                    MsgBox("Error deleting voter")
                End If
                Txtname.Clear()
                Txtpresident.Clear()
                Picd.Image = Nothing

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

            selectedRecordPAID = selectedRow.Cells("PAID").Value.ToString()
            Txtname.Text = selectedRow.Cells("Name").Value.ToString()
            Txtpresident.Text = selectedRow.Cells("President").Value.ToString()


        End If
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        Try

            Dim PAID, Name, President As String
            Dim Defamation As PictureBox
            PAID = Txtname.Text
            Name = Txtname.Text
            President = Txtpresident.Text
            Defamation = Picd




            dbconn.Open()




            If IsDBNull(Name) OrElse Name = "" OrElse
                    IsDBNull(President) OrElse President = "" OrElse
              IsDBNull(Defamation) OrElse President = "" Then

                MsgBox("All required")


            Else

                Dim query As String = "UPDATE party_registration " &
                                      "SET `Name`=@Name,`President`=@President,`Defamation`=@Defamation WHERE `PAID`=@PAID"
                cmd = New MySqlCommand(query, dbconn)
                cmd.Parameters.AddWithValue("@PAID", selectedRecordPAID)
                cmd.Parameters.AddWithValue("@Name", Txtname.Text)
                cmd.Parameters.AddWithValue("@president", Txtpresident.Text)

                Dim filesize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                Picd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                filesize = mstream.Length
                mstream.Close()
                cmd.Parameters.AddWithValue("@Defamation", picture)


                Dim i As Integer = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Record successfully updated!")
                    Reset()
                    Picd.Image = Nothing
                    dt.Clear()

                    data.Fill(dt)
                    Dgv1.DataSource = dt
                Else
                    MsgBox("Update failed. Please try again.")
                End If


                Txtname.Clear()
                Txtpresident.Clear()
                Picd.Image = Nothing


            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            dbconn.Close()
        End Try
        ' bindData()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class