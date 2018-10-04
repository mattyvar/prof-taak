using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using EV3WifiLib;

namespace Simon_Says2
{
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
            //Anti flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            timer1.Tick += blinkTextbox;
            timer1.Interval = 500;
            timer1.Enabled = true;
        }

         private void btnPlay_Click(object sender, EventArgs e)
        {
            //If button play is clicked, open splashscreen and close this one
            SplashScreen f4 = new SplashScreen();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Exit application
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If button options is clicked, open options form and close this one
            OptionsForm f2 = new OptionsForm();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(new Difficulty().delay.ToString());
        }



        private void StartForm_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void blinkTextbox(object sender, EventArgs e)
        {
            if (lblStart.ForeColor == Color.Black)
            {
                lblStart.ForeColor = Color.Transparent;
            }
            else
            {
                lblStart.ForeColor = Color.Black;
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            EV3WIFI f1 = new EV3WIFI();
            f1.Show();
            this.Hide();
        }
    }
}
