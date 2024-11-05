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
        'Label1 = New Label()
        'SuspendLayout()
        '' 
        '' Label1
        '' 
        'Label1.AutoSize = True
        'Label1.Location = New Point(435, 219)
        'Label1.Name = "Label1"
        'Label1.Size = New Size(41, 15)
        'Label1.TabIndex = 0
        'Label1.Text = "Label1"
        '' 
        '' Form1
        '' 
        'AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        'AutoScaleMode = AutoScaleMode.Font
        'ClientSize = New Size(830, 509)
        'Controls.Add(Label1)
        'Name = "Form1"
        'Text = "Form1"
        'ResumeLayout(False)
        'PerformLayout()




        Label1 = New Label()
        btnAddNode = New Button()
        txtNode = New TextBox()
        label2 = New Label()
        label3 = New Label()
        txtFrom = New TextBox()
        label4 = New Label()
        txtTo = New TextBox()
        btnAddEdge = New Button()
        btnRemoveEdge = New Button()
        txtGraphRepresentation = New TextBox()
        label5 = New Label()
        txtWeight = New TextBox()
        chkDirected = New CheckBox()
        btnShowDFS = New Button()
        txtStartNode = New TextBox()
        btnRemoveNode = New Button()
        btnShowBFS = New Button()
        label6 = New Label()
        btnShowDFSRecursive = New Button()
        btnRemoveAll = New Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 14.0F, FontStyle.Bold)
        Label1.Location = New Point(233, 21)
        Label1.Name = "label1"
        Label1.Size = New Size(324, 25)
        Label1.TabIndex = 0
        Label1.Text = "GRAFO CON LISTA DE ADYACENCIA"
        ' 
        ' btnAddNode
        ' 
        btnAddNode.Location = New Point(330, 73)
        btnAddNode.Name = "btnAddNode"
        btnAddNode.Size = New Size(75, 23)
        btnAddNode.TabIndex = 1
        btnAddNode.Text = "Add Node"
        btnAddNode.UseVisualStyleBackColor = True
        AddHandler btnAddNode.Click, AddressOf btnAddNode_Click
        ' 
        ' txtNode
        ' 
        txtNode.Location = New Point(126, 70)
        txtNode.Name = "txtNode"
        txtNode.Size = New Size(180, 23)
        txtNode.TabIndex = 2
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(46, 73)
        label2.Name = "label2"
        label2.Size = New Size(74, 15)
        label2.TabIndex = 3
        label2.Text = "Node Name:"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(44, 147)
        label3.Name = "label3"
        label3.Size = New Size(70, 15)
        label3.TabIndex = 5
        label3.Text = "Node From:"
        ' 
        ' txtFrom
        ' 
        txtFrom.Location = New Point(124, 144)
        txtFrom.Name = "txtFrom"
        txtFrom.Size = New Size(104, 23)
        txtFrom.TabIndex = 4
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(44, 185)
        label4.Name = "label4"
        label4.Size = New Size(53, 15)
        label4.TabIndex = 7
        label4.Text = "Node to:"
        ' 
        ' txtTo
        ' 
        txtTo.Location = New Point(124, 182)
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(104, 23)
        txtTo.TabIndex = 6
        ' 
        ' btnAddEdge
        ' 
        btnAddEdge.Location = New Point(261, 144)
        btnAddEdge.Name = "btnAddEdge"
        btnAddEdge.Size = New Size(75, 23)
        btnAddEdge.TabIndex = 8
        btnAddEdge.Text = "Add Edge"
        btnAddEdge.UseVisualStyleBackColor = True
        AddHandler btnAddEdge.Click, AddressOf btnAddEdge_Click
        ' 
        ' btnRemoveEdge
        ' 
        btnRemoveEdge.Location = New Point(261, 182)
        btnRemoveEdge.Name = "btnRemoveEdge"
        btnRemoveEdge.Size = New Size(75, 39)
        btnRemoveEdge.TabIndex = 9
        btnRemoveEdge.Text = "Remove Edge"
        btnRemoveEdge.UseVisualStyleBackColor = True
        AddHandler btnRemoveEdge.Click, AddressOf btnRemoveEdge_Click
        ' 
        ' txtGraphRepresentation
        ' 
        txtGraphRepresentation.Font = New Font("Yu Gothic Medium", 11.0F)
        txtGraphRepresentation.Location = New Point(389, 200)
        txtGraphRepresentation.Multiline = True
        txtGraphRepresentation.Name = "txtGraphRepresentation"
        txtGraphRepresentation.Size = New Size(362, 202)
        txtGraphRepresentation.TabIndex = 12
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(44, 219)
        label5.Name = "label5"
        label5.Size = New Size(48, 15)
        label5.TabIndex = 14
        label5.Text = "Weight:"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(124, 216)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(104, 23)
        txtWeight.TabIndex = 13
        ' 
        ' chkDirected
        ' 
        chkDirected.AutoSize = True
        chkDirected.Location = New Point(124, 245)
        chkDirected.Name = "chkDirected"
        chkDirected.Size = New Size(70, 19)
        chkDirected.TabIndex = 15
        chkDirected.Text = "Directed"
        chkDirected.UseVisualStyleBackColor = True
        ' 
        ' btnShowDFS
        ' 
        btnShowDFS.Location = New Point(119, 363)
        btnShowDFS.Name = "btnShowDFS"
        btnShowDFS.Size = New Size(75, 39)
        btnShowDFS.TabIndex = 16
        btnShowDFS.Text = "Show DFS Algorithm"
        btnShowDFS.UseVisualStyleBackColor = True
        AddHandler btnShowDFS.Click, AddressOf btnShowDFS_Click
        ' 
        ' txtStartNode
        ' 
        txtStartNode.Location = New Point(66, 334)
        txtStartNode.Name = "txtStartNode"
        txtStartNode.Size = New Size(104, 23)
        txtStartNode.TabIndex = 17
        ' 
        ' btnRemoveNode
        ' 
        btnRemoveNode.Location = New Point(330, 102)
        btnRemoveNode.Name = "btnRemoveNode"
        btnRemoveNode.Size = New Size(75, 23)
        btnRemoveNode.TabIndex = 20
        btnRemoveNode.Text = "Remove"
        btnRemoveNode.UseVisualStyleBackColor = True
        AddHandler btnRemoveNode.Click, AddressOf btnRemoveNode_Click
        ' 
        ' btnShowBFS
        ' 
        btnShowBFS.Location = New Point(38, 363)
        btnShowBFS.Name = "btnShowBFS"
        btnShowBFS.Size = New Size(75, 39)
        btnShowBFS.TabIndex = 21
        btnShowBFS.Text = "Show BFS Algorithm"
        btnShowBFS.UseVisualStyleBackColor = True
        AddHandler btnShowBFS.Click, AddressOf btnShowBFS_Click
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(66, 316)
        label6.Name = "label6"
        label6.Size = New Size(66, 15)
        label6.TabIndex = 22
        label6.Text = "Node Start:"
        ' 
        ' btnShowDFSRecursive
        ' 
        btnShowDFSRecursive.Location = New Point(200, 363)
        btnShowDFSRecursive.Name = "btnShowDFSRecursive"
        btnShowDFSRecursive.Size = New Size(75, 39)
        btnShowDFSRecursive.TabIndex = 23
        btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm"
        btnShowDFSRecursive.UseVisualStyleBackColor = True
        AddHandler btnShowDFSRecursive.Click, AddressOf btnShowDFSRecursive_Click
        ' 
        ' btnRemoveAll
        ' 
        btnRemoveAll.Location = New Point(389, 171)
        btnRemoveAll.Name = "btnRemoveAll"
        btnRemoveAll.Size = New Size(84, 23)
        btnRemoveAll.TabIndex = 24
        btnRemoveAll.Text = "Remove All"
        btnRemoveAll.UseVisualStyleBackColor = True
        AddHandler btnRemoveAll.Click, AddressOf btnRemoveAll_Click
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRemoveAll)
        Controls.Add(btnShowDFSRecursive)
        Controls.Add(label6)
        Controls.Add(btnShowBFS)
        Controls.Add(btnRemoveNode)
        Controls.Add(txtStartNode)
        Controls.Add(btnShowDFS)
        Controls.Add(chkDirected)
        Controls.Add(label5)
        Controls.Add(txtWeight)
        Controls.Add(txtGraphRepresentation)
        Controls.Add(btnRemoveEdge)
        Controls.Add(btnAddEdge)
        Controls.Add(label4)
        Controls.Add(txtTo)
        Controls.Add(label3)
        Controls.Add(txtFrom)
        Controls.Add(label2)
        Controls.Add(txtNode)
        Controls.Add(btnAddNode)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    'Friend WithEvents Label1 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btnAddNode As Button
    Friend WithEvents txtNode As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents label4 As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents btnAddEdge As Button
    Friend WithEvents btnRemoveEdge As Button
    Friend WithEvents txtGraphRepresentation As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents chkDirected As CheckBox
    Friend WithEvents btnShowDFS As Button
    Friend WithEvents txtStartNode As TextBox
    Friend WithEvents btnRemoveNode As Button
    Friend WithEvents btnShowBFS As Button
    Friend WithEvents label6 As Label
    Friend WithEvents btnShowDFSRecursive As Button
    Friend WithEvents btnRemoveAll As Button

End Class
