<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pdAddGender = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAddPic = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pdAddDeparts = New System.Windows.Forms.ComboBox()
        Me.dtpAddBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddMail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pdAddGra = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddSkill = New System.Windows.Forms.TextBox()
        Me.txtAddAddress = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddCancel = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCancelPic = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "社員新規登録"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "氏名"
        '
        'txtAddName
        '
        Me.txtAddName.Location = New System.Drawing.Point(114, 97)
        Me.txtAddName.Name = "txtAddName"
        Me.txtAddName.Size = New System.Drawing.Size(130, 25)
        Me.txtAddName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "性別"
        '
        'pdAddGender
        '
        Me.pdAddGender.FormattingEnabled = True
        Me.pdAddGender.Items.AddRange(New Object() {"男", "女"})
        Me.pdAddGender.Location = New System.Drawing.Point(358, 96)
        Me.pdAddGender.Name = "pdAddGender"
        Me.pdAddGender.Size = New System.Drawing.Size(93, 26)
        Me.pdAddGender.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(600, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" &
    "s (*.*)|*.*"
        Me.OpenFileDialog1.Title = "写真ファイルを選択してください"
        '
        'btnAddPic
        '
        Me.btnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddPic.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAddPic.Location = New System.Drawing.Point(600, 193)
        Me.btnAddPic.Name = "btnAddPic"
        Me.btnAddPic.Size = New System.Drawing.Size(129, 38)
        Me.btnAddPic.TabIndex = 7
        Me.btnAddPic.Text = "アップロード"
        Me.btnAddPic.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "部署"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "生年月日"
        '
        'pdAddDeparts
        '
        Me.pdAddDeparts.FormattingEnabled = True
        Me.pdAddDeparts.Items.AddRange(New Object() {"SS事業部G1", "SS事業部G2", "SI事業部G1", "SI事業部G2 ", "SI事業部G3", "SI事業部G4", "インバウンド事業部", "営業部", "管理部"})
        Me.pdAddDeparts.Location = New System.Drawing.Point(114, 149)
        Me.pdAddDeparts.Name = "pdAddDeparts"
        Me.pdAddDeparts.Size = New System.Drawing.Size(140, 26)
        Me.pdAddDeparts.TabIndex = 11
        '
        'dtpAddBirth
        '
        Me.dtpAddBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAddBirth.Location = New System.Drawing.Point(371, 152)
        Me.dtpAddBirth.Name = "dtpAddBirth"
        Me.dtpAddBirth.Size = New System.Drawing.Size(200, 25)
        Me.dtpAddBirth.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "メールアドレス"
        '
        'txtAddMail
        '
        Me.txtAddMail.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtAddMail.Location = New System.Drawing.Point(178, 200)
        Me.txtAddMail.Name = "txtAddMail"
        Me.txtAddMail.Size = New System.Drawing.Size(180, 25)
        Me.txtAddMail.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "電話番号"
        '
        'txtAddTel
        '
        Me.txtAddTel.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtAddTel.Location = New System.Drawing.Point(178, 248)
        Me.txtAddTel.Name = "txtAddTel"
        Me.txtAddTel.Size = New System.Drawing.Size(160, 25)
        Me.txtAddTel.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "住所"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "最終学歴"
        '
        'pdAddGra
        '
        Me.pdAddGra.FormattingEnabled = True
        Me.pdAddGra.Items.AddRange(New Object() {"大学院（博士）", "大学院（修士）", "大学", "高専", "短期大学", "専門・専修", "高校", "その他"})
        Me.pdAddGra.Location = New System.Drawing.Point(157, 340)
        Me.pdAddGra.Name = "pdAddGra"
        Me.pdAddGra.Size = New System.Drawing.Size(130, 26)
        Me.pdAddGra.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(384, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "特技"
        '
        'txtAddSkill
        '
        Me.txtAddSkill.Location = New System.Drawing.Point(450, 340)
        Me.txtAddSkill.Name = "txtAddSkill"
        Me.txtAddSkill.Size = New System.Drawing.Size(120, 25)
        Me.txtAddSkill.TabIndex = 21
        '
        'txtAddAddress
        '
        Me.txtAddAddress.Location = New System.Drawing.Point(178, 291)
        Me.txtAddAddress.Name = "txtAddAddress"
        Me.txtAddAddress.Size = New System.Drawing.Size(300, 25)
        Me.txtAddAddress.TabIndex = 22
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(114, 406)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 32)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "登録する"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAddCancel
        '
        Me.btnAddCancel.AutoSize = True
        Me.btnAddCancel.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAddCancel.Location = New System.Drawing.Point(334, 406)
        Me.btnAddCancel.Name = "btnAddCancel"
        Me.btnAddCancel.Size = New System.Drawing.Size(105, 32)
        Me.btnAddCancel.TabIndex = 24
        Me.btnAddCancel.Text = "キャンセル"
        Me.btnAddCancel.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'btnCancelPic
        '
        Me.btnCancelPic.AutoSize = True
        Me.btnCancelPic.Location = New System.Drawing.Point(600, 241)
        Me.btnCancelPic.Name = "btnCancelPic"
        Me.btnCancelPic.Size = New System.Drawing.Size(129, 38)
        Me.btnCancelPic.TabIndex = 26
        Me.btnCancelPic.Text = "取り消し"
        Me.btnCancelPic.UseVisualStyleBackColor = True
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelPic)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnAddCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAddAddress)
        Me.Controls.Add(Me.txtAddSkill)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pdAddGra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAddTel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddMail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpAddBirth)
        Me.Controls.Add(Me.pdAddDeparts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddPic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pdAddGender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewUser"
        Me.Text = "新規登録"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pdAddGender As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAddPic As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pdAddDeparts As ComboBox
    Friend WithEvents dtpAddBirth As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddMail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pdAddGra As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAddSkill As TextBox
    Friend WithEvents txtAddAddress As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddCancel As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancelPic As Button
End Class
