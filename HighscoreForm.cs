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
    public partial class HighscoreForm : Form
    {
        public HighscoreForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void HighscoreForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bedankt voor het spelen! Vul hierna uw gegevens in en kom op de website!");
        }
    }
}
