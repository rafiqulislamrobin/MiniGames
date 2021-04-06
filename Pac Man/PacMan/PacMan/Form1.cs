using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class PacManGame : Form
    {
        bool goup, godown, goright, goleft, isGameOVer;
        int score, playerSpeed, redGhostSpeed, yellowGhoshtSpeed, pinkGhostX, pinkGhostY;

        private void pacman_Click(object sender, EventArgs e)
        {

        }

        public PacManGame()
        {
            InitializeComponent();
            RestartGame();
        }

        private void PacManGame_Load(object sender, EventArgs e)
        {
            //RestartGame();
        }



        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                pacman.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;

                pacman.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {

                goup = true;
                pacman.Image = Properties.Resources.Up;
            }
            if (e.KeyCode == Keys.Down)
            {

                godown = true;
                pacman.Image = Properties.Resources.down;
            }
           
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOVer == true)
            {
                RestartGame();
                gameTimer.Enabled = true; ;
            }
        }
        private void mainGameTimer(object sender, EventArgs e)
        {
            scoreTxt.Text = $"Score: {score}";
            //player movement codes start
            if (goleft==true)
            {
                pacman.Left -= playerSpeed;
                //moving player to the left. 
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                //moving player to the right
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                //moving to the top
            }

            if (godown == true)
            {
                pacman.Top += playerSpeed;
                //moving down
            }


            //if pacman go out of the border 
            if (pacman.Left < -10)
            {
                pacman.Left = 780;
            }
            if (pacman.Left > 780)
            {
                pacman.Left = -10;
            }
            if (pacman.Top < -10)
            {
                pacman.Top = 650;

            }
            if (pacman.Top > 680)
            {
                pacman.Top = 0;

            }

            // coin and score

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }                   
                    }
                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOver("GAME OVER!!\npress enter\nto play again");
                        }
                        if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }
                    }
                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOver("GAME OVER!!\npress enter\nto play again");
                        }
                    }
                }
            }

            //moving ghost
            redGhost.Left += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(wall1.Bounds) || redGhost.Bounds.IntersectsWith(wall2.Bounds))
            {
                redGhostSpeed = (-redGhostSpeed);
            }

            yellowGhost.Left += yellowGhoshtSpeed;
            if (yellowGhost.Bounds.IntersectsWith(wall3.Bounds)|| yellowGhost.Bounds.IntersectsWith(wall4.Bounds))
            {
                yellowGhoshtSpeed = -yellowGhoshtSpeed;
            }


            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;

            if (pinkGhost.Top >600 || pinkGhost.Top <0)
            {
                pinkGhostY = -pinkGhostY;
            }
            if (pinkGhost.Left >730 || pinkGhost.Left <0)
            {
                pinkGhostX = -pinkGhostX;
            }


            if (score == 46)
            {
                GameOver("YOU WIN!!");
            }

        }
        private void RestartGame()
        {
           

            scoreTxt.Text = "Score: 0";
            score = 0;

            redGhostSpeed = 5;
            yellowGhoshtSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 8;

            isGameOVer = false;

            pacman.Left = 22;
            pacman.Top = 166;

            redGhost.Left = 241;
            redGhost.Top = 82;

            yellowGhost.Left = 518;
            yellowGhost.Top = 539;

            pinkGhost.Left = 674 ;
            pinkGhost.Top = 268;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }
        }
        private void GameOver(string message)
        {
            isGameOVer = true;
            gameTimer.Stop();

            scoreTxt.Text = $"Score: {score } {Environment.NewLine}{message}";
        }
    }
}
//x=left,y=top
