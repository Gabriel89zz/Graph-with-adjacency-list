Public Class Edge
    Public Property ToNode As Node
    Public Property Weight As Integer

    Public Sub New(ByVal toNode As Node, ByVal weight As Integer)
        Me.ToNode = toNode
        Me.Weight = weight
    End Sub

    Public Sub New(ByVal toNode As Node)
        Me.ToNode = toNode
    End Sub
End Class
