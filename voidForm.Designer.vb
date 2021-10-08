<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voidForm
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
        Me.lbl_accountType = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.tb_managerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_accountType
        '
        Me.lbl_accountType.AutoSize = True
        Me.lbl_accountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accountType.Location = New System.Drawing.Point(25, 190)
        Me.lbl_accountType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_accountType.Name = "lbl_accountType"
        Me.lbl_accountType.Size = New System.Drawing.Size(20, 25)
        Me.lbl_accountType.TabIndex = 16
        Me.lbl_accountType.Text = "*"
        Me.lbl_accountType.Visible = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.DimGray
        Me.btn_login.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(405, 177)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(109, 54)
        Me.btn_login.TabIndex = 15
        Me.btn_login.Text = "Enter"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'tb_managerID
        '
        Me.tb_managerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_managerID.Location = New System.Drawing.Point(30, 134)
        Me.tb_managerID.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_managerID.Name = "tb_managerID"
        Me.tb_managerID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_managerID.Size = New System.Drawing.Size(483, 34)
        Me.tb_managerID.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Manager ID"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(-1, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(494, 64)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Void Items Authorazation"
        '
        'voidForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 253)
        Me.Controls.Add(Me.lbl_accountType)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tb_managerID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "voidForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "voidForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_accountType As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents tb_managerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
