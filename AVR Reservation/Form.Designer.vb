<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New AVR_Reservation.Database1DataSet()
        Me.TableTableAdapter = New AVR_Reservation.Database1DataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New AVR_Reservation.Database1DataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RoomComboBox = New System.Windows.Forms.ComboBox()
        Me.SAVE = New System.Windows.Forms.Button()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.ReserveeTextBox = New System.Windows.Forms.TextBox()
        Me.End_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Start_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New AVR_Reservation.databaseDataSet()
        Me.ReservationTableAdapter = New AVR_Reservation.databaseDataSetTableAdapters.ReservationTableAdapter()
        Me.TableAdapterManager1 = New AVR_Reservation.databaseDataSetTableAdapters.TableAdapterManager()
        Me.UPDATE = New System.Windows.Forms.Button()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = AVR_Reservation.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Reservee", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(286, 13)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.IDTextBox.Size = New System.Drawing.Size(28, 17)
        Me.IDTextBox.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(196, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Reservation ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(196, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 15)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "to"
        '
        'RoomComboBox
        '
        Me.RoomComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Room", True))
        Me.RoomComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomComboBox.FormattingEnabled = True
        Me.RoomComboBox.Items.AddRange(New Object() {"AVR 1", "AVR 2", "AVR 3", "AVR 4", "AVR 5", "AVR 6", "AVR 7", "AVR 8"})
        Me.RoomComboBox.Location = New System.Drawing.Point(93, 99)
        Me.RoomComboBox.Name = "RoomComboBox"
        Me.RoomComboBox.Size = New System.Drawing.Size(91, 23)
        Me.RoomComboBox.TabIndex = 42
        '
        'SAVE
        '
        Me.SAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.SAVE.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAVE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVE.ForeColor = System.Drawing.Color.White
        Me.SAVE.Location = New System.Drawing.Point(156, 279)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(70, 30)
        Me.SAVE.TabIndex = 41
        Me.SAVE.Text = "Save"
        Me.SAVE.UseVisualStyleBackColor = False
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Purpose", True))
        Me.PurposeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurposeTextBox.Location = New System.Drawing.Point(93, 213)
        Me.PurposeTextBox.Multiline = True
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(221, 49)
        Me.PurposeTextBox.TabIndex = 40
        '
        'ReserveeTextBox
        '
        Me.ReserveeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Reservee", True))
        Me.ReserveeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveeTextBox.Location = New System.Drawing.Point(93, 173)
        Me.ReserveeTextBox.Name = "ReserveeTextBox"
        Me.ReserveeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ReserveeTextBox.Size = New System.Drawing.Size(221, 23)
        Me.ReserveeTextBox.TabIndex = 39
        '
        'End_TimeDateTimePicker
        '
        Me.End_TimeDateTimePicker.CustomFormat = "hh:mm:tt"
        Me.End_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TableBindingSource, "End_Time", True))
        Me.End_TimeDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.End_TimeDateTimePicker.Location = New System.Drawing.Point(223, 138)
        Me.End_TimeDateTimePicker.MaxDate = New Date(9950, 2, 27, 0, 0, 0, 0)
        Me.End_TimeDateTimePicker.MinDate = New Date(2020, 3, 13, 0, 0, 0, 0)
        Me.End_TimeDateTimePicker.Name = "End_TimeDateTimePicker"
        Me.End_TimeDateTimePicker.ShowUpDown = True
        Me.End_TimeDateTimePicker.Size = New System.Drawing.Size(91, 23)
        Me.End_TimeDateTimePicker.TabIndex = 38
        Me.End_TimeDateTimePicker.Value = New Date(2020, 3, 13, 0, 0, 0, 0)
        '
        'Start_TimeDateTimePicker
        '
        Me.Start_TimeDateTimePicker.CustomFormat = "hh:mm:tt"
        Me.Start_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TableBindingSource, "Start_Time", True))
        Me.Start_TimeDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Start_TimeDateTimePicker.Location = New System.Drawing.Point(93, 138)
        Me.Start_TimeDateTimePicker.MinDate = New Date(2020, 3, 13, 0, 0, 0, 0)
        Me.Start_TimeDateTimePicker.Name = "Start_TimeDateTimePicker"
        Me.Start_TimeDateTimePicker.ShowUpDown = True
        Me.Start_TimeDateTimePicker.Size = New System.Drawing.Size(91, 23)
        Me.Start_TimeDateTimePicker.TabIndex = 37
        Me.Start_TimeDateTimePicker.Value = New Date(2020, 3, 13, 0, 0, 0, 0)
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TableBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(93, 62)
        Me.DateDateTimePicker.MinDate = New Date(2020, 3, 13, 0, 0, 0, 0)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(221, 20)
        Me.DateDateTimePicker.TabIndex = 36
        Me.DateDateTimePicker.Value = New Date(2020, 3, 13, 0, 0, 0, 0)
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorControl1.Location = New System.Drawing.Point(0, 36)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(348, 20)
        Me.SeparatorControl1.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Room:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Purpose:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Reservee:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Date:"
        '
        'DELETE
        '
        Me.DELETE.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.DELETE.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DELETE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.ForeColor = System.Drawing.Color.White
        Me.DELETE.Location = New System.Drawing.Point(244, 279)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(70, 30)
        Me.DELETE.TabIndex = 46
        Me.DELETE.Text = "Delete"
        Me.DELETE.UseVisualStyleBackColor = False
        Me.DELETE.Visible = False
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ReservationTableAdapter = Me.ReservationTableAdapter
        Me.TableAdapterManager1.UpdateOrder = AVR_Reservation.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UPDATE
        '
        Me.UPDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.UPDATE.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UPDATE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE.ForeColor = System.Drawing.Color.White
        Me.UPDATE.Location = New System.Drawing.Point(169, 279)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(70, 30)
        Me.UPDATE.TabIndex = 47
        Me.UPDATE.Text = "Update"
        Me.UPDATE.UseVisualStyleBackColor = False
        Me.UPDATE.Visible = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(349, 327)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RoomComboBox)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.PurposeTextBox)
        Me.Controls.Add(Me.ReserveeTextBox)
        Me.Controls.Add(Me.End_TimeDateTimePicker)
        Me.Controls.Add(Me.Start_TimeDateTimePicker)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AVR Reservation"
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As Database1DataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RoomComboBox As ComboBox
    Friend WithEvents SAVE As Button
    Friend WithEvents PurposeTextBox As TextBox
    Friend WithEvents ReserveeTextBox As TextBox
    Friend WithEvents End_TimeDateTimePicker As DateTimePicker
    Friend WithEvents Start_TimeDateTimePicker As DateTimePicker
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatabaseDataSet As databaseDataSet
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As databaseDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents TableAdapterManager1 As databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DELETE As Button
    Friend WithEvents UPDATE As Button
End Class
