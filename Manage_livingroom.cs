using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Net.WebRequestMethods;

namespace Minions
{
    public partial class Manage_livingroom : Form
    {
        int Television = 0;
        
        public Manage_livingroom()
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
            Home_Control f10 = new Home_Control();
            f10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.tv1;
            Television = 1;
            pictureBox4.Visible = true;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.tv1;
            Television = 0;
            pictureBox4.Visible = false;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString() + "°C";
        }

        private void Manage_livingroom_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://best.live24.gr/best1222"; //best
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://imagine897.radioca.st/"; //imagine
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://s10.voscast.com:9942"; //velvet
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://ionian.yourstreaming.gr:9302/"; //ionian galaxy 
        }
    
        private void pictureBox8_Click(object sender, EventArgs e)
        {
        axWindowsMediaPlayer1.URL = "https://cast4.magicstreams.gr:10159/"; //music galaxy radio
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://sc2.streamwithq.com:8018/stream"; //mad
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "8");
        }
    }
}
