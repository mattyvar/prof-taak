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

namespace Simon_Says2
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            //Anti flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
        //Countdown start
        private int counter = 5;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //New timer and count with ticks of 1 second(1000ms)
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            //Start timer and write to label
            timer1.Start();
            lblCountdown.Text = counter.ToString();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Countdown
            counter--;
            //If 0 stop timer and close splashscreen and open gameform
            if (counter == 0)
                timer1.Stop();
            lblCountdown.Text = counter.ToString();
            if (counter == 0)
            {
                GameForm f5 = new GameForm(new Difficulty(2));
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
