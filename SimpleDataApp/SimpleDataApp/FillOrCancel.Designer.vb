<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FillOrCancel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.btnFindByOrderID = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFillDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView()
        Me.ButtonbtnCancelOrder = New System.Windows.Forms.Button()
        Me.btnFillOrder = New System.Windows.Forms.Button()
        Me.btnFinishUpdates = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "注文ID:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(126, 17)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(100, 25)
        Me.txtOrderID.TabIndex = 1
        '
        'btnFindByOrderID
        '
        Me.btnFindByOrderID.AutoSize = True
        Me.btnFindByOrderID.Location = New System.Drawing.Point(284, 19)
        Me.btnFindByOrderID.Name = "btnFindByOrderID"
        Me.btnFindByOrderID.Size = New System.Drawing.Size(105, 28)
        Me.btnFindByOrderID.TabIndex = 2
        Me.btnFindByOrderID.Text = "注文の検索"
        Me.btnFindByOrderID.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "注文を入力する場合、入力した日付を指定"
        '
        'dtpFillDate
        '
        Me.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFillDate.Location = New System.Drawing.Point(354, 85)
        Me.dtpFillDate.Name = "dtpFillDate"
        Me.dtpFillDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpFillDate.TabIndex = 4
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(31, 141)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.ReadOnly = True
        Me.dgvCustomerOrders.RowHeadersVisible = False
        Me.dgvCustomerOrders.RowHeadersWidth = 62
        Me.dgvCustomerOrders.RowTemplate.Height = 27
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(591, 155)
        Me.dgvCustomerOrders.TabIndex = 5
        '
        'ButtonbtnCancelOrder
        '
        Me.ButtonbtnCancelOrder.AutoSize = True
        Me.ButtonbtnCancelOrder.Location = New System.Drawing.Point(31, 344)
        Me.ButtonbtnCancelOrder.Name = "ButtonbtnCancelOrder"
        Me.ButtonbtnCancelOrder.Size = New System.Drawing.Size(139, 28)
        Me.ButtonbtnCancelOrder.TabIndex = 6
        Me.ButtonbtnCancelOrder.Text = "注文のキャンセル"
        Me.ButtonbtnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnFillOrder
        '
        Me.btnFillOrder.AutoSize = True
        Me.btnFillOrder.Location = New System.Drawing.Point(234, 344)
        Me.btnFillOrder.Name = "btnFillOrder"
        Me.btnFillOrder.Size = New System.Drawing.Size(105, 28)
        Me.btnFillOrder.TabIndex = 7
        Me.btnFillOrder.Text = "注文の入力"
        Me.btnFillOrder.UseVisualStyleBackColor = True
        '
        'btnFinishUpdates
        '
        Me.btnFinishUpdates.AutoSize = True
        Me.btnFinishUpdates.Location = New System.Drawing.Point(547, 347)
        Me.btnFinishUpdates.Name = "btnFinishUpdates"
        Me.btnFinishUpdates.Size = New System.Drawing.Size(75, 28)
        Me.btnFinishUpdates.TabIndex = 8
        Me.btnFinishUpdates.Text = "完了"
        Me.btnFinishUpdates.UseVisualStyleBackColor = True
        '
        'FillOrCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 393)
        Me.Controls.Add(Me.btnFinishUpdates)
        Me.Controls.Add(Me.btnFillOrder)
        Me.Controls.Add(Me.ButtonbtnCancelOrder)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me.dtpFillDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFindByOrderID)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FillOrCancel"
        Me.Text = "FillOrCancel"
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents btnFindByOrderID As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFillDate As DateTimePicker
    Friend WithEvents dgvCustomerOrders As DataGridView
    Friend WithEvents ButtonbtnCancelOrder As Button
    Friend WithEvents btnFillOrder As Button
    Friend WithEvents btnFinishUpdates As Button
End Class
