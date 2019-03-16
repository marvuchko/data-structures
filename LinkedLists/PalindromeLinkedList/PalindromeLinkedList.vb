''' <summary>
''' Generic Palindrome Linked List
''' </summary>
''' <typeparam name="T"></typeparam>
Public Class PalindromeLinkedList(Of T)
    Inherits Util.LinkedList(Of T)

#Region "Functions"

    ''' <summary>
    ''' Checks wheater Linked List is palindrome
    ''' </summary>
    ''' <returns>True or False</returns>
    Public Function IsPalindrome() As Boolean
        Dim firstNode = Head
        Dim lastNode = Tail
        While Not firstNode Is Nothing And Not lastNode Is Nothing And Not firstNode Is lastNode
            If Not firstNode.Value.Equals(lastNode.Value) Then
                Return False
            End If
            firstNode = firstNode.NextNode
            lastNode = lastNode.PreviousNode
        End While
        If firstNode Is lastNode Then
            Return True
        End If
        Return False
    End Function

#End Region

End Class
