<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FACTURA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FACTURA))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblidentidad = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblnofact = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbladicionales = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblimpuesto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.lblestancia = New System.Windows.Forms.Label()
        Me.lblcantid = New System.Windows.Forms.Label()
        Me.lblhabitacion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FECHA = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblempleado = New System.Windows.Forms.Label()
        Me.lblturno = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "TELÉFONO:"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.BackColor = System.Drawing.SystemColors.Control
        Me.lbltelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(156, 130)
        Me.lbltelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(76, 20)
        Me.lbltelefono.TabIndex = 14
        Me.lbltelefono.Text = "telefono"
        '
        'lblidentidad
        '
        Me.lblidentidad.AutoSize = True
        Me.lblidentidad.BackColor = System.Drawing.SystemColors.Control
        Me.lblidentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidentidad.Location = New System.Drawing.Point(156, 108)
        Me.lblidentidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidentidad.Name = "lblidentidad"
        Me.lblidentidad.Size = New System.Drawing.Size(24, 20)
        Me.lblidentidad.TabIndex = 13
        Me.lblidentidad.Text = "id"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.SystemColors.Control
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(156, 86)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(71, 20)
        Me.lblnombre.TabIndex = 12
        Me.lblnombre.Text = "nombre"
        '
        'lblnofact
        '
        Me.lblnofact.AutoSize = True
        Me.lblnofact.BackColor = System.Drawing.Color.Transparent
        Me.lblnofact.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnofact.ForeColor = System.Drawing.Color.Red
        Me.lblnofact.Location = New System.Drawing.Point(453, 44)
        Me.lblnofact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnofact.Name = "lblnofact"
        Me.lblnofact.Size = New System.Drawing.Size(54, 23)
        Me.lblnofact.TabIndex = 11
        Me.lblnofact.Text = "0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "IDENTIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CLIENTE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTURA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbladicionales)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblimpuesto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblsubtotal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblprecio)
        Me.GroupBox1.Controls.Add(Me.lblestancia)
        Me.GroupBox1.Controls.Add(Me.lblcantid)
        Me.GroupBox1.Controls.Add(Me.lblhabitacion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 178)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(516, 358)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETALLES DE LA FACTURA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(373, 292)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 20)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "L"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(373, 247)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 20)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "L"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(373, 223)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "L"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(373, 149)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 20)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "L"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(373, 54)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "L"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "SERVICIOS ADICIONALES"
        '
        'lbladicionales
        '
        Me.lbladicionales.AutoSize = True
        Me.lbladicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbladicionales.Location = New System.Drawing.Point(392, 148)
        Me.lbladicionales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladicionales.Name = "lbladicionales"
        Me.lbladicionales.Size = New System.Drawing.Size(93, 20)
        Me.lbladicionales.TabIndex = 12
        Me.lbladicionales.Text = "adicionales"
        Me.lbladicionales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbltotal.Location = New System.Drawing.Point(392, 292)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(41, 20)
        Me.lbltotal.TabIndex = 11
        Me.lbltotal.Text = "total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 292)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "TOTAL A PAGAR"
        '
        'lblimpuesto
        '
        Me.lblimpuesto.AutoSize = True
        Me.lblimpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblimpuesto.Location = New System.Drawing.Point(392, 247)
        Me.lblimpuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblimpuesto.Name = "lblimpuesto"
        Me.lblimpuesto.Size = New System.Drawing.Size(77, 20)
        Me.lblimpuesto.TabIndex = 9
        Me.lblimpuesto.Text = "impuesto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 247)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "ISV(15%)"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblsubtotal.Location = New System.Drawing.Point(392, 223)
        Me.lblsubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(68, 20)
        Me.lblsubtotal.TabIndex = 7
        Me.lblsubtotal.Text = "subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 223)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "SUBTOTAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 101)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "DIAS DE ESTANCIA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "CANTIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 54)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "HABITACION"
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblprecio.Location = New System.Drawing.Point(392, 54)
        Me.lblprecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(55, 20)
        Me.lblprecio.TabIndex = 3
        Me.lblprecio.Text = "precio"
        '
        'lblestancia
        '
        Me.lblestancia.AutoSize = True
        Me.lblestancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblestancia.Location = New System.Drawing.Point(392, 101)
        Me.lblestancia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestancia.Name = "lblestancia"
        Me.lblestancia.Size = New System.Drawing.Size(72, 20)
        Me.lblestancia.TabIndex = 2
        Me.lblestancia.Text = "estancia"
        Me.lblestancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcantid
        '
        Me.lblcantid.AutoSize = True
        Me.lblcantid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblcantid.Location = New System.Drawing.Point(392, 76)
        Me.lblcantid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcantid.Name = "lblcantid"
        Me.lblcantid.Size = New System.Drawing.Size(72, 20)
        Me.lblcantid.TabIndex = 1
        Me.lblcantid.Text = "cantidad"
        Me.lblcantid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhabitacion
        '
        Me.lblhabitacion.AutoSize = True
        Me.lblhabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblhabitacion.Location = New System.Drawing.Point(215, 54)
        Me.lblhabitacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhabitacion.Name = "lblhabitacion"
        Me.lblhabitacion.Size = New System.Drawing.Size(95, 20)
        Me.lblhabitacion.TabIndex = 0
        Me.lblhabitacion.Text = "habitacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Factura No."
        '
        'FECHA
        '
        Me.FECHA.AutoSize = True
        Me.FECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FECHA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FECHA.Location = New System.Drawing.Point(31, 32)
        Me.FECHA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(66, 20)
        Me.FECHA.TabIndex = 18
        Me.FECHA.Text = "FECHA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.lblempleado)
        Me.GroupBox2.Controls.Add(Me.lblturno)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 580)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(516, 161)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPLEADO QUE ATENDIO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 101)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 17)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "TURNO:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 76)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 17)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "CÓDIGO:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 54)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 17)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "NOMBRE:"
        '
        'lblempleado
        '
        Me.lblempleado.AutoSize = True
        Me.lblempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblempleado.Location = New System.Drawing.Point(135, 52)
        Me.lblempleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempleado.Name = "lblempleado"
        Me.lblempleado.Size = New System.Drawing.Size(81, 20)
        Me.lblempleado.TabIndex = 3
        Me.lblempleado.Text = "empleado"
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblturno.Location = New System.Drawing.Point(135, 97)
        Me.lblturno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(47, 20)
        Me.lblturno.TabIndex = 2
        Me.lblturno.Text = "turno"
        Me.lblturno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblcodigo.Location = New System.Drawing.Point(135, 73)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(58, 20)
        Me.lblcodigo.TabIndex = 1
        Me.lblcodigo.Text = "codigo"
        Me.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FACTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 783)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FECHA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblidentidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblnofact)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FACTURA"
        Me.Text = "FACTURA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblidentidad As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblnofact As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FECHA As Label
    Friend WithEvents lblprecio As Label
    Friend WithEvents lblestancia As Label
    Friend WithEvents lblcantid As Label
    Friend WithEvents lblhabitacion As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblimpuesto As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbladicionales As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblempleado As Label
    Friend WithEvents lblturno As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
End Class
