Public Class AddDoctor

    Private Sub ListOfDoctorsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfDoctorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ListOfDoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub AddDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.ListOfDoctors' table. You can move, or remove it, as needed.
        Me.ListOfDoctorsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.ListOfDoctors)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.ListOfDoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(open.FileName)
            PictureBox1.Image = New Bitmap(open.FileName)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        End If
    End Sub
End Class