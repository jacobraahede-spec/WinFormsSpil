using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSpil
{
    public partial class Form4 : Form
    {
        int ballXspeed = 4;
        int ballYspeed= 4;
        int speed = 4;
        Random rand =  new Random();
        bool goDown, goUp;
        int Computer_speed_change = 50;
        int SpillerScore = 0;
        int ComputerScore = 0;
        int Spillerspeed = 8;
        int[] i = { 5, 6, 7, 8, 9 };
        int[] j = { 8, 9, 10, 11, 12 };
        public Form4()
        {
            InitializeComponent();
        }

        private void SpilTimerEvent(object sender, EventArgs e)
        {
            ball.Top -= ballYspeed;
            ball.Left -= ballXspeed;

            this.Text = "Spiller Point " + SpillerScore + " -- Computer Point " + ComputerScore;
            if (ball.Top < 0 || ball.Bottom > this.ClientSize.Height)
            {
                ballYspeed = -ballYspeed;

            }
            if (ball.Left <2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                ComputerScore++;
            }
            if(ball.Right > this.ClientSize.Width + 2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                SpillerScore++;
            }
            if (Computer.Top <= 1)
            {
                Computer.Top = 0;
            }
            else if (Computer.Bottom >= this.ClientSize.Height)
            {
                Computer.Top = this.ClientSize.Height - Computer.Height;
            }
            if (ball.Top < Computer.Top + (Computer.Height /2) && ball.Left > 300)
            {
                Computer.Top -= speed;
            }
            if (ball.Top > Computer.Top + (Computer.Height / 2) && ball.Left > 300)
            {
                Computer.Top += speed;
            }

            Computer_speed_change -= 1;

            if (Computer_speed_change < 0)
            {
                speed = i[rand.Next(i.Length)];
                Computer_speed_change = 50;
            }
            if (goDown && Spiller1.Top + Spiller1.Height < this.ClientSize.Height)
            {
                Spiller1.Top += Spillerspeed;
            }
            if (goUp && Spiller1.Top > 0)
            {
                Spiller1.Top -= Spillerspeed;
            }

            CheckCollision(ball, Spiller1, Spiller1.Right + 5);
            CheckCollision(ball, Computer, Computer.Left - 35);

            if (ComputerScore > 5)
            {
                GameOver("Desværre du tabte");
            }
            else if (SpillerScore  > 5)
            {
                GameOver("Tillykke du vandt");
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void CheckCollision(PictureBox Pic0ne, PictureBox PicTwo, int offset)
        {
            if (Pic0ne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                    Pic0ne.Left = offset;

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];
                if (ballXspeed <0)
                {
                    ballXspeed = x;
                }
                else
                {
                    ballXspeed += -x;
                }
                if (ballXspeed == 0)
                {
                    Pic0ne.Location = new Point(20, 20);
                }
                if (ballYspeed <0)
                {
                    ballYspeed = -y;
                }
                else
                {
                    ballYspeed += y;
                }
                if (ballYspeed == 0)
                {
                    Pic0ne.Location = new Point(20, 20); 
                }

            }
        }

        private void GameOver(string message)
        {
            SpilTimer.Stop();
            MessageBox.Show(message, "Spillet er ovre -- spillet genstartes ");
            ComputerScore = 0;
            SpillerScore = 0;
            ballXspeed = ballYspeed = 4;
            Computer_speed_change = 50;
            SpilTimer.Start();
        }
    }
}
