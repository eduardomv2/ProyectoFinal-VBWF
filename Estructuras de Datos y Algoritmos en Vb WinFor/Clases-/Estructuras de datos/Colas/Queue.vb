Public Class Queue
    Private Property Head As Nodo
    Private Property LastNode As Nodo

    Public Sub New()
        Head = Nothing
        LastNode = Nothing
    End Sub

    Public Sub Enqueue(data As Integer)
        Dim NewNode As New Nodo(data)
        If IsEmpty() Then
            Head = NewNode
            LastNode = NewNode
            Return
        End If
        If Exist(NewNode.Data) Then
            Return
        End If
        If NewNode.Data < Head.Data Then
            NewNode.Right = Head
            Head = NewNode
            Return
        End If
        Dim CurrentNode As Nodo = Head
        While CurrentNode.Right IsNot Nothing AndAlso CurrentNode.Right.Data < NewNode.Data
            CurrentNode = CurrentNode.Right
        End While
        NewNode.Right = CurrentNode.Right
        CurrentNode.Right = NewNode
        CurrentNode = Head
        While CurrentNode.Right IsNot Nothing
            CurrentNode = CurrentNode.Right
        End While
        LastNode = CurrentNode
    End Sub

    Public Sub Dequeue()
        If IsEmpty() Then
            MessageBox.Show("Void Queue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Head.Right IsNot Nothing Then
            Head = Head.Right
            Return
        End If
        Clear()
    End Sub

    Private Function Exist(data As Integer) As Boolean
        If IsEmpty() Then
            Return False
        End If
        If Head.Data = data Then
            Return True
        End If
        Dim CurrentNode As Nodo = Head
        While CurrentNode.Right IsNot Nothing AndAlso CurrentNode.Right.Data < data
            CurrentNode = CurrentNode.Right
        End While
        If CurrentNode.Data = data Then
            Return True
        End If
        Return False
    End Function

    Private Function IsEmpty() As Boolean
        Return Head Is Nothing
    End Function

    Public Sub Clear()
        Head = Nothing
        LastNode = Nothing
    End Sub

    Public Function Count() As Integer
        Dim _count As Integer = 0
        Dim copy_head As Nodo = Head
        While copy_head IsNot Nothing
            _count += 1
            copy_head = copy_head.Right
        End While
        Return _count
    End Function

    Public Function ToString2() As String()
        Dim copy_head As Nodo = Head
        Dim r As String() = New String(Me.Count() - 1) {}
        Dim index As Integer = 0
        While copy_head IsNot Nothing
            r(index) += copy_head.Data.ToString()
            copy_head = copy_head.Right
            index += 1
        End While
        Return r
    End Function
End Class
