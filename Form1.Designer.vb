<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txt_StatusLable = New System.Windows.Forms.Label()
        Me.txt_GameStatus = New System.Windows.Forms.Label()
        Me.cb_gforcelimit = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_negG = New System.Windows.Forms.CheckBox()
        Me.ntxt_wingoverload = New System.Windows.Forms.NumericUpDown()
        Me.ntxt_neggforce = New System.Windows.Forms.NumericUpDown()
        Me.ntxt_gforce = New System.Windows.Forms.NumericUpDown()
        Me.cb_wingoverload = New System.Windows.Forms.CheckBox()
        Me.cb_stallingangle = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ntxt_stallspeed = New System.Windows.Forms.NumericUpDown()
        Me.ntxt_stallangle = New System.Windows.Forms.NumericUpDown()
        Me.cb_stallspeed = New System.Windows.Forms.CheckBox()
        Me.Gears = New System.Windows.Forms.GroupBox()
        Me.ntxt_gdowntxt = New System.Windows.Forms.NumericUpDown()
        Me.cb_gearsdownthreshhold = New System.Windows.Forms.CheckBox()
        Me.cb_gearsdownalarm = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_groundprx = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_status_stop = New System.Windows.Forms.Button()
        Me.btn_calibrate = New System.Windows.Forms.Button()
        Me.btn_status_start = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.bt_appsave = New System.Windows.Forms.Button()
        Me.txt_planetype = New System.Windows.Forms.Label()
        Me.sensor_timer = New System.Windows.Forms.Timer(Me.components)
        Me.indicators_worker = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.debug_lable = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.state_worker = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ntxt_wingoverload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_neggforce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_gforce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ntxt_stallspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_stallangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gears.SuspendLayout()
        CType(Me.ntxt_gdowntxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_StatusLable
        '
        Me.txt_StatusLable.AutoSize = True
        Me.txt_StatusLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_StatusLable.Location = New System.Drawing.Point(12, 9)
        Me.txt_StatusLable.Name = "txt_StatusLable"
        Me.txt_StatusLable.Size = New System.Drawing.Size(132, 25)
        Me.txt_StatusLable.TabIndex = 0
        Me.txt_StatusLable.Text = "Game Status:"
        '
        'txt_GameStatus
        '
        Me.txt_GameStatus.AutoSize = True
        Me.txt_GameStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_GameStatus.ForeColor = System.Drawing.Color.Red
        Me.txt_GameStatus.Location = New System.Drawing.Point(136, 9)
        Me.txt_GameStatus.Name = "txt_GameStatus"
        Me.txt_GameStatus.Size = New System.Drawing.Size(119, 25)
        Me.txt_GameStatus.TabIndex = 1
        Me.txt_GameStatus.Text = "Not Running"
        '
        'cb_gforcelimit
        '
        Me.cb_gforcelimit.AllowDrop = True
        Me.cb_gforcelimit.AutoSize = True
        Me.cb_gforcelimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_gforcelimit.Location = New System.Drawing.Point(6, 28)
        Me.cb_gforcelimit.Name = "cb_gforcelimit"
        Me.cb_gforcelimit.Size = New System.Drawing.Size(142, 28)
        Me.cb_gforcelimit.TabIndex = 2
        Me.cb_gforcelimit.Text = "G-Force Limit"
        Me.cb_gforcelimit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_negG)
        Me.GroupBox1.Controls.Add(Me.ntxt_wingoverload)
        Me.GroupBox1.Controls.Add(Me.ntxt_neggforce)
        Me.GroupBox1.Controls.Add(Me.ntxt_gforce)
        Me.GroupBox1.Controls.Add(Me.cb_gforcelimit)
        Me.GroupBox1.Controls.Add(Me.cb_wingoverload)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 235)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wings"
        '
        'cb_negG
        '
        Me.cb_negG.AutoSize = True
        Me.cb_negG.Location = New System.Drawing.Point(6, 62)
        Me.cb_negG.Name = "cb_negG"
        Me.cb_negG.Size = New System.Drawing.Size(198, 28)
        Me.cb_negG.TabIndex = 4
        Me.cb_negG.Text = "Negative G Warning"
        Me.cb_negG.UseVisualStyleBackColor = True
        '
        'ntxt_wingoverload
        '
        Me.ntxt_wingoverload.Location = New System.Drawing.Point(5, 165)
        Me.ntxt_wingoverload.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_wingoverload.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_wingoverload.Name = "ntxt_wingoverload"
        Me.ntxt_wingoverload.Size = New System.Drawing.Size(78, 29)
        Me.ntxt_wingoverload.TabIndex = 3
        Me.ntxt_wingoverload.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'ntxt_neggforce
        '
        Me.ntxt_neggforce.Location = New System.Drawing.Point(5, 96)
        Me.ntxt_neggforce.Maximum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.ntxt_neggforce.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.ntxt_neggforce.Name = "ntxt_neggforce"
        Me.ntxt_neggforce.Size = New System.Drawing.Size(78, 29)
        Me.ntxt_neggforce.TabIndex = 3
        Me.ntxt_neggforce.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'ntxt_gforce
        '
        Me.ntxt_gforce.Location = New System.Drawing.Point(144, 27)
        Me.ntxt_gforce.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.ntxt_gforce.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_gforce.Name = "ntxt_gforce"
        Me.ntxt_gforce.Size = New System.Drawing.Size(78, 29)
        Me.ntxt_gforce.TabIndex = 3
        Me.ntxt_gforce.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cb_wingoverload
        '
        Me.cb_wingoverload.AutoSize = True
        Me.cb_wingoverload.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_wingoverload.Location = New System.Drawing.Point(6, 131)
        Me.cb_wingoverload.Name = "cb_wingoverload"
        Me.cb_wingoverload.Size = New System.Drawing.Size(216, 28)
        Me.cb_wingoverload.TabIndex = 2
        Me.cb_wingoverload.Text = "Wing Overload Speed"
        Me.cb_wingoverload.UseVisualStyleBackColor = True
        '
        'cb_stallingangle
        '
        Me.cb_stallingangle.AutoSize = True
        Me.cb_stallingangle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_stallingangle.Location = New System.Drawing.Point(6, 28)
        Me.cb_stallingangle.Name = "cb_stallingangle"
        Me.cb_stallingangle.Size = New System.Drawing.Size(144, 28)
        Me.cb_stallingangle.TabIndex = 2
        Me.cb_stallingangle.Text = "Stalling Angle"
        Me.cb_stallingangle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ntxt_stallspeed)
        Me.GroupBox2.Controls.Add(Me.ntxt_stallangle)
        Me.GroupBox2.Controls.Add(Me.cb_stallspeed)
        Me.GroupBox2.Controls.Add(Me.cb_stallingangle)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 120)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Speed"
        '
        'ntxt_stallspeed
        '
        Me.ntxt_stallspeed.Location = New System.Drawing.Point(154, 71)
        Me.ntxt_stallspeed.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_stallspeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_stallspeed.Name = "ntxt_stallspeed"
        Me.ntxt_stallspeed.Size = New System.Drawing.Size(78, 29)
        Me.ntxt_stallspeed.TabIndex = 3
        Me.ntxt_stallspeed.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'ntxt_stallangle
        '
        Me.ntxt_stallangle.Location = New System.Drawing.Point(156, 27)
        Me.ntxt_stallangle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.ntxt_stallangle.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_stallangle.Name = "ntxt_stallangle"
        Me.ntxt_stallangle.Size = New System.Drawing.Size(64, 29)
        Me.ntxt_stallangle.TabIndex = 3
        Me.ntxt_stallangle.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'cb_stallspeed
        '
        Me.cb_stallspeed.AutoSize = True
        Me.cb_stallspeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_stallspeed.Location = New System.Drawing.Point(6, 72)
        Me.cb_stallspeed.Name = "cb_stallspeed"
        Me.cb_stallspeed.Size = New System.Drawing.Size(150, 28)
        Me.cb_stallspeed.TabIndex = 2
        Me.cb_stallspeed.Text = "Stalling Speed"
        Me.cb_stallspeed.UseVisualStyleBackColor = True
        '
        'Gears
        '
        Me.Gears.Controls.Add(Me.ntxt_gdowntxt)
        Me.Gears.Controls.Add(Me.cb_gearsdownthreshhold)
        Me.Gears.Controls.Add(Me.cb_gearsdownalarm)
        Me.Gears.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gears.Location = New System.Drawing.Point(261, 37)
        Me.Gears.Name = "Gears"
        Me.Gears.Size = New System.Drawing.Size(298, 134)
        Me.Gears.TabIndex = 3
        Me.Gears.TabStop = False
        Me.Gears.Text = "Gears"
        '
        'ntxt_gdowntxt
        '
        Me.ntxt_gdowntxt.Location = New System.Drawing.Point(6, 96)
        Me.ntxt_gdowntxt.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_gdowntxt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_gdowntxt.Name = "ntxt_gdowntxt"
        Me.ntxt_gdowntxt.Size = New System.Drawing.Size(78, 29)
        Me.ntxt_gdowntxt.TabIndex = 3
        Me.ntxt_gdowntxt.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'cb_gearsdownthreshhold
        '
        Me.cb_gearsdownthreshhold.AutoSize = True
        Me.cb_gearsdownthreshhold.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_gearsdownthreshhold.Location = New System.Drawing.Point(6, 62)
        Me.cb_gearsdownthreshhold.Name = "cb_gearsdownthreshhold"
        Me.cb_gearsdownthreshhold.Size = New System.Drawing.Size(278, 28)
        Me.cb_gearsdownthreshhold.TabIndex = 2
        Me.cb_gearsdownthreshhold.Text = "Gears Down Threshold Alarm"
        Me.cb_gearsdownthreshhold.UseVisualStyleBackColor = True
        '
        'cb_gearsdownalarm
        '
        Me.cb_gearsdownalarm.AutoSize = True
        Me.cb_gearsdownalarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_gearsdownalarm.Location = New System.Drawing.Point(6, 28)
        Me.cb_gearsdownalarm.Name = "cb_gearsdownalarm"
        Me.cb_gearsdownalarm.Size = New System.Drawing.Size(187, 28)
        Me.cb_gearsdownalarm.TabIndex = 2
        Me.cb_gearsdownalarm.Text = "Gears Down Alarm"
        Me.cb_gearsdownalarm.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_groundprx)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(261, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 67)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sensors"
        '
        'cb_groundprx
        '
        Me.cb_groundprx.AutoSize = True
        Me.cb_groundprx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_groundprx.Location = New System.Drawing.Point(6, 28)
        Me.cb_groundprx.Name = "cb_groundprx"
        Me.cb_groundprx.Size = New System.Drawing.Size(250, 28)
        Me.cb_groundprx.TabIndex = 2
        Me.cb_groundprx.Text = "Ground Proximity Warning"
        Me.cb_groundprx.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_status_stop)
        Me.GroupBox4.Controls.Add(Me.btn_calibrate)
        Me.GroupBox4.Controls.Add(Me.btn_status_start)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(261, 250)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 128)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status"
        '
        'btn_status_stop
        '
        Me.btn_status_stop.Enabled = False
        Me.btn_status_stop.Location = New System.Drawing.Point(93, 28)
        Me.btn_status_stop.Name = "btn_status_stop"
        Me.btn_status_stop.Size = New System.Drawing.Size(75, 35)
        Me.btn_status_stop.TabIndex = 0
        Me.btn_status_stop.Text = "Stop"
        Me.btn_status_stop.UseVisualStyleBackColor = True
        '
        'btn_calibrate
        '
        Me.btn_calibrate.Location = New System.Drawing.Point(6, 87)
        Me.btn_calibrate.Name = "btn_calibrate"
        Me.btn_calibrate.Size = New System.Drawing.Size(162, 35)
        Me.btn_calibrate.TabIndex = 0
        Me.btn_calibrate.Text = "Calibrate"
        Me.btn_calibrate.UseVisualStyleBackColor = True
        '
        'btn_status_start
        '
        Me.btn_status_start.Location = New System.Drawing.Point(6, 28)
        Me.btn_status_start.Name = "btn_status_start"
        Me.btn_status_start.Size = New System.Drawing.Size(75, 35)
        Me.btn_status_start.TabIndex = 0
        Me.btn_status_start.Text = "Start"
        Me.btn_status_start.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.bt_appsave)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(441, 250)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(89, 76)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Save"
        '
        'bt_appsave
        '
        Me.bt_appsave.Location = New System.Drawing.Point(6, 28)
        Me.bt_appsave.Name = "bt_appsave"
        Me.bt_appsave.Size = New System.Drawing.Size(75, 35)
        Me.bt_appsave.TabIndex = 0
        Me.bt_appsave.Text = "Save"
        Me.bt_appsave.UseVisualStyleBackColor = True
        '
        'txt_planetype
        '
        Me.txt_planetype.AutoSize = True
        Me.txt_planetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_planetype.Location = New System.Drawing.Point(6, 26)
        Me.txt_planetype.Name = "txt_planetype"
        Me.txt_planetype.Size = New System.Drawing.Size(73, 25)
        Me.txt_planetype.TabIndex = 0
        Me.txt_planetype.Text = "Plane: "
        '
        'sensor_timer
        '
        Me.sensor_timer.Enabled = True
        Me.sensor_timer.Interval = 10
        '
        'indicators_worker
        '
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.debug_lable)
        Me.GroupBox6.Controls.Add(Me.txt_planetype)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(542, 100)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Extra Info"
        '
        'debug_lable
        '
        Me.debug_lable.AutoSize = True
        Me.debug_lable.Location = New System.Drawing.Point(6, 61)
        Me.debug_lable.Name = "debug_lable"
        Me.debug_lable.Size = New System.Drawing.Size(33, 25)
        Me.debug_lable.TabIndex = 1
        Me.debug_lable.Text = "---"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"kmh", "mph", "kt"})
        Me.ComboBox1.Location = New System.Drawing.Point(498, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(61, 28)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "kmh"
        Me.ComboBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(404, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Unit Type:"
        Me.Label1.Visible = False
        '
        'state_worker
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 515)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Gears)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_GameStatus)
        Me.Controls.Add(Me.txt_StatusLable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "USAF 2017 Flight Instructor Aliza - WT VC Sounds"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ntxt_wingoverload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_neggforce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_gforce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ntxt_stallspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_stallangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gears.ResumeLayout(False)
        Me.Gears.PerformLayout()
        CType(Me.ntxt_gdowntxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_StatusLable As Label
    Friend WithEvents txt_GameStatus As Label
    Friend WithEvents cb_gforcelimit As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_wingoverload As CheckBox
    Friend WithEvents cb_stallingangle As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_stallspeed As CheckBox
    Friend WithEvents Gears As GroupBox
    Friend WithEvents cb_gearsdownthreshhold As CheckBox
    Friend WithEvents cb_gearsdownalarm As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cb_groundprx As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_status_stop As Button
    Friend WithEvents btn_status_start As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents bt_appsave As Button
    Friend WithEvents ntxt_wingoverload As NumericUpDown
    Friend WithEvents ntxt_gforce As NumericUpDown
    Friend WithEvents ntxt_stallspeed As NumericUpDown
    Friend WithEvents ntxt_stallangle As NumericUpDown
    Friend WithEvents ntxt_gdowntxt As NumericUpDown
    Friend WithEvents txt_planetype As Label
    Friend WithEvents sensor_timer As Timer
    Friend WithEvents indicators_worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents debug_lable As Label
    Friend WithEvents cb_negG As CheckBox
    Friend WithEvents ntxt_neggforce As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents state_worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_calibrate As Button
End Class
