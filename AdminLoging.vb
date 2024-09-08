Imports MySql.Data.MySqlClient

Public Class AdminLoging
    Dim dbconn As New MySqlConnection("host=localhost; user=root; password=; database=election_voting_system")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim data As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim result As Boolean
    Dim i As Integer
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub AdminLoging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text


        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If


        Dim usernameQuery As String = "SELECT COUNT(*) FROM admin WHERE User_Name = @username"
        Dim usernameCmd As New MySqlCommand(usernameQuery, dbconn)
        usernameCmd.Parameters.AddWithValue("@username", username)
        dbconn.Open()

        Dim usernameCount As Integer = Convert.ToInt32(usernameCmd.ExecuteScalar())

        dbconn.Close()


        Dim query As String = "SELECT COUNT(*) FROM admin WHERE User_Name = @username AND Password = @password"
        Dim cmd As New MySqlCommand(query, dbconn)

        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        dbconn.Open()


        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        dbconn.Close()

        If usernameCount > 0 And count > 0 Then
            Admin_option.ShowDialog()
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Close()

        ElseIf usernameCount = 0 Then
            MessageBox.Show("Invalid username.")
        Else
            MessageBox.Show("Invalid password. Please try again.")
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class