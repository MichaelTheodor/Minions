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
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minions
{
    public partial class Login : Form
    {
        String connectionString = "Data source = Minions_app.db;version=3";
        SQLiteConnection conn;
        SpeechSynthesizer engine = new SpeechSynthesizer();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            engine.SelectVoice("Microsoft Zira");
            engine.SpeakAsync(richTextBox1.Text);
            engine.Volume = 100;
            engine.Rate = 0;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String email = textBox1.Text;
            String password = textBox2.Text;
            //Parameterized query//
            String selectSQL = "Select * from Users where " + "email=@email and password=@password";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Login sucessfully done!");
                Dashboard f3 = new Dashboard();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password...");
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
