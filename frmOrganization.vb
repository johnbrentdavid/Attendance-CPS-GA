﻿Imports MySql.Data.MySqlClient

Public Class frmOrganization
    Public stOrg As String

    Private organizations As New Dictionary(Of String, Organization)

    Private Structure Organization
        Public logo As Image
        Public stFullName As String
    End Structure

    Private Sub frmOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        organizations.Add("CE", New Organization With {.logo = Image.FromFile("..\..\..\Img\Org Logo\CE.png"),
                          .stFullName = "Philippine Institute of Civil Engineers"})
        organizations.Add("CPS", New Organization With {.logo = Image.FromFile("..\..\..\Img\Org Logo\CPS.png"),
                          .stFullName = "Computer Programming Society"})
        organizations.Add("IECEP", New Organization With {.logo = Image.FromFile("..\..\..\Img\Org Logo\IECEP.png"),
                          .stFullName = "Institute of Electronics Engineers of the Philippines"})
        organizations.Add("IIEE", New Organization With {.logo = Image.FromFile("..\..\..\Img\Org Logo\IIEE.png"),
                          .stFullName = "Institute of Integrated Electrical Engineers"})
        organizations.Add("LPIES", New Organization With {.logo = Image.FromFile("..\..\..\Img\Org Logo\LPIES.png"),
                          .stFullName = "Lyceum of the Philippines - Laguna Industrial Engineering Society"})
        organizations.Add("LYCO", New Organization With {.logo = Image.FromFile("..\..\..\Img\Org Logo\LYCO-CPE.png"),
                          .stFullName = "Lycean’s Coalition of Computer Engineers"})

        ' Place proper Logo and Org name
        picOrg.Image = organizations(stOrg).logo
        lblOrg.Text = organizations(stOrg).stFullName

        ' Re allign Title
        Dim x, y As Double
        y = (frmAttendance.Size.Height * 0.2) - (panOrg.Size.Height / 2)
        panOrg.Location = New Point(panOrg.Location.X, y)

        y = (panOrg.Size.Height / 2) - (lblOrg.Size.Height / 2)
        lblOrg.Location = New Point(lblOrg.Location.X, y)

        ' Center Datagrid Panel
        x = (frmAttendance.Size.Width / 2) - (panAttendees.Size.Width / 2)
        y = (frmAttendance.Size.Height * 0.6) - (panAttendees.Size.Height / 2)
        panAttendees.Location = New Point(x, y)

        ' Update Attendees
        refreshAttendees()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshAttendees()
    End Sub

    Private Sub refreshAttendees()
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()

            Dim stDate As String = Date.Now.ToString("yyyy-MM-dd")
            Dim command As New MySqlCommand($"select * from tblstudent where dstudentid in (select dstudentid from tblattendance where ttimein between '{stDate} 00:00:00' and '{stDate} 23:59:59' and ttimeout is null);", conn)
            Dim dataset As New DataSet
            Dim adapter As New MySqlDataAdapter With {
                .SelectCommand = command
            }
            adapter.Fill(dataset, "Attendees")

            grdAttendance.DataSource = dataset.Tables("Attendees")
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Prompt if they really want to close
        Dim result = MsgBox("Are you sure you want to exit?", vbYesNo, "Attendance")

        ' Close if yes
        If result = vbYes Then
            frmAttendance.Show()
            Me.Close()
        End If
    End Sub
End Class