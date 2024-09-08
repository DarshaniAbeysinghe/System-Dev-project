<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presidentialcandidate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tc1 = New System.Windows.Forms.TabControl()
        Me.Tp1 = New System.Windows.Forms.TabPage()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmbparty = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Picc = New System.Windows.Forms.PictureBox()
        Me.Btnregister = New System.Windows.Forms.Button()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Grpgender = New System.Windows.Forms.GroupBox()
        Me.Rdofemale = New System.Windows.Forms.RadioButton()
        Me.Rdomale = New System.Windows.Forms.RadioButton()
        Me.Lbltpno = New System.Windows.Forms.Label()
        Me.Txttpno = New System.Windows.Forms.TextBox()
        Me.Grpname = New System.Windows.Forms.GroupBox()
        Me.Txtlname = New System.Windows.Forms.TextBox()
        Me.Lbllname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtfname = New System.Windows.Forms.TextBox()
        Me.Lblfname = New System.Windows.Forms.Label()
        Me.Lblbithday = New System.Windows.Forms.Label()
        Me.Txtnic = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cmbdistrict = New System.Windows.Forms.ComboBox()
        Me.Cmbprovince = New System.Windows.Forms.ComboBox()
        Me.Lblprovince = New System.Windows.Forms.Label()
        Me.Lbldistrict = New System.Windows.Forms.Label()
        Me.Lblnic = New System.Windows.Forms.Label()
        Me.Tp2 = New System.Windows.Forms.TabPage()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.Txtsearch = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Btnupdate = New System.Windows.Forms.Button()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tc1.SuspendLayout()
        Me.Tp1.SuspendLayout()
        CType(Me.Picc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grpgender.SuspendLayout()
        Me.Grpname.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Tp2.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(363, 477)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 37)
        Me.Label14.TabIndex = 40
        '
        'Tc1
        '
        Me.Tc1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.Tc1.Controls.Add(Me.Tp1)
        Me.Tc1.Controls.Add(Me.Tp2)
        Me.Tc1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tc1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tc1.ItemSize = New System.Drawing.Size(185, 50)
        Me.Tc1.Location = New System.Drawing.Point(0, 160)
        Me.Tc1.Name = "Tc1"
        Me.Tc1.SelectedIndex = 0
        Me.Tc1.Size = New System.Drawing.Size(947, 757)
        Me.Tc1.TabIndex = 65
        '
        'Tp1
        '
        Me.Tp1.BackColor = System.Drawing.Color.CadetBlue
        Me.Tp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tp1.Controls.Add(Me.Btnexit)
        Me.Tp1.Controls.Add(Me.Label4)
        Me.Tp1.Controls.Add(Me.Cmbparty)
        Me.Tp1.Controls.Add(Me.Label2)
        Me.Tp1.Controls.Add(Me.Picc)
        Me.Tp1.Controls.Add(Me.Btnregister)
        Me.Tp1.Controls.Add(Me.Dtp1)
        Me.Tp1.Controls.Add(Me.Grpgender)
        Me.Tp1.Controls.Add(Me.Lbltpno)
        Me.Tp1.Controls.Add(Me.Txttpno)
        Me.Tp1.Controls.Add(Me.Grpname)
        Me.Tp1.Controls.Add(Me.Lblbithday)
        Me.Tp1.Controls.Add(Me.Txtnic)
        Me.Tp1.Controls.Add(Me.GroupBox2)
        Me.Tp1.Controls.Add(Me.Lblnic)
        Me.Tp1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tp1.Location = New System.Drawing.Point(4, 54)
        Me.Tp1.Name = "Tp1"
        Me.Tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tp1.Size = New System.Drawing.Size(939, 699)
        Me.Tp1.TabIndex = 0
        Me.Tp1.Text = "Candidate Registration"
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.Red
        Me.Btnexit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(241, 635)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(200, 48)
        Me.Btnexit.TabIndex = 87
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(694, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 23)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Attach the picture here"
        '
        'Cmbparty
        '
        Me.Cmbparty.AccessibleName = ""
        Me.Cmbparty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cmbparty.DisplayMember = "hi"
        Me.Cmbparty.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbparty.FormattingEnabled = True
        Me.Cmbparty.Items.AddRange(New Object() {"sel"})
        Me.Cmbparty.Location = New System.Drawing.Point(132, 576)
        Me.Cmbparty.Name = "Cmbparty"
        Me.Cmbparty.Size = New System.Drawing.Size(200, 27)
        Me.Cmbparty.TabIndex = 84
        Me.Cmbparty.Text = "Select your party"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 579)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Party"
        '
        'Picc
        '
        Me.Picc.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Picc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picc.Location = New System.Drawing.Point(705, 161)
        Me.Picc.Name = "Picc"
        Me.Picc.Size = New System.Drawing.Size(195, 195)
        Me.Picc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picc.TabIndex = 85
        Me.Picc.TabStop = False
        '
        'Btnregister
        '
        Me.Btnregister.BackColor = System.Drawing.Color.ForestGreen
        Me.Btnregister.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregister.Location = New System.Drawing.Point(532, 635)
        Me.Btnregister.Name = "Btnregister"
        Me.Btnregister.Size = New System.Drawing.Size(195, 48)
        Me.Btnregister.TabIndex = 80
        Me.Btnregister.Text = "Rgister"
        Me.Btnregister.UseVisualStyleBackColor = False
        '
        'Dtp1
        '
        Me.Dtp1.CustomFormat = "MM-dd-yyyy"
        Me.Dtp1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp1.Location = New System.Drawing.Point(136, 210)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(200, 27)
        Me.Dtp1.TabIndex = 78
        '
        'Grpgender
        '
        Me.Grpgender.BackColor = System.Drawing.Color.Transparent
        Me.Grpgender.Controls.Add(Me.Rdofemale)
        Me.Grpgender.Controls.Add(Me.Rdomale)
        Me.Grpgender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpgender.Location = New System.Drawing.Point(35, 325)
        Me.Grpgender.Name = "Grpgender"
        Me.Grpgender.Size = New System.Drawing.Size(297, 104)
        Me.Grpgender.TabIndex = 77
        Me.Grpgender.TabStop = False
        Me.Grpgender.Text = "Gender"
        '
        'Rdofemale
        '
        Me.Rdofemale.AutoSize = True
        Me.Rdofemale.Location = New System.Drawing.Point(171, 48)
        Me.Rdofemale.Name = "Rdofemale"
        Me.Rdofemale.Size = New System.Drawing.Size(92, 27)
        Me.Rdofemale.TabIndex = 1
        Me.Rdofemale.TabStop = True
        Me.Rdofemale.Text = "Female"
        Me.Rdofemale.UseVisualStyleBackColor = True
        '
        'Rdomale
        '
        Me.Rdomale.AutoSize = True
        Me.Rdomale.Location = New System.Drawing.Point(55, 48)
        Me.Rdomale.Name = "Rdomale"
        Me.Rdomale.Size = New System.Drawing.Size(74, 27)
        Me.Rdomale.TabIndex = 0
        Me.Rdomale.TabStop = True
        Me.Rdomale.Text = "Male"
        Me.Rdomale.UseVisualStyleBackColor = True
        '
        'Lbltpno
        '
        Me.Lbltpno.AutoSize = True
        Me.Lbltpno.BackColor = System.Drawing.Color.Transparent
        Me.Lbltpno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltpno.Location = New System.Drawing.Point(45, 272)
        Me.Lbltpno.Name = "Lbltpno"
        Me.Lbltpno.Size = New System.Drawing.Size(62, 23)
        Me.Lbltpno.TabIndex = 74
        Me.Lbltpno.Text = "Tp.No"
        '
        'Txttpno
        '
        Me.Txttpno.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttpno.Location = New System.Drawing.Point(136, 272)
        Me.Txttpno.Name = "Txttpno"
        Me.Txttpno.Size = New System.Drawing.Size(175, 27)
        Me.Txttpno.TabIndex = 75
        '
        'Grpname
        '
        Me.Grpname.BackColor = System.Drawing.Color.Transparent
        Me.Grpname.Controls.Add(Me.Txtlname)
        Me.Grpname.Controls.Add(Me.Lbllname)
        Me.Grpname.Controls.Add(Me.Label3)
        Me.Grpname.Controls.Add(Me.Txtfname)
        Me.Grpname.Controls.Add(Me.Lblfname)
        Me.Grpname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpname.Location = New System.Drawing.Point(35, 20)
        Me.Grpname.Name = "Grpname"
        Me.Grpname.Size = New System.Drawing.Size(874, 101)
        Me.Grpname.TabIndex = 71
        Me.Grpname.TabStop = False
        Me.Grpname.Text = "Name"
        '
        'Txtlname
        '
        Me.Txtlname.Location = New System.Drawing.Point(571, 35)
        Me.Txtlname.Name = "Txtlname"
        Me.Txtlname.Size = New System.Drawing.Size(263, 30)
        Me.Txtlname.TabIndex = 5
        '
        'Lbllname
        '
        Me.Lbllname.AutoSize = True
        Me.Lbllname.Location = New System.Drawing.Point(449, 38)
        Me.Lbllname.Name = "Lbllname"
        Me.Lbllname.Size = New System.Drawing.Size(102, 23)
        Me.Lbllname.TabIndex = 3
        Me.Lbllname.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 23)
        Me.Label3.TabIndex = 2
        '
        'Txtfname
        '
        Me.Txtfname.Location = New System.Drawing.Point(128, 37)
        Me.Txtfname.Name = "Txtfname"
        Me.Txtfname.Size = New System.Drawing.Size(257, 30)
        Me.Txtfname.TabIndex = 1
        '
        'Lblfname
        '
        Me.Lblfname.AutoSize = True
        Me.Lblfname.Location = New System.Drawing.Point(19, 38)
        Me.Lblfname.Name = "Lblfname"
        Me.Lblfname.Size = New System.Drawing.Size(103, 23)
        Me.Lblfname.TabIndex = 0
        Me.Lblfname.Text = "First Name"
        '
        'Lblbithday
        '
        Me.Lblbithday.AutoSize = True
        Me.Lblbithday.BackColor = System.Drawing.Color.Transparent
        Me.Lblbithday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbithday.Location = New System.Drawing.Point(45, 210)
        Me.Lblbithday.Name = "Lblbithday"
        Me.Lblbithday.Size = New System.Drawing.Size(83, 23)
        Me.Lblbithday.TabIndex = 76
        Me.Lblbithday.Text = "Birthday"
        '
        'Txtnic
        '
        Me.Txtnic.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnic.Location = New System.Drawing.Point(117, 143)
        Me.Txtnic.Name = "Txtnic"
        Me.Txtnic.Size = New System.Drawing.Size(234, 27)
        Me.Txtnic.TabIndex = 72
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmbdistrict)
        Me.GroupBox2.Controls.Add(Me.Cmbprovince)
        Me.GroupBox2.Controls.Add(Me.Lblprovince)
        Me.GroupBox2.Controls.Add(Me.Lbldistrict)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 457)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(692, 100)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Cmbdistrict
        '
        Me.Cmbdistrict.FormattingEnabled = True
        Me.Cmbdistrict.Items.AddRange(New Object() {"iujkjchdb", "vcdghs", "yteuysf", "mnbdc ", " cnbv"})
        Me.Cmbdistrict.Location = New System.Drawing.Point(416, 41)
        Me.Cmbdistrict.Name = "Cmbdistrict"
        Me.Cmbdistrict.Size = New System.Drawing.Size(200, 31)
        Me.Cmbdistrict.TabIndex = 16
        Me.Cmbdistrict.Text = "Select your district"
        '
        'Cmbprovince
        '
        Me.Cmbprovince.DisplayMember = "hi"
        Me.Cmbprovince.FormattingEnabled = True
        Me.Cmbprovince.Items.AddRange(New Object() {"AAA", "BBB", "CCC", "DDD"})
        Me.Cmbprovince.Location = New System.Drawing.Point(101, 41)
        Me.Cmbprovince.Name = "Cmbprovince"
        Me.Cmbprovince.Size = New System.Drawing.Size(200, 31)
        Me.Cmbprovince.TabIndex = 12
        Me.Cmbprovince.Text = "Select your province"
        '
        'Lblprovince
        '
        Me.Lblprovince.AutoSize = True
        Me.Lblprovince.Location = New System.Drawing.Point(19, 46)
        Me.Lblprovince.Name = "Lblprovince"
        Me.Lblprovince.Size = New System.Drawing.Size(84, 23)
        Me.Lblprovince.TabIndex = 12
        Me.Lblprovince.Text = "Province"
        '
        'Lbldistrict
        '
        Me.Lbldistrict.AutoSize = True
        Me.Lbldistrict.Location = New System.Drawing.Point(333, 46)
        Me.Lbldistrict.Name = "Lbldistrict"
        Me.Lbldistrict.Size = New System.Drawing.Size(73, 23)
        Me.Lbldistrict.TabIndex = 13
        Me.Lbldistrict.Text = "District"
        '
        'Lblnic
        '
        Me.Lblnic.AutoSize = True
        Me.Lblnic.BackColor = System.Drawing.Color.Transparent
        Me.Lblnic.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnic.Location = New System.Drawing.Point(45, 146)
        Me.Lblnic.Name = "Lblnic"
        Me.Lblnic.Size = New System.Drawing.Size(45, 23)
        Me.Lblnic.TabIndex = 73
        Me.Lblnic.Text = "NIC"
        '
        'Tp2
        '
        Me.Tp2.AutoScroll = True
        Me.Tp2.BackColor = System.Drawing.Color.CadetBlue
        Me.Tp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tp2.Controls.Add(Me.Btnsearch)
        Me.Tp2.Controls.Add(Me.Txtsearch)
        Me.Tp2.Controls.Add(Me.Button4)
        Me.Tp2.Controls.Add(Me.Btnupdate)
        Me.Tp2.Controls.Add(Me.Dgv1)
        Me.Tp2.Location = New System.Drawing.Point(4, 54)
        Me.Tp2.Name = "Tp2"
        Me.Tp2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tp2.Size = New System.Drawing.Size(939, 699)
        Me.Tp2.TabIndex = 1
        Me.Tp2.Text = "Candidate Details"
        '
        'Btnsearch
        '
        Me.Btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Btnsearch.Location = New System.Drawing.Point(42, 43)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(154, 39)
        Me.Btnsearch.TabIndex = 85
        Me.Btnsearch.Text = "SEARCH"
        Me.Btnsearch.UseVisualStyleBackColor = False
        '
        'Txtsearch
        '
        Me.Txtsearch.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsearch.Location = New System.Drawing.Point(202, 43)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.Size = New System.Drawing.Size(233, 39)
        Me.Txtsearch.TabIndex = 84
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(570, 608)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(186, 46)
        Me.Button4.TabIndex = 83
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Btnupdate
        '
        Me.Btnupdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btnupdate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupdate.Location = New System.Drawing.Point(228, 603)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(186, 51)
        Me.Btnupdate.TabIndex = 82
        Me.Btnupdate.Text = "UPDATE"
        Me.Btnupdate.UseVisualStyleBackColor = False
        '
        'Dgv1
        '
        Me.Dgv1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(42, 96)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.RowHeadersWidth = 51
        Me.Dgv1.RowTemplate.Height = 24
        Me.Dgv1.Size = New System.Drawing.Size(858, 475)
        Me.Dgv1.TabIndex = 66
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 158)
        Me.Panel1.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(344, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 45)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "PRESIDENTIAL CANDIDATE"
        '
        'Presidentialcandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(945, 941)
        Me.Controls.Add(Me.Tc1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Presidentialcandidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDDD"
        Me.Tc1.ResumeLayout(False)
        Me.Tp1.ResumeLayout(False)
        Me.Tp1.PerformLayout()
        CType(Me.Picc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grpgender.ResumeLayout(False)
        Me.Grpgender.PerformLayout()
        Me.Grpname.ResumeLayout(False)
        Me.Grpname.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Tp2.ResumeLayout(False)
        Me.Tp2.PerformLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tc1 As TabControl
    Friend WithEvents Tp1 As TabPage
    Friend WithEvents Tp2 As TabPage
    Friend WithEvents Cmbparty As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btnregister As Button
    Friend WithEvents Dtp1 As DateTimePicker
    Friend WithEvents Grpgender As GroupBox
    Friend WithEvents Rdofemale As RadioButton
    Friend WithEvents Rdomale As RadioButton
    Friend WithEvents Lbltpno As Label
    Friend WithEvents Txttpno As TextBox
    Friend WithEvents Grpname As GroupBox
    Friend WithEvents Txtlname As TextBox
    Friend WithEvents Lbllname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtfname As TextBox
    Friend WithEvents Lblfname As Label
    Friend WithEvents Lblbithday As Label
    Friend WithEvents Txtnic As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cmbdistrict As ComboBox
    Friend WithEvents Cmbprovince As ComboBox
    Friend WithEvents Lblprovince As Label
    Friend WithEvents Lbldistrict As Label
    Friend WithEvents Lblnic As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Picc As PictureBox
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Btnupdate As Button
    Friend WithEvents Txtsearch As TextBox
    Friend WithEvents Btnsearch As Button
    Friend WithEvents Btnexit As Button
End Class
