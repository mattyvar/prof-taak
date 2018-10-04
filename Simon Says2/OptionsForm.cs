using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Says2
{
    public partial class OptionsForm : Form
    {
        public Difficulty d;

        public OptionsForm()
        {
            InitializeComponent();
            //Anti flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            rbtEasy.BackColor = Color.Transparent;
            rbtMedium.BackColor = Color.Transparent;
            rbtHard.BackColor = Color.Transparent;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            if (rbtEasy.Checked)
            {
                d = new Difficulty(1);
            }
            if (rbtMedium.Checked)
            {
                d = new Difficulty(2);
            }
            if (rbtHard.Checked)
            {
                d = new Difficulty(3);
            }
            SplashScreen f8 = new SplashScreen();
            this.Hide();
            f8.ShowDialog();
            this.Close();
        }
    }
}

