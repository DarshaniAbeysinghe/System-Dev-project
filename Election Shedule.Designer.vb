<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Election_Shedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Election_Shedule))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmbetype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dtpsd = New System.Windows.Forms.DateTimePicker()
        Me.Dtped = New System.Windows.Forms.DateTimePicker()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtplace = New System.Windows.Forms.TextBox()
        Me.Cmbplace = New System.Windows.Forms.ComboBox()
        Me.Cmbprovince = New System.Windows.Forms.ComboBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(332, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ELECTION SHEDULE"
        '
        'Cmbetype
        '
        Me.Cmbetype.AccessibleName = ""
        Me.Cmbetype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cmbetype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbetype.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbetype.FormattingEnabled = True
        Me.Cmbetype.Items.AddRange(New Object() {"Presidential Election", "Parliament Election", "Provincial Election", "Pradeshiya Saba Election"})
        Me.Cmbetype.Location = New System.Drawing.Point(373, 270)
        Me.Cmbetype.Name = "Cmbetype"
        Me.Cmbetype.Size = New System.Drawing.Size(328, 39)
        Me.Cmbetype.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(162, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Election Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(162, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(162, 523)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 33)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "End Date"
        '
        'Dtpsd
        '
        Me.Dtpsd.Checked = False
        Me.Dtpsd.CustomFormat = "MM/dd/yyyy"
        Me.Dtpsd.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtpsd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtpsd.Location = New System.Drawing.Point(373, 435)
        Me.Dtpsd.Name = "Dtpsd"
        Me.Dtpsd.Size = New System.Drawing.Size(328, 39)
        Me.Dtpsd.TabIndex = 79
        '
        'Dtped
        '
        Me.Dtped.CustomFormat = "MM/dd/yyyy"
        Me.Dtped.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtped.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtped.Location = New System.Drawing.Point(373, 518)
        Me.Dtped.Name = "Dtped"
        Me.Dtped.Size = New System.Drawing.Size(328, 39)
        Me.Dtped.TabIndex = 80
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.Navy
        Me.Guna2GradientButton1.BorderRadius = 34
        Me.Guna2GradientButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientButton1.BorderThickness = 2
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.SpringGreen
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Green
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(495, 647)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.PressedColor = System.Drawing.Color.Red
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(237, 71)
        Me.Guna2GradientButton1.TabIndex = 81
        Me.Guna2GradientButton1.Text = "SHEDULE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(162, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 33)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Place"
        '
        'Txtplace
        '
        Me.Txtplace.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtplace.Location = New System.Drawing.Point(373, 346)
        Me.Txtplace.Name = "Txtplace"
        Me.Txtplace.Size = New System.Drawing.Size(328, 39)
        Me.Txtplace.TabIndex = 85
        '
        'Cmbplace
        '
        Me.Cmbplace.AccessibleName = ""
        Me.Cmbplace.AllowDrop = True
        Me.Cmbplace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbplace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbplace.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbplace.FormattingEnabled = True
        Me.Cmbplace.Items.AddRange(New Object() {"All Island", "Central Province", "Eastern Province", "Northern Province ", "North Central Province ", "North Western Province ", "Sabaragamuwa Province ", "Southern Province ", "Uva Province ", "Western Province", "Mahawa"})
        Me.Cmbplace.Location = New System.Drawing.Point(575, 155)
        Me.Cmbplace.Name = "Cmbplace"
        Me.Cmbplace.Size = New System.Drawing.Size(157, 31)
        Me.Cmbplace.TabIndex = 83
        '
        'Cmbprovince
        '
        Me.Cmbprovince.AccessibleName = ""
        Me.Cmbprovince.AllowDrop = True
        Me.Cmbprovince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbprovince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbprovince.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbprovince.FormattingEnabled = True
        Me.Cmbprovince.Items.AddRange(New Object() {"All Island", "Central Province", "Eastern Province", "Northern Province ", "North Central Province ", "North Western Province ", "Sabaragamuwa Province ", "Southern Province ", "Uva Province ", "Western Province", "Mahawa"})
        Me.Cmbprovince.Location = New System.Drawing.Point(575, 107)
        Me.Cmbprovince.Name = "Cmbprovince"
        Me.Cmbprovince.Size = New System.Drawing.Size(157, 31)
        Me.Cmbprovince.TabIndex = 86
        '
        'Dgv1
        '
        Me.Dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(3, 656)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.RowHeadersWidth = 51
        Me.Dgv1.RowTemplate.Height = 24
        Me.Dgv1.Size = New System.Drawing.Size(688, 134)
        Me.Dgv1.TabIndex = 87
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2Panel2.Controls.Add(Me.Txtplace)
        Me.Guna2Panel2.Controls.Add(Me.Cmbetype)
        Me.Guna2Panel2.Controls.Add(Me.Cmbprovince)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Cmbplace)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Dtpsd)
        Me.Guna2Panel2.Controls.Add(Me.Dtped)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel2.Location = New System.Drawing.Point(587, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(755, 793)
        Me.Guna2Panel2.TabIndex = 90
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.AutoRoundedCorners = True
        Me.Guna2GradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.BorderColor = System.Drawing.Color.Navy
        Me.Guna2GradientButton2.BorderRadius = 34
        Me.Guna2GradientButton2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientButton2.BorderThickness = 2
        Me.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.Red
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.Firebrick
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(192, 647)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.PressedColor = System.Drawing.Color.Red
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(237, 71)
        Me.Guna2GradientButton2.TabIndex = 89
        Me.Guna2GradientButton2.Text = "DELETE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(692, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel4.Controls.Add(Me.Dgv1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(696, 793)
        Me.Guna2Panel4.TabIndex = 91
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Election_Voting_System.My.Resources.Resources.WhatsApp_Image_2023_08_21_at_04_343
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(688, 647)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'Election_Shedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 793)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Election_Shedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Election_Shedule"
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmbetype As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Dtpsd As DateTimePicker
    Friend WithEvents Dtped As DateTimePicker
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtplace As TextBox
    Friend WithEvents Cmbplace As ComboBox
    Friend WithEvents Cmbprovince As ComboBox
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
End Class
