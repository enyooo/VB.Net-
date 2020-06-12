<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClickThis = New System.Windows.Forms.Button()
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClickThis
        '
        Me.btnClickThis.Location = New System.Drawing.Point(225, 135)
        Me.btnClickThis.Name = "btnClickThis"
        Me.btnClickThis.Size = New System.Drawing.Size(117, 38)
        Me.btnClickThis.TabIndex = 0
        Me.btnClickThis.Text = "Click this"
        Me.btnClickThis.UseVisualStyleBackColor = True
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.AutoSize = True
        Me.lblHelloWorld.Location = New System.Drawing.Point(254, 227)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(58, 18)
        Me.lblHelloWorld.TabIndex = 1
        Me.lblHelloWorld.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHelloWorld)
        Me.Controls.Add(Me.btnClickThis)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickThis As Button
    Friend WithEvents lblHelloWorld As Label
End Class
