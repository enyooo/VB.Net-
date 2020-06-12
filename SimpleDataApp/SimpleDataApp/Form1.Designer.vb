<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ナビゲーション
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
        Me.btnGoToAdd = New System.Windows.Forms.Button()
        Me.btnGoToFillOrCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGoToAdd
        '
        Me.btnGoToAdd.AutoSize = True
        Me.btnGoToAdd.Location = New System.Drawing.Point(139, 108)
        Me.btnGoToAdd.Name = "btnGoToAdd"
        Me.btnGoToAdd.Size = New System.Drawing.Size(169, 35)
        Me.btnGoToAdd.TabIndex = 0
        Me.btnGoToAdd.Text = "アカウントの追加"
        Me.btnGoToAdd.UseVisualStyleBackColor = True
        '
        'btnGoToFillOrCancel
        '
        Me.btnGoToFillOrCancel.AutoSize = True
        Me.btnGoToFillOrCancel.Location = New System.Drawing.Point(125, 192)
        Me.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel"
        Me.btnGoToFillOrCancel.Size = New System.Drawing.Size(208, 28)
        Me.btnGoToFillOrCancel.TabIndex = 1
        Me.btnGoToFillOrCancel.Text = "注文の入力または取り消し"
        Me.btnGoToFillOrCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(327, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 28)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "終了"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "実行する操作"
        '
        'ナビゲーション
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 399)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGoToFillOrCancel)
        Me.Controls.Add(Me.btnGoToAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ナビゲーション"
        Me.Text = "ようこそ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoToAdd As Button
    Friend WithEvents btnGoToFillOrCancel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
