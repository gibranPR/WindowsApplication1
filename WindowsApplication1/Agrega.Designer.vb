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
        Dim NombreClienteLabel As System.Windows.Forms.Label
        Dim TelefonoClienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Me.txtProb = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AlDataSet = New PRSys.alDataSet()
        Me.NotaEquipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotaEquipoTableAdapter = New PRSys.alDataSetTableAdapters.NotaEquipoTableAdapter()
        Me.TableAdapterManager = New PRSys.alDataSetTableAdapters.TableAdapterManager()
        Me.Problema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tablita = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.NombreClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidadNumericUpDown = New System.Windows.Forms.NumericUpDown()
        NombreClienteLabel = New System.Windows.Forms.Label()
        TelefonoClienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotaEquipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProb
        '
        Me.txtProb.Location = New System.Drawing.Point(522, 199)
        Me.txtProb.Name = "txtProb"
        Me.txtProb.Size = New System.Drawing.Size(165, 56)
        Me.txtProb.TabIndex = 12
        Me.txtProb.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(519, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Problema:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cable/Cargador:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(535, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Contraseña:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(308, 391)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(188, 20)
        Me.TextBox4.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(538, 391)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 20)
        Me.TextBox5.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 461)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Presupuesto:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(92, 489)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 22
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(414, 439)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 68)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AlDataSet
        '
        Me.AlDataSet.DataSetName = "alDataSet"
        Me.AlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotaEquipoBindingSource
        '
        Me.NotaEquipoBindingSource.DataMember = "NotaEquipo"
        Me.NotaEquipoBindingSource.DataSource = Me.AlDataSet
        '
        'NotaEquipoTableAdapter
        '
        Me.NotaEquipoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ChecadorTableAdapter = Nothing
        Me.TableAdapterManager.CorteDiarioTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.NotaEquipoTableAdapter = Me.NotaEquipoTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRSys.alDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Problema
        '
        Me.Problema.HeaderText = "Problema"
        Me.Problema.Name = "Problema"
        Me.Problema.Width = 250
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.Width = 200
        '
        'Tipo
        '
        Me.Tipo.Frozen = True
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.MinimumWidth = 90
        Me.Tipo.Name = "Tipo"
        '
        'Cantidad
        '
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 60
        '
        'tablita
        '
        Me.tablita.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablita.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Tipo, Me.Descripción, Me.Problema})
        Me.tablita.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tablita.Location = New System.Drawing.Point(51, 261)
        Me.tablita.Name = "tablita"
        Me.tablita.Size = New System.Drawing.Size(658, 84)
        Me.tablita.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Observaciones:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(51, 384)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(205, 62)
        Me.RichTextBox1.TabIndex = 24
        Me.RichTextBox1.Text = ""
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Font = New System.Drawing.Font("Walkway UltraBold", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPrincipal.Location = New System.Drawing.Point(294, 12)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(190, 30)
        Me.lblPrincipal.TabIndex = 26
        Me.lblPrincipal.Text = "NUEVA NOTA"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Gold
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(542, 439)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(68, 68)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'NombreClienteLabel
        '
        NombreClienteLabel.AutoSize = True
        NombreClienteLabel.Location = New System.Drawing.Point(72, 116)
        NombreClienteLabel.Name = "NombreClienteLabel"
        NombreClienteLabel.Size = New System.Drawing.Size(47, 13)
        NombreClienteLabel.TabIndex = 27
        NombreClienteLabel.Text = "Nombre:"
        '
        'NombreClienteTextBox
        '
        Me.NombreClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotaEquipoBindingSource, "NombreCliente", True))
        Me.NombreClienteTextBox.Location = New System.Drawing.Point(187, 113)
        Me.NombreClienteTextBox.Name = "NombreClienteTextBox"
        Me.NombreClienteTextBox.Size = New System.Drawing.Size(205, 20)
        Me.NombreClienteTextBox.TabIndex = 28
        '
        'TelefonoClienteLabel
        '
        TelefonoClienteLabel.AutoSize = True
        TelefonoClienteLabel.Location = New System.Drawing.Point(72, 150)
        TelefonoClienteLabel.Name = "TelefonoClienteLabel"
        TelefonoClienteLabel.Size = New System.Drawing.Size(87, 13)
        TelefonoClienteLabel.TabIndex = 28
        TelefonoClienteLabel.Text = "Telefono Cliente:"
        '
        'TelefonoClienteTextBox
        '
        Me.TelefonoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotaEquipoBindingSource, "TelefonoCliente", True))
        Me.TelefonoClienteTextBox.Location = New System.Drawing.Point(187, 147)
        Me.TelefonoClienteTextBox.Name = "TelefonoClienteTextBox"
        Me.TelefonoClienteTextBox.Size = New System.Drawing.Size(205, 20)
        Me.TelefonoClienteTextBox.TabIndex = 29
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(484, 97)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 29
        FechaLabel.Text = "Fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NotaEquipoBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(487, 113)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 30
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(48, 182)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 30
        CantidadLabel.Text = "Cantidad:"
        '
        'CantidadNumericUpDown
        '
        Me.CantidadNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NotaEquipoBindingSource, "Cantidad", True))
        Me.CantidadNumericUpDown.Location = New System.Drawing.Point(51, 199)
        Me.CantidadNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CantidadNumericUpDown.Name = "CantidadNumericUpDown"
        Me.CantidadNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.CantidadNumericUpDown.TabIndex = 31
        Me.CantidadNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Agrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(802, 562)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadNumericUpDown)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(TelefonoClienteLabel)
        Me.Controls.Add(Me.TelefonoClienteTextBox)
        Me.Controls.Add(NombreClienteLabel)
        Me.Controls.Add(Me.NombreClienteTextBox)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tablita)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agrega"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotaEquipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtProb As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents AlDataSet As alDataSet
    Friend WithEvents NotaEquipoBindingSource As BindingSource
    Friend WithEvents NotaEquipoTableAdapter As alDataSetTableAdapters.NotaEquipoTableAdapter
    Friend WithEvents TableAdapterManager As alDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Problema As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents tablita As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblPrincipal As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents NombreClienteTextBox As TextBox
    Friend WithEvents TelefonoClienteTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents CantidadNumericUpDown As NumericUpDown
End Class
