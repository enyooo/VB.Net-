<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numOrderAmount = New System.Windows.Forms.NumericUpDown()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnAddFinish = New System.Windows.Forms.Button()
        Me.btnAddAnotheAccount = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "アカウントの追加"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "顧客名："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "顧客ID："
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(139, 36)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 25)
        Me.txtCustomerName.TabIndex = 2
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(139, 93)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 25)
        Me.txtCustomerID.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpOrderDate)
        Me.GroupBox2.Controls.Add(Me.numOrderAmount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "注文を作成する"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "注文の合計："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "注文日："
        '
        'numOrderAmount
        '
        Me.numOrderAmount.Location = New System.Drawing.Point(180, 42)
        Me.numOrderAmount.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numOrderAmount.Name = "numOrderAmount"
        Me.numOrderAmount.Size = New System.Drawing.Size(120, 25)
        Me.numOrderAmount.TabIndex = 2
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(100, 95)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpOrderDate.TabIndex = 3
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.AutoSize = True
        Me.btnCreateAccount.Location = New System.Drawing.Point(377, 137)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(135, 28)
        Me.btnCreateAccount.TabIndex = 2
        Me.btnCreateAccount.Text = "アカウントの作成"
        Me.btnCreateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.AutoSize = True
        Me.btnPlaceOrder.Location = New System.Drawing.Point(377, 323)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(83, 28)
        Me.btnPlaceOrder.TabIndex = 3
        Me.btnPlaceOrder.Text = "注文する"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnAddFinish
        '
        Me.btnAddFinish.AutoSize = True
        Me.btnAddFinish.Location = New System.Drawing.Point(48, 400)
        Me.btnAddFinish.Name = "btnAddFinish"
        Me.btnAddFinish.Size = New System.Drawing.Size(77, 28)
        Me.btnAddFinish.TabIndex = 4
        Me.btnAddFinish.Text = "完了"
        Me.btnAddFinish.UseVisualStyleBackColor = True
        '
        'btnAddAnotheAccount
        '
        Me.btnAddAnotheAccount.AutoSize = True
        Me.btnAddAnotheAccount.Location = New System.Drawing.Point(264, 400)
        Me.btnAddAnotheAccount.Name = "btnAddAnotheAccount"
        Me.btnAddAnotheAccount.Size = New System.Drawing.Size(196, 28)
        Me.btnAddAnotheAccount.TabIndex = 5
        Me.btnAddAnotheAccount.Text = "別のアカウントを追加する"
        Me.btnAddAnotheAccount.UseVisualStyleBackColor = True
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 449)
        Me.Controls.Add(Me.btnAddAnotheAccount)
        Me.Controls.Add(Me.btnAddFinish)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewCustomer"
        Me.Text = "NewCustomer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents numOrderAmount As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnAddFinish As Button
    Friend WithEvents btnAddAnotheAccount As Button
End Class
