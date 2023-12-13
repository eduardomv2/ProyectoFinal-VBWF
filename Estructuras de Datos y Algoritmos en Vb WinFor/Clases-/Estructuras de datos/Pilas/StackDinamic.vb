Public Class StackDinamic(Of T)
    Private Stack As List(Of T)
    Public Count As Integer

    Default Public ReadOnly Property Item(index As Integer) As T
        Get
            Return Stack(index)
        End Get
    End Property

    Public Sub New()
        Stack = New List(Of T)()
    End Sub

    Public Sub Push(item As T)
        Stack.Add(item)
        Count += 1
    End Sub

    Public Function Pop() As T
        If Stack.Count = 0 Then
            MessageBox.Show("Void Dynamic Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If

        Dim lastIndex As Integer = Stack.Count - 1
        Dim poppedItem As T = Stack(lastIndex)
        Stack.RemoveAt(lastIndex)
        Count -= 1
        Return poppedItem
    End Function

    Public Function Peek() As T
        If Stack.Count = 0 Then
            MessageBox.Show("Void Dynamic Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If

        MessageBox.Show($"Peek Dynamic Stack: {Stack(Stack.Count - 1)}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Stack(Stack.Count - 1)
    End Function

    Public Function ToString2() As String()
        Dim r As String() = New String(Me.Count - 1) {}
        For i As Integer = 0 To Count - 1
            r(i) += Stack(i).ToString()
        Next
        Return r
    End Function

End Class
