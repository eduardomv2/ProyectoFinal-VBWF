<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        StackMenu = New ToolStripMenuItem()
        QueueMenu = New ToolStripMenuItem()
        ListMenu = New ToolStripMenuItem()
        TreeMenu = New ToolStripMenuItem()
        GraphMenu = New ToolStripMenuItem()
        AlgorithmMenu = New ToolStripMenuItem()
        ListView_StackS = New ListBox()
        ListView_StackD = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Push_Stack = New Button()
        TexBox_Push_Stack = New TextBox()
        Pop_Stack = New Button()
        Peek_Stack = New Button()
        p_Queue = New Panel()
        p_List = New Panel()
        p_Tree = New Panel()
        p_Graph = New Panel()
        p_Algorithm = New Panel()
        Show_Algorithm = New Button()
        Case_Algorithm = New ComboBox()
        Label17 = New Label()
        Textbox_Algorithm = New TextBox()
        Label16 = New Label()
        TextBox_Size_Array = New TextBox()
        Generare_Array = New Button()
        Label15 = New Label()
        Label14 = New Label()
        Add_Edge_Graph = New Button()
        TextBox_Destination_Graph = New TextBox()
        TextBox_Origin_Graph = New TextBox()
        PictureBox1 = New PictureBox()
        TextBox_Add_vertex = New TextBox()
        Add_Vertex_Graph = New Button()
        Label13 = New Label()
        ListView_PostOden = New ListView()
        Label12 = New Label()
        ListView_InOden = New ListView()
        Label11 = New Label()
        ListView_PreOden = New ListView()
        TexBox_Search_BinaryTree = New TextBox()
        Search_BinaryTree = New Button()
        TreeView = New TreeView()
        Label10 = New Label()
        TexBox_Delete_BinaryTree = New TextBox()
        Delete_BinaryTree = New Button()
        TexBox_Add_BinaryTree = New TextBox()
        Add_BinaryTree = New Button()
        TexBox_Delete_List = New TextBox()
        Delete_List = New Button()
        Label8 = New Label()
        ListView_CircularDoublyLinkedList = New ListBox()
        Label9 = New Label()
        ListView_CircularList = New ListBox()
        Label7 = New Label()
        ListView_DoublyLinkedList = New ListBox()
        TexBox_Generate_List = New TextBox()
        Generate_List = New Button()
        Label6 = New Label()
        ListView_SimpleList = New ListBox()
        TexBox_Add_List = New TextBox()
        Add_List = New Button()
        Dequeue = New Button()
        TexBox_Priority_PriorityQueue = New TextBox()
        Priority_PriorityQueue = New Button()
        Label5 = New Label()
        ListView_PriorityQueue = New ListBox()
        TexBox_Enqueue_Queue = New TextBox()
        Enqueue_Queue = New Button()
        Label3 = New Label()
        Label4 = New Label()
        ListView_CircularQueue = New ListBox()
        ListView_Queue = New ListBox()
        MenuStrip1.SuspendLayout()
        p_Queue.SuspendLayout()
        p_List.SuspendLayout()
        p_Tree.SuspendLayout()
        p_Graph.SuspendLayout()
        p_Algorithm.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {StackMenu, QueueMenu, ListMenu, TreeMenu, GraphMenu, AlgorithmMenu})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(854, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' StackMenu
        ' 
        StackMenu.Name = "StackMenu"
        StackMenu.Size = New Size(47, 20)
        StackMenu.Text = "Stack"
        ' 
        ' QueueMenu
        ' 
        QueueMenu.Name = "QueueMenu"
        QueueMenu.Size = New Size(54, 20)
        QueueMenu.Text = "Queue"
        ' 
        ' ListMenu
        ' 
        ListMenu.Name = "ListMenu"
        ListMenu.Size = New Size(37, 20)
        ListMenu.Text = "List"
        ' 
        ' TreeMenu
        ' 
        TreeMenu.Name = "TreeMenu"
        TreeMenu.Size = New Size(40, 20)
        TreeMenu.Text = "Tree"
        ' 
        ' GraphMenu
        ' 
        GraphMenu.Name = "GraphMenu"
        GraphMenu.Size = New Size(51, 20)
        GraphMenu.Text = "Graph"
        ' 
        ' AlgorithmMenu
        ' 
        AlgorithmMenu.Name = "AlgorithmMenu"
        AlgorithmMenu.Size = New Size(73, 20)
        AlgorithmMenu.Text = "Algorithm"
        ' 
        ' ListView_StackS
        ' 
        ListView_StackS.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_StackS.FormattingEnabled = True
        ListView_StackS.ItemHeight = 21
        ListView_StackS.Location = New Point(131, 75)
        ListView_StackS.Name = "ListView_StackS"
        ListView_StackS.Size = New Size(187, 382)
        ListView_StackS.TabIndex = 1
        ' 
        ' ListView_StackD
        ' 
        ListView_StackD.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_StackD.FormattingEnabled = True
        ListView_StackD.ItemHeight = 21
        ListView_StackD.Location = New Point(344, 75)
        ListView_StackD.Name = "ListView_StackD"
        ListView_StackD.Size = New Size(187, 382)
        ListView_StackD.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(173, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 3
        Label1.Text = "Stack Static"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(373, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 25)
        Label2.TabIndex = 4
        Label2.Text = "Stack Dinamic"
        ' 
        ' Push_Stack
        ' 
        Push_Stack.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Push_Stack.Location = New Point(646, 151)
        Push_Stack.Name = "Push_Stack"
        Push_Stack.Size = New Size(165, 45)
        Push_Stack.TabIndex = 5
        Push_Stack.Text = "Push"
        Push_Stack.UseVisualStyleBackColor = True
        ' 
        ' TexBox_Push_Stack
        ' 
        TexBox_Push_Stack.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Push_Stack.Location = New Point(646, 102)
        TexBox_Push_Stack.Name = "TexBox_Push_Stack"
        TexBox_Push_Stack.Size = New Size(165, 33)
        TexBox_Push_Stack.TabIndex = 6
        ' 
        ' Pop_Stack
        ' 
        Pop_Stack.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Pop_Stack.Location = New Point(646, 214)
        Pop_Stack.Name = "Pop_Stack"
        Pop_Stack.Size = New Size(165, 45)
        Pop_Stack.TabIndex = 7
        Pop_Stack.Text = "Pop"
        Pop_Stack.UseVisualStyleBackColor = True
        ' 
        ' Peek_Stack
        ' 
        Peek_Stack.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Peek_Stack.Location = New Point(646, 279)
        Peek_Stack.Name = "Peek_Stack"
        Peek_Stack.Size = New Size(165, 45)
        Peek_Stack.TabIndex = 8
        Peek_Stack.Text = "Peek"
        Peek_Stack.UseVisualStyleBackColor = True
        ' 
        ' p_Queue
        ' 
        p_Queue.Controls.Add(p_List)
        p_Queue.Controls.Add(Dequeue)
        p_Queue.Controls.Add(TexBox_Priority_PriorityQueue)
        p_Queue.Controls.Add(Priority_PriorityQueue)
        p_Queue.Controls.Add(Label5)
        p_Queue.Controls.Add(ListView_PriorityQueue)
        p_Queue.Controls.Add(TexBox_Enqueue_Queue)
        p_Queue.Controls.Add(Enqueue_Queue)
        p_Queue.Controls.Add(Label3)
        p_Queue.Controls.Add(Label4)
        p_Queue.Controls.Add(ListView_CircularQueue)
        p_Queue.Controls.Add(ListView_Queue)
        p_Queue.Location = New Point(12, 27)
        p_Queue.Name = "p_Queue"
        p_Queue.Size = New Size(799, 430)
        p_Queue.TabIndex = 9
        p_Queue.Visible = False
        ' 
        ' p_List
        ' 
        p_List.Controls.Add(p_Tree)
        p_List.Controls.Add(TexBox_Delete_List)
        p_List.Controls.Add(Delete_List)
        p_List.Controls.Add(Label8)
        p_List.Controls.Add(ListView_CircularDoublyLinkedList)
        p_List.Controls.Add(Label9)
        p_List.Controls.Add(ListView_CircularList)
        p_List.Controls.Add(Label7)
        p_List.Controls.Add(ListView_DoublyLinkedList)
        p_List.Controls.Add(TexBox_Generate_List)
        p_List.Controls.Add(Generate_List)
        p_List.Controls.Add(Label6)
        p_List.Controls.Add(ListView_SimpleList)
        p_List.Controls.Add(TexBox_Add_List)
        p_List.Controls.Add(Add_List)
        p_List.Location = New Point(0, 0)
        p_List.Name = "p_List"
        p_List.Size = New Size(799, 430)
        p_List.TabIndex = 22
        p_List.Visible = False
        ' 
        ' p_Tree
        ' 
        p_Tree.Controls.Add(p_Graph)
        p_Tree.Controls.Add(Label13)
        p_Tree.Controls.Add(ListView_PostOden)
        p_Tree.Controls.Add(Label12)
        p_Tree.Controls.Add(ListView_InOden)
        p_Tree.Controls.Add(Label11)
        p_Tree.Controls.Add(ListView_PreOden)
        p_Tree.Controls.Add(TexBox_Search_BinaryTree)
        p_Tree.Controls.Add(Search_BinaryTree)
        p_Tree.Controls.Add(TreeView)
        p_Tree.Controls.Add(Label10)
        p_Tree.Controls.Add(TexBox_Delete_BinaryTree)
        p_Tree.Controls.Add(Delete_BinaryTree)
        p_Tree.Controls.Add(TexBox_Add_BinaryTree)
        p_Tree.Controls.Add(Add_BinaryTree)
        p_Tree.Location = New Point(0, 0)
        p_Tree.Name = "p_Tree"
        p_Tree.Size = New Size(799, 430)
        p_Tree.TabIndex = 37
        p_Tree.Visible = False
        ' 
        ' p_Graph
        ' 
        p_Graph.Controls.Add(p_Algorithm)
        p_Graph.Controls.Add(Label15)
        p_Graph.Controls.Add(Label14)
        p_Graph.Controls.Add(Add_Edge_Graph)
        p_Graph.Controls.Add(TextBox_Destination_Graph)
        p_Graph.Controls.Add(TextBox_Origin_Graph)
        p_Graph.Controls.Add(PictureBox1)
        p_Graph.Controls.Add(TextBox_Add_vertex)
        p_Graph.Controls.Add(Add_Vertex_Graph)
        p_Graph.Location = New Point(0, 0)
        p_Graph.Name = "p_Graph"
        p_Graph.Size = New Size(799, 430)
        p_Graph.TabIndex = 51
        p_Graph.Visible = False
        ' 
        ' p_Algorithm
        ' 
        p_Algorithm.Controls.Add(Show_Algorithm)
        p_Algorithm.Controls.Add(Case_Algorithm)
        p_Algorithm.Controls.Add(Label17)
        p_Algorithm.Controls.Add(Textbox_Algorithm)
        p_Algorithm.Controls.Add(Label16)
        p_Algorithm.Controls.Add(TextBox_Size_Array)
        p_Algorithm.Controls.Add(Generare_Array)
        p_Algorithm.Location = New Point(0, 0)
        p_Algorithm.Name = "p_Algorithm"
        p_Algorithm.Size = New Size(799, 430)
        p_Algorithm.TabIndex = 47
        ' 
        ' Show_Algorithm
        ' 
        Show_Algorithm.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Show_Algorithm.Location = New Point(116, 193)
        Show_Algorithm.Name = "Show_Algorithm"
        Show_Algorithm.Size = New Size(165, 45)
        Show_Algorithm.TabIndex = 52
        Show_Algorithm.Text = "Show"
        Show_Algorithm.UseVisualStyleBackColor = True
        ' 
        ' Case_Algorithm
        ' 
        Case_Algorithm.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Case_Algorithm.FormattingEnabled = True
        Case_Algorithm.Items.AddRange(New Object() {"BubbleSort", "Cocktailsort", "Insertionsort", "BucketSort", "Countingsort", "Mergesort", "Binarytreesort", "Pigeonhole", "Radixsort", "Gnomesort", "Shellsort", "Combsort", "Selectionsort", "Heapsort", "QuickSort"})
        Case_Algorithm.Location = New Point(116, 154)
        Case_Algorithm.Name = "Case_Algorithm"
        Case_Algorithm.Size = New Size(165, 33)
        Case_Algorithm.TabIndex = 51
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(3, 157)
        Label17.Name = "Label17"
        Label17.Size = New Size(110, 25)
        Label17.TabIndex = 50
        Label17.Text = "Algorithm:"
        ' 
        ' Textbox_Algorithm
        ' 
        Textbox_Algorithm.BackColor = Color.White
        Textbox_Algorithm.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Textbox_Algorithm.Location = New Point(327, 20)
        Textbox_Algorithm.Multiline = True
        Textbox_Algorithm.Name = "Textbox_Algorithm"
        Textbox_Algorithm.ReadOnly = True
        Textbox_Algorithm.ScrollBars = ScrollBars.Both
        Textbox_Algorithm.Size = New Size(469, 399)
        Textbox_Algorithm.TabIndex = 49
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(42, 53)
        Label16.Name = "Label16"
        Label16.Size = New Size(55, 25)
        Label16.TabIndex = 48
        Label16.Text = "Size:"
        ' 
        ' TextBox_Size_Array
        ' 
        TextBox_Size_Array.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Size_Array.Location = New Point(116, 50)
        TextBox_Size_Array.Name = "TextBox_Size_Array"
        TextBox_Size_Array.Size = New Size(165, 33)
        TextBox_Size_Array.TabIndex = 47
        ' 
        ' Generare_Array
        ' 
        Generare_Array.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Generare_Array.Location = New Point(116, 89)
        Generare_Array.Name = "Generare_Array"
        Generare_Array.Size = New Size(165, 45)
        Generare_Array.TabIndex = 46
        Generare_Array.Text = "Generare"
        Generare_Array.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(504, 183)
        Label15.Name = "Label15"
        Label15.Size = New Size(124, 25)
        Label15.TabIndex = 46
        Label15.Text = "Destination:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(504, 141)
        Label14.Name = "Label14"
        Label14.Size = New Size(76, 25)
        Label14.TabIndex = 45
        Label14.Text = "Origin:"
        ' 
        ' Add_Edge_Graph
        ' 
        Add_Edge_Graph.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Add_Edge_Graph.Location = New Point(631, 214)
        Add_Edge_Graph.Name = "Add_Edge_Graph"
        Add_Edge_Graph.Size = New Size(165, 45)
        Add_Edge_Graph.TabIndex = 44
        Add_Edge_Graph.Text = "Add Edge"
        Add_Edge_Graph.UseVisualStyleBackColor = True
        ' 
        ' TextBox_Destination_Graph
        ' 
        TextBox_Destination_Graph.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Destination_Graph.Location = New Point(631, 177)
        TextBox_Destination_Graph.Name = "TextBox_Destination_Graph"
        TextBox_Destination_Graph.Size = New Size(165, 33)
        TextBox_Destination_Graph.TabIndex = 43
        ' 
        ' TextBox_Origin_Graph
        ' 
        TextBox_Origin_Graph.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Origin_Graph.Location = New Point(631, 138)
        TextBox_Origin_Graph.Name = "TextBox_Origin_Graph"
        TextBox_Origin_Graph.Size = New Size(165, 33)
        TextBox_Origin_Graph.TabIndex = 42
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(488, 424)
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' TextBox_Add_vertex
        ' 
        TextBox_Add_vertex.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Add_vertex.Location = New Point(631, 48)
        TextBox_Add_vertex.Name = "TextBox_Add_vertex"
        TextBox_Add_vertex.Size = New Size(165, 33)
        TextBox_Add_vertex.TabIndex = 40
        ' 
        ' Add_Vertex_Graph
        ' 
        Add_Vertex_Graph.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Add_Vertex_Graph.Location = New Point(631, 87)
        Add_Vertex_Graph.Name = "Add_Vertex_Graph"
        Add_Vertex_Graph.Size = New Size(165, 45)
        Add_Vertex_Graph.TabIndex = 39
        Add_Vertex_Graph.Text = "Add Vertex"
        Add_Vertex_Graph.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(287, 302)
        Label13.Name = "Label13"
        Label13.Size = New Size(101, 25)
        Label13.TabIndex = 50
        Label13.Text = "PostOrden"
        ' 
        ' ListView_PostOden
        ' 
        ListView_PostOden.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_PostOden.Location = New Point(287, 329)
        ListView_PostOden.Name = "ListView_PostOden"
        ListView_PostOden.Size = New Size(307, 97)
        ListView_PostOden.TabIndex = 49
        ListView_PostOden.UseCompatibleStateImageBehavior = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(287, 175)
        Label12.Name = "Label12"
        Label12.Size = New Size(81, 25)
        Label12.TabIndex = 48
        Label12.Text = "InOrden"
        ' 
        ' ListView_InOden
        ' 
        ListView_InOden.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_InOden.Location = New Point(287, 202)
        ListView_InOden.Name = "ListView_InOden"
        ListView_InOden.Size = New Size(307, 97)
        ListView_InOden.TabIndex = 47
        ListView_InOden.UseCompatibleStateImageBehavior = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(287, 48)
        Label11.Name = "Label11"
        Label11.Size = New Size(93, 25)
        Label11.TabIndex = 46
        Label11.Text = "PreOrden"
        ' 
        ' ListView_PreOden
        ' 
        ListView_PreOden.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_PreOden.Location = New Point(287, 75)
        ListView_PreOden.Name = "ListView_PreOden"
        ListView_PreOden.Size = New Size(307, 97)
        ListView_PreOden.TabIndex = 45
        ListView_PreOden.UseCompatibleStateImageBehavior = False
        ' 
        ' TexBox_Search_BinaryTree
        ' 
        TexBox_Search_BinaryTree.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Search_BinaryTree.Location = New Point(631, 213)
        TexBox_Search_BinaryTree.Name = "TexBox_Search_BinaryTree"
        TexBox_Search_BinaryTree.Size = New Size(165, 33)
        TexBox_Search_BinaryTree.TabIndex = 44
        ' 
        ' Search_BinaryTree
        ' 
        Search_BinaryTree.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Search_BinaryTree.Location = New Point(631, 252)
        Search_BinaryTree.Name = "Search_BinaryTree"
        Search_BinaryTree.Size = New Size(165, 45)
        Search_BinaryTree.TabIndex = 43
        Search_BinaryTree.Text = "Search"
        Search_BinaryTree.UseVisualStyleBackColor = True
        ' 
        ' TreeView
        ' 
        TreeView.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TreeView.Location = New Point(12, 34)
        TreeView.Name = "TreeView"
        TreeView.Size = New Size(256, 390)
        TreeView.TabIndex = 42
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(90, 6)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 25)
        Label10.TabIndex = 41
        Label10.Text = "Binary Tree"
        ' 
        ' TexBox_Delete_BinaryTree
        ' 
        TexBox_Delete_BinaryTree.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Delete_BinaryTree.Location = New Point(631, 124)
        TexBox_Delete_BinaryTree.Name = "TexBox_Delete_BinaryTree"
        TexBox_Delete_BinaryTree.Size = New Size(165, 33)
        TexBox_Delete_BinaryTree.TabIndex = 40
        ' 
        ' Delete_BinaryTree
        ' 
        Delete_BinaryTree.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Delete_BinaryTree.Location = New Point(631, 163)
        Delete_BinaryTree.Name = "Delete_BinaryTree"
        Delete_BinaryTree.Size = New Size(165, 45)
        Delete_BinaryTree.TabIndex = 39
        Delete_BinaryTree.Text = "Delete"
        Delete_BinaryTree.UseVisualStyleBackColor = True
        ' 
        ' TexBox_Add_BinaryTree
        ' 
        TexBox_Add_BinaryTree.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Add_BinaryTree.Location = New Point(631, 34)
        TexBox_Add_BinaryTree.Name = "TexBox_Add_BinaryTree"
        TexBox_Add_BinaryTree.Size = New Size(165, 33)
        TexBox_Add_BinaryTree.TabIndex = 38
        ' 
        ' Add_BinaryTree
        ' 
        Add_BinaryTree.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Add_BinaryTree.Location = New Point(631, 73)
        Add_BinaryTree.Name = "Add_BinaryTree"
        Add_BinaryTree.Size = New Size(165, 45)
        Add_BinaryTree.TabIndex = 37
        Add_BinaryTree.Text = "Add"
        Add_BinaryTree.UseVisualStyleBackColor = True
        ' 
        ' TexBox_Delete_List
        ' 
        TexBox_Delete_List.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Delete_List.Location = New Point(600, 145)
        TexBox_Delete_List.Name = "TexBox_Delete_List"
        TexBox_Delete_List.Size = New Size(165, 33)
        TexBox_Delete_List.TabIndex = 36
        ' 
        ' Delete_List
        ' 
        Delete_List.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Delete_List.Location = New Point(600, 184)
        Delete_List.Name = "Delete_List"
        Delete_List.Size = New Size(165, 45)
        Delete_List.TabIndex = 35
        Delete_List.Text = "Delete"
        Delete_List.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(283, 224)
        Label8.Name = "Label8"
        Label8.Size = New Size(236, 25)
        Label8.TabIndex = 34
        Label8.Text = "Circular Doubly Linked List"
        ' 
        ' ListView_CircularDoublyLinkedList
        ' 
        ListView_CircularDoublyLinkedList.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_CircularDoublyLinkedList.FormattingEnabled = True
        ListView_CircularDoublyLinkedList.ItemHeight = 21
        ListView_CircularDoublyLinkedList.Location = New Point(287, 252)
        ListView_CircularDoublyLinkedList.Name = "ListView_CircularDoublyLinkedList"
        ListView_CircularDoublyLinkedList.Size = New Size(224, 172)
        ListView_CircularDoublyLinkedList.TabIndex = 33
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(346, 6)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 25)
        Label9.TabIndex = 32
        Label9.Text = "CircularList"
        ' 
        ' ListView_CircularList
        ' 
        ListView_CircularList.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_CircularList.FormattingEnabled = True
        ListView_CircularList.ItemHeight = 21
        ListView_CircularList.Location = New Point(287, 34)
        ListView_CircularList.Name = "ListView_CircularList"
        ListView_CircularList.Size = New Size(224, 172)
        ListView_CircularList.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(44, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(165, 25)
        Label7.TabIndex = 30
        Label7.Text = "Doubly Linked List"
        ' 
        ' ListView_DoublyLinkedList
        ' 
        ListView_DoublyLinkedList.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_DoublyLinkedList.FormattingEnabled = True
        ListView_DoublyLinkedList.ItemHeight = 21
        ListView_DoublyLinkedList.Location = New Point(21, 249)
        ListView_DoublyLinkedList.Name = "ListView_DoublyLinkedList"
        ListView_DoublyLinkedList.Size = New Size(224, 172)
        ListView_DoublyLinkedList.TabIndex = 29
        ' 
        ' TexBox_Generate_List
        ' 
        TexBox_Generate_List.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Generate_List.Location = New Point(600, 303)
        TexBox_Generate_List.Name = "TexBox_Generate_List"
        TexBox_Generate_List.Size = New Size(165, 33)
        TexBox_Generate_List.TabIndex = 27
        ' 
        ' Generate_List
        ' 
        Generate_List.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Generate_List.Location = New Point(600, 339)
        Generate_List.Name = "Generate_List"
        Generate_List.Size = New Size(165, 45)
        Generate_List.TabIndex = 26
        Generate_List.Text = "Generate"
        Generate_List.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(65, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 25)
        Label6.TabIndex = 25
        Label6.Text = "SimpleList"
        ' 
        ' ListView_SimpleList
        ' 
        ListView_SimpleList.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_SimpleList.FormattingEnabled = True
        ListView_SimpleList.ItemHeight = 21
        ListView_SimpleList.Location = New Point(21, 31)
        ListView_SimpleList.Name = "ListView_SimpleList"
        ListView_SimpleList.Size = New Size(224, 172)
        ListView_SimpleList.TabIndex = 24
        ' 
        ' TexBox_Add_List
        ' 
        TexBox_Add_List.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Add_List.Location = New Point(600, 55)
        TexBox_Add_List.Name = "TexBox_Add_List"
        TexBox_Add_List.Size = New Size(165, 33)
        TexBox_Add_List.TabIndex = 23
        ' 
        ' Add_List
        ' 
        Add_List.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Add_List.Location = New Point(600, 94)
        Add_List.Name = "Add_List"
        Add_List.Size = New Size(165, 45)
        Add_List.TabIndex = 22
        Add_List.Text = "Add"
        Add_List.UseVisualStyleBackColor = True
        ' 
        ' Dequeue
        ' 
        Dequeue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Dequeue.Location = New Point(616, 148)
        Dequeue.Name = "Dequeue"
        Dequeue.Size = New Size(165, 45)
        Dequeue.TabIndex = 21
        Dequeue.Text = "Dequeue"
        Dequeue.UseVisualStyleBackColor = True
        ' 
        ' TexBox_Priority_PriorityQueue
        ' 
        TexBox_Priority_PriorityQueue.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Priority_PriorityQueue.Location = New Point(616, 213)
        TexBox_Priority_PriorityQueue.Name = "TexBox_Priority_PriorityQueue"
        TexBox_Priority_PriorityQueue.Size = New Size(165, 33)
        TexBox_Priority_PriorityQueue.TabIndex = 20
        ' 
        ' Priority_PriorityQueue
        ' 
        Priority_PriorityQueue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Priority_PriorityQueue.Location = New Point(616, 262)
        Priority_PriorityQueue.Name = "Priority_PriorityQueue"
        Priority_PriorityQueue.Size = New Size(165, 45)
        Priority_PriorityQueue.TabIndex = 19
        Priority_PriorityQueue.Text = "Priority"
        Priority_PriorityQueue.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(415, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 25)
        Label5.TabIndex = 18
        Label5.Text = "Priority Queue"
        ' 
        ' ListView_PriorityQueue
        ' 
        ListView_PriorityQueue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_PriorityQueue.FormattingEnabled = True
        ListView_PriorityQueue.ItemHeight = 21
        ListView_PriorityQueue.Location = New Point(386, 48)
        ListView_PriorityQueue.Name = "ListView_PriorityQueue"
        ListView_PriorityQueue.Size = New Size(187, 382)
        ListView_PriorityQueue.TabIndex = 17
        ' 
        ' TexBox_Enqueue_Queue
        ' 
        TexBox_Enqueue_Queue.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TexBox_Enqueue_Queue.Location = New Point(616, 48)
        TexBox_Enqueue_Queue.Name = "TexBox_Enqueue_Queue"
        TexBox_Enqueue_Queue.Size = New Size(165, 33)
        TexBox_Enqueue_Queue.TabIndex = 14
        ' 
        ' Enqueue_Queue
        ' 
        Enqueue_Queue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Enqueue_Queue.Location = New Point(616, 97)
        Enqueue_Queue.Name = "Enqueue_Queue"
        Enqueue_Queue.Size = New Size(165, 45)
        Enqueue_Queue.TabIndex = 13
        Enqueue_Queue.Text = "Enqueue"
        Enqueue_Queue.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(225, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 25)
        Label3.TabIndex = 12
        Label3.Text = "Circular Queue"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(44, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 25)
        Label4.TabIndex = 11
        Label4.Text = "Queue"
        ' 
        ' ListView_CircularQueue
        ' 
        ListView_CircularQueue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_CircularQueue.FormattingEnabled = True
        ListView_CircularQueue.ItemHeight = 21
        ListView_CircularQueue.Location = New Point(193, 48)
        ListView_CircularQueue.Name = "ListView_CircularQueue"
        ListView_CircularQueue.Size = New Size(187, 382)
        ListView_CircularQueue.TabIndex = 10
        ' 
        ' ListView_Queue
        ' 
        ListView_Queue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView_Queue.FormattingEnabled = True
        ListView_Queue.ItemHeight = 21
        ListView_Queue.Location = New Point(0, 48)
        ListView_Queue.Name = "ListView_Queue"
        ListView_Queue.Size = New Size(187, 382)
        ListView_Queue.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(854, 499)
        Controls.Add(p_Queue)
        Controls.Add(Peek_Stack)
        Controls.Add(Pop_Stack)
        Controls.Add(TexBox_Push_Stack)
        Controls.Add(Push_Stack)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListView_StackD)
        Controls.Add(ListView_StackS)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        p_Queue.ResumeLayout(False)
        p_Queue.PerformLayout()
        p_List.ResumeLayout(False)
        p_List.PerformLayout()
        p_Tree.ResumeLayout(False)
        p_Tree.PerformLayout()
        p_Graph.ResumeLayout(False)
        p_Graph.PerformLayout()
        p_Algorithm.ResumeLayout(False)
        p_Algorithm.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StackMenu As ToolStripMenuItem
    Friend WithEvents QueueMenu As ToolStripMenuItem
    Friend WithEvents ListMenu As ToolStripMenuItem
    Friend WithEvents TreeMenu As ToolStripMenuItem
    Friend WithEvents GraphMenu As ToolStripMenuItem
    Friend WithEvents AlgorithmMenu As ToolStripMenuItem
    Friend WithEvents ListView_StackS As ListBox
    Friend WithEvents ListView_StackD As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Push_Stack As Button
    Friend WithEvents TexBox_Push_Stack As TextBox
    Friend WithEvents Pop_Stack As Button
    Friend WithEvents Peek_Stack As Button
    Friend WithEvents p_Queue As Panel
    Friend WithEvents Add_Edge_Graph As Button
    Friend WithEvents Generate_List As Button
    Friend WithEvents TexBox_Enqueue_Queue As TextBox
    Friend WithEvents Enqueue_Queue As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView_CircularQueue As ListBox
    Friend WithEvents ListView_Queue As ListBox
    Friend WithEvents ListView_PriorityQueue As ListBox
    Friend WithEvents TexBox_Priority_PriorityQueue As TextBox
    Friend WithEvents Priority_PriorityQueue As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Dequeue As Button
    Friend WithEvents p_List As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ListView_CircularDoublyLinkedList As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView_CircularList As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView_DoublyLinkedList As ListBox
    Friend WithEvents TexBox_Generate_List As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView_SimpleList As ListBox
    Friend WithEvents TexBox_Add_List As TextBox
    Friend WithEvents Add_List As Button
    Friend WithEvents TexBox_Delete_List As TextBox
    Friend WithEvents Delete_List As Button
    Friend WithEvents p_Tree As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents ListView_PostOden As ListView
    Friend WithEvents Label12 As Label
    Friend WithEvents ListView_InOden As ListView
    Friend WithEvents Label11 As Label
    Friend WithEvents ListView_PreOden As ListView
    Friend WithEvents TexBox_Search_BinaryTree As TextBox
    Friend WithEvents Search_BinaryTree As Button
    Friend WithEvents TreeView As TreeView
    Friend WithEvents Label10 As Label
    Friend WithEvents TexBox_Delete_BinaryTree As TextBox
    Friend WithEvents Delete_BinaryTree As Button
    Friend WithEvents TexBox_Add_BinaryTree As TextBox
    Friend WithEvents Add_BinaryTree As Button
    Friend WithEvents p_Graph As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox_Add_vertex As TextBox
    Friend WithEvents Add_Vertex_Graph As Button
    Friend WithEvents TextBox_Destination_Graph As TextBox
    Friend WithEvents TextBox_Origin_Graph As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents p_Algorithm As Panel
    Friend WithEvents Textbox_Algorithm As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox_Size_Array As TextBox
    Friend WithEvents Generare_Array As Button
    Friend WithEvents Case_Algorithm As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Show_Algorithm As Button
End Class
