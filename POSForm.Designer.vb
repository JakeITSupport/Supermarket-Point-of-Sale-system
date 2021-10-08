<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_transaction = New System.Windows.Forms.Label()
        Me.lbl_baggerName = New System.Windows.Forms.Label()
        Me.lbl_cashierName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_amountTender = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.tb_barcode = New System.Windows.Forms.TextBox()
        Me.btn_enterQuantity = New System.Windows.Forms.Button()
        Me.tb_quantity = New System.Windows.Forms.TextBox()
        Me.btn_enterPayment = New System.Windows.Forms.Button()
        Me.tb_payment = New System.Windows.Forms.TextBox()
        Me.btn_enterDiscount = New System.Windows.Forms.Button()
        Me.tb_discount = New System.Windows.Forms.TextBox()
        Me.btn_void = New System.Windows.Forms.Button()
        Me.tb_voidAmount = New System.Windows.Forms.TextBox()
        Me.btn_enterBaggerNo = New System.Windows.Forms.Button()
        Me.tb_baggerNumber = New System.Windows.Forms.TextBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_discountActivation = New System.Windows.Forms.Label()
        Me.lbl_voidActivation = New System.Windows.Forms.Label()
        Me.lbl_discountRate = New System.Windows.Forms.Label()
        Me.rtb_reciept = New System.Windows.Forms.RichTextBox()
        Me.lbl_time1 = New System.Windows.Forms.Label()
        Me.lbl_itemsTotal = New System.Windows.Forms.Label()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_discountName = New System.Windows.Forms.Label()
        Me.lbl_discountAmount = New System.Windows.Forms.Label()
        Me.lbl_discountTotal = New System.Windows.Forms.Label()
        Me.lbl_editPaymentActivation = New System.Windows.Forms.Label()
        Me.lbl_transactionTotal = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.lbl_transaction)
        Me.Panel1.Controls.Add(Me.lbl_baggerName)
        Me.Panel1.Controls.Add(Me.lbl_cashierName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1960, 150)
        Me.Panel1.TabIndex = 1
        '
        'lbl_transaction
        '
        Me.lbl_transaction.AutoSize = True
        Me.lbl_transaction.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transaction.ForeColor = System.Drawing.Color.White
        Me.lbl_transaction.Location = New System.Drawing.Point(1367, 94)
        Me.lbl_transaction.Name = "lbl_transaction"
        Me.lbl_transaction.Size = New System.Drawing.Size(36, 39)
        Me.lbl_transaction.TabIndex = 8
        Me.lbl_transaction.Text = "0"
        '
        'lbl_baggerName
        '
        Me.lbl_baggerName.AutoSize = True
        Me.lbl_baggerName.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_baggerName.ForeColor = System.Drawing.Color.White
        Me.lbl_baggerName.Location = New System.Drawing.Point(1367, 54)
        Me.lbl_baggerName.Name = "lbl_baggerName"
        Me.lbl_baggerName.Size = New System.Drawing.Size(36, 39)
        Me.lbl_baggerName.TabIndex = 7
        Me.lbl_baggerName.Text = "*"
        '
        'lbl_cashierName
        '
        Me.lbl_cashierName.AutoSize = True
        Me.lbl_cashierName.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cashierName.ForeColor = System.Drawing.Color.White
        Me.lbl_cashierName.Location = New System.Drawing.Point(1367, 14)
        Me.lbl_cashierName.Name = "lbl_cashierName"
        Me.lbl_cashierName.Size = New System.Drawing.Size(36, 39)
        Me.lbl_cashierName.TabIndex = 6
        Me.lbl_cashierName.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1035, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(297, 39)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Transaction No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1176, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 39)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bagger :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1163, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 39)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cashier :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(663, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 142)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "POS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 33.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(203, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 65)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Supermarket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 95)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sunshine"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.Location = New System.Drawing.Point(10, 307)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(197, 25)
        Me.lbl_description.TabIndex = 26
        Me.lbl_description.Text = "Product description"
        '
        'lbl_change
        '
        Me.lbl_change.AutoSize = True
        Me.lbl_change.Font = New System.Drawing.Font("Stencil", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.Black
        Me.lbl_change.Location = New System.Drawing.Point(2, 504)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(124, 57)
        Me.lbl_change.TabIndex = 25
        Me.lbl_change.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Stencil", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(2, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(209, 57)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Change"
        '
        'lbl_amountTender
        '
        Me.lbl_amountTender.AutoSize = True
        Me.lbl_amountTender.Font = New System.Drawing.Font("Stencil", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amountTender.ForeColor = System.Drawing.Color.Black
        Me.lbl_amountTender.Location = New System.Drawing.Point(2, 389)
        Me.lbl_amountTender.Name = "lbl_amountTender"
        Me.lbl_amountTender.Size = New System.Drawing.Size(124, 57)
        Me.lbl_amountTender.TabIndex = 23
        Me.lbl_amountTender.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Stencil", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(2, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(410, 57)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Amount Tender"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Stencil", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(3, 153)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(306, 142)
        Me.lbl_total.TabIndex = 21
        Me.lbl_total.Text = "0.00"
        '
        'tb_barcode
        '
        Me.tb_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_barcode.Location = New System.Drawing.Point(15, 1018)
        Me.tb_barcode.Name = "tb_barcode"
        Me.tb_barcode.Size = New System.Drawing.Size(166, 22)
        Me.tb_barcode.TabIndex = 27
        '
        'btn_enterQuantity
        '
        Me.btn_enterQuantity.BackColor = System.Drawing.Color.DimGray
        Me.btn_enterQuantity.Font = New System.Drawing.Font("Papyrus", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enterQuantity.ForeColor = System.Drawing.Color.White
        Me.btn_enterQuantity.Location = New System.Drawing.Point(419, 658)
        Me.btn_enterQuantity.Name = "btn_enterQuantity"
        Me.btn_enterQuantity.Size = New System.Drawing.Size(330, 60)
        Me.btn_enterQuantity.TabIndex = 34
        Me.btn_enterQuantity.Text = "Enter Quantity"
        Me.btn_enterQuantity.UseVisualStyleBackColor = False
        '
        'tb_quantity
        '
        Me.tb_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_quantity.Location = New System.Drawing.Point(12, 664)
        Me.tb_quantity.Name = "tb_quantity"
        Me.tb_quantity.Size = New System.Drawing.Size(400, 49)
        Me.tb_quantity.TabIndex = 32
        '
        'btn_enterPayment
        '
        Me.btn_enterPayment.BackColor = System.Drawing.Color.DimGray
        Me.btn_enterPayment.Font = New System.Drawing.Font("Papyrus", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enterPayment.ForeColor = System.Drawing.Color.White
        Me.btn_enterPayment.Location = New System.Drawing.Point(419, 724)
        Me.btn_enterPayment.Name = "btn_enterPayment"
        Me.btn_enterPayment.Size = New System.Drawing.Size(330, 60)
        Me.btn_enterPayment.TabIndex = 36
        Me.btn_enterPayment.Text = "Enter Payment"
        Me.btn_enterPayment.UseVisualStyleBackColor = False
        Me.btn_enterPayment.Visible = False
        '
        'tb_payment
        '
        Me.tb_payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_payment.Location = New System.Drawing.Point(12, 728)
        Me.tb_payment.Name = "tb_payment"
        Me.tb_payment.Size = New System.Drawing.Size(400, 49)
        Me.tb_payment.TabIndex = 35
        Me.tb_payment.Visible = False
        '
        'btn_enterDiscount
        '
        Me.btn_enterDiscount.BackColor = System.Drawing.Color.DimGray
        Me.btn_enterDiscount.Font = New System.Drawing.Font("Papyrus", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enterDiscount.ForeColor = System.Drawing.Color.White
        Me.btn_enterDiscount.Location = New System.Drawing.Point(419, 790)
        Me.btn_enterDiscount.Name = "btn_enterDiscount"
        Me.btn_enterDiscount.Size = New System.Drawing.Size(330, 60)
        Me.btn_enterDiscount.TabIndex = 38
        Me.btn_enterDiscount.Text = "Enter Discount"
        Me.btn_enterDiscount.UseVisualStyleBackColor = False
        Me.btn_enterDiscount.Visible = False
        '
        'tb_discount
        '
        Me.tb_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_discount.Location = New System.Drawing.Point(12, 791)
        Me.tb_discount.Name = "tb_discount"
        Me.tb_discount.Size = New System.Drawing.Size(400, 49)
        Me.tb_discount.TabIndex = 37
        Me.tb_discount.Text = "0"
        Me.tb_discount.Visible = False
        '
        'btn_void
        '
        Me.btn_void.BackColor = System.Drawing.Color.DimGray
        Me.btn_void.Font = New System.Drawing.Font("Papyrus", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_void.ForeColor = System.Drawing.Color.White
        Me.btn_void.Location = New System.Drawing.Point(419, 856)
        Me.btn_void.Name = "btn_void"
        Me.btn_void.Size = New System.Drawing.Size(330, 60)
        Me.btn_void.TabIndex = 40
        Me.btn_void.Text = "Void Items!"
        Me.btn_void.UseVisualStyleBackColor = False
        Me.btn_void.Visible = False
        '
        'tb_voidAmount
        '
        Me.tb_voidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_voidAmount.Location = New System.Drawing.Point(12, 857)
        Me.tb_voidAmount.Name = "tb_voidAmount"
        Me.tb_voidAmount.Size = New System.Drawing.Size(400, 49)
        Me.tb_voidAmount.TabIndex = 39
        Me.tb_voidAmount.Text = "0"
        Me.tb_voidAmount.Visible = False
        '
        'btn_enterBaggerNo
        '
        Me.btn_enterBaggerNo.BackColor = System.Drawing.Color.DimGray
        Me.btn_enterBaggerNo.Font = New System.Drawing.Font("Papyrus", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enterBaggerNo.ForeColor = System.Drawing.Color.White
        Me.btn_enterBaggerNo.Location = New System.Drawing.Point(419, 592)
        Me.btn_enterBaggerNo.Name = "btn_enterBaggerNo"
        Me.btn_enterBaggerNo.Size = New System.Drawing.Size(330, 60)
        Me.btn_enterBaggerNo.TabIndex = 42
        Me.btn_enterBaggerNo.Text = "Enter Bagger No."
        Me.btn_enterBaggerNo.UseVisualStyleBackColor = False
        Me.btn_enterBaggerNo.Visible = False
        '
        'tb_baggerNumber
        '
        Me.tb_baggerNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_baggerNumber.Location = New System.Drawing.Point(12, 602)
        Me.tb_baggerNumber.Name = "tb_baggerNumber"
        Me.tb_baggerNumber.Size = New System.Drawing.Size(400, 49)
        Me.tb_baggerNumber.TabIndex = 41
        Me.tb_baggerNumber.Text = "0"
        Me.tb_baggerNumber.Visible = False
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Location = New System.Drawing.Point(2, 1015)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(381, 27)
        Me.dtp_date.TabIndex = 43
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.description, Me.price, Me.quantity, Me.subTotal})
        Me.DataGridView1.Location = New System.Drawing.Point(739, 150)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1200, 900)
        Me.DataGridView1.TabIndex = 44
        '
        'description
        '
        Me.description.FillWeight = 149.7326!
        Me.description.HeaderText = "Product Description"
        Me.description.MinimumWidth = 6
        Me.description.Name = "description"
        '
        'price
        '
        Me.price.FillWeight = 83.42246!
        Me.price.HeaderText = "Price"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        '
        'quantity
        '
        Me.quantity.FillWeight = 83.42246!
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.MinimumWidth = 6
        Me.quantity.Name = "quantity"
        '
        'subTotal
        '
        Me.subTotal.FillWeight = 83.42246!
        Me.subTotal.HeaderText = "Sub Total"
        Me.subTotal.MinimumWidth = 6
        Me.subTotal.Name = "subTotal"
        '
        'lbl_discountActivation
        '
        Me.lbl_discountActivation.AutoSize = True
        Me.lbl_discountActivation.Location = New System.Drawing.Point(284, 1001)
        Me.lbl_discountActivation.Name = "lbl_discountActivation"
        Me.lbl_discountActivation.Size = New System.Drawing.Size(125, 17)
        Me.lbl_discountActivation.TabIndex = 52
        Me.lbl_discountActivation.Text = "discount activation"
        Me.lbl_discountActivation.Visible = False
        '
        'lbl_voidActivation
        '
        Me.lbl_voidActivation.AutoSize = True
        Me.lbl_voidActivation.Location = New System.Drawing.Point(180, 1001)
        Me.lbl_voidActivation.Name = "lbl_voidActivation"
        Me.lbl_voidActivation.Size = New System.Drawing.Size(98, 17)
        Me.lbl_voidActivation.TabIndex = 51
        Me.lbl_voidActivation.Text = "void activation"
        Me.lbl_voidActivation.Visible = False
        '
        'lbl_discountRate
        '
        Me.lbl_discountRate.AutoSize = True
        Me.lbl_discountRate.Location = New System.Drawing.Point(250, 978)
        Me.lbl_discountRate.Name = "lbl_discountRate"
        Me.lbl_discountRate.Size = New System.Drawing.Size(95, 17)
        Me.lbl_discountRate.TabIndex = 50
        Me.lbl_discountRate.Text = "discount Rate"
        Me.lbl_discountRate.Visible = False
        '
        'rtb_reciept
        '
        Me.rtb_reciept.Location = New System.Drawing.Point(419, 922)
        Me.rtb_reciept.Name = "rtb_reciept"
        Me.rtb_reciept.Size = New System.Drawing.Size(290, 96)
        Me.rtb_reciept.TabIndex = 49
        Me.rtb_reciept.Text = ""
        Me.rtb_reciept.Visible = False
        '
        'lbl_time1
        '
        Me.lbl_time1.AutoSize = True
        Me.lbl_time1.Location = New System.Drawing.Point(197, 978)
        Me.lbl_time1.Name = "lbl_time1"
        Me.lbl_time1.Size = New System.Drawing.Size(47, 17)
        Me.lbl_time1.TabIndex = 48
        Me.lbl_time1.Text = "Time1"
        Me.lbl_time1.Visible = False
        '
        'lbl_itemsTotal
        '
        Me.lbl_itemsTotal.AutoSize = True
        Me.lbl_itemsTotal.Location = New System.Drawing.Point(105, 978)
        Me.lbl_itemsTotal.Name = "lbl_itemsTotal"
        Me.lbl_itemsTotal.Size = New System.Drawing.Size(77, 17)
        Me.lbl_itemsTotal.TabIndex = 47
        Me.lbl_itemsTotal.Text = "Items Total"
        Me.lbl_itemsTotal.Visible = False
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.AutoSize = True
        Me.lbl_subTotal.Location = New System.Drawing.Point(197, 943)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.Size = New System.Drawing.Size(69, 17)
        Me.lbl_subTotal.TabIndex = 46
        Me.lbl_subTotal.Text = "Sub Total"
        Me.lbl_subTotal.Visible = False
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(16, 978)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(40, 17)
        Me.lbl_price.TabIndex = 45
        Me.lbl_price.Text = "Price"
        Me.lbl_price.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbl_discountName
        '
        Me.lbl_discountName.AutoSize = True
        Me.lbl_discountName.Location = New System.Drawing.Point(284, 943)
        Me.lbl_discountName.Name = "lbl_discountName"
        Me.lbl_discountName.Size = New System.Drawing.Size(102, 17)
        Me.lbl_discountName.TabIndex = 53
        Me.lbl_discountName.Text = "discount Name"
        Me.lbl_discountName.Visible = False
        '
        'lbl_discountAmount
        '
        Me.lbl_discountAmount.AutoSize = True
        Me.lbl_discountAmount.Location = New System.Drawing.Point(197, 922)
        Me.lbl_discountAmount.Name = "lbl_discountAmount"
        Me.lbl_discountAmount.Size = New System.Drawing.Size(112, 17)
        Me.lbl_discountAmount.TabIndex = 54
        Me.lbl_discountAmount.Text = "discount amount"
        Me.lbl_discountAmount.Visible = False
        '
        'lbl_discountTotal
        '
        Me.lbl_discountTotal.AutoSize = True
        Me.lbl_discountTotal.Location = New System.Drawing.Point(301, 922)
        Me.lbl_discountTotal.Name = "lbl_discountTotal"
        Me.lbl_discountTotal.Size = New System.Drawing.Size(92, 17)
        Me.lbl_discountTotal.TabIndex = 55
        Me.lbl_discountTotal.Text = "discount total"
        Me.lbl_discountTotal.Visible = False
        '
        'lbl_editPaymentActivation
        '
        Me.lbl_editPaymentActivation.AutoSize = True
        Me.lbl_editPaymentActivation.Location = New System.Drawing.Point(16, 961)
        Me.lbl_editPaymentActivation.Name = "lbl_editPaymentActivation"
        Me.lbl_editPaymentActivation.Size = New System.Drawing.Size(91, 17)
        Me.lbl_editPaymentActivation.TabIndex = 56
        Me.lbl_editPaymentActivation.Text = "Edit Payment"
        Me.lbl_editPaymentActivation.Visible = False
        '
        'lbl_transactionTotal
        '
        Me.lbl_transactionTotal.AutoSize = True
        Me.lbl_transactionTotal.Location = New System.Drawing.Point(16, 995)
        Me.lbl_transactionTotal.Name = "lbl_transactionTotal"
        Me.lbl_transactionTotal.Size = New System.Drawing.Size(119, 17)
        Me.lbl_transactionTotal.TabIndex = 57
        Me.lbl_transactionTotal.Text = "Transaction Total"
        Me.lbl_transactionTotal.Visible = False
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.Location = New System.Drawing.Point(16, 943)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(57, 17)
        Me.lbl_position.TabIndex = 58
        Me.lbl_position.Text = "position"
        Me.lbl_position.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Point_of_Sale.My.Resources.Resources.spining_sun
        Me.PictureBox1.Location = New System.Drawing.Point(43, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'POSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1942, 1050)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.lbl_transactionTotal)
        Me.Controls.Add(Me.lbl_editPaymentActivation)
        Me.Controls.Add(Me.lbl_discountTotal)
        Me.Controls.Add(Me.lbl_discountAmount)
        Me.Controls.Add(Me.lbl_discountName)
        Me.Controls.Add(Me.lbl_discountActivation)
        Me.Controls.Add(Me.lbl_voidActivation)
        Me.Controls.Add(Me.lbl_discountRate)
        Me.Controls.Add(Me.rtb_reciept)
        Me.Controls.Add(Me.lbl_time1)
        Me.Controls.Add(Me.lbl_itemsTotal)
        Me.Controls.Add(Me.lbl_subTotal)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.btn_enterBaggerNo)
        Me.Controls.Add(Me.tb_baggerNumber)
        Me.Controls.Add(Me.btn_void)
        Me.Controls.Add(Me.tb_voidAmount)
        Me.Controls.Add(Me.btn_enterDiscount)
        Me.Controls.Add(Me.tb_discount)
        Me.Controls.Add(Me.btn_enterPayment)
        Me.Controls.Add(Me.tb_payment)
        Me.Controls.Add(Me.btn_enterQuantity)
        Me.Controls.Add(Me.tb_quantity)
        Me.Controls.Add(Me.tb_barcode)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.lbl_change)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_amountTender)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "POSForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_transaction As Label
    Friend WithEvents lbl_baggerName As Label
    Friend WithEvents lbl_cashierName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_description As Label
    Friend WithEvents lbl_change As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_amountTender As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents tb_barcode As TextBox
    Friend WithEvents btn_enterQuantity As Button
    Friend WithEvents tb_quantity As TextBox
    Friend WithEvents btn_enterPayment As Button
    Friend WithEvents tb_payment As TextBox
    Friend WithEvents btn_enterDiscount As Button
    Friend WithEvents tb_discount As TextBox
    Friend WithEvents btn_void As Button
    Friend WithEvents tb_voidAmount As TextBox
    Friend WithEvents btn_enterBaggerNo As Button
    Friend WithEvents tb_baggerNumber As TextBox
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents subTotal As DataGridViewTextBoxColumn
    Friend WithEvents lbl_discountActivation As Label
    Friend WithEvents lbl_voidActivation As Label
    Friend WithEvents lbl_discountRate As Label
    Friend WithEvents rtb_reciept As RichTextBox
    Friend WithEvents lbl_time1 As Label
    Friend WithEvents lbl_itemsTotal As Label
    Friend WithEvents lbl_subTotal As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_discountName As Label
    Friend WithEvents lbl_discountAmount As Label
    Friend WithEvents lbl_discountTotal As Label
    Friend WithEvents lbl_editPaymentActivation As Label
    Friend WithEvents lbl_transactionTotal As Label
    Friend WithEvents lbl_position As Label
End Class
