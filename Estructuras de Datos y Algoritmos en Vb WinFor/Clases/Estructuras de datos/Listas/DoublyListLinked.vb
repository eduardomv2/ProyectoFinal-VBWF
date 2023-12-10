Public Class DoublyListLinked(Of T)
    Implements ImethodLists(Of T)

    Private Property Head As DoubleNode(Of T)
    Private Property LastNode As DoubleNode(Of T)

    Public Sub New()
        Clear()
    End Sub

    Public Sub Add(data As T) Implements ImethodLists(Of T).Add
        Dim newNode As New DoubleNode(Of T)(data)

        If IsEmpty() Then
            Head = newNode
            LastNode = newNode
            Return
        End If

        If Exist(newNode.Data) Then
            Return
        End If

        If newNode.CompareTo(Head) <= 0 Then
            Head.Back = newNode
            newNode.Next = Head
            Head = newNode
            Return
        End If

        If newNode.CompareTo(LastNode) >= 0 Then
            LastNode.Next = newNode
            newNode.Back = LastNode
            LastNode = newNode
            Return
        End If

        Dim currentNode As DoubleNode(Of T) = Head
        While currentNode.Next IsNot Nothing AndAlso currentNode.Next.CompareTo(newNode) <= 0
            currentNode = currentNode.Next
        End While

        newNode.Next = currentNode.Next
        newNode.Back = currentNode
        currentNode.Next.Back = newNode
        currentNode.Next = newNode
    End Sub

    Public Sub Delete(data As T) Implements ImethodLists(Of T).Delete
        If IsEmpty() Then
            Return
        End If

        If Object.Equals(Head.Data, data) Then
            Head = Head.Next
            Head.Back = Nothing
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If

        If Object.Equals(LastNode.Data, data) Then
            LastNode = LastNode.Back
            LastNode.Next = Nothing
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If

        Dim currentNode As DoubleNode(Of T) = Head
        While currentNode.Next IsNot Nothing AndAlso currentNode.Next.CompareTo(data) <= 0
            currentNode = currentNode.Next
        End While

        If Object.Equals(currentNode.Data, data) Then
            currentNode.Back.Next = currentNode.Next
            currentNode.Next.Back = currentNode.Back
            Console.WriteLine($"- Data [{data}] remove from List...")
            Return
        End If

        Console.WriteLine($"- Data [{data}] not remove from List...")
    End Sub

    Public Sub Search(data As T) Implements ImethodLists(Of T).Search
        If IsEmpty() Then
            Return
        End If

        If Object.Equals(Head.Data, data) Then
            Console.WriteLine($"- Data [{data}] exists in List...")
            Return
        End If

        If Object.Equals(LastNode.Data, data) Then
            Console.WriteLine($"- Data [{data}] exists in List...")
            Return
        End If

        Dim currentNode As DoubleNode(Of T) = Head
        While currentNode.Next IsNot Nothing AndAlso currentNode.CompareTo(data) < 0
            currentNode = currentNode.Next
        End While

        If Object.Equals(currentNode.Data, data) Then
            Console.WriteLine($"- Data [{data}] exists in List...")
            Return
        End If

        Console.WriteLine($"- Data [{data}] does not exist in List...")
    End Sub

    Public Sub Show() Implements ImethodLists(Of T).Show
        If IsEmpty() Then
            Console.WriteLine("Void List")
            Return
        End If

        Dim currentNode As DoubleNode(Of T) = Head
        Dim i As Integer = 0
        Console.WriteLine("=== My Doubly Linked List ===")

        While currentNode IsNot Nothing
            Console.WriteLine($"- Node [{i}] and Data: " & currentNode.Data.ToString())
            currentNode = currentNode.Next
            i += 1
        End While
    End Sub

    Public Sub ShowRevers() Implements ImethodLists(Of T).ShowRevers
        If IsEmpty() Then
            Console.WriteLine("Void List")
            Return
        End If

        Dim currentNode As DoubleNode(Of T) = LastNode
        Dim i As Integer = 0
        Console.WriteLine("=== My Doubly Linked List Reversed ===")

        Do
            Console.WriteLine($"- Node [{i}] and Data: " & currentNode.Data.ToString())
            currentNode = currentNode.Back
            i += 1
        Loop While currentNode IsNot Nothing
    End Sub

    Public Function Exist(data As T) As Boolean Implements ImethodLists(Of T).Exist
        If IsEmpty() Then
            Return False
        End If

        If Object.Equals(Head.Data, data) Then
            Return True
        End If

        If Object.Equals(LastNode.Data, data) Then
            Return True
        End If

        Dim currentNode As DoubleNode(Of T) = Head
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
        LastNode = Nothing
    End Sub

    Public Function Count() As Integer
        Dim _count As Integer = 0
        Dim copyHead As DoubleNode(Of T) = Head

        While copyHead IsNot Nothing
            _count += 1
            copyHead = copyHead.Next
        End While

        Return _count
    End Function

    Public Function ToString2() As String()
        Dim copy_head As DoubleNode(Of T) = Head
        Dim r As String() = New String(Me.Count() - 1) {}
        Dim index As Integer = 0

        Do
            r(index) += copy_head.Data.ToString()
            copy_head = copy_head.Next
            index += 1
        Loop While copy_head IsNot Nothing

        Return r
    End Function

End Class
