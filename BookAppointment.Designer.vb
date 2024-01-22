<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookAppointment
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
        Dim Appointment_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Cellphone_NoLabel As System.Windows.Forms.Label
        Dim Telephone_NoLabel As System.Windows.Forms.Label
        Dim Street_AddressLabel As System.Windows.Forms.Label
        Dim City_TownLabel As System.Windows.Forms.Label
        Dim Doctor_IDLabel As System.Windows.Forms.Label
        Dim Doctor_NameLabel As System.Windows.Forms.Label
        Dim Doctor_NoLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Fee_HourLabel As System.Windows.Forms.Label
        Dim No_of_HoursLabel As System.Windows.Forms.Label
        Dim Total_DueLabel As System.Windows.Forms.Label
        Dim Processed_ByLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookAppointment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListOfDoctorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ListOfDoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentBookingSystem1DataSet = New CareHospital.AppointmentBookingSystem1DataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Appointment_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Appointment_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Cellphone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Street_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.City_TownTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NoTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fee_HourTextBox = New System.Windows.Forms.TextBox()
        Me.No_of_HoursTextBox = New System.Windows.Forms.TextBox()
        Me.Total_DueTextBox = New System.Windows.Forms.TextBox()
        Me.Processed_ByTextBox = New System.Windows.Forms.TextBox()
        Me.AppointmentTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AppointmentTableAdapter()
        Me.TableAdapterManager = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager()
        Me.Appointment_DetailsTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.Appointment_DetailsTableAdapter()
        Me.ListOfDoctorsTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.ListOfDoctorsTableAdapter()
        Me.AppointmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AppointmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Appointment_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Cellphone_NoLabel = New System.Windows.Forms.Label()
        Telephone_NoLabel = New System.Windows.Forms.Label()
        Street_AddressLabel = New System.Windows.Forms.Label()
        City_TownLabel = New System.Windows.Forms.Label()
        Doctor_IDLabel = New System.Windows.Forms.Label()
        Doctor_NameLabel = New System.Windows.Forms.Label()
        Doctor_NoLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Fee_HourLabel = New System.Windows.Forms.Label()
        No_of_HoursLabel = New System.Windows.Forms.Label()
        Total_DueLabel = New System.Windows.Forms.Label()
        Processed_ByLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListOfDoctorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfDoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppointmentBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Appointment_IDLabel
        '
        Appointment_IDLabel.AutoSize = True
        Appointment_IDLabel.Location = New System.Drawing.Point(32, 38)
        Appointment_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Appointment_IDLabel.Name = "Appointment_IDLabel"
        Appointment_IDLabel.Size = New System.Drawing.Size(83, 13)
        Appointment_IDLabel.TabIndex = 0
        Appointment_IDLabel.Text = "Appointment ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(32, 68)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(32, 98)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(32, 128)
        AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 6
        AgeLabel.Text = "Age:"
        '
        'Cellphone_NoLabel
        '
        Cellphone_NoLabel.AutoSize = True
        Cellphone_NoLabel.Location = New System.Drawing.Point(32, 158)
        Cellphone_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cellphone_NoLabel.Name = "Cellphone_NoLabel"
        Cellphone_NoLabel.Size = New System.Drawing.Size(74, 13)
        Cellphone_NoLabel.TabIndex = 8
        Cellphone_NoLabel.Text = "Cellphone No:"
        '
        'Telephone_NoLabel
        '
        Telephone_NoLabel.AutoSize = True
        Telephone_NoLabel.Location = New System.Drawing.Point(32, 188)
        Telephone_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telephone_NoLabel.Name = "Telephone_NoLabel"
        Telephone_NoLabel.Size = New System.Drawing.Size(78, 13)
        Telephone_NoLabel.TabIndex = 10
        Telephone_NoLabel.Text = "Telephone No:"
        '
        'Street_AddressLabel
        '
        Street_AddressLabel.AutoSize = True
        Street_AddressLabel.Location = New System.Drawing.Point(32, 218)
        Street_AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Street_AddressLabel.Name = "Street_AddressLabel"
        Street_AddressLabel.Size = New System.Drawing.Size(79, 13)
        Street_AddressLabel.TabIndex = 12
        Street_AddressLabel.Text = "Street Address:"
        '
        'City_TownLabel
        '
        City_TownLabel.AutoSize = True
        City_TownLabel.Location = New System.Drawing.Point(32, 248)
        City_TownLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        City_TownLabel.Name = "City_TownLabel"
        City_TownLabel.Size = New System.Drawing.Size(59, 13)
        City_TownLabel.TabIndex = 14
        City_TownLabel.Text = "City/Town:"
        '
        'Doctor_IDLabel
        '
        Doctor_IDLabel.AutoSize = True
        Doctor_IDLabel.Location = New System.Drawing.Point(32, 278)
        Doctor_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Doctor_IDLabel.Name = "Doctor_IDLabel"
        Doctor_IDLabel.Size = New System.Drawing.Size(56, 13)
        Doctor_IDLabel.TabIndex = 16
        Doctor_IDLabel.Text = "Doctor ID:"
        '
        'Doctor_NameLabel
        '
        Doctor_NameLabel.AutoSize = True
        Doctor_NameLabel.Location = New System.Drawing.Point(32, 308)
        Doctor_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Doctor_NameLabel.Name = "Doctor_NameLabel"
        Doctor_NameLabel.Size = New System.Drawing.Size(73, 13)
        Doctor_NameLabel.TabIndex = 18
        Doctor_NameLabel.Text = "Doctor Name:"
        '
        'Doctor_NoLabel
        '
        Doctor_NoLabel.AutoSize = True
        Doctor_NoLabel.Location = New System.Drawing.Point(32, 338)
        Doctor_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Doctor_NoLabel.Name = "Doctor_NoLabel"
        Doctor_NoLabel.Size = New System.Drawing.Size(59, 13)
        Doctor_NoLabel.TabIndex = 20
        Doctor_NoLabel.Text = "Doctor No:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(32, 368)
        ColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 22
        ColorLabel.Text = "Color:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(32, 399)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 24
        DateLabel.Text = "Date:"
        '
        'Fee_HourLabel
        '
        Fee_HourLabel.AutoSize = True
        Fee_HourLabel.Location = New System.Drawing.Point(32, 428)
        Fee_HourLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fee_HourLabel.Name = "Fee_HourLabel"
        Fee_HourLabel.Size = New System.Drawing.Size(56, 13)
        Fee_HourLabel.TabIndex = 26
        Fee_HourLabel.Text = "Fee/Hour:"
        '
        'No_of_HoursLabel
        '
        No_of_HoursLabel.AutoSize = True
        No_of_HoursLabel.Location = New System.Drawing.Point(32, 458)
        No_of_HoursLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        No_of_HoursLabel.Name = "No_of_HoursLabel"
        No_of_HoursLabel.Size = New System.Drawing.Size(67, 13)
        No_of_HoursLabel.TabIndex = 28
        No_of_HoursLabel.Text = "No of Hours:"
        '
        'Total_DueLabel
        '
        Total_DueLabel.AutoSize = True
        Total_DueLabel.Location = New System.Drawing.Point(32, 488)
        Total_DueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_DueLabel.Name = "Total_DueLabel"
        Total_DueLabel.Size = New System.Drawing.Size(57, 13)
        Total_DueLabel.TabIndex = 30
        Total_DueLabel.Text = "Total Due:"
        '
        'Processed_ByLabel
        '
        Processed_ByLabel.AutoSize = True
        Processed_ByLabel.Location = New System.Drawing.Point(32, 518)
        Processed_ByLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Processed_ByLabel.Name = "Processed_ByLabel"
        Processed_ByLabel.Size = New System.Drawing.Size(75, 13)
        Processed_ByLabel.TabIndex = 32
        Processed_ByLabel.Text = "Processed By:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListOfDoctorsDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(654, 86)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(522, 290)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ListOfDoctorsDataGridView
        '
        Me.ListOfDoctorsDataGridView.AutoGenerateColumns = False
        Me.ListOfDoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListOfDoctorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1})
        Me.ListOfDoctorsDataGridView.DataSource = Me.ListOfDoctorsBindingSource
        Me.ListOfDoctorsDataGridView.Location = New System.Drawing.Point(7, 30)
        Me.ListOfDoctorsDataGridView.Name = "ListOfDoctorsDataGridView"
        Me.ListOfDoctorsDataGridView.Size = New System.Drawing.Size(508, 220)
        Me.ListOfDoctorsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Doctor_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Doctor_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Doctor_No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Doctor_No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Doctor_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Doctor_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fee/Hour"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fee/Hour"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.DataGridViewImageColumn1.HeaderText = "Picture"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AppointmentDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(654, 420)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(522, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'AppointmentDataGridView
        '
        Me.AppointmentDataGridView.AutoGenerateColumns = False
        Me.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.AppointmentDataGridView.DataSource = Me.AppointmentBindingSource
        Me.AppointmentDataGridView.Location = New System.Drawing.Point(7, 34)
        Me.AppointmentDataGridView.Name = "AppointmentDataGridView"
        Me.AppointmentDataGridView.Size = New System.Drawing.Size(508, 220)
        Me.AppointmentDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Appointment_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Appointment_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cellphone_No"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cellphone_No"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Telephone_No"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Telephone_No"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Street_Address"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Street_Address"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "City/Town"
        Me.DataGridViewTextBoxColumn14.HeaderText = "City/Town"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Doctor_ID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Doctor_ID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Doctor_Name"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Doctor_Name"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Doctor_No"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Doctor_No"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Fee/Hour"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Fee/Hour"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "No_of_Hours"
        Me.DataGridViewTextBoxColumn21.HeaderText = "No_of_Hours"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Total_Due"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Total_Due"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Processed_By"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Processed_By"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "Appointment"
        Me.AppointmentBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'Appointment_DetailsBindingSource
        '
        Me.Appointment_DetailsBindingSource.DataMember = "Appointment_Details"
        Me.Appointment_DetailsBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Appointment_IDLabel)
        Me.GroupBox3.Controls.Add(Me.Appointment_IDTextBox)
        Me.GroupBox3.Controls.Add(First_NameLabel)
        Me.GroupBox3.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox3.Controls.Add(Last_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox3.Controls.Add(AgeLabel)
        Me.GroupBox3.Controls.Add(Me.AgeTextBox)
        Me.GroupBox3.Controls.Add(Cellphone_NoLabel)
        Me.GroupBox3.Controls.Add(Me.Cellphone_NoTextBox)
        Me.GroupBox3.Controls.Add(Telephone_NoLabel)
        Me.GroupBox3.Controls.Add(Me.Telephone_NoTextBox)
        Me.GroupBox3.Controls.Add(Street_AddressLabel)
        Me.GroupBox3.Controls.Add(Me.Street_AddressTextBox)
        Me.GroupBox3.Controls.Add(City_TownLabel)
        Me.GroupBox3.Controls.Add(Me.City_TownTextBox)
        Me.GroupBox3.Controls.Add(Doctor_IDLabel)
        Me.GroupBox3.Controls.Add(Me.Doctor_IDTextBox)
        Me.GroupBox3.Controls.Add(Doctor_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Doctor_NameTextBox)
        Me.GroupBox3.Controls.Add(Doctor_NoLabel)
        Me.GroupBox3.Controls.Add(Me.Doctor_NoTextBox)
        Me.GroupBox3.Controls.Add(ColorLabel)
        Me.GroupBox3.Controls.Add(Me.ColorTextBox)
        Me.GroupBox3.Controls.Add(DateLabel)
        Me.GroupBox3.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox3.Controls.Add(Fee_HourLabel)
        Me.GroupBox3.Controls.Add(Me.Fee_HourTextBox)
        Me.GroupBox3.Controls.Add(No_of_HoursLabel)
        Me.GroupBox3.Controls.Add(Me.No_of_HoursTextBox)
        Me.GroupBox3.Controls.Add(Total_DueLabel)
        Me.GroupBox3.Controls.Add(Me.Total_DueTextBox)
        Me.GroupBox3.Controls.Add(Processed_ByLabel)
        Me.GroupBox3.Controls.Add(Me.Processed_ByTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 86)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(549, 551)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Appointment_IDTextBox
        '
        Me.Appointment_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Appointment_ID", True))
        Me.Appointment_IDTextBox.Location = New System.Drawing.Point(136, 35)
        Me.Appointment_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Appointment_IDTextBox.Name = "Appointment_IDTextBox"
        Me.Appointment_IDTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Appointment_IDTextBox.TabIndex = 1
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(136, 65)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(232, 20)
        Me.First_NameTextBox.TabIndex = 3
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(136, 95)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(136, 125)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(232, 20)
        Me.AgeTextBox.TabIndex = 7
        '
        'Cellphone_NoTextBox
        '
        Me.Cellphone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Cellphone_No", True))
        Me.Cellphone_NoTextBox.Location = New System.Drawing.Point(136, 155)
        Me.Cellphone_NoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cellphone_NoTextBox.Name = "Cellphone_NoTextBox"
        Me.Cellphone_NoTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Cellphone_NoTextBox.TabIndex = 9
        '
        'Telephone_NoTextBox
        '
        Me.Telephone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Telephone_No", True))
        Me.Telephone_NoTextBox.Location = New System.Drawing.Point(136, 185)
        Me.Telephone_NoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Telephone_NoTextBox.Name = "Telephone_NoTextBox"
        Me.Telephone_NoTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Telephone_NoTextBox.TabIndex = 11
        '
        'Street_AddressTextBox
        '
        Me.Street_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Street_Address", True))
        Me.Street_AddressTextBox.Location = New System.Drawing.Point(136, 215)
        Me.Street_AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Street_AddressTextBox.Name = "Street_AddressTextBox"
        Me.Street_AddressTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Street_AddressTextBox.TabIndex = 13
        '
        'City_TownTextBox
        '
        Me.City_TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "City/Town", True))
        Me.City_TownTextBox.Location = New System.Drawing.Point(136, 245)
        Me.City_TownTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.City_TownTextBox.Name = "City_TownTextBox"
        Me.City_TownTextBox.Size = New System.Drawing.Size(232, 20)
        Me.City_TownTextBox.TabIndex = 15
        '
        'Doctor_IDTextBox
        '
        Me.Doctor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Doctor_ID", True))
        Me.Doctor_IDTextBox.Location = New System.Drawing.Point(136, 275)
        Me.Doctor_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Doctor_IDTextBox.Name = "Doctor_IDTextBox"
        Me.Doctor_IDTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Doctor_IDTextBox.TabIndex = 17
        '
        'Doctor_NameTextBox
        '
        Me.Doctor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Doctor_Name", True))
        Me.Doctor_NameTextBox.Location = New System.Drawing.Point(136, 305)
        Me.Doctor_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Doctor_NameTextBox.Name = "Doctor_NameTextBox"
        Me.Doctor_NameTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Doctor_NameTextBox.TabIndex = 19
        '
        'Doctor_NoTextBox
        '
        Me.Doctor_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Doctor_No", True))
        Me.Doctor_NoTextBox.Location = New System.Drawing.Point(136, 335)
        Me.Doctor_NoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Doctor_NoTextBox.Name = "Doctor_NoTextBox"
        Me.Doctor_NoTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Doctor_NoTextBox.TabIndex = 21
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(136, 365)
        Me.ColorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(232, 20)
        Me.ColorTextBox.TabIndex = 23
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(136, 395)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(232, 20)
        Me.DateDateTimePicker.TabIndex = 25
        '
        'Fee_HourTextBox
        '
        Me.Fee_HourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Fee/Hour", True))
        Me.Fee_HourTextBox.Location = New System.Drawing.Point(136, 425)
        Me.Fee_HourTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Fee_HourTextBox.Name = "Fee_HourTextBox"
        Me.Fee_HourTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Fee_HourTextBox.TabIndex = 27
        '
        'No_of_HoursTextBox
        '
        Me.No_of_HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "No_of_Hours", True))
        Me.No_of_HoursTextBox.Location = New System.Drawing.Point(136, 455)
        Me.No_of_HoursTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.No_of_HoursTextBox.Name = "No_of_HoursTextBox"
        Me.No_of_HoursTextBox.Size = New System.Drawing.Size(232, 20)
        Me.No_of_HoursTextBox.TabIndex = 29
        '
        'Total_DueTextBox
        '
        Me.Total_DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Total_Due", True))
        Me.Total_DueTextBox.Location = New System.Drawing.Point(136, 485)
        Me.Total_DueTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Total_DueTextBox.Name = "Total_DueTextBox"
        Me.Total_DueTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Total_DueTextBox.TabIndex = 31
        '
        'Processed_ByTextBox
        '
        Me.Processed_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Processed_By", True))
        Me.Processed_ByTextBox.Location = New System.Drawing.Point(136, 515)
        Me.Processed_ByTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Processed_ByTextBox.Name = "Processed_ByTextBox"
        Me.Processed_ByTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Processed_ByTextBox.TabIndex = 33
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Appointment_DetailsTableAdapter = Me.Appointment_DetailsTableAdapter
        Me.TableAdapterManager.AppointmentTableAdapter = Me.AppointmentTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishedTableAdapter = Nothing
        Me.TableAdapterManager.ListOfDoctorsTableAdapter = Me.ListOfDoctorsTableAdapter
        Me.TableAdapterManager.PatientLoginDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.tblDoctorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Appointment_DetailsTableAdapter
        '
        Me.Appointment_DetailsTableAdapter.ClearBeforeFill = True
        '
        'ListOfDoctorsTableAdapter
        '
        Me.ListOfDoctorsTableAdapter.ClearBeforeFill = True
        '
        'AppointmentBindingNavigator
        '
        Me.AppointmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AppointmentBindingNavigator.BindingSource = Me.AppointmentBindingSource
        Me.AppointmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AppointmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AppointmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AppointmentBindingNavigatorSaveItem})
        Me.AppointmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AppointmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AppointmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AppointmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AppointmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AppointmentBindingNavigator.Name = "AppointmentBindingNavigator"
        Me.AppointmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AppointmentBindingNavigator.Size = New System.Drawing.Size(1199, 25)
        Me.AppointmentBindingNavigator.TabIndex = 3
        Me.AppointmentBindingNavigator.Text = "BindingNavigator1"
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
        'AppointmentBindingNavigatorSaveItem
        '
        Me.AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AppointmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("AppointmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AppointmentBindingNavigatorSaveItem.Name = "AppointmentBindingNavigatorSaveItem"
        Me.AppointmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AppointmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(91, 652)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(191, 651)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(286, 651)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 43)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(396, 651)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 43)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BookAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1199, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.AppointmentBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookAppointment"
        Me.Text = "BookAppointment"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ListOfDoctorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfDoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppointmentBindingNavigator.ResumeLayout(False)
        Me.AppointmentBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents AppointmentBookingSystem1DataSet As CareHospital.AppointmentBookingSystem1DataSet
    Friend WithEvents AppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents TableAdapterManager As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AppointmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Appointment_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cellphone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents City_TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fee_HourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_of_HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_DueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Processed_ByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListOfDoctorsTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.ListOfDoctorsTableAdapter
    Friend WithEvents ListOfDoctorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfDoctorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Appointment_DetailsTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.Appointment_DetailsTableAdapter
    Friend WithEvents Appointment_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
