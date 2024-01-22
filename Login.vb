Imports System.Data.OleDb

Public Class Login
    Dim con As New OleDbConnection
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\project\CareHospital\CareHospital\AppointmentBookingSystem1.mdb"
    End Sub
    Public Function ask()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from Admin", con)
        da.Fill(dt)

        For Each datarow In dt.Rows

            If UsernameTextBox.Text = datarow.item(1) And PasswordTextBox.Text = datarow(2) Then
                con.Close()
                Return True
            End If
        Next

        con.Close()
        Return False

    End Function


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ask() = True Then
            Main_Form.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Public Function find()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from PatientLoginDetails", con)
        da.Fill(dt)

        For Each datarow In dt.Rows

            If txtUsername.Text = datarow.item(1) And txtPassword.Text = datarow(2) Then
                con.Close()
                Return True
            End If
        Next

        con.Close()
        Return False

    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If find() = True Then
            BookAppointment.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Public Function Recieve()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from tblDoctor", con)
        da.Fill(dt)

        For Each datarow In dt.Rows

            If TextBox1.Text = datarow.item(1) And TextBox2.Text = datarow(2) Then
                con.Close()
                Return True
            End If
        Next

        con.Close()
        Return False

    End Function

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Recieve() = True Then
            DoctorFormView.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
End Class