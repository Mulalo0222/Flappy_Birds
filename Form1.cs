﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 5;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if(pipeDown.Left< -150)
            {
                pipeDown.Left = 800;
                score++;
            }
            if(pipeUp.Left<-180)
            {
                pipeUp.Left = 950;
                score++;
            }

            if(flappyBird.Bounds.IntersectsWith(pipeDown.Bounds) || flappyBird.Bounds.IntersectsWith(pipeUp.Bounds)
                || flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if(score >5)
            {
                pipeSpeed = 15;
            }
            if(flappyBird.Top <-25)
            {
                endGame();
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = - 7;

            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;

            }
        }
      private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text +=  " Game Over!!";
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }
    }
}
