''' <summary>
''' Generic Linked List that has the functionality
''' to reverse its nodes.
''' <para>Author: Marko Vuckovic</para>
''' </summary>
''' <typeparam name="T">Generic Type</typeparam>
Public Class ReversedLinkedList(Of T)
    Inherits Util.LinkedList(Of T)

#Region "Functions"

    ''' <summary>
    ''' Creates a reversed Linked list from current linked list
    ''' </summary>
    ''' <returns>Reversed linked list</returns>
    Public Function ReversedLinkedList() As Util.LinkedList(Of T)
        Dim linkedList As New Util.LinkedList(Of T)
        Dim node = Head
        While Not node Is Nothing
            Dim value As New Util.LinkedListNode(Of T) With {
                .Value = node.Value,
                .NextNode = Nothing
            }
            linkedList.AddToHead(value)
            node = node.NextNode
        End While
        Return linkedList
    End Function

#End Region

End Class
