Public Class Form1
    Private graph As Graph

    Public Sub New()
        InitializeComponent()
        graph = New Graph()
    End Sub

    Private Sub btnAddNode_Click(sender As Object, e As EventArgs) Handles btnAddNode.Click
        Dim nodeName As String = txtNode.Text.Trim()
        If Not String.IsNullOrEmpty(nodeName) Then
            ' Verificar si el nodo ya existe en el grafo
            If graph.Nodes.Any(Function(node) node.Name = nodeName) Then
                MessageBox.Show($"The node '{nodeName}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Si no existe, añadir el nodo
                Dim newNode As New Node(nodeName)
                graph.AddNode(newNode)
                MessageBox.Show($"Node '{nodeName}' added.", "Success", MessageBoxButtons.OK)
                txtNode.Clear()

                Dim weightText As String = txtWeight.Text.Trim()
                Dim weight As Integer ' Declaración de la variable weight
                If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, weight) Then
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
                Else
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList()
                End If
            End If
        End If
    End Sub


    Private Sub btnAddEdge_Click(sender As Object, e As EventArgs) Handles btnAddEdge.Click
        Dim fromNodeName As String = txtFrom.Text.Trim()
        Dim toNodeName As String = txtTo.Text.Trim()
        Dim weightText As String = txtWeight.Text.Trim() ' Asumimos que tienes un campo de texto para el peso

        Dim fromNode As Node = graph.Nodes.Find(Function(n) n.Name = fromNodeName)
        Dim toNode As Node = graph.Nodes.Find(Function(n) n.Name = toNodeName)

        If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
            ' Si el campo de peso no está vacío, se usa el constructor con peso
            Dim weight As Integer
            If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, weight) Then
                If chkDirected.Checked Then
                    graph.AddEdge(fromNode, toNode, weight)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                Else
                    graph.AddNoDirectedEdge(fromNode, toNode, weight)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                End If
                txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
            Else
                ' Si no se especifica peso, se usa el constructor sin peso
                If chkDirected.Checked Then
                    graph.AddEdge(fromNode, toNode)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                Else
                    graph.AddNoDirectedEdge(fromNode, toNode)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                End If
                txtGraphRepresentation.Text = graph.ShowAdjacencyList()
            End If
        Else
            MessageBox.Show("One or both nodes do not exist.")
        End If
    End Sub

    Private Sub btnRemoveNode_Click(sender As Object, e As EventArgs) Handles btnRemoveNode.Click
        Dim nodeName As String = txtNode.Text.Trim()
        Dim nodeToRemove As Node = graph.Nodes.Find(Function(n) n.Name = nodeName)

        If nodeToRemove IsNot Nothing Then
            graph.RemoveNode(nodeToRemove)
            MessageBox.Show($"Node '{nodeName}' deleted.")
            txtNode.Clear()
        Else
            MessageBox.Show("Node not found.")
        End If
    End Sub

    ' Método para eliminar una arista no dirigida
    Private Sub btnRemoveEdge_Click(sender As Object, e As EventArgs) Handles btnRemoveEdge.Click
        Dim fromNodeName As String = txtFrom.Text.Trim()
        Dim toNodeName As String = txtTo.Text.Trim()

        Dim fromNode As Node = graph.Nodes.Find(Function(n) n.Name = fromNodeName)
        Dim toNode As Node = graph.Nodes.Find(Function(n) n.Name = toNodeName)

        If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
            graph.RemoveEdge(fromNode, toNode)
            MessageBox.Show($"Edge removed from '{fromNodeName}' to '{toNodeName}'.")
        Else
            MessageBox.Show("One or both nodes do not exist.")
        End If
    End Sub

    Private Sub btnShowDFS_Click(sender As Object, e As EventArgs) Handles btnShowDFS.Click
        txtGraphRepresentation.Clear()
        ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
        Dim startNodeName As String = txtStartNode.Text

        ' Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
        Dim startNode As Node = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)

        If startNode IsNot Nothing Then
            ' Realizar DFS desde el nodo encontrado
            Dim result As String = graph.DFSIterative(startNode)
            txtGraphRepresentation.Text = result ' Mostrar el resultado en el TextBox
        Else
            ' Si el nodo no existe, mostrar un mensaje de error
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub

    Private Sub btnShowBFS_Click(sender As Object, e As EventArgs) Handles btnShowBFS.Click
        txtGraphRepresentation.Clear()
        ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
        Dim startNodeName As String = txtStartNode.Text

        ' Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
        Dim startNode As Node = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)

        If startNode IsNot Nothing Then
            ' Realizar BFS desde el nodo encontrado
            Dim result As String = graph.BFS(startNode)
            txtGraphRepresentation.Text = result ' Mostrar el resultado en el TextBox
        Else
            ' Si el nodo no existe, mostrar un mensaje de error
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub

    Private Sub btnShowDFSRecursive_Click(sender As Object, e As EventArgs) Handles btnShowDFSRecursive.Click
        txtGraphRepresentation.Clear()
        ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
        Dim startNodeName As String = txtStartNode.Text
        Dim startNode As Node = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)
        If startNode IsNot Nothing Then
            Dim result As String = graph.DFS(startNode)
            txtGraphRepresentation.Text = result
        Else
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        ' Validación de confirmación en inglés
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove all nodes and edges?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            graph.RemoveGraph()
            MessageBox.Show("All nodes and edges removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtGraphRepresentation.Clear()
        End If
    End Sub

End Class
