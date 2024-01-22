Public Class Patients

    Private Sub PatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub Patients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Patient)

    End Sub

    Private Sub PatientTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientTextBox1.TextChanged
        If PatientTextBox1.Text = "" Then
            Me.PatientTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Patient)
        Else
            Me.PatientTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Patient)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            Me.Validate()
            Me.PatientBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Return
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub
End Class