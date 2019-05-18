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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_StatusLable = New System.Windows.Forms.Label()
        Me.txt_GameStatus = New System.Windows.Forms.Label()
        Me.cb_gforcelimit = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ntxt_wingoverload = New System.Windows.Forms.NumericUpDown()
        Me.cb_wingoverload = New System.Windows.Forms.CheckBox()
        Me.ntxt_neggforce = New System.Windows.Forms.NumericUpDown()
        Me.cb_negG = New System.Windows.Forms.CheckBox()
        Me.ntxt_gforce = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_vario = New System.Windows.Forms.Button()
        Me.ntxt_Vario_value = New System.Windows.Forms.NumericUpDown()
        Me.cb_stall_angle = New System.Windows.Forms.CheckBox()
        Me.ntxt_stallspeed = New System.Windows.Forms.NumericUpDown()
        Me.cb_stallspeed = New System.Windows.Forms.CheckBox()
        Me.Gears = New System.Windows.Forms.GroupBox()
        Me.ntxt_gdowntxt = New System.Windows.Forms.NumericUpDown()
        Me.cb_gearsdownthreshhold = New System.Windows.Forms.CheckBox()
        Me.cb_gearsdownalarm = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_groundprx = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_calibrate = New System.Windows.Forms.Button()
        Me.btn_status_stop = New System.Windows.Forms.Button()
        Me.btn_status_start = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_quicksave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_saveas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_importsettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickLoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadSettingsFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_planetype = New System.Windows.Forms.Label()
        Me.sensor_timer = New System.Windows.Forms.Timer(Me.components)
        Me.indicators_worker = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.debug_lable = New System.Windows.Forms.Label()
        Me.state_worker = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ntxt_kt = New System.Windows.Forms.NumericUpDown()
        Me.txt_knots_l = New System.Windows.Forms.Label()
        Me.ntxt_mph = New System.Windows.Forms.NumericUpDown()
        Me.txt_mph_l = New System.Windows.Forms.Label()
        Me.ntxt_kmh = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ntxt_wingoverload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_neggforce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_gforce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ntxt_Vario_value, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_stallspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gears.SuspendLayout()
        CType(Me.ntxt_gdowntxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.ntxt_kt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_mph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntxt_kmh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_StatusLable
        '
        Me.txt_StatusLable.AutoSize = True
        Me.txt_StatusLable.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_StatusLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_StatusLable.Location = New System.Drawing.Point(3, 51)
        Me.txt_StatusLable.Name = "txt_StatusLable"
        Me.txt_StatusLable.Size = New System.Drawing.Size(132, 25)
        Me.txt_StatusLable.TabIndex = 0
        Me.txt_StatusLable.Text = "Game Status:"
        '
        'txt_GameStatus
        '
        Me.txt_GameStatus.AutoSize = True
        Me.txt_GameStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_GameStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_GameStatus.ForeColor = System.Drawing.Color.Red
        Me.txt_GameStatus.Location = New System.Drawing.Point(3, 76)
        Me.txt_GameStatus.Name = "txt_GameStatus"
        Me.txt_GameStatus.Size = New System.Drawing.Size(119, 25)
        Me.txt_GameStatus.TabIndex = 1
        Me.txt_GameStatus.Text = "Not Running"
        '
        'cb_gforcelimit
        '
        Me.cb_gforcelimit.AllowDrop = True
        Me.cb_gforcelimit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_gforcelimit.AutoSize = True
        Me.cb_gforcelimit.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_gforcelimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_gforcelimit.Location = New System.Drawing.Point(3, 25)
        Me.cb_gforcelimit.Name = "cb_gforcelimit"
        Me.cb_gforcelimit.Size = New System.Drawing.Size(165, 34)
        Me.cb_gforcelimit.TabIndex = 2
        Me.cb_gforcelimit.Text = "G-Force Limit"
        Me.cb_gforcelimit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.ntxt_wingoverload)
        Me.GroupBox1.Controls.Add(Me.cb_wingoverload)
        Me.GroupBox1.Controls.Add(Me.ntxt_neggforce)
        Me.GroupBox1.Controls.Add(Me.cb_negG)
        Me.GroupBox1.Controls.Add(Me.ntxt_gforce)
        Me.GroupBox1.Controls.Add(Me.cb_gforcelimit)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(201, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 227)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wings"
        '
        'ntxt_wingoverload
        '
        Me.ntxt_wingoverload.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_wingoverload.Location = New System.Drawing.Point(3, 195)
        Me.ntxt_wingoverload.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_wingoverload.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_wingoverload.Name = "ntxt_wingoverload"
        Me.ntxt_wingoverload.Size = New System.Drawing.Size(165, 29)
        Me.ntxt_wingoverload.TabIndex = 3
        Me.ntxt_wingoverload.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cb_wingoverload
        '
        Me.cb_wingoverload.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_wingoverload.AutoSize = True
        Me.cb_wingoverload.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_wingoverload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_wingoverload.Location = New System.Drawing.Point(3, 151)
        Me.cb_wingoverload.Name = "cb_wingoverload"
        Me.cb_wingoverload.Size = New System.Drawing.Size(165, 44)
        Me.cb_wingoverload.TabIndex = 2
        Me.cb_wingoverload.Text = "Wing Overload" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pre-Warning Speed"
        Me.cb_wingoverload.UseVisualStyleBackColor = True
        '
        'ntxt_neggforce
        '
        Me.ntxt_neggforce.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_neggforce.Location = New System.Drawing.Point(3, 122)
        Me.ntxt_neggforce.Maximum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.ntxt_neggforce.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.ntxt_neggforce.Name = "ntxt_neggforce"
        Me.ntxt_neggforce.Size = New System.Drawing.Size(165, 29)
        Me.ntxt_neggforce.TabIndex = 3
        Me.ntxt_neggforce.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'cb_negG
        '
        Me.cb_negG.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_negG.AutoSize = True
        Me.cb_negG.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_negG.Location = New System.Drawing.Point(3, 88)
        Me.cb_negG.Name = "cb_negG"
        Me.cb_negG.Size = New System.Drawing.Size(165, 34)
        Me.cb_negG.TabIndex = 4
        Me.cb_negG.Text = "Negative G Warning"
        Me.cb_negG.UseVisualStyleBackColor = True
        '
        'ntxt_gforce
        '
        Me.ntxt_gforce.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_gforce.Location = New System.Drawing.Point(3, 59)
        Me.ntxt_gforce.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.ntxt_gforce.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_gforce.Name = "ntxt_gforce"
        Me.ntxt_gforce.Size = New System.Drawing.Size(165, 29)
        Me.ntxt_gforce.TabIndex = 3
        Me.ntxt_gforce.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_vario)
        Me.GroupBox2.Controls.Add(Me.ntxt_Vario_value)
        Me.GroupBox2.Controls.Add(Me.cb_stall_angle)
        Me.GroupBox2.Controls.Add(Me.ntxt_stallspeed)
        Me.GroupBox2.Controls.Add(Me.cb_stallspeed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 217)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Speed"
        '
        'btn_vario
        '
        Me.btn_vario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_vario.Location = New System.Drawing.Point(3, 171)
        Me.btn_vario.Name = "btn_vario"
        Me.btn_vario.Size = New System.Drawing.Size(177, 40)
        Me.btn_vario.TabIndex = 5
        Me.btn_vario.Text = "Capture Vario°"
        Me.btn_vario.UseVisualStyleBackColor = True
        '
        'ntxt_Vario_value
        '
        Me.ntxt_Vario_value.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_Vario_value.Location = New System.Drawing.Point(3, 142)
        Me.ntxt_Vario_value.Maximum = New Decimal(New Integer() {290, 0, 0, 0})
        Me.ntxt_Vario_value.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_Vario_value.Name = "ntxt_Vario_value"
        Me.ntxt_Vario_value.Size = New System.Drawing.Size(177, 29)
        Me.ntxt_Vario_value.TabIndex = 3
        Me.ntxt_Vario_value.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'cb_stall_angle
        '
        Me.cb_stall_angle.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_stall_angle.AutoSize = True
        Me.cb_stall_angle.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_stall_angle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_stall_angle.Location = New System.Drawing.Point(3, 98)
        Me.cb_stall_angle.Name = "cb_stall_angle"
        Me.cb_stall_angle.Size = New System.Drawing.Size(177, 44)
        Me.cb_stall_angle.TabIndex = 4
        Me.cb_stall_angle.Text = "Alert when stalling at the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stalling Speed + Vario°" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cb_stall_angle.UseVisualStyleBackColor = True
        '
        'ntxt_stallspeed
        '
        Me.ntxt_stallspeed.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_stallspeed.Location = New System.Drawing.Point(3, 69)
        Me.ntxt_stallspeed.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_stallspeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_stallspeed.Name = "ntxt_stallspeed"
        Me.ntxt_stallspeed.Size = New System.Drawing.Size(177, 29)
        Me.ntxt_stallspeed.TabIndex = 3
        Me.ntxt_stallspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cb_stallspeed
        '
        Me.cb_stallspeed.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_stallspeed.AutoSize = True
        Me.cb_stallspeed.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_stallspeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_stallspeed.Location = New System.Drawing.Point(3, 25)
        Me.cb_stallspeed.Name = "cb_stallspeed"
        Me.cb_stallspeed.Size = New System.Drawing.Size(177, 44)
        Me.cb_stallspeed.TabIndex = 2
        Me.cb_stallspeed.Text = "Alert when you fall below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Stalling Speed."
        Me.cb_stallspeed.UseVisualStyleBackColor = True
        '
        'Gears
        '
        Me.Gears.Controls.Add(Me.ntxt_gdowntxt)
        Me.Gears.Controls.Add(Me.cb_gearsdownthreshhold)
        Me.Gears.Controls.Add(Me.cb_gearsdownalarm)
        Me.Gears.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gears.Location = New System.Drawing.Point(235, 82)
        Me.Gears.Name = "Gears"
        Me.Gears.Size = New System.Drawing.Size(295, 126)
        Me.Gears.TabIndex = 3
        Me.Gears.TabStop = False
        Me.Gears.Text = "Gears"
        '
        'ntxt_gdowntxt
        '
        Me.ntxt_gdowntxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_gdowntxt.Location = New System.Drawing.Point(3, 93)
        Me.ntxt_gdowntxt.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_gdowntxt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ntxt_gdowntxt.Name = "ntxt_gdowntxt"
        Me.ntxt_gdowntxt.Size = New System.Drawing.Size(289, 29)
        Me.ntxt_gdowntxt.TabIndex = 3
        Me.ntxt_gdowntxt.Value = New Decimal(New Integer() {260, 0, 0, 0})
        '
        'cb_gearsdownthreshhold
        '
        Me.cb_gearsdownthreshhold.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_gearsdownthreshhold.AutoSize = True
        Me.cb_gearsdownthreshhold.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_gearsdownthreshhold.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_gearsdownthreshhold.Location = New System.Drawing.Point(3, 59)
        Me.cb_gearsdownthreshhold.Name = "cb_gearsdownthreshhold"
        Me.cb_gearsdownthreshhold.Size = New System.Drawing.Size(289, 34)
        Me.cb_gearsdownthreshhold.TabIndex = 2
        Me.cb_gearsdownthreshhold.Text = "Gears Down Threshold Alarm"
        Me.cb_gearsdownthreshhold.UseVisualStyleBackColor = True
        '
        'cb_gearsdownalarm
        '
        Me.cb_gearsdownalarm.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_gearsdownalarm.AutoSize = True
        Me.cb_gearsdownalarm.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_gearsdownalarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cb_gearsdownalarm.Location = New System.Drawing.Point(3, 25)
        Me.cb_gearsdownalarm.Name = "cb_gearsdownalarm"
        Me.cb_gearsdownalarm.Size = New System.Drawing.Size(289, 34)
        Me.cb_gearsdownalarm.TabIndex = 2
        Me.cb_gearsdownalarm.Text = "Gears Down Alarm"
        Me.cb_gearsdownalarm.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_groundprx)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(235, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(295, 76)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sensors"
        '
        'cb_groundprx
        '
        Me.cb_groundprx.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_groundprx.AutoSize = True
        Me.cb_groundprx.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_groundprx.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_groundprx.Location = New System.Drawing.Point(3, 25)
        Me.cb_groundprx.Name = "cb_groundprx"
        Me.cb_groundprx.Size = New System.Drawing.Size(289, 44)
        Me.cb_groundprx.TabIndex = 2
        Me.cb_groundprx.Text = "Alarm when speed is greater than" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "velocity at a negtive Vario° setting."
        Me.cb_groundprx.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_calibrate)
        Me.GroupBox4.Controls.Add(Me.btn_status_stop)
        Me.GroupBox4.Controls.Add(Me.btn_status_start)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(217, 141)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status"
        '
        'btn_calibrate
        '
        Me.btn_calibrate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_calibrate.Location = New System.Drawing.Point(3, 95)
        Me.btn_calibrate.Name = "btn_calibrate"
        Me.btn_calibrate.Size = New System.Drawing.Size(211, 35)
        Me.btn_calibrate.TabIndex = 0
        Me.btn_calibrate.Text = "Calibrate"
        Me.btn_calibrate.UseVisualStyleBackColor = True
        '
        'btn_status_stop
        '
        Me.btn_status_stop.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_status_stop.Enabled = False
        Me.btn_status_stop.Location = New System.Drawing.Point(3, 60)
        Me.btn_status_stop.Name = "btn_status_stop"
        Me.btn_status_stop.Size = New System.Drawing.Size(211, 35)
        Me.btn_status_stop.TabIndex = 0
        Me.btn_status_stop.Text = "Stop"
        Me.btn_status_stop.UseVisualStyleBackColor = True
        '
        'btn_status_start
        '
        Me.btn_status_start.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_status_start.Location = New System.Drawing.Point(3, 25)
        Me.btn_status_start.Name = "btn_status_start"
        Me.btn_status_start.Size = New System.Drawing.Size(211, 35)
        Me.btn_status_start.TabIndex = 0
        Me.btn_status_start.Text = "Start"
        Me.btn_status_start.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MenuStrip1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(378, 407)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(152, 64)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Save / Import"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.menu_importsettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(146, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_quicksave, Me.menu_saveas})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'menu_quicksave
        '
        Me.menu_quicksave.Name = "menu_quicksave"
        Me.menu_quicksave.Size = New System.Drawing.Size(132, 22)
        Me.menu_quicksave.Text = "Quick Save"
        '
        'menu_saveas
        '
        Me.menu_saveas.Name = "menu_saveas"
        Me.menu_saveas.Size = New System.Drawing.Size(132, 22)
        Me.menu_saveas.Text = "Save As"
        '
        'menu_importsettings
        '
        Me.menu_importsettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuickLoadToolStripMenuItem, Me.LoadSettingsFileToolStripMenuItem})
        Me.menu_importsettings.Name = "menu_importsettings"
        Me.menu_importsettings.Size = New System.Drawing.Size(100, 20)
        Me.menu_importsettings.Text = "Import Settings"
        '
        'QuickLoadToolStripMenuItem
        '
        Me.QuickLoadToolStripMenuItem.Name = "QuickLoadToolStripMenuItem"
        Me.QuickLoadToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.QuickLoadToolStripMenuItem.Text = "Quick Load"
        '
        'LoadSettingsFileToolStripMenuItem
        '
        Me.LoadSettingsFileToolStripMenuItem.Name = "LoadSettingsFileToolStripMenuItem"
        Me.LoadSettingsFileToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LoadSettingsFileToolStripMenuItem.Text = "Load Settings File"
        '
        'txt_planetype
        '
        Me.txt_planetype.AutoSize = True
        Me.txt_planetype.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_planetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_planetype.Location = New System.Drawing.Point(3, 26)
        Me.txt_planetype.Name = "txt_planetype"
        Me.txt_planetype.Size = New System.Drawing.Size(73, 25)
        Me.txt_planetype.TabIndex = 0
        Me.txt_planetype.Text = "Plane: "
        '
        'sensor_timer
        '
        Me.sensor_timer.Enabled = True
        '
        'indicators_worker
        '
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_GameStatus)
        Me.GroupBox6.Controls.Add(Me.txt_StatusLable)
        Me.GroupBox6.Controls.Add(Me.txt_planetype)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(217, 110)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Extra Info"
        '
        'debug_lable
        '
        Me.debug_lable.AutoSize = True
        Me.debug_lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.debug_lable.Location = New System.Drawing.Point(12, 507)
        Me.debug_lable.Name = "debug_lable"
        Me.debug_lable.Size = New System.Drawing.Size(24, 20)
        Me.debug_lable.TabIndex = 1
        Me.debug_lable.Text = "---"
        Me.debug_lable.Visible = False
        '
        'state_worker
        '
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ntxt_kt)
        Me.GroupBox7.Controls.Add(Me.txt_knots_l)
        Me.GroupBox7.Controls.Add(Me.ntxt_mph)
        Me.GroupBox7.Controls.Add(Me.txt_mph_l)
        Me.GroupBox7.Controls.Add(Me.ntxt_kmh)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox7.Location = New System.Drawing.Point(378, 212)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(152, 192)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Conv. Sheet"
        '
        'ntxt_kt
        '
        Me.ntxt_kt.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_kt.Location = New System.Drawing.Point(3, 155)
        Me.ntxt_kt.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_kt.Name = "ntxt_kt"
        Me.ntxt_kt.Size = New System.Drawing.Size(146, 29)
        Me.ntxt_kt.TabIndex = 0
        '
        'txt_knots_l
        '
        Me.txt_knots_l.AutoSize = True
        Me.txt_knots_l.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_knots_l.Location = New System.Drawing.Point(3, 131)
        Me.txt_knots_l.Name = "txt_knots_l"
        Me.txt_knots_l.Size = New System.Drawing.Size(62, 24)
        Me.txt_knots_l.TabIndex = 3
        Me.txt_knots_l.Text = "Knots:"
        '
        'ntxt_mph
        '
        Me.ntxt_mph.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_mph.Location = New System.Drawing.Point(3, 102)
        Me.ntxt_mph.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_mph.Name = "ntxt_mph"
        Me.ntxt_mph.Size = New System.Drawing.Size(146, 29)
        Me.ntxt_mph.TabIndex = 0
        '
        'txt_mph_l
        '
        Me.txt_mph_l.AutoSize = True
        Me.txt_mph_l.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_mph_l.Location = New System.Drawing.Point(3, 78)
        Me.txt_mph_l.Name = "txt_mph_l"
        Me.txt_mph_l.Size = New System.Drawing.Size(57, 24)
        Me.txt_mph_l.TabIndex = 3
        Me.txt_mph_l.Text = "MPH:"
        '
        'ntxt_kmh
        '
        Me.ntxt_kmh.Dock = System.Windows.Forms.DockStyle.Top
        Me.ntxt_kmh.Location = New System.Drawing.Point(3, 49)
        Me.ntxt_kmh.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.ntxt_kmh.Name = "ntxt_kmh"
        Me.ntxt_kmh.Size = New System.Drawing.Size(146, 29)
        Me.ntxt_kmh.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(3, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "KMH:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(540, 477)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Gears)
        Me.Controls.Add(Me.debug_lable)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 520)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USAF 2017 Flight Instructor Aliza - WT VC Sounds"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ntxt_wingoverload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_neggforce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_gforce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ntxt_Vario_value, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_stallspeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gears.ResumeLayout(False)
        Me.Gears.PerformLayout()
        CType(Me.ntxt_gdowntxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.ntxt_kt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_mph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntxt_kmh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_StatusLable As Label
    Friend WithEvents txt_GameStatus As Label
    Friend WithEvents cb_gforcelimit As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_wingoverload As CheckBox
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
    Friend WithEvents ntxt_wingoverload As NumericUpDown
    Friend WithEvents ntxt_gforce As NumericUpDown
    Friend WithEvents ntxt_stallspeed As NumericUpDown
    Friend WithEvents ntxt_Vario_value As NumericUpDown
    Friend WithEvents ntxt_gdowntxt As NumericUpDown
    Friend WithEvents txt_planetype As Label
    Friend WithEvents sensor_timer As Timer
    Friend WithEvents indicators_worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents debug_lable As Label
    Friend WithEvents cb_negG As CheckBox
    Friend WithEvents ntxt_neggforce As NumericUpDown
    Friend WithEvents state_worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_calibrate As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txt_knots_l As Label
    Friend WithEvents txt_mph_l As Label
    Friend WithEvents ntxt_kmh As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents ntxt_kt As NumericUpDown
    Friend WithEvents ntxt_mph As NumericUpDown
    Friend WithEvents cb_stall_angle As CheckBox
    Friend WithEvents btn_vario As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_quicksave As ToolStripMenuItem
    Friend WithEvents menu_saveas As ToolStripMenuItem
    Friend WithEvents menu_importsettings As ToolStripMenuItem
    Friend WithEvents QuickLoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadSettingsFileToolStripMenuItem As ToolStripMenuItem
End Class
