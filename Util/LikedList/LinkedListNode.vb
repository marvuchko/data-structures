''' <summary>
''' Generic class for a Linked List node
''' <para>Author: Marko Vuckovic</para>
''' </summary>
Public Class LinkedListNode(Of T)

#Region "Properties"

    ''' <summary>
    ''' Value of a Node
    ''' </summary>
    ''' <returns></returns>
    Public Property Value As T

    ''' <summary>
    ''' Pointer to Next node
    ''' </summary>
    ''' <returns></returns>
    Public Property NextNode As LinkedListNode(Of T)

    ''' <summary>
    ''' Pointer to Previous node
    ''' </summary>
    ''' <returns></returns>
    Public Property PreviousNode As LinkedListNode(Of T)

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    Public Sub New()
        Me.New(Nothing)
    End Sub

    ''' <summary>
    ''' Constructor with value argument
    ''' </summary>
    ''' <param name="value"></param>
    Public Sub New(ByVal value As T)
        Me.Value = value
    End Sub

#End Region

#Region "Functions"

    ''' <summary>
    ''' String representation of a Linked List node
    ''' </summary>
    ''' <returns>String representation of a Linked List node</returns>
    Public Overrides Function ToString() As String
        Return "Node Value: " & Value.ToString()
    End Function

#End Region

End Class
