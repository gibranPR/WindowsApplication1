Public Class Agrega
    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablita.CellContentClick

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs)
        If Cant.Value Like "" Or cmbTipo.SelectedIndex = -1 Or txtDesc.Text Like "" Or txtProb.Text Like "" Then
            MessageBox.Show("No puedes dejar datos en blanco.", "Error", MessageBoxButtons.OK)
        Else
            tablita.Rows.Add(Cant.Value, cmbTipo.SelectedItem, txtDesc.Text, txtProb.Text)
        End If

    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs)
        If tablita.Rows.Count > 1 Then
            tablita.Rows.Remove(tablita.CurrentRow)
        Else
            MessageBox.Show("Fila vacía.", "Error")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNombre.Text Like "" Or txtTelefono.Text Like "" Or tablita.Rows.Count < 1 Then
            MessageBox.Show("Uno o más valores están incompletos.", "Error", MessageBoxButtons.OK)
        Else

        End If
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Agrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlDataSet.NotaEquipo' table. You can move, or remove it, as needed.
        Me.NotaEquipoTableAdapter.Fill(Me.AlDataSet.NotaEquipo)

    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub NotaEquipoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles NotaEquipoBindingSource.CurrentChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblPrincipal_Click(sender As Object, e As EventArgs) Handles lblPrincipal.Click

    End Sub
End Class