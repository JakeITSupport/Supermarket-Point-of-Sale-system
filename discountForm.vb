Imports MySql.Data.MySqlClient
Public Class discountForm

    Public Property original_total As String
    Private Sub discountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If lbl_accountType.Text = "Administrator" Then
            tb_managerID.Clear()
            pnl_discount.Visible = True
            btn_login.Visible = False
            tb_managerID.Visible = False
            lbl_MID.Visible = False
            tb_id.Select()

        ElseIf lbl_accountType.Text IsNot "Administrator" Then
            MessageBox.Show("NOT AUTHORIZE ACCOUNT", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tb_managerID.Select()

        Else
            MessageBox.Show("Enter your Administrator ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_managerID.Select()

        End If
    End Sub

    Private Sub discountForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Close()

        ElseIf e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub tb_managerID_TextChanged(sender As Object, e As EventArgs) Handles tb_managerID.TextChanged
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
                lbl_accountType.Text = reader.GetString("account_type")
            End While
        Catch ex As Exception

        End Try
        connect.Close()
    End Sub

    Private Sub cb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_type.SelectedIndexChanged
        If cb_type.SelectedItem = "Senior Citizen" Or cb_type.SelectedItem = "Person with Disabilities" Then
            lbl_discountRate.Text = ".001"
        Else
            lbl_discountRate.Text = ".001"

        End If
    End Sub

    Private Sub btn_sendOut_Click(sender As Object, e As EventArgs) Handles btn_sendOut.Click
        If tb_id.Text IsNot "" And tb_fullName.Text IsNot "" And lbl_discountRate.Text > 0.00 Then
            POSForm.discounted_name = tb_fullName.Text
            POSForm.tb_discount.Text = lbl_discountTotal.Text
            POSForm.lbl_discountActivation.Text = "1"
            POSForm.tb_discount.Visible = True
            POSForm.btn_enterDiscount.Visible = True
            POSForm.tb_barcode.Select()
            POSForm.tb_barcode.SelectAll()
            Me.Close()

        Else
            MessageBox.Show("Please fill in all feilds", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lbl_discountRate_TextChanged(sender As Object, e As EventArgs) Handles lbl_discountRate.TextChanged
        lbl_discountTotal.Text = Val(lbl_originalTotal.Text) * Val(lbl_discountRate.Text)

        If Val(lbl_discountRate.Text) > 0.000 Then
            btn_sendOut.Visible = True

        End If

    End Sub

    Private Sub btn_login_GotFoucus(sender As Object, e As EventArgs) Handles btn_login.GotFocus
        btn_login.BackColor = Color.DodgerBlue

    End Sub

    Private Sub btn_login_LostFocus(sender As Object, e As EventArgs) Handles btn_login.LostFocus
        btn_login.BackColor = Color.DimGray
    End Sub

    Private Sub btn_sendOut_GotFoucus(sender As Object, e As EventArgs) Handles btn_sendOut.GotFocus
        btn_sendOut.BackColor = Color.DodgerBlue

    End Sub

    Private Sub btn_sendOut_LostFocus(sender As Object, e As EventArgs) Handles btn_sendOut.LostFocus
        btn_sendOut.BackColor = Color.DimGray
    End Sub
End Class