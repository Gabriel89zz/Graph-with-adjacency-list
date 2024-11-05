Imports System.Text

Public Class Graph
    Public Property Nodes As List(Of Node)
    Public Property AdjacencyList As List(Of List(Of Edge))

    Public Sub New()
        Nodes = New List(Of Node)()
        AdjacencyList = New List(Of List(Of Edge))()
    End Sub

    Public Sub AddNode(newNode As Node)
        Nodes.Add(newNode)
        AdjacencyList.Add(New List(Of Edge)())
    End Sub

    Public Sub AddEdge(fromNode As Node, toNode As Node)
        If Nodes.Contains(fromNode) AndAlso Nodes.Contains(toNode) Then
            Dim newEdge As New Edge(toNode)
            fromNode.Neighbors.Add(newEdge)
            AdjacencyList(Nodes.IndexOf(fromNode)).Add(newEdge)
        End If
    End Sub

    Public Sub Clear()
        Nodes.Clear()
        AdjacencyList.Clear()
    End Sub

    Public Sub AddEdge(fromNode As Node, toNode As Node, weight As Integer)
        If Nodes.Contains(fromNode) AndAlso Nodes.Contains(toNode) Then
            Dim newEdge As New Edge(toNode, weight)
            fromNode.Neighbors.Add(newEdge)
            AdjacencyList(Nodes.IndexOf(fromNode)).Add(newEdge)
        End If
    End Sub

    Public Sub AddNoDirectedEdge(node1 As Node, node2 As Node, weight As Integer)
        AddEdge(node1, node2, weight)
        AddEdge(node2, node1, weight)
    End Sub

    Public Sub AddNoDirectedEdge(node1 As Node, node2 As Node)
        AddEdge(node1, node2)
        AddEdge(node2, node1)
    End Sub

    Public Sub RemoveNode(nodeToRemove As Node)
        If Nodes.Contains(nodeToRemove) Then
            Dim index As Integer = Nodes.IndexOf(nodeToRemove)
            Nodes.RemoveAt(index)
            AdjacencyList.RemoveAt(index)

            For Each node As Node In Nodes
                node.Neighbors.RemoveAll(Function(edge) edge.ToNode Is nodeToRemove)
            Next

            For Each adjList In AdjacencyList
                adjList.RemoveAll(Function(edge) edge.ToNode Is nodeToRemove)
            Next
        End If
    End Sub

    Public Sub RemoveNoDirectedEdge(node1 As Node, node2 As Node)
        RemoveEdge(node1, node2)
        RemoveEdge(node2, node1)
    End Sub

    Public Sub RemoveEdge(fromNode As Node, toNode As Node)
        If Nodes.Contains(fromNode) AndAlso Nodes.Contains(toNode) Then
            Dim edgeToRemove As Edge = fromNode.Neighbors.Find(Function(e) e.ToNode Is toNode)
            If edgeToRemove IsNot Nothing Then
                fromNode.Neighbors.Remove(edgeToRemove)
                AdjacencyList(Nodes.IndexOf(fromNode)).Remove(edgeToRemove)
            End If
        End If
    End Sub

    Public Sub RemoveGraph()
        Nodes.Clear()
        AdjacencyList.Clear()
    End Sub

    Public Function ShowAdjacencyList() As String
        Dim sb As New StringBuilder()

        For i As Integer = 0 To Nodes.Count - 1
            sb.Append($"{Nodes(i).Name}: ")
            For Each edge In AdjacencyList(i)
                sb.Append($"{edge.ToNode.Name}, ")
            Next
            sb.AppendLine()
        Next

        Return sb.ToString()
    End Function

    Public Function ShowAdjacencyListWithWeights() As String
        Dim sb As New StringBuilder()

        For i As Integer = 0 To Nodes.Count - 1
            sb.Append($"{Nodes(i).Name}: ")
            For Each edge In AdjacencyList(i)
                sb.Append($"{edge.ToNode.Name} ({edge.Weight}), ")
            Next
            sb.AppendLine()
        Next

        Return sb.ToString()
    End Function

    Public Function DFS(startNode As Node) As String
        If startNode Is Nothing OrElse Not Nodes.Contains(startNode) Then Return String.Empty

        Dim visited As New List(Of Node)()
        Dim result As New StringBuilder()

        DFSRecursive(startNode, visited, result)

        Return result.ToString()
    End Function

    Private Sub DFSRecursive(currentNode As Node, visited As List(Of Node), result As StringBuilder)
        visited.Add(currentNode)

        If result.Length > 0 Then
            result.Append(" → ")
        End If
        result.Append(currentNode.Name)

        For Each edge As Edge In currentNode.Neighbors
            Dim adjacentNode As Node = edge.ToNode
            If Not visited.Contains(adjacentNode) Then
                DFSRecursive(adjacentNode, visited, result)
            End If
        Next
    End Sub

    Public Function DFSIterative(startNode As Node) As String
        If startNode Is Nothing OrElse Not Nodes.Contains(startNode) Then Return String.Empty

        Dim visited As New List(Of Node)()
        Dim stack As New Stack(Of Node)()
        Dim result As New StringBuilder()

        stack.Push(startNode)

        While stack.Count > 0
            Dim currentNode As Node = stack.Pop()

            If Not visited.Contains(currentNode) Then
                If result.Length > 0 Then
                    result.Append(" → ")
                End If
                result.Append(currentNode.Name)

                visited.Add(currentNode)

                Dim reversedEdges As List(Of Edge) = currentNode.Neighbors.OrderByDescending(Function(e) e.ToNode.Name).ToList()

                For Each edge As Edge In reversedEdges
                    Dim adjacentNode As Node = edge.ToNode
                    If Not visited.Contains(adjacentNode) Then
                        stack.Push(adjacentNode)
                    End If
                Next
            End If
        End While

        Return result.ToString()
    End Function

    Public Function BFS(startNode As Node) As String
        If startNode Is Nothing OrElse Not Nodes.Contains(startNode) Then Return String.Empty

        Dim visited As New List(Of Node)()
        Dim queue As New Queue(Of Node)()
        Dim result As New StringBuilder()

        queue.Enqueue(startNode)

        While queue.Count > 0
            Dim currentNode As Node = queue.Dequeue()

            If Not visited.Contains(currentNode) Then
                If result.Length > 0 Then
                    result.Append(" → ")
                End If
                result.Append(currentNode.Name)

                visited.Add(currentNode)

                For Each edge As Edge In currentNode.Neighbors
                    Dim adjacentNode As Node = edge.ToNode
                    If Not visited.Contains(adjacentNode) AndAlso Not queue.Contains(adjacentNode) Then
                        queue.Enqueue(adjacentNode)
                    End If
                Next
            End If
        End While

        Return result.ToString()
    End Function
End Class

