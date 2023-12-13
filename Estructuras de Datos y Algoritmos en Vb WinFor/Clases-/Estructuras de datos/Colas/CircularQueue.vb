Class CircularQueue
    Private Size, Front, Rear As Integer
    Private Queue As List(Of Integer) = New List(Of Integer)()

    Public Sub New(size As Integer)
        Me.Size = size
        Me.Front = Me.Rear = -1
    End Sub

    Public Sub Enqueue(value As Integer)
        If (Front = 0 AndAlso Rear = Size - 1) OrElse (Rear = (Front - 1) Mod (Size - 1)) Then
            MessageBox.Show("Circular Queue is Full!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Front = -1 Then
            Front = 0
            Rear = 0
            Queue.Add(value)
        ElseIf Rear = Size - 1 AndAlso Front <> 0 Then
            Rear = 0
            Queue(Rear) = value
        Else
            Rear = (Rear + 1) Mod Size
            If Front <= Rear Then
                Queue.Add(value)
            Else
                Queue(Rear) = value
            End If
        End If
    End Sub

    Public Sub Dequeue()
        If Front = -1 Then
            MessageBox.Show("Void Circular Queue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Front = Rear Then
            Front = -1
            Rear = -1
        ElseIf Front = Size - 1 Then
            Front = 0
        Else
            If Front = Queue.Count Then
                MessageBox.Show("Void Circular Queue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Queue.RemoveAt(Front)
        End If
    End Sub

    Public Sub Clear()
        Queue.Clear()
    End Sub

    Public Function ToString2() As String()
        Dim r As String() = New String(Queue.Count - 1) {}
        For i As Integer = 0 To Queue.Count - 1
            r(i) += Queue(i).ToString()
        Next
        Return r
    End Function
End Class