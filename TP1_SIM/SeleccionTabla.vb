Public Class SeleccionTabla

    Private form1 As Form1

    Public Sub New(ByRef form1 As Form1)

        Me.form1 = form1
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim stringAux As String = ""

        If form1.rb_mixto.Checked = True Then
            form1.tabla.DataGridView1.Columns(1).Name = "Frecuencia Mixto"
            form1.tabla.DataGridView1.Columns(1).HeaderText = "Frecuencia Mixto"

            If Me.rb_jiCuadrado.Checked = True Then
                form1.tabla.DataGridView1.Columns(3).Visible = True
                form1.tabla.DataGridView1.Columns(4).Visible = False
                form1.tabla.DataGridView1.Columns(5).Visible = False
                form1.tabla.DataGridView1.Columns(6).Visible = False
                form1.CompletarTabla(True)
            Else

                form1.tabla.DataGridView1.Columns(3).Visible = False
                form1.tabla.DataGridView1.Columns(4).Visible = True
                form1.tabla.DataGridView1.Columns(5).Visible = True
                form1.tabla.DataGridView1.Columns(6).Visible = True


                form1.CompletarTabla(False)
            End If

        Else
            form1.tabla.DataGridView1.Columns(1).Name = "Frecuencia Multiplicativo"
            form1.tabla.DataGridView1.Columns(1).HeaderText = "Frecuencia Multiplicativo"

            If Me.rb_jiCuadrado.Checked = True Then
                form1.tabla.DataGridView1.Columns(3).Visible = True
                form1.tabla.DataGridView1.Columns(4).Visible = False
                form1.tabla.DataGridView1.Columns(5).Visible = False
                form1.tabla.DataGridView1.Columns(6).Visible = False
                form1.CompletarTabla(True)
            Else
                form1.tabla.DataGridView1.Columns(3).Visible = False
                form1.tabla.DataGridView1.Columns(4).Visible = True
                form1.tabla.DataGridView1.Columns(5).Visible = True
                form1.tabla.DataGridView1.Columns(6).Visible = True

                form1.CompletarTabla(False)
            End If

        End If

        If Me.rb_jiCuadrado.Checked = True Then
            stringAux = form1.tabla.DataGridView1.Rows(10).Cells(3).Value
            If stringAux.CompareTo("0") <> 0 Then

                If form1.datosArchivoJI.Contains("9") Then
                    If Double.Parse(stringAux) < Double.Parse(Array.IndexOf(form1.datosArchivoJI, "9") + 1) Then

                        MessageBox.Show("Se acepta la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        form1.tabla.DataGridView1.Rows(10).Cells(3).Style.BackColor = Color.Green
                    Else
                        MessageBox.Show("Se rechaza la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        form1.tabla.DataGridView1.Rows(10).Cells(3).Style.BackColor = Color.Red
                    End If
                End If


            End If

        Else
            stringAux = form1.tabla.DataGridView1.Rows(10).Cells(6).Value
            If stringAux.CompareTo("0") <> 0 Then

                If form1.datosArchivoKS.Contains("10") Then
                    If Double.Parse(stringAux) < Double.Parse(Array.IndexOf(form1.datosArchivoKS, "10") + 1) Then

                        MessageBox.Show("Se acepta la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        form1.tabla.DataGridView1.Rows(10).Cells(6).Style.BackColor = Color.Green
                    Else
                        MessageBox.Show("Se rechaza la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        form1.tabla.DataGridView1.Rows(10).Cells(6).Style.BackColor = Color.Red
                    End If
                End If


            End If
        End If




        form1.tabla.Show()
    End Sub

    Private Sub SeleccionTabla_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class