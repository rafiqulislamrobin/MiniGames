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

namespace Battle_Ship
{
    public partial class Game : Form
    {

        List<Button> playerPositionButtons;
        List<Button> enemyPositionButtons;

        Random rand = new Random();
        int totalShips = 5;
        int round = 20;
        int playerScore;
        int enemyScore;
          
        public Game()
        {
            InitializeComponent();
            RestartGame();
        }

        private void RestartGame()
        {
            playerPositionButtons = new List<Button>
            {u1,u2,u3,u4,u5,w1,w2,w3,w4,w5,x1,x2,x3,x4,x5,y1,y2,y3,y4,y5,z1,z2,z3,z4,z5
            };
            enemyPositionButtons =new List<Button>
            {a1,a2,a3,a4,a5,b1,b2,b3,b4,b5,c1,c2,c3,c4,c5,d1,d2,d3,d4,d5,e1,e2,e3,e4,e5
            };

            enemyLocationListBox.Items.Clear();
            enemyLocationListBox.Text = null;
            txtHelp.Text = "1)Click on five different locations from above to start!";

            for (int i = 0; i < enemyPositionButtons.Count; i++)
            {
                enemyPositionButtons[i].Enabled = true;
                enemyPositionButtons[i].Tag = null;
                enemyPositionButtons[i].BackColor = Color.Orange;
                enemyPositionButtons[i].BackgroundImage = null;
                enemyLocationListBox.Items.Add(enemyPositionButtons[i].Text);
            }
            for (int i = 0; i < playerPositionButtons.Count; i++)
            {
                playerPositionButtons[i].Enabled = true;
                playerPositionButtons[i].Tag = null;
                //playerPositionButtons[i].BackColor = Color.Orange;
                playerPositionButtons[i].BackgroundImage = null;

            }
            playerScore = 0;
            enemyScore = 0;
            totalShips = 5;
            round = 20;

            txtEnemy.Text = enemyScore.ToString();
            txtPlayer.Text = playerScore.ToString();
            enemyMove.Text = "A1";

            buttonAttack.Enabled = false;

            enemyLocationPicker();
        }

        private void enemyPlayTimerEvent(object sender, EventArgs e)
        {
            if (round>0 && playerPositionButtons.Count>0)
            {
                round -= 1;
                txtRound.Text = $"Round {round}";

                int index = rand.Next(playerPositionButtons.Count);

                if ((string)playerPositionButtons[index].Tag == "PlayerShip")
                {
                    enemyMove.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.fire;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons.RemoveAt(index);
                    enemyScore += 1;
                    txtEnemy.Text = enemyScore.ToString();
                    enemyPlayTimer.Stop();

                }
                else
                {
                    enemyMove.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.miss;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons.RemoveAt(index);
                    enemyPlayTimer.Stop();
                } 
            }
            if (round < 1 || enemyScore > 4 || playerScore > 4)
            {
                if (playerScore > enemyScore)
                {
                    MessageBox.Show("Player Win", "Player");
                    RestartGame();
                }
                else if(playerScore < enemyScore)
                {
                    MessageBox.Show("HAHA u lost noob!", "Bot");
                    RestartGame();
                }
                else if (playerScore == enemyScore)
                {
                    MessageBox.Show("MATCH DRAW", "DRAW");
                    RestartGame();
                }
            }
        }

        private void attackButtonEvent(object sender, EventArgs e)
        {
            if (enemyLocationListBox.Text != "")
            {
                var attackPosition = enemyLocationListBox.Text.ToLower();

                int index = enemyPositionButtons.FindIndex(a => a.Name == attackPosition);

                if (enemyPositionButtons[index].Enabled && round>0)
                {
                    round--;
                    txtRound.Text = $"Round {round}";

                    if ((string)enemyPositionButtons[index].Tag== "EnemyShip" )
                    {
                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackColor = Color.Orange;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.fire;
                        playerScore++;
                        txtPlayer.Text = playerScore.ToString();
                        enemyPlayTimer.Start();
                    }
                    else
                    {
                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackColor = Color.Orange;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.miss;
                        enemyPlayTimer.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a location from the drop down first! ", "Alert");
            }
        }

        private void playerPositionButtonsEvent(object sender, EventArgs e)
        {
            if (totalShips > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "PlayerShip";
                button.BackColor = Color.Azure;
                //button.ForeColor = Color.Yellow;
                totalShips--; 
            }

            if (totalShips==0)
            {
                buttonAttack.Enabled = true;
                buttonAttack.BackColor = Color.Red;
                buttonAttack.ForeColor = Color.White;

                txtHelp.Text = "2) Now pick the attack position from the drop down";
            }

        }
        private void enemyLocationPicker()
        {
            for (int i = 0; i < 5; i++)
            {
                int index = rand.Next(enemyPositionButtons.Count);

                if (enemyPositionButtons[index].Enabled==true && (string)enemyPositionButtons[index].Tag==null)
                {
                    enemyPositionButtons[index].Tag = "EnemyShip";

                    Debug.WriteLine($"Enemy Ships {enemyPositionButtons[index].Text}");

                    //enemyPositionButtons[index].Text = "ship";
                }
                else
                {
                    index = rand.Next(enemyPositionButtons.Count);
                }
            }
        }
    }
}
