<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DgvSurah = New System.Windows.Forms.DataGridView()
        Me.DgvNomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvNamaLatin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvJumlahAyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.lblarab = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DgvSurah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvSurah
        '
        Me.DgvSurah.AllowUserToAddRows = False
        Me.DgvSurah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSurah.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvNomor, Me.DgvNamaLatin, Me.DgvJumlahAyat})
        Me.DgvSurah.Location = New System.Drawing.Point(406, 64)
        Me.DgvSurah.Name = "DgvSurah"
        Me.DgvSurah.Size = New System.Drawing.Size(320, 232)
        Me.DgvSurah.TabIndex = 0
        '
        'DgvNomor
        '
        Me.DgvNomor.HeaderText = "#"
        Me.DgvNomor.Name = "DgvNomor"
        Me.DgvNomor.Width = 20
        '
        'DgvNamaLatin
        '
        Me.DgvNamaLatin.HeaderText = "Nama Latin"
        Me.DgvNamaLatin.Name = "DgvNamaLatin"
        Me.DgvNamaLatin.Width = 150
        '
        'DgvJumlahAyat
        '
        Me.DgvJumlahAyat.HeaderText = "Jumlah Ayat"
        Me.DgvJumlahAyat.Name = "DgvJumlahAyat"
        Me.DgvJumlahAyat.Width = 50
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Location = New System.Drawing.Point(762, 143)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(91, 13)
        Me.lbl_nama.TabIndex = 1
        Me.lbl_nama.Text = "Get Api html code"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(755, 159)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(270, 137)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.55!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(388, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "هل لديك سكايب"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(27, 64)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(363, 232)
        Me.WebBrowser1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.55!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nomor Suroh"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(755, 321)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(270, 187)
        Me.RichTextBox2.TabIndex = 9
        Me.RichTextBox2.Text = ""
        '
        'lblarab
        '
        Me.lblarab.AutoSize = True
        Me.lblarab.Location = New System.Drawing.Point(762, 305)
        Me.lblarab.Name = "lblarab"
        Me.lblarab.Size = New System.Drawing.Size(91, 13)
        Me.lblarab.TabIndex = 10
        Me.lblarab.Text = "Get Api html code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.55!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Suroh : "
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(24, 321)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(702, 213)
        Me.WebBrowser2.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(530, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Play"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(627, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 577)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblarab)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.DgvSurah)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "https://equran.id/"
        CType(Me.DgvSurah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvSurah As DataGridView
    Friend WithEvents lbl_nama As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DgvNomor As DataGridViewTextBoxColumn
    Friend WithEvents DgvNamaLatin As DataGridViewTextBoxColumn
    Friend WithEvents DgvJumlahAyat As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents lblarab As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
