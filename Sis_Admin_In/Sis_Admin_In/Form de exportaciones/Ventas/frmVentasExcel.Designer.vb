<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentasExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentasExcel))
        Me.dgTablas = New System.Windows.Forms.DataGridView()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.dgFinal = New System.Windows.Forms.DataGridView()
        Me.idVentaV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleadoV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVentaD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProductoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProductoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidadP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencasP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maximmoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleadoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudadE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coloniaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccionE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacimientoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTablas
        '
        Me.dgTablas.AllowUserToAddRows = False
        Me.dgTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTablas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.seleccionar})
        Me.dgTablas.Location = New System.Drawing.Point(35, 12)
        Me.dgTablas.Name = "dgTablas"
        Me.dgTablas.Size = New System.Drawing.Size(560, 266)
        Me.dgTablas.TabIndex = 0
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(275, 353)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(177, 48)
        Me.btn_salir.TabIndex = 30
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Image = CType(resources.GetObject("btnGenerar.Image"), System.Drawing.Image)
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(35, 353)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(177, 48)
        Me.btnGenerar.TabIndex = 29
        Me.btnGenerar.Text = "Exportar a excel"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'dgFinal
        '
        Me.dgFinal.AllowUserToAddRows = False
        Me.dgFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFinal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVentaV, Me.idEmpleadoV, Me.fechaV, Me.totalV, Me.idVentaD, Me.idProductoD, Me.CantidadD, Me.PrecioD, Me.idProductoP, Me.nombreP, Me.marcaP, Me.unidadP, Me.costoP, Me.existencasP, Me.minimoP, Me.maximmoP, Me.idEmpleadoE, Me.nombreE, Me.ciudadE, Me.coloniaE, Me.direccionE, Me.telefonoE, Me.nacimientoE, Me.sexoE})
        Me.dgFinal.Location = New System.Drawing.Point(657, 12)
        Me.dgFinal.Name = "dgFinal"
        Me.dgFinal.Size = New System.Drawing.Size(474, 266)
        Me.dgFinal.TabIndex = 31
        '
        'idVentaV
        '
        Me.idVentaV.HeaderText = "idVenta"
        Me.idVentaV.Name = "idVentaV"
        '
        'idEmpleadoV
        '
        Me.idEmpleadoV.HeaderText = "idEmpleado"
        Me.idEmpleadoV.Name = "idEmpleadoV"
        '
        'fechaV
        '
        Me.fechaV.HeaderText = "fecha"
        Me.fechaV.Name = "fechaV"
        '
        'totalV
        '
        Me.totalV.HeaderText = "total"
        Me.totalV.Name = "totalV"
        '
        'idVentaD
        '
        Me.idVentaD.HeaderText = "idVenta"
        Me.idVentaD.Name = "idVentaD"
        '
        'idProductoD
        '
        Me.idProductoD.HeaderText = "idProducto"
        Me.idProductoD.Name = "idProductoD"
        Me.idProductoD.ReadOnly = True
        '
        'CantidadD
        '
        Me.CantidadD.HeaderText = "Cantidad"
        Me.CantidadD.Name = "CantidadD"
        '
        'PrecioD
        '
        Me.PrecioD.HeaderText = "Precio"
        Me.PrecioD.Name = "PrecioD"
        Me.PrecioD.ReadOnly = True
        '
        'idProductoP
        '
        Me.idProductoP.HeaderText = "idProducto"
        Me.idProductoP.Name = "idProductoP"
        '
        'nombreP
        '
        Me.nombreP.HeaderText = "nombre"
        Me.nombreP.Name = "nombreP"
        Me.nombreP.ReadOnly = True
        '
        'marcaP
        '
        Me.marcaP.HeaderText = "marca"
        Me.marcaP.Name = "marcaP"
        Me.marcaP.ReadOnly = True
        '
        'unidadP
        '
        Me.unidadP.HeaderText = "unidad"
        Me.unidadP.Name = "unidadP"
        Me.unidadP.ReadOnly = True
        '
        'costoP
        '
        Me.costoP.HeaderText = "costo"
        Me.costoP.Name = "costoP"
        Me.costoP.ReadOnly = True
        '
        'existencasP
        '
        Me.existencasP.HeaderText = "existencas"
        Me.existencasP.Name = "existencasP"
        Me.existencasP.ReadOnly = True
        '
        'minimoP
        '
        Me.minimoP.HeaderText = "minimo"
        Me.minimoP.Name = "minimoP"
        Me.minimoP.ReadOnly = True
        '
        'maximmoP
        '
        Me.maximmoP.HeaderText = "maximmo"
        Me.maximmoP.Name = "maximmoP"
        Me.maximmoP.ReadOnly = True
        '
        'idEmpleadoE
        '
        Me.idEmpleadoE.HeaderText = "idEmpleado"
        Me.idEmpleadoE.Name = "idEmpleadoE"
        Me.idEmpleadoE.ReadOnly = True
        '
        'nombreE
        '
        Me.nombreE.HeaderText = "nombre"
        Me.nombreE.Name = "nombreE"
        Me.nombreE.ReadOnly = True
        '
        'ciudadE
        '
        Me.ciudadE.HeaderText = "ciudad"
        Me.ciudadE.Name = "ciudadE"
        Me.ciudadE.ReadOnly = True
        '
        'coloniaE
        '
        Me.coloniaE.HeaderText = "colonia"
        Me.coloniaE.Name = "coloniaE"
        Me.coloniaE.ReadOnly = True
        '
        'direccionE
        '
        Me.direccionE.HeaderText = "direccion"
        Me.direccionE.Name = "direccionE"
        Me.direccionE.ReadOnly = True
        '
        'telefonoE
        '
        Me.telefonoE.HeaderText = "telefono"
        Me.telefonoE.Name = "telefonoE"
        Me.telefonoE.ReadOnly = True
        '
        'nacimientoE
        '
        Me.nacimientoE.HeaderText = "nacimiento"
        Me.nacimientoE.Name = "nacimientoE"
        Me.nacimientoE.ReadOnly = True
        '
        'sexoE
        '
        Me.sexoE.HeaderText = "sexo"
        Me.sexoE.Name = "sexoE"
        Me.sexoE.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tabla"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Campo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Longitud"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'seleccionar
        '
        Me.seleccionar.HeaderText = "seleccionar"
        Me.seleccionar.Name = "seleccionar"
        '
        'frmVentasExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgFinal)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dgTablas)
        Me.Name = "frmVentasExcel"
        Me.Text = "frmVentasExcel"
        CType(Me.dgTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgTablas As DataGridView
    Friend WithEvents btn_salir As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents dgFinal As DataGridView
    Friend WithEvents idVentaV As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleadoV As DataGridViewTextBoxColumn
    Friend WithEvents fechaV As DataGridViewTextBoxColumn
    Friend WithEvents totalV As DataGridViewTextBoxColumn
    Friend WithEvents idVentaD As DataGridViewTextBoxColumn
    Friend WithEvents idProductoD As DataGridViewTextBoxColumn
    Friend WithEvents CantidadD As DataGridViewTextBoxColumn
    Friend WithEvents PrecioD As DataGridViewTextBoxColumn
    Friend WithEvents idProductoP As DataGridViewTextBoxColumn
    Friend WithEvents nombreP As DataGridViewTextBoxColumn
    Friend WithEvents marcaP As DataGridViewTextBoxColumn
    Friend WithEvents unidadP As DataGridViewTextBoxColumn
    Friend WithEvents costoP As DataGridViewTextBoxColumn
    Friend WithEvents existencasP As DataGridViewTextBoxColumn
    Friend WithEvents minimoP As DataGridViewTextBoxColumn
    Friend WithEvents maximmoP As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleadoE As DataGridViewTextBoxColumn
    Friend WithEvents nombreE As DataGridViewTextBoxColumn
    Friend WithEvents ciudadE As DataGridViewTextBoxColumn
    Friend WithEvents coloniaE As DataGridViewTextBoxColumn
    Friend WithEvents direccionE As DataGridViewTextBoxColumn
    Friend WithEvents telefonoE As DataGridViewTextBoxColumn
    Friend WithEvents nacimientoE As DataGridViewTextBoxColumn
    Friend WithEvents sexoE As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents seleccionar As DataGridViewCheckBoxColumn
End Class
