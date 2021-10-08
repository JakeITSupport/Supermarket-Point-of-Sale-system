Imports MySql.Data.MySqlClient

Public Class POSForm

    Public Property cashier_number As String
    Public Property cashier_name As String
    Public Property discounted_name As String
    Private Sub POSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_voidActivation.Text = "0"
        lbl_discountActivation.Text = "0"
        lbl_editPaymentActivation.Text = "0"
        lbl_cashierName.Text = cashier_name
        tb_quantity.Text = 0
        tb_barcode.Select()
        rtb_reciept.SelectionAlignment = HorizontalAlignment.Center

        rtb_reciept.Text = "" & vbNewLine & "SUNSHINE SUPERMARKET" +
                   "" & vbNewLine & "081 Gen. Luna St. San Lazaro city" +
                   "" & vbNewLine & "MIN: 151124155515355861" +
                   "" & vbNewLine & "VAT/TIN: 008-521-046-008" +
                   "" & vbNewLine & "Cashier: " + lbl_cashierName.Text + "" +
                   "" & vbNewLine & "Transaction No: " + lbl_transaction.Text + "" +
                   "" & vbNewLine & "Date/Time : " + dtp_date.Value + ""
    End Sub

    Private Sub DataGridView1_GotFoucus(sender As Object, e As EventArgs) Handles DataGridView1.GotFocus
        tb_barcode.Select()
    End Sub

    Private Sub tb_voidAmount_GotFoucus(sender As Object, e As EventArgs) Handles tb_voidAmount.GotFocus
        btn_void.Select()
        tb_voidAmount.ReadOnly = True
    End Sub

    Private Sub tb_voidAmount_lostFocus(sender As Object, e As EventArgs) Handles tb_voidAmount.LostFocus
        btn_void.Select()
        tb_voidAmount.ReadOnly = False
    End Sub
    Private Sub tb_discount_GotFoucus(sender As Object, e As EventArgs) Handles tb_discount.GotFocus
        btn_enterDiscount.Select()
        tb_discount.ReadOnly = True
    End Sub
    Private Sub tb_discount_lostFocus(sender As Object, e As EventArgs) Handles tb_discount.LostFocus
        btn_enterDiscount.Select()
        tb_discount.ReadOnly = False
    End Sub

    Private timeLeft1 As Integer = 3
    Private identifier As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft1 > 0 Then
            timeLeft1 = timeLeft1 - 1
            lbl_time1.Text = timeLeft1 & " Seconds"
            tb_barcode.[Select]()
        Else
            tb_barcode.SelectAll()
        End If
    End Sub

    Public Sub normal_counting_auoto_quantity_by_one()
        lbl_subTotal.Text = Val(lbl_price.Text) * 1
        lbl_total.Text = Val(lbl_total.Text) + Val(lbl_subTotal.Text)

        lbl_itemsTotal.Text = Val(lbl_itemsTotal.Text) + 1

        rtb_reciept.AppendText("" & vbNewLine & "." +
                            "" & vbNewLine & "" + lbl_description.Text +
                            "" & vbNewLine & "Pice: " + lbl_price.Text + "  Quantity: 1 " _
                             + "  Sub Total:" + lbl_subTotal.Text)

        DataGridView1.Rows.Add(lbl_description.Text, lbl_price.Text, 1, lbl_subTotal.Text)

        Dim counter As Integer = DataGridView1.CurrentRow.Index + 1
        Dim nextRow As DataGridViewRow
        If counter = DataGridView1.RowCount Then
            nextRow = DataGridView1.Rows(1)
        Else
            nextRow = DataGridView1.Rows(counter)
        End If

        DataGridView1.CurrentCell = nextRow.Cells(1)
        nextRow.Selected = True

        tb_quantity.Text = "0"

    End Sub

    Public Sub normal_counting_input_quantity()
        lbl_subTotal.Text = Val(lbl_price.Text) * Val(tb_quantity.Text)
        lbl_total.Text = Val(lbl_total.Text) + Val(lbl_subTotal.Text)

        lbl_itemsTotal.Text = Val(lbl_itemsTotal.Text) + Val(tb_quantity.Text)

        rtb_reciept.AppendText("" & vbNewLine & "." +
                            "" & vbNewLine & "" + lbl_description.Text +
                            "" & vbNewLine & "Pice: " + lbl_price.Text + "  Quantity: " _
                            + tb_quantity.Text + "  Sub Total:" + lbl_subTotal.Text)

        DataGridView1.Rows.Add(lbl_description.Text, lbl_price.Text, tb_quantity.Text, lbl_subTotal.Text)

        Dim counter As Integer = DataGridView1.CurrentRow.Index + 1
        Dim nextRow As DataGridViewRow
        If counter = DataGridView1.RowCount Then
            nextRow = DataGridView1.Rows(1)
        Else
            nextRow = DataGridView1.Rows(counter)
        End If

        DataGridView1.CurrentCell = nextRow.Cells(1)
        nextRow.Selected = True

        tb_quantity.Text = "0"

    End Sub

    Public Sub void_counting_auto_quantity_by_one()
        lbl_subTotal.Text = Val(lbl_price.Text) * 1
        tb_voidAmount.Text = Val(tb_voidAmount.Text) + Val(lbl_subTotal.Text)

        lbl_itemsTotal.Text = Val(lbl_itemsTotal.Text) - 1

        rtb_reciept.AppendText("" & vbNewLine & "." +
                            "" & vbNewLine & "VOID ITEM: " + lbl_description.Text +
                            "" & vbNewLine & "Pice: " + lbl_price.Text + "  Quantity: 1 " _
                             + "  Sub Total:" + lbl_subTotal.Text)

        DataGridView1.Rows.Add(("VOIDED ITEM: " + lbl_description.Text), lbl_price.Text, 1, lbl_subTotal.Text)

        Dim counter As Integer = DataGridView1.CurrentRow.Index + 1
        Dim nextRow As DataGridViewRow
        If counter = DataGridView1.RowCount Then
            nextRow = DataGridView1.Rows(1)
        Else
            nextRow = DataGridView1.Rows(counter)
        End If

        DataGridView1.CurrentCell = nextRow.Cells(1)
        nextRow.Selected = True

        tb_quantity.Text = "0"

    End Sub

    Public Sub void_counting_input_quantity()
        lbl_subTotal.Text = Val(lbl_price.Text) * Val(tb_quantity.Text)
        tb_voidAmount.Text = Val(tb_voidAmount.Text) + Val(lbl_subTotal.Text)

        lbl_itemsTotal.Text = Val(lbl_itemsTotal.Text) - Val(tb_quantity.Text)

        rtb_reciept.AppendText("" & vbNewLine & "." +
                            "" & vbNewLine & "VOIDED ITEM:" + lbl_description.Text +
                            "" & vbNewLine & "Pice: " + lbl_price.Text + "  Quantity: " _
                            + tb_quantity.Text + "  Sub Total:" + lbl_subTotal.Text)

        DataGridView1.Rows.Add(("VOIDED ITEM: " + lbl_description.Text), lbl_price.Text, tb_quantity.Text, lbl_subTotal.Text)

        Dim counter As Integer = DataGridView1.CurrentRow.Index + 1
        Dim nextRow As DataGridViewRow
        If counter = DataGridView1.RowCount Then
            nextRow = DataGridView1.Rows(1)
        Else
            nextRow = DataGridView1.Rows(counter)
        End If

        DataGridView1.CurrentCell = nextRow.Cells(1)
        nextRow.Selected = True

        tb_quantity.Text = "0"

    End Sub

    Private Sub tb_barcode_TextChanged(sender As Object, e As EventArgs) Handles tb_barcode.TextChanged
        Dim cmd As New MySqlCommand
        Dim sql As String = "SELECT * FROM tbl_products where barcode ='" & tb_barcode.Text & "'; "
        Dim reader As MySqlDataReader

        con()
        connect.Open()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = connect
        reader = cmd.ExecuteReader()

        If reader.Read() = True Then
            lbl_price.Text = reader.GetString("price")
            lbl_description.Text = reader.GetString("description")
            lbl_discountRate.Text = reader.GetString("discount_rate")

            tb_barcode.SelectAll()

            If lbl_voidActivation.Text = "0" And lbl_discountActivation.Text = "0" And Val(tb_quantity.Text = 0) Then
                normal_counting_auoto_quantity_by_one()

            ElseIf lbl_voidActivation.Text = "0" And lbl_discountActivation.Text = "0" And Val(tb_quantity.Text > 0) Then
                normal_counting_input_quantity()

            ElseIf lbl_voidActivation.Text = "1" And lbl_discountActivation.Text = "0" And Val(tb_quantity.Text = 0) Then
                void_counting_auto_quantity_by_one()

            ElseIf lbl_voidActivation.Text = "1" And Val(tb_quantity.Text) > 0 And lbl_discountActivation.Text = "0" Then

                void_counting_input_quantity()
            End If

            'THIS IS FOR DISCOUNTING AUTO QUANTITY BY 1
            If lbl_discountActivation.Text = "1" And Val(tb_quantity.Text) = 0 And lbl_voidActivation.Text = "0" Then
                normal_counting_auoto_quantity_by_one()
                lbl_discountAmount.Text = Val(lbl_subTotal.Text) * Val(lbl_discountRate.Text)
                tb_discount.Text = Val(tb_discount.Text) + Val(lbl_discountAmount.Text)

                'THIS IS FOR DISCOUNTING INPUT QUANTITY
            ElseIf lbl_discountActivation.Text = "1" And Val(tb_quantity.Text) > 0 And lbl_voidActivation.Text = "0" Then
                normal_counting_input_quantity()
                lbl_discountAmount.Text = Val(lbl_subTotal.Text) * Val(lbl_discountRate.Text)
                tb_discount.Text = Val(tb_discount.Text) + Val(lbl_discountAmount.Text)

            End If

            'THIS IS FOR DISCOUNTING and VOID AUTO QUANTITY BY 1
            If lbl_discountActivation.Text = "1" And Val(tb_quantity.Text) = 0 And lbl_voidActivation.Text = "1" Then
                void_counting_auto_quantity_by_one()
                lbl_discountAmount.Text = Val(lbl_subTotal.Text) * Val(lbl_discountRate.Text)
                tb_discount.Text = Val(tb_discount.Text) - Val(lbl_discountAmount.Text)

                'THIS IS FOR DISCOUNTING Input QUANTITY BY 1
            ElseIf lbl_discountActivation.Text = "1" And Val(tb_quantity.Text) > 0 And lbl_voidActivation.Text = "1" Then
                void_counting_input_quantity()
                lbl_discountAmount.Text = Val(lbl_subTotal.Text) * Val(lbl_discountRate.Text)
                tb_discount.Text = Val(tb_discount.Text) - Val(lbl_discountAmount.Text)

            End If


        ElseIf reader.Read() = False Then

            lbl_description.Text = "Product Not Found :("
            lbl_price.Text = "0"

        End If
        connect.Close()
    End Sub

    Private Sub btn_enterQuantity_Click(sender As Object, e As EventArgs) Handles btn_enterQuantity.Click
        If Val(tb_quantity.Text > 0) Then
            tb_barcode.Select()
            tb_barcode.SelectAll()
        End If
    End Sub

    Private Sub lbl_total_TextChanged(sender As Object, e As EventArgs) Handles lbl_total.TextChanged
        'lbl_total.Text = Math.Round(Val(lbl_subTotal.Text), 2)
    End Sub

    Private Sub lbl_subTotal_TextChanged(sender As Object, e As EventArgs) Handles lbl_subTotal.TextChanged
        lbl_subTotal.Text = Math.Round(Val(lbl_subTotal.Text), 2)
    End Sub

    Private Sub POSForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F2 Then
            tb_barcode.Select()
            tb_barcode.SelectAll()
        End If

        If e.KeyCode = Keys.F3 And Val(lbl_total.Text > 0) Then
            voidForm.Show()
        End If

        If e.KeyCode = Keys.F4 And Val(tb_voidAmount.Text <= 0) Then
            discountForm.Show()

        ElseIf e.KeyCode = Keys.F4 And Val(tb_voidAmount.Text > 0) Then
            MessageBox.Show("Please void the Items first", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If e.KeyCode = Keys.F5 Then
            If Val(tb_payment.Text) > 0 Then

                rtb_reciept.AppendText("" & vbNewLine & "" +
                                           "" & vbNewLine & "Bagger Name: " + lbl_baggerName.Text +
                                           "" & vbNewLine & "Items Total:" + lbl_itemsTotal.Text +
                                           "" & vbNewLine & "This Invoice/Receipt Shall be valid for " +
                                           "" & vbNewLine & "five(5) years from the date issued" +
                                           "" & vbNewLine & "." +
                                           "" & vbNewLine & "This serve as your Official Receipt" +
                                           "" & vbNewLine & "THANK YOU. COME AGAIN :)" +
                                           "" & vbNewLine & "POS publish by: Jake IT Support")

                DataGridView1.Rows.Clear()
                tb_barcode.ReadOnly = False
                Printer.Print(rtb_reciept.Text)

                lbl_description.Text = "*"
                lbl_price.Text = "*"
                lbl_subTotal.Text = "0"
                lbl_total.Text = "0"
                lbl_change.Text = "0"
                lbl_amountTender.Text = "0"
                lbl_itemsTotal.Text = "0"
                tb_payment.Text = "0"

                tb_quantity.Text = "0"
                tb_barcode.Clear()
                tb_barcode.Select()

                tb_payment.Visible = False
                btn_enterPayment.Visible = False

                lbl_transaction.Text = Val(lbl_transaction.Text) + 1
                rtb_reciept.Text = "" & vbNewLine & "SUNSHINE SUPERMARKET" +
                   "" & vbNewLine & "081 Gen. Luna St. San Lazaro city" +
                   "" & vbNewLine & "MIN: 151124155515355861" +
                   "" & vbNewLine & "VAT/TIN: 008-521-046-008" +
                   "" & vbNewLine & "Cashier Name: " + lbl_cashierName.Text + "" +
                   "" & vbNewLine & "Transaction No: " + lbl_transaction.Text + "" +
                   "" & vbNewLine & " Date/Time : " + dtp_date.Value + ""
            End If
        End If

        If e.KeyCode = Keys.F6 Then
            If Val(tb_payment.Text) > 0 And Val(lbl_change.Text) > 0 Then
                lbl_editPaymentActivation.Text = "1"
                tb_payment.Select()
                tb_payment.SelectAll()

            End If
        End If

        If e.KeyCode = Keys.F7 Then
            PriceLookUpForm.Show()
        End If

        If e.KeyCode = Keys.F8 And Val(lbl_total.Text > 0) Then
            tb_payment.Visible = True
            btn_enterPayment.Visible = True
            tb_payment.Select()
        End If

        If e.KeyCode = Keys.F9 Then
            tb_baggerNumber.Visible = True
            btn_enterBaggerNo.Visible = True
            tb_baggerNumber.Select()
            tb_baggerNumber.SelectAll()
        End If

        If e.KeyCode = Keys.F1 Then
            If Val(lbl_transactionTotal.Text) > 0 And lbl_total.Text = "0" Then

                CashOutForm.lbl_transactionsTotal.Text = lbl_transaction.Text
                CashOutForm.lbl_transactionsAmountTotal.Text = lbl_transactionTotal.Text
                CashOutForm.lbl_discountsAmountTotal.Text = lbl_discountTotal.Text
                CashOutForm.tb_managerID.Select()

                Me.Hide()
                CashOutForm.Show()
            End If
        End If
    End Sub

    Private Sub btn_void_Click(sender As Object, e As EventArgs) Handles btn_void.Click
        If Val(tb_voidAmount.Text) > 0 And Val(tb_voidAmount.Text) <= Val(lbl_total.Text) Then
            lbl_total.Text = Val(lbl_total.Text) - Val(tb_voidAmount.Text)
            tb_voidAmount.Text = "0"
            lbl_voidActivation.Text = "0"
            lbl_description.Text = "*"
            lbl_price.Text = "*"
            lbl_subTotal.Text = "*"
            tb_voidAmount.Visible = False
            btn_void.Visible = False
            tb_quantity.Text = "0"
            tb_barcode.Select()
            tb_barcode.SelectAll()
            tb_payment.Visible = True
            btn_enterPayment.Visible = True

        ElseIf Val(tb_voidAmount.Text) > Val(lbl_total.Text) Then
            MessageBox.Show(
                "VOID AMOUNT " + tb_voidAmount.Text + " IS GREATER THAN THE AMOUNT OF TOTAL " + lbl_total.Text _
                + " !!, RE-SCAN AGAIN!!", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            tb_voidAmount.Clear()
            tb_barcode.Select()

        End If
    End Sub

    Private Sub lbl_discountActivation_TextChanged(sender As Object, e As EventArgs) Handles lbl_discountActivation.TextChanged
        If lbl_discountActivation.Text = "1" Then
            MessageBox.Show("Discounting is now Activated!", "Information Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            lbl_discountName.Text = discounted_name
        End If
    End Sub

    Private Sub btn_enterDiscount_Click(sender As Object, e As EventArgs) Handles btn_enterDiscount.Click
        If Val(tb_discount.Text) > 0.00 Then

            rtb_reciept.AppendText("" & vbNewLine & "" +
                                       "" & vbNewLine & "Original Total: " + lbl_total.Text)

            lbl_total.Text = Val(lbl_total.Text) - Val(tb_discount.Text)

            rtb_reciept.AppendText("" & vbNewLine & "Discounted Name: " + lbl_discountName.Text +
                                       "" & vbNewLine & "Discount Total: " + tb_discount.Text)

            lbl_discountTotal.Text = Val(lbl_discountTotal.Text) + Val(tb_discount.Text)

            tb_discount.Text = "0"
            tb_discount.Visible = False
            btn_enterDiscount.Visible = False
            lbl_discountRate.Text = "0"
            lbl_discountActivation.Text = "0"
            tb_barcode.Select()
            tb_barcode.SelectAll()
        End If
    End Sub

    Private Sub btn_enterPayment_Click(sender As Object, e As EventArgs) Handles btn_enterPayment.Click
        If lbl_editPaymentActivation.Text = "0" Then
            If Val(tb_payment.Text) >= Val(lbl_total.Text) And Val(tb_discount.Text) = 0 And Val(tb_voidAmount.Text) = 0 Then
                lbl_change.Text = (Val(tb_payment.Text)) - (Val(lbl_total.Text))
                lbl_change.Text = Math.Round(Val(lbl_change.Text), 2)
                lbl_amountTender.Text = Val(tb_payment.Text)
                tb_barcode.ReadOnly = True
                lbl_transactionTotal.Text = Val(lbl_transactionTotal.Text) + Val(lbl_total.Text)
                rtb_reciept.AppendText("" & vbNewLine & "" +
                                       "" & vbNewLine & "" +
                                       "" & vbNewLine & "Total Amount: " + lbl_total.Text +
                                       "" & vbNewLine & "Amount Tender: " + lbl_amountTender.Text +
                                       "" & vbNewLine & "CHANGE: " + lbl_change.Text)



            ElseIf Val(tb_payment.Text) < Val(lbl_total.Text) Then
                MessageBox.Show("Insufficient Amount of PAYMENT!!!!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_payment.Select()

            ElseIf Val(tb_voidAmount.Text > 0) Then
                MessageBox.Show("Please void the Items first", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Val(tb_discount.Text > 0) Then
                MessageBox.Show("Please Enter the discount first", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If

        If lbl_editPaymentActivation.Text = "1" Then
            If Val(tb_payment.Text) >= Val(lbl_total.Text) And Val(tb_discount.Text) = 0 And Val(tb_voidAmount.Text) = 0 Then
                lbl_change.Text = (Val(tb_payment.Text)) - (Val(lbl_total.Text))
                lbl_change.Text = Math.Round(Val(lbl_change.Text), 2)
                lbl_amountTender.Text = Val(tb_payment.Text)
                tb_barcode.ReadOnly = True
                lbl_transactionTotal.Text = Val(lbl_transactionTotal.Text) + Val(lbl_total.Text)
                rtb_reciept.AppendText("" & vbNewLine & "" +
                                       "" & vbNewLine & "" +
                                       "" & vbNewLine & "Total Amount: " + lbl_total.Text +
                                       "" & vbNewLine & "EDITED Amount Tender: " + lbl_amountTender.Text +
                                       "" & vbNewLine & "CHANGE: " + lbl_change.Text)

                lbl_editPaymentActivation.Text = "0"

            ElseIf Val(tb_payment.Text) < Val(lbl_total.Text) Then
                MessageBox.Show("Insufficient Amount of PAYMENT!!!!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_payment.Select()

            End If
        End If
    End Sub

    Private Sub tb_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_quantity.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_payment.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_payment_Validated(sender As Object, e As EventArgs) Handles tb_payment.Validated
        If tb_payment.Text = Format(Val(tb_payment.Text), "0.00") Or tb_payment.Text = Format(Val(tb_payment.Text), "0") Then
            btn_enterPayment.Visible = True
            btn_enterPayment.Select()
        ElseIf tb_payment.Text IsNot Format(Val(tb_payment.Text), "0.00") Or tb_payment.Text IsNot Format(Val(tb_payment.Text), "0") Then
            MessageBox.Show("Invalid Payment Decimal Format!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_enterPayment.Visible = False
            tb_payment.Select()
            tb_payment.SelectAll()
        End If
    End Sub

    Private Sub btn_enterBaggerNo_GotFoucus(sender As Object, e As EventArgs) Handles btn_enterBaggerNo.GotFocus
        btn_enterBaggerNo.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btn_enterBaggerNo_LostFocus(sender As Object, e As EventArgs) Handles btn_enterBaggerNo.LostFocus
        btn_enterBaggerNo.BackColor = Color.DimGray
    End Sub

    Private Sub btn_enterQuantity_GotFoucus(sender As Object, e As EventArgs) Handles btn_enterQuantity.GotFocus
        btn_enterQuantity.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btn_enterQuantity_LostFocus(sender As Object, e As EventArgs) Handles btn_enterQuantity.LostFocus
        btn_enterQuantity.BackColor = Color.DimGray
    End Sub

    Private Sub btn_enterPayment_GotFoucus(sender As Object, e As EventArgs) Handles btn_enterPayment.GotFocus
        btn_enterPayment.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btn_enterPayment_LostFocus(sender As Object, e As EventArgs) Handles btn_enterPayment.LostFocus
        btn_enterPayment.BackColor = Color.DimGray
    End Sub

    Private Sub btn_void_GotFoucus(sender As Object, e As EventArgs) Handles btn_void.GotFocus
        btn_void.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btn_void_LostFocus(sender As Object, e As EventArgs) Handles btn_void.LostFocus
        btn_void.BackColor = Color.DimGray
    End Sub

    Private Sub btn_enterDiscount_GotFoucus(sender As Object, e As EventArgs) Handles btn_enterDiscount.GotFocus
        btn_enterDiscount.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btn_enterDiscount_LostFocus(sender As Object, e As EventArgs) Handles btn_enterDiscount.LostFocus
        btn_enterDiscount.BackColor = Color.DimGray
    End Sub

    Private Sub btn_enterBaggerNo_Click(sender As Object, e As EventArgs) Handles btn_enterBaggerNo.Click
        Dim cmd As New MySqlCommand
        Dim sql As String = "SELECT * FROM tbl_accounts where id ='" & tb_baggerNumber.Text & "'; "
        Dim reader As MySqlDataReader

        con()
        connect.Open()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = connect
        reader = cmd.ExecuteReader()

        If reader.Read() = True And lbl_position.Text = "Bagger" Then
            lbl_baggerName.Text = reader.GetString("name")
            tb_baggerNumber.Text = "0"
            tb_baggerNumber.Visible = False
            btn_enterBaggerNo.Visible = False

        ElseIf reader.Read() = False Or lbl_position.Text IsNot "Bagger" Then
            tb_baggerNumber.Text = "0"
            lbl_baggerName.Text = "*"
            tb_baggerNumber.Visible = False
            btn_enterBaggerNo.Visible = False
        End If

        tb_barcode.Select()
        connect.Close()
    End Sub

    Private Sub tb_baggerNumber_Validated(sender As Object, e As EventArgs) Handles tb_baggerNumber.Validated
        Dim cmd As New MySqlCommand
        Dim sql As String = "SELECT * FROM tbl_accounts where id ='" & tb_baggerNumber.Text & "'; "
        Dim reader As MySqlDataReader

        con()
        connect.Open()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = connect
        reader = cmd.ExecuteReader()

        While reader.Read()
            lbl_position.Text = reader.GetString("position")
        End While
    End Sub

    Private Sub tb_baggerNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_baggerNumber.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
