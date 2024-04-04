using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minions
{
    public partial class Pet_camera : Form
    {
        string[] paths, files;
        public Pet_camera()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e) // watch latest incident
        {
            player.URL = @"mp4/1.mp4";
        }

        private void pictureBox1_Click(object sender, EventArgs e) //  watch older incidents
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;                                       // Display//
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    Incidents.Items.Add(files[i]);
                }
            }
        }

        private void Incidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[Incidents.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            MY_PETS f25 = new MY_PETS();
            f25.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "13");
        }

        private void Pet_camera_Load(object sender, EventArgs e)
        {
            player.URL = @"mp4/1.mp4";
            timer1.Start();
        }
    }
}
