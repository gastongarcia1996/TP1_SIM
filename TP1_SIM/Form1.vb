Public Class Form1

    Private paramA As Double
    Private paramC As Double
    Private paramX As Double
    Private paramX2 As Double
    Private paramM As Double
    Private aleatorio As Double = 0
    Private flag As Boolean = False
    Private cantNum As Integer = 0
    Private dp As New DataVisualization.Charting.DataPoint()
    Private acumuladorMixto As Double = 0.0
    Private acumuladorLenguaje As Double = 0.0
    Private conti(-1) As Integer
    Private conti2(-1) As Integer
    Private contLenguaje(-1) As Integer
    Private IOArchivo As New IOArchivo
    Private numIntervalos As Integer
    Public datosArchivoJI() As String
    Public datosArchivoKS() As String

    Dim grafico As New Grafico
    Public tabla As New Tabla
    Dim seleccionTabla As New SeleccionTabla(Me)
    Dim random As New Random()

    Public Sub New()
        Me.datosArchivoJI = Me.IOArchivo.LeerArchivo("C:\Users\gasto\source\repos\TP1_SIM\tablaJI.txt") 'Acordarse de cambiar las rutas
        Me.datosArchivoKS = Me.IOArchivo.LeerArchivo("C:\Users\gasto\source\repos\TP1_SIM\tablaKS.txt")


        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btn_comenzar_Click(sender As Object, e As EventArgs) Handles btn_comenzar.Click

        ReDim conti(Integer.Parse(Me.txt_numIntervalos.Text) - 1)
        ReDim conti2(Integer.Parse(Me.txt_numIntervalos.Text) - 1)
        ReDim contLenguaje(Integer.Parse(Me.txt_numIntervalos.Text) - 1)

        Dim cont As Integer = 0
        If VerificarTextBox() Then
            Return

        ElseIf flag Then
            LeerTextBox()
            Me.flag = False
        End If

        'Aleatorios del congruencial mixto
        If Me.rb_mixto.Checked = True Then
            While cont < Integer.Parse(Me.txt_cantNum.Text)
                GenerarAleatoriosMixto()
                Me.ListBox1.Items.Add(Me.aleatorio)

                Me.acumuladorMixto += Me.aleatorio

                For i As Integer = 0 To conti.Length - 1

                    If Me.aleatorio < (1 / conti.Length) * i Then
                        conti(i - 1) += 1
                        Exit For


                    ElseIf Me.aleatorio > (conti.Length - 1) / conti.Length Then
                        conti(conti.Length - 1) += 1
                        Exit For
                    End If
                Next

                'Select Case Me.aleatorio
                '    Case 0 To 0.1
                '        Me.conti(0) += 1
                '    Case 0.1 To 0.2
                '        Me.conti(1) += 1
                '    Case 0.2 To 0.3
                '        Me.conti(2) += 1
                '    Case 0.3 To 0.4
                '        Me.conti(3) += 1
                '    Case 0.4 To 0.5
                '        Me.conti(4) += 1
                '    Case 0.5 To 0.6
                '        Me.conti(5) += 1
                '    Case 0.6 To 0.7
                '        Me.conti(6) += 1
                '    Case 0.7 To 0.8
                '        Me.conti(7) += 1
                '    Case 0.8 To 0.9
                '        Me.conti(8) += 1
                '    Case 0.9 To 1
                '        Me.conti(9) += 1
                'End Select

                cont += 1
            End While
        End If

        Me.cantNum += cont

        cont = 0

        'Aleatorios del congruencial multiplicativo
        If Me.rb_multiplicativo.Checked = True Then
            While cont < Integer.Parse(Me.txt_cantNum.Text)
                GenerarAleatoriosMultiplicativo()
                Me.ListBox1.Items.Add(Me.aleatorio)


                For i As Integer = 0 To conti2.Length - 1

                    If Me.aleatorio < (1 / conti2.Length) * i Then
                        conti2(i - 1) += 1
                        Exit For


                    ElseIf Me.aleatorio > (conti2.Length - 1) / conti2.Length Then
                        conti2(conti2.Length - 1) += 1
                        Exit For
                    End If
                Next

                'Select Case Me.aleatorio
                '    Case 0 To 0.1
                '        Me.conti2(0) += 1
                '    Case 0.1 To 0.2
                '        Me.conti2(1) += 1
                '    Case 0.2 To 0.3
                '        Me.conti2(2) += 1
                '    Case 0.3 To 0.4
                '        Me.conti2(3) += 1
                '    Case 0.4 To 0.5
                '        Me.conti2(4) += 1
                '    Case 0.5 To 0.6
                '        Me.conti2(5) += 1
                '    Case 0.6 To 0.7
                '        Me.conti2(6) += 1
                '    Case 0.7 To 0.8
                '        Me.conti2(7) += 1
                '    Case 0.8 To 0.9
                '        Me.conti2(8) += 1
                '    Case 0.9 To 1
                '        Me.conti2(9) += 1
                'End Select

                cont += 1
            End While

        End If

        'Aleatorios del Lenguaje
        If Me.rb_lenguaje.Checked = True Then
            While cont < Integer.Parse(Me.txt_cantNum.Text)
                Me.aleatorio = random.Next(1, 9999) / 10000
                Me.ListBox1.Items.Add(Me.aleatorio)

                acumuladorLenguaje += Me.aleatorio


                For i As Integer = 0 To contLenguaje.Length - 1

                    If Me.aleatorio < (1 / contLenguaje.Length) * i Then
                        contLenguaje(i - 1) += 1
                        Exit For


                    ElseIf Me.aleatorio > (conti.Length - 1) / contLenguaje.Length Then
                        contLenguaje(contLenguaje.Length - 1) += 1
                        Exit For
                    End If
                Next

                'Select Case Me.aleatorio
                '    Case 0 To 0.1
                '        Me.contLenguaje(0) += 1
                '    Case 0.1 To 0.2
                '        Me.contLenguaje(1) += 1
                '    Case 0.2 To 0.3
                '        Me.contLenguaje(2) += 1
                '    Case 0.3 To 0.4
                '        Me.contLenguaje(3) += 1
                '    Case 0.4 To 0.5
                '        Me.contLenguaje(4) += 1
                '    Case 0.5 To 0.6
                '        Me.contLenguaje(5) += 1
                '    Case 0.6 To 0.7
                '        Me.contLenguaje(6) += 1
                '    Case 0.7 To 0.8
                '        Me.contLenguaje(7) += 1
                '    Case 0.8 To 0.9
                '        Me.contLenguaje(8) += 1
                '    Case 0.9 To 1
                '        Me.contLenguaje(9) += 1
                'End Select

                cont += 1
            End While
        End If
        Me.cantNum += cont
        Me.numIntervalos = Integer.Parse(Me.txt_numIntervalos.Text)
        Me.ListBox1.TopIndex = ListBox1.Items.Count - 1
    End Sub
    'Genera el numero aleatorio mixto
    Sub GenerarAleatoriosMixto()

        Dim rand As Double = (Me.paramA * Me.paramX + Me.paramC) Mod Me.paramM

        Me.aleatorio = rand / paramM
        Me.paramX = rand
    End Sub
    'Genera el numero aleatorio multiplicativo
    Sub GenerarAleatoriosMultiplicativo()
        Dim rand As Double = (Me.paramA * Me.paramX2) Mod Me.paramM

        Me.aleatorio = rand / Me.paramM
        Me.paramX2 = rand
    End Sub

    'Se verificar que las cajas de texto no esten vacias
    Function VerificarTextBox() As Boolean
        Dim aux As TextBox
        For Each controlesForm In Me.Controls
            If (TypeOf controlesForm Is TextBox) Then
                aux = controlesForm
                If aux.Text Is "" Then
                    MessageBox.Show("Complete los parametros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    'Aqui se obtiene el contenido de las cajas de texto
    Sub LeerTextBox()
        Me.paramA = Integer.Parse(Me.txt_a.Text)
        Me.paramC = Integer.Parse(Me.txt_c.Text)
        Me.paramX = Integer.Parse(Me.txt_x.Text)
        Me.paramX2 = Integer.Parse(Me.txt_x.Text)
        Me.paramM = Integer.Parse(Me.txt_m.Text)
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If VerificarTextBox() Then
            Return

        ElseIf flag Then
            LeerTextBox()
            Me.flag = False
        End If


        If Me.rb_mixto.Checked = True Then
            GenerarAleatoriosMixto()
            Me.ListBox1.Items.Add(Me.aleatorio)

            Me.acumuladorMixto += Me.aleatorio

            For i As Integer = 0 To conti.Length - 1

                If Me.aleatorio < (1 / conti.Length) * i Then
                    conti(i - 1) += 1
                    Exit For


                ElseIf Me.aleatorio > (conti.Length - 1) / conti.Length Then
                    conti(conti.Length - 1) += 1
                    Exit For
                End If
            Next

            'Select Case Me.aleatorio
            '    Case 0 To 0.1
            '        Me.conti(0) += 1
            '    Case 0.1 To 0.2
            '        Me.conti(1) += 1
            '    Case 0.2 To 0.3
            '        Me.conti(2) += 1
            '    Case 0.3 To 0.4
            '        Me.conti(3) += 1
            '    Case 0.4 To 0.5
            '        Me.conti(4) += 1
            '    Case 0.5 To 0.6
            '        Me.conti(5) += 1
            '    Case 0.6 To 0.7
            '        Me.conti(6) += 1
            '    Case 0.7 To 0.8
            '        Me.conti(7) += 1
            '    Case 0.8 To 0.9
            '        Me.conti(8) += 1
            '    Case 0.9 To 1
            '        Me.conti(9) += 1
            'End Select

            Me.ListBox1.TopIndex = ListBox1.Items.Count - 1

        End If


        If Me.rb_multiplicativo.Checked = True Then
            GenerarAleatoriosMultiplicativo()
            Me.ListBox1.Items.Add(Me.aleatorio)
            Me.ListBox1.TopIndex = ListBox1.Items.Count - 1

            For i As Integer = 0 To conti2.Length - 1

                If Me.aleatorio < (1 / conti2.Length) * i Then
                    conti2(i - 1) += 1
                    Exit For


                ElseIf Me.aleatorio > (conti2.Length - 1) / conti2.Length Then
                    conti2(conti2.Length - 1) += 1
                    Exit For
                End If
            Next
            'Select Case Me.aleatorio
            '    Case 0 To 0.1
            '        Me.conti2(0) += 1
            '    Case 0.1 To 0.2
            '        Me.conti2(1) += 1
            '    Case 0.2 To 0.3
            '        Me.conti2(2) += 1
            '    Case 0.3 To 0.4
            '        Me.conti2(3) += 1
            '    Case 0.4 To 0.5
            '        Me.conti2(4) += 1
            '    Case 0.5 To 0.6
            '        Me.conti2(5) += 1
            '    Case 0.6 To 0.7
            '        Me.conti2(6) += 1
            '    Case 0.7 To 0.8
            '        Me.conti2(7) += 1
            '    Case 0.8 To 0.9
            '        Me.conti2(8) += 1
            '    Case 0.9 To 1
            '        Me.conti2(9) += 1
            'End Select
        End If

        If Me.rb_lenguaje.Checked = True Then

            Me.aleatorio = random.Next(1, 9999) / 10000
            Me.ListBox1.Items.Add(Me.aleatorio)
            acumuladorLenguaje += Me.aleatorio


            For i As Integer = 0 To contLenguaje.Length - 1

                If Me.aleatorio < (1 / contLenguaje.Length) * i Then
                    contLenguaje(i - 1) += 1
                    Exit For


                ElseIf Me.aleatorio > (contLenguaje.Length - 1) / contLenguaje.Length Then
                    contLenguaje(contLenguaje.Length - 1) += 1
                    Exit For
                End If
            Next

            'Select Case Me.aleatorio
            '    Case 0 To 0.1
            '        Me.contLenguaje(0) += 1
            '    Case 0.1 To 0.2
            '        Me.contLenguaje(1) += 1
            '    Case 0.2 To 0.3
            '        Me.contLenguaje(2) += 1
            '    Case 0.3 To 0.4
            '        Me.contLenguaje(3) += 1
            '    Case 0.4 To 0.5
            '        Me.contLenguaje(4) += 1
            '    Case 0.5 To 0.6
            '        Me.contLenguaje(5) += 1
            '    Case 0.6 To 0.7
            '        Me.contLenguaje(6) += 1
            '    Case 0.7 To 0.8
            '        Me.contLenguaje(7) += 1
            '    Case 0.8 To 0.9
            '        Me.contLenguaje(8) += 1
            '    Case 0.9 To 1
            '        Me.contLenguaje(9) += 1
            'End Select

        End If
        Me.cantNum += 1
        Me.numIntervalos = Integer.Parse(Me.txt_numIntervalos.Text)
        Me.ListBox1.TopIndex = ListBox1.Items.Count - 1
    End Sub

    'Evento que se activa cuando el texto del textBox cambia
    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt_a.TextChanged, txt_c.TextChanged, txt_x.TextChanged, txt_m.TextChanged, txt_cantNum.TextChanged, txt_numIntervalos.TextChanged
        Me.flag = True

        If Me.ListBox1.Items.Count > 0 Then
            Me.ListBox1.Items.Clear()
            Me.tabla.DataGridView1.Rows.Clear()
        End If
    End Sub

    'sub rutina que se activa al hacer click en el boton grafico, grafica solo mixto y lenguaje
    Private Sub btn_grafico_Click(sender As Object, e As EventArgs) Handles btn_grafico.Click

        If rb_multiplicativo.Checked = True Then

            For i As Integer = 0 To 9
                conti(i) = 0
            Next

            Me.acumuladorMixto = 0.0
            Me.cantNum = 0

        Else
            grafico.Show()
            CompletarGrafico()
        End If

        If rb_lenguaje.Checked = True Then

            grafico.Show()
            CompletarGrafico()
        End If
    End Sub

    Private Sub CompletarGrafico()

        Dim aux As Integer = Me.cantNum / Me.conti.Length
        Dim media As Double = 0.0
        Dim cont As Integer = 0
        Dim acu As Double = 0.0

        If Me.rb_mixto.Checked = True Then
            media = Me.acumuladorMixto / Me.cantNum
        ElseIf Me.rb_lenguaje.Checked = True Then
            media = Me.acumuladorLenguaje / Me.cantNum
        End If


        'Si es congruencial mixto
        If Me.rb_mixto.Checked = True Then

            Me.grafico.Chart1.Series(0).Points.Clear() 'Limpia el grafico serie 1 (azul)


            'Completa el grafico congruencial mixto   
            'For i As Double = 0.1 To 1.0 Step 0.1
            '    Me.grafico.Chart1.Series(0).Points.AddXY("" & i, Me.conti((i - 0.1) * 10))
            'Next

            For i As Double = 1 / Me.conti.Length To 1.0 Step 1 / Me.conti.Length
                Me.grafico.Chart1.Series(0).Points.AddXY("" & i, Me.conti((i / (1 / Me.conti.Length)) - 1))
            Next

            Me.grafico.Chart1.Series(1).Points.Clear()

            'For i As Double = 0.1 To 1.0 Step 0.1
            '    Me.grafico.Chart1.Series(1).Points.AddXY("" & i, aux)
            'Next

            For i As Double = 1 / Me.conti.Length To 1.0 Step 1 / Me.conti.Length
                Me.grafico.Chart1.Series(1).Points.AddXY("" & i, aux)
            Next

            'Si es del lenguaje
        ElseIf Me.rb_lenguaje.Checked = True Then

            Me.grafico.Chart1.Series(0).Points.Clear() 'Limpia el grafico serie 1 (azul)


            'Completa el grafico para los aleatorios generados por el lenaguaje
            'For i As Double = 0.1 To 1.0 Step 0.1
            '    Me.grafico.Chart1.Series(0).Points.AddXY("" & i, Me.contLenguaje((i - 0.1) * 10))
            'Next

            For i As Double = 1 / Me.contLenguaje.Length To 1.0 Step 1 / Me.contLenguaje.Length
                Me.grafico.Chart1.Series(0).Points.AddXY("" & i, Me.contLenguaje((i / (1 / Me.contLenguaje.Length)) - 1))
            Next

            Me.grafico.Chart1.Series(1).Points.Clear()

            'For i As Double = 0.1 To 1.0 Step 0.1
            '    Me.grafico.Chart1.Series(1).Points.AddXY("" & i, aux)
            'Next

            For i As Double = 1 / Me.contLenguaje.Length To 1.0 Step 1 / Me.contLenguaje.Length
                Me.grafico.Chart1.Series(1).Points.AddXY("" & i, aux)
            Next
        End If




        Me.grafico.lbl_numMedia.Text = Math.Truncate((media * 10000)) / 10000

        While cont < ListBox1.Items.Count
            acu += Math.Pow(Me.ListBox1.Items(cont) - media, 2)

            cont += 1
        End While

        Me.grafico.lbl_numVarianza.Text = Math.Truncate((acu / Me.cantNum) * 10000) / 10000

    End Sub

    'Realiza el trabajo de completar la tabla, llenando las filas correspondientes
    Public Sub CompletarTabla(ByVal flag As Boolean)
        'Variables auxiliares para calcular chi-cuadrado y ks (vease las formulas de chi-cuadrado y ks)
        Dim ji_cuadrado As Double = 0.0
        Dim ks As Double = 0.0
        Dim aux As Double = 0.0
        Dim acumuladorFrecuencias As Double = 0.0
        Dim frao As Double = 0.0
        Dim frae As Double = 0.0
        Dim maxKs As Double = 0.0
        Dim indiceMaxKs As Integer = 0

        'Si es Ji cuadrado
        If flag = True Then
            'For i As Double = 0.1 To 1 Step 0.1
            '    Me.tabla.DataGridView1.Rows(i * 10 - 1).Cells(0).Value = i
            'Next

            For i As Double = 1 / Me.conti.Length To 1.0 Step 1 / Me.conti.Length
                Me.tabla.DataGridView1.Rows(i / (1 / Me.conti.Length) - 1).Cells(0).Value = i
            Next

            For i As Integer = 0 To Me.conti.Length - 1
                Me.tabla.DataGridView1.Rows(i).Cells(2).Value = 1 / Me.conti.Length
            Next
            'Si es mixto
            If Me.rb_mixto.Checked = True Then
                For i As Integer = 0 To Me.conti.Length - 1
                    Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.conti(i) & "/" & Me.cantNum
                Next

                If cantNum <> 0 Then
                    For i As Integer = 0 To Me.conti.Length - 1
                        aux = Math.Truncate((Math.Pow((Me.conti(i) / Me.cantNum) - (1 / Me.conti.Length), 2) / (1 / Me.conti.Length)) * 100000) / 100000
                        Me.tabla.DataGridView1.Rows(i).Cells(3).Value = aux
                        ji_cuadrado += aux
                    Next

                Else
                    For i As Integer = 0 To Me.conti.Length - 1
                        Me.tabla.DataGridView1.Rows(i).Cells(3).Value = 0
                    Next
                End If

                'Si es multiplicativo
            ElseIf Me.rb_multiplicativo.Checked = True Then

                For i As Integer = 0 To Me.conti2.Length - 1
                    Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.conti2(i) & "/" & Me.cantNum
                Next

                If cantNum <> 0 Then
                    For i As Integer = 0 To Me.conti2.Length - 1
                        aux = Math.Truncate((Math.Pow((Me.conti2(i) / Me.cantNum) - (1 / Me.conti.Length), 2) / (1 / Me.conti.Length)) * 100000) / 100000
                        Me.tabla.DataGridView1.Rows(i).Cells(3).Value = aux
                        ji_cuadrado += aux
                    Next

                Else
                    For i As Integer = 0 To Me.conti2.Length - 1
                        Me.tabla.DataGridView1.Rows(i).Cells(3).Value = 0
                    Next
                End If

                'Si es el del lenguaje
            ElseIf Me.rb_lenguaje.Checked = True Then
                For i As Integer = 0 To Me.conti2.Length - 1
                    Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.contLenguaje(i) & "/" & Me.cantNum
                Next

                If cantNum <> 0 Then
                    'Calculo de chi-cuadrado
                    For i As Integer = 0 To Me.conti2.Length - 1
                        aux = Math.Truncate((Math.Pow((Me.contLenguaje(i) / Me.cantNum) - (1 / Me.conti.Length), 2) / (1 / Me.conti.Length)) * 100000) / 100000
                        Me.tabla.DataGridView1.Rows(i).Cells(3).Value = aux
                        ji_cuadrado += aux
                    Next

                Else
                    For i As Integer = 0 To 9
                        Me.tabla.DataGridView1.Rows(i).Cells(3).Value = 0
                    Next
                End If
            End If




            Me.tabla.DataGridView1.Rows(Me.conti.Length).Cells(3).Value = ji_cuadrado

        Else
            'Si es KS

            For i As Double = 1 / Me.conti.Length To 1.0 Step 1 / Me.conti.Length
                Me.tabla.DataGridView1.Rows(i / (1 / Me.conti.Length) - 1).Cells(0).Value = i
            Next

            For i As Integer = 0 To Me.conti.Length - 1
                Me.tabla.DataGridView1.Rows(i).Cells(2).Value = 1 / Me.conti.Length
            Next

            If Me.rb_mixto.Checked = True Then
                For i As Integer = 0 To Me.conti2.Length - 1
                    Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.conti(i) & "/" & Me.cantNum
                Next

                If cantNum <> 0 Then

                    For i As Integer = 0 To Me.conti2.Length - 1
                        acumuladorFrecuencias += Me.conti(i) / Me.cantNum
                        Me.tabla.DataGridView1.Rows(i).Cells(4).Value = acumuladorFrecuencias
                    Next

                Else
                    For i As Integer = 0 To Me.conti2.Length - 1
                        Me.tabla.DataGridView1.Rows(i).Cells(4).Value = 0
                    Next
                End If
            ElseIf Me.rb_multiplicativo.Checked = True Then

                For i As Integer = 0 To Me.conti2.Length - 1
                    Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.conti2(i) & "/" & Me.cantNum
                Next

                If cantNum <> 0 Then

                    For i As Integer = 0 To Me.conti2.Length - 1
                        acumuladorFrecuencias += Me.conti2(i) / Me.cantNum
                        Me.tabla.DataGridView1.Rows(i).Cells(4).Value = acumuladorFrecuencias
                    Next

                Else
                    For i As Integer = 0 To Me.conti2.Length - 1
                        Me.tabla.DataGridView1.Rows(i).Cells(4).Value = 0
                    Next
                End If

            ElseIf Me.rb_lenguaje.Checked = True Then
                For i As Integer = 0 To Me.contLenguaje.Length - 1
                    Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.contLenguaje(i) & "/" & Me.cantNum
                Next

                If cantNum <> 0 Then
                    For i As Integer = 0 To Me.contLenguaje.Length - 1
                        acumuladorFrecuencias += Me.contLenguaje(i) / Me.cantNum
                        Me.tabla.DataGridView1.Rows(i).Cells(4).Value = acumuladorFrecuencias
                    Next

                Else
                    For i As Integer = 0 To Me.contLenguaje.Length - 1
                        Me.tabla.DataGridView1.Rows(i).Cells(4).Value = 0
                    Next
                End If
            End If

            acumuladorFrecuencias = 0.0
            For j As Integer = 0 To Me.contLenguaje.Length - 1

                acumuladorFrecuencias += Double.Parse(Me.tabla.DataGridView1.Rows(j).Cells(2).Value)
                Me.tabla.DataGridView1.Rows(j).Cells(5).Value = acumuladorFrecuencias
            Next

            For k As Integer = 0 To Me.contLenguaje.Length - 1

                frao = Double.Parse(Me.tabla.DataGridView1.Rows(k).Cells(4).Value)
                frae = Double.Parse(Me.tabla.DataGridView1.Rows(k).Cells(5).Value)
                maxKs = Math.Abs(frao - frae)

                If ks < maxKs Then
                    ks = maxKs
                    indiceMaxKs = k
                End If

                Me.tabla.DataGridView1.Rows(k).Cells(6).Value = Math.Abs(maxKs)
            Next

            Me.tabla.DataGridView1.Rows(Me.contLenguaje.Length).Cells(6).Value = ks
        End If


    End Sub

    'Es un evento que se activa cuando se presiona una tecla para escribir en cualquier textBox
    Private Sub txt_a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_a.KeyPress, txt_c.KeyPress, txt_m.KeyPress, txt_x.KeyPress, txt_cantNum.KeyPress
        'Verifico que sean solo numeros en los textBox
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Este metodo lo que hace es habilitar o deshabilitar los txt dependiendo de los radio button
    Private Sub rb_multiplicativo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_multiplicativo.CheckedChanged, rb_lenguaje.CheckedChanged
        Me.ListBox1.Items.Clear()
        'Me.tabla.DataGridView1.Rows(10).Cells(3).Style.BackColor = Color.White


        If conti.Length > 0 Then
            For i As Integer = 0 To conti.Length - 1
                conti(i) = 0
                conti2(i) = 0
                contLenguaje(i) = 0
            Next
        End If

        Me.acumuladorMixto = 0.0
        Me.acumuladorLenguaje = 0.0
        Me.cantNum = 0
        Me.flag = True

        If Me.rb_lenguaje.Checked = True Then
            Me.txt_a.Enabled = False
            Me.txt_c.Enabled = False
            Me.txt_m.Enabled = False
            Me.txt_x.Enabled = False

        ElseIf Me.rb_multiplicativo.Checked = True Then
            Me.txt_c.Enabled = False
            Me.txt_m.Enabled = True
            Me.txt_x.Enabled = True
            Me.txt_a.Enabled = True
        Else
            Me.txt_a.Enabled = True
            Me.txt_c.Enabled = True
            Me.txt_m.Enabled = True
            Me.txt_x.Enabled = True

        End If
    End Sub

    Private Sub btn_tablas_Click(sender As Object, e As EventArgs) Handles btn_tablas.Click
        If Me.tabla.DataGridView1.Rows.Count = 0 Then
            For i As Integer = 0 To Me.conti.Length
                Me.tabla.DataGridView1.Rows.Add()
            Next
        End If
        seleccionTabla.Show()
    End Sub

    Public Function GetConti() As Integer()
        Return Me.conti
    End Function
End Class