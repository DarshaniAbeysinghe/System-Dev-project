Imports MySql.Data.MySqlClient

Public Class psresult
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim data As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private Sub psresult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_result()
        load_results()
        Dim sum As Integer
        Dim max As Integer
        Dim maxRows As New List(Of DataGridViewRow)()

        For i As Integer = 0 To Dgv1.Rows.Count() - 1 Step 1
            sum = sum + Convert.ToInt32(Dgv1.Rows(i).Cells(2).Value)

            If i = 0 Then
                max = Convert.ToInt32(Dgv1.Rows(i).Cells(2).Value)
                maxRows.Clear()
                maxRows.Add(Dgv1.Rows(i))
            ElseIf max < Convert.ToInt32(Dgv1.Rows(i).Cells(2).Value) Then
                max = Convert.ToInt32(Dgv1.Rows(i).Cells(2).Value)
                maxRows.Clear()
                maxRows.Add(Dgv1.Rows(i))
            ElseIf max = Convert.ToInt32(Dgv1.Rows(i).Cells(2).Value) Then
                maxRows.Add(Dgv1.Rows(i))
            End If
        Next

        Txtwin.Text = max.ToString()
        Txtsum.Text = sum.ToString()

        For Each row As DataGridViewRow In Dgv1.Rows
            If maxRows.Contains(row) Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.CadetBlue
            End If
        Next

        For Each row As DataGridViewRow In maxRows
            Txtmname.Text += row.Cells(1).Value.ToString() & ", "
        Next
        Txtmname.Text = Txtmname.Text.TrimEnd(", ")




        For i As Integer = 0 To Dgv2.Rows.Count() - 1 Step 1
            'sum = sum + Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value)

            If i = 0 Then
                max = Convert.ToInt32(Dgv2.Rows(i).Cells(2).Value)
                maxRows.Clear()
                maxRows.Add(Dgv2.Rows(i))
            ElseIf max < Convert.ToInt32(Dgv2.Rows(i).Cells(2).Value) Then
                max = Convert.ToInt32(Dgv2.Rows(i).Cells(2).Value)
                maxRows.Clear()
                maxRows.Add(Dgv2.Rows(i))
            ElseIf max = Convert.ToInt32(Dgv2.Rows(i).Cells(2).Value) Then
                maxRows.Add(Dgv2.Rows(i))
            End If
        Next

        Txtsecondv.Text = max.ToString()
        '  Txtsum.Text = sum.ToString()

        For Each row As DataGridViewRow In Dgv2.Rows
            If maxRows.Contains(row) Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.CadetBlue
            End If
        Next

        For Each row As DataGridViewRow In maxRows
            Txtwinsecond.Text += row.Cells(1).Value.ToString() & ", "
        Next
        Txtsecondv.Text = Txtsecondv.Text.TrimEnd(", ")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Sub load_result()
        dbconn.Open()
        cmd = New MySqlCommand("SELECT `Time` as Time,`Selected_Party` as Selected_Party,COUNT(*) as VOTE FROM `psvoting_details` group BY `Selected_Party` HAVING(COUNT(*)>=1) ORDER BY `VOTE`DESC", dbconn)
        data.SelectCommand = cmd
        data.Fill(dt)
        Dgv1.DataSource = dt

        dbconn.Close()
    End Sub
    Sub load_results()
        dbconn.Open()
        Dim dataa As New MySqlDataAdapter
        Dim dtb As New DataTable
        cmd = New MySqlCommand("SELECT `Time` as Time,`Selected_Candidate` as Selected_Candidate,COUNT(*) as VOTE FROM `psvoting_details_2` group BY `Selected_Candidate` HAVING(COUNT(*)>=1) ORDER BY `VOTE`DESC", dbconn)
        dataa.SelectCommand = cmd
        dataa.Fill(dtb)
        Dgv2.DataSource = dtb

        dbconn.Close()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Guna2GradientButton3_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim dt As DataTable = TryCast(Dgv1.DataSource, DataTable)
        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter = String.Format("Selected_Party LIKE '%{0}%'", TextBox1.Text)
        End If
    End Sub

    Private Sub Guna2GradientButton4_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim dt As DataTable = TryCast(Dgv2.DataSource, DataTable)
        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter = String.Format("Selected_Candidate LIKE '%{0}%'", TextBox2.Text)
        End If
    End Sub
End Class