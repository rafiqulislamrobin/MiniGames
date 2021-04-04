
namespace Battle_Ship
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.Label();
            this.enemy = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.z2 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.u1 = new System.Windows.Forms.Button();
            this.u2 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.u3 = new System.Windows.Forms.Button();
            this.u4 = new System.Windows.Forms.Button();
            this.u5 = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.w5 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x5 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.y5 = new System.Windows.Forms.Button();
            this.z5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.e2 = new System.Windows.Forms.Button();
            this.e3 = new System.Windows.Forms.Button();
            this.e5 = new System.Windows.Forms.Button();
            this.e4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.c5 = new System.Windows.Forms.Button();
            this.d5 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.a5 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.e1 = new System.Windows.Forms.Button();
            this.txtRound = new System.Windows.Forms.Label();
            this.enemyMove = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.enemyLocationListBox = new System.Windows.Forms.ComboBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.enemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player.Location = new System.Drawing.Point(103, 82);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(156, 65);
            this.player.TabIndex = 0;
            this.player.Text = "Player";
            // 
            // enemy
            // 
            this.enemy.AutoSize = true;
            this.enemy.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enemy.Location = new System.Drawing.Point(779, 82);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(168, 65);
            this.enemy.TabIndex = 0;
            this.enemy.Text = "Enemy";
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPlayer.Location = new System.Drawing.Point(265, 97);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(49, 37);
            this.txtPlayer.TabIndex = 1;
            this.txtPlayer.Text = "00";
            // 
            // txtEnemy
            // 
            this.txtEnemy.AutoSize = true;
            this.txtEnemy.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnemy.Location = new System.Drawing.Point(953, 97);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(49, 37);
            this.txtEnemy.TabIndex = 1;
            this.txtEnemy.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(728, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enemy Move";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(34, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter Move";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.z2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.z1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.u1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.u2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.w2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.u3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.u4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.u5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.w1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.w3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.w4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.w5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.x4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.x5, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.x3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.x2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.x1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.y2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.y1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.y3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.z3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.z4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.y4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.y5, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.z5, 4, 4);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 388);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.Color.Maroon;
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z2.ForeColor = System.Drawing.Color.White;
            this.z2.Location = new System.Drawing.Point(111, 311);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(100, 67);
            this.z2.TabIndex = 9;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.Color.Maroon;
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z1.ForeColor = System.Drawing.Color.White;
            this.z1.Location = new System.Drawing.Point(3, 311);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(100, 67);
            this.z1.TabIndex = 8;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // u1
            // 
            this.u1.BackColor = System.Drawing.Color.Maroon;
            this.u1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.u1.ForeColor = System.Drawing.Color.White;
            this.u1.Location = new System.Drawing.Point(3, 3);
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(100, 67);
            this.u1.TabIndex = 7;
            this.u1.Text = "U1";
            this.u1.UseVisualStyleBackColor = false;
            this.u1.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // u2
            // 
            this.u2.BackColor = System.Drawing.Color.Maroon;
            this.u2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.u2.ForeColor = System.Drawing.Color.White;
            this.u2.Location = new System.Drawing.Point(111, 3);
            this.u2.Name = "u2";
            this.u2.Size = new System.Drawing.Size(100, 67);
            this.u2.TabIndex = 7;
            this.u2.Text = "U2";
            this.u2.UseVisualStyleBackColor = false;
            this.u2.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // w2
            // 
            this.w2.BackColor = System.Drawing.Color.Maroon;
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w2.ForeColor = System.Drawing.Color.White;
            this.w2.Location = new System.Drawing.Point(111, 80);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(100, 67);
            this.w2.TabIndex = 7;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = false;
            this.w2.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // u3
            // 
            this.u3.BackColor = System.Drawing.Color.Maroon;
            this.u3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.u3.ForeColor = System.Drawing.Color.White;
            this.u3.Location = new System.Drawing.Point(219, 3);
            this.u3.Name = "u3";
            this.u3.Size = new System.Drawing.Size(100, 67);
            this.u3.TabIndex = 7;
            this.u3.Text = "U3";
            this.u3.UseVisualStyleBackColor = false;
            this.u3.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // u4
            // 
            this.u4.BackColor = System.Drawing.Color.Maroon;
            this.u4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.u4.ForeColor = System.Drawing.Color.White;
            this.u4.Location = new System.Drawing.Point(327, 3);
            this.u4.Name = "u4";
            this.u4.Size = new System.Drawing.Size(100, 67);
            this.u4.TabIndex = 7;
            this.u4.Text = "U4";
            this.u4.UseVisualStyleBackColor = false;
            this.u4.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // u5
            // 
            this.u5.BackColor = System.Drawing.Color.Maroon;
            this.u5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.u5.ForeColor = System.Drawing.Color.White;
            this.u5.Location = new System.Drawing.Point(435, 3);
            this.u5.Name = "u5";
            this.u5.Size = new System.Drawing.Size(100, 67);
            this.u5.TabIndex = 7;
            this.u5.Text = "U5";
            this.u5.UseVisualStyleBackColor = false;
            this.u5.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // w1
            // 
            this.w1.BackColor = System.Drawing.Color.Maroon;
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w1.ForeColor = System.Drawing.Color.White;
            this.w1.Location = new System.Drawing.Point(3, 80);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(100, 67);
            this.w1.TabIndex = 7;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = false;
            this.w1.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // w3
            // 
            this.w3.BackColor = System.Drawing.Color.Maroon;
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w3.ForeColor = System.Drawing.Color.White;
            this.w3.Location = new System.Drawing.Point(219, 80);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(100, 67);
            this.w3.TabIndex = 7;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = false;
            this.w3.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // w4
            // 
            this.w4.BackColor = System.Drawing.Color.Maroon;
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w4.ForeColor = System.Drawing.Color.White;
            this.w4.Location = new System.Drawing.Point(327, 80);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(100, 67);
            this.w4.TabIndex = 7;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = false;
            this.w4.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // w5
            // 
            this.w5.BackColor = System.Drawing.Color.Maroon;
            this.w5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w5.ForeColor = System.Drawing.Color.White;
            this.w5.Location = new System.Drawing.Point(435, 80);
            this.w5.Name = "w5";
            this.w5.Size = new System.Drawing.Size(100, 67);
            this.w5.TabIndex = 7;
            this.w5.Text = "W5";
            this.w5.UseVisualStyleBackColor = false;
            this.w5.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.Color.Maroon;
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x4.ForeColor = System.Drawing.Color.White;
            this.x4.Location = new System.Drawing.Point(327, 157);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(100, 67);
            this.x4.TabIndex = 7;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = false;
            this.x4.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // x5
            // 
            this.x5.BackColor = System.Drawing.Color.Maroon;
            this.x5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x5.ForeColor = System.Drawing.Color.White;
            this.x5.Location = new System.Drawing.Point(435, 157);
            this.x5.Name = "x5";
            this.x5.Size = new System.Drawing.Size(100, 67);
            this.x5.TabIndex = 7;
            this.x5.Text = "X5";
            this.x5.UseVisualStyleBackColor = false;
            this.x5.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.Maroon;
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x3.ForeColor = System.Drawing.Color.White;
            this.x3.Location = new System.Drawing.Point(219, 157);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(100, 67);
            this.x3.TabIndex = 7;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.Maroon;
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x2.ForeColor = System.Drawing.Color.White;
            this.x2.Location = new System.Drawing.Point(111, 157);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 67);
            this.x2.TabIndex = 7;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.Maroon;
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x1.ForeColor = System.Drawing.Color.White;
            this.x1.Location = new System.Drawing.Point(3, 157);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 67);
            this.x1.TabIndex = 7;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.Color.Maroon;
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y2.ForeColor = System.Drawing.Color.White;
            this.y2.Location = new System.Drawing.Point(111, 234);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 67);
            this.y2.TabIndex = 7;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = false;
            this.y2.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.Color.Maroon;
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y1.ForeColor = System.Drawing.Color.White;
            this.y1.Location = new System.Drawing.Point(3, 234);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 67);
            this.y1.TabIndex = 7;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.Color.Maroon;
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y3.ForeColor = System.Drawing.Color.White;
            this.y3.Location = new System.Drawing.Point(219, 234);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(100, 67);
            this.y3.TabIndex = 7;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = false;
            this.y3.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.Color.Maroon;
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z3.ForeColor = System.Drawing.Color.White;
            this.z3.Location = new System.Drawing.Point(219, 311);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(100, 67);
            this.z3.TabIndex = 7;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = false;
            this.z3.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // z4
            // 
            this.z4.BackColor = System.Drawing.Color.Maroon;
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z4.ForeColor = System.Drawing.Color.White;
            this.z4.Location = new System.Drawing.Point(327, 311);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(100, 67);
            this.z4.TabIndex = 7;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = false;
            this.z4.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // y4
            // 
            this.y4.BackColor = System.Drawing.Color.Maroon;
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y4.ForeColor = System.Drawing.Color.White;
            this.y4.Location = new System.Drawing.Point(327, 234);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(100, 67);
            this.y4.TabIndex = 7;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = false;
            this.y4.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // y5
            // 
            this.y5.BackColor = System.Drawing.Color.Maroon;
            this.y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y5.ForeColor = System.Drawing.Color.White;
            this.y5.Location = new System.Drawing.Point(435, 234);
            this.y5.Name = "y5";
            this.y5.Size = new System.Drawing.Size(100, 67);
            this.y5.TabIndex = 7;
            this.y5.Text = "Y5";
            this.y5.UseVisualStyleBackColor = false;
            this.y5.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // z5
            // 
            this.z5.BackColor = System.Drawing.Color.Maroon;
            this.z5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z5.ForeColor = System.Drawing.Color.White;
            this.z5.Location = new System.Drawing.Point(435, 311);
            this.z5.Name = "z5";
            this.z5.Size = new System.Drawing.Size(100, 67);
            this.z5.TabIndex = 7;
            this.z5.Text = "Z5";
            this.z5.UseVisualStyleBackColor = false;
            this.z5.Click += new System.EventHandler(this.playerPositionButtonsEvent);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.e2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.e3, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.e5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.e4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.a1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.a2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.b1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.b2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.c2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.c1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.d2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.d1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.d3, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.c3, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.c4, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.b3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.b4, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.d4, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.c5, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.d5, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.b5, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.a5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.a4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.a3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.e1, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(591, 175);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 388);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // e2
            // 
            this.e2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.e2.Location = new System.Drawing.Point(327, 311);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(100, 67);
            this.e2.TabIndex = 13;
            this.e2.Text = "E2";
            this.e2.UseVisualStyleBackColor = true;
            // 
            // e3
            // 
            this.e3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.e3.Location = new System.Drawing.Point(219, 311);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(100, 67);
            this.e3.TabIndex = 11;
            this.e3.Text = "E3";
            this.e3.UseVisualStyleBackColor = true;
            // 
            // e5
            // 
            this.e5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.e5.Location = new System.Drawing.Point(111, 311);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(100, 67);
            this.e5.TabIndex = 10;
            this.e5.Text = "E5";
            this.e5.UseVisualStyleBackColor = true;
            // 
            // e4
            // 
            this.e4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.e4.Location = new System.Drawing.Point(435, 311);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(100, 67);
            this.e4.TabIndex = 9;
            this.e4.Text = "E4";
            this.e4.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a1.Location = new System.Drawing.Point(3, 3);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(100, 67);
            this.a1.TabIndex = 8;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a2.Location = new System.Drawing.Point(111, 3);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(100, 67);
            this.a2.TabIndex = 8;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(3, 80);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(100, 67);
            this.b1.TabIndex = 8;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(111, 80);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(100, 67);
            this.b2.TabIndex = 8;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c2.Location = new System.Drawing.Point(111, 157);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(100, 67);
            this.c2.TabIndex = 8;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c1.Location = new System.Drawing.Point(3, 157);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(100, 67);
            this.c1.TabIndex = 8;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d2.Location = new System.Drawing.Point(111, 234);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(100, 67);
            this.d2.TabIndex = 8;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d1.Location = new System.Drawing.Point(3, 234);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(100, 67);
            this.d1.TabIndex = 8;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d3.Location = new System.Drawing.Point(219, 234);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(100, 67);
            this.d3.TabIndex = 8;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c3.Location = new System.Drawing.Point(219, 157);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(100, 67);
            this.c3.TabIndex = 8;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c4.Location = new System.Drawing.Point(327, 157);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(100, 67);
            this.c4.TabIndex = 8;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(219, 80);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(100, 67);
            this.b3.TabIndex = 8;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(327, 80);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(100, 67);
            this.b4.TabIndex = 8;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d4.Location = new System.Drawing.Point(327, 234);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(100, 67);
            this.d4.TabIndex = 8;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // c5
            // 
            this.c5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c5.Location = new System.Drawing.Point(435, 157);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(100, 67);
            this.c5.TabIndex = 8;
            this.c5.Text = "C5";
            this.c5.UseVisualStyleBackColor = true;
            // 
            // d5
            // 
            this.d5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d5.Location = new System.Drawing.Point(435, 234);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(100, 67);
            this.d5.TabIndex = 8;
            this.d5.Text = "D5";
            this.d5.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            this.b5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b5.Location = new System.Drawing.Point(435, 80);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(100, 67);
            this.b5.TabIndex = 8;
            this.b5.Text = "B5";
            this.b5.UseVisualStyleBackColor = true;
            // 
            // a5
            // 
            this.a5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a5.Location = new System.Drawing.Point(435, 3);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(100, 67);
            this.a5.TabIndex = 8;
            this.a5.Text = "A5";
            this.a5.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a4.Location = new System.Drawing.Point(327, 3);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(100, 67);
            this.a4.TabIndex = 8;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a3.Location = new System.Drawing.Point(219, 3);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(100, 67);
            this.a3.TabIndex = 8;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // e1
            // 
            this.e1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.e1.Location = new System.Drawing.Point(3, 311);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(100, 67);
            this.e1.TabIndex = 12;
            this.e1.Text = "E1";
            this.e1.UseVisualStyleBackColor = true;
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRound.Location = new System.Drawing.Point(505, 128);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(114, 30);
            this.txtRound.TabIndex = 1;
            this.txtRound.Text = "Round: 20";
            // 
            // enemyMove
            // 
            this.enemyMove.AutoSize = true;
            this.enemyMove.BackColor = System.Drawing.Color.LightCoral;
            this.enemyMove.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyMove.ForeColor = System.Drawing.Color.Navy;
            this.enemyMove.Location = new System.Drawing.Point(895, 21);
            this.enemyMove.Name = "enemyMove";
            this.enemyMove.Size = new System.Drawing.Size(52, 37);
            this.enemyMove.TabIndex = 1;
            this.enemyMove.Text = "A1";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoSize = true;
            this.txtHelp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHelp.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtHelp.Location = new System.Drawing.Point(337, 590);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(465, 25);
            this.txtHelp.TabIndex = 1;
            this.txtHelp.Text = "1) Click on 3 different loaction from above to start ";
            // 
            // enemyLocationListBox
            // 
            this.enemyLocationListBox.BackColor = System.Drawing.Color.LightCoral;
            this.enemyLocationListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyLocationListBox.DropDownWidth = 95;
            this.enemyLocationListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyLocationListBox.FormattingEnabled = true;
            this.enemyLocationListBox.Location = new System.Drawing.Point(180, 24);
            this.enemyLocationListBox.Name = "enemyLocationListBox";
            this.enemyLocationListBox.Size = new System.Drawing.Size(100, 38);
            this.enemyLocationListBox.TabIndex = 5;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAttack.Location = new System.Drawing.Point(286, 24);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(111, 38);
            this.buttonAttack.TabIndex = 6;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.attackButtonEvent);
            // 
            // enemyPlayTimer
            // 
            this.enemyPlayTimer.Interval = 1000;
            this.enemyPlayTimer.Tick += new System.EventHandler(this.enemyPlayTimerEvent);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1144, 711);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.enemyLocationListBox);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.enemyMove);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player);
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "Battle Ship";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label enemy;
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label txtRound;
        private System.Windows.Forms.Label enemyMove;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.ComboBox enemyLocationListBox;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button u1;
        private System.Windows.Forms.Button u2;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button u3;
        private System.Windows.Forms.Button u4;
        private System.Windows.Forms.Button u5;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button w5;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x5;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button y5;
        private System.Windows.Forms.Button z5;
        private System.Windows.Forms.Button e2;
        private System.Windows.Forms.Button e1;
        private System.Windows.Forms.Button e3;
        private System.Windows.Forms.Button e5;
        private System.Windows.Forms.Button e4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button c5;
        private System.Windows.Forms.Button d5;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button a5;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Timer enemyPlayTimer;
    }
}

