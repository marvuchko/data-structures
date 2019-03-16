''' <summary>
''' Generic Stack class
''' <para>Author: Marko Vuckovic</para>
''' </summary>
''' <typeparam name="T">Generic Type</typeparam>
Public Class Stack(Of T)

#Region "Properties"

    ''' <summary>
    ''' Values of a stack
    ''' </summary>
    ''' <returns>Values of a stack</returns>
    Public Property Values As List(Of T)

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    Public Sub New()
        Values = New List(Of T)
    End Sub

#End Region

#Region "Subroutines"

    ''' <summary>
    ''' Adds new element into stack
    ''' </summary>
    ''' <param name="value">Value to be added to the stack</param>
    Public Sub Push(ByVal value As T)
        Values.Add(value)
    End Sub

    ''' <summary>
    ''' Prints the entire stack to console output
    ''' </summary>
    Public Sub PrintStack()
        For i As Integer = Values.Count - 1 To 0 Step -1
            Console.WriteLine("  " & Values(i).ToString() & " ")
            Console.WriteLine(" ---")
        Next
    End Sub

#End Region

#Region "Functions"

    ''' <summary>
    ''' Removes the element from the top of a Stack
    ''' </summary>
    ''' <returns>Element form the top of a Stack</returns>
    Public Function Pop() As T
        If IsEmpty() Then
            Return Nothing
        End If
        Dim value = Values(Values.Count - 1)
        Values.RemoveAt(Values.Count - 1)
        Return value
    End Function

    ''' <summary>
    ''' Checks wheater Stack is empty or not
    ''' </summary>
    ''' <returns>True or False</returns>
    Public Function IsEmpty() As Boolean
        Return Values.Count = 0
    End Function

#End Region

End Class
