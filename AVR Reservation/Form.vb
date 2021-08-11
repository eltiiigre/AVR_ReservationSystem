
Public Class Form

    Public resID As Integer = 0

    Public Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.DatabaseDataSet.Reservation)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Reservation' table. You can move, or remove it, as needed.

    End Sub

    Public Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        'Dim sql As String
        If String.IsNullOrWhiteSpace(RoomComboBox.Text) Or String.IsNullOrWhiteSpace(DateDateTimePicker.Value) Or String.IsNullOrWhiteSpace(Start_TimeDateTimePicker.Value) Or String.IsNullOrWhiteSpace(End_TimeDateTimePicker.Value) Or String.IsNullOrWhiteSpace(ReserveeTextBox.Text) Or String.IsNullOrWhiteSpace(PurposeTextBox.Text) Then
            MsgBox("Input details first.", MsgBoxStyle.Exclamation, "Error")
        End If
        ''Else
        ' Dim count As Integer

        ' If resID = 0 Then
        If IsConfirm("Do you want to save reservation ?") Then
            't = Me.ReservationTableAdapter.ScalarQuery(DateDateTimePicker.Value, RoomComboBox.Text, End_TimeDateTimePicker.Value, Start_TimeDateTimePicker.Value)
            '  If count = 0 Then
            '           'sql = $"Select count(*) As Expr1
            'From Reservation
            'Where (Date_Res = '{DateDateTimePicker.Value}') And (Room = '{RoomComboBox.Text}') And (End_Time >='{Start_TimeDateTimePicker.Value}') And (Start_Time <= '{End_TimeDateTimePicker.Value}')"

            'If check(sql) Then
            ' Sql = $"insert into Reservation(Date_Res, Room, Start_Time, End_Time, Reservee, Purpose) 
            'values('{DateDateTimePicker.Value.ToShortDateString()}', 
            '{RoomComboBox.Text}', '{Start_TimeDateTimePicker.Value}', 
            '{End_TimeDateTimePicker.Value}', '{ReserveeTextBox.Text}',
            '{PurposeTextBox.Text}')"

            'tUpdateDelete(sql) Then
            'MsgBox("Reservation Saved!", MsgBoxStyle.Information, "Saved")
            '
            '  Close()
            ' Else
            'MsgBox("Failed")
            ' End If
            '
            '  Else
            '             MsgBox("Time Conflict")
            ' End If
            '
            ' Display.Today()
            'Else
            'Sql = $"update Reservation set Date_Res = '{DateDateTimePicker.Value.ToShortDateString()}', 
            '                                     Room = '{RoomComboBox.Text}', Start_Time = '{Start_TimeDateTimePicker.Value}', 
            '                                    End_Time = '{End_TimeDateTimePicker.Value}', Reservee = '{ReserveeTextBox.Text}',
            '                                    Purpose = '{PurposeTextBox.Text}'
            '                         where Reservation_ID = {resID}"
            'If InsertUpdateDelete(sql) Then
            'Box("Reservation Updated!", MsgBoxStyle.Information, "Updated")
            'Close()
            'Else
            'MsgBox("Update Failed")
            'End If

            '  End If
            'Display.Today()tart
            'End If
            Dim count As Integer
            count = Me.ReservationTableAdapter.ScalarQuery(DateDateTimePicker.Value.ToShortDateString(), RoomComboBox.Text, Start_TimeDateTimePicker.Value, End_TimeDateTimePicker.Value, End_TimeDateTimePicker.Value, End_TimeDateTimePicker.Value, Start_TimeDateTimePicker.Value, Start_TimeDateTimePicker.Value)
            Me.ReservationTableAdapter.Fill(Me.DatabaseDataSet.Reservation)
            If count = 0 Then
                Me.ReservationTableAdapter.InsertQuery(DateDateTimePicker.Value.ToShortDateString(), RoomComboBox.Text, Start_TimeDateTimePicker.Value, End_TimeDateTimePicker.Value, ReserveeTextBox.Text, PurposeTextBox.Text)
                Me.ReservationTableAdapter.Fill(Me.DatabaseDataSet.Reservation)

                MsgBox("Reservation Saved!", MsgBoxStyle.Information, "Saved")
                ''Close()
                Display.Today()


            Else

                MsgBox("Reservation Rejected! There is a time conflict.", MsgBoxStyle.Exclamation, "Error")

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        If IsConfirm("Do you want to delete this reservation ?") Then
            Dim sql As String = $"delete from Reservation where Reservation_ID = {resID}"
            If InsertUpdateDelete(sql) Then
                MsgBox("Reservation Deleted!", MsgBoxStyle.Information, "Deleted")
                'Close()
            Else
                MsgBox("Delete Failed")
            End If
        End If
        Display.Today()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles UPDATE.Click
        '  Me.ReservationTableAdapter.UpdateQuery(DateDateTimePicker.Value, RoomComboBox.Text, Start_TimeDateTimePicker.Value, End_TimeDateTimePicker.Value, ReserveeTextBox.Text, PurposeTextBox.Text)
        Dim Sql As String = $"update Reservation set Date_Res = '{DateDateTimePicker.Value.ToShortDateString()}', 
                                             Room = '{RoomComboBox.Text}', Start_Time = '{Start_TimeDateTimePicker.Value}', 
                                            End_Time = '{End_TimeDateTimePicker.Value}', Reservee = '{ReserveeTextBox.Text}',
                                            Purpose = '{PurposeTextBox.Text}'
                                 where Reservation_ID = {resID}"
        If InsertUpdateDelete(Sql) Then
            MsgBox("Reservation Updated!", MsgBoxStyle.Information, "Updated")
            'Close()
        Else
            MsgBox("Update Failed")
        End If
    End Sub
End Class
