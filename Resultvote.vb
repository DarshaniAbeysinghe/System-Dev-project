
Imports MySql.Data.MySqlClient

Public Class Resultvote
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim data As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dgv1.RowTemplate.Height = 35
        ' Clear the DataGridView before loading new values


        load_result()
        load_results()
        load_resultss()


        Dim sum As Integer
        Dim max As Integer
        Dim maxRows As New List(Of DataGridViewRow)()
        sum = 0
        max = 0
        maxRows.Clear()



        For i As Integer = 0 To Dgv1.Rows.Count() - 1 Step 1
            sum = sum + Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value)

            If i = 0 Then
                max = Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value)
                maxRows.Clear()
                maxRows.Add(Dgv1.Rows(i))
            ElseIf max < Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value) Then
                max = Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value)
                maxRows.Clear()
                maxRows.Add(Dgv1.Rows(i))
            ElseIf max = Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value) Then
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
            Txtmname.Text += row.Cells(0).Value.ToString() & ", "
        Next
        Txtmname.Text = Txtmname.Text.TrimEnd(", ")




        For i As Integer = 0 To Dgv2.Rows.Count() - 1 Step 1
            'sum = sum + Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value)

            If i = 0 Then
                max = Convert.ToInt32(Dgv2.Rows(i).Cells(1).Value)
                maxRows.Clear()
                maxRows.Add(Dgv2.Rows(i))
            ElseIf max < Convert.ToInt32(Dgv2.Rows(i).Cells(1).Value) Then
                max = Convert.ToInt32(Dgv2.Rows(i).Cells(1).Value)
                maxRows.Clear()
                maxRows.Add(Dgv2.Rows(i))
            ElseIf max = Convert.ToInt32(Dgv2.Rows(i).Cells(1).Value) Then
                maxRows.Add(Dgv2.Rows(i))
            End If
        Next

        Txtsecondv.Text = max.ToString()
        '  Txtsum.Text = sum.ToString()

        For Each row As DataGridViewRow In Dgv2.Rows
            If maxRows.Contains(row) Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next

        For Each row As DataGridViewRow In maxRows
            Txtwinsecond.Text += row.Cells(0).Value.ToString() & ", "
        Next
        Txtsecondv.Text = Txtsecondv.Text.TrimEnd(", ")



        For i As Integer = 0 To Dgv3.Rows.Count() - 1 Step 1
            'sum = sum + Convert.ToInt32(Dgv1.Rows(i).Cells(1).Value)

            If i = 0 Then
                max = Convert.ToInt32(Dgv3.Rows(i).Cells(1).Value)
                maxRows.Clear()
                maxRows.Add(Dgv3.Rows(i))
            ElseIf max < Convert.ToInt32(Dgv3.Rows(i).Cells(1).Value) Then
                max = Convert.ToInt32(Dgv3.Rows(i).Cells(1).Value)
                maxRows.Clear()
                maxRows.Add(Dgv3.Rows(i))
            ElseIf max = Convert.ToInt32(Dgv3.Rows(i).Cells(1).Value) Then
                maxRows.Add(Dgv3.Rows(i))
            End If
        Next

        Txtthirdv.Text = max.ToString()
        '  Txtsum.Text = sum.ToString()

        For Each row As DataGridViewRow In Dgv3.Rows
            If maxRows.Contains(row) Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next

        For Each row As DataGridViewRow In maxRows
            Txtthird.Text += row.Cells(0).Value.ToString() & ", "
        Next
        Txtthird.Text = Txtthird.Text.TrimEnd(", ")
    End Sub
    Sub load_result()
        dbconn.Open()
        cmd = New MySqlCommand("SELECT `First_Vote` as First_Vote,COUNT(*) as VOTE FROM `voting_details` group BY `First_Vote` HAVING(COUNT(*)>=1) ORDER BY `VOTE` DESC", dbconn)
        '  cmd = New MySqlCommand("SELECT `First_Vote` as First_Vote,`Second_Vote` as Second_Vote,`Third_Vote` as Third_Vote,COUNT(*) as VOTE FROM `voting_details` group BY `First_Vote` HAVING(COUNT(*)>=1) ORDER BY `First_Vote`", dbconn)
        data.SelectCommand = cmd

        data.Fill(dt)
        Dgv1.DataSource = dt

        dbconn.Close()
    End Sub
    Sub load_results()
        dbconn.Open()
        Dim dataa As New MySqlDataAdapter
        Dim dtb As New DataTable
        cmd = New MySqlCommand("SELECT `Second_Vote` as Second_Vote,COUNT(*) as VOTE FROM `voting_details` group BY `Second_Vote` HAVING(COUNT(*)>=1) ORDER BY `VOTE` DESC", dbconn)
        '  cmd = New MySqlCommand("SELECT `First_Vote` as First_Vote,`Second_Vote` as Second_Vote,`Third_Vote` as Third_Vote,COUNT(*) as VOTE FROM `voting_details` group BY `First_Vote` HAVING(COUNT(*)>=1) ORDER BY `First_Vote`", dbconn)
        dataa.SelectCommand = cmd

        dataa.Fill(dtb)
        Dgv2.DataSource = dtb

        dbconn.Close()
    End Sub
    Sub load_resultss()
        dbconn.Open()
        Dim dataaa As New MySqlDataAdapter
        Dim dtbb As New DataTable
        cmd = New MySqlCommand("SELECT `Third_Vote` as Third_Vote,COUNT(*) as VOTE FROM `voting_details` group BY `Third_Vote` HAVING(COUNT(*)>=1) ORDER BY `VOTE` DESC", dbconn)
        '  cmd = New MySqlCommand("SELECT `First_Vote` as First_Vote,`Second_Vote` as Second_Vote,`Third_Vote` as Third_Vote,COUNT(*) as VOTE FROM `voting_details` group BY `First_Vote` HAVING(COUNT(*)>=1) ORDER BY `First_Vote`", dbconn)
        dataaa.SelectCommand = cmd
        dataaa.Fill(dtbb)
        Dgv3.DataSource = dtbb

        dbconn.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()




    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim dt As DataTable = TryCast(Dgv1.DataSource, DataTable)
        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter = String.Format("First_Vote LIKE '%{0}%'", TextBox1.Text)
        End If
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Dim dt As DataTable = TryCast(Dgv2.DataSource, DataTable)
        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter = String.Format("Second_Vote LIKE '%{0}%'", TextBox2.Text)
        End If
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Dim dt As DataTable = TryCast(Dgv3.DataSource, DataTable)
        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter = String.Format("Third_Vote LIKE '%{0}%'", TextBox3.Text)
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class