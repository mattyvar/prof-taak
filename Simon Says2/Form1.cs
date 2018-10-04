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
    public partial class GameForm : Form
    {
        private EV3Wifi myEV3;
        private Difficulty difficulty;
        private Connection connection;
        public Connection c;
        public GameForm(Difficulty _difficulty)
        {
            InitializeComponent();
            //Anti flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            myEV3 = new EV3Wifi();
            myEV3.SendMessage("Forward", "0");
            difficulty = _difficulty;
        }
        //Declare variables and make new list for combination
        int onInList = 0;
        List<int> pattern = new List<int>();
        Random rand = new Random();
        bool playingBack = false;
        //Check which button is pressed and give it to testCorrect function
        private void btnBlue_Click(object sender, EventArgs e)
        {
            testCorrect(1);
            // Send message "Forward" to EV3.
            c = new Connection(0);
        }
        private void btnOrange_Click(object sender, EventArgs e)
        {
            testCorrect(3);
            c = new Connection(1);
        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            testCorrect(0);
            c = new Connection(2);
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            testCorrect(2);
            c = new Connection(3);
        }

        void testCorrect(int color)
        {
            
            if (playingBack)//if colors are playing back, return to beginning
            {
                return;
            }
            if (pattern[onInList] == color)//If color is in the list, add one to the list
            {
                onInList++;

            }
            else//If color is not right, display messagebox
            {
                MessageBox.Show("Gefaald! Highscore is: " + pattern.Count.ToString());
                HighscoreForm f2 = new HighscoreForm(); //Open highscoreform
                this.Hide();
                f2.ShowDialog();
                this.Close();//Close this one
                /*onInList = 0;
                pattern = new List<int>();
                new Thread(playback).Start();*/
            }
            if(onInList >= pattern.Count) //Add one to pattern
            {
                //Get random int(color) for combination
                pattern.Add(rand.Next(0, 4));
                onInList = 0;
                new Thread(playback).Start(); //Playback colors
            }
            //Show score and in pattern
            lblScore.Text = ("Score: " + pattern.Count.ToString());
            lblPattern.Text = ("In pattern: " + onInList.ToString());
        }





        void playback()
        {
            Thread.Sleep(600);
            //Playback colors
            playingBack = true;
            foreach (int color in pattern)
            {
                
                //Switch for showing colors
                switch (color)
                {
                    case 0:
                        //btnRed.BackColor = Color.Transparent;
                       // btnRed.Size = new Size(500, 600);
                        btnRed.FlatAppearance.BorderSize = 5;
                        Thread.Sleep(difficulty.delay);
                        btnRed.FlatAppearance.BorderSize = 0;
                        //btnRed.Size = new Size(400, 500);
                        //btnRed.BackColor = Color.Red;
                        break;
                    case 1:
                        //btnBlue.BackColor = Color.Transparent;
                        //btnBlue.Size = new Size(500, 600);
                        btnBlue.FlatAppearance.BorderSize = 5;
                        Thread.Sleep(difficulty.delay);
                        btnBlue.FlatAppearance.BorderSize = 0;
                        //btnBlue.Size = new Size(400, 500);
                        //btnBlue.BackColor = Color.Blue;
                        break;

                    case 2:
                        //btnGreen.BackColor = Color.Transparent;
                        //btnGreen.Size = new Size(500, 600);
                        //btnGreen.Width += 100;
                        btnGreen.FlatAppearance.BorderSize = 5;
                        Thread.Sleep(difficulty.delay);
                        btnGreen.FlatAppearance.BorderSize = 0;
                        // btnGreen.Size = new Size(400, 500);
                        // btnGreen.Height -= 100;
                        // btnGreen.Width -= 100;
                        // btnGreen.BackColor = Color.LimeGreen;
                        break;
                    case 3:
                        // btnOrange.BackColor = Color.Transparent;
                        // btnOrange.Size = new Size(500, 600);
                        btnOrange.FlatAppearance.BorderSize = 5;
                        Thread.Sleep(difficulty.delay);
                        btnOrange.FlatAppearance.BorderSize = 0;
                        //btnOrange.Size = new Size(400, 500);
                        //btnOrange.BackColor = Color.Orange;
                        break;
                }
                Thread.Sleep(400);
            }
            playingBack = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                MessageBox.Show("Verbonden");
            }
            pattern.Add(rand.Next(0, 4));
            new Thread(playback).Start();    
        }
    }
}
