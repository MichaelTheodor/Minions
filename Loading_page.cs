using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minions
{
    public partial class Loading_page : Form
    {
        int startpos = 0;
        public Loading_page()
        {
            InitializeComponent();
        }

        private void Loading_page_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            MyprogressBar.Value = startpos;
            if (MyprogressBar.Value == 100)
            {
                MyprogressBar.Value = 100;
                timer1.Stop();
                this.Hide();
                Login f2 = new Login();
                f2.Show();
            }
        }
    }
}
