﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        TabControl1 = New TabControl()
        tabControl = New TabPage()
        panControl = New Panel()
        Label3 = New Label()
        panSettings = New Panel()
        GroupBox1 = New GroupBox()
        btnResetSettings = New Button()
        btnSave = New Button()
        lblMessage = New Label()
        rtfMessage = New RichTextBox()
        Label4 = New Label()
        chkTimeIn = New CheckBox()
        btnForce = New Button()
        tabData = New TabPage()
        panTitle = New Panel()
        Label2 = New Label()
        panGrid = New Panel()
        grdAttendance = New DataGridView()
        panFilter = New Panel()
        dtpTo = New DateTimePicker()
        dtpFrom = New DateTimePicker()
        cboYear = New ComboBox()
        btnReset = New Button()
        btnExport = New Button()
        btnSearch = New Button()
        Label1 = New Label()
        cboDepartment = New ComboBox()
        PictureBox7 = New PictureBox()
        tabAddUser = New TabPage()
        pnlAdd = New Panel()
        Label10 = New Label()
        panAddUser = New Panel()
        Label9 = New Label()
        cboStudentCourse = New ComboBox()
        cboStudentYear = New ComboBox()
        txtFullName = New TextBox()
        cboStudentDepartment = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        lblDepartment = New Label()
        lblTimeIn = New Label()
        lblCourse = New Label()
        lblFullName = New Label()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        btnAddUser = New Button()
        lblStudent = New Label()
        txtStudentID = New TextBox()
        tabGroupings = New TabPage()
        Panel1 = New Panel()
        btnRandomize = New Button()
        grdGroup1 = New DataGridView()
        grdGroup4 = New DataGridView()
        grdGroup2 = New DataGridView()
        grdGroup3 = New DataGridView()
        pnlView = New Panel()
        Label11 = New Label()
        btnClose = New Button()
        TabControl1.SuspendLayout()
        tabControl.SuspendLayout()
        panControl.SuspendLayout()
        panSettings.SuspendLayout()
        GroupBox1.SuspendLayout()
        tabData.SuspendLayout()
        panTitle.SuspendLayout()
        panGrid.SuspendLayout()
        CType(grdAttendance, ComponentModel.ISupportInitialize).BeginInit()
        panFilter.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        tabAddUser.SuspendLayout()
        pnlAdd.SuspendLayout()
        panAddUser.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        tabGroupings.SuspendLayout()
        Panel1.SuspendLayout()
        CType(grdGroup1, ComponentModel.ISupportInitialize).BeginInit()
        CType(grdGroup4, ComponentModel.ISupportInitialize).BeginInit()
        CType(grdGroup2, ComponentModel.ISupportInitialize).BeginInit()
        CType(grdGroup3, ComponentModel.ISupportInitialize).BeginInit()
        pnlView.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabControl)
        TabControl1.Controls.Add(tabData)
        TabControl1.Controls.Add(tabAddUser)
        TabControl1.Controls.Add(tabGroupings)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.ItemSize = New Size(108, 30)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1950, 1039)
        TabControl1.TabIndex = 0
        ' 
        ' tabControl
        ' 
        tabControl.BackColor = Color.DarkGray
        tabControl.BackgroundImageLayout = ImageLayout.Stretch
        tabControl.Controls.Add(panControl)
        tabControl.Controls.Add(panSettings)
        tabControl.Location = New Point(4, 34)
        tabControl.Name = "tabControl"
        tabControl.Padding = New Padding(3)
        tabControl.Size = New Size(1942, 1001)
        tabControl.TabIndex = 1
        tabControl.Text = "Control"
        ' 
        ' panControl
        ' 
        panControl.BackColor = Color.Transparent
        panControl.BorderStyle = BorderStyle.Fixed3D
        panControl.Controls.Add(Label3)
        panControl.Location = New Point(488, 46)
        panControl.Name = "panControl"
        panControl.Size = New Size(317, 91)
        panControl.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(45, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(223, 45)
        Label3.TabIndex = 5
        Label3.Text = "Control Panel"
        ' 
        ' panSettings
        ' 
        panSettings.Anchor = AnchorStyles.Top
        panSettings.BackColor = Color.WhiteSmoke
        panSettings.Controls.Add(GroupBox1)
        panSettings.Location = New Point(410, 143)
        panSettings.Name = "panSettings"
        panSettings.Size = New Size(449, 510)
        panSettings.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnResetSettings)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(lblMessage)
        GroupBox1.Controls.Add(rtfMessage)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(chkTimeIn)
        GroupBox1.Controls.Add(btnForce)
        GroupBox1.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(37, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(377, 439)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Time In / Out"
        ' 
        ' btnResetSettings
        ' 
        btnResetSettings.BackColor = Color.Silver
        btnResetSettings.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnResetSettings.Location = New Point(207, 363)
        btnResetSettings.Name = "btnResetSettings"
        btnResetSettings.Size = New Size(128, 44)
        btnResetSettings.TabIndex = 10
        btnResetSettings.Text = "Reset"
        btnResetSettings.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Silver
        btnSave.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Location = New Point(34, 363)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(159, 44)
        btnSave.TabIndex = 9
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.Top
        lblMessage.AutoSize = True
        lblMessage.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        lblMessage.Location = New Point(290, 203)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(46, 19)
        lblMessage.TabIndex = 8
        lblMessage.Text = "0 / 40"
        ' 
        ' rtfMessage
        ' 
        rtfMessage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rtfMessage.Location = New Point(34, 113)
        rtfMessage.MaxLength = 40
        rtfMessage.Name = "rtfMessage"
        rtfMessage.Size = New Size(303, 83)
        rtfMessage.TabIndex = 7
        rtfMessage.Text = "Please wait for the admin to come back."
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(40, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(297, 19)
        Label4.TabIndex = 6
        Label4.Text = "Forces to time out all the attendance for today."
        ' 
        ' chkTimeIn
        ' 
        chkTimeIn.AutoSize = True
        chkTimeIn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkTimeIn.Location = New Point(122, 84)
        chkTimeIn.Name = "chkTimeIn"
        chkTimeIn.Size = New Size(130, 25)
        chkTimeIn.TabIndex = 0
        chkTimeIn.Text = "Enable Time In"
        chkTimeIn.UseVisualStyleBackColor = True
        ' 
        ' btnForce
        ' 
        btnForce.BackColor = Color.LightCoral
        btnForce.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnForce.Location = New Point(104, 316)
        btnForce.Name = "btnForce"
        btnForce.Size = New Size(171, 40)
        btnForce.TabIndex = 4
        btnForce.Text = "Force Time Out"
        btnForce.UseVisualStyleBackColor = False
        ' 
        ' tabData
        ' 
        tabData.BackColor = Color.Silver
        tabData.BackgroundImageLayout = ImageLayout.Stretch
        tabData.Controls.Add(panTitle)
        tabData.Controls.Add(panGrid)
        tabData.Controls.Add(panFilter)
        tabData.Location = New Point(4, 34)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(1942, 1001)
        tabData.TabIndex = 0
        tabData.Text = "Export"
        ' 
        ' panTitle
        ' 
        panTitle.Anchor = AnchorStyles.Top
        panTitle.BackColor = Color.Transparent
        panTitle.BorderStyle = BorderStyle.Fixed3D
        panTitle.Controls.Add(Label2)
        panTitle.Location = New Point(484, 46)
        panTitle.Name = "panTitle"
        panTitle.Size = New Size(317, 91)
        panTitle.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(22, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(269, 45)
        Label2.TabIndex = 4
        Label2.Text = "Attendance Logs"
        ' 
        ' panGrid
        ' 
        panGrid.BackColor = Color.WhiteSmoke
        panGrid.Controls.Add(grdAttendance)
        panGrid.Location = New Point(477, 231)
        panGrid.Name = "panGrid"
        panGrid.Size = New Size(764, 588)
        panGrid.TabIndex = 1
        ' 
        ' grdAttendance
        ' 
        grdAttendance.AllowUserToAddRows = False
        grdAttendance.AllowUserToDeleteRows = False
        grdAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        grdAttendance.BackgroundColor = Color.WhiteSmoke
        grdAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdAttendance.Location = New Point(26, 26)
        grdAttendance.Name = "grdAttendance"
        grdAttendance.ReadOnly = True
        grdAttendance.RowHeadersWidth = 51
        grdAttendance.RowTemplate.Height = 25
        grdAttendance.Size = New Size(718, 537)
        grdAttendance.TabIndex = 0
        grdAttendance.TabStop = False
        ' 
        ' panFilter
        ' 
        panFilter.BackColor = Color.WhiteSmoke
        panFilter.Controls.Add(dtpTo)
        panFilter.Controls.Add(dtpFrom)
        panFilter.Controls.Add(cboYear)
        panFilter.Controls.Add(btnReset)
        panFilter.Controls.Add(btnExport)
        panFilter.Controls.Add(btnSearch)
        panFilter.Controls.Add(Label1)
        panFilter.Controls.Add(cboDepartment)
        panFilter.Controls.Add(PictureBox7)
        panFilter.Location = New Point(11, 230)
        panFilter.Name = "panFilter"
        panFilter.Size = New Size(451, 588)
        panFilter.TabIndex = 0
        ' 
        ' dtpTo
        ' 
        dtpTo.CustomFormat = "MMMM dd, yyyy"
        dtpTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.Location = New Point(103, 400)
        dtpTo.MaxDate = New DateTime(2024, 10, 31, 0, 0, 0, 0)
        dtpTo.MinDate = New DateTime(2023, 5, 1, 0, 0, 0, 0)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(245, 29)
        dtpTo.TabIndex = 5
        dtpTo.Value = New DateTime(2023, 6, 1, 0, 0, 0, 0)
        ' 
        ' dtpFrom
        ' 
        dtpFrom.CustomFormat = "MMMM dd, yyyy"
        dtpFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.Location = New Point(103, 341)
        dtpFrom.MaxDate = New DateTime(2024, 10, 31, 0, 0, 0, 0)
        dtpFrom.MinDate = New DateTime(2023, 5, 1, 0, 0, 0, 0)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(245, 29)
        dtpFrom.TabIndex = 4
        dtpFrom.Value = New DateTime(2023, 6, 1, 0, 0, 0, 0)
        ' 
        ' cboYear
        ' 
        cboYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboYear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboYear.FormattingEnabled = True
        cboYear.Items.AddRange(New Object() {"YEAR - ALL", "1", "2", "3", "4"})
        cboYear.Location = New Point(103, 292)
        cboYear.Name = "cboYear"
        cboYear.Size = New Size(245, 29)
        cboYear.TabIndex = 3
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ScrollBar
        btnReset.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(282, 457)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(66, 40)
        btnReset.TabIndex = 7
        btnReset.TabStop = False
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.Silver
        btnExport.Enabled = False
        btnExport.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnExport.Location = New Point(103, 508)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(245, 40)
        btnExport.TabIndex = 8
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.CornflowerBlue
        btnSearch.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(103, 457)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(171, 40)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(210, 373)
        Label1.Name = "Label1"
        Label1.Size = New Size(29, 25)
        Label1.TabIndex = 19
        Label1.Text = "to"
        ' 
        ' cboDepartment
        ' 
        cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboDepartment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboDepartment.FormattingEnabled = True
        cboDepartment.Items.AddRange(New Object() {"Department  - ALL"})
        cboDepartment.Location = New Point(103, 242)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(245, 29)
        cboDepartment.TabIndex = 2
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = My.Resources.Resources.CPS_Logo
        PictureBox7.Location = New Point(126, 34)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(192, 175)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' tabAddUser
        ' 
        tabAddUser.BackColor = Color.Silver
        tabAddUser.BackgroundImageLayout = ImageLayout.Stretch
        tabAddUser.Controls.Add(pnlAdd)
        tabAddUser.Controls.Add(panAddUser)
        tabAddUser.Location = New Point(4, 34)
        tabAddUser.Name = "tabAddUser"
        tabAddUser.Padding = New Padding(3)
        tabAddUser.Size = New Size(1942, 1001)
        tabAddUser.TabIndex = 2
        tabAddUser.Text = "Add Student"
        ' 
        ' pnlAdd
        ' 
        pnlAdd.Anchor = AnchorStyles.Top
        pnlAdd.BackColor = Color.Transparent
        pnlAdd.BorderStyle = BorderStyle.Fixed3D
        pnlAdd.Controls.Add(Label10)
        pnlAdd.Location = New Point(484, 46)
        pnlAdd.Name = "pnlAdd"
        pnlAdd.Size = New Size(317, 91)
        pnlAdd.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(52, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(208, 45)
        Label10.TabIndex = 6
        Label10.Text = "Add Student"
        ' 
        ' panAddUser
        ' 
        panAddUser.BackColor = Color.WhiteSmoke
        panAddUser.BorderStyle = BorderStyle.Fixed3D
        panAddUser.Controls.Add(Label9)
        panAddUser.Controls.Add(cboStudentCourse)
        panAddUser.Controls.Add(cboStudentYear)
        panAddUser.Controls.Add(txtFullName)
        panAddUser.Controls.Add(cboStudentDepartment)
        panAddUser.Controls.Add(Label5)
        panAddUser.Controls.Add(Label6)
        panAddUser.Controls.Add(lblDepartment)
        panAddUser.Controls.Add(lblTimeIn)
        panAddUser.Controls.Add(lblCourse)
        panAddUser.Controls.Add(lblFullName)
        panAddUser.Controls.Add(Label8)
        panAddUser.Controls.Add(Label7)
        panAddUser.Controls.Add(PictureBox2)
        panAddUser.Controls.Add(btnAddUser)
        panAddUser.Controls.Add(lblStudent)
        panAddUser.Controls.Add(txtStudentID)
        panAddUser.Location = New Point(413, 129)
        panAddUser.Name = "panAddUser"
        panAddUser.Size = New Size(459, 576)
        panAddUser.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Baskerville Old Face", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(75, 302)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 14)
        Label9.TabIndex = 28
        Label9.Text = "(Surmane, First name)"
        ' 
        ' cboStudentCourse
        ' 
        cboStudentCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentCourse.Enabled = False
        cboStudentCourse.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentCourse.FormattingEnabled = True
        cboStudentCourse.Location = New Point(75, 474)
        cboStudentCourse.Name = "cboStudentCourse"
        cboStudentCourse.Size = New Size(225, 29)
        cboStudentCourse.TabIndex = 4
        ' 
        ' cboStudentYear
        ' 
        cboStudentYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentYear.Enabled = False
        cboStudentYear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentYear.FormattingEnabled = True
        cboStudentYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cboStudentYear.Location = New Point(311, 474)
        cboStudentYear.Name = "cboStudentYear"
        cboStudentYear.Size = New Size(62, 29)
        cboStudentYear.TabIndex = 5
        ' 
        ' txtFullName
        ' 
        txtFullName.CharacterCasing = CharacterCasing.Upper
        txtFullName.Enabled = False
        txtFullName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtFullName.Location = New Point(75, 324)
        txtFullName.MaxLength = 50
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "DELA CRUZ, JUAN"
        txtFullName.Size = New Size(298, 29)
        txtFullName.TabIndex = 2
        ' 
        ' cboStudentDepartment
        ' 
        cboStudentDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentDepartment.Enabled = False
        cboStudentDepartment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentDepartment.FormattingEnabled = True
        cboStudentDepartment.Location = New Point(75, 397)
        cboStudentDepartment.Name = "cboStudentDepartment"
        cboStudentDepartment.Size = New Size(298, 29)
        cboStudentDepartment.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(75, 367)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 25)
        Label5.TabIndex = 27
        Label5.Text = "Department:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(311, 443)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 25)
        Label6.TabIndex = 25
        Label6.Text = "Year:"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDepartment.Location = New Point(75, 420)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(0, 25)
        lblDepartment.TabIndex = 21
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.AutoSize = True
        lblTimeIn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTimeIn.Location = New Point(75, 480)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Size = New Size(0, 25)
        lblTimeIn.TabIndex = 19
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.Location = New Point(75, 360)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(0, 25)
        lblCourse.TabIndex = 17
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.Location = New Point(75, 300)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(0, 25)
        lblFullName.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(79, 444)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 25)
        Label8.TabIndex = 15
        Label8.Text = "Course:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(75, 279)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 25)
        Label7.TabIndex = 14
        Label7.Text = "Full Name:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = My.Resources.Resources.CPS_Logo
        PictureBox2.Location = New Point(128, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(203, 183)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.Silver
        btnAddUser.Enabled = False
        btnAddUser.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddUser.Location = New Point(136, 517)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(163, 40)
        btnAddUser.TabIndex = 6
        btnAddUser.Text = "Add Student"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.BackColor = Color.Transparent
        lblStudent.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudent.Location = New Point(75, 207)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(154, 25)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Student Number:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(75, 239)
        txtStudentID.MaxLength = 10
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "1234-12345"
        txtStudentID.Size = New Size(298, 29)
        txtStudentID.TabIndex = 1
        ' 
        ' tabGroupings
        ' 
        tabGroupings.BackColor = Color.Silver
        tabGroupings.Controls.Add(Panel1)
        tabGroupings.Controls.Add(pnlView)
        tabGroupings.Location = New Point(4, 34)
        tabGroupings.Name = "tabGroupings"
        tabGroupings.Size = New Size(1942, 1001)
        tabGroupings.TabIndex = 3
        tabGroupings.Text = "Groupings"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(btnRandomize)
        Panel1.Controls.Add(grdGroup1)
        Panel1.Controls.Add(grdGroup4)
        Panel1.Controls.Add(grdGroup2)
        Panel1.Controls.Add(grdGroup3)
        Panel1.Location = New Point(134, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1674, 832)
        Panel1.TabIndex = 13
        ' 
        ' btnRandomize
        ' 
        btnRandomize.BackColor = Color.WhiteSmoke
        btnRandomize.Location = New Point(1501, 22)
        btnRandomize.Name = "btnRandomize"
        btnRandomize.Size = New Size(156, 46)
        btnRandomize.TabIndex = 14
        btnRandomize.Text = "Randomize"
        btnRandomize.UseVisualStyleBackColor = False
        ' 
        ' grdGroup1
        ' 
        grdGroup1.AllowUserToAddRows = False
        grdGroup1.AllowUserToDeleteRows = False
        grdGroup1.AllowUserToOrderColumns = True
        grdGroup1.AllowUserToResizeRows = False
        grdGroup1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        grdGroup1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grdGroup1.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        grdGroup1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        grdGroup1.DefaultCellStyle = DataGridViewCellStyle1
        grdGroup1.GridColor = Color.Black
        grdGroup1.Location = New Point(26, 86)
        grdGroup1.Name = "grdGroup1"
        grdGroup1.ReadOnly = True
        grdGroup1.RowHeadersVisible = False
        grdGroup1.RowHeadersWidth = 82
        grdGroup1.RowTemplate.Height = 25
        grdGroup1.Size = New Size(390, 746)
        grdGroup1.TabIndex = 1
        ' 
        ' grdGroup4
        ' 
        grdGroup4.AllowUserToAddRows = False
        grdGroup4.AllowUserToDeleteRows = False
        grdGroup4.AllowUserToOrderColumns = True
        grdGroup4.AllowUserToResizeRows = False
        grdGroup4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        grdGroup4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grdGroup4.BackgroundColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        grdGroup4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        grdGroup4.DefaultCellStyle = DataGridViewCellStyle2
        grdGroup4.GridColor = Color.Black
        grdGroup4.Location = New Point(1267, 86)
        grdGroup4.Name = "grdGroup4"
        grdGroup4.ReadOnly = True
        grdGroup4.RowHeadersVisible = False
        grdGroup4.RowHeadersWidth = 82
        grdGroup4.RowTemplate.Height = 25
        grdGroup4.Size = New Size(390, 746)
        grdGroup4.TabIndex = 12
        ' 
        ' grdGroup2
        ' 
        grdGroup2.AllowUserToAddRows = False
        grdGroup2.AllowUserToDeleteRows = False
        grdGroup2.AllowUserToOrderColumns = True
        grdGroup2.AllowUserToResizeRows = False
        grdGroup2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        grdGroup2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grdGroup2.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        grdGroup2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdGroup2.DefaultCellStyle = DataGridViewCellStyle3
        grdGroup2.GridColor = Color.Black
        grdGroup2.Location = New Point(437, 86)
        grdGroup2.Name = "grdGroup2"
        grdGroup2.ReadOnly = True
        grdGroup2.RowHeadersVisible = False
        grdGroup2.RowHeadersWidth = 82
        grdGroup2.RowTemplate.Height = 25
        grdGroup2.Size = New Size(390, 746)
        grdGroup2.TabIndex = 10
        ' 
        ' grdGroup3
        ' 
        grdGroup3.AllowUserToAddRows = False
        grdGroup3.AllowUserToDeleteRows = False
        grdGroup3.AllowUserToOrderColumns = True
        grdGroup3.AllowUserToResizeRows = False
        grdGroup3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        grdGroup3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grdGroup3.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        grdGroup3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        grdGroup3.DefaultCellStyle = DataGridViewCellStyle4
        grdGroup3.GridColor = Color.Black
        grdGroup3.Location = New Point(856, 86)
        grdGroup3.Name = "grdGroup3"
        grdGroup3.ReadOnly = True
        grdGroup3.RowHeadersVisible = False
        grdGroup3.RowHeadersWidth = 82
        grdGroup3.RowTemplate.Height = 25
        grdGroup3.Size = New Size(390, 746)
        grdGroup3.TabIndex = 11
        ' 
        ' pnlView
        ' 
        pnlView.BackColor = Color.Transparent
        pnlView.BorderStyle = BorderStyle.Fixed3D
        pnlView.Controls.Add(Label11)
        pnlView.Location = New Point(813, 17)
        pnlView.Name = "pnlView"
        pnlView.Size = New Size(317, 91)
        pnlView.TabIndex = 9
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(68, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(177, 45)
        Label11.TabIndex = 5
        Label11.Text = "Groupings"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.LightCoral
        btnClose.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(1869, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(81, 30)
        btnClose.TabIndex = 2
        btnClose.TabStop = False
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1950, 1039)
        Controls.Add(btnClose)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAdmin"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmAdmin"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        tabControl.ResumeLayout(False)
        panControl.ResumeLayout(False)
        panControl.PerformLayout()
        panSettings.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        tabData.ResumeLayout(False)
        panTitle.ResumeLayout(False)
        panTitle.PerformLayout()
        panGrid.ResumeLayout(False)
        CType(grdAttendance, ComponentModel.ISupportInitialize).EndInit()
        panFilter.ResumeLayout(False)
        panFilter.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        tabAddUser.ResumeLayout(False)
        pnlAdd.ResumeLayout(False)
        pnlAdd.PerformLayout()
        panAddUser.ResumeLayout(False)
        panAddUser.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        tabGroupings.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(grdGroup1, ComponentModel.ISupportInitialize).EndInit()
        CType(grdGroup4, ComponentModel.ISupportInitialize).EndInit()
        CType(grdGroup2, ComponentModel.ISupportInitialize).EndInit()
        CType(grdGroup3, ComponentModel.ISupportInitialize).EndInit()
        pnlView.ResumeLayout(False)
        pnlView.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents tabControl As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents panFilter As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents panGrid As Panel
    Friend WithEvents grdAttendance As DataGridView
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents panTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents btnForce As Button
    Friend WithEvents panControl As Panel
    Friend WithEvents panSettings As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkTimeIn As CheckBox
    Friend WithEvents rtfMessage As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnResetSettings As Button
    Friend WithEvents tabAddUser As TabPage
    Friend WithEvents cboStudentYear As ComboBox
    Friend WithEvents panAddUser As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblTimeIn As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lblStudent As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents cboStudentDepartment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cboStudentCourse As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tabGroupings As TabPage
    Friend WithEvents grdGroup1 As DataGridView
    Friend WithEvents pnlAdd As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlView As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents grdGroup4 As DataGridView
    Friend WithEvents grdGroup3 As DataGridView
    Friend WithEvents grdGroup2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRandomize As Button
End Class
