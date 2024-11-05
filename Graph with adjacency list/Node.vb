Public Class Node
    Public Property Name As String
    Public Property Neighbors As List(Of Edge)

    Public Sub New(name As String)
        Me.Name = name
        Neighbors = New List(Of Edge)()
    End Sub
End Class
