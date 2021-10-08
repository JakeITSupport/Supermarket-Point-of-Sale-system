Imports MySql.Data.MySqlClient

Public Class PriceLookUpForm
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
            tb_price.Text = reader.GetString("price")
            lbl_description.Text = reader.GetString("description")
            lbl_label.Text = reader.GetString("label")
            tb_barcode.SelectAll()

        ElseIf reader.Read() = False Then
            lbl_description.Text = "Product Not Found"
            lbl_label.Text = "Product Not Found"
            tb_price.Text = "0.00"

        End If
        connect.Close()
    End Sub

    Private timeLeft1 As Integer = 3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft1 > 0 Then
            timeLeft1 = timeLeft1 - 1
            lbl_time1.Text = timeLeft1 & " Seconds"
            tb_barcode.[Select]()
        Else
            tb_barcode.SelectAll()
        End If
    End Sub

    Private Sub PiceLookForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Close()
        End If
    End Sub
End Class