using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPJPlayer
{
    public partial class Form1 : Form
    {
        private Player glavni;
        int status;
        public Form1()
        {
            glavni = new Player();
            status = 0;
            InitializeComponent();
            Echo_trackbar_factor.Value = 10;
            echo_trackbar_length.Value = 10;
        }

        private void update_labels()
        {
            switch (status)
            {
                case 0:
                    button_play.Text = "Play";
                    button_play.Enabled = false;
                    button_stop.Enabled = false;
                    break;
                case 1:
                    button_stop.Enabled = true;
                    button_play.Text = "Pause";
                    button_play.Enabled = true;
                    break;
                case 2:
                    button_stop.Enabled = true;
                    button_play.Enabled = true;
                    button_play.Text = "Play";
                    break;
            }
        }
        private void ResetState()
        {
            //effects reset
            //echo
            groupBox_Echo.Enabled = false;
            echo_enabled_check.Checked = true;
            echo_label_length.Text = "Length: 10";
            label_echo_factor.Text = "Factor: 1.0";
            echo_trackbar_length.Value = 10;
            Echo_trackbar_factor.Value = 10;
            //panning
            box_panning.Enabled = false;
            panning_enabled_check.Enabled = true;
            panning_trackbar.Value = 0;
            panning_label.Text = "Middle: 0";
            //distorsion
            box_modulation.Enabled = false;
            modulation_enabled_check.Checked = true;
            modulation_label.Text = "a: 0";
            modulation_trackbar.Value = 0;
            //modulacija
            mod_box.Enabled = false;
            mod_check_enabled.Checked = true;
            mod_label.Text = "Range: 0";
            mod_trackbar.Value = 0;
            //kompresija
            ce2_box.Enabled = false;
            ce2_check_enabled.Enabled = true;
            ce2_trackbar.Value = 0;
            ce2_label.Text = "Intensity: 0";
            //tone
            ce3_box.Enabled = false;
            ce3_check_enabled.Checked = true;
            ce3_label_a.Text = "Intensity: 0";
            ce3_label_freq.Text = "Frequency: 1";
            ce3_trackbar.Value = 0;
            ce3_trackbar2.Value = 1;
            //display
            display_label_current.Text = "Current: ";
            display_bar.Value = 0;
            display_bar.Maximum = 100;
            display_bar.Minimum = 0;
            display_time_now.Text = "Now";
            display_time_sum.Text = "Duration";
            button_play.Enabled = false;
            button_stop.Enabled = false;
            //radio buttons
            radio_1.Enabled = false;
            radio_1.Checked = false;
            radio_2.Enabled = false;
            radio_2.Checked = false;
            radio_3.Enabled = false;
            radio_3.Checked = true;
            //timer
        }
        private void Initialize()
        {
            if (glavni.effect != null)
            {
                //effects reset
                //echo
                groupBox_Echo.Enabled = true;
                echo_enabled_check.Checked = true;
                echo_label_length.Text = "Length: 10";
                label_echo_factor.Text = "Factor: 1.0";
                echo_trackbar_length.Value = 10;
                Echo_trackbar_factor.Value = 10;
                //panning
                box_panning.Enabled = true;
                panning_enabled_check.Enabled = true;
                panning_trackbar.Value = 0;
                panning_label.Text = "Middle: 0";
                //distorsion
                box_modulation.Enabled = true;
                modulation_enabled_check.Checked = true;
                modulation_label.Text = "a: 0";
                modulation_trackbar.Value = 0;
                //modulacija
                mod_box.Enabled = true;
                mod_check_enabled.Checked = true;
                mod_label.Text = "Range: 0";
                mod_trackbar.Value = 0;
                //kompresija
                ce2_box.Enabled = true;
                ce2_check_enabled.Enabled = true;
                ce2_trackbar.Value = 0;
                ce2_label.Text = "Intensity: 0";
                //tone
                ce3_box.Enabled = true;
                ce3_check_enabled.Checked = true;
                ce3_label_a.Text = "Intensity: 0";
                ce3_label_freq.Text = "Frequency: 1";
                ce3_trackbar.Value = 0;
                ce3_trackbar2.Value = 1;
                //display
                display_label_current.Text = "Current: " + glavni.Name;
                display_bar.Value = 0;
                display_bar.Maximum = 100;
                display_bar.Minimum = 0;
                display_time_now.Text = "0";
                display_time_sum.Text = "Duration: " + glavni.stream.TotalTime.Minutes + ":" + glavni.stream.TotalTime.Seconds;
                button_play.Enabled = true;
                button_stop.Enabled = true;
                //radio buttons
                radio_1.Enabled = true;
                radio_1.Checked = false;
                radio_2.Enabled = true;
                radio_2.Checked = false;
                radio_3.Enabled = true;
                radio_3.Checked = true;
                //timer
            }
        }
        private void button_play_Click(object sender, EventArgs e)
        {
            if (glavni.play())
            {
                status = 1;
            }
            else
            {
                status = 2;
            }
            update_labels();
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            if (glavni.open())
            {
                status = 2;
                Initialize();
            }
            else
            {
                status = 0;
            }
            update_labels();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            glavni.stop();
            status = 0;
            update_labels();
            ResetState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            glavni.Dispose();
        }

        private void Echo_trackbar_factor_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is Echo)
                        {
                            Echo ec = ef as Echo;
                            ec.EchoFactor = Echo_trackbar_factor.Value / 10.0f;
                        }
                    }
                }
                label_echo_factor.Text = "Factor: " + (Echo_trackbar_factor.Value / 10.0f);
            }
        }

        private void echo_trackbar_length_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is Echo)
                        {
                            Echo ec = ef as Echo;
                            ec.Update();
                            ec.EchoLength = echo_trackbar_length.Value * 2000;
                        }
                    }
                }
                echo_label_length.Text = "Length: " + (echo_trackbar_length.Value);
            }
        }

        private void panning_trackbar_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is Panning)
                        {
                            Panning pn = ef as Panning;
                            pn.Update(panning_trackbar.Value / 10);
                            if (panning_trackbar.Value > 0)
                            {
                                panning_label.Text = "Right: " + panning_trackbar.Value;
                            }
                            else if (panning_trackbar.Value == 0)
                            {
                                panning_label.Text = "Middle: 0";
                            }
                            else
                            {
                                panning_label.Text = "Left: " + Math.Abs(panning_trackbar.Value);
                            }
                        }
                    }
                }
            }
        }

        private void echo_enabled_check_CheckedChanged(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is Echo)
                        {
                            Echo ec = ef as Echo;
                            ec.enabled = echo_enabled_check.Checked;
                        }
                    }
                }
            }
        }

        private void panning_enabled_check_CheckedChanged(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is Panning)
                        {
                            Panning pn = ef as Panning;
                            pn.enabled = panning_enabled_check.Checked;
                        }
                    }
                }
            }
        }

        private void modulation_trackbar_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is Distorsion)
                        {
                            Distorsion md = ef as Distorsion;
                            md.Update((float)modulation_trackbar.Value / 10);
                            modulation_label.Text = "a: " + ((float)modulation_trackbar.Value / 10);
                        }
                    }
                }
            }
        }

        private void modulation_enabled_check_CheckedChanged(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is Distorsion)
                        {
                            Distorsion md = ef as Distorsion;
                            md.enabled = modulation_enabled_check.Checked;
                        }
                    }
                }
            }
        }

        private void mod_trackbar_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is CustomEffect1)
                        {
                            CustomEffect1 ce1 = ef as CustomEffect1;
                            ce1.Update(mod_trackbar.Value * 100000);
                            if (mod_trackbar.Value == 0)
                            {
                                mod_label.Text = "Range: 0";
                            }
                            else
                            {
                                mod_label.Text = "Range: " + (mod_trackbar.Value * 100) + "k";
                            }
                        }
                    }
                }
            }
        }

        private void mod_check_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is CustomEffect1)
                        {
                            CustomEffect1 ce1 = ef as CustomEffect1;
                            ce1.enabled = mod_check_enabled.Checked;
                        }
                    }
                }
            }
        }

        private void ce2_trackbar_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is CustomEffect2)
                        {
                            CustomEffect2 ce2 = ef as CustomEffect2;
                            ce2.Update(ce2_trackbar.Value);
                            ce2_label.Text = "Intensity: " + ce2_trackbar.Value;
                        }
                    }
                }
            }
        }

        private void ce2_check_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is CustomEffect2)
                        {
                            CustomEffect2 ce2 = ef as CustomEffect2;
                            ce2.enabled = ce2_check_enabled.Checked;
                        }
                    }
                }
            }
        }

        private void ce3_trackbar_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is CustomEffect3)
                        {
                            CustomEffect3 ce3 = ef as CustomEffect3;
                            ce3.Update(ce3_trackbar.Value / 40f, ce3_trackbar2.Value * 10);
                            ce3_label_a.Text = "Intensity: " + (ce3_trackbar.Value / 40f);
                        }
                    }
                }
            }
        }

        private void ce3_trackbar2_Scroll(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is CustomEffect3)
                        {
                            CustomEffect3 ce3 = ef as CustomEffect3;
                            ce3.Update(ce3_trackbar.Value / 40f, ce3_trackbar2.Value * 10);
                            ce3_label_freq.Text = "Frequency: " + ce3_trackbar2.Value;
                        }
                    }
                }
            }
        }

        private void ce3_check_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (glavni.effect != null)
            {
                foreach (List<Effect> l in glavni.effect.Effects)
                {
                    foreach (Effect ef in l)
                    {
                        if (ef is CustomEffect3)
                        {
                            CustomEffect3 ce3 = ef as CustomEffect3;
                            ce3.enabled = ce3_check_enabled.Checked;
                        }
                    }
                }
            }
        }

        private void progress_timer_Tick(object sender, EventArgs e)
        {
            if (status != 0)
            {
                if (glavni.stream.Position > 0)
                {
                    if (glavni.stream.Position >= glavni.stream.Length)
                    {
                        if (radio_1.Checked)
                        {
                            glavni.stream.Position = 0;
                        }
                    }
                    else
                    {
                        display_bar.Value = (int)(glavni.stream.Position / (glavni.stream.Length / 100));
                        display_time_now.Text = glavni.stream.CurrentTime.Minutes + ":" + glavni.stream.CurrentTime.Seconds + "";
                    }
                }
            }
        }

        private void display_bar_Scroll(object sender, ScrollEventArgs e)
        {
            int s = (int)(display_bar.Value - (glavni.stream.CurrentTime.TotalSeconds / glavni.stream.TotalTime.TotalSeconds) * 100);
            glavni.stream.Skip(s);
            if (glavni.output.PlaybackState != NAudio.Wave.PlaybackState.Playing)
            {
                glavni.play();
            }
        }

        private void display_bar_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (glavni.output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
            {
                glavni.play();
            }
        }
    }
}
