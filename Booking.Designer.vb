<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Dim Doctor_IDLabel As System.Windows.Forms.Label
        Dim Doctor_NoLabel As System.Windows.Forms.Label
        Dim Doctor_NameLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Fee_HourLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Doctor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ListOfDoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentBookingSystem1DataSet = New CareHospital.AppointmentBookingSystem1DataSet()
        Me.Doctor_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Fee_HourTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Appointment_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Appointment_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListOfDoctorsTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.ListOfDoctorsTableAdapter()
        Me.TableAdapterManager = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager()
        Me.ListOfDoctorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListOfDoctorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Appointment_DetailsTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.Appointment_DetailsTableAdapter()
        Me.AppointmentTableAdapter1 = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AppointmentTableAdapter()
        Doctor_IDLabel = New System.Windows.Forms.Label()
        Doctor_NoLabel = New System.Windows.Forms.Label()
        Doctor_NameLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Fee_HourLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListOfDoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Appointment_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ListOfDoctorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListOfDoctorsBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Doctor_IDLabel
        '
        Doctor_IDLabel.AutoSize = True
        Doctor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_IDLabel.Location = New System.Drawing.Point(14, 29)
        Doctor_IDLabel.Name = "Doctor_IDLabel"
        Doctor_IDLabel.Size = New System.Drawing.Size(82, 20)
        Doctor_IDLabel.TabIndex = 0
        Doctor_IDLabel.Text = "Doctor ID:"
        '
        'Doctor_NoLabel
        '
        Doctor_NoLabel.AutoSize = True
        Doctor_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_NoLabel.Location = New System.Drawing.Point(14, 70)
        Doctor_NoLabel.Name = "Doctor_NoLabel"
        Doctor_NoLabel.Size = New System.Drawing.Size(85, 20)
        Doctor_NoLabel.TabIndex = 2
        Doctor_NoLabel.Text = "Doctor No:"
        '
        'Doctor_NameLabel
        '
        Doctor_NameLabel.AutoSize = True
        Doctor_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_NameLabel.Location = New System.Drawing.Point(14, 103)
        Doctor_NameLabel.Name = "Doctor_NameLabel"
        Doctor_NameLabel.Size = New System.Drawing.Size(107, 20)
        Doctor_NameLabel.TabIndex = 4
        Doctor_NameLabel.Text = "Doctor Name:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColorLabel.Location = New System.Drawing.Point(14, 135)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(50, 20)
        ColorLabel.TabIndex = 6
        ColorLabel.Text = "Color:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(14, 179)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 8
        QuantityLabel.Text = "Quantity:"
        '
        'Fee_HourLabel
        '
        Fee_HourLabel.AutoSize = True
        Fee_HourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fee_HourLabel.Location = New System.Drawing.Point(14, 223)
        Fee_HourLabel.Name = "Fee_HourLabel"
        Fee_HourLabel.Size = New System.Drawing.Size(80, 20)
        Fee_HourLabel.TabIndex = 10
        Fee_HourLabel.Text = "Fee/Hour:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Doctor_IDLabel)
        Me.GroupBox2.Controls.Add(Me.Doctor_IDTextBox)
        Me.GroupBox2.Controls.Add(Doctor_NoLabel)
        Me.GroupBox2.Controls.Add(Me.Doctor_NoTextBox)
        Me.GroupBox2.Controls.Add(Doctor_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Doctor_NameTextBox)
        Me.GroupBox2.Controls.Add(ColorLabel)
        Me.GroupBox2.Controls.Add(Me.ColorTextBox)
        Me.GroupBox2.Controls.Add(QuantityLabel)
        Me.GroupBox2.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox2.Controls.Add(Fee_HourLabel)
        Me.GroupBox2.Controls.Add(Me.Fee_HourTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 288)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Doctor_IDTextBox
        '
        Me.Doctor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfDoctorsBindingSource, "Doctor_ID", True))
        Me.Doctor_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_IDTextBox.Location = New System.Drawing.Point(126, 29)
        Me.Doctor_IDTextBox.Name = "Doctor_IDTextBox"
        Me.Doctor_IDTextBox.Size = New System.Drawing.Size(181, 26)
        Me.Doctor_IDTextBox.TabIndex = 1
        '
        'ListOfDoctorsBindingSource
        '
        Me.ListOfDoctorsBindingSource.DataMember = "ListOfDoctors"
        Me.ListOfDoctorsBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'AppointmentBookingSystem1DataSet
        '
        Me.AppointmentBookingSystem1DataSet.DataSetName = "AppointmentBookingSystem1DataSet"
        Me.AppointmentBookingSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_NoTextBox
        '
        Me.Doctor_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfDoctorsBindingSource, "Doctor_No", True))
        Me.Doctor_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_NoTextBox.Location = New System.Drawing.Point(126, 70)
        Me.Doctor_NoTextBox.Name = "Doctor_NoTextBox"
        Me.Doctor_NoTextBox.Size = New System.Drawing.Size(181, 26)
        Me.Doctor_NoTextBox.TabIndex = 3
        '
        'Doctor_NameTextBox
        '
        Me.Doctor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfDoctorsBindingSource, "Doctor_Name", True))
        Me.Doctor_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_NameTextBox.Location = New System.Drawing.Point(126, 103)
        Me.Doctor_NameTextBox.Name = "Doctor_NameTextBox"
        Me.Doctor_NameTextBox.Size = New System.Drawing.Size(181, 26)
        Me.Doctor_NameTextBox.TabIndex = 5
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfDoctorsBindingSource, "Color", True))
        Me.ColorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTextBox.Location = New System.Drawing.Point(126, 135)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(181, 26)
        Me.ColorTextBox.TabIndex = 7
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfDoctorsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(126, 179)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(181, 26)
        Me.QuantityTextBox.TabIndex = 9
        '
        'Fee_HourTextBox
        '
        Me.Fee_HourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfDoctorsBindingSource, "Fee/Hour", True))
        Me.Fee_HourTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fee_HourTextBox.Location = New System.Drawing.Point(126, 223)
        Me.Fee_HourTextBox.Name = "Fee_HourTextBox"
        Me.Fee_HourTextBox.Size = New System.Drawing.Size(181, 26)
        Me.Fee_HourTextBox.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Appointment_DetailsDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(361, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(529, 288)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Appointment_DetailsDataGridView
        '
        Me.Appointment_DetailsDataGridView.AutoGenerateColumns = False
        Me.Appointment_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Appointment_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn1})
        Me.Appointment_DetailsDataGridView.DataSource = Me.Appointment_DetailsBindingSource
        Me.Appointment_DetailsDataGridView.Location = New System.Drawing.Point(6, 8)
        Me.Appointment_DetailsDataGridView.Name = "Appointment_DetailsDataGridView"
        Me.Appointment_DetailsDataGridView.Size = New System.Drawing.Size(516, 274)
        Me.Appointment_DetailsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AppointmentDetails_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AppointmentDetails_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Appointment_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Appointment_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Doctor_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Doctor_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Doctor_No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Doctor_No"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fee/Hour"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fee/Hour"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.DataGridViewImageColumn1.HeaderText = "Picture"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Appointment_DetailsBindingSource
        '
        Me.Appointment_DetailsBindingSource.DataMember = "Appointment_Details"
        Me.Appointment_DetailsBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(13, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 101)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(333, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListOfDoctorsTableAdapter
        '
        Me.ListOfDoctorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Appointment_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishedTableAdapter = Nothing
        Me.TableAdapterManager.ListOfDoctorsTableAdapter = Me.ListOfDoctorsTableAdapter
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListOfDoctorsBindingNavigator
        '
        Me.ListOfDoctorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListOfDoctorsBindingNavigator.BindingSource = Me.ListOfDoctorsBindingSource
        Me.ListOfDoctorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListOfDoctorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListOfDoctorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListOfDoctorsBindingNavigatorSaveItem})
        Me.ListOfDoctorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ListOfDoctorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListOfDoctorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListOfDoctorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListOfDoctorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListOfDoctorsBindingNavigator.Name = "ListOfDoctorsBindingNavigator"
        Me.ListOfDoctorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListOfDoctorsBindingNavigator.Size = New System.Drawing.Size(904, 25)
        Me.ListOfDoctorsBindingNavigator.TabIndex = 4
        Me.ListOfDoctorsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ListOfDoctorsBindingNavigatorSaveItem
        '
        Me.ListOfDoctorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListOfDoctorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListOfDoctorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListOfDoctorsBindingNavigatorSaveItem.Name = "ListOfDoctorsBindingNavigatorSaveItem"
        Me.ListOfDoctorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListOfDoctorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(367, 470)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 107)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(395, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Appointment_DetailsTableAdapter
        '
        Me.Appointment_DetailsTableAdapter.ClearBeforeFill = True
        '
        'AppointmentTableAdapter1
        '
        Me.AppointmentTableAdapter1.ClearBeforeFill = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 605)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListOfDoctorsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Booking"
        Me.Text = "Booking"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ListOfDoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Appointment_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ListOfDoctorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListOfDoctorsBindingNavigator.ResumeLayout(False)
        Me.ListOfDoctorsBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AppointmentBookingSystem1DataSet As CareHospital.AppointmentBookingSystem1DataSet
    Friend WithEvents ListOfDoctorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfDoctorsTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.ListOfDoctorsTableAdapter
    Friend WithEvents TableAdapterManager As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListOfDoctorsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ListOfDoctorsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doctor_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fee_HourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Appointment_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Appointment_DetailsTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.Appointment_DetailsTableAdapter
    Friend WithEvents Appointment_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents AppointmentTableAdapter1 As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AppointmentTableAdapter
End Class
