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
    Private conti(10) As Integer
    Private conti2(10) As Integer

    Dim grafico As New Grafico
    Dim tabla As New Tabla

    Private Sub btn_comenzar_Click(sender As Object, e As EventArgs) Handles btn_comenzar.Click
        Dim cont As Integer = 0
        If VerificarTextBox() Then
            Return

        ElseIf flag Then
            LeerTextBox()
            Me.flag = False
        End If


        If Me.rb_mixto.Checked = True Then
            While cont < Integer.Parse(Me.txt_cantNum.Text)
                GenerarAleatoriosMixto()
                Me.ListBox1.Items.Add(Me.aleatorio)

                Me.acumuladorMixto += Me.aleatorio

                Select Case Me.aleatorio
                    Case 0 To 0.1
                        Me.conti(0) += 1
                    Case 0.1 To 0.2
                        Me.conti(1) += 1
                    Case 0.2 To 0.3
                        Me.conti(2) += 1
                    Case 0.3 To 0.4
                        Me.conti(3) += 1
                    Case 0.4 To 0.5
                        Me.conti(4) += 1
                    Case 0.5 To 0.6
                        Me.conti(5) += 1
                    Case 0.6 To 0.7
                        Me.conti(6) += 1
                    Case 0.7 To 0.8
                        Me.conti(7) += 1
                    Case 0.8 To 0.9
                        Me.conti(8) += 1
                    Case 0.9 To 1
                        Me.conti(9) += 1
                End Select

                cont += 1
            End While
        End If

        Me.cantNum += cont

        cont = 0

        If Me.rb_multiplicativo.Checked = True Then
            While cont < Integer.Parse(Me.txt_cantNum.Text)
                GenerarAleatoriosMultiplicativo()
                Me.ListBox1.Items.Add(Me.aleatorio)

                Select Case Me.aleatorio
                    Case 0 To 0.1
                        Me.conti2(0) += 1
                    Case 0.1 To 0.2
                        Me.conti2(1) += 1
                    Case 0.2 To 0.3
                        Me.conti2(2) += 1
                    Case 0.3 To 0.4
                        Me.conti2(3) += 1
                    Case 0.4 To 0.5
                        Me.conti2(4) += 1
                    Case 0.5 To 0.6
                        Me.conti2(5) += 1
                    Case 0.6 To 0.7
                        Me.conti2(6) += 1
                    Case 0.7 To 0.8
                        Me.conti2(7) += 1
                    Case 0.8 To 0.9
                        Me.conti2(8) += 1
                    Case 0.9 To 1
                        Me.conti2(9) += 1
                End Select

                cont += 1
            End While

            Me.cantNum += cont
        End If

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

            Select Case Me.aleatorio
                Case 0 To 0.1
                    Me.conti(0) += 1
                Case 0.1 To 0.2
                    Me.conti(1) += 1
                Case 0.2 To 0.3
                    Me.conti(2) += 1
                Case 0.3 To 0.4
                    Me.conti(3) += 1
                Case 0.4 To 0.5
                    Me.conti(4) += 1
                Case 0.5 To 0.6
                    Me.conti(5) += 1
                Case 0.6 To 0.7
                    Me.conti(6) += 1
                Case 0.7 To 0.8
                    Me.conti(7) += 1
                Case 0.8 To 0.9
                    Me.conti(8) += 1
                Case 0.9 To 1
                    Me.conti(9) += 1
            End Select

            Me.ListBox1.TopIndex = ListBox1.Items.Count - 1

            Me.cantNum += 1
        End If


        If Me.rb_multiplicativo.Checked = True Then
            GenerarAleatoriosMultiplicativo()
            Me.ListBox1.Items.Add(Me.aleatorio)
            Me.ListBox1.TopIndex = ListBox1.Items.Count - 1

            Select Case Me.aleatorio
                Case 0 To 0.1
                    Me.conti2(0) += 1
                Case 0.1 To 0.2
                    Me.conti2(1) += 1
                Case 0.2 To 0.3
                    Me.conti2(2) += 1
                Case 0.3 To 0.4
                    Me.conti2(3) += 1
                Case 0.4 To 0.5
                    Me.conti2(4) += 1
                Case 0.5 To 0.6
                    Me.conti2(5) += 1
                Case 0.6 To 0.7
                    Me.conti2(6) += 1
                Case 0.7 To 0.8
                    Me.conti2(7) += 1
                Case 0.8 To 0.9
                    Me.conti2(8) += 1
                Case 0.9 To 1
                    Me.conti2(9) += 1
            End Select
        End If
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt_a.TextChanged, txt_c.TextChanged, txt_x.TextChanged, txt_m.TextChanged, txt_cantNum.TextChanged
        Me.flag = True
    End Sub

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

    End Sub

    Private Sub CompletarGrafico()

        Dim aux As Integer = Me.cantNum / 10
        Dim media As Double = Me.acumuladorMixto / Me.cantNum
        Dim cont As Integer = 0
        Dim acu As Double = 0.0

        Me.grafico.Chart1.Series(0).Points.Clear()
        Me.grafico.Chart1.Series(0).Points.AddXY("0.1", Me.conti(0))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.2", Me.conti(1))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.3", Me.conti(2))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.4", Me.conti(3))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.5", Me.conti(4))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.6", Me.conti(5))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.7", Me.conti(6))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.8", Me.conti(7))
        Me.grafico.Chart1.Series(0).Points.AddXY("0.9", Me.conti(8))
        Me.grafico.Chart1.Series(0).Points.AddXY("1.0", Me.conti(9))

        Me.grafico.Chart1.Series(1).Points.Clear()
        Me.grafico.Chart1.Series(1).Points.AddXY("0.1", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.2", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.3", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.4", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.5", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.6", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.7", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.8", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("0.9", aux)
        Me.grafico.Chart1.Series(1).Points.AddXY("1.0", aux)

        Me.grafico.lbl_numMedia.Text = Math.Truncate((media * 10000)) / 10000

        While cont < ListBox1.Items.Count
            acu += Math.Pow(Me.ListBox1.Items(cont) - media, 2)

            cont += 1
        End While

        Me.grafico.lbl_numVarianza.Text = Math.Truncate((acu / Me.cantNum) * 10000) / 10000

    End Sub

    Private Sub CompletarTabla()
        Dim ji_cuadrado As Double = 0.0
        Dim aux As Double = 0.0


        If Me.rb_mixto.Checked = True Then
            For i As Double = 0.1 To 1 Step 0.1
                Me.tabla.DataGridView1.Rows(i * 10 - 1).Cells(0).Value = i
            Next

            For i As Integer = 0 To 9
                Me.tabla.DataGridView1.Rows(i).Cells(2).Value = 0.1
            Next

            For i As Integer = 0 To 9
                Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.conti(i) & "/" & Me.cantNum
            Next

            If cantNum <> 0 Then
                For i As Integer = 0 To 9
                    aux = Math.Truncate((Math.Pow((Me.conti(i) / Me.cantNum) - 0.1, 2) / 0.1) * 100000) / 100000
                    Me.tabla.DataGridView1.Rows(i).Cells(3).Value = aux
                    ji_cuadrado += aux
                Next

            Else
                For i As Integer = 0 To 9
                    Me.tabla.DataGridView1.Rows(i).Cells(3).Value = 0
                Next
            End If

            Me.tabla.DataGridView1.Rows(10).Cells(3).Value = ji_cuadrado

        Else
            For i As Double = 0.1 To 1 Step 0.1
                Me.tabla.DataGridView1.Rows(i * 10 - 1).Cells(0).Value = i
            Next

            For i As Integer = 0 To 9
                Me.tabla.DataGridView1.Rows(i).Cells(2).Value = 0.1
            Next

            For i As Integer = 0 To 9
                Me.tabla.DataGridView1.Rows(i).Cells(1).Value = Me.conti2(i) & "/" & Me.cantNum
            Next

            If cantNum <> 0 Then
                For i As Integer = 0 To 9
                    aux = Math.Truncate((Math.Pow((Me.conti2(i) / Me.cantNum) - 0.1, 2) / 0.1) * 100000) / 100000
                    Me.tabla.DataGridView1.Rows(i).Cells(3).Value = aux
                    ji_cuadrado += aux
                Next

            Else
                For i As Integer = 0 To 9
                    Me.tabla.DataGridView1.Rows(i).Cells(3).Value = 0
                Next
            End If

            Me.tabla.DataGridView1.Rows(10).Cells(3).Value = ji_cuadrado
        End If


    End Sub

    Private Sub txt_a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_a.KeyPress, txt_c.KeyPress, txt_m.KeyPress, txt_x.KeyPress, txt_cantNum.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub rb_multiplicativo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_multiplicativo.CheckedChanged
        Me.ListBox1.Items.Clear()
        For i As Integer = 0 To 9
            conti(i) = 0
        Next

        Me.acumuladorMixto = 0.0
        Me.cantNum = 0
        Me.flag = True

        If Me.rb_multiplicativo.Checked = True Then
            Me.txt_c.Enabled = False
        Else
            Me.txt_c.Enabled = True
        End If
    End Sub

    Private Sub btn_tablas_Click(sender As Object, e As EventArgs) Handles btn_tablas.Click
        If Me.rb_mixto.Checked = True Then
            Me.tabla.DataGridView1.Columns(1).Name = "Frecuencia Mixto"
            Me.tabla.DataGridView1.Columns(1).HeaderText = "Frecuencia Mixto"
            CompletarTabla()

        Else
            Me.tabla.DataGridView1.Columns(1).Name = "Frecuencia Multiplicativo"
            Me.tabla.DataGridView1.Columns(1).HeaderText = "Frecuencia Multiplicativo"

            CompletarTabla()
        End If

        Me.tabla.Show()
    End Sub
End Class