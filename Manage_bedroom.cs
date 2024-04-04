using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minions
{
    public partial class Manage_bedroom : Form
    {
        int Television = 0;
        public Manage_bedroom()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void Manage_bedroom_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Shoe_rack f21 = new Shoe_rack();
            f21.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "10");
        }
    }
}
