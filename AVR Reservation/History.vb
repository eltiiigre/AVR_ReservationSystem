Public Class History


    Private Sub Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.DatabaseDataSet.Reservation)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.DatabaseDataSet.Reservation)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.DatabaseDataSet.Reservation)

    End Sub

    Private Sub flDays_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.ReservationTableAdapter.Fill(Me.DatabaseDataSet.Reservation)
    End Sub

    Private Sub ReservationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReservationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub ReservationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReservationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Users\Dell\Desktop\Final\AVR Reservation - Copy\AVR Reservation\bin\Debug\database.accdb")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Display.Button4_Click()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim DV As New DataView(DatabaseDataSet.Reservation)
        If Filter.Text = "Reservation_ID" Then
            DV.RowFilter = String.Format("Convert([Reservation_ID], System.String) like '%{0}%'", TextBox1.Text)

        ElseIf Filter.Text = "Date_Res" Then
            DV.RowFilter = String.Format("Convert([Date_Res], System.String) like '%{0}%'", TextBox1.Text)

        ElseIf Filter.Text = "Room" Then
            DV.RowFilter = String.Format("Room like '%{0}%'", TextBox1.Text)

        ElseIf Filter.Text = "Start_Time" Then
            DV.RowFilter = String.Format("Convert([Start_Time], System.String) like '%{0}%'", TextBox1.Text)

        ElseIf Filter.Text = "End_Time" Then
            DV.RowFilter = String.Format("Convert([End_Time], System.String) like '%{0}%'", TextBox1.Text)

        ElseIf Filter.Text = "Reservee" Then
            DV.RowFilter = String.Format("Reservee like '%{0}%'", TextBox1.Text)

        Else
            DV.RowFilter = String.Format("Purpose like '%{0}%'", TextBox1.Text)

        End If
        ReservationDataGridView.DataSource = DV
    End Sub


End Class