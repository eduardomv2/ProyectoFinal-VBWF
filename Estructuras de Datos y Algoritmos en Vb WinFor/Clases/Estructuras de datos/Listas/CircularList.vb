Public Class CircularList(Of T)
    Implements ImethodLists(Of T)

    Private Property Head As Node(Of T)
    Private Property LastNode As Node(Of T)

    Public Property Lenght As Integer

    Public Sub New()
        Clear()
    End Sub

    Public Sub Add(data As T) Implements ImethodLists(Of T).Add
        Dim newNode As New Node(Of T)(data)

        If IsEmpty() Then
            Head = newNode
            Head.Next = Head
            LastNode = newNode
            Lenght += 1
            Return
        End If

        If Exist(newNode.Data) Then
            Return
        End If

        If newNode.CompareTo(Head) <= 0 Then
            newNode.Next = Head
            Head = newNode
            LastNode.Next = Head
            Lenght += 1
            Return
        End If

        If newNode.CompareTo(LastNode) >= 0 Then
            LastNode.Next = newNode
            newNode.Next = Head
            LastNode = newNode
            Lenght += 1
            Return
        End If

        Dim currentNode As Node(Of T) = Head
        While currentNode.Next IsNot Head AndAlso currentNode.Next.CompareTo(newNode) <= 0
            currentNode = currentNode.Next
        End While

        newNode.Next = currentNode.Next
        currentNode.Next = newNode
        Lenght += 1
    End Sub

    Public Sub Delete(data As T) Implements ImethodLists(Of T).Delete
        If IsEmpty() Then
            Return
        End If

        If Object.Equals(Head.Data, data) Then
            Head = Head.Next
            LastNode.Next = Head
            Console.WriteLine($"- Data [{data}] remove from List...")
            Lenght -= 1
            Return
        End If

        Dim currentNode As Node(Of T) = Head
        While currentNode.Next IsNot Head AndAlso currentNode.Next.CompareTo(data) < 0
            currentNode = currentNode.Next
        End While

        If currentNode.Next Is LastNode AndAlso Object.Equals(LastNode.Data, data) Then
            currentNode.Next = currentNode.Next.Next
            LastNode = currentNode
            LastNode.Next = Head
            Console.WriteLine($"- Data [{data}] remove from List...")
            Lenght -= 1
            Return
        End If

        If Object.Equals(currentNode.Next.Data, data) Then
            currentNode.Next = currentNode.Next.Next
            Console.WriteLine($"- Data [{data}] remove from List...")
            Lenght -= 1
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

        Dim currentNode As Node(Of T) = Head
        While currentNode.Next IsNot Head AndAlso currentNode.Next.CompareTo(data) < 0
            currentNode = currentNode.Next
        End While

        If Object.Equals(currentNode.Next.Data, data) Then
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

        Dim currentNode As Node(Of T) = Head
        Dim i As Integer = 0
        Console.WriteLine("=== My Circular List ===")

        Do
            Console.WriteLine($"- Node [{i}] and Data: " & currentNode.Data.ToString())
            currentNode = currentNode.Next
            i += 1
        Loop While currentNode IsNot Head
    End Sub

    Public Sub ShowRevers() Implements ImethodLists(Of T).ShowRevers
        If IsEmpty() Then
            Console.WriteLine("Void List")
            Return
        End If

        Dim currentNode As Node(Of T) = Head
        Dim x As Integer = 0
        Console.WriteLine("=== My Circular List Reversed ===")

        For i As Integer = Lenght - 1 To 0 Step -1
            currentNode = Head
            x = 0

            Do
                currentNode = currentNode.Next
                x += 1
            Loop While currentNode IsNot Nothing AndAlso x <> i

            Console.WriteLine($"- Node [{i}] and Data: " & currentNode.Data.ToString())
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
        While currentNode.Next IsNot Head AndAlso Not Object.Equals(currentNode.Data, data)
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
        Dim copyHead As Node(Of T) = Head

        Do
            _count += 1
            copyHead = copyHead.Next
        Loop While copyHead IsNot Head

        Return _count
    End Function

    Public Function ToString2() As String()
        Dim copyHead As Node(Of T) = Head
        Dim r As String() = New String(Me.Count() - 1) {}
        Dim index As Integer = 0

        Do
            r(index) += copyHead.Data.ToString()
            copyHead = copyHead.Next
            index += 1
        Loop While copyHead IsNot Head

        Return r
    End Function
End Class
