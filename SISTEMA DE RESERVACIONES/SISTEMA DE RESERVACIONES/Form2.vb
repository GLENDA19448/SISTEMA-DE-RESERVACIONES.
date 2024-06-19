Public Class FACTURA
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim thisDate As Date
        thisDate = Today
        FECHA.Text = thisDate

        lblnombre.Text = Module1.nombre
        lblidentidad.Text = Module1.identidad
        lbltelefono.Text = Module1.telefono
        lblnofact.Text = Rnd() * 10000


        lblhabitacion.Text = Module1.habitacion
        lblcantid.Text = Module1.cantidad
        lblestancia.Text = Module1.estancia
        lbladicionales.Text = Module1.extra

        lblempleado.Text = Module1.nomempleado
        lblcodigo.Text = Module1.codempleado
        lblturno.Text = Module1.turno


        Dim precio, cantid, dias, extra, subtotal, impuesto, total As Double

        If lblhabitacion.Text = "ECONÓMICA" Then
            precio = 350
        End If
        If lblhabitacion.Text = "STANDARD" Then
            precio = 500
        End If
        If lblhabitacion.Text = "EJECUTIVA" Then
            precio = 800
        End If
        If lblhabitacion.Text = "PRESIDENCIAL" Then
            precio = 1500
        End If

        lblprecio.Text = precio


        cantid = lblcantid.Text

        dias = lblestancia.Text

        extra = Module1.extra


        subtotal = (precio * cantid * dias) + extra
        lblsubtotal.Text = subtotal
        impuesto = subtotal * 0.15
        lblimpuesto.Text = impuesto

        total = subtotal + impuesto
        lbltotal.Text = total

        Dim aleatorio As New Random()
        Dim valor As Integer
        valor = aleatorio.Next(100000, 999999)
        lblnofact.Text = valor

    End Sub


    Private Sub lblhabitacion_Click(sender As Object, e As EventArgs) Handles lblhabitacion.Click

    End Sub
End Class