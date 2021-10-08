<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class discountForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_accountType = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.tb_managerID = New System.Windows.Forms.TextBox()
        Me.lbl_MID = New System.Windows.Forms.Label()
        Me.pnl_discount = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_originalTotal = New System.Windows.Forms.Label()
        Me.lbl_discountTotal = New System.Windows.Forms.Label()
        Me.lbl_discountRate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_type = New System.Windows.Forms.ComboBox()
        Me.btn_sendOut = New System.Windows.Forms.Button()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_fullName = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.pnl_discount.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 94)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount Form"
        '
        'lbl_accountType
        '
        Me.lbl_accountType.AutoSize = True
        Me.lbl_accountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accountType.Location = New System.Drawing.Point(18, 168)
        Me.lbl_accountType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_accountType.Name = "lbl_accountType"
        Me.lbl_accountType.Size = New System.Drawing.Size(20, 25)
        Me.lbl_accountType.TabIndex = 14
        Me.lbl_accountType.Text = "*"
        Me.lbl_accountType.Visible = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.DimGray
        Me.btn_login.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(602, 168)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(113, 54)
        Me.btn_login.TabIndex = 13
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'tb_managerID
        '
        Me.tb_managerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_managerID.Location = New System.Drawing.Point(227, 125)
        Me.tb_managerID.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_managerID.Name = "tb_managerID"
        Me.tb_managerID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_managerID.Size = New System.Drawing.Size(487, 34)
        Me.tb_managerID.TabIndex = 12
        '
        'lbl_MID
        '
        Me.lbl_MID.AutoSize = True
        Me.lbl_MID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MID.Location = New System.Drawing.Point(20, 127)
        Me.lbl_MID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_MID.Name = "lbl_MID"
        Me.lbl_MID.Size = New System.Drawing.Size(201, 29)
        Me.lbl_MID.TabIndex = 11
        Me.lbl_MID.Text = "Input Manager ID:"
        '
        'pnl_discount
        '
        Me.pnl_discount.Controls.Add(Me.Label7)
        Me.pnl_discount.Controls.Add(Me.lbl_originalTotal)
        Me.pnl_discount.Controls.Add(Me.lbl_discountTotal)
        Me.pnl_discount.Controls.Add(Me.lbl_discountRate)
        Me.pnl_discount.Controls.Add(Me.Label5)
        Me.pnl_discount.Controls.Add(Me.Label4)
        Me.pnl_discount.Controls.Add(Me.Label2)
        Me.pnl_discount.Controls.Add(Me.cb_type)
        Me.pnl_discount.Controls.Add(Me.btn_sendOut)
        Me.pnl_discount.Controls.Add(Me.tb_id)
        Me.pnl_discount.Controls.Add(Me.Label3)
        Me.pnl_discount.Controls.Add(Me.tb_fullName)
        Me.pnl_discount.Controls.Add(Me.lbl_name)
        Me.pnl_discount.Location = New System.Drawing.Point(7, 257)
        Me.pnl_discount.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl_discount.Name = "pnl_discount"
        Me.pnl_discount.Size = New System.Drawing.Size(721, 326)
        Me.pnl_discount.TabIndex = 15
        Me.pnl_discount.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 161)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 29)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Original Total:"
        '
        'lbl_originalTotal
        '
        Me.lbl_originalTotal.AutoSize = True
        Me.lbl_originalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_originalTotal.Location = New System.Drawing.Point(277, 161)
        Me.lbl_originalTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_originalTotal.Name = "lbl_originalTotal"
        Me.lbl_originalTotal.Size = New System.Drawing.Size(58, 29)
        Me.lbl_originalTotal.TabIndex = 25
        Me.lbl_originalTotal.Text = "0.00"
        '
        'lbl_discountTotal
        '
        Me.lbl_discountTotal.AutoSize = True
        Me.lbl_discountTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discountTotal.Location = New System.Drawing.Point(281, 242)
        Me.lbl_discountTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_discountTotal.Name = "lbl_discountTotal"
        Me.lbl_discountTotal.Size = New System.Drawing.Size(58, 29)
        Me.lbl_discountTotal.TabIndex = 25
        Me.lbl_discountTotal.Text = "0.00"
        '
        'lbl_discountRate
        '
        Me.lbl_discountRate.AutoSize = True
        Me.lbl_discountRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discountRate.Location = New System.Drawing.Point(277, 201)
        Me.lbl_discountRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_discountRate.Name = "lbl_discountRate"
        Me.lbl_discountRate.Size = New System.Drawing.Size(58, 29)
        Me.lbl_discountRate.TabIndex = 24
        Me.lbl_discountRate.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 242)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 29)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Discount Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 201)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 29)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Discount Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Select Type:"
        '
        'cb_type
        '
        Me.cb_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_type.FormattingEnabled = True
        Me.cb_type.Items.AddRange(New Object() {"Senior Citizen", "Person with Disabilities", "others"})
        Me.cb_type.Location = New System.Drawing.Point(216, 103)
        Me.cb_type.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_type.Name = "cb_type"
        Me.cb_type.Size = New System.Drawing.Size(487, 33)
        Me.cb_type.TabIndex = 14
        '
        'btn_sendOut
        '
        Me.btn_sendOut.BackColor = System.Drawing.Color.DimGray
        Me.btn_sendOut.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sendOut.ForeColor = System.Drawing.Color.White
        Me.btn_sendOut.Location = New System.Drawing.Point(532, 258)
        Me.btn_sendOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sendOut.Name = "btn_sendOut"
        Me.btn_sendOut.Size = New System.Drawing.Size(172, 54)
        Me.btn_sendOut.TabIndex = 18
        Me.btn_sendOut.Text = "Send Out"
        Me.btn_sendOut.UseVisualStyleBackColor = False
        Me.btn_sendOut.Visible = False
        '
        'tb_id
        '
        Me.tb_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Location = New System.Drawing.Point(216, 14)
        Me.tb_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(487, 34)
        Me.tb_id.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Input ID:"
        '
        'tb_fullName
        '
        Me.tb_fullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fullName.Location = New System.Drawing.Point(216, 57)
        Me.tb_fullName.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_fullName.Name = "tb_fullName"
        Me.tb_fullName.Size = New System.Drawing.Size(487, 34)
        Me.tb_fullName.TabIndex = 10
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(17, 59)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(188, 29)
        Me.lbl_name.TabIndex = 9
        Me.lbl_name.Text = "Input Full Name:"
        '
        'discountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 653)
        Me.Controls.Add(Me.pnl_discount)
        Me.Controls.Add(Me.lbl_accountType)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tb_managerID)
        Me.Controls.Add(Me.lbl_MID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "discountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount Form"
        Me.pnl_discount.ResumeLayout(False)
        Me.pnl_discount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_accountType As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents tb_managerID As TextBox
    Friend WithEvents lbl_MID As Label
    Friend WithEvents pnl_discount As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_originalTotal As Label
    Friend WithEvents lbl_discountTotal As Label
    Friend WithEvents lbl_discountRate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_type As ComboBox
    Friend WithEvents btn_sendOut As Button
    Friend WithEvents tb_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_fullName As TextBox
    Friend WithEvents lbl_name As Label
End Class
