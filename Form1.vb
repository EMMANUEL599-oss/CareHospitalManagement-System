Public Class Form1

    Private Sub Appointment_DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Appointment_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Appointment_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment_Details' table. You can move, or remove it, as needed.
        Me.Appointment_DetailsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment_Details)


        'TODO: This line of code loads data into the 'ListOfCarsDataSet.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfDoctorsTableAdapter1.Fill(Me.AppointmentBookingSystem1DataSet.ListOfDoctors)
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent_Details' table. You can move, or remove it, as needed.

        Me.AppointmentTableAdapter1.Fill(Me.AppointmentBookingSystem1DataSet.Appointment)

    End Sub

    Private Sub Fee_HourTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fee_HourTextBox.TextChanged

    End Sub
End Class
