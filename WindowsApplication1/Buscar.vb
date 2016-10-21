Public Class Buscar
    Dim comandero As New OleDb.OleDbCommand
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
    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;DATA SOURCE=" & "al.mdb" & ";persist security info=false"
        abrirConexion()
        comandero = conexion.CreateCommand
        comandero.CommandText = "select * from vw_Equipos"
        adaptador.SelectCommand = comandero
        Dim aux As New DataTable
        adaptador.Fill(aux)
        tablinha.DataSource = aux
        tablinha.Columns(5).MinimumWidth = 130
        tablinha.Columns(6).MinimumWidth = 200
        cerrarConexion()
        llenaCmbEstatus()
    End Sub
    Private Sub llenaCmbEstatus()
        abrirConexion()
        comandero = conexion.CreateCommand
        comandero.CommandText = "select * from Estatus"
        adaptador.SelectCommand = comandero
        cerrarConexion()
        Dim tablaEstatus As New DataTable
        adaptador.Fill(tablaEstatus)
        tablaEstatus.Rows.Add(5, "Todos")
        cmbEstatus.DataSource = tablaEstatus
        cmbEstatus.DisplayMember = "Tipo"
        cmbEstatus.ValueMember = "Id"
        cmbEstatus.Text = "Todos"
    End Sub
    Private Sub abrirConexion()
        conexion.Open()
    End Sub
    Private Sub cerrarConexion()
        conexion.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cmbFiltro.Text = "" Or txtBuscar.Text = "" Then
            MessageBox.Show("Error, selecciona lo que quieres buscar.")

        Else abrirConexion()
            comandero = conexion.CreateCommand
            comandero.CommandText = "select * from vw_Equipos where " & cmbFiltro.SelectedItem & " like '%" & txtBuscar.Text & "%'"
            adaptador.SelectCommand = comandero
            Dim aux As New DataTable
            adaptador.Fill(aux)
            If aux.Rows.Count = 0 Then
                MessageBox.Show("Error, no hemos encontrado el registro.")
            Else
                tablinha.DataSource = aux
                tablinha.Columns(5).MinimumWidth = 130
                tablinha.Columns(6).MinimumWidth = 200
            End If
            cerrarConexion()
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        If cmbEstatus.SelectedValue = 5 Then
            abrirConexion()
            comandero = conexion.CreateCommand
            comandero.CommandText = "select * from vw_Equipos"
            adaptador.SelectCommand = comandero
            Dim aux As New DataTable
            adaptador.Fill(aux)
            tablinha.DataSource = aux
            tablinha.Columns(5).MinimumWidth = 130
            tablinha.Columns(6).MinimumWidth = 200
            cerrarConexion()
        Else
            abrirConexion()
            comandero = conexion.CreateCommand
            comandero.CommandText = "select * from vw_Equipos where Tipo like '" & cmbEstatus.Text & "'"
            adaptador.SelectCommand = comandero
            Dim aux As New DataTable
            adaptador.Fill(aux)
            tablinha.DataSource = aux
            tablinha.Columns(5).MinimumWidth = 130
            tablinha.Columns(6).MinimumWidth = 200
            cerrarConexion()
        End If
    End Sub
End Class