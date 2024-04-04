using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Minions
{
    public partial class Manage_security : Form
    {
        SpeechSynthesizer engine = new SpeechSynthesizer();
        public Manage_security()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_Control f20 = new Home_Control();
            f20.Show();
            
        }

        private void button1_Click(object sender, EventArgs e) //HOME LOCK ON
        {
            pictureBox9.Visible = true;
            timer1.Enabled = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox8.Visible = true;
            engine.SelectVoice("Microsoft Zira");
            engine.SpeakAsync(textBox3.Text);
            engine.Volume = 100;
            engine.Rate = 0;
            button6.Enabled = true;
            button1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e) // HOME LOCK OFF
        {
            pictureBox9.Visible = false;
            timer1.Enabled = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox8.Visible = false;
            button1.Enabled = true;
            button6.Enabled = false;
            engine.SelectVoice("Microsoft Zira");
            engine.SpeakAsync(textBox4.Text);
            engine.Volume = 100;
            engine.Rate = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            Dashboard f20 = new Dashboard();
            f20.Show();
        }

        private void button11_Click(object sender, EventArgs e) // DOOR SENSORS ON
        {
            pictureBox3.Visible = true;
            button10.Enabled = true;
            button11.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e) // DOOR SENSORS OFF
        {
            pictureBox3.Visible = false;
            button11.Enabled = true;
            button10.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e) // WINDOWS SENSORS ON
        {
            pictureBox4.Visible = true;
            button12.Enabled = true;
            button13.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e) // WINDOWS SENSORS OFF
        {
            pictureBox4.Visible = false;
            button13.Enabled = true;
            button12.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e) //CALL POLICE
        {
            engine.SelectVoice("Microsoft Zira");
            engine.SpeakAsync(textBox1.Text);
            engine.Volume = 100;
            engine.Rate = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e) // //CALL AMBULANCE
        {
            engine.SelectVoice("Microsoft Zira");
            engine.SpeakAsync(textBox2.Text);
            engine.Volume = 100;
            engine.Rate = 0;
        }

        private void button7_Click(object sender, EventArgs e) // OUTSIDE SURVEILLANCE CAMERAS ON
        {
            pictureBox5.Visible = true;
            button2.Enabled = true;
            button7.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e) // OUTSIDE SURVEILLANCE CAMERAS OFF
        {
            pictureBox5.Visible = false;
            button2.Enabled = false;
            button7.Enabled = true;
        }
        private void button9_Click(object sender, EventArgs e) // INSIDE SURVEILLANCE CAMERAS ON
        {
            pictureBox8.Visible = true;
            button8.Enabled = true;
            button9.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e) // INSIDE SURVEILLANCE CAMERAS OFF
        {
            pictureBox8.Visible = false;
            button8.Enabled = false;
            button9.Enabled = true;
        }

        private void Manage_security_Load(object sender, EventArgs e)
        {
            engine.SelectVoice("Microsoft Zira");
            engine.SpeakAsync("Master, welcome to your home security management!");
            engine.Volume = 100;
            engine.Rate = 0;
            button2.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm",HelpNavigator.TopicId,"6");
        }
    }
}
