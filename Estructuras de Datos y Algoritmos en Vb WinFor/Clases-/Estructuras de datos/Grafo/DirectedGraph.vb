Friend Class DirectedGraph
    Private _random As New Random()
    Public ReadOnly Property _Vertex As New List(Of Vertex)()
    Public ReadOnly Property _Edge As New List(Of Edge)()

    Public Sub New()
    End Sub

    Public Sub AddVertex(name As String)
        ' Añadir un vértice a posiciones aleatorias en el PictureBox
        Dim NewVertex As New Vertex(name, New Point(_random.Next(0, 400), _random.Next(0, 300)))
        _Vertex.Add(NewVertex)
    End Sub

    Public Sub AddEdge(origin As String, destination As String)
        ' Añadir una arista entre los vértices con los nombres dados
        Dim OriginVertx As Vertex = _Vertex.Find(Function(v) v.Nombre = origin)
        Dim DestinationVertx As Vertex = _Vertex.Find(Function(v) v.Nombre = destination)

        If OriginVertx IsNot Nothing AndAlso DestinationVertx IsNot Nothing Then
            _Edge.Add(New Edge(OriginVertx, DestinationVertx))
        End If
    End Sub
End Class
