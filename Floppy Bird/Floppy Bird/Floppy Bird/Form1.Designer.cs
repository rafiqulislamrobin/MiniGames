
namespace Floppy_Bird
{
    partial class Form1
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
            this.FloppyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.FloppyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloppyBird
            // 
            this.FloppyBird.Image = global::Floppy_Bird.Properties.Resources.flappyBird1;
            this.FloppyBird.Location = new System.Drawing.Point(12, 326);
            this.FloppyBird.Name = "FloppyBird";
            this.FloppyBird.Size = new System.Drawing.Size(71, 44);
            this.FloppyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FloppyBird.TabIndex = 0;
            this.FloppyBird.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.Image = global::Floppy_Bird.Properties.Resources.pipeBottom1;
            this.pipeBottom1.Location = new System.Drawing.Point(728, 342);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(76, 262);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 1;
            this.pipeBottom1.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::Floppy_Bird.Properties.Resources.pipeTop2;
            this.pipeTop2.Location = new System.Drawing.Point(1103, -8);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(76, 225);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 2;
            this.pipeTop2.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = global::Floppy_Bird.Properties.Resources.pipeTop1;
            this.pipeTop1.Location = new System.Drawing.Point(473, 1);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(76, 216);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 3;
            this.pipeTop1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Floppy_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 569);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1467, 75);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.Image = global::Floppy_Bird.Properties.Resources.pipeBottom2;
            this.pipeBottom2.Location = new System.Drawing.Point(1303, 342);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(76, 236);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 5;
            this.pipeBottom2.TabStop = false;
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.BackColor = System.Drawing.Color.Black;
            this.scoreTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreTxt.Location = new System.Drawing.Point(664, 615);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(82, 27);
            this.scoreTxt.TabIndex = 6;
            this.scoreTxt.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 615);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1449, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Start);
            // 
            // StartMenu
            // 
            this.StartMenu.BackColor = System.Drawing.Color.Black;
            this.StartMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartMenu.ForeColor = System.Drawing.Color.White;
            this.StartMenu.Name = "StartMenu";
            this.StartMenu.Size = new System.Drawing.Size(57, 25);
            this.StartMenu.Text = "Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1449, 644);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.FloppyBird);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.pipeBottom2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1465, 683);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1465, 683);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floppy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.FloppyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FloppyBird;
        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StartMenu;
    }
}

