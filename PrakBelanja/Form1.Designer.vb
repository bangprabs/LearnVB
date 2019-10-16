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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QTY = New System.Windows.Forms.TextBox()
        Me.HRGBRG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KETDISK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BYRAKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CloseImage = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClearText = New System.Windows.Forms.Button()
        Me.BoxSebDisk = New System.Windows.Forms.TextBox()
        Me.LabelKet = New System.Windows.Forms.Label()
        Me.Jabatan = New System.Windows.Forms.PictureBox()
        CType(Me.CloseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banyak Barang              :"
        '
        'QTY
        '
        Me.QTY.Location = New System.Drawing.Point(170, 71)
        Me.QTY.Name = "QTY"
        Me.QTY.Size = New System.Drawing.Size(162, 20)
        Me.QTY.TabIndex = 1
        '
        'HRGBRG
        '
        Me.HRGBRG.Location = New System.Drawing.Point(170, 112)
        Me.HRGBRG.Name = "HRGBRG"
        Me.HRGBRG.Size = New System.Drawing.Size(162, 20)
        Me.HRGBRG.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Harga Satuan Barang   :"
        '
        'KETDISK
        '
        Me.KETDISK.Location = New System.Drawing.Point(170, 208)
        Me.KETDISK.Name = "KETDISK"
        Me.KETDISK.Size = New System.Drawing.Size(162, 20)
        Me.KETDISK.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keterangan                     :"
        '
        'BYRAKH
        '
        Me.BYRAKH.Location = New System.Drawing.Point(170, 268)
        Me.BYRAKH.Name = "BYRAKH"
        Me.BYRAKH.Size = New System.Drawing.Size(162, 20)
        Me.BYRAKH.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Bayar Akhir         :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Bayar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CloseImage
        '
        Me.CloseImage.Image = CType(resources.GetObject("CloseImage.Image"), System.Drawing.Image)
        Me.CloseImage.Location = New System.Drawing.Point(294, 7)
        Me.CloseImage.Name = "CloseImage"
        Me.CloseImage.Size = New System.Drawing.Size(38, 35)
        Me.CloseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseImage.TabIndex = 9
        Me.CloseImage.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ClearText
        '
        Me.ClearText.Location = New System.Drawing.Point(168, 162)
        Me.ClearText.Name = "ClearText"
        Me.ClearText.Size = New System.Drawing.Size(75, 23)
        Me.ClearText.TabIndex = 11
        Me.ClearText.Text = "Bersihkan"
        Me.ClearText.UseVisualStyleBackColor = True
        '
        'BoxSebDisk
        '
        Me.BoxSebDisk.Location = New System.Drawing.Point(170, 237)
        Me.BoxSebDisk.Name = "BoxSebDisk"
        Me.BoxSebDisk.Size = New System.Drawing.Size(162, 20)
        Me.BoxSebDisk.TabIndex = 13
        Me.BoxSebDisk.Visible = False
        '
        'LabelKet
        '
        Me.LabelKet.AutoSize = True
        Me.LabelKet.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKet.Location = New System.Drawing.Point(12, 239)
        Me.LabelKet.Name = "LabelKet"
        Me.LabelKet.Size = New System.Drawing.Size(137, 15)
        Me.LabelKet.TabIndex = 12
        Me.LabelKet.Text = "Total Sebelum Diskon  :"
        Me.LabelKet.Visible = False
        '
        'Jabatan
        '
        Me.Jabatan.Image = CType(resources.GetObject("Jabatan.Image"), System.Drawing.Image)
        Me.Jabatan.Location = New System.Drawing.Point(141, 233)
        Me.Jabatan.Name = "Jabatan"
        Me.Jabatan.Size = New System.Drawing.Size(43, 30)
        Me.Jabatan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Jabatan.TabIndex = 14
        Me.Jabatan.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 304)
        Me.Controls.Add(Me.Jabatan)
        Me.Controls.Add(Me.BoxSebDisk)
        Me.Controls.Add(Me.LabelKet)
        Me.Controls.Add(Me.ClearText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CloseImage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BYRAKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.KETDISK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HRGBRG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QTY)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.CloseImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jabatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents QTY As TextBox
    Friend WithEvents HRGBRG As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents KETDISK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BYRAKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CloseImage As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClearText As Button
    Friend WithEvents BoxSebDisk As TextBox
    Friend WithEvents LabelKet As Label
    Friend WithEvents Jabatan As PictureBox
End Class
