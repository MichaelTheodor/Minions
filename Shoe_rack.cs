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
    public partial class Shoe_rack : Form
    {
       int x=0;
       SpeechSynthesizer engine = new SpeechSynthesizer();
        public Shoe_rack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            if (x == 0)
            {
                pictureBox1.Image = Properties.Resources.athletic_shoes;
                textBox1.Text = "Athletic shoes ";
                textBox2.Text = "Nike";
                textBox3.Text = "2 months old";
                textBox4.Text = "Walking,running,gym";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 1)
            {
                pictureBox1.Image = Properties.Resources.casual_shoes;
                textBox1.Text = "Casual shoes ";
                textBox2.Text = "Levis";
                textBox3.Text = "15 months old";
                textBox4.Text = "Everywhere except formal occassions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 2)
            {
                pictureBox1.Image = Properties.Resources.boat_shoes;
                textBox1.Text = "Boat shoes ";
                textBox2.Text = "Yot";
                textBox3.Text = "4 months old";
                textBox4.Text = "In summer at casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 3)
            {
                pictureBox1.Image = Properties.Resources.boots;
                textBox1.Text = "Boots ";
                textBox2.Text = "GK Uomo";
                textBox3.Text = "3 months old";
                textBox4.Text = "All seasons except summer at casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 4)
            {
                pictureBox1.Image = Properties.Resources.casual_boots;
                textBox1.Text = "Casual boots";
                textBox2.Text = "Pepe Jeans";
                textBox3.Text = "10 months old";
                textBox4.Text = "At casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 5)
            {
                pictureBox1.Image = Properties.Resources.formal_shoes1;
                textBox1.Text = "Formal shoes (brown)";
                textBox2.Text = "Guy Laroche";
                textBox3.Text = "12 months old";
                textBox4.Text = "At formal occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 6)
            {
                pictureBox1.Image = Properties.Resources.formal_shoes2;
                textBox1.Text = "Formal shoes (black) ";
                textBox2.Text = "Guy Laroche";
                textBox3.Text = "8 months old";
                textBox4.Text = "At formal occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 7)
            {
                pictureBox1.Image = Properties.Resources.mocassins;
                textBox1.Text = "Mocassins";
                textBox2.Text = "GK Uomo";
                textBox3.Text = "5 months old";
                textBox4.Text = "In summer at formal or casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 8)
            {
                pictureBox1.Image = Properties.Resources.sandals;
                textBox1.Text = "Sandals";
                textBox2.Text = "Yot";
                textBox3.Text = "6 months old";
                textBox4.Text = "In summer at casual occasions or in the beach ";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 9)
            {
                pictureBox1.Image = Properties.Resources.slippers;
                textBox1.Text = "Slippers";
                textBox2.Text = "Pepe Jeans";
                textBox3.Text = "1 month old";
                textBox4.Text = "At home while relaxing";
                engine.SpeakAsync(textBox1.Text);
            }
        }

        private void Shoe_rack_Load(object sender, EventArgs e)
        {
            timer1.Start();
            engine.SelectVoice("Microsoft Zira");
            richTextBox1.Text = "Welcome to your smart shoe rack!Here you can check all your available shoes!";
            engine.SpeakAsync(richTextBox1.Text);
            engine.Volume = 100;
            engine.Rate = 0;
            pictureBox1.Image = Properties.Resources.athletic_shoes;
            textBox1.Text = "Athletic shoes ";
            textBox2.Text = "Nike";
            textBox3.Text = "2 months old";
            textBox4.Text = "Walking,running,gym";   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x--;
            if (x == 0)
            {
                pictureBox1.Image = Properties.Resources.athletic_shoes;
                textBox1.Text = "Athletic shoes ";
                textBox2.Text = "Nike";
                textBox3.Text = "2 months old";
                textBox4.Text = "Walking,running,gym";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 1)
            {
                pictureBox1.Image = Properties.Resources.casual_shoes;
                textBox1.Text = "Casual shoes ";
                textBox2.Text = "Levis";
                textBox3.Text = "15 months old";
                textBox4.Text = "Everywhere except formal occassions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 2)
            {
                pictureBox1.Image = Properties.Resources.boat_shoes;
                textBox1.Text = "Boat shoes ";
                textBox2.Text = "Yot";
                textBox3.Text = "4 months old";
                textBox4.Text = "In summer at casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 3)
            {
                pictureBox1.Image = Properties.Resources.boots;
                textBox1.Text = "Boots ";
                textBox2.Text = "GK Uomo";
                textBox3.Text = "3 months old";
                textBox4.Text = "All seasons except summer at casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 4)
            {
                pictureBox1.Image = Properties.Resources.casual_boots;
                textBox1.Text = "Casual boots";
                textBox2.Text = "Pepe Jeans";
                textBox3.Text = "10 months old";
                textBox4.Text = "At casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 5)
            {
                pictureBox1.Image = Properties.Resources.formal_shoes1;
                textBox1.Text = "Formal shoes (brown)";
                textBox2.Text = "Guy Laroche";
                textBox3.Text = "12 months old";
                textBox4.Text = "At formal occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 6)
            {
                pictureBox1.Image = Properties.Resources.formal_shoes2;
                textBox1.Text = "Formal shoes (black) ";
                textBox2.Text = "Guy Laroche";
                textBox3.Text = "8 months old";
                textBox4.Text = "At formal occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 7)
            {
                pictureBox1.Image = Properties.Resources.mocassins;
                textBox1.Text = "Mocassins";
                textBox2.Text = "GK Uomo";
                textBox3.Text = "5 months old";
                textBox4.Text = "In summer at formal or casual occasions";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 8)
            {
                pictureBox1.Image = Properties.Resources.sandals;
                textBox1.Text = "Sandals";
                textBox2.Text = "Yot";
                textBox3.Text = "6 months old";
                textBox4.Text = "In summer at casual occasions or in the beach ";
                engine.SpeakAsync(textBox1.Text);
            }
            else if (x == 9)
            {
                pictureBox1.Image = Properties.Resources.slippers;
                textBox1.Text = "Slippers";
                textBox2.Text = "Pepe Jeans";
                textBox3.Text = "1 month old";
                textBox4.Text = "At home while relaxing";
                engine.SpeakAsync(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_bedroom f22 = new Manage_bedroom();
            f22.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "10");
        }
    }
}
