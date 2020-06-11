<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowUsers
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowUsers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.Button()
        Me.btnGoToNew = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSrcName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pdSrcGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pdSrcDeparts = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSrcMail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSrcTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSrcAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pdSrcGra = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSrcSkill = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.dgvShowUsers = New System.Windows.Forms.DataGridView()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSrcBirth = New System.Windows.Forms.TextBox()
        Me.txtSrcID = New System.Windows.Forms.TextBox()
        Me.btnEditByID = New System.Windows.Forms.Button()
        Me.btnDeleteByID = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvShowUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "社員情報一覧"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.Maroon
        Me.Logout.Location = New System.Drawing.Point(1036, 12)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(102, 32)
        Me.Logout.TabIndex = 1
        Me.Logout.Text = "ログアウト"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'btnGoToNew
        '
        Me.btnGoToNew.AutoSize = True
        Me.btnGoToNew.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGoToNew.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnGoToNew.Location = New System.Drawing.Point(906, 12)
        Me.btnGoToNew.Name = "btnGoToNew"
        Me.btnGoToNew.Size = New System.Drawing.Size(102, 32)
        Me.btnGoToNew.TabIndex = 2
        Me.btnGoToNew.Text = "新規"
        Me.btnGoToNew.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(12, 45)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(237, 61)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 26
        Me.Logo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "氏名"
        '
        'txtSrcName
        '
        Me.txtSrcName.Location = New System.Drawing.Point(88, 152)
        Me.txtSrcName.Name = "txtSrcName"
        Me.txtSrcName.Size = New System.Drawing.Size(100, 25)
        Me.txtSrcName.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "性別"
        '
        'pdSrcGender
        '
        Me.pdSrcGender.FormattingEnabled = True
        Me.pdSrcGender.Items.AddRange(New Object() {"", "男", "女"})
        Me.pdSrcGender.Location = New System.Drawing.Point(244, 151)
        Me.pdSrcGender.Name = "pdSrcGender"
        Me.pdSrcGender.Size = New System.Drawing.Size(74, 26)
        Me.pdSrcGender.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "部署"
        '
        'pdSrcDeparts
        '
        Me.pdSrcDeparts.FormattingEnabled = True
        Me.pdSrcDeparts.Items.AddRange(New Object() {"", "SS事業部G1", "SS事業部G2", "SI事業部G1", "SI事業部G2 ", "SI事業部G3", "SI事業部G4", "インバウンド事業部", "営業部", "管理部"})
        Me.pdSrcDeparts.Location = New System.Drawing.Point(374, 151)
        Me.pdSrcDeparts.Name = "pdSrcDeparts"
        Me.pdSrcDeparts.Size = New System.Drawing.Size(132, 26)
        Me.pdSrcDeparts.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(527, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "生年月日"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(793, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "メールアドレス"
        '
        'txtSrcMail
        '
        Me.txtSrcMail.Location = New System.Drawing.Point(904, 151)
        Me.txtSrcMail.Name = "txtSrcMail"
        Me.txtSrcMail.Size = New System.Drawing.Size(156, 25)
        Me.txtSrcMail.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "電話"
        '
        'txtSrcTel
        '
        Me.txtSrcTel.Location = New System.Drawing.Point(88, 192)
        Me.txtSrcTel.Name = "txtSrcTel"
        Me.txtSrcTel.Size = New System.Drawing.Size(100, 25)
        Me.txtSrcTel.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "住所"
        '
        'txtSrcAddress
        '
        Me.txtSrcAddress.Location = New System.Drawing.Point(244, 192)
        Me.txtSrcAddress.Name = "txtSrcAddress"
        Me.txtSrcAddress.Size = New System.Drawing.Size(262, 25)
        Me.txtSrcAddress.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(527, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "最終学歴"
        '
        'pdSrcGra
        '
        Me.pdSrcGra.FormattingEnabled = True
        Me.pdSrcGra.Items.AddRange(New Object() {"", "大学院（博士）", "大学院（修士）", "大学", "高専", "短期大学", "専門・専修", "高校", "その他"})
        Me.pdSrcGra.Location = New System.Drawing.Point(622, 194)
        Me.pdSrcGra.Name = "pdSrcGra"
        Me.pdSrcGra.Size = New System.Drawing.Size(136, 26)
        Me.pdSrcGra.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(778, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "特技"
        '
        'txtSrcSkill
        '
        Me.txtSrcSkill.Location = New System.Drawing.Point(828, 195)
        Me.txtSrcSkill.Name = "txtSrcSkill"
        Me.txtSrcSkill.Size = New System.Drawing.Size(100, 25)
        Me.txtSrcSkill.TabIndex = 44
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Location = New System.Drawing.Point(975, 193)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 28)
        Me.btnSearch.TabIndex = 45
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClearSearch
        '
        Me.btnClearSearch.AutoSize = True
        Me.btnClearSearch.Location = New System.Drawing.Point(1056, 193)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(75, 28)
        Me.btnClearSearch.TabIndex = 46
        Me.btnClearSearch.Text = "クリア"
        Me.btnClearSearch.UseVisualStyleBackColor = True
        '
        'dgvShowUsers
        '
        Me.dgvShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowUsers.Location = New System.Drawing.Point(14, 245)
        Me.dgvShowUsers.Name = "dgvShowUsers"
        Me.dgvShowUsers.RowHeadersVisible = False
        Me.dgvShowUsers.RowHeadersWidth = 62
        Me.dgvShowUsers.RowTemplate.Height = 27
        Me.dgvShowUsers.Size = New System.Drawing.Size(1098, 313)
        Me.dgvShowUsers.TabIndex = 47
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1165, 38)
        Me.BindingNavigator1.TabIndex = 48
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 33)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'txtSrcBirth
        '
        Me.txtSrcBirth.Location = New System.Drawing.Point(622, 151)
        Me.txtSrcBirth.Name = "txtSrcBirth"
        Me.txtSrcBirth.Size = New System.Drawing.Size(156, 25)
        Me.txtSrcBirth.TabIndex = 50
        '
        'txtSrcID
        '
        Me.txtSrcID.Location = New System.Drawing.Point(1011, 56)
        Me.txtSrcID.Name = "txtSrcID"
        Me.txtSrcID.Size = New System.Drawing.Size(127, 25)
        Me.txtSrcID.TabIndex = 51
        '
        'btnEditByID
        '
        Me.btnEditByID.AutoSize = True
        Me.btnEditByID.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEditByID.Location = New System.Drawing.Point(702, 94)
        Me.btnEditByID.Name = "btnEditByID"
        Me.btnEditByID.Size = New System.Drawing.Size(206, 32)
        Me.btnEditByID.TabIndex = 52
        Me.btnEditByID.Text = "該当する社員情報を編集"
        Me.btnEditByID.UseVisualStyleBackColor = True
        '
        'btnDeleteByID
        '
        Me.btnDeleteByID.AutoSize = True
        Me.btnDeleteByID.ForeColor = System.Drawing.Color.DarkRed
        Me.btnDeleteByID.Location = New System.Drawing.Point(932, 94)
        Me.btnDeleteByID.Name = "btnDeleteByID"
        Me.btnDeleteByID.Size = New System.Drawing.Size(206, 34)
        Me.btnDeleteByID.TabIndex = 53
        Me.btnDeleteByID.Text = "該当する社員情報を削除"
        Me.btnDeleteByID.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(888, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 22)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "IDを入力："
        '
        'ShowUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 597)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnDeleteByID)
        Me.Controls.Add(Me.btnEditByID)
        Me.Controls.Add(Me.txtSrcID)
        Me.Controls.Add(Me.txtSrcBirth)
        Me.Controls.Add(Me.btnGoToNew)
        Me.Controls.Add(Me.dgvShowUsers)
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSrcSkill)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pdSrcGra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSrcAddress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSrcTel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSrcMail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pdSrcDeparts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pdSrcGender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSrcName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShowUsers"
        Me.Text = "情報一覧"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvShowUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As Button
    Friend WithEvents btnGoToNew As Button
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSrcName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pdSrcGender As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pdSrcDeparts As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSrcMail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSrcTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSrcAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pdSrcGra As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSrcSkill As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents dgvShowUsers As DataGridView
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents txtSrcBirth As TextBox
    Friend WithEvents txtSrcID As TextBox
    Friend WithEvents btnEditByID As Button
    Friend WithEvents btnDeleteByID As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
