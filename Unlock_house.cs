using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minions
{
    public partial class Unlock_house : Form
    {

        String Code = "12345";
        SpeechSynthesizer engine = new SpeechSynthesizer();
        public Unlock_house()
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
            Dashboard f13 = new Dashboard();
            f13.Show();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            String pass = textBox1.Text;
            //Parameterized query//
            
            if (Code == pass)
            {
                MessageBox.Show("Welcome Home!");
                engine.SelectVoice("Microsoft Zira");
                engine.SpeakAsync(richTextBox2.Text);
                engine.Volume = 100;
                engine.Rate = 0;
                Home_Control f23 = new Home_Control();
                f23.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WELCOME INTRUDER!"); 
                pictureBox5.Visible=true;
                timer2.Enabled = true;
                player.URL = @"alarm mp3\Security Warning.mp3";
                player.settings.playCount = 1;    
            }
        }

        private void Unlock_house_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.URL = @"alarm mp3\Mission Impossible - Minions Cover.mp3";
            player.settings.playCount = 1;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            engine.SelectVoice("Microsoft Zira");
            engine.SpeakAsync(richTextBox1.Text);
            engine.Volume = 100;
            engine.Rate = 0;
            timer2.Enabled = false;
        }
    }
}
