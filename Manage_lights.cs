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
    public partial class Manage_lights : Form
    {
        int bedroom_light = 0, kitchen_light = 0,bathroom_light = 0, livingroom_light = 0;

            public Manage_lights()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bedroom")
            {
                pictureBox1.Image = Properties.Resources.bedroom;
                bedroom_light = 1;
            }
            else if (comboBox1.Text == "Kitchen")
            {
                pictureBox1.Image = Properties.Resources.kitchen;
                kitchen_light = 1;
            }
            else if (comboBox1.Text == "Bathroom")
            {
                pictureBox1.Image = Properties.Resources.bathroom;
                bathroom_light = 1;
            }
            else if (comboBox1.Text == "Living Room")
            {
                pictureBox1.Image = Properties.Resources.livingroom;
                livingroom_light = 1;
            }
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bedroom")
            {
                pictureBox1.Image = Properties.Resources.bedroom0;
                bedroom_light = 0;
            }
            else if (comboBox1.Text == "Kitchen")
            {
                pictureBox1.Image = Properties.Resources.kitchen0;
                kitchen_light = 0;
            }
            else if (comboBox1.Text == "Bathroom")
            {
                pictureBox1.Image = Properties.Resources.bathroom0;
                bathroom_light = 0;
            }
            else if (comboBox1.Text == "Living Room")
            {
                pictureBox1.Image = Properties.Resources.livingroom0;
                livingroom_light = 0;
            }
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Manage_lights_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "7");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Control f20 = new Home_Control();
            f20.Show();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
            if (comboBox1.Text == "Bedroom")
            {
                if (bedroom_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.bedroom;
                    button2.Enabled = true;
                }
                else if (bedroom_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.bedroom0;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Kitchen")
            {
                if (kitchen_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.kitchen;
                    button2.Enabled = true;
                }
                else if (kitchen_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.kitchen0;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Bathroom")
            {
                if (bathroom_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.bathroom;
                    button2.Enabled = true;
                }
                else if (bathroom_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.bathroom0;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Living Room")
            {
                if (livingroom_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.livingroom;
                    button2.Enabled = true;
                }
                else if (livingroom_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.livingroom0;
                    button1.Enabled = true;
                }
            }
        }
    }
}
