using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Floppy_Bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            GameStart();

        }
        private void GameStart()
        {

            gameTimer.Enabled = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FloppyBird.Top += gravity;
            pipeBottom1.Left -= pipeSpeed;
            pipeTop1.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;

            scoreTxt.Text = $"Score: {score.ToString()}";
            if (pipeBottom1.Left < -140)
            {
                pipeBottom1.Left = 1650;
                score++;
            }
            if (pipeBottom2.Left < -130)
            {
                pipeBottom2.Left = 1649;
                score++;
            }
            if (pipeTop1.Left < -120)
            {
                pipeTop1.Left = 1550;
                score++;
            }
            if (pipeTop2.Left < -110)
            {
                pipeTop2.Left = 1599;
                score++;
            }
            if (score > 10)
            {
                pipeSpeed = 15;
            }
            if (score > 50)
            {
                pipeSpeed = 20;
            }
            if (score > 50)
            {
                pipeSpeed = 25;
            }


            if (FloppyBird.Bounds.IntersectsWith(pipeBottom1.Bounds) ||
               FloppyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
               FloppyBird.Bounds.IntersectsWith(pipeTop1.Bounds) ||
               FloppyBird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
               FloppyBird.Bounds.IntersectsWith(ground.Bounds) ||
               FloppyBird.Top < -22)

            {
                EndGame();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;

            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void EndGame()
        {
            gameTimer.Stop();
            scoreTxt.Text += "   Game Over!!!";
        } 


       

        private void Start(object sender, ToolStripItemClickedEventArgs e)
        {
            Process.Start(Application.ExecutablePath);

            // Closes the current process
            Environment.Exit(0);
            
        }
    }
}
