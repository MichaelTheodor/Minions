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
    public partial class MY_PETS : Form
    {

        decimal fs = 5000; //food in the supplier
        decimal fb = 0; //food in the bowl
        decimal ws = 6000; //water in the supplier
        decimal wb = 0; //water in the bowl
        decimal mf = 0; //manual feeding
        decimal mw = 0;//manual watering

        public MY_PETS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard f13 = new Dashboard();
            f13.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MY_PETS_Load(object sender, EventArgs e)
        {
            timer3.Start();
            timer4.Start();
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox25.Visible = false;
            checkBox8.Visible = false;
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            MessageBox.Show("Edelweiss was naughty!Press the pet camera button to see the incident.");
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pet_camera f23 = new Pet_camera();
            f23.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox19.Visible = true;
            textBox19.Text = textBox6.Text;
            textBox20.Visible = true;
            textBox20.Text = textBox5.Text;
            textBox25.Visible = true;
            textBox25.Text = textBox24.Text;
            checkBox8.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal fs,fb,mf,ws,wb,mw;
            fs=decimal.Parse(textBox1.Text);
            fb = decimal.Parse(textBox3.Text);
            mf = decimal.Parse(textBox12.Text);
            ws = decimal.Parse(textBox2.Text);
            wb = decimal.Parse(textBox4.Text);
            mw = decimal.Parse(textBox11.Text);
            if (fs == 0)
            {
                MessageBox.Show("You can't feed manually because the food supply is empty!");
            }
            if (ws == 0)
            {
                MessageBox.Show("You can't water manually because the water supply is empty!");
            }
            textBox1.Text = (fs - mf).ToString();
            textBox2.Text = (ws - mw).ToString();
            textBox3.Text = (fb+mf).ToString();
            textBox4.Text = (wb+mw).ToString();
            if (fb > 500)
            {
                MessageBox.Show("You can't feed manually because the food bowl is full!");
                
                textBox3.Text = (fb).ToString();
                textBox1.Text = (fs).ToString();
            }
            if (wb > 500)
            {
                MessageBox.Show("You can't water manually because the water bowl is full!");
                
                textBox4.Text = (wb).ToString();
                textBox2.Text = (ws).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "13");
        }
    }
}
