Imports MySql.Data.MySqlClient

Public Class voidForm
    Private Sub voidForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Close()

        ElseIf e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()

        End If
    End Sub

    Private Sub voidForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_managerID.Select()
    End Sub
    Private Sub btn_login_GotFoucus(sender As Object, e As EventArgs) Handles btn_login.GotFocus
        btn_login.BackColor = Color.DodgerBlue

    End Sub

    Private Sub btn_login_LostFoucus(sender As Object, e As EventArgs) Handles btn_login.LostFocus
        btn_login.BackColor = Color.DimGray
    End Sub

    Private Sub tb_managerID_TextChanged(sender As Object, e As EventArgs) Handles tb_managerID.TextChanged

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If lbl_accountType.Text = "Administrator" Then
            tb_managerID.Clear()
            Me.Close()
            POSForm.tb_barcode.Select()
            POSForm.lbl_voidActivation.Text = "1"
            POSForm.tb_voidAmount.Visible = True
            POSForm.btn_void.Visible = True
            POSForm.tb_payment.Visible = False
            POSForm.btn_enterPayment.Visible = False

        ElseIf lbl_accountType.Text IsNot "Administrator" Then
            MessageBox.Show("NOT AUTHORIZE ACCOUNT", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tb_managerID.Select()

        ElseIf tb_managerID.Text = "" Then
            MessageBox.Show("Enter your Administrator ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_managerID.Select()

        End If
    End Sub

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
                lbl_accountType.Text = reader.GetString("account_type")
            End While
        Catch ex As Exception

        End Try
        connect.Close()
    End Sub
End Class