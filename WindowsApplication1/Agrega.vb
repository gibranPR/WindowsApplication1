Public Class Agrega
    Dim comandero As New OleDb.OleDbCommand
    Dim comandero1 As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim conexion As New OleDb.OleDbConnection
    'Para crear consultas
    'conexion.open
    'comandero = conexion.CreateCommand
    'comandero.CommandText = "su consulta aqui"
    'adaptador.SelectCommand = comandero
    'Dim la_tabla_que_guarda_la_consulta As New DataTable
    'adaptador.fill(la_tabla_que_guarda_la_consulta)

    'para crear inserts
    'conexion.open
    'comandero = conexion.CreateCommand
    'comandero.CommandText = "su insert aqui"
    'comandero.ExecuteNonQuery()

    Private Sub Agrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;DATA SOURCE=" & "al.mdb" & ";persist security info=false"
        abrirConexion()
        comandero = conexion.CreateCommand
        comandero.CommandText = "select * from tipoEquipos"
        adaptador.SelectCommand = comandero
        cerrarConexion()
        Dim tablaTipo As New DataTable
        adaptador.Fill(tablaTipo)
        cmbTipo.DataSource = tablaTipo
        cmbTipo.DisplayMember = "Tipo"
        cmbTipo.ValueMember = "Id"
        cmbTipo.Text = "Selecciona un tipo..."
    End Sub
    Private Sub abrirConexion()
        conexion.Open()
    End Sub
    Private Sub cerrarConexion()
        conexion.Close()
    End Sub
    Private Sub txtPresupuesto_Leave(sender As Object, e As EventArgs) Handles txtPresupuesto.Leave
        If txtPresupuesto.Text IsNot "" Then
            txtPresupuesto.Text = Format(CType(txtPresupuesto.Text, Decimal), "$####.00")
            MessageBox.Show(txtPresupuesto.Text)
        End If
    End Sub

    Private Sub txtPresupuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresupuesto.KeyPress
        Dim Aceptados As String
        Aceptados = “0123456789.,” + Convert.ToChar(8)
        If (Aceptados.Contains("" + e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ide, nombre, telefono, fechaa, observaciones, presupuesto, estatus, empleado As String
        ide = ultimoId("id", "Nota") + 1
        nombre = txtNombre.Text
        telefono = txtTelefono.Text
        fechaa = fecha.Value.ToShortDateString
        observaciones = txtObservaciones.Text
        presupuesto = txtPresupuesto.Text.Substring(1)
        estatus = 1
        empleado = 1000
        If Not validaVacio() Then
            MessageBox.Show("no jaló")
        Else
            abrirConexion()
            comandero = conexion.CreateCommand
            comandero.CommandText = "insert into nota values (" & ide & ",'" & nombre & "','" & telefono & "','" & fechaa & "','" & observaciones & "'," & presupuesto & "," & estatus & "," & empleado & ")"
            comandero.ExecuteNonQuery()
            For i As Integer = 0 To tablita.RowCount - 2
                Dim gtipo, gDesc, gProb, gCarg, gCont As String
                gtipo = tablita.Rows(i).Cells(0).Value
                gDesc = tablita.Rows(i).Cells(1).Value
                gProb = tablita.Rows(i).Cells(2).Value
                gCarg = tablita.Rows(i).Cells(3).Value
                gCont = tablita.Rows(i).Cells(4).Value
                comandero.CommandText = "insert into equipo (Nota, Equipo, Descripcion, Problema, Conexion, Contra, Estatus, Presupuesto) values (" & ide & ", " & gtipo & ", '" & gDesc & "', '" & gProb & "', '" & gCarg & "', '" & gCont & "', 1, " & presupuesto & ")"

                comandero.ExecuteNonQuery()
            Next i
            conexion.Close()
            MessageBox.Show("Nota creada exitosamente, presione aceptar para imprimirla.", "Agregando nota")
            borraTodo()
        End If
    End Sub
    Private Sub borraTodo()
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtObservaciones.Text = ""
        txtPresupuesto.Text = ""
        tablita.Rows.Clear()
        borraDeTabla()
    End Sub
    Private Sub borraDeTabla()
        cmbTipo.SelectedIndex = -1
        txtDescripcion.Text = ""
        txtProblema.Text = ""
        txtCargador.Text = ""
        txtContra.Text = ""
    End Sub
    Private Function validaVacio() As Boolean
        If txtNombre.Text = "" Or txtTelefono.Text = "" Or txtObservaciones.Text = "" Or txtPresupuesto.Text = "" Then
            Return False
        End If
        If tablita.RowCount = 1 Then
            Return False
        End If
        Return True
    End Function
    Private Sub btnTabla_Click(sender As Object, e As EventArgs) Handles btnTabla.Click
        If Not validaTabla() Then
            MessageBox.Show("Dato faltante.")
        Else
            tablita.Rows.Add(cmbTipo.SelectedValue, txtDescripcion.Text, txtProblema.Text, txtCargador.Text, txtContra.Text)
            borraDeTabla()
        End If
    End Sub
    Private Function validaTabla() As Boolean
        If cmbTipo.Text = "Selecciona un tipo..." Or cmbTipo.SelectedIndex < 0 Or txtDescripcion.Text = "" Or txtProblema.Text = "" Or txtCargador.Text = "" Or txtContra.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If tablita.CurrentRow.IsNewRow Then
        Else tablita.Rows.Remove(tablita.CurrentRow)
        End If
    End Sub
    Private Function ultimoId(id As String, tabla As String) As String
        comandero = conexion.CreateCommand
        comandero.CommandText = "select top 1 " & id & " from " & tabla & " order by " & id & " desc"
        adaptador.SelectCommand = comandero
        Dim algo As DataTable
        algo = New DataTable
        adaptador.Fill(algo)
        Dim otraCosa As String
        otraCosa = ""
        otraCosa = algo.Rows(0).Item(0).ToString
        If otraCosa IsNot "" Then
            Return otraCosa
        Else
            MessageBox.Show("Algo ha salido mal.")
            Return ""
        End If

    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        borraTodo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class