Public Class AddAdmin

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub AddAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Admin)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            Me.Validate()
            Me.AdminBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)



            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class