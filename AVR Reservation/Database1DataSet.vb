Partial Class Database1DataSet
    Partial Public Class TableDataTable
        Private Sub TableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Reservation_IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace Database1DataSetTableAdapters

    Partial Public Class TableTableAdapter
    End Class
End Namespace

Namespace Database1DataSetTableAdapters
    Partial Public Class TableTableAdapter
    End Class
End Namespace
