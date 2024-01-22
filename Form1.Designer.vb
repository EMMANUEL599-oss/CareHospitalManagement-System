<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim AppointmentDetails_IDLabel As System.Windows.Forms.Label
        Dim Appointment_IDLabel As System.Windows.Forms.Label
        Dim Doctor_IDLabel As System.Windows.Forms.Label
        Dim Doctor_NoLabel As System.Windows.Forms.Label
        Dim Doctor_NameLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Fee_HourLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AppointmentDetails_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Appointment_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentBookingSystem1DataSet = New CareHospital.AppointmentBookingSystem1DataSet()
        Me.Appointment_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Fee_HourTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Appointment_DetailsTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.Appointment_DetailsTableAdapter()
        Me.TableAdapterManager = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager()
        Me.Appointment_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Appointment_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ListOfDoctorsTableAdapter1 = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.ListOfDoctorsTableAdapter()
        Me.AdminTableAdapter1 = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AdminTableAdapter()
        Me.AppointmentTableAdapter1 = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AppointmentTableAdapter()
        AppointmentDetails_IDLabel = New System.Windows.Forms.Label()
        Appointment_IDLabel = New System.Windows.Forms.Label()
        Doctor_IDLabel = New System.Windows.Forms.Label()
        Doctor_NoLabel = New System.Windows.Forms.Label()
        Doctor_NameLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Fee_HourLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Appointment_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Appointment_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Appointment_DetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppointmentDetails_IDLabel
        '
        AppointmentDetails_IDLabel.AutoSize = True
        AppointmentDetails_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AppointmentDetails_IDLabel.Location = New System.Drawing.Point(6, 58)
        AppointmentDetails_IDLabel.Name = "AppointmentDetails_IDLabel"
        AppointmentDetails_IDLabel.Size = New System.Drawing.Size(178, 20)
        AppointmentDetails_IDLabel.TabIndex = 0
        AppointmentDetails_IDLabel.Text = "Appointment Details ID:"
        '
        'Appointment_IDLabel
        '
        Appointment_IDLabel.AutoSize = True
        Appointment_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appointment_IDLabel.Location = New System.Drawing.Point(6, 104)
        Appointment_IDLabel.Name = "Appointment_IDLabel"
        Appointment_IDLabel.Size = New System.Drawing.Size(125, 20)
        Appointment_IDLabel.TabIndex = 2
        Appointment_IDLabel.Text = "Appointment ID:"
        '
        'Doctor_IDLabel
        '
        Doctor_IDLabel.AutoSize = True
        Doctor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_IDLabel.Location = New System.Drawing.Point(6, 150)
        Doctor_IDLabel.Name = "Doctor_IDLabel"
        Doctor_IDLabel.Size = New System.Drawing.Size(82, 20)
        Doctor_IDLabel.TabIndex = 4
        Doctor_IDLabel.Text = "Doctor ID:"
        '
        'Doctor_NoLabel
        '
        Doctor_NoLabel.AutoSize = True
        Doctor_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_NoLabel.Location = New System.Drawing.Point(6, 196)
        Doctor_NoLabel.Name = "Doctor_NoLabel"
        Doctor_NoLabel.Size = New System.Drawing.Size(85, 20)
        Doctor_NoLabel.TabIndex = 6
        Doctor_NoLabel.Text = "Doctor No:"
        '
        'Doctor_NameLabel
        '
        Doctor_NameLabel.AutoSize = True
        Doctor_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_NameLabel.Location = New System.Drawing.Point(6, 242)
        Doctor_NameLabel.Name = "Doctor_NameLabel"
        Doctor_NameLabel.Size = New System.Drawing.Size(107, 20)
        Doctor_NameLabel.TabIndex = 8
        Doctor_NameLabel.Text = "Doctor Name:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColorLabel.Location = New System.Drawing.Point(6, 288)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(50, 20)
        ColorLabel.TabIndex = 10
        ColorLabel.Text = "Color:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(6, 334)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 12
        QuantityLabel.Text = "Quantity:"
        '
        'Fee_HourLabel
        '
        Fee_HourLabel.AutoSize = True
        Fee_HourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fee_HourLabel.Location = New System.Drawing.Point(6, 380)
        Fee_HourLabel.Name = "Fee_HourLabel"
        Fee_HourLabel.Size = New System.Drawing.Size(80, 20)
        Fee_HourLabel.TabIndex = 14
        Fee_HourLabel.Text = "Fee/Hour:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(AppointmentDetails_IDLabel)
        Me.GroupBox1.Controls.Add(Me.AppointmentDetails_IDTextBox)
        Me.GroupBox1.Controls.Add(Appointment_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Appointment_IDTextBox)
        Me.GroupBox1.Controls.Add(Doctor_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Doctor_IDTextBox)
        Me.GroupBox1.Controls.Add(Doctor_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Doctor_NoTextBox)
        Me.GroupBox1.Controls.Add(Doctor_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Doctor_NameTextBox)
        Me.GroupBox1.Controls.Add(ColorLabel)
        Me.GroupBox1.Controls.Add(Me.ColorTextBox)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Fee_HourLabel)
        Me.GroupBox1.Controls.Add(Me.Fee_HourTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 469)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'AppointmentDetails_IDTextBox
        '
        Me.AppointmentDetails_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "AppointmentDetails_ID", True))
        Me.AppointmentDetails_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentDetails_IDTextBox.Location = New System.Drawing.Point(193, 52)
        Me.AppointmentDetails_IDTextBox.Name = "AppointmentDetails_IDTextBox"
        Me.AppointmentDetails_IDTextBox.Size = New System.Drawing.Size(223, 26)
        Me.AppointmentDetails_IDTextBox.TabIndex = 1
        '
        'Appointment_DetailsBindingSource
        '
        Me.Appointment_DetailsBindingSource.DataMember = "Appointment_Details"
        Me.Appointment_DetailsBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'AppointmentBookingSystem1DataSet
        '
        Me.AppointmentBookingSystem1DataSet.DataSetName = "AppointmentBookingSystem1DataSet"
        Me.AppointmentBookingSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Appointment_IDTextBox
        '
        Me.Appointment_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "Appointment_ID", True))
        Me.Appointment_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appointment_IDTextBox.Location = New System.Drawing.Point(187, 98)
        Me.Appointment_IDTextBox.Name = "Appointment_IDTextBox"
        Me.Appointment_IDTextBox.Size = New System.Drawing.Size(229, 26)
        Me.Appointment_IDTextBox.TabIndex = 3
        '
        'Doctor_IDTextBox
        '
        Me.Doctor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "Doctor_ID", True))
        Me.Doctor_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_IDTextBox.Location = New System.Drawing.Point(187, 144)
        Me.Doctor_IDTextBox.Name = "Doctor_IDTextBox"
        Me.Doctor_IDTextBox.Size = New System.Drawing.Size(229, 26)
        Me.Doctor_IDTextBox.TabIndex = 5
        '
        'Doctor_NoTextBox
        '
        Me.Doctor_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "Doctor_No", True))
        Me.Doctor_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_NoTextBox.Location = New System.Drawing.Point(187, 190)
        Me.Doctor_NoTextBox.Name = "Doctor_NoTextBox"
        Me.Doctor_NoTextBox.Size = New System.Drawing.Size(229, 26)
        Me.Doctor_NoTextBox.TabIndex = 7
        '
        'Doctor_NameTextBox
        '
        Me.Doctor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "Doctor_Name", True))
        Me.Doctor_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_NameTextBox.Location = New System.Drawing.Point(187, 236)
        Me.Doctor_NameTextBox.Name = "Doctor_NameTextBox"
        Me.Doctor_NameTextBox.Size = New System.Drawing.Size(229, 26)
        Me.Doctor_NameTextBox.TabIndex = 9
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "Color", True))
        Me.ColorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTextBox.Location = New System.Drawing.Point(187, 282)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(229, 26)
        Me.ColorTextBox.TabIndex = 11
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(187, 328)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(229, 26)
        Me.QuantityTextBox.TabIndex = 13
        '
        'Fee_HourTextBox
        '
        Me.Fee_HourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Appointment_DetailsBindingSource, "Fee/Hour", True))
        Me.Fee_HourTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fee_HourTextBox.Location = New System.Drawing.Point(187, 374)
        Me.Fee_HourTextBox.Name = "Fee_HourTextBox"
        Me.Fee_HourTextBox.Size = New System.Drawing.Size(229, 26)
        Me.Fee_HourTextBox.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Appointment_DetailsDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(482, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 301)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Appointment_DetailsDataGridView
        '
        Me.Appointment_DetailsDataGridView.AutoGenerateColumns = False
        Me.Appointment_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Appointment_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn1})
        Me.Appointment_DetailsDataGridView.DataSource = Me.Appointment_DetailsBindingSource
        Me.Appointment_DetailsDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.Appointment_DetailsDataGridView.Name = "Appointment_DetailsDataGridView"
        Me.Appointment_DetailsDataGridView.Size = New System.Drawing.Size(495, 276)
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
        'Appointment_DetailsTableAdapter
        '
        Me.Appointment_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Appointment_DetailsTableAdapter = Me.Appointment_DetailsTableAdapter
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishedTableAdapter = Nothing
        Me.TableAdapterManager.ListOfDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Appointment_DetailsBindingNavigator
        '
        Me.Appointment_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Appointment_DetailsBindingNavigator.BindingSource = Me.Appointment_DetailsBindingSource
        Me.Appointment_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Appointment_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Appointment_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Appointment_DetailsBindingNavigatorSaveItem})
        Me.Appointment_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Appointment_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Appointment_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Appointment_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Appointment_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Appointment_DetailsBindingNavigator.Name = "Appointment_DetailsBindingNavigator"
        Me.Appointment_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Appointment_DetailsBindingNavigator.Size = New System.Drawing.Size(1028, 25)
        Me.Appointment_DetailsBindingNavigator.TabIndex = 2
        Me.Appointment_DetailsBindingNavigator.Text = "BindingNavigator1"
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
        'Appointment_DetailsBindingNavigatorSaveItem
        '
        Me.Appointment_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Appointment_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Appointment_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Appointment_DetailsBindingNavigatorSaveItem.Name = "Appointment_DetailsBindingNavigatorSaveItem"
        Me.Appointment_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Appointment_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ListOfDoctorsTableAdapter1
        '
        Me.ListOfDoctorsTableAdapter1.ClearBeforeFill = True
        '
        'AdminTableAdapter1
        '
        Me.AdminTableAdapter1.ClearBeforeFill = True
        '
        'AppointmentTableAdapter1
        '
        Me.AppointmentTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 540)
        Me.Controls.Add(Me.Appointment_DetailsBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Appointment_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Appointment_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Appointment_DetailsBindingNavigator.ResumeLayout(False)
        Me.Appointment_DetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AppointmentBookingSystem1DataSet As CareHospital.AppointmentBookingSystem1DataSet
    Friend WithEvents Appointment_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Appointment_DetailsTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.Appointment_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Appointment_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Appointment_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AppointmentDetails_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Appointment_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fee_HourTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents ListOfDoctorsTableAdapter1 As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.ListOfDoctorsTableAdapter
    Friend WithEvents AdminTableAdapter1 As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AdminTableAdapter
    Friend WithEvents AppointmentTableAdapter1 As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AppointmentTableAdapter

End Class
