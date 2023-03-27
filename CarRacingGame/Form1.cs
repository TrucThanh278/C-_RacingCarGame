using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rd = new Random();
        Random rdCarPosition = new Random();

        bool goLeft, goRight;

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if(goLeft==true && picPlayer.Left> 6) 
            {
                picPlayer.Left -= playerSpeed;
            }
            if (goRight == true && picPlayer.Left < 420)
            {
                picPlayer.Left += playerSpeed;
            }
        }

        private void resetGame()
        {
            btnStart.Enabled = false;
            goLeft = goRight = false;
            picAward.Visible = false;
            picExplosion.Visible = false;
            score = 0;
            picAward.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            picItem1.Top = rdCarPosition.Next(200, 500) *-1;
            picItem1.Left = rdCarPosition.Next(6, 188);

            picItem2.Top = rdCarPosition.Next(200, 500) * -1;
            picItem2.Left = rdCarPosition.Next(251, 420);
            gameTimer.Start();
        }
    }
}
