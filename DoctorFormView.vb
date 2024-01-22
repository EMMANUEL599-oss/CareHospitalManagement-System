Public Class DoctorFormView

    Private Sub AppointmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub DoctorFormView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment)

    End Sub
End Class