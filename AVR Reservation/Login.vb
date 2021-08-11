Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database1DataSet1.Table)
        password.PasswordChar = "*"
    End Sub

    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click

        If Me.TableTableAdapter.SelectQuery(username.Text, password.Text) Then
            Display.Show()
            Me.Hide()
        Else
            MsgBox("Invalid login information!", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class