namespace TPJPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_openFile = new System.Windows.Forms.Button();
            this.groupBox_Echo = new System.Windows.Forms.GroupBox();
            this.echo_enabled_check = new System.Windows.Forms.CheckBox();
            this.echo_label_length = new System.Windows.Forms.Label();
            this.echo_trackbar_length = new System.Windows.Forms.TrackBar();
            this.label_echo_factor = new System.Windows.Forms.Label();
            this.Echo_trackbar_factor = new System.Windows.Forms.TrackBar();
            this.box_panning = new System.Windows.Forms.GroupBox();
            this.panning_enabled_check = new System.Windows.Forms.CheckBox();
            this.panning_label = new System.Windows.Forms.Label();
            this.panning_trackbar = new System.Windows.Forms.TrackBar();
            this.box_modulation = new System.Windows.Forms.GroupBox();
            this.modulation_enabled_check = new System.Windows.Forms.CheckBox();
            this.modulation_label = new System.Windows.Forms.Label();
            this.modulation_trackbar = new System.Windows.Forms.TrackBar();
            this.ce2_box = new System.Windows.Forms.GroupBox();
            this.ce2_label = new System.Windows.Forms.Label();
            this.ce2_trackbar = new System.Windows.Forms.TrackBar();
            this.ce2_check_enabled = new System.Windows.Forms.CheckBox();
            this.display_label_current = new System.Windows.Forms.Label();
            this.display_bar = new System.Windows.Forms.HScrollBar();
            this.display_time_now = new System.Windows.Forms.Label();
            this.display_time_sum = new System.Windows.Forms.Label();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.progress_timer = new System.Windows.Forms.Timer(this.components);
            this.eBox1 = new System.Windows.Forms.GroupBox();
            this.bar_band1 = new System.Windows.Forms.TrackBar();
            this.bar_band2 = new System.Windows.Forms.TrackBar();
            this.bar_band3 = new System.Windows.Forms.TrackBar();
            this.bar_band4 = new System.Windows.Forms.TrackBar();
            this.bar_band5 = new System.Windows.Forms.TrackBar();
            this.bar_band6 = new System.Windows.Forms.TrackBar();
            this.bar_band7 = new System.Windows.Forms.TrackBar();
            this.bar_band8 = new System.Windows.Forms.TrackBar();
            this.l_band1 = new System.Windows.Forms.Label();
            this.l_band2 = new System.Windows.Forms.Label();
            this.l_band3 = new System.Windows.Forms.Label();
            this.l_band4 = new System.Windows.Forms.Label();
            this.l_band5 = new System.Windows.Forms.Label();
            this.l_band6 = new System.Windows.Forms.Label();
            this.l_band7 = new System.Windows.Forms.Label();
            this.l_band8 = new System.Windows.Forms.Label();
            this.groupBox_Echo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.echo_trackbar_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Echo_trackbar_factor)).BeginInit();
            this.box_panning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panning_trackbar)).BeginInit();
            this.box_modulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulation_trackbar)).BeginInit();
            this.ce2_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ce2_trackbar)).BeginInit();
            this.eBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band8)).BeginInit();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Enabled = false;
            this.button_play.Location = new System.Drawing.Point(12, 262);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 1;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(93, 262);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(174, 262);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(75, 23);
            this.button_openFile.TabIndex = 3;
            this.button_openFile.Text = "Open File";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // groupBox_Echo
            // 
            this.groupBox_Echo.Controls.Add(this.echo_enabled_check);
            this.groupBox_Echo.Controls.Add(this.echo_label_length);
            this.groupBox_Echo.Controls.Add(this.echo_trackbar_length);
            this.groupBox_Echo.Controls.Add(this.label_echo_factor);
            this.groupBox_Echo.Controls.Add(this.Echo_trackbar_factor);
            this.groupBox_Echo.Enabled = false;
            this.groupBox_Echo.Location = new System.Drawing.Point(261, 12);
            this.groupBox_Echo.Name = "groupBox_Echo";
            this.groupBox_Echo.Size = new System.Drawing.Size(137, 226);
            this.groupBox_Echo.TabIndex = 5;
            this.groupBox_Echo.TabStop = false;
            this.groupBox_Echo.Text = "Echo";
            // 
            // echo_enabled_check
            // 
            this.echo_enabled_check.AutoSize = true;
            this.echo_enabled_check.Checked = true;
            this.echo_enabled_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.echo_enabled_check.Location = new System.Drawing.Point(63, 9);
            this.echo_enabled_check.Name = "echo_enabled_check";
            this.echo_enabled_check.Size = new System.Drawing.Size(65, 17);
            this.echo_enabled_check.TabIndex = 4;
            this.echo_enabled_check.Text = "Enabled";
            this.echo_enabled_check.UseVisualStyleBackColor = true;
            this.echo_enabled_check.CheckedChanged += new System.EventHandler(this.echo_enabled_check_CheckedChanged);
            // 
            // echo_label_length
            // 
            this.echo_label_length.AutoSize = true;
            this.echo_label_length.Location = new System.Drawing.Point(70, 210);
            this.echo_label_length.Name = "echo_label_length";
            this.echo_label_length.Size = new System.Drawing.Size(58, 13);
            this.echo_label_length.TabIndex = 4;
            this.echo_label_length.Text = "Length: 10";
            // 
            // echo_trackbar_length
            // 
            this.echo_trackbar_length.Location = new System.Drawing.Point(73, 32);
            this.echo_trackbar_length.Maximum = 30;
            this.echo_trackbar_length.Name = "echo_trackbar_length";
            this.echo_trackbar_length.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.echo_trackbar_length.Size = new System.Drawing.Size(45, 175);
            this.echo_trackbar_length.TabIndex = 3;
            this.echo_trackbar_length.Scroll += new System.EventHandler(this.echo_trackbar_length_Scroll);
            // 
            // label_echo_factor
            // 
            this.label_echo_factor.AutoSize = true;
            this.label_echo_factor.Location = new System.Drawing.Point(6, 210);
            this.label_echo_factor.Name = "label_echo_factor";
            this.label_echo_factor.Size = new System.Drawing.Size(61, 13);
            this.label_echo_factor.TabIndex = 2;
            this.label_echo_factor.Text = "Factor:  1.0";
            // 
            // Echo_trackbar_factor
            // 
            this.Echo_trackbar_factor.Location = new System.Drawing.Point(9, 32);
            this.Echo_trackbar_factor.Maximum = 30;
            this.Echo_trackbar_factor.Name = "Echo_trackbar_factor";
            this.Echo_trackbar_factor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Echo_trackbar_factor.Size = new System.Drawing.Size(45, 175);
            this.Echo_trackbar_factor.TabIndex = 1;
            this.Echo_trackbar_factor.Scroll += new System.EventHandler(this.Echo_trackbar_factor_Scroll);
            // 
            // box_panning
            // 
            this.box_panning.Controls.Add(this.panning_enabled_check);
            this.box_panning.Controls.Add(this.panning_label);
            this.box_panning.Controls.Add(this.panning_trackbar);
            this.box_panning.Enabled = false;
            this.box_panning.Location = new System.Drawing.Point(404, 12);
            this.box_panning.Name = "box_panning";
            this.box_panning.Size = new System.Drawing.Size(137, 109);
            this.box_panning.TabIndex = 6;
            this.box_panning.TabStop = false;
            this.box_panning.Text = "Panning";
            // 
            // panning_enabled_check
            // 
            this.panning_enabled_check.AutoSize = true;
            this.panning_enabled_check.Checked = true;
            this.panning_enabled_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.panning_enabled_check.Location = new System.Drawing.Point(57, 9);
            this.panning_enabled_check.Name = "panning_enabled_check";
            this.panning_enabled_check.Size = new System.Drawing.Size(65, 17);
            this.panning_enabled_check.TabIndex = 3;
            this.panning_enabled_check.Text = "Enabled";
            this.panning_enabled_check.UseVisualStyleBackColor = true;
            this.panning_enabled_check.CheckedChanged += new System.EventHandler(this.panning_enabled_check_CheckedChanged);
            // 
            // panning_label
            // 
            this.panning_label.AutoSize = true;
            this.panning_label.Location = new System.Drawing.Point(32, 80);
            this.panning_label.Name = "panning_label";
            this.panning_label.Size = new System.Drawing.Size(53, 13);
            this.panning_label.TabIndex = 2;
            this.panning_label.Text = "Middle : 0";
            // 
            // panning_trackbar
            // 
            this.panning_trackbar.Location = new System.Drawing.Point(6, 32);
            this.panning_trackbar.Minimum = -10;
            this.panning_trackbar.Name = "panning_trackbar";
            this.panning_trackbar.Size = new System.Drawing.Size(119, 45);
            this.panning_trackbar.TabIndex = 1;
            this.panning_trackbar.Scroll += new System.EventHandler(this.panning_trackbar_Scroll);
            // 
            // box_modulation
            // 
            this.box_modulation.Controls.Add(this.modulation_enabled_check);
            this.box_modulation.Controls.Add(this.modulation_label);
            this.box_modulation.Controls.Add(this.modulation_trackbar);
            this.box_modulation.Enabled = false;
            this.box_modulation.Location = new System.Drawing.Point(404, 129);
            this.box_modulation.Name = "box_modulation";
            this.box_modulation.Size = new System.Drawing.Size(137, 109);
            this.box_modulation.TabIndex = 7;
            this.box_modulation.TabStop = false;
            this.box_modulation.Text = "Distorsion";
            // 
            // modulation_enabled_check
            // 
            this.modulation_enabled_check.AutoSize = true;
            this.modulation_enabled_check.Checked = true;
            this.modulation_enabled_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modulation_enabled_check.Location = new System.Drawing.Point(66, 22);
            this.modulation_enabled_check.Name = "modulation_enabled_check";
            this.modulation_enabled_check.Size = new System.Drawing.Size(65, 17);
            this.modulation_enabled_check.TabIndex = 3;
            this.modulation_enabled_check.Text = "Enabled";
            this.modulation_enabled_check.UseVisualStyleBackColor = true;
            this.modulation_enabled_check.CheckedChanged += new System.EventHandler(this.modulation_enabled_check_CheckedChanged);
            // 
            // modulation_label
            // 
            this.modulation_label.AutoSize = true;
            this.modulation_label.Location = new System.Drawing.Point(54, 93);
            this.modulation_label.Name = "modulation_label";
            this.modulation_label.Size = new System.Drawing.Size(25, 13);
            this.modulation_label.TabIndex = 2;
            this.modulation_label.Text = "a: 0";
            // 
            // modulation_trackbar
            // 
            this.modulation_trackbar.Location = new System.Drawing.Point(6, 45);
            this.modulation_trackbar.Name = "modulation_trackbar";
            this.modulation_trackbar.Size = new System.Drawing.Size(119, 45);
            this.modulation_trackbar.TabIndex = 1;
            this.modulation_trackbar.Scroll += new System.EventHandler(this.modulation_trackbar_Scroll);
            // 
            // ce2_box
            // 
            this.ce2_box.Controls.Add(this.ce2_label);
            this.ce2_box.Controls.Add(this.ce2_trackbar);
            this.ce2_box.Controls.Add(this.ce2_check_enabled);
            this.ce2_box.Enabled = false;
            this.ce2_box.Location = new System.Drawing.Point(547, 12);
            this.ce2_box.Name = "ce2_box";
            this.ce2_box.Size = new System.Drawing.Size(127, 109);
            this.ce2_box.TabIndex = 9;
            this.ce2_box.TabStop = false;
            this.ce2_box.Text = "Kompresija";
            // 
            // ce2_label
            // 
            this.ce2_label.AutoSize = true;
            this.ce2_label.Location = new System.Drawing.Point(34, 90);
            this.ce2_label.Name = "ce2_label";
            this.ce2_label.Size = new System.Drawing.Size(58, 13);
            this.ce2_label.TabIndex = 6;
            this.ce2_label.Text = "Intensity: 0";
            // 
            // ce2_trackbar
            // 
            this.ce2_trackbar.Location = new System.Drawing.Point(6, 42);
            this.ce2_trackbar.Minimum = 2;
            this.ce2_trackbar.Name = "ce2_trackbar";
            this.ce2_trackbar.Size = new System.Drawing.Size(119, 45);
            this.ce2_trackbar.TabIndex = 5;
            this.ce2_trackbar.Value = 2;
            this.ce2_trackbar.Scroll += new System.EventHandler(this.ce2_trackbar_Scroll);
            // 
            // ce2_check_enabled
            // 
            this.ce2_check_enabled.AutoSize = true;
            this.ce2_check_enabled.Checked = true;
            this.ce2_check_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ce2_check_enabled.Location = new System.Drawing.Point(56, 19);
            this.ce2_check_enabled.Name = "ce2_check_enabled";
            this.ce2_check_enabled.Size = new System.Drawing.Size(65, 17);
            this.ce2_check_enabled.TabIndex = 4;
            this.ce2_check_enabled.Text = "Enabled";
            this.ce2_check_enabled.UseVisualStyleBackColor = true;
            this.ce2_check_enabled.CheckedChanged += new System.EventHandler(this.ce2_check_enabled_CheckedChanged);
            // 
            // display_label_current
            // 
            this.display_label_current.AutoSize = true;
            this.display_label_current.Location = new System.Drawing.Point(12, 166);
            this.display_label_current.Name = "display_label_current";
            this.display_label_current.Size = new System.Drawing.Size(47, 13);
            this.display_label_current.TabIndex = 9;
            this.display_label_current.Text = "Current: ";
            // 
            // display_bar
            // 
            this.display_bar.Location = new System.Drawing.Point(12, 210);
            this.display_bar.Name = "display_bar";
            this.display_bar.Size = new System.Drawing.Size(246, 28);
            this.display_bar.TabIndex = 12;
            this.display_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.display_bar_Scroll);
            this.display_bar.MouseCaptureChanged += new System.EventHandler(this.display_bar_MouseCaptureChanged);
            // 
            // display_time_now
            // 
            this.display_time_now.AutoSize = true;
            this.display_time_now.Location = new System.Drawing.Point(12, 186);
            this.display_time_now.Name = "display_time_now";
            this.display_time_now.Size = new System.Drawing.Size(29, 13);
            this.display_time_now.TabIndex = 13;
            this.display_time_now.Text = "Now";
            // 
            // display_time_sum
            // 
            this.display_time_sum.AutoSize = true;
            this.display_time_sum.Location = new System.Drawing.Point(171, 186);
            this.display_time_sum.Name = "display_time_sum";
            this.display_time_sum.Size = new System.Drawing.Size(47, 13);
            this.display_time_sum.TabIndex = 14;
            this.display_time_sum.Text = "Duration";
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Location = new System.Drawing.Point(294, 262);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(83, 17);
            this.radio_1.TabIndex = 15;
            this.radio_1.Text = "Repeat One";
            this.radio_1.UseVisualStyleBackColor = true;
            // 
            // radio_2
            // 
            this.radio_2.AutoSize = true;
            this.radio_2.Location = new System.Drawing.Point(385, 262);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(74, 17);
            this.radio_2.TabIndex = 16;
            this.radio_2.Text = "Repeat All";
            this.radio_2.UseVisualStyleBackColor = true;
            // 
            // radio_3
            // 
            this.radio_3.AutoSize = true;
            this.radio_3.Checked = true;
            this.radio_3.Location = new System.Drawing.Point(476, 262);
            this.radio_3.Name = "radio_3";
            this.radio_3.Size = new System.Drawing.Size(77, 17);
            this.radio_3.TabIndex = 17;
            this.radio_3.TabStop = true;
            this.radio_3.Text = "No Repeat";
            this.radio_3.UseVisualStyleBackColor = true;
            // 
            // progress_timer
            // 
            this.progress_timer.Enabled = true;
            this.progress_timer.Interval = 200;
            this.progress_timer.Tick += new System.EventHandler(this.progress_timer_Tick);
            // 
            // eBox1
            // 
            this.eBox1.Controls.Add(this.l_band8);
            this.eBox1.Controls.Add(this.l_band7);
            this.eBox1.Controls.Add(this.l_band6);
            this.eBox1.Controls.Add(this.l_band5);
            this.eBox1.Controls.Add(this.l_band4);
            this.eBox1.Controls.Add(this.l_band3);
            this.eBox1.Controls.Add(this.l_band2);
            this.eBox1.Controls.Add(this.l_band1);
            this.eBox1.Controls.Add(this.bar_band8);
            this.eBox1.Controls.Add(this.bar_band7);
            this.eBox1.Controls.Add(this.bar_band6);
            this.eBox1.Controls.Add(this.bar_band5);
            this.eBox1.Controls.Add(this.bar_band4);
            this.eBox1.Controls.Add(this.bar_band3);
            this.eBox1.Controls.Add(this.bar_band2);
            this.eBox1.Controls.Add(this.bar_band1);
            this.eBox1.Location = new System.Drawing.Point(680, 12);
            this.eBox1.Name = "eBox1";
            this.eBox1.Size = new System.Drawing.Size(435, 273);
            this.eBox1.TabIndex = 18;
            this.eBox1.TabStop = false;
            this.eBox1.Text = "Equalizer";
            // 
            // bar_band1
            // 
            this.bar_band1.Enabled = false;
            this.bar_band1.Location = new System.Drawing.Point(25, 32);
            this.bar_band1.Maximum = 15;
            this.bar_band1.Minimum = -15;
            this.bar_band1.Name = "bar_band1";
            this.bar_band1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band1.Size = new System.Drawing.Size(45, 206);
            this.bar_band1.TabIndex = 4;
            this.bar_band1.ValueChanged += new System.EventHandler(this.bar_band1_ValueChanged);
            // 
            // bar_band2
            // 
            this.bar_band2.Enabled = false;
            this.bar_band2.Location = new System.Drawing.Point(76, 32);
            this.bar_band2.Maximum = 15;
            this.bar_band2.Minimum = -15;
            this.bar_band2.Name = "bar_band2";
            this.bar_band2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band2.Size = new System.Drawing.Size(45, 206);
            this.bar_band2.TabIndex = 5;
            this.bar_band2.ValueChanged += new System.EventHandler(this.bar_band2_ValueChanged);
            // 
            // bar_band3
            // 
            this.bar_band3.Enabled = false;
            this.bar_band3.Location = new System.Drawing.Point(127, 32);
            this.bar_band3.Maximum = 15;
            this.bar_band3.Minimum = -15;
            this.bar_band3.Name = "bar_band3";
            this.bar_band3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band3.Size = new System.Drawing.Size(45, 206);
            this.bar_band3.TabIndex = 6;
            this.bar_band3.ValueChanged += new System.EventHandler(this.bar_band3_ValueChanged);
            // 
            // bar_band4
            // 
            this.bar_band4.Enabled = false;
            this.bar_band4.Location = new System.Drawing.Point(178, 33);
            this.bar_band4.Maximum = 15;
            this.bar_band4.Minimum = -15;
            this.bar_band4.Name = "bar_band4";
            this.bar_band4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band4.Size = new System.Drawing.Size(45, 206);
            this.bar_band4.TabIndex = 7;
            this.bar_band4.ValueChanged += new System.EventHandler(this.bar_band4_ValueChanged);
            // 
            // bar_band5
            // 
            this.bar_band5.Enabled = false;
            this.bar_band5.Location = new System.Drawing.Point(229, 33);
            this.bar_band5.Maximum = 15;
            this.bar_band5.Minimum = -15;
            this.bar_band5.Name = "bar_band5";
            this.bar_band5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band5.Size = new System.Drawing.Size(45, 206);
            this.bar_band5.TabIndex = 8;
            this.bar_band5.ValueChanged += new System.EventHandler(this.bar_band5_ValueChanged);
            // 
            // bar_band6
            // 
            this.bar_band6.Enabled = false;
            this.bar_band6.Location = new System.Drawing.Point(280, 32);
            this.bar_band6.Maximum = 15;
            this.bar_band6.Minimum = -15;
            this.bar_band6.Name = "bar_band6";
            this.bar_band6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band6.Size = new System.Drawing.Size(45, 206);
            this.bar_band6.TabIndex = 9;
            this.bar_band6.ValueChanged += new System.EventHandler(this.bar_band6_ValueChanged);
            // 
            // bar_band7
            // 
            this.bar_band7.Enabled = false;
            this.bar_band7.Location = new System.Drawing.Point(331, 33);
            this.bar_band7.Maximum = 15;
            this.bar_band7.Minimum = -15;
            this.bar_band7.Name = "bar_band7";
            this.bar_band7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band7.Size = new System.Drawing.Size(45, 206);
            this.bar_band7.TabIndex = 10;
            this.bar_band7.ValueChanged += new System.EventHandler(this.bar_band7_ValueChanged);
            // 
            // bar_band8
            // 
            this.bar_band8.Enabled = false;
            this.bar_band8.Location = new System.Drawing.Point(382, 32);
            this.bar_band8.Maximum = 15;
            this.bar_band8.Minimum = -15;
            this.bar_band8.Name = "bar_band8";
            this.bar_band8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_band8.Size = new System.Drawing.Size(45, 206);
            this.bar_band8.TabIndex = 11;
            this.bar_band8.ValueChanged += new System.EventHandler(this.bar_band8_ValueChanged);
            // 
            // l_band1
            // 
            this.l_band1.AutoSize = true;
            this.l_band1.Location = new System.Drawing.Point(22, 242);
            this.l_band1.Name = "l_band1";
            this.l_band1.Size = new System.Drawing.Size(13, 13);
            this.l_band1.TabIndex = 12;
            this.l_band1.Text = "0";
            this.l_band1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_band2
            // 
            this.l_band2.AutoSize = true;
            this.l_band2.Location = new System.Drawing.Point(73, 241);
            this.l_band2.Name = "l_band2";
            this.l_band2.Size = new System.Drawing.Size(13, 13);
            this.l_band2.TabIndex = 13;
            this.l_band2.Text = "0";
            this.l_band2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_band3
            // 
            this.l_band3.AutoSize = true;
            this.l_band3.Location = new System.Drawing.Point(119, 241);
            this.l_band3.Name = "l_band3";
            this.l_band3.Size = new System.Drawing.Size(13, 13);
            this.l_band3.TabIndex = 14;
            this.l_band3.Text = "0";
            this.l_band3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_band4
            // 
            this.l_band4.AutoSize = true;
            this.l_band4.Location = new System.Drawing.Point(175, 242);
            this.l_band4.Name = "l_band4";
            this.l_band4.Size = new System.Drawing.Size(13, 13);
            this.l_band4.TabIndex = 15;
            this.l_band4.Text = "0";
            this.l_band4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_band4.Click += new System.EventHandler(this.label4_Click);
            // 
            // l_band5
            // 
            this.l_band5.AutoSize = true;
            this.l_band5.Location = new System.Drawing.Point(226, 241);
            this.l_band5.Name = "l_band5";
            this.l_band5.Size = new System.Drawing.Size(13, 13);
            this.l_band5.TabIndex = 16;
            this.l_band5.Text = "0";
            this.l_band5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_band6
            // 
            this.l_band6.AutoSize = true;
            this.l_band6.Location = new System.Drawing.Point(277, 241);
            this.l_band6.Name = "l_band6";
            this.l_band6.Size = new System.Drawing.Size(13, 13);
            this.l_band6.TabIndex = 17;
            this.l_band6.Text = "0";
            this.l_band6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_band7
            // 
            this.l_band7.AutoSize = true;
            this.l_band7.Location = new System.Drawing.Point(328, 241);
            this.l_band7.Name = "l_band7";
            this.l_band7.Size = new System.Drawing.Size(13, 13);
            this.l_band7.TabIndex = 18;
            this.l_band7.Text = "0";
            this.l_band7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_band8
            // 
            this.l_band8.AutoSize = true;
            this.l_band8.Location = new System.Drawing.Point(379, 241);
            this.l_band8.Name = "l_band8";
            this.l_band8.Size = new System.Drawing.Size(13, 13);
            this.l_band8.TabIndex = 19;
            this.l_band8.Text = "0";
            this.l_band8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 297);
            this.Controls.Add(this.eBox1);
            this.Controls.Add(this.radio_3);
            this.Controls.Add(this.radio_2);
            this.Controls.Add(this.radio_1);
            this.Controls.Add(this.display_time_sum);
            this.Controls.Add(this.display_time_now);
            this.Controls.Add(this.display_bar);
            this.Controls.Add(this.display_label_current);
            this.Controls.Add(this.ce2_box);
            this.Controls.Add(this.box_modulation);
            this.Controls.Add(this.box_panning);
            this.Controls.Add(this.groupBox_Echo);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox_Echo.ResumeLayout(false);
            this.groupBox_Echo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.echo_trackbar_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Echo_trackbar_factor)).EndInit();
            this.box_panning.ResumeLayout(false);
            this.box_panning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panning_trackbar)).EndInit();
            this.box_modulation.ResumeLayout(false);
            this.box_modulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulation_trackbar)).EndInit();
            this.ce2_box.ResumeLayout(false);
            this.ce2_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ce2_trackbar)).EndInit();
            this.eBox1.ResumeLayout(false);
            this.eBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_band8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.GroupBox groupBox_Echo;
        private System.Windows.Forms.TrackBar Echo_trackbar_factor;
        private System.Windows.Forms.Label label_echo_factor;
        private System.Windows.Forms.TrackBar echo_trackbar_length;
        private System.Windows.Forms.Label echo_label_length;
        private System.Windows.Forms.GroupBox box_panning;
        private System.Windows.Forms.Label panning_label;
        private System.Windows.Forms.TrackBar panning_trackbar;
        private System.Windows.Forms.CheckBox echo_enabled_check;
        private System.Windows.Forms.CheckBox panning_enabled_check;
        private System.Windows.Forms.GroupBox box_modulation;
        private System.Windows.Forms.CheckBox modulation_enabled_check;
        private System.Windows.Forms.Label modulation_label;
        private System.Windows.Forms.TrackBar modulation_trackbar;
        private System.Windows.Forms.GroupBox ce2_box;
        private System.Windows.Forms.Label ce2_label;
        private System.Windows.Forms.TrackBar ce2_trackbar;
        private System.Windows.Forms.CheckBox ce2_check_enabled;
        private System.Windows.Forms.Label display_label_current;
        private System.Windows.Forms.HScrollBar display_bar;
        private System.Windows.Forms.Label display_time_now;
        private System.Windows.Forms.Label display_time_sum;
        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.RadioButton radio_2;
        private System.Windows.Forms.RadioButton radio_3;
        private System.Windows.Forms.Timer progress_timer;
        private System.Windows.Forms.GroupBox eBox1;
        private System.Windows.Forms.Label l_band8;
        private System.Windows.Forms.Label l_band7;
        private System.Windows.Forms.Label l_band6;
        private System.Windows.Forms.Label l_band5;
        private System.Windows.Forms.Label l_band4;
        private System.Windows.Forms.Label l_band3;
        private System.Windows.Forms.Label l_band2;
        private System.Windows.Forms.Label l_band1;
        private System.Windows.Forms.TrackBar bar_band8;
        private System.Windows.Forms.TrackBar bar_band7;
        private System.Windows.Forms.TrackBar bar_band6;
        private System.Windows.Forms.TrackBar bar_band5;
        private System.Windows.Forms.TrackBar bar_band4;
        private System.Windows.Forms.TrackBar bar_band3;
        private System.Windows.Forms.TrackBar bar_band2;
        private System.Windows.Forms.TrackBar bar_band1;
    }
}

