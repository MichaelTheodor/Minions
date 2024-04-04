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
    public partial class Calendar : Form
    {
        String date = "";
        String[] times = new String[15];
        String[] selected = new String[11];
        String[] transportation = new String[5];
        public Calendar()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard f12 = new Dashboard();
            f12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            dateTimePicker1.Visible=true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            date= (dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder stringbuilder = new StringBuilder();
            groupBox2.Visible = true;
            if (checkBox1.Checked)
            {
                times[0]= (dateTimePicker2.Value.ToString("HH:mm"));
                selected[0]= (checkBox1.Text);
                stringbuilder.Append("-").Append(checkBox1.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker2.Value.ToString("HH:mm")).Append("\n");
                DialogResult dialogResult = MessageBox.Show("Coffee", "Do you want some Coffee?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    DialogResult d2 = MessageBox.Show("Yes for efood/ No for Coffee station", "Online?", MessageBoxButtons.YesNo);
                    if (d2 == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://www.e-food.gr/");
                    }
                    else
                    {
                        this.Hide();
                        Gps f27 = new Gps();
                        f27.Show();
                    }
                }

            }
           if (checkBox2.Checked)
            {
                times[1] = (dateTimePicker3.Value.ToString("HH:mm"));
                times[2] = (dateTimePicker4.Value.ToString("HH:mm"));
                selected[1] = (checkBox2.Text);
                stringbuilder.Append("-").Append(checkBox2.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker3.Value.ToString("HH:mm")).Append("\n");
                DialogResult dialogResult = MessageBox.Show("Coffee", "Do you want some Coffee?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    DialogResult d2 = MessageBox.Show("Yes for efood/ No for Coffee station", "Online?", MessageBoxButtons.YesNo);
                    if (d2 == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://www.e-food.gr/");
                    }
                    else
                    {
                        this.Hide();
                        Gps f27 = new Gps();
                        f27.Show();
                    }
                }
               
            }
            if (checkBox2.Checked && checkBox17.Checked)
            {
                times[1] = (dateTimePicker3.Value.ToString("HH:mm"));
                times[2] = (dateTimePicker4.Value.ToString("HH:mm"));
                selected[1] = (checkBox2.Text);
                stringbuilder.Append("-").Append(checkBox2.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker3.Value.ToString("HH:mm")).Append(" ").Append("and").Append(" ").Append(dateTimePicker4.Value.ToString("HH:mm")).Append("\n");
               
            }
            
            if (checkBox3.Checked)
            {
                times[3] = (dateTimePicker5.Value.ToString("HH:mm"));
                selected[2] = (checkBox3.Text);
                stringbuilder.Append("-").Append(checkBox3.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker5.Value.ToString("HH:mm")).Append("\n");
                pictureBox3.Visible = true;
            }
            if (checkBox4.Checked)
            {
                times[4] = (dateTimePicker6.Value.ToString("HH:mm"));
                selected[3] = (checkBox4.Text);
                stringbuilder.Append("-").Append(checkBox4.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker6.Value.ToString("HH:mm")).Append("\n");
                
            }
            if (checkBox5.Checked)
            {
                times[5] = (dateTimePicker7.Value.ToString("HH:mm"));
                selected[4] = (checkBox5.Text);
                stringbuilder.Append("-").Append(checkBox5.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker7.Value.ToString("HH:mm")).Append("\n");
                pictureBox5.Visible = true;
                DialogResult dialogResult1 = MessageBox.Show("Message from your Smart Shoe rack", "Your casual shoes are more than a year,do you want to buy new?", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {

                    DialogResult d2 = MessageBox.Show("Yes to buy them now/ No for Later", "Online?", MessageBoxButtons.YesNo);
                    if (d2 == DialogResult.Yes)
                    {

                        Shopping f28 = new Shopping();
                        f28.Show();
                    }
                    else
                    {

                    }
                }
            }
            if (checkBox6.Checked)
            {
                times[6] = (dateTimePicker8.Value.ToString("HH:mm"));
                selected[5] = (checkBox6.Text);
                stringbuilder.Append("-").Append(checkBox6.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker8.Value.ToString("HH:mm")).Append("\n");
                pictureBox4.Visible = true;
            }
            if (checkBox7.Checked && checkBox18.Checked)
            {
                times[7] = (dateTimePicker9.Value.ToString("HH:mm"));
                times[8] = (dateTimePicker10.Value.ToString("HH:mm"));
                selected[6] = (checkBox7.Text);
                stringbuilder.Append("-").Append(checkBox7.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker9.Value.ToString("HH:mm")).Append(" ").Append("and").Append(" ").Append(dateTimePicker10.Value.ToString("HH:mm")).Append("\n");
            }
            if (checkBox7.Checked)
            {
                times[7] = (dateTimePicker9.Value.ToString("HH:mm"));
                times[8] = (dateTimePicker10.Value.ToString("HH:mm"));
                selected[6] = (checkBox7.Text);
                stringbuilder.Append("-").Append(checkBox7.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker9.Value.ToString("HH:mm")).Append("\n");
            }

            if (checkBox8.Checked && checkBox19.Checked)
            {
                times[9] = (dateTimePicker11.Value.ToString("HH:mm"));
                times[10] = (dateTimePicker12.Value.ToString("HH:mm"));
                selected[7] = (checkBox8.Text);
                stringbuilder.Append("-").Append(checkBox8.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker11.Value.ToString("HH:mm")).Append(" ").Append("and").Append(" ").Append(dateTimePicker12.Value.ToString("HH:mm")).Append("\n");
            }
            if (checkBox8.Checked)
            {
                times[9] = (dateTimePicker11.Value.ToString("HH:mm"));
                times[10] = (dateTimePicker12.Value.ToString("HH:mm"));
                selected[7] = (checkBox8.Text);
                stringbuilder.Append("-").Append(checkBox8.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker11.Value.ToString("HH:mm")).Append("\n");
            }
            if (checkBox9.Checked && checkBox20.Checked)
            {
                times[11] = (dateTimePicker13.Value.ToString("HH:mm"));
                times[12] = (dateTimePicker14.Value.ToString("HH:mm"));
                selected[8] = (checkBox9.Text);
                stringbuilder.Append("-").Append(checkBox9.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker13.Value.ToString("HH:mm")).Append(" ").Append("and").Append(" ").Append(dateTimePicker14.Value.ToString("HH:mm")).Append("\n");
            }
            if (checkBox9.Checked)
            {
                times[11] = (dateTimePicker13.Value.ToString("HH:mm"));
                times[12] = (dateTimePicker14.Value.ToString("HH:mm"));
                selected[8] = (checkBox9.Text);
                stringbuilder.Append("-").Append(checkBox9.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker13.Value.ToString("HH:mm")).Append("\n");
            }
            if (checkBox10.Checked)
            {
                times[13] = (dateTimePicker15.Value.ToString("HH:mm"));
                selected[9] = (checkBox10.Text);
                stringbuilder.Append("-").Append(checkBox10.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker15.Value.ToString("HH:mm")).Append("\n");
                pictureBox6.Visible = true;
            }
            if (checkBox11.Checked)
            {
                times[14] = (dateTimePicker16.Value.ToString("HH:mm"));
                selected[10] = (checkBox11.Text);
                stringbuilder.Append("-").Append(checkBox11.Text).Append(" ").Append("at").Append(" ").Append(dateTimePicker16.Value.ToString("HH:mm")).Append("\n");
                pictureBox7.Visible = true;
            }


            groupBox3.Visible = true;
            groupBox3.Text = date;
            richTextBox1.Text = stringbuilder.ToString();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StringBuilder stringbuilder1 = new StringBuilder();
            if (checkBox16.Checked)
            { 
                transportation[0] = (checkBox16.Text);
                stringbuilder1.Append(checkBox16.Text).Append("\n");
            }
            if (checkBox12.Checked)
            {
                transportation[0] = (checkBox12.Text);
                stringbuilder1.Append(checkBox12.Text).Append("\n");
            }
            if (checkBox13.Checked)
            {
                transportation[0] = (checkBox13.Text);
                stringbuilder1.Append(checkBox13.Text).Append("\n");
            }
            if (checkBox14.Checked)
            {
                transportation[0] = (checkBox14.Text);
                stringbuilder1.Append(checkBox14.Text).Append("\n");
            }
            if (checkBox15.Checked)
            {
                transportation[0] = (checkBox15.Text);
                stringbuilder1.Append(checkBox15.Text).Append("\n");
            }
            groupBox4.Visible = true;
            groupBox4.Text = "Transportation";

            this.Hide();
            Gps f27 = new Gps();
            f27.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"minions.chm", HelpNavigator.TopicId, "12");
        }
    }
}
