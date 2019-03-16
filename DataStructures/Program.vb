Imports System

Module Program
    Sub Main(args As String())

        '' Linked Lists
        Console.WriteLine("############## Linked Lists")

        '  Reversed Linked List
        Console.WriteLine()
        Console.WriteLine("### Reversing a Linked List")

        Dim nonReversedLinkedList As New LinkedLists.ReversedLinkedList(Of Integer)
        nonReversedLinkedList.AddToHead(New Util.LinkedListNode(Of Integer)(3))
        nonReversedLinkedList.AddToHead(New Util.LinkedListNode(Of Integer)(2))
        nonReversedLinkedList.AddToHead(New Util.LinkedListNode(Of Integer)(1))

        Console.WriteLine("Linked List before reversing: ")
        Console.WriteLine(nonReversedLinkedList)
        Console.WriteLine("Linked List after reversing: ")
        Console.WriteLine(nonReversedLinkedList.ReversedLinkedList())

        'Palindrome Linked List
        Console.WriteLine()
        Console.WriteLine("### Palindrome Linked List")
        Dim palindromeLinkedList As New LinkedLists.PalindromeLinkedList(Of Char)
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("A"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("N"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("A"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("V"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("O"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("L"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("I"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("M"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("I"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("L"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("O"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("V"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("A"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("N"))
        palindromeLinkedList.AddToTail(New Util.LinkedListNode(Of Char)("A"))
        Console.WriteLine("Palindrome Linked List values: " & palindromeLinkedList.ToString())
        Console.WriteLine("Is palindrome: " & palindromeLinkedList.IsPalindrome())
        Console.WriteLine()

        '' Stacks
        Console.WriteLine("############## Stacks")

        Console.WriteLine()
        Dim stack As New Util.Stack(Of Integer)
        stack.Push(1)
        stack.Push(2)
        stack.Push(3)
        stack.PrintStack()

    End Sub
End Module
