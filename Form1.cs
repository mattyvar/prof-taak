﻿using System;
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
        public GameForm()
        {
            InitializeComponent();
            //Anti flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
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
                f2.Show();
                this.Hide();//Close this one
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
            //Playback colors
            playingBack = true;
            foreach (int color in pattern)
            {
                //Switch for showing colors
                switch (color)
                {
                    case 0:
                        btnRed.BackColor = Color.Transparent;
                        Thread.Sleep(400);
                        btnRed.BackColor = Color.Red;
                        break;
                    case 1:
                        btnBlue.BackColor = Color.Transparent;
                        Thread.Sleep(400);
                        btnBlue.BackColor = Color.Blue;
                        break;
                    case 2:
                        btnGreen.BackColor = Color.Transparent;
                        Thread.Sleep(400);
                        btnGreen.BackColor = Color.LimeGreen;
                        break;
                    case 3:
                        btnOrange.BackColor = Color.Transparent;
                        Thread.Sleep(400);
                        btnOrange.BackColor = Color.Orange;
                        break;
                }
                Thread.Sleep(400);
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
