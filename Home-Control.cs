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
    public partial class Home_Control : Form
    {
        public Home_Control()
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
            Dashboard f10 = new Dashboard();
            f10.Show();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_security f11 = new Manage_security();
            f11.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_lights f12 = new Manage_lights();
            f12.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_livingroom f13 = new Manage_livingroom();
            f13.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_kitchen f14 = new Manage_kitchen();
            f14.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_bathroom f16 = new Manage_bathroom();
            f16.Show();
        }

        private void Home_Control_Load(object sender, EventArgs e)
        {
           
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_bedroom f15 = new Manage_bedroom();
            f15.Show();
            
        }
    }
}
