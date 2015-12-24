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
        Me.TextBoxSId = New System.Windows.Forms.TextBox()
        Me.Calc = New System.Windows.Forms.Button()
        Me.TextBoxAnswer = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxSId
        '
        Me.TextBoxSId.Location = New System.Drawing.Point(64, 44)
        Me.TextBoxSId.Name = "TextBoxSId"
        Me.TextBoxSId.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSId.TabIndex = 0
        '
        'Calc
        '
        Me.Calc.Location = New System.Drawing.Point(64, 97)
        Me.Calc.Name = "Calc"
        Me.Calc.Size = New System.Drawing.Size(75, 23)
        Me.Calc.TabIndex = 1
        Me.Calc.Text = "Calc!"
        Me.Calc.UseVisualStyleBackColor = True
        '
        'TextBoxAnswer
        '
        Me.TextBoxAnswer.Location = New System.Drawing.Point(64, 159)
        Me.TextBoxAnswer.Name = "TextBoxAnswer"
        Me.TextBoxAnswer.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxAnswer.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 19)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "入力例: 1H15A010"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxAnswer)
        Me.Controls.Add(Me.Calc)
        Me.Controls.Add(Me.TextBoxSId)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxSId As System.Windows.Forms.TextBox
    Friend WithEvents Calc As System.Windows.Forms.Button
    Friend WithEvents TextBoxAnswer As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
