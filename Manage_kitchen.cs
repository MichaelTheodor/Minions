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
    public partial class Manage_kitchen : Form
    {
        int coffe_maker = 0;
        public Manage_kitchen()
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString() + "°C";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar2.Value.ToString() + "°C";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar3.Value.ToString() + "°C";
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label12.Text = trackBar4.Value.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible= true;
            pictureBox16.Visible = false;
            pictureBox15.Visible = false;
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox16.Visible = true;
            pictureBox15.Visible = false;
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox16.Visible = false;
            pictureBox15.Visible = true;
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox16.Visible = false;
            pictureBox15.Visible = false;
            pictureBox14.Visible = true;
            pictureBox13.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox16.Visible = false;
            pictureBox15.Visible = false;
            pictureBox14.Visible = false;
            pictureBox13.Visible = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            
            pictureBox23.Visible = true;
            
            
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
           
            pictureBox22.Visible = true;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox25.Visible = true;
            
          
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
          
            pictureBox24.Visible = true;
            
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Visible = false;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Visible = false;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Visible = false; 
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
           
            pictureBox16.Visible = false;
            
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            
            pictureBox15.Visible = false;
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
        
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
            pictureBox13.Visible = false;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = true;
            pictureBox27.Enabled = true;
            pictureBox28.Enabled = true;
            pictureBox29.Enabled = true;
            pictureBox30.Enabled = true;
            pictureBox31.Enabled = true;
            pictureBox32.Enabled = true;

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = true;
            pictureBox37.Visible = false;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
            pictureBox34.Visible = false;
            pictureBox33.Visible = false;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            pictureBox37.Visible = true;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
            pictureBox34.Visible = false;
            pictureBox33.Visible = false;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            pictureBox37.Visible = false;
            pictureBox36.Visible = true;
            pictureBox35.Visible = false;
            pictureBox34.Visible = false;
            pictureBox33.Visible = false;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            pictureBox37.Visible = false;
            pictureBox36.Visible = false;
            pictureBox35.Visible = true;
            pictureBox34.Visible = false;
            pictureBox33.Visible = false;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            pictureBox37.Visible = false;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
            pictureBox34.Visible = true;
            pictureBox33.Visible = false;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            pictureBox37.Visible = false;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
            pictureBox34.Visible = false;
            pictureBox33.Visible = true;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox38.Visible = false;
            pictureBox37.Visible = false;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
            pictureBox34.Visible = false;
            pictureBox33.Visible = false;
            pictureBox27.Enabled = false;
            pictureBox28.Enabled = false;
            pictureBox29.Enabled = false;
            pictureBox30.Enabled = false;
            pictureBox31.Enabled = false;
            pictureBox32.Enabled = false;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.Visible = false;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.Visible = false;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = false;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.Visible = false;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Visible = false;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label13.Text = trackBar5.Value.ToString() + "°C";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void Manage_kitchen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox27.Enabled = false;
            pictureBox28.Enabled = false;
            pictureBox29.Enabled = false;
            pictureBox30.Enabled = false;
            pictureBox31.Enabled = false;
            pictureBox32.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "9");
        }
    }
}
