<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Cellphone_NoLabel As System.Windows.Forms.Label
        Dim Telephone_NoLabel As System.Windows.Forms.Label
        Dim Street_AddressLabel As System.Windows.Forms.Label
        Dim City_TownLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patients))
        Me.PatientTextBox1 = New System.Windows.Forms.TextBox()
        Me.AppointmentBookingSystem1DataSet = New CareHospital.AppointmentBookingSystem1DataSet()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.PatientTableAdapter()
        Me.TableAdapterManager = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager()
        Me.PatientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PatientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Cellphone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Street_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.City_TownTextBox = New System.Windows.Forms.TextBox()
        Me.PatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Cellphone_NoLabel = New System.Windows.Forms.Label()
        Telephone_NoLabel = New System.Windows.Forms.Label()
        Street_AddressLabel = New System.Windows.Forms.Label()
        City_TownLabel = New System.Windows.Forms.Label()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientBindingNavigator.SuspendLayout()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Location = New System.Drawing.Point(8, 128)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(84, 20)
        Patient_IDLabel.TabIndex = 2
        Patient_IDLabel.Text = "Patient ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(8, 160)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(8, 192)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(8, 224)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(42, 20)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'Cellphone_NoLabel
        '
        Cellphone_NoLabel.AutoSize = True
        Cellphone_NoLabel.Location = New System.Drawing.Point(8, 256)
        Cellphone_NoLabel.Name = "Cellphone_NoLabel"
        Cellphone_NoLabel.Size = New System.Drawing.Size(108, 20)
        Cellphone_NoLabel.TabIndex = 10
        Cellphone_NoLabel.Text = "Cellphone No:"
        '
        'Telephone_NoLabel
        '
        Telephone_NoLabel.AutoSize = True
        Telephone_NoLabel.Location = New System.Drawing.Point(8, 288)
        Telephone_NoLabel.Name = "Telephone_NoLabel"
        Telephone_NoLabel.Size = New System.Drawing.Size(112, 20)
        Telephone_NoLabel.TabIndex = 12
        Telephone_NoLabel.Text = "Telephone No:"
        '
        'Street_AddressLabel
        '
        Street_AddressLabel.AutoSize = True
        Street_AddressLabel.Location = New System.Drawing.Point(8, 320)
        Street_AddressLabel.Name = "Street_AddressLabel"
        Street_AddressLabel.Size = New System.Drawing.Size(120, 20)
        Street_AddressLabel.TabIndex = 14
        Street_AddressLabel.Text = "Street Address:"
        '
        'City_TownLabel
        '
        City_TownLabel.AutoSize = True
        City_TownLabel.Location = New System.Drawing.Point(8, 352)
        City_TownLabel.Name = "City_TownLabel"
        City_TownLabel.Size = New System.Drawing.Size(81, 20)
        City_TownLabel.TabIndex = 16
        City_TownLabel.Text = "City/Town:"
        '
        'PatientTextBox1
        '
        Me.PatientTextBox1.Location = New System.Drawing.Point(12, 66)
        Me.PatientTextBox1.Name = "PatientTextBox1"
        Me.PatientTextBox1.Size = New System.Drawing.Size(369, 26)
        Me.PatientTextBox1.TabIndex = 0
        '
        'AppointmentBookingSystem1DataSet
        '
        Me.AppointmentBookingSystem1DataSet.DataSetName = "AppointmentBookingSystem1DataSet"
        Me.AppointmentBookingSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Appointment_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishedTableAdapter = Nothing
        Me.TableAdapterManager.ListOfDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.PatientLoginDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Me.PatientTableAdapter
        Me.TableAdapterManager.tblDoctorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientBindingNavigator
        '
        Me.PatientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientBindingNavigator.BindingSource = Me.PatientBindingSource
        Me.PatientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientBindingNavigatorSaveItem})
        Me.PatientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PatientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientBindingNavigator.Name = "PatientBindingNavigator"
        Me.PatientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientBindingNavigator.Size = New System.Drawing.Size(896, 25)
        Me.PatientBindingNavigator.TabIndex = 1
        Me.PatientBindingNavigator.Text = "BindingNavigator1"
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
        'PatientBindingNavigatorSaveItem
        '
        Me.PatientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientBindingNavigatorSaveItem.Name = "PatientBindingNavigatorSaveItem"
        Me.PatientBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PatientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Patient_ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(134, 125)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Patient_IDTextBox.TabIndex = 3
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(134, 157)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(247, 26)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(134, 189)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(134, 221)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(247, 26)
        Me.AgeTextBox.TabIndex = 9
        '
        'Cellphone_NoTextBox
        '
        Me.Cellphone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Cellphone_No", True))
        Me.Cellphone_NoTextBox.Location = New System.Drawing.Point(134, 253)
        Me.Cellphone_NoTextBox.Name = "Cellphone_NoTextBox"
        Me.Cellphone_NoTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Cellphone_NoTextBox.TabIndex = 11
        '
        'Telephone_NoTextBox
        '
        Me.Telephone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Telephone_No", True))
        Me.Telephone_NoTextBox.Location = New System.Drawing.Point(134, 285)
        Me.Telephone_NoTextBox.Name = "Telephone_NoTextBox"
        Me.Telephone_NoTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Telephone_NoTextBox.TabIndex = 13
        '
        'Street_AddressTextBox
        '
        Me.Street_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Street_Address", True))
        Me.Street_AddressTextBox.Location = New System.Drawing.Point(134, 317)
        Me.Street_AddressTextBox.Name = "Street_AddressTextBox"
        Me.Street_AddressTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Street_AddressTextBox.TabIndex = 15
        '
        'City_TownTextBox
        '
        Me.City_TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "City/Town", True))
        Me.City_TownTextBox.Location = New System.Drawing.Point(134, 349)
        Me.City_TownTextBox.Name = "City_TownTextBox"
        Me.City_TownTextBox.Size = New System.Drawing.Size(247, 26)
        Me.City_TownTextBox.TabIndex = 17
        '
        'PatientDataGridView
        '
        Me.PatientDataGridView.AutoGenerateColumns = False
        Me.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PatientDataGridView.DataSource = Me.PatientBindingSource
        Me.PatientDataGridView.Location = New System.Drawing.Point(421, 66)
        Me.PatientDataGridView.Name = "PatientDataGridView"
        Me.PatientDataGridView.Size = New System.Drawing.Size(458, 213)
        Me.PatientDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Patient_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Patient_ID"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cellphone_No"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cellphone_No"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telephone_No"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone_No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Street_Address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Street_Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "City/Town"
        Me.DataGridViewTextBoxColumn8.HeaderText = "City/Town"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 155)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(194, 100)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 49)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(349, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(194, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 34)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "VIEW AND ADD PATIENTS"
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 455)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PatientDataGridView)
        Me.Controls.Add(Patient_IDLabel)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Cellphone_NoLabel)
        Me.Controls.Add(Me.Cellphone_NoTextBox)
        Me.Controls.Add(Telephone_NoLabel)
        Me.Controls.Add(Me.Telephone_NoTextBox)
        Me.Controls.Add(Street_AddressLabel)
        Me.Controls.Add(Me.Street_AddressTextBox)
        Me.Controls.Add(City_TownLabel)
        Me.Controls.Add(Me.City_TownTextBox)
        Me.Controls.Add(Me.PatientBindingNavigator)
        Me.Controls.Add(Me.PatientTextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Patients"
        Me.Text = "Patients"
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientBindingNavigator.ResumeLayout(False)
        Me.PatientBindingNavigator.PerformLayout()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PatientTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AppointmentBookingSystem1DataSet As CareHospital.AppointmentBookingSystem1DataSet
    Friend WithEvents PatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.PatientTableAdapter
    Friend WithEvents TableAdapterManager As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PatientBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Patient_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cellphone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents City_TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
