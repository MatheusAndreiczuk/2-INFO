Public Class Form1


    Dim calc As New Calculadora

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles bSoma.Click
        calc.valor1 = Double.Parse(txtValor1.Text)
        calc.valor2 = Double.Parse(txtValor2.Text)
        calc.soma()
        lResultado.Text = calc.resultado

    End Sub

    Private Sub btnSubtrai_Click(sender As Object, e As EventArgs) Handles bSubtrai.Click
        calc.valor1 = Double.Parse(txtValor1.Text)
        calc.valor2 = Double.Parse(txtValor2.Text)
        calc.subtrai()
        lResultado.Text = calc.resultado
    End Sub

    Private Sub btnMultiplica_Click(sender As Object, e As EventArgs) Handles bMultiplica.Click
        calc.valor1 = Double.Parse(txtValor1.Text)
        calc.valor2 = Double.Parse(txtValor2.Text)
        calc.multiplica()
        lResultado.Text = calc.resultado
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles bDivide.Click
        calc.valor1 = Double.Parse(txtValor1.Text)
        calc.valor2 = Double.Parse(txtValor2.Text)
        calc.divide()
        lResultado.Text = calc.resultado
    End Sub
End Class
