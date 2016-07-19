Friend Class ListViewSort

#Region "ListView Sort Class"

    Implements IComparer
    Dim SortOrder As SortOrder
    Dim ColumnNumber As Integer

    Protected Friend Sub New(ByVal ColumnNum As Integer, ByVal Sort_Order As SortOrder)
        ColumnNumber = ColumnNum
        SortOrder = Sort_Order
    End Sub

    Protected Friend Function Compare(ByVal Obj1 As Object, ByVal Obj2 As Object) As Integer Implements System.Collections.IComparer.Compare

        Dim Str1, Str2 As String
        Dim Item1 As ListViewItem = DirectCast(Obj1, ListViewItem)
        Dim Item2 As ListViewItem = DirectCast(Obj2, ListViewItem)

        If Item1.SubItems.Count <= ColumnNumber Then
            Str1 = ""
        Else
            Str1 = Item1.SubItems(ColumnNumber).Text.Trim
        End If

        If Item2.SubItems.Count <= ColumnNumber Then
            Str2 = ""
        Else
            Str2 = Item2.SubItems(ColumnNumber).Text.Trim
        End If

        If SortOrder = SortOrder.Ascending Then

            If IsNumeric(Str1) = True AndAlso IsNumeric(Str2) = True Then
                Return CInt(Str1).CompareTo(CInt(Str2))
            Else
                Return String.Compare(Str1, Str2)
            End If

        Else

            If IsNumeric(Str1) = True AndAlso IsNumeric(Str2) = True Then
                Return CInt(Str2).CompareTo(CInt(Str1))
            Else
                Return String.Compare(Str2, Str1)
            End If

        End If

    End Function

#End Region

End Class