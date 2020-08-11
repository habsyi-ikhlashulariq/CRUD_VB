<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_nik = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_nama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tx_alamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tx_ttl = New System.Windows.Forms.DateTimePicker()
        Me.cb_agama = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tx_pekerjaan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tx_berlaku = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Kependudukan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 11)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'tx_nik
        '
        Me.tx_nik.Location = New System.Drawing.Point(103, 48)
        Me.tx_nik.Name = "tx_nik"
        Me.tx_nik.Size = New System.Drawing.Size(174, 20)
        Me.tx_nik.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 11)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama"
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(103, 70)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.Size = New System.Drawing.Size(174, 20)
        Me.tx_nama.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 11)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TTL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 11)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jenis Kelamin"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(103, 116)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 15)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Laki-Laki"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(186, 116)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(86, 15)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Perempuan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 11)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Alamat"
        '
        'tx_alamat
        '
        Me.tx_alamat.Location = New System.Drawing.Point(382, 47)
        Me.tx_alamat.Name = "tx_alamat"
        Me.tx_alamat.Size = New System.Drawing.Size(174, 20)
        Me.tx_alamat.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 11)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Agama"
        '
        'tx_ttl
        '
        Me.tx_ttl.CustomFormat = "yyyy-mm-dd"
        Me.tx_ttl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tx_ttl.Location = New System.Drawing.Point(103, 94)
        Me.tx_ttl.Name = "tx_ttl"
        Me.tx_ttl.Size = New System.Drawing.Size(174, 20)
        Me.tx_ttl.TabIndex = 11
        '
        'cb_agama
        '
        Me.cb_agama.FormattingEnabled = True
        Me.cb_agama.Items.AddRange(New Object() {"Pilih Agama", "Islam", "Kristen", "Khatolik", "Budha", "Hindu"})
        Me.cb_agama.Location = New System.Drawing.Point(382, 69)
        Me.cb_agama.Name = "cb_agama"
        Me.cb_agama.Size = New System.Drawing.Size(174, 19)
        Me.cb_agama.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 11)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Pekerjaan"
        '
        'tx_pekerjaan
        '
        Me.tx_pekerjaan.Location = New System.Drawing.Point(382, 91)
        Me.tx_pekerjaan.Name = "tx_pekerjaan"
        Me.tx_pekerjaan.Size = New System.Drawing.Size(174, 20)
        Me.tx_pekerjaan.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 11)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Berlaku"
        '
        'tx_berlaku
        '
        Me.tx_berlaku.Location = New System.Drawing.Point(382, 113)
        Me.tx_berlaku.Name = "tx_berlaku"
        Me.tx_berlaku.Size = New System.Drawing.Size(174, 20)
        Me.tx_berlaku.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 191)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(553, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(134, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "INPUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(296, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(377, 153)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "TUTUP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 353)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb_agama)
        Me.Controls.Add(Me.tx_ttl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tx_berlaku)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tx_pekerjaan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tx_alamat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tx_nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tx_nik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Dotum", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tx_nik As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tx_nama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents tx_alamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tx_ttl As DateTimePicker
    Friend WithEvents cb_agama As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tx_pekerjaan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tx_berlaku As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
