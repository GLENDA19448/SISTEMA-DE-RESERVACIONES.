<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txbNombreCliente = New System.Windows.Forms.TextBox()
        Me.GroupBoxCLIENTE = New System.Windows.Forms.GroupBox()
        Me.txbIdCliente = New System.Windows.Forms.MaskedTextBox()
        Me.txbTelefCliente = New System.Windows.Forms.MaskedTextBox()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxturno = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txbidempleado = New System.Windows.Forms.TextBox()
        Me.txbempleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblprec = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxhabitacion = New System.Windows.Forms.ComboBox()
        Me.cbxcantidad = New System.Windows.Forms.MaskedTextBox()
        Me.tbxEstancia = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxpiscina = New System.Windows.Forms.CheckBox()
        Me.cbxjacuzzi = New System.Windows.Forms.CheckBox()
        Me.cbxcomida = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxCLIENTE.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbNombreCliente
        '
        Me.txbNombreCliente.Location = New System.Drawing.Point(156, 32)
        Me.txbNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txbNombreCliente.Name = "txbNombreCliente"
        Me.txbNombreCliente.Size = New System.Drawing.Size(540, 30)
        Me.txbNombreCliente.TabIndex = 1
        '
        'GroupBoxCLIENTE
        '
        Me.GroupBoxCLIENTE.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxCLIENTE.Controls.Add(Me.txbIdCliente)
        Me.GroupBoxCLIENTE.Controls.Add(Me.txbTelefCliente)
        Me.GroupBoxCLIENTE.Controls.Add(Me.rdbFemenino)
        Me.GroupBoxCLIENTE.Controls.Add(Me.rdbMasculino)
        Me.GroupBoxCLIENTE.Controls.Add(Me.Label7)
        Me.GroupBoxCLIENTE.Controls.Add(Me.Label6)
        Me.GroupBoxCLIENTE.Controls.Add(Me.Label5)
        Me.GroupBoxCLIENTE.Controls.Add(Me.Label4)
        Me.GroupBoxCLIENTE.Controls.Add(Me.txbNombreCliente)
        Me.GroupBoxCLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCLIENTE.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxCLIENTE.Location = New System.Drawing.Point(121, 153)
        Me.GroupBoxCLIENTE.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxCLIENTE.Name = "GroupBoxCLIENTE"
        Me.GroupBoxCLIENTE.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxCLIENTE.Size = New System.Drawing.Size(735, 184)
        Me.GroupBoxCLIENTE.TabIndex = 17
        Me.GroupBoxCLIENTE.TabStop = False
        Me.GroupBoxCLIENTE.Text = "CLIENTE"
        '
        'txbIdCliente
        '
        Me.txbIdCliente.Location = New System.Drawing.Point(156, 73)
        Me.txbIdCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txbIdCliente.Mask = "0000-0000-00000"
        Me.txbIdCliente.Name = "txbIdCliente"
        Me.txbIdCliente.Size = New System.Drawing.Size(195, 30)
        Me.txbIdCliente.TabIndex = 12
        '
        'txbTelefCliente
        '
        Me.txbTelefCliente.Location = New System.Drawing.Point(156, 114)
        Me.txbTelefCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTelefCliente.Mask = "0000-0000"
        Me.txbTelefCliente.Name = "txbTelefCliente"
        Me.txbTelefCliente.Size = New System.Drawing.Size(132, 30)
        Me.txbTelefCliente.TabIndex = 11
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(339, 155)
        Me.rdbFemenino.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(128, 29)
        Me.rdbFemenino.TabIndex = 10
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.ForeColor = System.Drawing.Color.Maroon
        Me.rdbMasculino.Location = New System.Drawing.Point(156, 155)
        Me.rdbMasculino.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(131, 29)
        Me.rdbMasculino.TabIndex = 9
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 162)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "GÉNERO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "TELÉFONO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "IDENTIDAD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(28, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NOMBRE:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cbxturno)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txbidempleado)
        Me.GroupBox2.Controls.Add(Me.txbempleado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(121, 362)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(735, 180)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPLEADO QUE LO ATENDIÓ"
        '
        'cbxturno
        '
        Me.cbxturno.FormattingEnabled = True
        Me.cbxturno.Items.AddRange(New Object() {"MATUTINO", "VESPERTINO", "NOCTURNO"})
        Me.cbxturno.Location = New System.Drawing.Point(115, 113)
        Me.cbxturno.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxturno.Name = "cbxturno"
        Me.cbxturno.Size = New System.Drawing.Size(236, 33)
        Me.cbxturno.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 122)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "TURNO:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 81)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(229, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "CÓDIGO DE EMPLEADO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 41)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "NOMBRE:"
        '
        'txbidempleado
        '
        Me.txbidempleado.Location = New System.Drawing.Point(270, 73)
        Me.txbidempleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txbidempleado.Name = "txbidempleado"
        Me.txbidempleado.Size = New System.Drawing.Size(169, 30)
        Me.txbidempleado.TabIndex = 4
        '
        'txbempleado
        '
        Me.txbempleado.Location = New System.Drawing.Point(133, 32)
        Me.txbempleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txbempleado.Name = "txbempleado"
        Me.txbempleado.Size = New System.Drawing.Size(563, 30)
        Me.txbempleado.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Georgia", 25.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(472, 13)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(727, 49)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "SISTEMA DE RESERVACIONES"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lblprec)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cbxhabitacion)
        Me.GroupBox3.Controls.Add(Me.cbxcantidad)
        Me.GroupBox3.Controls.Add(Me.tbxEstancia)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(121, 555)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(735, 203)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESERVACIÓN"
        '
        'lblprec
        '
        Me.lblprec.AutoSize = True
        Me.lblprec.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprec.Location = New System.Drawing.Point(549, 53)
        Me.lblprec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprec.Name = "lblprec"
        Me.lblprec.Size = New System.Drawing.Size(112, 46)
        Me.lblprec.TabIndex = 14
        Me.lblprec.Text = "L000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(556, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PRECIO x DIA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxhabitacion
        '
        Me.cbxhabitacion.AutoCompleteCustomSource.AddRange(New String() {"ECONÓMICA", "STANDARD", "EJECUTIVA", "PRECIDENCIAL"})
        Me.cbxhabitacion.FormattingEnabled = True
        Me.cbxhabitacion.Items.AddRange(New Object() {"ECONÓMICA", "STANDARD", "EJECUTIVA", "PRESIDENCIAL"})
        Me.cbxhabitacion.Location = New System.Drawing.Point(240, 44)
        Me.cbxhabitacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxhabitacion.Name = "cbxhabitacion"
        Me.cbxhabitacion.Size = New System.Drawing.Size(247, 33)
        Me.cbxhabitacion.TabIndex = 12
        '
        'cbxcantidad
        '
        Me.cbxcantidad.Location = New System.Drawing.Point(316, 94)
        Me.cbxcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxcantidad.Mask = "00"
        Me.cbxcantidad.Name = "cbxcantidad"
        Me.cbxcantidad.Size = New System.Drawing.Size(51, 30)
        Me.cbxcantidad.TabIndex = 11
        '
        'tbxEstancia
        '
        Me.tbxEstancia.Location = New System.Drawing.Point(211, 140)
        Me.tbxEstancia.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxEstancia.Mask = "000"
        Me.tbxEstancia.Name = "tbxEstancia"
        Me.tbxEstancia.Size = New System.Drawing.Size(59, 30)
        Me.tbxEstancia.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 102)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(283, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "CANTIDAD DE HABITACIONES:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 149)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "DIAS DE ESTANCIA:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 53)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(207, 20)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "TIPO DE HABITACIÓN:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISTEMA_DE_RESERVACIONES.My.Resources.Resources.hotel
        Me.PictureBox1.Location = New System.Drawing.Point(121, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1016, 211)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 84)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "GENERAR FACTURA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1016, 352)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(300, 82)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "BORRAR TODO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cbxpiscina)
        Me.GroupBox1.Controls.Add(Me.cbxjacuzzi)
        Me.GroupBox1.Controls.Add(Me.cbxcomida)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(896, 482)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(431, 251)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SERVICIOS ADICIONALES"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(353, 129)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 25)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "L50"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(353, 185)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 25)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "L100"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(353, 74)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 25)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "L50"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(355, 42)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 18)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "PRECIO"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxpiscina
        '
        Me.cbxpiscina.AutoSize = True
        Me.cbxpiscina.Location = New System.Drawing.Point(28, 187)
        Me.cbxpiscina.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxpiscina.Name = "cbxpiscina"
        Me.cbxpiscina.Size = New System.Drawing.Size(104, 29)
        Me.cbxpiscina.TabIndex = 17
        Me.cbxpiscina.Text = "Piscina"
        Me.cbxpiscina.UseVisualStyleBackColor = True
        '
        'cbxjacuzzi
        '
        Me.cbxjacuzzi.AutoSize = True
        Me.cbxjacuzzi.Location = New System.Drawing.Point(28, 73)
        Me.cbxjacuzzi.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxjacuzzi.Name = "cbxjacuzzi"
        Me.cbxjacuzzi.Size = New System.Drawing.Size(108, 29)
        Me.cbxjacuzzi.TabIndex = 16
        Me.cbxjacuzzi.Text = "Jacuzzi"
        Me.cbxjacuzzi.UseVisualStyleBackColor = True
        '
        'cbxcomida
        '
        Me.cbxcomida.AutoSize = True
        Me.cbxcomida.Location = New System.Drawing.Point(28, 128)
        Me.cbxcomida.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxcomida.Name = "cbxcomida"
        Me.cbxcomida.Size = New System.Drawing.Size(108, 29)
        Me.cbxcomida.TabIndex = 15
        Me.cbxcomida.Text = "Comida"
        Me.cbxcomida.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 25.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(578, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(483, 49)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = " MERCURY DELUXE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1504, 820)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxCLIENTE)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = " "
        Me.GroupBoxCLIENTE.ResumeLayout(False)
        Me.GroupBoxCLIENTE.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbNombreCliente As TextBox
    Friend WithEvents GroupBoxCLIENTE As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txbidempleado As TextBox
    Friend WithEvents txbempleado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txbIdCliente As MaskedTextBox
    Friend WithEvents txbTelefCliente As MaskedTextBox
    Friend WithEvents cbxcantidad As MaskedTextBox
    Friend WithEvents tbxEstancia As MaskedTextBox
    Friend WithEvents rdbFemenino As RadioButton
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents cbxturno As ComboBox
    Friend WithEvents cbxhabitacion As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblprec As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxjacuzzi As CheckBox
    Friend WithEvents cbxcomida As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbxpiscina As CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
