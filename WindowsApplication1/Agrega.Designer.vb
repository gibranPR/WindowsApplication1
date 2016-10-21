<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agrega
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agrega))
        Me.tablita = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Problema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProblema = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCargador = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPresupuesto = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnTabla = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablita
        '
        Me.tablita.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablita.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Descripción, Me.Problema, Me.Cargador, Me.Contraseña})
        Me.tablita.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tablita.Location = New System.Drawing.Point(15, 261)
        Me.tablita.Name = "tablita"
        Me.tablita.Size = New System.Drawing.Size(737, 111)
        Me.tablita.TabIndex = 14
        '
        'Tipo
        '
        Me.Tipo.Frozen = True
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.MinimumWidth = 70
        Me.Tipo.Name = "Tipo"
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.MinimumWidth = 150
        Me.Descripción.Name = "Descripción"
        Me.Descripción.Width = 170
        '
        'Problema
        '
        Me.Problema.HeaderText = "Problema"
        Me.Problema.MinimumWidth = 190
        Me.Problema.Name = "Problema"
        Me.Problema.Width = 220
        '
        'Cargador
        '
        Me.Cargador.HeaderText = "Cargador"
        Me.Cargador.MinimumWidth = 70
        Me.Cargador.Name = "Cargador"
        '
        'Contraseña
        '
        Me.Contraseña.HeaderText = "Contraseña"
        Me.Contraseña.MinimumWidth = 70
        Me.Contraseña.Name = "Contraseña"
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Font = New System.Drawing.Font("Walkway UltraBold", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPrincipal.Location = New System.Drawing.Point(294, 12)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(190, 30)
        Me.lblPrincipal.TabIndex = 16
        Me.lblPrincipal.Text = "NUEVA NOTA"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 119)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(199, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre del cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(133, 150)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(199, 20)
        Me.txtTelefono.TabIndex = 1
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(435, 118)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 20)
        Me.fecha.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha:"
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(15, 203)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tipo:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 203)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(158, 20)
        Me.txtDescripcion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Descripción:"
        '
        'txtProblema
        '
        Me.txtProblema.Location = New System.Drawing.Point(330, 203)
        Me.txtProblema.Multiline = True
        Me.txtProblema.Name = "txtProblema"
        Me.txtProblema.Size = New System.Drawing.Size(175, 52)
        Me.txtProblema.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Problema:"
        '
        'txtCargador
        '
        Me.txtCargador.Location = New System.Drawing.Point(521, 203)
        Me.txtCargador.Name = "txtCargador"
        Me.txtCargador.Size = New System.Drawing.Size(108, 20)
        Me.txtCargador.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(518, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Cargador:"
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(644, 204)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(108, 20)
        Me.txtContra.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(641, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Contraseña:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(32, 393)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(182, 50)
        Me.txtObservaciones.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 377)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Presupuesto:"
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.Location = New System.Drawing.Point(261, 393)
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(137, 20)
        Me.txtPresupuesto.TabIndex = 10
        Me.txtPresupuesto.Text = "$0"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Beige
        Me.btnBorrar.BackgroundImage = Global.PRSys.My.Resources.Resources.delete
        Me.btnBorrar.Location = New System.Drawing.Point(758, 261)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(32, 36)
        Me.btnBorrar.TabIndex = 13
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnTabla
        '
        Me.btnTabla.BackColor = System.Drawing.Color.Beige
        Me.btnTabla.BackgroundImage = CType(resources.GetObject("btnTabla.BackgroundImage"), System.Drawing.Image)
        Me.btnTabla.Location = New System.Drawing.Point(758, 204)
        Me.btnTabla.Name = "btnTabla"
        Me.btnTabla.Size = New System.Drawing.Size(32, 32)
        Me.btnTabla.TabIndex = 8
        Me.btnTabla.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Gold
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(542, 439)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(68, 68)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(414, 439)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 68)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Agrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(802, 562)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnTabla)
        Me.Controls.Add(Me.txtPresupuesto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCargador)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProblema)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tablita)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agrega"
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents tablita As DataGridView
    Friend WithEvents lblPrincipal As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Problema As DataGridViewTextBoxColumn
    Friend WithEvents Cargador As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents txtProblema As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCargador As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtContra As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPresupuesto As TextBox
    Friend WithEvents btnTabla As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
