Imports MySql.Data.MySqlClient

Public Class CashOutForm
    Private Sub tb_managerID_Validated(sender As Object, e As EventArgs) Handles tb_managerID.Validated
        Dim cmd As New MySqlCommand
        Dim sql As String = "SELECT * FROM tbl_accounts where identification_number ='" & tb_managerID.Text & "'; "
        Dim reader As MySqlDataReader

        con()
        connect.Open()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = connect
        reader = cmd.ExecuteReader()

        Try
            While reader.Read()
                lbl_manager.Text = reader.GetString("name")
                lbl_accountType.Text = reader.GetString("account_type")
            End While

        Catch ex As Exception

        End Try
        connect.Close()
    End Sub

    Private Sub btn_enterManagerID_Click(sender As Object, e As EventArgs) Handles btn_enterManagerID.Click
        If lbl_accountType.Text = "Administrator" Then
            tb_managerID.Clear()
            lbl_accountType.Text = "*"

            pnl1.Visible = False
            pnl2.Visible = True

            tb_cashOutAmount.Select()
            tb_cashOutAmount.SelectAll()

        ElseIf lbl_accountType.Text IsNot "Administrator" Then
            MessageBox.Show("Not Authorized Account", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_managerID.Select()
            tb_managerID.SelectAll()

        ElseIf tb_managerID.Text = "" Then
            MessageBox.Show("Please Enter your ID", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_managerID.Select()
            tb_managerID.SelectAll()
        End If
    End Sub

    Private Sub tb_cashOutAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cashOutAmount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_enterCashOutAmount_Click(sender As Object, e As EventArgs) Handles btn_enterCashOutAmount.Click
        If tb_cashOutAmount.Text = Format(Val(tb_cashOutAmount.Text), "0.00") Or tb_cashOutAmount.Text = Format(Val(tb_cashOutAmount.Text), "0") Then

            If DialogResult.OK = MessageBox.Show("The Amount of Cashed Out is " + tb_cashOutAmount.Text _
            + "Are you sure to continue??", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) Then
                rtb_tor.Text = "" & vbNewLine & "" +
                    "" & vbNewLine & "SUNSHINE SUPERMARKET" +
                    "" & vbNewLine & "081 Gen. Luna St. San Lazaro city" +
                    "" & vbNewLine & "CASH IN AMOUNT TRANSCRIPT" +
                    "" & vbNewLine & "." +
                    "" & vbNewLine & "." +
                    "" & vbNewLine & "Manager: " + lbl_cashInManager.Text +
                    "" & vbNewLine & "Cashier: " + lbl_cashier.Text +
                    "" & vbNewLine & "Cash IN Amount: " +
                    "" & vbNewLine & lbl_cashInAmount.Text +
                    "" & vbNewLine & lbl_cashInTime.Text +
                    "" & vbNewLine & "." +
                    "" & vbNewLine & "." +
                    "" & vbNewLine & "CASH OUT AMOUNT TRANSCRIPT" +
                    "" & vbNewLine & "Manager: " + lbl_manager.Text +
                    "" & vbNewLine & "Transactions Total: " +
                    "" & vbNewLine & lbl_transactionsTotal.Text +
                    "" & vbNewLine & "Transactions Amount Total: " +
                    "" & vbNewLine & lbl_transactionsAmountTotal.Text +
                    "" & vbNewLine & "Discounts Amount Total: " +
                    "" & vbNewLine & lbl_discountsAmountTotal.Text +
                    "" & vbNewLine & "Cash Out Amount : " +
                    "" & vbNewLine & tb_cashOutAmount.Text +
                    "" & vbNewLine & dtp_date.Value + ""

                Printer.Print(rtb_tor.Text)
                Me.Close()
                POSForm.Close()
                LoginForm.Show()
            End If

        ElseIf tb_cashOutAmount.Text IsNot Format(Val(tb_cashOutAmount.Text), "0.00") Or tb_cashOutAmount.Text IsNot Format(Val(tb_cashOutAmount.Text), "0") Then
            MessageBox.Show("Invalid Decimal Format!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            tb_cashOutAmount.Select()
            tb_cashOutAmount.SelectAll()
        End If
    End Sub

    Private Sub CashOutForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 And tb_cashOutAmount.Text = "0" Then
            Me.Hide()
            POSForm.Show()
        End If
    End Sub
End Class