Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.nombre = txbNombreCliente.Text
        Module1.identidad = txbIdCliente.Text
        Module1.telefono = txbTelefCliente.Text
        Module1.nomempleado = txbempleado.Text
        Module1.codempleado = txbidempleado.Text
        Module1.turno = cbxturno.Text
        Module1.habitacion = cbxhabitacion.Text
        Module1.cantidad = cbxcantidad.Text
        Module1.estancia = tbxEstancia.Text

        Dim jacuzzi, comida, piscina, extra
        jacuzzi = 0
        comida = 0
        piscina = 0
        extra = 0
        If cbxjacuzzi.Checked Then
            jacuzzi = 50
        End If
        If cbxcomida.Checked Then
            comida = 50
        End If
        If cbxpiscina.Checked Then
            piscina = 100
        End If
        extra = jacuzzi + comida + piscina
        Module1.extra = extra
        Dim f2 As New FACTURA()
        f2.Show()
    End Sub
    Private Sub cbxhabitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxhabitacion.SelectedIndexChanged
        Dim prec As String
        If cbxhabitacion.Text = "ECONÓMICA" Then
            prec = "L350"
            lblprec.Text = prec
        End If
        If cbxhabitacion.Text = "STANDARD" Then
            prec = "L400"
            lblprec.Text = prec
        End If
        If cbxhabitacion.Text = "EJECUTIVA" Then
            prec = "L800"
            lblprec.Text = prec
        End If
        If cbxhabitacion.Text = "PRESIDENCIAL" Then
            prec = "L1600"
            lblprec.Text = prec
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txbNombreCliente.Text = ""
        txbIdCliente.Text = ""
        txbTelefCliente.Text = ""
        txbempleado.Text = ""
        txbidempleado.Text = ""
        cbxturno.Text = ""
        cbxhabitacion.Text = ""
        cbxcantidad.Text = ""
        tbxEstancia.Text = ""
        lblprec.Text = "L000"
        cbxjacuzzi.CheckState = CheckState.Unchecked
        cbxcomida.CheckState = CheckState.Unchecked
        cbxpiscina.CheckState = CheckState.Unchecked
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
