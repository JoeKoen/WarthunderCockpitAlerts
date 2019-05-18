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

    Dim gears_value As Integer
    Dim G_ind As Integer
    Dim IAS_value As Integer
    Dim Altitude_value As Integer
    Dim Altitude_value_cali As Integer


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

            txt_planetype.Text = If(jResults("type") Is Nothing, "Plane: Nothing Found", "Plane: " + jResults("type").ToString())

            ' data alerts

            gears_value = jResults("gears").ToString()
            G_ind = jResults("g_meter").ToString()
            Altitude_value = jResults("altitude_hour").ToString()



            ' Gears are down
            Try
                If cb_gearsdownalarm.CheckState = CheckState.Checked Then
                    Dim myPlayer As System.Media.SoundPlayer
                    myPlayer = New System.Media.SoundPlayer(My.Resources.GearDown)
                    If gears_value >= 0 AndAlso Altitude_value >= Altitude_value_cali + 100 Then
                        myPlayer.Stop()
                        myPlayer.PlaySync()
                    Else
                        myPlayer.Stop()
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

        '' IAS

        IAS_value = jResults("IAS, km/h").ToString()
        ' debug lable
        debug_lable.Text = IAS_value

        Try
            If cb_wingoverload.CheckState = CheckState.Checked Then
                Dim G1 As System.Media.SoundPlayer
                G1 = New System.Media.SoundPlayer(My.Resources.MaximumSpeed)
                If IAS_value >= ntxt_wingoverload.Value - 50 Then
                    G1.Stop()
                    G1.PlaySync()
                Else
                    G1.Stop()
                End If
            End If
            If cb_stallspeed.CheckState = CheckState.Checked Then
                Dim G2 As System.Media.SoundPlayer
                G2 = New System.Media.SoundPlayer(My.Resources.MinimumSpeed)
                If IAS_value <= ntxt_stallspeed.Value AndAlso Altitude_value.ToString > Altitude_value_cali.ToString + 100 Then
                    G2.Stop()
                    G2.PlaySync()
                Else
                    G2.Stop()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Btn_calibrate_Click(sender As Object, e As EventArgs) Handles btn_calibrate.Click
        Altitude_value_cali = Altitude_value
    End Sub
End Class
