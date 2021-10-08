Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub tb_username_Validated(sender As Object, e As EventArgs) Handles tb_username.Validated
        Dim cmd As New MySqlCommand
        Dim sql As String = "SELECT * FROM tbl_accounts where username ='" & tb_username.Text & "'; "
        Dim reader As MySqlDataReader

        con()
        connect.Open()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = connect
        reader = cmd.ExecuteReader()

        Try
            While reader.Read()
                lbl_employeeNum.Text = reader.GetString("id")
                lbl_cashierName.Text = reader.GetString("name")
                lbl_accountType.Text = reader.GetString("account_type")
            End While

        Catch ex As Exception

        End Try
        connect.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        con()
        Dim cmd As New MySqlCommand
        Dim cmdreader As MySqlDataReader
        Dim sql As String = "SELECT * FROM tbl_accounts Where username = '" & tb_username.Text &
            "' AND password = '" & tb_password.Text & "';"

        connect.Open()
        cmd.CommandText = sql
        cmd.Connection = connect
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmdreader = cmd.ExecuteReader

        If tb_username.Text <> "" Or tb_password.Text <> "" Then
            If cmdreader.Read() = True Then
                POSForm.cashier_name = lbl_cashierName.Text
                CashInForm.lbl_cashier.Text = lbl_cashierName.Text
                tb_username.Clear()
                tb_password.Clear()
                tb_username.Select()
                Me.Hide()
                CashInForm.Show()
                ' POSform.Show()

            ElseIf cmdreader.Read() = False Then
                MessageBox.Show("Incorrect Username or Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please fill in all Feilds!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_username.Clear()
            tb_password.Clear()
        End If
        connect.Close()
    End Sub

    Private Sub btn_login_GotFoucus(sender As Object, e As EventArgs) Handles btn_login.GotFocus
        btn_login.BackColor = Color.DodgerBlue

    End Sub

    Private Sub btn_login_LostFocus(sender As Object, e As EventArgs) Handles btn_login.LostFocus
        btn_login.BackColor = Color.Black
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class