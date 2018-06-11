using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        private int leftpadlemove = 0;
        private int rightpadlemove = 0;
        private int padlespeed = 5;
        private int ballxspeed = 3;
        private int ballyspeed = 1;
        private int ballydir = 1;
        private int ballxdir = 1;
        private bool delay = true;
        private int score1 = 0;
        private int score2 = 0;

        public Form1()
        {
            InitializeComponent();
            setup_score();
            reset_ball();
        }

        private void setup_score()
        {
            leftscore.Location = new Point((this.Width - leftscore.Width - rightscore.Width) / 3 + 20, (this.Height - leftscore.Height) / 2 - 23);
            rightscore.Location = new Point(leftscore.Location.X*2 + leftscore.Width - 50, leftscore.Location.Y);
            ball.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (leftpadle.Top <= 0 && leftpadlemove == -1)
                return;
            if (leftpadle.Bottom >= this.Height - 27 && leftpadlemove == 1)
                return;
            move_padle(leftpadle, leftpadlemove);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rightpadle.Top <= 0 && rightpadlemove == -1)
                return;
            if (rightpadle.Bottom >= this.Height - 27 && rightpadlemove == 1)
                return;
            move_padle(rightpadle, rightpadlemove);
        }

        private void move_padle(Panel p, int arg)
        {
            p.Location = new Point(p.Location.X, p.Location.Y + padlespeed * arg);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                rightpadlemove = 1;
            }
            else if (e.KeyCode == Keys.Up)
            {
                rightpadlemove = -1;
            }
            else if (e.KeyCode == Keys.S)
            {
                leftpadlemove = 1;
            }
            else if (e.KeyCode == Keys.W)
            {
                leftpadlemove = -1;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && rightpadlemove != -1)
            {
                rightpadlemove = 0;
            }
            else if (e.KeyCode == Keys.Up && rightpadlemove != 1)
            {
                rightpadlemove = 0;
            }
            else if (e.KeyCode == Keys.S && leftpadlemove != -1)
            {
                leftpadlemove = 0;
            }
            else if (e.KeyCode == Keys.W && leftpadlemove != 1)
            {
                leftpadlemove = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            bounce();
            move_ball();
        }

        private void move_ball()
        {
            ball.Location = new Point(ball.Location.X + ballxspeed*ballxdir, ball.Location.Y + ballyspeed*ballydir);
        }

        private void reset_ball()
        {
            Random rnd = new Random();
            ballyspeed = rnd.Next(0, 5);
            ballxdir = rnd.Next(0, 2);
            if (ballxdir == 0)
                ballxdir = -1;
            ballydir = rnd.Next(0, 2);
            if (ballydir == 0)
                ballydir = -1;


            ball.Location = new Point(this.Width / 2 - ball.Width/2, this.Height / 2 - ball.Height/2);
            ballxspeed = 3;

            leftscore.Text = score1.ToString();
            rightscore.Text = score2.ToString();
        }

        private void bounce()
        {
            if (ball.Left <= leftpadle.Right && ball.Left >= leftpadle.Right - ballxspeed && ball.Bottom > leftpadle.Top && ball.Top < leftpadle.Bottom)
            {
                ballxdir = ballxdir * -1;
                ballyspeed = ballyspeed + leftpadlemove * ballydir;
                if (delay)
                {
                    ballxspeed += 1;
                    delay = false;
                }
                else
                    delay = true;
            }
                

            else if (ball.Right >= rightpadle.Left && ball.Right <= rightpadle.Left + ballxspeed && ball.Bottom > rightpadle.Top && ball.Top < rightpadle.Bottom)
            {
                ballxdir = ballxdir * -1;
                ballyspeed = ballyspeed + rightpadlemove * ballydir;
                if (delay)
                {
                    ballxspeed += 1;
                    delay = false;
                }
                else
                    delay = true;
            }
                

            if (ball.Bottom >= this.Height-27)
                ballydir = ballydir * -1;

            else if (ball.Top <= 0)
                ballydir = ballydir * -1;

            if(ball.Right > this.Width)
            {
                score1 += 1;
                reset_ball();
            }
            else if (ball.Left < 0)
            {
                score2 += 1;
                reset_ball();
            }
        }
    }
}
