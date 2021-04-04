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

namespace Minesweeper
{
    public partial class game : Form
    {
        List<Button> bombPosition;
        int score = 0;
        int energy = 1;
        Random rand = new Random();
        public game()

        {
            InitializeComponent();
            RestartGame();
        }
        public void RestartGame()
        {
            energy = 1;
            lifeTxt.Text = $"Life: 1";
            score = 0;
            Scoretxt.Text = $"Score: 0";
            bombPosition = new List<Button>
            {b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,
            };
            for (int i = 0; i < bombPosition.Count; i++)
            {
                bombPosition[i].Enabled = true;
                bombPosition[i].Tag = null;
                bombPosition[i].BackColor = Color.White;
                bombPosition[i].BackgroundImage = null;
                //bombPosition[i].Text = "!";

            }
            BotLocationPicker();
            bombPosition = new List<Button>
            {b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,
            };
           


        }
        private void BotLocationPicker()
        {
            int point = 0;
            int bomb = 0;
            int life = 1;
            for (int i = 0; i < 25; i++)
            {
                int randomNumber = rand.Next(bombPosition.Count);
                if (point < 12)
                {
                    if (bombPosition[randomNumber].Tag == null && bombPosition[randomNumber].Enabled == true)
                    {
                        //bombPosition[randomNumber].BackColor = Color.Orange;
                        bombPosition[randomNumber].Tag = "point";

                        Debug.WriteLine($"point {randomNumber + 1}");


                        point++;                        
                    }
                    bombPosition.RemoveAt(randomNumber);
                }
               

                

                if (bomb < 11)
                {
                    randomNumber = rand.Next(bombPosition.Count);

                    if (bombPosition[randomNumber].Tag == null && bombPosition[randomNumber].Enabled == true)
                    {
                        
                        bombPosition[randomNumber].Tag = "bomb";

                        Debug.WriteLine($"bomb {randomNumber + 1}");
                        bombPosition[randomNumber].ForeColor = Color.White;

                        bomb++;
                    }
                    bombPosition.RemoveAt(randomNumber);
                }
                if (life < 3)
                {
                    randomNumber = rand.Next(bombPosition.Count);

                    if (bombPosition[randomNumber].Tag == null && bombPosition[randomNumber].Enabled == true)
                    {

                        bombPosition[randomNumber].Tag = "life";

                        Debug.WriteLine($"life {randomNumber+1}");
                        //bombPosition[randomNumber].ForeColor = Color.Purple;
                        //bombPosition[randomNumber].BackColor = Color.Purple;
                        life++;
                    }
                    
                    bombPosition.RemoveAt(randomNumber);
                }

            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Enabled = false;
            button.BackColor = Color.White;

            if ((string) button.Tag=="point")
            {
                score++;
                Scoretxt.Text = $"Score: {score}";
                button.Text = "1point";
                button.BackgroundImage = Properties.Resources.safe;
                
                button.BackColor = Color.Green;
                if (score == 12)
                {
                    MessageBox.Show("CONGRATS U WIN !!!");
                    RestartGame();
                }

            }
            else if ((string)button.Tag == "life")
            {
                energy = energy + 1;
               
                button.Text = "1LIFE";              
                button.BackColor = Color.Purple;
                button.BackgroundImage = Properties.Resources.life;
                lifeTxt.Text = $"Life: {energy}";
            }
            else
            {
                button.BackColor = Color.Red;
                
                button.Text = "bomb";
                energy--;
                button.BackgroundImage = Properties.Resources.bomb;
                lifeTxt.Text = $"Life: {energy}";


            }
            if (energy == 0)
            {
                MessageBox.Show($"GAME OVER! YOUR SCORE: {score}");
                RestartGame();
            }
        }

        private void ExitButton_click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
  
