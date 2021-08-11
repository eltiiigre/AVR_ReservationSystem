Imports System.IO
Public Class Display


    Public ListFlDay As New List(Of FlowLayoutPanel)
    Public currentDate As DateTime = DateTime.Today

    Public Sub Button4_Click()
        pnl.BackColor = Color.FromArgb(3, 218, 198)
        pnl.Height = Button4.Height
        pnl.Top = Button4.Top
    End Sub
    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        DisplayCurrentDate()
    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then

            With Form

                .UPDATE.Visible = False
                .DELETE.Visible = False
                .SAVE.Visible = True
                .DateDateTimePicker.Value = New Date(currentDate.Year, currentDate.Month, day)
                .RoomComboBox.Text = ""
                .ReserveeTextBox.Text = ""
                .PurposeTextBox.Text = ""
                .ShowDialog()

            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub ShowAppointmentDetail(sender As Object, e As EventArgs)
        Dim ResID As Integer = CType(sender, LinkLabel).Tag
        Dim sql As String = $"select * from Reservation where Reservation_ID = {ResID}"
        Dim dt As DataTable = QueryAsDataTable(sql)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With Form
                .IDTextBox.Text = ResID
                .resID = ResID
                .DateDateTimePicker.Value = row("Date_Res")
                .RoomComboBox.Text = row("Room")
                .Start_TimeDateTimePicker.Value = row("Start_Time")
                .End_TimeDateTimePicker.Value = row("End_Time")
                .ReserveeTextBox.Text = row("Reservee")
                .PurposeTextBox.Text = row("Purpose")
                .Label5.Visible = True
                .SAVE.Visible = False
                .DELETE.Visible = True
                .UPDATE.Visible = True
                .ShowDialog()
            End With

        End If
        Today()
    End Sub

    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        Dim sql As String = $"select * from Reservation where Date_Res between #{startDate.ToShortDateString()}# and #{endDate.ToShortDateString()}#"
        Dim dt As DataTable = QueryAsDataTable(sql)

        For Each row As DataRow In dt.Rows
            Dim resDay As DateTime = DateTime.Parse(row("Date_Res"))
            Dim link As New LinkLabel
            link.Tag = row("Reservation_ID")
            link.Name = $"link{row("Reservation_ID")}"
            link.TextAlign = ContentAlignment.TopLeft
            link.Size = New Size(50, 20)
            link.LinkColor = Color.Green
            link.VisitedLinkColor = Color.Blue
            link.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
            link.Text = row("Room")
            AddHandler link.Click, AddressOf ShowAppointmentDetail
            ListFlDay((resDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
        Next
    End Sub

    Public Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM,yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Public Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        ListFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(109, 65)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True

            flDays.Controls.Add(fl)
            ListFlDay.Add(fl)
            AddHandler fl.Click, AddressOf AddNewAppointment
        Next


    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In ListFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(90, 20)
            lbl.Text = i
            lbl.Font = New Font("Segoe Ul", 8, FontStyle.Bold)
            lbl.ForeColor = Color.FromArgb(3, 31, 36)
            ListFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            ListFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                ListFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.FromArgb(3, 218, 198)
            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrevMonth()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NextMonth()
    End Sub

    Public Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Today()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        pnl.BackColor = Color.FromArgb(3, 218, 198)
        pnl.Height = Button3.Height
        pnl.Top = Button3.Top

        History.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        pnl.BackColor = Color.FromArgb(207, 102, 121)
        pnl.Height = Button6.Height
        pnl.Top = Button6.Top

        If IsConfirm("Are you sure you want to logout?") Then
            Me.Hide()
            Login.Show()
            Login.username.Text = ""
            Login.password.Text = ""
        Else
            Button4_Click()
        End If
    End Sub

End Class