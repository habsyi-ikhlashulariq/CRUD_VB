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
        Me.tx_npm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kd_matkul = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_kuis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tx_tugas = New System.Windows.Forms.TextBox()
        Me.lb_nm_mhs = New System.Windows.Forms.Label()
        Me.lb_nm_matkul = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tx_kehadiran = New System.Windows.Forms.TextBox()
        Me.tx_uts = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tx_uas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lb_nilai_akhir = New System.Windows.Forms.Label()
        Me.lb_grade = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Nilai Mahasiwa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NPM"
        '
        'tx_npm
        '
        Me.tx_npm.Location = New System.Drawing.Point(121, 65)
        Me.tx_npm.Name = "tx_npm"
        Me.tx_npm.Size = New System.Drawing.Size(100, 20)
        Me.tx_npm.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Matkul"
        '
        'kd_matkul
        '
        Me.kd_matkul.Location = New System.Drawing.Point(282, 65)
        Me.kd_matkul.Name = "kd_matkul"
        Me.kd_matkul.Size = New System.Drawing.Size(100, 20)
        Me.kd_matkul.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kuis"
        '
        'tx_kuis
        '
        Me.tx_kuis.Location = New System.Drawing.Point(75, 121)
        Me.tx_kuis.Name = "tx_kuis"
        Me.tx_kuis.Size = New System.Drawing.Size(100, 20)
        Me.tx_kuis.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tugas"
        '
        'tx_tugas
        '
        Me.tx_tugas.Location = New System.Drawing.Point(75, 147)
        Me.tx_tugas.Name = "tx_tugas"
        Me.tx_tugas.Size = New System.Drawing.Size(100, 20)
        Me.tx_tugas.TabIndex = 4
        '
        'lb_nm_mhs
        '
        Me.lb_nm_mhs.AutoSize = True
        Me.lb_nm_mhs.Location = New System.Drawing.Point(122, 90)
        Me.lb_nm_mhs.Name = "lb_nm_mhs"
        Me.lb_nm_mhs.Size = New System.Drawing.Size(16, 13)
        Me.lb_nm_mhs.TabIndex = 5
        Me.lb_nm_mhs.Text = "..."
        '
        'lb_nm_matkul
        '
        Me.lb_nm_matkul.AutoSize = True
        Me.lb_nm_matkul.Location = New System.Drawing.Point(282, 91)
        Me.lb_nm_matkul.Name = "lb_nm_matkul"
        Me.lb_nm_matkul.Size = New System.Drawing.Size(16, 13)
        Me.lb_nm_matkul.TabIndex = 6
        Me.lb_nm_matkul.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kehadiran"
        '
        'tx_kehadiran
        '
        Me.tx_kehadiran.Location = New System.Drawing.Point(75, 176)
        Me.tx_kehadiran.Name = "tx_kehadiran"
        Me.tx_kehadiran.Size = New System.Drawing.Size(100, 20)
        Me.tx_kehadiran.TabIndex = 4
        '
        'tx_uts
        '
        Me.tx_uts.Location = New System.Drawing.Point(74, 201)
        Me.tx_uts.Name = "tx_uts"
        Me.tx_uts.Size = New System.Drawing.Size(100, 20)
        Me.tx_uts.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "UTS"
        '
        'tx_uas
        '
        Me.tx_uas.Location = New System.Drawing.Point(75, 227)
        Me.tx_uas.Name = "tx_uas"
        Me.tx_uas.Size = New System.Drawing.Size(100, 20)
        Me.tx_uas.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "UAS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(284, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Nilai Akhir"
        '
        'lb_nilai_akhir
        '
        Me.lb_nilai_akhir.AutoSize = True
        Me.lb_nilai_akhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nilai_akhir.Location = New System.Drawing.Point(297, 150)
        Me.lb_nilai_akhir.Name = "lb_nilai_akhir"
        Me.lb_nilai_akhir.Size = New System.Drawing.Size(28, 24)
        Me.lb_nilai_akhir.TabIndex = 9
        Me.lb_nilai_akhir.Text = "..."
        '
        'lb_grade
        '
        Me.lb_grade.AutoSize = True
        Me.lb_grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_grade.Location = New System.Drawing.Point(297, 196)
        Me.lb_grade.Name = "lb_grade"
        Me.lb_grade.Size = New System.Drawing.Size(28, 24)
        Me.lb_grade.TabIndex = 10
        Me.lb_grade.Text = "..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "INPUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(226, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(307, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "TUTUP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 301)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(402, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "ID Nilai"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(59, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(190, 123)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Hitung"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 461)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lb_grade)
        Me.Controls.Add(Me.lb_nilai_akhir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lb_nm_matkul)
        Me.Controls.Add(Me.tx_uas)
        Me.Controls.Add(Me.tx_uts)
        Me.Controls.Add(Me.tx_kehadiran)
        Me.Controls.Add(Me.lb_nm_mhs)
        Me.Controls.Add(Me.tx_tugas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tx_kuis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kd_matkul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tx_npm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tx_npm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kd_matkul As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tx_kuis As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tx_tugas As TextBox
    Friend WithEvents lb_nm_mhs As Label
    Friend WithEvents lb_nm_matkul As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tx_kehadiran As TextBox
    Friend WithEvents tx_uts As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tx_uas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lb_nilai_akhir As Label
    Friend WithEvents lb_grade As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
End Class
