﻿Public Class Imprimir
    Dim comandero As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim conexion As New OleDb.OleDbConnection
    Private registro As Integer
    Public Sub setRegistro(R As Integer)
        registro = R
    End Sub
    Public Function getRegistro() As Integer
        Return registro
    End Function
    Private Sub Imprimir_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;DATA SOURCE=" & "al.mdb" & ";persist security info=false"
        abrirConexion()
        comandero = conexion.CreateCommand
        comandero.CommandText = "select top 1 Id from Nota order by id desc"
        adaptador.SelectCommand = comandero
        Dim aux As New DataTable
        adaptador.Fill(aux)
        setRegistro(aux.Rows(0).Item(0))
        cerrarConexion()
        txtId.Text = getRegistro()
        '
    End Sub
    Private Sub abrirConexion()
        conexion.Open()
    End Sub
    Private Sub cerrarConexion()
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub imprime()
        'Orientación horizontal
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        'margenes
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 20
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 20
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 20
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 20
        'Imprimir
        PrintForm1.Print()
    End Sub
End Class