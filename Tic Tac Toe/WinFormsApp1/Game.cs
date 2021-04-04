using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Game : Form
    {
        char player = 'o';
        short count = 0;
        int X=0;
        int O = 0;
        int draw = 0;
        public Game()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            player = 'o';
            count = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.CadetBlue;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.CadetBlue;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.CadetBlue;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.CadetBlue;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.CadetBlue;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.CadetBlue;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.CadetBlue;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.CadetBlue;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.CadetBlue;
            tableLayoutPanel1.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show($"O: {O}\nX: {X}\nDraw: {draw}");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Enabled = false;
            button.BackColor = Color.Orange;
            if (player=='o')
            {
                button.BackColor = Color.Orange;
                button.Text = "O";
                if ((b1.Text==b2.Text && b2.Text == b3.Text && b2.Text!="")||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != "") )
                {
                    MessageBox.Show($"The Winner is {player.ToString().ToUpper()} !!!!");
                    tableLayoutPanel1.Enabled = false;
                    O++;
                }
                else if (count==8)
                {
                    MessageBox.Show("DRAW!!!");
                    draw++;

                }
                player = 'x';
            }
            else if (player == 'x')
            {
                button.BackColor = Color.Green;
                button.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show($"The Winner is {player.ToString().ToUpper()} !!!!");
                    tableLayoutPanel1.Enabled = false;
                    X++;

                    
                }
                else if (count == 8)
                {
                    MessageBox.Show("DRAW!!!");
                    draw++;
                }
                player = 'o';
            }
            count++;
        }
    }
}
