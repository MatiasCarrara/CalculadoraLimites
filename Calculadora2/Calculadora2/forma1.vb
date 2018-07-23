Public Class forma1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a As Integer = txtA.Text
        Dim b As Integer = txtB.Text
        Dim x As Integer = txtX.Text

        If (Convert.ToInt32(txtA.Text)) Then
            a = Convert.ToInt32(txtA.Text)
        End If
        If (Convert.ToInt32(txtB.Text)) Then
            b = Convert.ToInt32(txtB.Text)
        End If
        If (Convert.ToInt32(txtX.Text)) Then
            x = Convert.ToInt32(txtX.Text)
        End If

        Dim z As Double = a * x + b
        lblResultado.Text = z
    End Sub

    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        txtA.Clear()
        txtB.Clear()
        txtX.Clear()
        lblResultado.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        inicio.Visible = True
    End Sub
End Class