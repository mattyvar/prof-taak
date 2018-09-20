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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            //Anti flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //If button play is clicked, open splashscreen and close this one
            SplashScreen f4 = new SplashScreen();
            f4.Show();
            this.Hide();
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
            f2.Show();
            this.Hide();
        }
    }
}
