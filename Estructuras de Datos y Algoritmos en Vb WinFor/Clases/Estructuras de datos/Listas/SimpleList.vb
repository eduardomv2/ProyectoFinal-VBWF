Public Class SimpleList(Of T)
    Implements ImethodLists(Of T)

    Private Property Head As Node(Of T)
    Private Property Length As Integer

    Public Sub New()
        Clear()
    End Sub

    Public Sub Add(data As T) Implements ImethodLists(Of T).Add
        Dim newNode As New Node(Of T)(data)

        If IsEmpty() Then
            Head = newNode
            Length += 1
            Return
        End If

        If Exist(newNode.Data) Then
            Return
        End If

        If newNode.CompareTo(Head) <= 0 Then
            newNode.Next = Head
            Head = newNode
            Length += 1
            Return
        End If

        Dim currentNode As Node(Of T) = Head
        While currentNode.Next IsNot Nothing AndAlso currentNode.Next.CompareTo(newNode) < 0
            currentNode = currentNode.Next
        End While

        newNode.Next = currentNode.Next
        currentNode.Next = newNode
        Length += 1
    End Sub

    Public Sub Delete(data As T) Implements ImethodLists(Of T).Delete
        If IsEmpty() Then
            Return
        End If

        If Object.Equals(Head.Data, data) Then
            Head = Head.Next
            Length -= 1
            Return
        End If

        Dim currentNode As Node(Of T) = Head
        While currentNode.Next IsNot Nothing AndAlso Not Object.Equals(currentNode.Next.Data, data)
            currentNode = currentNode.Next
        End While

        If currentNode.Next IsNot Nothing AndAlso Object.Equals(currentNode.Next.Data, data) Then
            currentNode.Next = currentNode.Next.Next
            Length -= 1
            Return
        End If
    End Sub

    Public Sub Search(data As T) Implements ImethodLists(Of T).Search
        If IsEmpty() Then
            Return
        End If

        If Object.Equals(Head.Data, data) Then
            Return
        End If

        Dim currentNode As Node(Of T) = Head
        While currentNode.Next IsNot Nothing AndAlso currentNode.CompareTo(data) < 0
            currentNode = currentNode.Next
        End While

        If Object.Equals(currentNode.Data, data) Then
            Return
        End If
    End Sub

    Public Sub Show() Implements ImethodLists(Of T).Show
        If IsEmpty() Then
            Return
        End If

        Dim i As Integer = 0
        Dim currentNode As Node(Of T) = Head
        While currentNode IsNot Nothing
            currentNode = currentNode.Next
            i += 1
        End While
    End Sub

    Public Sub ShowRevers() Implements ImethodLists(Of T).ShowRevers
        If IsEmpty() Then
            Return
        End If

        Dim currentNode As Node(Of T) = Head
        Dim x As Integer = 0
        For i As Integer = Length - 1 To 0 Step -1
            currentNode = Head
            x = 0
            While currentNode IsNot Nothing AndAlso x <> i
                currentNode = currentNode.Next
                x += 1
            End While
        Next
    End Sub

    Public Function Exist(data As T) As Boolean Implements ImethodLists(Of T).Exist
        If IsEmpty() Then
            Return False
        End If

        If Object.Equals(Head.Data, data) Then
            Return True
        End If

        Dim currentNode As Node(Of T) = Head
        While currentNode.Next IsNot Nothing AndAlso currentNode.CompareTo(data) < 0
            currentNode = currentNode.Next
        End While

        If Object.Equals(currentNode.Data, data) Then
            Return True
        End If

        Return False
    End Function

    Public Function IsEmpty() As Boolean Implements ImethodLists(Of T).IsEmpty
        Return Head Is Nothing
    End Function

    Public Sub Clear() Implements ImethodLists(Of T).Clear
        Head = Nothing
        Length = 0
    End Sub

    Public Function Count() As Integer
        Dim _count As Integer = 0
        Dim copyHead As Node(Of T) = Head

        While copyHead IsNot Nothing
            _count += 1
            copyHead = copyHead.Next
        End While

        Return _count
    End Function

    Public Function ToString2() As String()
        Dim copyHead As Node(Of T) = Head
        Dim result As String() = New String(Me.Count() - 1) {}
        Dim index As Integer = 0

        While copyHead IsNot Nothing
            result(index) += copyHead.Data.ToString()
            copyHead = copyHead.Next
            index += 1
        End While

        Return result
    End Function
End Class
