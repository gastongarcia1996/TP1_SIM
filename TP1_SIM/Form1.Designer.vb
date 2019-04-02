<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_comenzar = New System.Windows.Forms.Button()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.lbl_m = New System.Windows.Forms.Label()
        Me.txt_m = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_x = New System.Windows.Forms.Label()
        Me.txt_x = New System.Windows.Forms.TextBox()
        Me.btn_grafico = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cantNum = New System.Windows.Forms.TextBox()
        Me.rb_mixto = New System.Windows.Forms.RadioButton()
        Me.rb_multiplicativo = New System.Windows.Forms.RadioButton()
        Me.btn_tablas = New System.Windows.Forms.Button()
        Me.rb_lenguaje = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(132, 555)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 23)
        Me.btn_next.TabIndex = 9
        Me.btn_next.Text = "Siguiente"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_comenzar
        '
        Me.btn_comenzar.Location = New System.Drawing.Point(30, 555)
        Me.btn_comenzar.Name = "btn_comenzar"
        Me.btn_comenzar.Size = New System.Drawing.Size(75, 23)
        Me.btn_comenzar.TabIndex = 0
        Me.btn_comenzar.Text = "Comenzar"
        Me.btn_comenzar.UseVisualStyleBackColor = True
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_a.Location = New System.Drawing.Point(30, 27)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(95, 16)
        Me.lbl_a.TabIndex = 11
        Me.lbl_a.Text = "Constante A:"
        '
        'txt_a
        '
        Me.txt_a.Location = New System.Drawing.Point(131, 26)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(100, 20)
        Me.txt_a.TabIndex = 1
        Me.txt_a.Text = "16807"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Constante C:"
        '
        'txt_c
        '
        Me.txt_c.Location = New System.Drawing.Point(129, 67)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(100, 20)
        Me.txt_c.TabIndex = 2
        Me.txt_c.Text = "43"
        '
        'lbl_m
        '
        Me.lbl_m.AutoSize = True
        Me.lbl_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_m.Location = New System.Drawing.Point(56, 153)
        Me.lbl_m.Name = "lbl_m"
        Me.lbl_m.Size = New System.Drawing.Size(67, 16)
        Me.lbl_m.TabIndex = 9
        Me.lbl_m.Text = "Muestra:"
        '
        'txt_m
        '
        Me.txt_m.Location = New System.Drawing.Point(129, 152)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.Size = New System.Drawing.Size(100, 20)
        Me.txt_m.TabIndex = 4
        Me.txt_m.Text = "2147483647"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 206)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(465, 292)
        Me.ListBox1.TabIndex = 8
        '
        'lbl_x
        '
        Me.lbl_x.AutoSize = True
        Me.lbl_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_x.Location = New System.Drawing.Point(59, 112)
        Me.lbl_x.Name = "lbl_x"
        Me.lbl_x.Size = New System.Drawing.Size(64, 16)
        Me.lbl_x.TabIndex = 4
        Me.lbl_x.Text = "Semilla:"
        '
        'txt_x
        '
        Me.txt_x.Location = New System.Drawing.Point(129, 111)
        Me.txt_x.Name = "txt_x"
        Me.txt_x.Size = New System.Drawing.Size(100, 20)
        Me.txt_x.TabIndex = 3
        Me.txt_x.Text = "123457"
        '
        'btn_grafico
        '
        Me.btn_grafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_grafico.Location = New System.Drawing.Point(402, 555)
        Me.btn_grafico.Name = "btn_grafico"
        Me.btn_grafico.Size = New System.Drawing.Size(75, 23)
        Me.btn_grafico.TabIndex = 15
        Me.btn_grafico.Text = "Grafico"
        Me.btn_grafico.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Datos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cantidad de numeros"
        '
        'txt_cantNum
        '
        Me.txt_cantNum.Location = New System.Drawing.Point(319, 46)
        Me.txt_cantNum.Name = "txt_cantNum"
        Me.txt_cantNum.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantNum.TabIndex = 19
        Me.txt_cantNum.Text = "100"
        '
        'rb_mixto
        '
        Me.rb_mixto.AutoSize = True
        Me.rb_mixto.Checked = True
        Me.rb_mixto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_mixto.Location = New System.Drawing.Point(319, 88)
        Me.rb_mixto.Name = "rb_mixto"
        Me.rb_mixto.Size = New System.Drawing.Size(62, 20)
        Me.rb_mixto.TabIndex = 20
        Me.rb_mixto.TabStop = True
        Me.rb_mixto.Text = "Mixto"
        Me.rb_mixto.UseVisualStyleBackColor = True
        '
        'rb_multiplicativo
        '
        Me.rb_multiplicativo.AutoSize = True
        Me.rb_multiplicativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_multiplicativo.Location = New System.Drawing.Point(319, 114)
        Me.rb_multiplicativo.Name = "rb_multiplicativo"
        Me.rb_multiplicativo.Size = New System.Drawing.Size(117, 20)
        Me.rb_multiplicativo.TabIndex = 21
        Me.rb_multiplicativo.Text = "Multiplicativo"
        Me.rb_multiplicativo.UseVisualStyleBackColor = True
        '
        'btn_tablas
        '
        Me.btn_tablas.Location = New System.Drawing.Point(306, 555)
        Me.btn_tablas.Name = "btn_tablas"
        Me.btn_tablas.Size = New System.Drawing.Size(75, 23)
        Me.btn_tablas.TabIndex = 22
        Me.btn_tablas.Text = "Tablas"
        Me.btn_tablas.UseVisualStyleBackColor = True
        '
        'rb_lenguaje
        '
        Me.rb_lenguaje.AutoSize = True
        Me.rb_lenguaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_lenguaje.Location = New System.Drawing.Point(319, 140)
        Me.rb_lenguaje.Name = "rb_lenguaje"
        Me.rb_lenguaje.Size = New System.Drawing.Size(90, 20)
        Me.rb_lenguaje.TabIndex = 23
        Me.rb_lenguaje.Text = "Lenguaje"
        Me.rb_lenguaje.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 613)
        Me.Controls.Add(Me.rb_lenguaje)
        Me.Controls.Add(Me.btn_tablas)
        Me.Controls.Add(Me.rb_multiplicativo)
        Me.Controls.Add(Me.rb_mixto)
        Me.Controls.Add(Me.txt_cantNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_grafico)
        Me.Controls.Add(Me.txt_x)
        Me.Controls.Add(Me.lbl_x)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txt_m)
        Me.Controls.Add(Me.lbl_m)
        Me.Controls.Add(Me.txt_c)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_a)
        Me.Controls.Add(Me.lbl_a)
        Me.Controls.Add(Me.btn_comenzar)
        Me.Controls.Add(Me.btn_next)
        Me.Name = "Form1"
        Me.Text = "Numeros Aleatorios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_next As Button
    Friend WithEvents btn_comenzar As Button
    Friend WithEvents lbl_a As Label
    Friend WithEvents txt_a As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_c As TextBox
    Friend WithEvents lbl_m As Label
    Friend WithEvents txt_m As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lbl_x As Label
    Friend WithEvents txt_x As TextBox
    Friend WithEvents btn_grafico As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cantNum As TextBox
    Friend WithEvents rb_mixto As RadioButton
    Friend WithEvents rb_multiplicativo As RadioButton
    Friend WithEvents btn_tablas As Button
    Friend WithEvents rb_lenguaje As RadioButton
End Class
