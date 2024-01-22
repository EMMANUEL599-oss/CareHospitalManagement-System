<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finished
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Finished))
        Dim Finish_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Doctor_IDLabel As System.Windows.Forms.Label
        Dim Doctor_NameLabel As System.Windows.Forms.Label
        Dim Doctor_NoLabel As System.Windows.Forms.Label
        Dim Time_BookedLabel As System.Windows.Forms.Label
        Dim Time_FinishedLabel As System.Windows.Forms.Label
        Dim Processed_ByLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AppointmentBookingSystem1DataSet = New CareHospital.AppointmentBookingSystem1DataSet()
        Me.FinishedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishedTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.FinishedTableAdapter()
        Me.TableAdapterManager = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager()
        Me.FinishedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.FinishedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Finish_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Time_BookedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Time_FinishedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Processed_ByTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FinishedDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Finish_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Doctor_IDLabel = New System.Windows.Forms.Label()
        Doctor_NameLabel = New System.Windows.Forms.Label()
        Doctor_NoLabel = New System.Windows.Forms.Label()
        Time_BookedLabel = New System.Windows.Forms.Label()
        Time_FinishedLabel = New System.Windows.Forms.Label()
        Processed_ByLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinishedBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FinishedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Finish_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Finish_IDTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(Doctor_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Doctor_IDTextBox)
        Me.GroupBox1.Controls.Add(Doctor_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Doctor_NameTextBox)
        Me.GroupBox1.Controls.Add(Doctor_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Doctor_NoTextBox)
        Me.GroupBox1.Controls.Add(Time_BookedLabel)
        Me.GroupBox1.Controls.Add(Me.Time_BookedDateTimePicker)
        Me.GroupBox1.Controls.Add(Time_FinishedLabel)
        Me.GroupBox1.Controls.Add(Me.Time_FinishedDateTimePicker)
        Me.GroupBox1.Controls.Add(Processed_ByLabel)
        Me.GroupBox1.Controls.Add(Me.Processed_ByTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 344)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'AppointmentBookingSystem1DataSet
        '
        Me.AppointmentBookingSystem1DataSet.DataSetName = "AppointmentBookingSystem1DataSet"
        Me.AppointmentBookingSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishedBindingSource
        '
        Me.FinishedBindingSource.DataMember = "Finished"
        Me.FinishedBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'FinishedTableAdapter
        '
        Me.FinishedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Appointment_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishedTableAdapter = Me.FinishedTableAdapter
        Me.TableAdapterManager.ListOfDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FinishedBindingNavigator
        '
        Me.FinishedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FinishedBindingNavigator.BindingSource = Me.FinishedBindingSource
        Me.FinishedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FinishedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FinishedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FinishedBindingNavigatorSaveItem})
        Me.FinishedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FinishedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FinishedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FinishedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FinishedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FinishedBindingNavigator.Name = "FinishedBindingNavigator"
        Me.FinishedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FinishedBindingNavigator.Size = New System.Drawing.Size(952, 25)
        Me.FinishedBindingNavigator.TabIndex = 1
        Me.FinishedBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FinishedBindingNavigatorSaveItem
        '
        Me.FinishedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FinishedBindingNavigatorSaveItem.Image = CType(resources.GetObject("FinishedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FinishedBindingNavigatorSaveItem.Name = "FinishedBindingNavigatorSaveItem"
        Me.FinishedBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FinishedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Finish_IDLabel
        '
        Finish_IDLabel.AutoSize = True
        Finish_IDLabel.Location = New System.Drawing.Point(26, 36)
        Finish_IDLabel.Name = "Finish_IDLabel"
        Finish_IDLabel.Size = New System.Drawing.Size(76, 20)
        Finish_IDLabel.TabIndex = 0
        Finish_IDLabel.Text = "Finish ID:"
        '
        'Finish_IDTextBox
        '
        Me.Finish_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishedBindingSource, "Finish_ID", True))
        Me.Finish_IDTextBox.Location = New System.Drawing.Point(143, 33)
        Me.Finish_IDTextBox.Name = "Finish_IDTextBox"
        Me.Finish_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Finish_IDTextBox.TabIndex = 1
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(26, 68)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishedBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(143, 65)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.First_NameTextBox.TabIndex = 3
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(26, 100)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishedBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(143, 97)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'Doctor_IDLabel
        '
        Doctor_IDLabel.AutoSize = True
        Doctor_IDLabel.Location = New System.Drawing.Point(26, 132)
        Doctor_IDLabel.Name = "Doctor_IDLabel"
        Doctor_IDLabel.Size = New System.Drawing.Size(82, 20)
        Doctor_IDLabel.TabIndex = 6
        Doctor_IDLabel.Text = "Doctor ID:"
        '
        'Doctor_IDTextBox
        '
        Me.Doctor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishedBindingSource, "Doctor_ID", True))
        Me.Doctor_IDTextBox.Location = New System.Drawing.Point(143, 129)
        Me.Doctor_IDTextBox.Name = "Doctor_IDTextBox"
        Me.Doctor_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Doctor_IDTextBox.TabIndex = 7
        '
        'Doctor_NameLabel
        '
        Doctor_NameLabel.AutoSize = True
        Doctor_NameLabel.Location = New System.Drawing.Point(26, 164)
        Doctor_NameLabel.Name = "Doctor_NameLabel"
        Doctor_NameLabel.Size = New System.Drawing.Size(107, 20)
        Doctor_NameLabel.TabIndex = 8
        Doctor_NameLabel.Text = "Doctor Name:"
        '
        'Doctor_NameTextBox
        '
        Me.Doctor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishedBindingSource, "Doctor_Name", True))
        Me.Doctor_NameTextBox.Location = New System.Drawing.Point(143, 161)
        Me.Doctor_NameTextBox.Name = "Doctor_NameTextBox"
        Me.Doctor_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Doctor_NameTextBox.TabIndex = 9
        '
        'Doctor_NoLabel
        '
        Doctor_NoLabel.AutoSize = True
        Doctor_NoLabel.Location = New System.Drawing.Point(26, 196)
        Doctor_NoLabel.Name = "Doctor_NoLabel"
        Doctor_NoLabel.Size = New System.Drawing.Size(85, 20)
        Doctor_NoLabel.TabIndex = 10
        Doctor_NoLabel.Text = "Doctor No:"
        '
        'Doctor_NoTextBox
        '
        Me.Doctor_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishedBindingSource, "Doctor_No", True))
        Me.Doctor_NoTextBox.Location = New System.Drawing.Point(143, 193)
        Me.Doctor_NoTextBox.Name = "Doctor_NoTextBox"
        Me.Doctor_NoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Doctor_NoTextBox.TabIndex = 11
        '
        'Time_BookedLabel
        '
        Time_BookedLabel.AutoSize = True
        Time_BookedLabel.Location = New System.Drawing.Point(26, 229)
        Time_BookedLabel.Name = "Time_BookedLabel"
        Time_BookedLabel.Size = New System.Drawing.Size(106, 20)
        Time_BookedLabel.TabIndex = 12
        Time_BookedLabel.Text = "Time Booked:"
        '
        'Time_BookedDateTimePicker
        '
        Me.Time_BookedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FinishedBindingSource, "Time_Booked", True))
        Me.Time_BookedDateTimePicker.Location = New System.Drawing.Point(143, 225)
        Me.Time_BookedDateTimePicker.Name = "Time_BookedDateTimePicker"
        Me.Time_BookedDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Time_BookedDateTimePicker.TabIndex = 13
        '
        'Time_FinishedLabel
        '
        Time_FinishedLabel.AutoSize = True
        Time_FinishedLabel.Location = New System.Drawing.Point(26, 261)
        Time_FinishedLabel.Name = "Time_FinishedLabel"
        Time_FinishedLabel.Size = New System.Drawing.Size(111, 20)
        Time_FinishedLabel.TabIndex = 14
        Time_FinishedLabel.Text = "Time Finished:"
        '
        'Time_FinishedDateTimePicker
        '
        Me.Time_FinishedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FinishedBindingSource, "Time_Finished", True))
        Me.Time_FinishedDateTimePicker.Location = New System.Drawing.Point(143, 257)
        Me.Time_FinishedDateTimePicker.Name = "Time_FinishedDateTimePicker"
        Me.Time_FinishedDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Time_FinishedDateTimePicker.TabIndex = 15
        '
        'Processed_ByLabel
        '
        Processed_ByLabel.AutoSize = True
        Processed_ByLabel.Location = New System.Drawing.Point(26, 292)
        Processed_ByLabel.Name = "Processed_ByLabel"
        Processed_ByLabel.Size = New System.Drawing.Size(110, 20)
        Processed_ByLabel.TabIndex = 16
        Processed_ByLabel.Text = "Processed By:"
        '
        'Processed_ByTextBox
        '
        Me.Processed_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishedBindingSource, "Processed_By", True))
        Me.Processed_ByTextBox.Location = New System.Drawing.Point(143, 289)
        Me.Processed_ByTextBox.Name = "Processed_ByTextBox"
        Me.Processed_ByTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Processed_ByTextBox.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(252, 480)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(148, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(275, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(246, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Finished Appointments"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FinishedDataGridView)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(491, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 344)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'FinishedDataGridView
        '
        Me.FinishedDataGridView.AutoGenerateColumns = False
        Me.FinishedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinishedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.FinishedDataGridView.DataSource = Me.FinishedBindingSource
        Me.FinishedDataGridView.Location = New System.Drawing.Point(6, 27)
        Me.FinishedDataGridView.Name = "FinishedDataGridView"
        Me.FinishedDataGridView.Size = New System.Drawing.Size(437, 220)
        Me.FinishedDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Finish_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Finish_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Doctor_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Doctor_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Doctor_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Doctor_Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Doctor_No"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Doctor_No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Time_Booked"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time_Booked"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Time_Finished"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time_Finished"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Processed_By"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Processed_By"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Finished
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 633)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FinishedBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Finished"
        Me.Text = "Finished"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinishedBindingNavigator.ResumeLayout(False)
        Me.FinishedBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.FinishedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AppointmentBookingSystem1DataSet As CareHospital.AppointmentBookingSystem1DataSet
    Friend WithEvents FinishedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishedTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.FinishedTableAdapter
    Friend WithEvents TableAdapterManager As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinishedBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FinishedBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Finish_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Time_BookedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Time_FinishedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Processed_ByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FinishedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
