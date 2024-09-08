<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manage_voters
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
        Me.Tc1 = New System.Windows.Forms.TabControl()
        Me.Tp1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Txtadd = New System.Windows.Forms.TextBox()
        Me.Lbladdress = New System.Windows.Forms.Label()
        Me.Btnregister = New System.Windows.Forms.Button()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Grpgender = New System.Windows.Forms.GroupBox()
        Me.Rdofemale = New System.Windows.Forms.RadioButton()
        Me.Rdomale = New System.Windows.Forms.RadioButton()
        Me.Lbltpno = New System.Windows.Forms.Label()
        Me.Txttpno = New System.Windows.Forms.TextBox()
        Me.Grpname = New System.Windows.Forms.GroupBox()
        Me.Lblmname = New System.Windows.Forms.Label()
        Me.Txtlname = New System.Windows.Forms.TextBox()
        Me.Txtmname = New System.Windows.Forms.TextBox()
        Me.Lbllname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtfname = New System.Windows.Forms.TextBox()
        Me.Lblfname = New System.Windows.Forms.Label()
        Me.Lblbithday = New System.Windows.Forms.Label()
        Me.Txtnic = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cmbps = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tc1.SuspendLayout()
        Me.Tp1.SuspendLayout()
        Me.Grpgender.SuspendLayout()
        Me.Grpname.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Tp2.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tc1
        '
        Me.Tc1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.Tc1.Controls.Add(Me.Tp1)
        Me.Tc1.Controls.Add(Me.Tp2)
        Me.Tc1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tc1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tc1.ItemSize = New System.Drawing.Size(185, 50)
        Me.Tc1.Location = New System.Drawing.Point(1, 176)
        Me.Tc1.Name = "Tc1"
        Me.Tc1.SelectedIndex = 0
        Me.Tc1.Size = New System.Drawing.Size(1057, 862)
        Me.Tc1.TabIndex = 66
        '
        'Tp1
        '
        Me.Tp1.BackColor = System.Drawing.Color.CadetBlue
        Me.Tp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tp1.Controls.Add(Me.PictureBox1)
        Me.Tp1.Controls.Add(Me.Button2)
        Me.Tp1.Controls.Add(Me.Txtadd)
        Me.Tp1.Controls.Add(Me.Lbladdress)
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
        Me.Tp1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tp1.Location = New System.Drawing.Point(4, 54)
        Me.Tp1.Name = "Tp1"
        Me.Tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tp1.Size = New System.Drawing.Size(1049, 804)
        Me.Tp1.TabIndex = 0
        Me.Tp1.Text = "Voter Registration"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(240, 711)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 54)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Txtadd
        '
        Me.Txtadd.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtadd.Location = New System.Drawing.Point(123, 373)
        Me.Txtadd.Name = "Txtadd"
        Me.Txtadd.Size = New System.Drawing.Size(175, 27)
        Me.Txtadd.TabIndex = 88
        '
        'Lbladdress
        '
        Me.Lbladdress.AutoSize = True
        Me.Lbladdress.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbladdress.Location = New System.Drawing.Point(30, 373)
        Me.Lbladdress.Name = "Lbladdress"
        Me.Lbladdress.Size = New System.Drawing.Size(68, 19)
        Me.Lbladdress.TabIndex = 87
        Me.Lbladdress.Text = "Address"
        '
        'Btnregister
        '
        Me.Btnregister.BackColor = System.Drawing.Color.ForestGreen
        Me.Btnregister.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregister.Location = New System.Drawing.Point(557, 711)
        Me.Btnregister.Name = "Btnregister"
        Me.Btnregister.Size = New System.Drawing.Size(247, 54)
        Me.Btnregister.TabIndex = 80
        Me.Btnregister.Text = "Register"
        Me.Btnregister.UseVisualStyleBackColor = False
        '
        'Dtp1
        '
        Me.Dtp1.CustomFormat = "MM-dd-yyyy"
        Me.Dtp1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp1.Location = New System.Drawing.Point(125, 221)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(200, 27)
        Me.Dtp1.TabIndex = 78
        '
        'Grpgender
        '
        Me.Grpgender.BackColor = System.Drawing.Color.Transparent
        Me.Grpgender.Controls.Add(Me.Rdofemale)
        Me.Grpgender.Controls.Add(Me.Rdomale)
        Me.Grpgender.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpgender.Location = New System.Drawing.Point(22, 449)
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
        Me.Rdofemale.Size = New System.Drawing.Size(85, 23)
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
        Me.Rdomale.Size = New System.Drawing.Size(68, 23)
        Me.Rdomale.TabIndex = 0
        Me.Rdomale.TabStop = True
        Me.Rdomale.Text = "Male"
        Me.Rdomale.UseVisualStyleBackColor = True
        '
        'Lbltpno
        '
        Me.Lbltpno.AutoSize = True
        Me.Lbltpno.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltpno.Location = New System.Drawing.Point(36, 297)
        Me.Lbltpno.Name = "Lbltpno"
        Me.Lbltpno.Size = New System.Drawing.Size(53, 19)
        Me.Lbltpno.TabIndex = 74
        Me.Lbltpno.Text = "Tp.No"
        '
        'Txttpno
        '
        Me.Txttpno.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttpno.Location = New System.Drawing.Point(123, 289)
        Me.Txttpno.Name = "Txttpno"
        Me.Txttpno.Size = New System.Drawing.Size(175, 27)
        Me.Txttpno.TabIndex = 75
        '
        'Grpname
        '
        Me.Grpname.BackColor = System.Drawing.Color.Transparent
        Me.Grpname.Controls.Add(Me.Lblmname)
        Me.Grpname.Controls.Add(Me.Txtlname)
        Me.Grpname.Controls.Add(Me.Txtmname)
        Me.Grpname.Controls.Add(Me.Lbllname)
        Me.Grpname.Controls.Add(Me.Label3)
        Me.Grpname.Controls.Add(Me.Txtfname)
        Me.Grpname.Controls.Add(Me.Lblfname)
        Me.Grpname.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpname.Location = New System.Drawing.Point(22, 27)
        Me.Grpname.Name = "Grpname"
        Me.Grpname.Size = New System.Drawing.Size(1010, 84)
        Me.Grpname.TabIndex = 71
        Me.Grpname.TabStop = False
        Me.Grpname.Text = "Name"
        '
        'Lblmname
        '
        Me.Lblmname.AutoSize = True
        Me.Lblmname.Location = New System.Drawing.Point(324, 40)
        Me.Lblmname.Name = "Lblmname"
        Me.Lblmname.Size = New System.Drawing.Size(109, 19)
        Me.Lblmname.TabIndex = 8
        Me.Lblmname.Text = "Middle Name"
        '
        'Txtlname
        '
        Me.Txtlname.Location = New System.Drawing.Point(794, 37)
        Me.Txtlname.Name = "Txtlname"
        Me.Txtlname.Size = New System.Drawing.Size(178, 27)
        Me.Txtlname.TabIndex = 5
        '
        'Txtmname
        '
        Me.Txtmname.Location = New System.Drawing.Point(456, 35)
        Me.Txtmname.Name = "Txtmname"
        Me.Txtmname.Size = New System.Drawing.Size(178, 27)
        Me.Txtmname.TabIndex = 7
        '
        'Lbllname
        '
        Me.Lbllname.AutoSize = True
        Me.Lbllname.Location = New System.Drawing.Point(674, 40)
        Me.Lbllname.Name = "Lbllname"
        Me.Lbllname.Size = New System.Drawing.Size(87, 19)
        Me.Lbllname.TabIndex = 3
        Me.Lbllname.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 2
        '
        'Txtfname
        '
        Me.Txtfname.Location = New System.Drawing.Point(125, 35)
        Me.Txtfname.Name = "Txtfname"
        Me.Txtfname.Size = New System.Drawing.Size(178, 27)
        Me.Txtfname.TabIndex = 1
        '
        'Lblfname
        '
        Me.Lblfname.AutoSize = True
        Me.Lblfname.Location = New System.Drawing.Point(19, 38)
        Me.Lblfname.Name = "Lblfname"
        Me.Lblfname.Size = New System.Drawing.Size(93, 19)
        Me.Lblfname.TabIndex = 0
        Me.Lblfname.Text = "First Name"
        '
        'Lblbithday
        '
        Me.Lblbithday.AutoSize = True
        Me.Lblbithday.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbithday.Location = New System.Drawing.Point(38, 226)
        Me.Lblbithday.Name = "Lblbithday"
        Me.Lblbithday.Size = New System.Drawing.Size(75, 19)
        Me.Lblbithday.TabIndex = 76
        Me.Lblbithday.Text = "Birthday"
        '
        'Txtnic
        '
        Me.Txtnic.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnic.Location = New System.Drawing.Point(113, 141)
        Me.Txtnic.Name = "Txtnic"
        Me.Txtnic.Size = New System.Drawing.Size(234, 27)
        Me.Txtnic.TabIndex = 72
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmbps)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Cmbdistrict)
        Me.GroupBox2.Controls.Add(Me.Cmbprovince)
        Me.GroupBox2.Controls.Add(Me.Lblprovince)
        Me.GroupBox2.Controls.Add(Me.Lbldistrict)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 577)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1010, 105)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Cmbps
        '
        Me.Cmbps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbps.FormattingEnabled = True
        Me.Cmbps.Items.AddRange(New Object() {"iuaycdc", "knbxc ", "bhc", "jkhcn"})
        Me.Cmbps.Location = New System.Drawing.Point(794, 41)
        Me.Cmbps.Name = "Cmbps"
        Me.Cmbps.Size = New System.Drawing.Size(207, 27)
        Me.Cmbps.TabIndex = 19
        Me.Cmbps.Text = "Select your pradeshiya saba"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(653, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Pradeshiya Saba"
        '
        'Cmbdistrict
        '
        Me.Cmbdistrict.FormattingEnabled = True
        Me.Cmbdistrict.Items.AddRange(New Object() {"iujkjchdb", "vcdghs", "yteuysf", "mnbdc ", " cnbv"})
        Me.Cmbdistrict.Location = New System.Drawing.Point(416, 41)
        Me.Cmbdistrict.Name = "Cmbdistrict"
        Me.Cmbdistrict.Size = New System.Drawing.Size(200, 27)
        Me.Cmbdistrict.TabIndex = 16
        Me.Cmbdistrict.Text = "Select your district"
        '
        'Cmbprovince
        '
        Me.Cmbprovince.AccessibleName = "h"
        Me.Cmbprovince.AllowDrop = True
        Me.Cmbprovince.AutoCompleteCustomSource.AddRange(New String() {"Select"})
        Me.Cmbprovince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cmbprovince.DisplayMember = "hi"
        Me.Cmbprovince.FormattingEnabled = True
        Me.Cmbprovince.Items.AddRange(New Object() {"AAA", "BBB", "CCC", "DDD"})
        Me.Cmbprovince.Location = New System.Drawing.Point(101, 41)
        Me.Cmbprovince.Name = "Cmbprovince"
        Me.Cmbprovince.Size = New System.Drawing.Size(200, 27)
        Me.Cmbprovince.TabIndex = 12
        Me.Cmbprovince.Text = "Select your province"
        '
        'Lblprovince
        '
        Me.Lblprovince.AutoSize = True
        Me.Lblprovince.Location = New System.Drawing.Point(19, 46)
        Me.Lblprovince.Name = "Lblprovince"
        Me.Lblprovince.Size = New System.Drawing.Size(76, 19)
        Me.Lblprovince.TabIndex = 12
        Me.Lblprovince.Text = "Province"
        '
        'Lbldistrict
        '
        Me.Lbldistrict.AutoSize = True
        Me.Lbldistrict.Location = New System.Drawing.Point(333, 46)
        Me.Lbldistrict.Name = "Lbldistrict"
        Me.Lbldistrict.Size = New System.Drawing.Size(68, 19)
        Me.Lbldistrict.TabIndex = 13
        Me.Lbldistrict.Text = "District"
        '
        'Lblnic
        '
        Me.Lblnic.AutoSize = True
        Me.Lblnic.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnic.Location = New System.Drawing.Point(41, 144)
        Me.Lblnic.Name = "Lblnic"
        Me.Lblnic.Size = New System.Drawing.Size(39, 19)
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
        Me.Tp2.Size = New System.Drawing.Size(1049, 804)
        Me.Tp2.TabIndex = 1
        Me.Tp2.Text = "Voter Details"
        '
        'Btnsearch
        '
        Me.Btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Btnsearch.Location = New System.Drawing.Point(31, 25)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(125, 43)
        Me.Btnsearch.TabIndex = 85
        Me.Btnsearch.Text = "SEARCH"
        Me.Btnsearch.UseVisualStyleBackColor = False
        '
        'Txtsearch
        '
        Me.Txtsearch.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsearch.Location = New System.Drawing.Point(162, 31)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.Size = New System.Drawing.Size(233, 34)
        Me.Txtsearch.TabIndex = 84
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(618, 525)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(186, 51)
        Me.Button4.TabIndex = 83
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Btnupdate
        '
        Me.Btnupdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btnupdate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupdate.Location = New System.Drawing.Point(282, 525)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(186, 51)
        Me.Btnupdate.TabIndex = 82
        Me.Btnupdate.Text = "UPDATE"
        Me.Btnupdate.UseVisualStyleBackColor = False
        '
        'Dgv1
        '
        Me.Dgv1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Dgv1.ColumnHeadersHeight = 35
        Me.Dgv1.Location = New System.Drawing.Point(31, 89)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.RowHeadersWidth = 51
        Me.Dgv1.RowTemplate.Height = 24
        Me.Dgv1.Size = New System.Drawing.Size(982, 400)
        Me.Dgv1.TabIndex = 66
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 169)
        Me.Panel1.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(631, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 45)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "MANAGE VOTERS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Election_Voting_System.My.Resources.Resources.WhatsApp_Image_2023_08_20_at_18_41_15_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(600, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 363)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'Manage_voters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1065, 1048)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tc1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Manage_voters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage_voters"
        Me.Tc1.ResumeLayout(False)
        Me.Tp1.ResumeLayout(False)
        Me.Tp1.PerformLayout()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tc1 As TabControl
    Friend WithEvents Tp1 As TabPage
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
    Friend WithEvents Tp2 As TabPage
    Friend WithEvents Txtsearch As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Btnupdate As Button
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents Txtadd As TextBox
    Friend WithEvents Lbladdress As Label
    Friend WithEvents Lblmname As Label
    Friend WithEvents Txtmname As TextBox
    Friend WithEvents Btnsearch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmbps As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
