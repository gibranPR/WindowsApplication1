﻿Public Class Principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPrincipal.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOp1_Click(sender As Object, e As EventArgs) Handles btnOp1.Click
        Dim agrega As New Agrega
        agrega.Show()
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        Dim buscar As New Buscar
        buscar.Show()
    End Sub

    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        Dim modificar As New Modificar
        modificar.Show()
    End Sub

    Private Sub btnEntrega_Click(sender As Object, e As EventArgs) Handles btnEntrega.Click
        Dim entregar As New Imprimir
        entregar.Show()
    End Sub
End Class
