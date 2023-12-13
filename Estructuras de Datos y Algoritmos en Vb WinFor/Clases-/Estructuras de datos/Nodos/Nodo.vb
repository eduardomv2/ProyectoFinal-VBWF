Public Class Nodo
    Public Property Left As Nodo
    Public Property Right As Nodo
    Public Property NextNode As Nodo
    Public Property Data As Integer

    Public Sub New(ByVal Data As Integer)
        Me.Data = Data
        Left = Nothing
        Right = Nothing
        NextNode = Nothing
    End Sub
End Class
