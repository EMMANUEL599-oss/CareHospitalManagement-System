Public Class Booking

    Private Sub ListOfDoctorsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfDoctorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ListOfDoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment_Details' table. You can move, or remove it, as needed.
        Me.Appointment_DetailsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment_Details)
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.ListOfDoctors' table. You can move, or remove it, as needed.
        Me.ListOfDoctorsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.ListOfDoctors)
       
        Me.Appointment_DetailsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment_Details)
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter1.Fill(Me.AppointmentBookingSystem1DataSet.Appointment)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.ListOfDoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Fee_HourTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fee_HourTextBox.TextChanged

    End Sub
End Class