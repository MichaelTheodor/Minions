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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
            player.URL = @"mp3\Diana_Ross_Tame_Impala_Turn_Up_The_Sunshine.mp3";
            player.settings.playCount = 1;
            trackBar1.Value = 30;

        }
        string[] paths, files;
        private void Dashboard_Load(object sender, EventArgs e)

        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
               label9.Text = DateTime.Now.ToString(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            Unlock_house f4 = new Unlock_house();
            f4.Show();
            this.Hide();
            player.Ctlcontrols.stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Calendar f5 = new Calendar();
            f5.Show();
            this.Hide();
            player.Ctlcontrols.stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            MY_PETS f6 = new MY_PETS();
            f6.Show();
            this.Hide();
            player.Ctlcontrols.stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            Shopping f7 = new Shopping();
            f7.Show();
            this.Hide();
            player.Ctlcontrols.stop();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
            Internet f8 = new Internet();
            f8.Show();
            this.Hide();
            player.Ctlcontrols.stop();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
            Gps f9 = new Gps();
            f9.Show();
            this.Hide();
            player.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            trackBar1.Visible=true;
            label6.Visible=true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            label6.Text = trackBar1.Value.ToString() + "%";
        }

        private void pictureBox11_Click(object sender, EventArgs e) //Music Folder Button//
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect=true;
            if (ofd.ShowDialog() ==System.Windows.Forms.DialogResult.OK) 
            {
                files = ofd.SafeFileNames;                                       // Display//
                paths = ofd.FileNames;
                for(int i = 0; i < files.Length; i++) 
                {
                    listBox1.Items.Add(files[i]);
                }
            
            }       

        }

        private void pictureBox12_Click(object sender, EventArgs e) //Previous Button//
        {
            if (listBox1.SelectedIndex > 0) 
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e) //Next Button//
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1) 
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e) //Play Button//
        {
            player.Ctlcontrols.play();
        }

        private void pictureBox16_Click(object sender, EventArgs e) //Pause Button//
        {
            player.Ctlcontrols.pause();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[listBox1.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm");
        }

        private void pictureBox15_Click(object sender, EventArgs e) //Stop Button//
        {
            player.Ctlcontrols.stop();
        }
    }
}
