<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.labelTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnWorker = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle.Font = New System.Drawing.Font("Tahoma", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(24, 37)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(158, 30)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Payroll Board"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.btnWorker)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.labelTitle)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.FillColor = System.Drawing.Color.White
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowColor = System.Drawing.Color.Black
        Me.pnlMenu.Size = New System.Drawing.Size(215, 653)
        Me.pnlMenu.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.SquareFull
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 34
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(12, 578)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 55)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnWorker
        '
        Me.btnWorker.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorker.IconChar = FontAwesome.Sharp.IconChar.Person
        Me.btnWorker.IconColor = System.Drawing.Color.Black
        Me.btnWorker.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnWorker.IconSize = 34
        Me.btnWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWorker.Location = New System.Drawing.Point(12, 221)
        Me.btnWorker.Name = "btnWorker"
        Me.btnWorker.Size = New System.Drawing.Size(190, 55)
        Me.btnWorker.TabIndex = 2
        Me.btnWorker.Text = "Worker List"
        Me.btnWorker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWorker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWorker.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnHome.IconColor = System.Drawing.Color.Black
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.IconSize = 34
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(12, 145)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(190, 55)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.FillColor = System.Drawing.Color.White
        Me.pnlMain.Location = New System.Drawing.Point(221, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.ShadowColor = System.Drawing.Color.Black
        Me.pnlMain.Size = New System.Drawing.Size(1047, 655)
        Me.pnlMain.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 653)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlMenu As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnWorker As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2ShadowPanel
End Class
