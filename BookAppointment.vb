Public Class BookAppointment

    Private Sub AppointmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub BookAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment_Details' table. You can move, or remove it, as needed.
        Me.Appointment_DetailsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment_Details)
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.ListOfDoctors' table. You can move, or remove it, as needed.
        Me.ListOfDoctorsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.ListOfDoctors)
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment)

    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class