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
    public partial class GameForm : Form
    {
        /*int colors = 4;
        int color_1 = 1;
        int color_2 = 2;
        int color_3 = 3;
        int color_4 = 4;
        int maxSequence = 100;

        int currentLengthOfSequence = 0;

        Random rand;
        int[] correctColorSeq;
        int[] playerColorSeq;
        int correctColorSequenceCount = 0;
        int playerColorSequenceCount = 0;

        Boolean playerTurn = true;
        Boolean seqCorrect = false;
        Boolean gameStart = false;*/







        public GameForm()
        {
            InitializeComponent();

        }
        int onInList = 0;
        List<int> pattern = new List<int>();
        Random rand = new Random();
        bool playingBack = false;

        private void btnBlue_Click(object sender, EventArgs e)
        {
            testCorrect(1);
        }
        private void btnOrange_Click(object sender, EventArgs e)
        {
            testCorrect(3);

        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            testCorrect(0);

        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            testCorrect(2);

        }

        void testCorrect(int color)
        {
            if (playingBack)
            {
                return;
            }
            if(pattern[onInList] == color)
            {
                onInList++;
            }
            else
            {
                MessageBox.Show("Gefaald! Highscore is: " + pattern.Count.ToString());
                HighscoreForm f2 = new HighscoreForm();
                f2.Show();
                /*onInList = 0;
                pattern = new List<int>();
                new Thread(playback).Start();*/
            }
            if(onInList >= pattern.Count)
            {
                pattern.Add(rand.Next(0, 4));
                onInList = 0;
                new Thread(playback).Start();
            }
            lblScore.Text = ("Score: " + pattern.Count.ToString());
            lblPattern.Text = ("In pattern: " + onInList.ToString());
        }





        void playback()
        {
            playingBack = true;
            foreach (int color in pattern)
            {
                switch (color)
                {
                    case 0:
                        btnRed.BackColor = Color.Red;
                        Thread.Sleep(200);
                        btnRed.BackColor = Color.Transparent;
                        break;
                    case 1:
                        btnBlue.BackColor = Color.Blue;
                        Thread.Sleep(200);
                        btnBlue.BackColor = Color.Transparent;
                        break;
                    case 2:
                        btnGreen.BackColor = Color.Green;
                        Thread.Sleep(200);
                        btnGreen.BackColor = Color.Transparent;
                        break;
                    case 3:
                        btnOrange.BackColor = Color.Orange;
                        Thread.Sleep(200);
                        btnOrange.BackColor = Color.Transparent;
                        break;
                }
                Thread.Sleep(200);
            }
            playingBack = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pattern.Add(rand.Next(0, 4));
            new Thread(playback).Start();
        }
    }
}
