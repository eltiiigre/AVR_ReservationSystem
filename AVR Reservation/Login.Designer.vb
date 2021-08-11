<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.log_in = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Database1DataSet1 = New AVR_Reservation.Database1DataSet1()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New AVR_Reservation.Database1DataSet1TableAdapters.TableAdapterManager()
        Me.TableTableAdapter = New AVR_Reservation.Database1DataSet1TableAdapters.TableTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 327)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.log_in)
        Me.Panel3.Controls.Add(Me.password)
        Me.Panel3.Controls.Add(Me.username)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(40, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 231)
        Me.Panel3.TabIndex = 2
        '
        'log_in
        '
        Me.log_in.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.log_in.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.log_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.log_in.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_in.ForeColor = System.Drawing.Color.White
        Me.log_in.Location = New System.Drawing.Point(130, 176)
        Me.log_in.Name = "log_in"
        Me.log_in.Size = New System.Drawing.Size(82, 30)
        Me.log_in.TabIndex = 24
        Me.log_in.Text = "Login"
        Me.log_in.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.BackColor = System.Drawing.SystemColors.Control
        Me.password.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.password.Location = New System.Drawing.Point(104, 130)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(129, 25)
        Me.password.TabIndex = 5
        '
        'username
        '
        Me.username.BackColor = System.Drawing.SystemColors.Control
        Me.username.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.username.Location = New System.Drawing.Point(104, 91)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(129, 25)
        Me.username.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username:"
        '
        'Label8
        '
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(94, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 78)
        Me.Label8.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 142)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(140, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Login"
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Database1DataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AVR_Reservation.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents log_in As Button
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As Database1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TableTableAdapter As Database1DataSet1TableAdapters.TableTableAdapter
End Class
