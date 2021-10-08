Imports MySql.Data.MySqlClient

Public Class CashInForm
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

            tb_cashInAmount.Select()
            tb_cashInAmount.SelectAll()

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

    Private Sub tb_cashInAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cashInAmount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_enterCashInAmount_Click(sender As Object, e As EventArgs) Handles btn_enterCashInAmount.Click
        If tb_cashInAmount.Text = Format(Val(tb_cashInAmount.Text), "0.00") Or tb_cashInAmount.Text = Format(Val(tb_cashInAmount.Text), "0") Then
            If Val(tb_cashInAmount.Text >= 5000) Then
                If DialogResult.OK = MessageBox.Show("The Amount of Cashed IN is " + tb_cashInAmount.Text _
                + "Are you sure to continue??", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) Then
                    CashOutForm.lbl_cashier.Text = lbl_cashier.Text
                    CashOutForm.lbl_cashInManager.Text = lbl_manager.Text
                    CashOutForm.lbl_cashInAmount.Text = tb_cashInAmount.Text
                    CashOutForm.lbl_cashInTime.Text = dtp_date.Value
                    POSForm.Show()
                    Me.Close()
                End If

            ElseIf Val(tb_cashInAmount.Text < 5000) Then
                MessageBox.Show("Insuficient Amount of Cash", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        ElseIf tb_cashInAmount.Text IsNot Format(Val(tb_cashInAmount.Text), "0.00") Or tb_cashInAmount.Text IsNot Format(Val(tb_cashInAmount.Text), "0") Then
            MessageBox.Show("Invalid Decimal Format!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            tb_cashInAmount.Select()
            tb_cashInAmount.SelectAll()
        End If
    End Sub

    Private Sub CashInForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 And Val(tb_cashInAmount.Text = 0) Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub
End Class