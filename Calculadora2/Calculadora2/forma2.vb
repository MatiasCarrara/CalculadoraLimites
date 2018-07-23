Public Class forma2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a As Integer = txtA.Text
        Dim b As Integer = txtB.Text
        Dim c As Integer = txtC.Text
        Dim d As Integer = txtD.Text
        Dim x As Integer = txtX.Text

        If (Convert.ToInt32(txtA.Text)) Then
            a = Convert.ToInt32(txtA.Text)
        End If
        If (Convert.ToInt32(txtB.Text)) Then
            b = Convert.ToInt32(txtB.Text)
        End If
        If (Convert.ToInt32(txtC.Text)) Then
            c = Convert.ToInt32(txtC.Text)
        End If
        If (Convert.ToInt32(txtD.Text)) Then
            d = Convert.ToInt32(txtD.Text)
        End If
        If (Convert.ToInt32(txtX.Text)) Then
            x = Convert.ToInt32(txtX.Text)
        End If

        Dim z As Double = (a * x + b) / (c * (x * x) + d)

        If ((c * (x * x) + d) = 0) Then
            lblResultado.Text = "El limite no existe"
        Else
            lblResultado.Text = z
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtD.Clear()
        txtX.Clear()
        lblResultado.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        inicio.Visible = True
    End Sub
End Class
