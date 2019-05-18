Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System
Imports System.Windows
Imports System.Globalization
Imports System.Collections.Generic
Imports System.Media

Public Class Form1

    Dim ActiveCovert As Integer

    Dim gears_value As Integer
    Dim G_ind As Integer
    Dim IAS_value As Integer
    Dim Altitude_value As Integer
    Dim Altitude_value_cali As Integer
    Dim Vy As Integer
    Dim AoA_value As Integer
    Dim Vario_value As Integer
    Dim Planetype As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        Try
            ntxt_stallspeed.Value = My.Settings.ntxt_stallspeed
            ntxt_Vario_value.Value = My.Settings.ntxt_Vario_value
            ntxt_gforce.Value = My.Settings.ntxt_gforce
            ntxt_neggforce.Value = My.Settings.ntxt_neggforce
            ntxt_wingoverload.Value = My.Settings.ntxt_wingoverload
            ntxt_gdowntxt.Value = My.Settings.ntxt_gdowntxt
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Sensor_timer_Tick(sender As Object, e As EventArgs) Handles sensor_timer.Tick
        Try


            If btn_status_start.Enabled = False Then
                indicators_worker.RunWorkerAsync()
                state_worker.RunWorkerAsync()
            End If

            Dim p() As Process

            p = Process.GetProcessesByName("launcher")
            If p.Count > 0 Then
                txt_GameStatus.Text = "Launcher is running?"
                txt_GameStatus.ForeColor = Color.Yellow
            Else
                txt_GameStatus.Text = "Game is not running"
                txt_GameStatus.ForeColor = Color.Red
            End If

            p = Process.GetProcessesByName("aces")
            If p.Count > 0 Then
                txt_GameStatus.Text = "Game is running"
                txt_GameStatus.ForeColor = Color.Green
            Else
                txt_GameStatus.Text = "Game is not running"
                txt_GameStatus.ForeColor = Color.Red
            End If


        Catch ex As Exception

        End Try

    End Sub


    Private Sub Btn_status_stop_Click(sender As Object, e As EventArgs) Handles btn_status_stop.Click
        btn_status_start.Enabled = True
        btn_status_stop.Enabled = False
    End Sub

    Private Sub Btn_status_start_Click(sender As Object, e As EventArgs) Handles btn_status_start.Click
        btn_status_start.Enabled = False
        btn_status_stop.Enabled = True
    End Sub


    Private Sub indicators_worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles indicators_worker.DoWork
        Try
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader

            request = DirectCast(WebRequest.Create("http://localhost:8111/indicators"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As Object = JObject.Parse(rawresp)

            Planetype = If(jResults("type") Is Nothing, "", jResults("type").ToString())

            txt_planetype.Text = If(jResults("type") Is Nothing, "Plane: Nothing Found", "Plane: " + jResults("type").ToString())

            ' data alerts

            gears_value = jResults("gears").ToString()
            G_ind = jResults("g_meter").ToString()
            Altitude_value = jResults("altitude_hour").ToString()
            Vario_value = jResults("vario").ToString





            ' Gears are down
            Try
                If cb_gearsdownalarm.CheckState = CheckState.Checked Then
                    Dim myPlayer As System.Media.SoundPlayer
                    myPlayer = New System.Media.SoundPlayer(My.Resources.GearDown)
                    If gears_value > 0 AndAlso Altitude_value > Altitude_value_cali + 100 Then
                        myPlayer.Stop()
                        myPlayer.PlaySync()
                    Else
                        myPlayer.Stop()
                    End If
                End If
                If cb_gearsdownthreshhold.CheckState = CheckState.Checked Then
                    Dim myPlayer1 As System.Media.SoundPlayer
                    myPlayer1 = New System.Media.SoundPlayer(My.Resources.WarningWarning)
                    If gears_value > 0 AndAlso Altitude_value > Altitude_value_cali + 100 AndAlso IAS_value >= ntxt_gdowntxt.Validate Then
                        myPlayer1.Stop()
                        myPlayer1.PlaySync()
                    Else
                        myPlayer1.Stop()
                    End If
                End If
            Catch ex As Exception

            End Try

            'G limit
            Try
                If cb_gforcelimit.CheckState = CheckState.Checked Then
                    Dim G1 As System.Media.SoundPlayer
                    Dim G2 As System.Media.SoundPlayer

                    G1 = New System.Media.SoundPlayer(My.Resources.OverG)
                    G2 = New System.Media.SoundPlayer(My.Resources.GOverLimit)

                    If G_ind >= ntxt_gforce.Value Then
                        If G_ind >= ntxt_gforce.Value + 3 - ntxt_gforce.Value / CDec(3) Then
                            G1.Stop()
                            G2.PlaySync()
                        Else
                            G2.Stop()
                            G1.PlaySync()
                        End If
                    End If
                End If



                If cb_negG.CheckState = CheckState.Checked Then
                    Dim G3 As System.Media.SoundPlayer
                    G3 = New System.Media.SoundPlayer(My.Resources.negG)
                    If G_ind <= ntxt_neggforce.Value Then
                        G3.Stop()
                        G3.PlaySync()
                    Else
                        G3.Stop()
                    End If
                End If
            Catch ex As Exception

            End Try

            ' stall climb angle warning
            Try



                If cb_stall_angle.CheckState = CheckState.Checked Then
                    Dim G3 As System.Media.SoundPlayer
                    G3 = New System.Media.SoundPlayer(My.Resources.stallhorn)
                    If IAS_value <= ntxt_stallspeed.Value AndAlso Altitude_value.ToString > Altitude_value_cali + 1200 AndAlso Vario_value >= ntxt_Vario_value.Value Then
                        G3.Stop()
                        G3.PlaySync()
                    Else
                        G3.Stop()
                    End If
                End If
            Catch ex As Exception

            End Try




        Catch ex As Exception

        End Try
    End Sub

    Private Sub State_worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles state_worker.DoWork
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create("http://localhost:8111/state"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)

        ' txt_planetype.Text = If(jResults("type") Is Nothing, "Plane: Nothing Found", "Plane: " + jResults("type").ToString())

        'AOS calies

        AoA_value = jResults("AoA, deg").ToString



        '' IAS

        IAS_value = jResults("IAS, km/h").ToString()
        Vy = jResults("Vy, m/s").ToString()
        Dim Vspeed As Decimal = Convert.ToDecimal(Vy)




        ' debug lable


        ''debug_lable.Text = gears_value.ToString & G_ind.ToString & Altitude_value.ToString & Altitude_value_cali.ToString & Vario_value.ToString & AoA_value.ToString & IAS_value.ToString & Vspeed.ToString & IAS_value.ToString & ntxt_wingoverload.Value.ToString & 50 & IAS_value.ToString & ntxt_stallspeed.Value.ToString & Altitude_value.ToString & Altitude_value_cali.ToString & 75 & 0 * Vspeed.ToString * (2 + Math.Pow(IAS_value / 100, 0.7)).ToString & vbNewLine & Altitude_value_cali.ToString & 200 & Altitude_value.ToString & (Altitude_value_cali + 1500).ToString & IAS_value.ToString & ntxt_stallspeed.Value.ToString & Altitude_value.ToString & (Altitude_value_cali + 1200).ToString & vbNewLine & Vario_value.ToString & ntxt_Vario_value.Value.ToString & G_ind.ToString & ntxt_neggforce.Value.ToString & G_ind.ToString & (ntxt_gforce.Value + 3 - ntxt_gforce.Value / CDec(3)).ToString & gears_value.ToString & 0 & Altitude_value.ToString & (Altitude_value_cali + 100).ToString


        Try
            If cb_wingoverload.CheckState = CheckState.Checked Then
                Dim G1 As System.Media.SoundPlayer
                G1 = New System.Media.SoundPlayer(My.Resources.MaximumSpeed)
                If IAS_value >= ntxt_wingoverload.Value Then
                    G1.Stop()
                    G1.PlaySync()
                Else
                    G1.Stop()
                End If
            End If
            If cb_stallspeed.CheckState = CheckState.Checked Then
                Dim G2 As System.Media.SoundPlayer
                G2 = New System.Media.SoundPlayer(My.Resources.MinimumSpeed)
                If IAS_value <= ntxt_stallspeed.Value AndAlso Altitude_value.ToString > Altitude_value_cali + 75 Then
                    G2.Stop()
                    G2.PlaySync()
                Else
                    G2.Stop()
                End If
            End If
        Catch ex As Exception

        End Try

        '' Ground prox warning

        Try
            If cb_groundprx.CheckState = CheckState.Checked Then
                Dim F1 As System.Media.SoundPlayer
                F1 = New System.Media.SoundPlayer(My.Resources.negG)
                If 0 - Vspeed * (2 + Math.Pow(IAS_value / 100, 0.7)) > Altitude_value_cali + 200 AndAlso Altitude_value <= Altitude_value_cali + 1500 Then
                    F1.PlaySync()
                Else
                    F1.Stop()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Btn_calibrate_Click(sender As Object, e As EventArgs) Handles btn_calibrate.Click
        Altitude_value_cali = Altitude_value
    End Sub

    Private Sub Ntxt_kmh_ValueChanged(sender As Object, e As EventArgs) Handles ntxt_kmh.ValueChanged, ntxt_kmh.KeyUp
        Try
            If ActiveCovert = 1 Then
                ntxt_mph.Value = Math.Round(ntxt_kmh.Value / 1.609, 0)
                ntxt_kt.Value = Math.Round(ntxt_kmh.Value / 1.852, 0)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Ntxt_mph_ValueChanged(sender As Object, e As EventArgs) Handles ntxt_mph.ValueChanged, ntxt_mph.KeyUp
        Try
            If ActiveCovert = 2 Then
                ntxt_kmh.Value = Math.Round(ntxt_mph.Value * 1.609, 0)
                ntxt_kt.Value = Math.Round(ntxt_mph.Value / 1.151, 0)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Ntxt_kt_ValueChanged(sender As Object, e As EventArgs) Handles ntxt_kt.ValueChanged, ntxt_kt.KeyUp
        Try
            If ActiveCovert = 3 Then
                ntxt_kmh.Value = Math.Round(ntxt_kt.Value * 1.852, 0)
                ntxt_mph.Value = Math.Round(ntxt_kt.Value * 1.151, 0)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Ntxt_kmh_MouseClick(sender As Object, e As MouseEventArgs) Handles ntxt_kmh.MouseClick, ntxt_kmh.Click, ntxt_kmh.MouseDown
        ActiveCovert = 1
    End Sub

    Private Sub Ntxt_mph_MouseClick(sender As Object, e As MouseEventArgs) Handles ntxt_mph.MouseClick, ntxt_mph.Click, ntxt_mph.MouseDown
        ActiveCovert = 2
    End Sub

    Private Sub Ntxt_kt_MouseClick(sender As Object, e As MouseEventArgs) Handles ntxt_kt.MouseClick, ntxt_kt.Click, ntxt_kt.MouseDown
        ActiveCovert = 3
    End Sub

    Private Sub Btn_vario_Click(sender As Object, e As EventArgs) Handles btn_vario.Click
        Try
            ntxt_Vario_value.Value = Math.Round(Vario_value, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cb_stallspeed_CheckedChanged(sender As Object, e As EventArgs) Handles cb_stallspeed.CheckedChanged
        If cb_stall_angle.CheckState = CheckState.Checked Then
            cb_stallspeed.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Cb_stall_angle_CheckedChanged(sender As Object, e As EventArgs) Handles cb_stall_angle.CheckedChanged
        If cb_stallspeed.CheckState = CheckState.Checked Then
            cb_stall_angle.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Menu_quicksave_Click(sender As Object, e As EventArgs) Handles menu_quicksave.Click
        My.Settings.ntxt_stallspeed = ntxt_stallspeed.Value
        My.Settings.ntxt_Vario_value = ntxt_Vario_value.Value
        My.Settings.ntxt_gforce = ntxt_gforce.Value
        My.Settings.ntxt_neggforce = ntxt_neggforce.Value
        My.Settings.ntxt_wingoverload = ntxt_wingoverload.Value
        My.Settings.ntxt_gdowntxt = ntxt_gdowntxt.Value
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub QuickLoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickLoadToolStripMenuItem.Click
        My.Settings.Reload()
        ntxt_stallspeed.Value = My.Settings.ntxt_stallspeed
        ntxt_Vario_value.Value = My.Settings.ntxt_Vario_value
        ntxt_gforce.Value = My.Settings.ntxt_gforce
        ntxt_neggforce.Value = My.Settings.ntxt_neggforce
        ntxt_wingoverload.Value = My.Settings.ntxt_wingoverload
        ntxt_gdowntxt.Value = My.Settings.ntxt_gdowntxt
    End Sub

    Private Sub Menu_saveas_Click(sender As Object, e As EventArgs) Handles menu_saveas.Click
        Try
            Dim sDialog As New SaveFileDialog With {
            .DefaultExt = ".AppSettings",
            .Filter = "Application Settings (*.AppSettings)|*AppSettings",
            .FileName = Planetype.ToString & ".AppSettings"
        }

            If sDialog.ShowDialog() = DialogResult.OK Then
                My.Settings.ntxt_stallspeed = ntxt_stallspeed.Value
                My.Settings.ntxt_Vario_value = ntxt_Vario_value.Value
                My.Settings.ntxt_gforce = ntxt_gforce.Value
                My.Settings.ntxt_neggforce = ntxt_neggforce.Value
                My.Settings.ntxt_wingoverload = ntxt_wingoverload.Value
                My.Settings.ntxt_gdowntxt = ntxt_gdowntxt.Value
                Using sWriter As New StreamWriter(sDialog.FileName)

                    For Each setting As Configuration.SettingsPropertyValue In My.Settings.PropertyValues

                        sWriter.WriteLine(setting.Name & "," & setting.PropertyValue.ToString())

                    Next

                End Using

                My.Settings.Save()
                MessageBox.Show("Settings saved", "Settings were saved.")
            End If
        Catch ex As Exception
            Dim sDialog As New SaveFileDialog With {
            .DefaultExt = ".AppSettings",
            .Filter = "Application Settings (*.AppSettings)|*AppSettings",
            .FileName = "NoName.AppSettings"
        }

                If sDialog.ShowDialog() = DialogResult.OK Then
                    My.Settings.ntxt_stallspeed = ntxt_stallspeed.Value
                    My.Settings.ntxt_Vario_value = ntxt_Vario_value.Value
                    My.Settings.ntxt_gforce = ntxt_gforce.Value
                    My.Settings.ntxt_neggforce = ntxt_neggforce.Value
                    My.Settings.ntxt_wingoverload = ntxt_wingoverload.Value
                    My.Settings.ntxt_gdowntxt = ntxt_gdowntxt.Value
                    Using sWriter As New StreamWriter(sDialog.FileName)

                        For Each setting As Configuration.SettingsPropertyValue In My.Settings.PropertyValues

                            sWriter.WriteLine(setting.Name & "," & setting.PropertyValue.ToString())

                        Next

                    End Using

                    My.Settings.Save()
                    MessageBox.Show("Settings saved", "Settings were saved.")
                End If


            End Try



    End Sub

    Private Sub LoadSettingsFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadSettingsFileToolStripMenuItem.Click
        Try
            Dim oDialog As New OpenFileDialog With {
                .Filter = "Application Settings (*.AppSettings)|*AppSettings",
                .FileName = Planetype.ToString & ".AppSettings"
            }

            If oDialog.ShowDialog() = DialogResult.OK Then

                Using sReader As New StreamReader(oDialog.FileName)

                    While sReader.Peek() > 0

                        Dim input = sReader.ReadLine()

                        ' Split comma delimited data ( SettingName,SettingValue )  
                        Dim dataSplit = input.Split(CChar(","))

                        '           Setting         Value  
                        My.Settings(dataSplit(0)) = dataSplit(1)

                    End While

                End Using


                My.Settings.Save()

                ntxt_stallspeed.Value = My.Settings.ntxt_stallspeed
                ntxt_Vario_value.Value = My.Settings.ntxt_Vario_value
                ntxt_gforce.Value = My.Settings.ntxt_gforce
                ntxt_neggforce.Value = My.Settings.ntxt_neggforce
                ntxt_wingoverload.Value = My.Settings.ntxt_wingoverload
                ntxt_gdowntxt.Value = My.Settings.ntxt_gdowntxt

                MessageBox.Show("Settings loaded", "Loaded")

            End If

        Catch ex As Exception

            Dim oDialog As New OpenFileDialog With {
                .Filter = "Application Settings (*.AppSettings)|*AppSettings",
                .FileName = "NoName.AppSettings"
            }

            If oDialog.ShowDialog() = DialogResult.OK Then

                Using sReader As New StreamReader(oDialog.FileName)

                    While sReader.Peek() > 0

                        Dim input = sReader.ReadLine()

                        ' Split comma delimited data ( SettingName,SettingValue )  
                        Dim dataSplit = input.Split(CChar(","))

                        '           Setting         Value  
                        My.Settings(dataSplit(0)) = dataSplit(1)

                    End While

                End Using


                My.Settings.Save()

                ntxt_stallspeed.Value = My.Settings.ntxt_stallspeed
                ntxt_Vario_value.Value = My.Settings.ntxt_Vario_value
                ntxt_gforce.Value = My.Settings.ntxt_gforce
                ntxt_neggforce.Value = My.Settings.ntxt_neggforce
                ntxt_wingoverload.Value = My.Settings.ntxt_wingoverload
                ntxt_gdowntxt.Value = My.Settings.ntxt_gdowntxt

                MessageBox.Show("Settings loaded", "Loaded")
            End If

        End Try



    End Sub
End Class
