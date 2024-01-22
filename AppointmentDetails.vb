Public Class AppointmentDetails

    Private Sub Appointment_DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Appointment_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Appointment_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub AppointmentDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment)
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment_Details' table. You can move, or remove it, as needed.
        Me.Appointment_DetailsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment_Details)

    End Sub
End Class