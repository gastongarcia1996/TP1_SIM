<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionTabla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rb_jiCuadrado = New System.Windows.Forms.RadioButton()
        Me.rb_ks = New System.Windows.Forms.RadioButton()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rb_jiCuadrado
        '
        Me.rb_jiCuadrado.AutoSize = True
        Me.rb_jiCuadrado.Checked = True
        Me.rb_jiCuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_jiCuadrado.Location = New System.Drawing.Point(63, 31)
        Me.rb_jiCuadrado.Name = "rb_jiCuadrado"
        Me.rb_jiCuadrado.Size = New System.Drawing.Size(110, 20)
        Me.rb_jiCuadrado.TabIndex = 0
        Me.rb_jiCuadrado.TabStop = True
        Me.rb_jiCuadrado.Text = "Ji Cuadrado"
        Me.rb_jiCuadrado.UseVisualStyleBackColor = True
        '
        'rb_ks
        '
        Me.rb_ks.AutoSize = True
        Me.rb_ks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_ks.Location = New System.Drawing.Point(254, 31)
        Me.rb_ks.Name = "rb_ks"
        Me.rb_ks.Size = New System.Drawing.Size(45, 20)
        Me.rb_ks.TabIndex = 1
        Me.rb_ks.TabStop = True
        Me.rb_ks.Text = "KS"
        Me.rb_ks.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Location = New System.Drawing.Point(164, 78)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'SeleccionTabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 113)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.rb_ks)
        Me.Controls.Add(Me.rb_jiCuadrado)
        Me.Name = "SeleccionTabla"
        Me.Text = "SeleccionTabla"
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Friend WithEvents rb_jiCuadrado As RadioButton
    Friend WithEvents rb_ks As RadioButton
    Friend WithEvents btn_aceptar As Button
End Class
