<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditUser
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtEditAddress = New System.Windows.Forms.TextBox()
        Me.txtEditSkill = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pdEditGra = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEditMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpEditBirth = New System.Windows.Forms.DateTimePicker()
        Me.pdEditDeparts = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEditPic = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pdEditGender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEditTel = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCancelPic = New System.Windows.Forms.Button()
        Me.txtEditByID = New System.Windows.Forms.TextBox()
        Me.btnSrcForEdit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "社員情報編集"
        '
        'btnEditCancel
        '
        Me.btnEditCancel.AutoSize = True
        Me.btnEditCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEditCancel.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEditCancel.ForeColor = System.Drawing.Color.DarkRed
        Me.btnEditCancel.Location = New System.Drawing.Point(363, 450)
        Me.btnEditCancel.Name = "btnEditCancel"
        Me.btnEditCancel.Size = New System.Drawing.Size(125, 32)
        Me.btnEditCancel.TabIndex = 46
        Me.btnEditCancel.Text = "キャンセル"
        Me.btnEditCancel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEdit.Location = New System.Drawing.Point(132, 450)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(125, 32)
        Me.btnEdit.TabIndex = 45
        Me.btnEdit.Text = "変更を保存"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtEditAddress
        '
        Me.txtEditAddress.Location = New System.Drawing.Point(170, 341)
        Me.txtEditAddress.Name = "txtEditAddress"
        Me.txtEditAddress.Size = New System.Drawing.Size(300, 25)
        Me.txtEditAddress.TabIndex = 44
        '
        'txtEditSkill
        '
        Me.txtEditSkill.Location = New System.Drawing.Point(442, 390)
        Me.txtEditSkill.Name = "txtEditSkill"
        Me.txtEditSkill.Size = New System.Drawing.Size(120, 25)
        Me.txtEditSkill.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(376, 393)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "特技"
        '
        'pdEditGra
        '
        Me.pdEditGra.FormattingEnabled = True
        Me.pdEditGra.Items.AddRange(New Object() {"大学院（博士）", "大学院（修士）", "大学", "高専", "短期大学", "専門・専修", "高校", "その他"})
        Me.pdEditGra.Location = New System.Drawing.Point(170, 393)
        Me.pdEditGra.Name = "pdEditGra"
        Me.pdEditGra.Size = New System.Drawing.Size(147, 26)
        Me.pdEditGra.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "最終学歴"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "住所"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "電話番号"
        '
        'txtEditMail
        '
        Me.txtEditMail.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtEditMail.Location = New System.Drawing.Point(170, 250)
        Me.txtEditMail.Name = "txtEditMail"
        Me.txtEditMail.Size = New System.Drawing.Size(180, 25)
        Me.txtEditMail.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "メールアドレス"
        '
        'dtpEditBirth
        '
        Me.dtpEditBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEditBirth.Location = New System.Drawing.Point(363, 202)
        Me.dtpEditBirth.Name = "dtpEditBirth"
        Me.dtpEditBirth.Size = New System.Drawing.Size(200, 25)
        Me.dtpEditBirth.TabIndex = 35
        '
        'pdEditDeparts
        '
        Me.pdEditDeparts.FormattingEnabled = True
        Me.pdEditDeparts.Items.AddRange(New Object() {"SS事業部G1", "SS事業部G2", "SI事業部G1", "SI事業部G2 ", "SI事業部G3", "SI事業部G4", "インバウンド事業部", "営業部", "管理部"})
        Me.pdEditDeparts.Location = New System.Drawing.Point(106, 199)
        Me.pdEditDeparts.Name = "pdEditDeparts"
        Me.pdEditDeparts.Size = New System.Drawing.Size(165, 26)
        Me.pdEditDeparts.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(277, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "生年月日"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "部署"
        '
        'btnEditPic
        '
        Me.btnEditPic.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditPic.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEditPic.Location = New System.Drawing.Point(616, 207)
        Me.btnEditPic.Name = "btnEditPic"
        Me.btnEditPic.Size = New System.Drawing.Size(150, 38)
        Me.btnEditPic.TabIndex = 31
        Me.btnEditPic.Text = "アップロード"
        Me.btnEditPic.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(616, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'pdEditGender
        '
        Me.pdEditGender.FormattingEnabled = True
        Me.pdEditGender.Items.AddRange(New Object() {"男", "女"})
        Me.pdEditGender.Location = New System.Drawing.Point(350, 146)
        Me.pdEditGender.Name = "pdEditGender"
        Me.pdEditGender.Size = New System.Drawing.Size(93, 26)
        Me.pdEditGender.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "性別"
        '
        'txtEditName
        '
        Me.txtEditName.Location = New System.Drawing.Point(106, 147)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(130, 25)
        Me.txtEditName.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "氏名"
        '
        'txtEditTel
        '
        Me.txtEditTel.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtEditTel.Location = New System.Drawing.Point(170, 295)
        Me.txtEditTel.Name = "txtEditTel"
        Me.txtEditTel.Size = New System.Drawing.Size(160, 25)
        Me.txtEditTel.TabIndex = 47
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'btnCancelPic
        '
        Me.btnCancelPic.AutoSize = True
        Me.btnCancelPic.ForeColor = System.Drawing.Color.DarkRed
        Me.btnCancelPic.Location = New System.Drawing.Point(616, 253)
        Me.btnCancelPic.Name = "btnCancelPic"
        Me.btnCancelPic.Size = New System.Drawing.Size(150, 38)
        Me.btnCancelPic.TabIndex = 49
        Me.btnCancelPic.Text = "取り消し"
        Me.btnCancelPic.UseVisualStyleBackColor = True
        '
        'txtEditByID
        '
        Me.txtEditByID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtEditByID.Location = New System.Drawing.Point(107, 100)
        Me.txtEditByID.Name = "txtEditByID"
        Me.txtEditByID.Size = New System.Drawing.Size(100, 25)
        Me.txtEditByID.TabIndex = 50
        '
        'btnSrcForEdit
        '
        Me.btnSrcForEdit.AutoSize = True
        Me.btnSrcForEdit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSrcForEdit.Location = New System.Drawing.Point(246, 98)
        Me.btnSrcForEdit.Name = "btnSrcForEdit"
        Me.btnSrcForEdit.Size = New System.Drawing.Size(75, 28)
        Me.btnSrcForEdit.TabIndex = 51
        Me.btnSrcForEdit.Text = "検索"
        Me.btnSrcForEdit.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "社員ID："
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 506)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSrcForEdit)
        Me.Controls.Add(Me.txtEditByID)
        Me.Controls.Add(Me.btnCancelPic)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtEditTel)
        Me.Controls.Add(Me.btnEditCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtEditAddress)
        Me.Controls.Add(Me.txtEditSkill)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pdEditGra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEditMail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpEditBirth)
        Me.Controls.Add(Me.pdEditDeparts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEditPic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pdEditGender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEditName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditUser"
        Me.Text = "情報編集"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtEditAddress As TextBox
    Friend WithEvents txtEditSkill As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pdEditGra As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEditMail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpEditBirth As DateTimePicker
    Friend WithEvents pdEditDeparts As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEditPic As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pdEditGender As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEditTel As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancelPic As Button
    Friend WithEvents txtEditByID As TextBox
    Friend WithEvents btnSrcForEdit As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label11 As Label
End Class
