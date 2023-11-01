<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lstWorker = New System.Windows.Forms.ListBox()
        Me.lblDetail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAge = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDOB = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDepartment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEmployment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRoles = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.wrkPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.detailsGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sds = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAmountSalary = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAmountWorking = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtLate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.wrkPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detailsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Worker List"
        '
        'lstWorker
        '
        Me.lstWorker.BackColor = System.Drawing.SystemColors.Window
        Me.lstWorker.CausesValidation = False
        Me.lstWorker.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWorker.FormattingEnabled = True
        Me.lstWorker.IntegralHeight = False
        Me.lstWorker.ItemHeight = 15
        Me.lstWorker.Location = New System.Drawing.Point(12, 58)
        Me.lstWorker.Name = "lstWorker"
        Me.lstWorker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstWorker.Size = New System.Drawing.Size(138, 355)
        Me.lstWorker.TabIndex = 1
        '
        'lblDetail
        '
        Me.lblDetail.BackColor = System.Drawing.Color.Transparent
        Me.lblDetail.Font = New System.Drawing.Font("Microsoft YaHei", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(191, 12)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(151, 28)
        Me.lblDetail.TabIndex = 4
        Me.lblDetail.Text = "Worker's Detail"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(447, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(8, 22)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = ":"
        Me.lblName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(447, 149)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(8, 22)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = ":"
        Me.lblGender.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(447, 107)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(8, 22)
        Me.lblAge.TabIndex = 7
        Me.lblAge.Text = ":"
        Me.lblAge.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'lblDOB
        '
        Me.lblDOB.BackColor = System.Drawing.Color.Transparent
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(447, 192)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(8, 22)
        Me.lblDOB.TabIndex = 11
        Me.lblDOB.Text = ":"
        Me.lblDOB.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'lblDepartment
        '
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(782, 192)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(8, 22)
        Me.lblDepartment.TabIndex = 15
        Me.lblDepartment.Text = ":"
        Me.lblDepartment.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(782, 107)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(8, 22)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = ":"
        Me.lblEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'lblEmployment
        '
        Me.lblEmployment.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployment.Location = New System.Drawing.Point(782, 149)
        Me.lblEmployment.Name = "lblEmployment"
        Me.lblEmployment.Size = New System.Drawing.Size(8, 22)
        Me.lblEmployment.TabIndex = 13
        Me.lblEmployment.Text = ":"
        Me.lblEmployment.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'lblRoles
        '
        Me.lblRoles.BackColor = System.Drawing.Color.Transparent
        Me.lblRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoles.Location = New System.Drawing.Point(782, 53)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(8, 22)
        Me.lblRoles.TabIndex = 12
        Me.lblRoles.Text = ":"
        Me.lblRoles.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(342, 192)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(99, 22)
        Me.Guna2HtmlLabel1.TabIndex = 19
        Me.Guna2HtmlLabel1.Text = "Date of Birth"
        Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(342, 107)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(32, 22)
        Me.Guna2HtmlLabel2.TabIndex = 18
        Me.Guna2HtmlLabel2.Text = "Age"
        Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(342, 149)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(58, 22)
        Me.Guna2HtmlLabel3.TabIndex = 17
        Me.Guna2HtmlLabel3.Text = "Gender"
        Me.Guna2HtmlLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(342, 58)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(47, 22)
        Me.Guna2HtmlLabel4.TabIndex = 16
        Me.Guna2HtmlLabel4.Text = "Name  "
        Me.Guna2HtmlLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(631, 192)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(91, 22)
        Me.Guna2HtmlLabel5.TabIndex = 23
        Me.Guna2HtmlLabel5.Text = "Department"
        Me.Guna2HtmlLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(631, 107)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(51, 22)
        Me.Guna2HtmlLabel6.TabIndex = 22
        Me.Guna2HtmlLabel6.Text = "E-mail"
        Me.Guna2HtmlLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(631, 149)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(51, 22)
        Me.Guna2HtmlLabel7.TabIndex = 21
        Me.Guna2HtmlLabel7.Text = "Status "
        Me.Guna2HtmlLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(631, 58)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(46, 22)
        Me.Guna2HtmlLabel8.TabIndex = 20
        Me.Guna2HtmlLabel8.Text = "Roles"
        Me.Guna2HtmlLabel8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'wrkPic
        '
        Me.wrkPic.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.wrkPic.Location = New System.Drawing.Point(191, 58)
        Me.wrkPic.Name = "wrkPic"
        Me.wrkPic.ShadowDecoration.Parent = Me.wrkPic
        Me.wrkPic.Size = New System.Drawing.Size(128, 156)
        Me.wrkPic.TabIndex = 24
        Me.wrkPic.TabStop = False
        '
        'detailsGrid
        '
        Me.detailsGrid.AllowUserToAddRows = False
        Me.detailsGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.detailsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.detailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.detailsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.detailsGrid.BackgroundColor = System.Drawing.Color.White
        Me.detailsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.detailsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.detailsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.detailsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.detailsGrid.ColumnHeadersHeight = 4
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.detailsGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.detailsGrid.EnableHeadersVisualStyles = False
        Me.detailsGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.detailsGrid.Location = New System.Drawing.Point(191, 238)
        Me.detailsGrid.Name = "detailsGrid"
        Me.detailsGrid.ReadOnly = True
        Me.detailsGrid.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.detailsGrid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.detailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.detailsGrid.Size = New System.Drawing.Size(724, 142)
        Me.detailsGrid.TabIndex = 25
        Me.detailsGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.detailsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.detailsGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.detailsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.detailsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.detailsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.detailsGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.detailsGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.detailsGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.detailsGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.detailsGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.detailsGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.detailsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.detailsGrid.ThemeStyle.HeaderStyle.Height = 4
        Me.detailsGrid.ThemeStyle.ReadOnly = True
        Me.detailsGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.detailsGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.detailsGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.detailsGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.detailsGrid.ThemeStyle.RowsStyle.Height = 22
        Me.detailsGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.detailsGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(191, 393)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 20)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'sds
        '
        Me.sds.BackColor = System.Drawing.Color.Transparent
        Me.sds.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sds.Location = New System.Drawing.Point(248, 391)
        Me.sds.Name = "sds"
        Me.sds.Size = New System.Drawing.Size(36, 22)
        Me.sds.TabIndex = 27
        Me.sds.Text = "Late"
        Me.sds.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(191, 435)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(133, 22)
        Me.Guna2HtmlLabel9.TabIndex = 28
        Me.Guna2HtmlLabel9.Text = "Salary this month "
        Me.Guna2HtmlLabel9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txtAmountSalary
        '
        Me.txtAmountSalary.BackColor = System.Drawing.Color.Transparent
        Me.txtAmountSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountSalary.Location = New System.Drawing.Point(364, 435)
        Me.txtAmountSalary.Name = "txtAmountSalary"
        Me.txtAmountSalary.Size = New System.Drawing.Size(8, 22)
        Me.txtAmountSalary.TabIndex = 29
        Me.txtAmountSalary.Text = ":"
        Me.txtAmountSalary.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(191, 473)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(139, 22)
        Me.Guna2HtmlLabel11.TabIndex = 30
        Me.Guna2HtmlLabel11.Text = "Total Working Hrs"
        Me.Guna2HtmlLabel11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txtAmountWorking
        '
        Me.txtAmountWorking.BackColor = System.Drawing.Color.Transparent
        Me.txtAmountWorking.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountWorking.Location = New System.Drawing.Point(364, 473)
        Me.txtAmountWorking.Name = "txtAmountWorking"
        Me.txtAmountWorking.Size = New System.Drawing.Size(8, 22)
        Me.txtAmountWorking.TabIndex = 31
        Me.txtAmountWorking.Text = ":"
        Me.txtAmountWorking.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.txtAmountWorking.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txtLate
        '
        Me.txtLate.BackColor = System.Drawing.Color.Transparent
        Me.txtLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLate.Location = New System.Drawing.Point(366, 391)
        Me.txtLate.Name = "txtLate"
        Me.txtLate.Size = New System.Drawing.Size(8, 22)
        Me.txtLate.TabIndex = 32
        Me.txtLate.Text = ":"
        Me.txtLate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'DetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 557)
        Me.Controls.Add(Me.txtLate)
        Me.Controls.Add(Me.txtAmountWorking)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.txtAmountSalary)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.sds)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.detailsGrid)
        Me.Controls.Add(Me.wrkPic)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblEmployment)
        Me.Controls.Add(Me.lblRoles)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.lstWorker)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DetailForm"
        Me.Text = "DetailForm"
        CType(Me.wrkPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detailsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lstWorker As ListBox
    Friend WithEvents lblDetail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAge As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDOB As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDepartment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEmployment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRoles As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents wrkPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents detailsGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sds As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAmountSalary As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAmountWorking As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtLate As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
