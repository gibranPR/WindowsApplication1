Public Class Modificar
    Dim comandero As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim conexion As New OleDb.OleDbConnection
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text = "" Then
            MessageBox.Show("Error, escribe la nota que quieres buscar.")
            txtBuscar.Focus()
        Else abrirConexion()
            comandero = conexion.CreateCommand
            comandero.CommandText = "select * from vw_Equipo where Nota like '" & txtBuscar.Text & "'"
            adaptador.SelectCommand = comandero
            Dim aux As New DataTable
            adaptador.Fill(aux)
            If aux.Rows.Count = 0 Then
                MessageBox.Show("Error, no se ha encontrado la nota, prueba con otra.")
            Else
                tablinha.DataSource = aux
                tablinha.Columns(0).Width = 20
                tablinha.Columns(1).Width = 32
                tablinha.Columns(2).Width = 70
                tablinha.Columns(5).Width = 80
                'tablinha.Columns(6).MinimumWidth = 200
                btnModificar.Enabled = True
            End If
            cerrarConexion()
        End If
    End Sub

    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;DATA SOURCE=" & "al.mdb" & ";persist security info=false"
    End Sub
    Private Sub abrirConexion()
        conexion.Open()
    End Sub
    Private Sub cerrarConexion()
        conexion.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text Like "Modificar" Then
            llenaModificar()
        ElseIf btnModificar.Text Like "Guardar" Then
            modifica()
            borraTxt()
            btnModificar.Text = "Modificar"
            btnModificar.Enabled = False
            Me.Close()
        End If
    End Sub
    Dim indice As New Integer
    Private Sub borraTxt()
        txtBuscar.Text = ""
        txtDescripcion.Text = ""
        txtProblema.Text = ""
        txtCargador.Text = ""
        txtContra.Text = ""
    End Sub
    Private Sub llenaModificar()
        'Llenamos los txt
        abrirConexion()
        comandero = conexion.CreateCommand
        indice = tablinha.CurrentRow.Cells(0).Value
        If indice <> 0 Then
            comandero.CommandText = "select Descripcion, Problema, Conexion, Contra from Equipo where id = " & indice & ""
            adaptador.SelectCommand = comandero
            cerrarConexion()
            Dim aux As New DataTable
            adaptador.Fill(aux)
            txtDescripcion.Text = aux.Rows(0).Item(0)
            txtProblema.Text = aux.Rows(0).Item(1)
            txtCargador.Text = aux.Rows(0).Item(2)
            txtContra.Text = aux.Rows(0).Item(3)
            'Llenamos el cmbTipo
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
            cmbTipo.Text = tablinha.CurrentRow.Cells(2).Value
            'Llenamos en cmbEstatus
            abrirConexion()
            comandero = conexion.CreateCommand
            comandero.CommandText = "select * from Estatus"
            adaptador.SelectCommand = comandero
            cerrarConexion()
            Dim tablaEstatus As New DataTable
            adaptador.Fill(tablaEstatus)
            cmbEstatus.DataSource = tablaEstatus
            cmbEstatus.DisplayMember = "Tipo"
            cmbEstatus.ValueMember = "Id"
            cmbEstatus.Text = tablinha.CurrentRow.Cells(5).Value
            btnModificar.Text = "Guardar"
        End If
    End Sub
    Private Sub modifica()
        abrirConexion()
        comandero = conexion.CreateCommand
        indice = tablinha.CurrentRow.Cells(0).Value
        comandero.CommandText = "update Equipo set Equipo = " & cmbTipo.SelectedValue & ", Descripcion = '" & txtDescripcion.Text & "', Problema = '" & txtProblema.Text & "', Conexion = '" & txtCargador.Text & "', Contra = '" & txtContra.Text & "', Estatus = " & cmbEstatus.SelectedValue & " where id = " & indice & ""
        comandero.ExecuteNonQuery()
        cerrarConexion()
        MessageBox.Show("Equipo modificado exitosamente.")
    End Sub
End Class