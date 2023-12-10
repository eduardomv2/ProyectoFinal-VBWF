Public Class PriorityQueue(Of T)
    Public Class Element
        Public Property Value As T
        Public Property Priority As Integer

        Public Sub New(value As T, priority As Integer)
            Me.Value = value
            Me.Priority = priority
        End Sub
    End Class

    Private Items As List(Of Element)
    Public Property Count As Integer

    Public Sub New()
        Items = New List(Of Element)()
    End Sub

    Public Sub Enqueue(value As T, priority As Integer)
        Dim element As New Element(value, priority)
        Items.Add(element)
        HeapifyUp(Items.Count - 1)
    End Sub

    Public Function Dequeue() As T
        If Items.Count = 0 Then
            MessageBox.Show("Void Priority Queue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If

        Dim result As T = Items(0).Value
        Items(0) = Items(Items.Count - 1)
        Items.RemoveAt(Items.Count - 1)
        HeapifyDown(0)
        Return result
    End Function

    Private Sub HeapifyUp(index As Integer)
        While index > 0
            Dim parentIndex As Integer = (index - 1) \ 2

            If Items(index).Priority < Items(parentIndex).Priority Then
                Swap(index, parentIndex)
                index = parentIndex
            Else
                Exit While
            End If
        End While
    End Sub

    Private Sub HeapifyDown(index As Integer)
        Dim leftChild As Integer = 2 * index + 1
        Dim rightChild As Integer = 2 * index + 2
        Dim smallest As Integer = index

        If leftChild < Items.Count AndAlso Items(leftChild).Priority < Items(smallest).Priority Then
            smallest = leftChild
        End If

        If rightChild < Items.Count AndAlso Items(rightChild).Priority < Items(smallest).Priority Then
            smallest = rightChild
        End If

        If smallest <> index Then
            Swap(index, smallest)
            HeapifyDown(smallest)
        End If
    End Sub

    Private Sub Swap(index1 As Integer, index2 As Integer)
        Dim temp As Element = Items(index1)
        Items(index1) = Items(index2)
        Items(index2) = temp
    End Sub

    Public Sub Clear()
        Items.Clear()
    End Sub

    Public Function ToString2() As String()
        Dim r As String() = New String(Items.Count - 1) {}
        For i As Integer = 0 To Items.Count - 1
            r(i) += Items(i).Value.ToString() & " P: " & Items(i).Priority.ToString()
        Next
        Return r
    End Function
End Class
