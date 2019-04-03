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
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.NumberDecimalSeparator = "."

        System.Threading.Thread.CurrentThread.CurrentCulture = r

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

        ElseIf form1.rb_mixto.Checked = True Then
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

        Else
            form1.tabla.DataGridView1.Columns(1).Name = "Frecuencia Lenguaje"
            form1.tabla.DataGridView1.Columns(1).HeaderText = "Frecuencia Lenguaje"

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
                    If Double.Parse(stringAux) < Double.Parse(form1.datosArchivoJI.ElementAt(Array.IndexOf(form1.datosArchivoJI, "9") + 1), Globalization.NumberStyles.AllowDecimalPoint) Then

                        MessageBox.Show("Para 9 grados de libertad y confianza %95, el valor de KS es: " & Convert.ToDouble(form1.datosArchivoJI.ElementAt(Array.IndexOf(form1.datosArchivoKS, "9") + 1)) &
                                        " por lo tanto se acepta la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        form1.tabla.DataGridView1.Rows(10).Cells(3).Style.BackColor = Color.Green
                    Else
                        MessageBox.Show("Para 9 grados de libertad y confianza %95, el valor de KS es: " & Convert.ToDouble(form1.datosArchivoJI.ElementAt(Array.IndexOf(form1.datosArchivoKS, "9") + 1)) &
                                        " por lo tanto se rechaza la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        form1.tabla.DataGridView1.Rows(10).Cells(3).Style.BackColor = Color.Red
                    End If
                End If


            End If

        Else
            stringAux = form1.tabla.DataGridView1.Rows(10).Cells(6).Value
            If stringAux.CompareTo("0") <> 0 Then

                If form1.datosArchivoKS.Contains("10") Then
                    If Convert.ToDouble(stringAux) < Convert.ToDouble(form1.datosArchivoKS.ElementAt(Array.IndexOf(form1.datosArchivoKS, "10") + 1)) Then

                        MessageBox.Show("Para 10 grados de libertad y confianza %95, el valor de KS es: " & Convert.ToDouble(form1.datosArchivoKS.ElementAt(Array.IndexOf(form1.datosArchivoKS, "10") + 1)) &
                                        " por lo tanto se acepta la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        form1.tabla.DataGridView1.Rows(10).Cells(6).Style.BackColor = Color.Green
                    Else
                        MessageBox.Show("Para 9 grados de libertad y confianza %95, el valor de KS es: " & Convert.ToDouble(form1.datosArchivoJI.ElementAt(Array.IndexOf(form1.datosArchivoKS, "10") + 1)) &
                                        " por lo tanto se rechaza la hipotesis", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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