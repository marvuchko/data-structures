''' <summary>
''' Generic class for a Linked List
''' <para>Author: Marko Vuckovic</para>
''' </summary>
''' <typeparam name="T">Generic Type</typeparam>
Public Class LinkedList(Of T)

#Region "Properties"

    ''' <summary>
    ''' Head pointer of a Linked List
    ''' </summary>
    ''' <returns></returns>
    Public Property Head As LinkedListNode(Of T)

    ''' <summary>
    ''' Tail pointer of a Linkde List
    ''' </summary>
    ''' <returns></returns>
    Public Property Tail As LinkedListNode(Of T)

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default Constructor
    ''' </summary>
    Public Sub New()
        Head = Tail
    End Sub

#End Region

#Region "Subroutines"

    ''' <summary>
    ''' Adds new node to the Head of a Linked List
    ''' </summary>
    ''' <param name="node">New list node</param>
    Public Sub AddToHead(ByRef node As LinkedListNode(Of T))
        If Head Is Nothing Then
            Head = node
            Tail = node
        Else
            node.NextNode = Head
            Head.PreviousNode = node
            Head = node
        End If
    End Sub

    ''' <summary>
    ''' Adds a new node to the Tail of a Linked List
    ''' </summary>
    ''' <param name="node">New list node</param>
    Public Sub AddToTail(ByRef node As LinkedListNode(Of T))
        If Tail Is Nothing Then
            Tail = node
            Head = node
        Else
            Tail.NextNode = node
            node.PreviousNode = Tail
            Tail = Tail.NextNode
        End If
    End Sub

#End Region

#Region "Functions"

    ''' <summary>
    ''' Finds Nth node in a Linked List
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns>Nth node of a list</returns>
    Public Function FindNthNode(ByVal index As Integer) As LinkedListNode(Of T)
        Dim node = Head
        While Not node Is Nothing And index > 0
            node = node.NextNode
            index -= 1
        End While
        If index = 0 Then
            Return node
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Calculates total elements inside Linked List
    ''' </summary>
    ''' <returns>Total elements of a list</returns>
    Public Function Size() As Integer
        Dim sizeOfList = 0
        Dim node = Head
        While Not node Is Nothing
            node = node.NextNode
            sizeOfList += 1
        End While
        Return sizeOfList
    End Function

    ''' <summary>
    ''' String representation of a Linked List
    ''' </summary>
    ''' <returns>String representation of a Linked List</returns>
    Public Overrides Function ToString() As String
        Dim value = ""
        Dim node = Head
        While Not node Is Nothing
            value &= node.Value.ToString() & " "
            node = node.NextNode
        End While
        Return value
    End Function

#End Region

End Class
