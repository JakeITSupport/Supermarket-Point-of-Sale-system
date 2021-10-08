<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashOutForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl_accountType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_enterManagerID = New System.Windows.Forms.Button()
        Me.tb_managerID = New System.Windows.Forms.TextBox()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.btn_enterCashOutAmount = New System.Windows.Forms.Button()
        Me.tb_cashOutAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_manager = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_cashier = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_cashInAmount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_transactionsTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_discountsAmountTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_transactionsAmountTotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_cashInManager = New System.Windows.Forms.Label()
        Me.rtb_tor = New System.Windows.Forms.RichTextBox()
        Me.lbl_cashInTime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pnl1)
        Me.Panel1.Controls.Add(Me.pnl2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(350, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 800)
        Me.Panel1.TabIndex = 1
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.lbl_accountType)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.btn_enterManagerID)
        Me.pnl1.Controls.Add(Me.tb_managerID)
        Me.pnl1.Location = New System.Drawing.Point(0, 99)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(800, 150)
        Me.pnl1.TabIndex = 7
        '
        'lbl_accountType
        '
        Me.lbl_accountType.AutoSize = True
        Me.lbl_accountType.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accountType.Location = New System.Drawing.Point(84, 103)
        Me.lbl_accountType.Name = "lbl_accountType"
        Me.lbl_accountType.Size = New System.Drawing.Size(32, 37)
        Me.lbl_accountType.TabIndex = 4
        Me.lbl_accountType.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manager ID"
        '
        'btn_enterManagerID
        '
        Me.btn_enterManagerID.BackColor = System.Drawing.Color.DimGray
        Me.btn_enterManagerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enterManagerID.ForeColor = System.Drawing.Color.White
        Me.btn_enterManagerID.Location = New System.Drawing.Point(598, 52)
        Me.btn_enterManagerID.Name = "btn_enterManagerID"
        Me.btn_enterManagerID.Size = New System.Drawing.Size(100, 50)
        Me.btn_enterManagerID.TabIndex = 3
        Me.btn_enterManagerID.Text = "Enter"
        Me.btn_enterManagerID.UseVisualStyleBackColor = False
        '
        'tb_managerID
        '
        Me.tb_managerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_managerID.Location = New System.Drawing.Point(88, 55)
        Me.tb_managerID.Name = "tb_managerID"
        Me.tb_managerID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_managerID.Size = New System.Drawing.Size(500, 45)
        Me.tb_managerID.TabIndex = 2
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.lbl_cashInTime)
        Me.pnl2.Controls.Add(Me.rtb_tor)
        Me.pnl2.Controls.Add(Me.lbl_cashInManager)
        Me.pnl2.Controls.Add(Me.lbl_transactionsAmountTotal)
        Me.pnl2.Controls.Add(Me.Label13)
        Me.pnl2.Controls.Add(Me.lbl_discountsAmountTotal)
        Me.pnl2.Controls.Add(Me.Label11)
        Me.pnl2.Controls.Add(Me.lbl_transactionsTotal)
        Me.pnl2.Controls.Add(Me.Label9)
        Me.pnl2.Controls.Add(Me.lbl_cashInAmount)
        Me.pnl2.Controls.Add(Me.Label5)
        Me.pnl2.Controls.Add(Me.dtp_date)
        Me.pnl2.Controls.Add(Me.btn_enterCashOutAmount)
        Me.pnl2.Controls.Add(Me.tb_cashOutAmount)
        Me.pnl2.Controls.Add(Me.Label8)
        Me.pnl2.Controls.Add(Me.lbl_manager)
        Me.pnl2.Controls.Add(Me.Label6)
        Me.pnl2.Controls.Add(Me.lbl_cashier)
        Me.pnl2.Controls.Add(Me.Label3)
        Me.pnl2.Location = New System.Drawing.Point(1, 271)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(800, 500)
        Me.pnl2.TabIndex = 4
        Me.pnl2.Visible = False
        '
        'dtp_date
        '
        Me.dtp_date.Location = New System.Drawing.Point(3, 475)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(289, 22)
        Me.dtp_date.TabIndex = 7
        '
        'btn_enterCashOutAmount
        '
        Me.btn_enterCashOutAmount.BackColor = System.Drawing.Color.DimGray
        Me.btn_enterCashOutAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enterCashOutAmount.ForeColor = System.Drawing.Color.White
        Me.btn_enterCashOutAmount.Location = New System.Drawing.Point(598, 383)
        Me.btn_enterCashOutAmount.Name = "btn_enterCashOutAmount"
        Me.btn_enterCashOutAmount.Size = New System.Drawing.Size(100, 50)
        Me.btn_enterCashOutAmount.TabIndex = 6
        Me.btn_enterCashOutAmount.Text = "Enter"
        Me.btn_enterCashOutAmount.UseVisualStyleBackColor = False
        '
        'tb_cashOutAmount
        '
        Me.tb_cashOutAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cashOutAmount.Location = New System.Drawing.Point(87, 388)
        Me.tb_cashOutAmount.Name = "tb_cashOutAmount"
        Me.tb_cashOutAmount.Size = New System.Drawing.Size(500, 45)
        Me.tb_cashOutAmount.TabIndex = 5
        Me.tb_cashOutAmount.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(80, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 37)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cash Out Amount"
        '
        'lbl_manager
        '
        Me.lbl_manager.AutoSize = True
        Me.lbl_manager.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manager.Location = New System.Drawing.Point(157, 56)
        Me.lbl_manager.Name = "lbl_manager"
        Me.lbl_manager.Size = New System.Drawing.Size(32, 37)
        Me.lbl_manager.TabIndex = 3
        Me.lbl_manager.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 37)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Manager:"
        '
        'lbl_cashier
        '
        Me.lbl_cashier.AutoSize = True
        Me.lbl_cashier.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cashier.Location = New System.Drawing.Point(157, 10)
        Me.lbl_cashier.Name = "lbl_cashier"
        Me.lbl_cashier.Size = New System.Drawing.Size(32, 37)
        Me.lbl_cashier.TabIndex = 1
        Me.lbl_cashier.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cashier:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 31.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(715, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash Out Authorization"
        '
        'lbl_cashInAmount
        '
        Me.lbl_cashInAmount.AutoSize = True
        Me.lbl_cashInAmount.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cashInAmount.Location = New System.Drawing.Point(256, 122)
        Me.lbl_cashInAmount.Name = "lbl_cashInAmount"
        Me.lbl_cashInAmount.Size = New System.Drawing.Size(32, 37)
        Me.lbl_cashInAmount.TabIndex = 9
        Me.lbl_cashInAmount.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 37)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cash In Amount:"
        '
        'lbl_transactionsTotal
        '
        Me.lbl_transactionsTotal.AutoSize = True
        Me.lbl_transactionsTotal.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transactionsTotal.Location = New System.Drawing.Point(256, 159)
        Me.lbl_transactionsTotal.Name = "lbl_transactionsTotal"
        Me.lbl_transactionsTotal.Size = New System.Drawing.Size(32, 37)
        Me.lbl_transactionsTotal.TabIndex = 11
        Me.lbl_transactionsTotal.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 37)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Transactions Total:"
        '
        'lbl_discountsAmountTotal
        '
        Me.lbl_discountsAmountTotal.AutoSize = True
        Me.lbl_discountsAmountTotal.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discountsAmountTotal.Location = New System.Drawing.Point(372, 216)
        Me.lbl_discountsAmountTotal.Name = "lbl_discountsAmountTotal"
        Me.lbl_discountsAmountTotal.Size = New System.Drawing.Size(32, 37)
        Me.lbl_discountsAmountTotal.TabIndex = 13
        Me.lbl_discountsAmountTotal.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(317, 37)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Discounts Amount Total:"
        '
        'lbl_transactionsAmountTotal
        '
        Me.lbl_transactionsAmountTotal.AutoSize = True
        Me.lbl_transactionsAmountTotal.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transactionsAmountTotal.Location = New System.Drawing.Point(372, 253)
        Me.lbl_transactionsAmountTotal.Name = "lbl_transactionsAmountTotal"
        Me.lbl_transactionsAmountTotal.Size = New System.Drawing.Size(32, 37)
        Me.lbl_transactionsAmountTotal.TabIndex = 15
        Me.lbl_transactionsAmountTotal.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(349, 37)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Transactions Amount Total:"
        '
        'lbl_cashInManager
        '
        Me.lbl_cashInManager.AutoSize = True
        Me.lbl_cashInManager.Location = New System.Drawing.Point(43, 97)
        Me.lbl_cashInManager.Name = "lbl_cashInManager"
        Me.lbl_cashInManager.Size = New System.Drawing.Size(115, 17)
        Me.lbl_cashInManager.TabIndex = 16
        Me.lbl_cashInManager.Text = "Cash In Manager"
        Me.lbl_cashInManager.Visible = False
        '
        'rtb_tor
        '
        Me.rtb_tor.Location = New System.Drawing.Point(486, 62)
        Me.rtb_tor.Name = "rtb_tor"
        Me.rtb_tor.Size = New System.Drawing.Size(212, 191)
        Me.rtb_tor.TabIndex = 17
        Me.rtb_tor.Text = ""
        Me.rtb_tor.Visible = False
        '
        'lbl_cashInTime
        '
        Me.lbl_cashInTime.AutoSize = True
        Me.lbl_cashInTime.Location = New System.Drawing.Point(483, 269)
        Me.lbl_cashInTime.Name = "lbl_cashInTime"
        Me.lbl_cashInTime.Size = New System.Drawing.Size(90, 17)
        Me.lbl_cashInTime.TabIndex = 18
        Me.lbl_cashInTime.Text = "Cash In Time"
        Me.lbl_cashInTime.Visible = False
        '
        'CashOutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Point_of_Sale.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1500, 1000)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "CashOutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashOutForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl1 As Panel
    Friend WithEvents lbl_accountType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_enterManagerID As Button
    Friend WithEvents tb_managerID As TextBox
    Friend WithEvents pnl2 As Panel
    Friend WithEvents lbl_transactionsAmountTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_discountsAmountTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_transactionsTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_cashInAmount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents btn_enterCashOutAmount As Button
    Friend WithEvents tb_cashOutAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_manager As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_cashier As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_cashInManager As Label
    Friend WithEvents rtb_tor As RichTextBox
    Friend WithEvents lbl_cashInTime As Label
End Class
