<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceLookUpForm
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
        Me.lbl_time1 = New System.Windows.Forms.Label()
        Me.tb_price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_label = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_barcode = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbl_time1
        '
        Me.lbl_time1.AutoSize = True
        Me.lbl_time1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time1.Location = New System.Drawing.Point(132, 233)
        Me.lbl_time1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_time1.Name = "lbl_time1"
        Me.lbl_time1.Size = New System.Drawing.Size(20, 25)
        Me.lbl_time1.TabIndex = 19
        Me.lbl_time1.Text = "*"
        Me.lbl_time1.Visible = False
        '
        'tb_price
        '
        Me.tb_price.BackColor = System.Drawing.Color.White
        Me.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price.Location = New System.Drawing.Point(12, 294)
        Me.tb_price.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_price.Name = "tb_price"
        Me.tb_price.ReadOnly = True
        Me.tb_price.Size = New System.Drawing.Size(600, 91)
        Me.tb_price.TabIndex = 18
        Me.tb_price.Text = "0.00"
        Me.tb_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(250, 236)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 42)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Price"
        '
        'lbl_label
        '
        Me.lbl_label.AutoSize = True
        Me.lbl_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_label.Location = New System.Drawing.Point(160, 187)
        Me.lbl_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_label.Name = "lbl_label"
        Me.lbl_label.Size = New System.Drawing.Size(20, 25)
        Me.lbl_label.TabIndex = 16
        Me.lbl_label.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 182)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Label:"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.Location = New System.Drawing.Point(160, 140)
        Me.lbl_description.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(20, 25)
        Me.lbl_description.TabIndex = 14
        Me.lbl_description.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Barcode:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Price Look Up"
        '
        'tb_barcode
        '
        Me.tb_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_barcode.Location = New System.Drawing.Point(129, 78)
        Me.tb_barcode.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_barcode.Name = "tb_barcode"
        Me.tb_barcode.Size = New System.Drawing.Size(465, 34)
        Me.tb_barcode.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PriceLookUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.lbl_time1)
        Me.Controls.Add(Me.tb_price)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_label)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_barcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "PriceLookUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pice Look Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_time1 As Label
    Friend WithEvents tb_price As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_label As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_barcode As TextBox
    Friend WithEvents Timer1 As Timer
End Class
