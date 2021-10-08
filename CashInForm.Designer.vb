<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashInForm
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
        Me.btn_enterCashInAmount = New System.Windows.Forms.Button()
        Me.tb_cashInAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_manager = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_cashier = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.Location = New System.Drawing.Point(343, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 800)
        Me.Panel1.TabIndex = 0
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
        Me.lbl_accountType.Location = New System.Drawing.Point(84, 101)
        Me.lbl_accountType.Name = "lbl_accountType"
        Me.lbl_accountType.Size = New System.Drawing.Size(32, 37)
        Me.lbl_accountType.TabIndex = 4
        Me.lbl_accountType.Text = "*"
        Me.lbl_accountType.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 13)
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
        Me.btn_enterManagerID.Location = New System.Drawing.Point(598, 50)
        Me.btn_enterManagerID.Name = "btn_enterManagerID"
        Me.btn_enterManagerID.Size = New System.Drawing.Size(100, 50)
        Me.btn_enterManagerID.TabIndex = 3
        Me.btn_enterManagerID.Text = "Enter"
        Me.btn_enterManagerID.UseVisualStyleBackColor = False
        '
        'tb_managerID
        '
        Me.tb_managerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_managerID.Location = New System.Drawing.Point(88, 53)
        Me.tb_managerID.Name = "tb_managerID"
        Me.tb_managerID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_managerID.Size = New System.Drawing.Size(500, 45)
        Me.tb_managerID.TabIndex = 2
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.dtp_date)
        Me.pnl2.Controls.Add(Me.btn_enterCashInAmount)
        Me.pnl2.Controls.Add(Me.tb_cashInAmount)
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
        'btn_enterCashInAmount
        '
        Me.btn_enterCashInAmount.BackColor = System.Drawing.Color.DimGray
        Me.btn_enterCashInAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enterCashInAmount.ForeColor = System.Drawing.Color.White
        Me.btn_enterCashInAmount.Location = New System.Drawing.Point(598, 214)
        Me.btn_enterCashInAmount.Name = "btn_enterCashInAmount"
        Me.btn_enterCashInAmount.Size = New System.Drawing.Size(100, 50)
        Me.btn_enterCashInAmount.TabIndex = 6
        Me.btn_enterCashInAmount.Text = "Enter"
        Me.btn_enterCashInAmount.UseVisualStyleBackColor = False
        '
        'tb_cashInAmount
        '
        Me.tb_cashInAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cashInAmount.Location = New System.Drawing.Point(87, 219)
        Me.tb_cashInAmount.Name = "tb_cashInAmount"
        Me.tb_cashInAmount.Size = New System.Drawing.Size(500, 45)
        Me.tb_cashInAmount.TabIndex = 5
        Me.tb_cashInAmount.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(80, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 37)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cash In Amount"
        '
        'lbl_manager
        '
        Me.lbl_manager.AutoSize = True
        Me.lbl_manager.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manager.Location = New System.Drawing.Point(157, 83)
        Me.lbl_manager.Name = "lbl_manager"
        Me.lbl_manager.Size = New System.Drawing.Size(32, 37)
        Me.lbl_manager.TabIndex = 3
        Me.lbl_manager.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 37)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Manager:"
        '
        'lbl_cashier
        '
        Me.lbl_cashier.AutoSize = True
        Me.lbl_cashier.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cashier.Location = New System.Drawing.Point(157, 37)
        Me.lbl_cashier.Name = "lbl_cashier"
        Me.lbl_cashier.Size = New System.Drawing.Size(32, 37)
        Me.lbl_cashier.TabIndex = 1
        Me.lbl_cashier.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cashier:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash In Authorization"
        '
        'CashInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Point_of_Sale.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1500, 1000)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "CashInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashInForm"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_enterManagerID As Button
    Friend WithEvents tb_managerID As TextBox
    Friend WithEvents pnl2 As Panel
    Friend WithEvents btn_enterCashInAmount As Button
    Friend WithEvents tb_cashInAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_manager As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_cashier As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_accountType As Label
    Friend WithEvents dtp_date As DateTimePicker
End Class
