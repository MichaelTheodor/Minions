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
    public partial class Loading : Form
    {
        WMPLib.WindowsMediaPlayer player =new WMPLib.WindowsMediaPlayer();
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            player.URL = @"Minions Fanfare_cut.mp3";
            player.controls.play();
                  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Loading_page f1 = new Loading_page();
            f1.Show();
        }
    }
}
