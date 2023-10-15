Public Class Form1
    Public q As Queue = New Queue()
    Private Sub adicionar()
        q.Enqueue(1)
        q.Enqueue(2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgfiltro.DataSource = q
    End Sub
End Class