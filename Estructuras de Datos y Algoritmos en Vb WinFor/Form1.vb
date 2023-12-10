Public Class Form1

    ReadOnly random As New Random()
    ReadOnly stackS As New StackStatic(Of Integer)(20)
    ReadOnly stackD As New StackDinamic(Of Integer)()
    ReadOnly queue As New Queue()
    ReadOnly circularqueue As New CircularQueue(20)
    ReadOnly priorityQueue As New PriorityQueue(Of Integer)()
    ReadOnly simpleList As New SimpleList(Of Integer)()
    ReadOnly circularList As New CircularList(Of Integer)()
    ReadOnly doublyListLinked As New DoublyListLinked(Of Integer)()
    ReadOnly circularDoublyLinkedList As New CircularDoublyLinkedList(Of Integer)()
    ReadOnly binaryTree As New BinaryTree()
    ReadOnly directedGraph As New DirectedGraph()
    ReadOnly _Call As New CallAllAlgorithm()

#Region "Menu"
    Private Sub StackMenu_Click(sender As Object, e As EventArgs) Handles StackMenu.Click
        p_Queue.Visible = False
    End Sub

    Private Sub QueueMenu_Click(sender As Object, e As EventArgs) Handles QueueMenu.Click
        p_Queue.Visible = True
        p_List.Visible = False
    End Sub

    Private Sub ListMenu_Click(sender As Object, e As EventArgs) Handles ListMenu.Click
        p_Queue.Visible = True
        p_List.Visible = True
        p_Tree.Visible = False
    End Sub

    Private Sub TreeMenu_Click(sender As Object, e As EventArgs) Handles TreeMenu.Click
        p_Queue.Visible = True
        p_List.Visible = True
        p_Tree.Visible = True
        p_Graph.Visible = False
    End Sub

    Private Sub GraphMenu_Click(sender As Object, e As EventArgs) Handles GraphMenu.Click
        p_Queue.Visible = True
        p_List.Visible = True
        p_Tree.Visible = True
        p_Graph.Visible = True
        p_Algorithm.Visible = False
    End Sub

    Private Sub AlgorithmMenu_Click(sender As Object, e As EventArgs) Handles AlgorithmMenu.Click
        p_Queue.Visible = True
        p_List.Visible = True
        p_Tree.Visible = True
        p_Graph.Visible = True
        p_Algorithm.Visible = True
    End Sub
#End Region

#Region "Stack"
    Private Sub Peek_Stack_Click(sender As Object, e As EventArgs) Handles Peek_Stack.Click
        stackS.Peek()
        stackD.Peek()
    End Sub

    Private Sub Pop_Stack_Click(sender As Object, e As EventArgs) Handles Pop_Stack.Click
        stackS.Pop()
        stackD.Pop()

        Show(stackS.ToString2(), ListView_StackS)
        Show(stackD.ToString2(), ListView_StackD)

    End Sub

    Private Sub Push_Stack_Click(sender As Object, e As EventArgs) Handles Push_Stack.Click
        Dim Data As Integer = 0
        Try
            Data = Integer.Parse(TexBox_Push_Stack.Text)
        Catch
        End Try

        stackS.Push(Data)
        stackD.Push(Data)

        Show(stackS.ToString2(), ListView_StackS)
        Show(stackD.ToString2(), ListView_StackD)

        TexBox_Push_Stack.Clear()
        TexBox_Push_Stack.Focus()
    End Sub
#End Region

#Region "Queue"
    Private Sub Enqueue_Queue_Click(sender As Object, e As EventArgs) Handles Enqueue_Queue.Click
        Dim Data As Integer = 0
        Try
            Data = Integer.Parse(TexBox_Enqueue_Queue.Text)
        Catch
        End Try

        queue.Enqueue(Data)
        circularqueue.Enqueue(Data)
        priorityQueue.Enqueue(Data, 0)

        Show(queue.ToString2(), ListView_Queue)
        Show(circularqueue.ToString2(), ListView_CircularQueue)
        Show(priorityQueue.ToString2(), ListView_PriorityQueue)

        TexBox_Enqueue_Queue.Clear()
        TexBox_Enqueue_Queue.Focus()
    End Sub

    Private Sub Dequeue_Click(sender As Object, e As EventArgs) Handles Dequeue.Click
        queue.Dequeue()
        circularqueue.Dequeue()
        priorityQueue.Dequeue()

        Show(queue.ToString2(), ListView_Queue)
        Show(circularqueue.ToString2(), ListView_CircularQueue)
        Show(priorityQueue.ToString2(), ListView_PriorityQueue)
    End Sub

    Private Sub Priority_PriorityQueue_Click(sender As Object, e As EventArgs) Handles Priority_PriorityQueue.Click
        Dim Data1 As Integer = 0
        Try
            Data1 = Integer.Parse(TexBox_Enqueue_Queue.Text)
        Catch
        End Try

        Dim Data2 As Integer = 0
        Try
            Data2 = Integer.Parse(TexBox_Priority_PriorityQueue.Text)
        Catch
        End Try

        priorityQueue.Enqueue(Data1, Data2)

        Show(priorityQueue.ToString2(), ListView_PriorityQueue)

        TexBox_Enqueue_Queue.Clear()
        TexBox_Priority_PriorityQueue.Clear()
        TexBox_Enqueue_Queue.Focus()
        TexBox_Priority_PriorityQueue.Focus()
    End Sub
#End Region

#Region "List"
    Private Sub Add_List_Click(sender As Object, e As EventArgs) Handles Add_List.Click
        Dim Data As Integer = 0
        Try
            Data = Integer.Parse(TexBox_Add_List.Text)
        Catch
        End Try

        simpleList.Add(Data)
        circularList.Add(Data)
        doublyListLinked.Add(Data)
        circularDoublyLinkedList.Add(Data)

        Show(simpleList.ToString2(), ListView_SimpleList)
        Show(circularList.ToString2(), ListView_CircularList)
        Show(doublyListLinked.ToString2(), ListView_DoublyLinkedList)
        Show(circularDoublyLinkedList.ToString2(), ListView_CircularDoublyLinkedList)

        TexBox_Add_List.Clear()
        TexBox_Add_List.Focus()
    End Sub

    Private Sub Delete_List_Click(sender As Object, e As EventArgs) Handles Delete_List.Click
        Dim Data As Integer = 0
        Try
            Data = Integer.Parse(TexBox_Delete_List.Text)
        Catch
        End Try

        simpleList.Delete(Data)
        circularList.Delete(Data)
        doublyListLinked.Delete(Data)
        circularDoublyLinkedList.Delete(Data)

        Show(simpleList.ToString2(), ListView_SimpleList)
        Show(circularList.ToString2(), ListView_CircularList)
        Show(doublyListLinked.ToString2(), ListView_DoublyLinkedList)
        Show(circularDoublyLinkedList.ToString2(), ListView_CircularDoublyLinkedList)

        TexBox_Delete_List.Clear()
        TexBox_Delete_List.Focus()
    End Sub

    Private Sub Generate_List_Click(sender As Object, e As EventArgs) Handles Generate_List.Click
        Dim Data As Integer = 0
        Try
            Data = Integer.Parse(TexBox_Generate_List.Text)
        Catch
        End Try

        Generate(Data)

        Show(simpleList.ToString2(), ListView_SimpleList)
        Show(circularList.ToString2(), ListView_CircularList)
        Show(doublyListLinked.ToString2(), ListView_DoublyLinkedList)
        Show(circularDoublyLinkedList.ToString2(), ListView_CircularDoublyLinkedList)

        TexBox_Generate_List.Clear()
        TexBox_Generate_List.Focus()
    End Sub
#End Region

#Region "Tree"
    Private Sub Add_BinaryTree_Click(sender As Object, e As EventArgs) Handles Add_BinaryTree.Click
        Dim number As Integer = 0
        If Not Integer.TryParse(TexBox_Add_BinaryTree.Text, number) Then
            MessageBox.Show("Solo se permiten números en el cuadro de 'números'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        binaryTree.Add(number)

        ToursOfTree()

        Dim Data As Integer = 0
        Try
            Data = Integer.Parse(TexBox_Add_BinaryTree.Text)
        Catch
        End Try

        binaryTree.Add(Data)

        TreeShow(binaryTree.Root, Nothing, TreeView.Nodes)

        TexBox_Add_BinaryTree.Clear()
        TexBox_Add_BinaryTree.Focus()
    End Sub

    Private Sub Delete_BinaryTree_Click(sender As Object, e As EventArgs) Handles Delete_BinaryTree.Click
        Dim number As Integer = 0
        If Not Integer.TryParse(TexBox_Delete_BinaryTree.Text, number) Then
            MessageBox.Show("Solo se permiten números en el cuadro de 'números'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        binaryTree.Delete(number)
        ToursOfTree()

        TexBox_Delete_BinaryTree.Clear()
        TexBox_Delete_BinaryTree.Focus()
    End Sub

    Private Sub Search_BinaryTree_Click(sender As Object, e As EventArgs) Handles Search_BinaryTree.Click
        Dim number As Integer = 0
        If Not Integer.TryParse(TexBox_Search_BinaryTree.Text, number) Then
            MessageBox.Show("Solo se permiten números en el cuadro de 'números'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        binaryTree.Search(number)

        TexBox_Search_BinaryTree.Clear()
        TexBox_Search_BinaryTree.Focus()
    End Sub

    Public Sub TreeShow(ByVal Tree As BinaryNode, ByVal parentNode As TreeNode, ByVal nodes As TreeNodeCollection)
        If Tree IsNot Nothing Then
            Dim NewNode As New TreeNode(Tree.Data.ToString())
            If parentNode IsNot Nothing Then
                parentNode.Nodes.Add(NewNode)
            Else
                nodes.Add(NewNode)
            End If
            TreeShow(Tree.Left, NewNode, NewNode.Nodes)
            TreeShow(Tree.Right, NewNode, NewNode.Nodes)
        End If
    End Sub

    Public Sub ToursOfTree()
        ListView_PreOden.Items.Clear()
        For Each val As Integer In binaryTree.GetPreOrden()
            ListView_PreOden.Items.Add(val.ToString())
        Next

        ListView_PostOden.Items.Clear()
        For Each val As Integer In binaryTree.GetPostOrden()
            ListView_PostOden.Items.Add(val.ToString())
        Next

        ListView_InOden.Items.Clear()
        For Each val As Integer In binaryTree.GetInOrden()
            ListView_InOden.Items.Add(val.ToString())
        Next
    End Sub

    Shared Sub ShowTree(ByVal Tree As Nodo, ByVal parentNode As TreeNode, ByVal nodes As TreeNodeCollection)
        If Tree IsNot Nothing Then
            Dim NewNode As New TreeNode(Tree.Data.ToString())

            If parentNode IsNot Nothing Then
                parentNode.Nodes.Add(NewNode)
            Else
                nodes.Add(NewNode)
            End If

            ShowTree(Tree.Left, NewNode, NewNode.Nodes)
            ShowTree(Tree.Right, NewNode, NewNode.Nodes)
        End If
    End Sub
#End Region

#Region "Graph"
    Private Sub Add_Vertex_Graph_Click(sender As Object, e As EventArgs) Handles Add_Vertex_Graph.Click
        Dim name As String

        name = TextBox_Add_vertex.Text

        directedGraph.AddVertex(name)

        UpdateViewGraph()

        TextBox_Add_vertex.Clear()
        TextBox_Add_vertex.Focus()
    End Sub

    Private Sub Add_Edge_Graph_Click(sender As Object, e As EventArgs) Handles Add_Edge_Graph.Click
        Dim origin As String
        Dim destination As String

        origin = TextBox_Origin_Graph.Text
        destination = TextBox_Destination_Graph.Text

        directedGraph.AddEdge(origin, destination)

        UpdateViewGraph()

        TextBox_Origin_Graph.Clear()
        TextBox_Destination_Graph.Clear()
    End Sub

    Private Sub UpdateViewGraph()
        Dim imagenGrafo As New Bitmap(PictureBox1.Width, PictureBox1.Height)

        Using g As Graphics = Graphics.FromImage(imagenGrafo)
            For Each vertice In directedGraph._Vertex
                g.FillEllipse(Brushes.Blue, vertice.Valor.X, vertice.Valor.Y, 30, 30)
                g.DrawString(vertice.Nombre, DefaultFont, Brushes.White, vertice.Valor.X + 8, vertice.Valor.Y + 8)
            Next

            For Each arista In directedGraph._Edge
                g.DrawLine(Pens.Black, arista.Origen.Valor.X + 15, arista.Origen.Valor.Y + 15,
                                  arista.Destino.Valor.X + 15, arista.Destino.Valor.Y + 15)
            Next
        End Using

        PictureBox1.Image = imagenGrafo
    End Sub
#End Region

    Public Sub Show(dataArray As String(), list As ListBox)
        list.Items.Clear()

        For index As Integer = 0 To dataArray.Length - 1
            If dataArray(index) Is Nothing Then
                MessageBox.Show("Item array is null")
                Continue For
            End If
            list.Items.Add(dataArray(index))
        Next
    End Sub

    Public Sub Generate(N As Integer)
        For i As Integer = 0 To N - 1
            simpleList.Add(random.Next(10000))
            circularList.Add(random.Next(10000))
            doublyListLinked.Add(random.Next(10000))
            circularDoublyLinkedList.Add(random.Next(10000))
        Next
    End Sub

    Private Sub Generare_Array_Click(sender As Object, e As EventArgs) Handles Generare_Array.Click
        Textbox_Algorithm.Clear()

        Dim size As Integer = Integer.Parse(TextBox_Size_Array.Text)

        array = New Integer(size - 1) {}

        For i As Integer = 0 To size - 1
            array(i) = random.Next(100)
        Next

        PrintArray(array, Textbox_Algorithm)
    End Sub

    Private Sub Show_Algorithm_Click(sender As Object, e As EventArgs) Handles Show_Algorithm.Click
        Textbox_Algorithm.Clear()

        Dim [option] As String = Case_Algorithm.Text

        Select Case [option]
            Case "BubbleSort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._BubbleSort.BubbleSortAlgorithm(array)
                Textbox_Algorithm.Text += ("BubbleSort: ")
            Case "Cocktailsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Cocktailsort.cocktailSort(array)
                Textbox_Algorithm.Text += ("Cocktailsort: ")
            Case "Insertionsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Insertionsort.InsertionSortAlgorithm(array)
                Textbox_Algorithm.Text += ("Insertionsort: ")
            Case "BucketSort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._BucketSort.BucketSort_int(array, Textbox_Algorithm)
                Textbox_Algorithm.Text += ("BucketSort: ")
            Case "Countingsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Countingsort.Sort(array)
                Textbox_Algorithm.Text += ("Countingsort: ")
            Case "Mergesort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Countingsort.Sort(array)
                Textbox_Algorithm.Text += ("Mergesort: ")
            Case "Binarytreesort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Binarytreesort.Sort(array)
                Textbox_Algorithm.Text += ("Binarytreesort: ")
            Case "Pigeonhole"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Pigeonhole.PigeonholeSort(array)
                Textbox_Algorithm.Text += ("Pigeonhole: ")
            Case "Radixsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Radixsort.Sort(array)
                Textbox_Algorithm.Text += ("Radixsort: ")
            Case "Gnomesort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Gnomesort.Sort(array)
                Textbox_Algorithm.Text += ("Gnomesort: ")
            Case "Shellsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Shellsort.Shell_Sort(array, Textbox_Algorithm)
                Textbox_Algorithm.Text += ("Shellsort: ")
            Case "Combsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Combsort.Sort(array)
                Textbox_Algorithm.Text += ("Combsort: ")
            Case "Selectionsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Selectionsort.Sort(array)
                Textbox_Algorithm.Text += ("Selectionsort: ")
            Case "Heapsort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._Heapsort.Sort(array)
                Textbox_Algorithm.Text += ("Heapsort: ")
            Case "QuickSort"
                Textbox_Algorithm.Text = String.Empty
                Textbox_Algorithm.Text += ("Arreglo inicial: ")
                PrintArray(array, Textbox_Algorithm)
                _Call._QuickSort.quicksort(array, 0, array.Length - 1, Textbox_Algorithm)
                Textbox_Algorithm.Text += ("QuickSort: ")
        End Select

        PrintArray(array, Textbox_Algorithm)
    End Sub

    Public Shared array As Integer()

    Private Sub PrintArray(array As Integer(), txtBox As TextBox)
        If array Is Nothing Then
            txtBox.Clear()
        End If
        txtBox.Text += ("[" & String.Join(", ", array) & "]" & vbCrLf)
    End Sub
End Class
