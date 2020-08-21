using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using static TicTacToe_WF.Player;
using static TicTacToe_WF.VirtualBoard;
using System.Media;

namespace TicTacToe_WF
{
    partial class Form1
    {
        public static int turn = 0;
        public static bool[] buttons = new bool[9]
        {
            false, false, false, false, false, false, false, false, false
        };
        public static Actions actions = new Actions();
        private static Image image1 = Image.FromFile("X.png");
        private static Image image2 = Image.FromFile("O.png");
        public static Player player1 = new Player(image1, 0, false);
        public static Player player2 = new Player(image2, 0, false);

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.topLeftBtn = new System.Windows.Forms.Button();
            this.topMiddleBtn = new System.Windows.Forms.Button();
            this.topRightBtn = new System.Windows.Forms.Button();
            this.middleRightBtn = new System.Windows.Forms.Button();
            this.bottomRightBtn = new System.Windows.Forms.Button();
            this.bottomMiddleBtn = new System.Windows.Forms.Button();
            this.centerBtn = new System.Windows.Forms.Button();
            this.middleLeftBtn = new System.Windows.Forms.Button();
            this.bottomLeftBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "topLeftBtn";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.OliveDrab;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.startButton.FlatAppearance.BorderSize = 5;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.Blue;
            this.startButton.Location = new System.Drawing.Point(330, 261);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // topLeftBtn
            // 
            this.topLeftBtn.BackColor = System.Drawing.Color.Black;
            this.topLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topLeftBtn.FlatAppearance.BorderSize = 0;
            this.topLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topLeftBtn.Location = new System.Drawing.Point(48, 40);
            this.topLeftBtn.Name = "topLeftBtn";
            this.topLeftBtn.Size = new System.Drawing.Size(155, 144);
            this.topLeftBtn.TabIndex = 2;
            this.topLeftBtn.Tag = "topLeftBtn";
            this.topLeftBtn.UseVisualStyleBackColor = false;
            this.topLeftBtn.Click += new System.EventHandler(this.topLeftBtn_Click);
            // 
            // topMiddleBtn
            // 
            this.topMiddleBtn.BackColor = System.Drawing.Color.Black;
            this.topMiddleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topMiddleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topMiddleBtn.Location = new System.Drawing.Point(209, 40);
            this.topMiddleBtn.Name = "topMiddleBtn";
            this.topMiddleBtn.Size = new System.Drawing.Size(313, 144);
            this.topMiddleBtn.TabIndex = 3;
            this.topMiddleBtn.UseVisualStyleBackColor = false;
            this.topMiddleBtn.Click += new System.EventHandler(this.topMiddleBtn_Click);
            // 
            // topRightBtn
            // 
            this.topRightBtn.BackColor = System.Drawing.Color.Black;
            this.topRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topRightBtn.Location = new System.Drawing.Point(537, 40);
            this.topRightBtn.Name = "topRightBtn";
            this.topRightBtn.Size = new System.Drawing.Size(168, 144);
            this.topRightBtn.TabIndex = 4;
            this.topRightBtn.UseVisualStyleBackColor = false;
            this.topRightBtn.Click += new System.EventHandler(this.topRightBtn_Click);
            // 
            // middleRightBtn
            // 
            this.middleRightBtn.BackColor = System.Drawing.Color.Black;
            this.middleRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.middleRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleRightBtn.Location = new System.Drawing.Point(537, 199);
            this.middleRightBtn.Name = "middleRightBtn";
            this.middleRightBtn.Size = new System.Drawing.Size(168, 136);
            this.middleRightBtn.TabIndex = 5;
            this.middleRightBtn.UseVisualStyleBackColor = false;
            this.middleRightBtn.Click += new System.EventHandler(this.middleRightBtn_Click);
            // 
            // bottomRightBtn
            // 
            this.bottomRightBtn.BackColor = System.Drawing.Color.Black;
            this.bottomRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bottomRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomRightBtn.Location = new System.Drawing.Point(537, 362);
            this.bottomRightBtn.Name = "bottomRightBtn";
            this.bottomRightBtn.Size = new System.Drawing.Size(168, 117);
            this.bottomRightBtn.TabIndex = 7;
            this.bottomRightBtn.UseVisualStyleBackColor = false;
            this.bottomRightBtn.Click += new System.EventHandler(this.bottomRightBtn_Click);
            // 
            // bottomMiddleBtn
            // 
            this.bottomMiddleBtn.BackColor = System.Drawing.Color.Black;
            this.bottomMiddleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bottomMiddleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomMiddleBtn.Location = new System.Drawing.Point(209, 362);
            this.bottomMiddleBtn.Name = "bottomMiddleBtn";
            this.bottomMiddleBtn.Size = new System.Drawing.Size(313, 117);
            this.bottomMiddleBtn.TabIndex = 8;
            this.bottomMiddleBtn.UseVisualStyleBackColor = false;
            this.bottomMiddleBtn.Click += new System.EventHandler(this.bottomMiddleBtn_Click);
            // 
            // centerBtn
            // 
            this.centerBtn.BackColor = System.Drawing.Color.Black;
            this.centerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.centerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centerBtn.Location = new System.Drawing.Point(209, 199);
            this.centerBtn.Name = "centerBtn";
            this.centerBtn.Size = new System.Drawing.Size(313, 145);
            this.centerBtn.TabIndex = 9;
            this.centerBtn.UseVisualStyleBackColor = false;
            this.centerBtn.Click += new System.EventHandler(this.centerBtn_Click);
            // 
            // middleLeftBtn
            // 
            this.middleLeftBtn.BackColor = System.Drawing.Color.Black;
            this.middleLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.middleLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleLeftBtn.Location = new System.Drawing.Point(48, 199);
            this.middleLeftBtn.Name = "middleLeftBtn";
            this.middleLeftBtn.Size = new System.Drawing.Size(155, 145);
            this.middleLeftBtn.TabIndex = 10;
            this.middleLeftBtn.UseVisualStyleBackColor = false;
            this.middleLeftBtn.Click += new System.EventHandler(this.middleLeftBtn_Click);
            // 
            // bottomLeftBtn
            // 
            this.bottomLeftBtn.BackColor = System.Drawing.Color.Black;
            this.bottomLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bottomLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomLeftBtn.Location = new System.Drawing.Point(48, 362);
            this.bottomLeftBtn.Name = "bottomLeftBtn";
            this.bottomLeftBtn.Size = new System.Drawing.Size(155, 105);
            this.bottomLeftBtn.TabIndex = 11;
            this.bottomLeftBtn.UseVisualStyleBackColor = false;
            this.bottomLeftBtn.Click += new System.EventHandler(this.bottomLeftBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(755, 553);
            this.Controls.Add(this.bottomLeftBtn);
            this.Controls.Add(this.middleLeftBtn);
            this.Controls.Add(this.centerBtn);
            this.Controls.Add(this.bottomMiddleBtn);
            this.Controls.Add(this.bottomRightBtn);
            this.Controls.Add(this.middleRightBtn);
            this.Controls.Add(this.topRightBtn);
            this.Controls.Add(this.topMiddleBtn);
            this.Controls.Add(this.topLeftBtn);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(773, 600);
            this.MinimumSize = new System.Drawing.Size(773, 600);
            this.Name = "Form1";
            this.Text = "TicTacToe-WF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bottomRightBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            if (!vBoard[0, 2, 0])
            {
                string str = "bottomRightBtn";

                buttons[8] = true;

                bottomRightBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        private void bottomMiddleBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            if (!vBoard[0, 1, 0])
            {
                string str = "bottomMiddleBtn";

                buttons[7] = true;

                bottomMiddleBtn.BackgroundImageLayout = ImageLayout.Center;
                bottomMiddleBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        public void bottomLeftBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            //var v = vBoard[0, 0, 0];
            if (!vBoard[0, 0, 0])
            {
                string str = "bottomLeftBtn";

                buttons[6] = true;

                bottomLeftBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        private void middleRightBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            if (!vBoard[1, 2, 0])
            {
                string str = "middleRightBtn";

                buttons[5] = true;

                middleRightBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        private void centerBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            if (!vBoard[1, 1, 0])
            {
                string str = "centerBtn";

                buttons[4] = true;

                centerBtn.BackgroundImageLayout = ImageLayout.Center;
                centerBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        private void middleLeftBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            if (!vBoard[1, 0, 0])
            {
                string str = "middleLeftBtn";

                buttons[3] = true;

                middleLeftBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        private void topRightBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            if (!vBoard[2, 2, 0])
            {
                string str = "topRightBtn";

                buttons[2] = true;

                topRightBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        private void topMiddleBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
            if (!vBoard[2, 1, 0])
            {
                string str = "topMiddleBtn";

                buttons[1] = true;

                topMiddleBtn.BackgroundImageLayout = ImageLayout.Center;
                topMiddleBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        private void topLeftBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();


            if (!vBoard[2, 0, 0])
            {
                string str = "topLeftBtn";

                buttons[0] = true;

                topLeftBtn.BackgroundImage = Program.ExecuteAction(str);
            }
            else
            {
                MessageBox.Show("Space occupied!");
            }
        }

        public static void EndConditon(Player p1, Player p2)
        {
            bool bitX = XCounter(p1);
            bool bitO = OCounter(p2);

            if (bitX)
            {
                MessageBox.Show("Player One Wins!!!", "Game Over", MessageBoxButtons.OK);
                Environment.Exit(0);
            }

            if (bitO)
            {
                MessageBox.Show("Player Two Wins!!!", "Game Over", MessageBoxButtons.OK);
                Environment.Exit(0);
            }

            if (buttons.All(a => a == true) && !bitX && !bitO)
            {
                MessageBox.Show("DRAW!", "Game Over", MessageBoxButtons.OK);
                Environment.Exit(0);
            }
            turn++;
        }

        public static bool XCounter(Player player1)
        {
            // Virtical left win

            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[0,0,1] == 'X' && vBoard[1,0,1] == 'X' && vBoard[2,0,1] == 'X')
            {
                return true;
            }

            // Virtical mid win

            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[0, 1, 1] == 'X' && vBoard[1, 1, 1] == 'X' && vBoard[2, 1, 1] == 'X')
            {
                return true;
            }

            // Virtical right win

            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[0, 2, 1] == 'X' && vBoard[1, 2, 1] == 'X' && vBoard[2, 2, 1] == 'X')
            {
                return true;
            }

            // Horizontal top win

            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[2, 0, 1] == 'X' && vBoard[2, 1, 1] == 'X' && vBoard[2, 2, 1] == 'X')
            {
                return true;
            }

            // Horizontal mid win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[1, 0, 1] == 'X' && vBoard[1, 1, 1] == 'X' && vBoard[1, 2, 1] == 'X')
            {
                return true;
            }

            // Horizontal bottom win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[0, 0, 1] == 'X' && vBoard[0, 1, 1] == 'X' && vBoard[0, 2, 1] == 'X')
            {
                return true;
            }

            // First Diagonal win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[2, 0, 1] == 'X' && vBoard[1, 1, 1] == 'X' && vBoard[0, 2, 1] == 'X')
            {
                return true;
            }

            // Second Diagonal win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[0, 0, 1] == 'X' && vBoard[1, 1, 1] == 'X' && vBoard[2, 2, 1] == 'X')
            {
                return true;
            }
            return false;
        }

        public static bool OCounter(Player player2)
        {
            // Virtical left win
            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[0, 0, 1] == 'O' && vBoard[1, 0, 1] == 'O' && vBoard[2, 0, 1] == 'O')
            {
                return true;
            }

            // Virtical mid win

            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[0, 1, 1] == 'O' && vBoard[1, 1, 1] == 'O' && vBoard[2, 1, 1] == 'O')
            {
                return true;
            }

            // Virtical right win

            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[0, 2, 1] == 'O' && vBoard[1, 2, 1] == 'O' && vBoard[2, 2, 1] == 'O')
            {
                return true;
            }

            // Horizontal top win

            //var x = vBoard[0, 0, 1];
            //var x1 = vBoard[1, 0, 1];
            //var x2 = vBoard[2, 0, 1];
            if (vBoard[2, 0, 1] == 'O' && vBoard[2, 1, 1] == 'O' && vBoard[2, 2, 1] == 'O')
            {
                return true;
            }

            // Horizontal mid win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[1, 0, 1] == 'O' && vBoard[1, 1, 1] == 'O' && vBoard[1, 2, 1] == 'O')
            {
                return true;
            }

            // Horizontal bottom win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[0, 0, 1] == 'O' && vBoard[0, 1, 1] == 'O' && vBoard[0, 2, 1] == 'O')
            {
                return true;
            }

            // First Diagonal win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[2, 0, 1] == 'O' && vBoard[1, 1, 1] == 'O' && vBoard[0, 2, 1] == 'O')
            {
                return true;
            }

            // Second Diagonal win

            //var x = vBoard[1, 0, 1];
            //var x1 = vBoard[1, 1, 1];
            //var x2 = vBoard[1, 2, 1];
            if (vBoard[0, 0, 1] == 'O' && vBoard[1, 1, 1] == 'O' && vBoard[2, 2, 1] == 'O')
            {
                return true;
            }
            return false;
        }

        public static Image ExecuteAction(string btnPressed)
        {
            
            Image image = Image.FromFile("empty.png");
            actions.playerTookAction = true;
            actions.buttonLocationPressed = btnPressed;
            
            int lastPlayed = actions.player;

            if (lastPlayed == 1)
            {
                actions.player = 2;
            }
            else if (lastPlayed == 2)
            {
                actions.player = 1;
            }
            else if (lastPlayed == 0)
            {
                actions.player = 1;
            }

            switch (btnPressed)
            {
                case "bottomLeftBtn":
                    if (actions.player == 1)
                    {
                        vBoard[0, 0, 0] = true;
                        vBoard[0, 0, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[0, 0, 0] = true;
                        vBoard[0, 0, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;

                case "middleLeftBtn":
                    if (actions.player == 1)
                    {
                        vBoard[1, 0, 0] = true;
                        vBoard[1, 0, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[1, 0, 0] = true;
                        vBoard[1, 0, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;

                case "topLeftBtn":
                    if (actions.player == 1)
                    {
                        vBoard[2, 0, 0] = true;
                        vBoard[2, 0, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[2, 0, 0] = true;
                        vBoard[2, 0, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;

                case "topMiddleBtn":
                    if (actions.player == 1)
                    {
                        vBoard[2, 1, 0] = true;
                        vBoard[2, 1, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[2, 1, 0] = true;
                        vBoard[2, 1, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;
                case "centerBtn":
                    if (actions.player == 1)
                    {
                        vBoard[1, 1, 0] = true;
                        vBoard[1, 1, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[1, 1, 0] = true;
                        vBoard[1, 1, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;
                case "bottomMiddleBtn":
                    if (actions.player == 1)
                    {
                        vBoard[0, 1, 0] = true;
                        vBoard[0, 1, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[0, 1, 0] = true;
                        vBoard[0, 1, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;

                case "bottomRightBtn":
                    if (actions.player == 1)
                    {
                        vBoard[0, 2, 0] = true;
                        vBoard[0, 2, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[0, 2, 0] = true;
                        vBoard[0, 2, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;
                case "middleRightBtn":
                    if (actions.player == 1)
                    {
                        vBoard[1, 2, 0] = true;
                        vBoard[1, 2, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[1, 2, 0] = true;
                        vBoard[1, 2, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;
                case "topRightBtn":
                    if (actions.player == 1)
                    {
                        vBoard[2, 2, 0] = true;
                        vBoard[2, 2, 1] = 'X';
                        image = Image.FromFile("X.png");
                    }
                    else if (actions.player == 2)
                    {
                        vBoard[2, 2, 0] = true;
                        vBoard[2, 2, 1] = 'O';
                        image = Image.FromFile("O.png");
                    }
                    break;
            }
            EndConditon(Program.player1, Program.player2);
            return image;
        }

        public static void AI()
        {
            BoardScan[] scan = new BoardScan[]
            {
                // Bottom Row
                new BoardScan()
                {
                    // 1a
                    occ = vBoard[0,0,0],
                    playerTile = vBoard[0,0,1],
                    id = 1
                },

                new BoardScan()
                {
                    // 2a
                    occ = vBoard[0,1,0],
                    playerTile = vBoard[0,1,1],
                    id = 2
                },

                new BoardScan()
                {
                    // 3a
                    occ = vBoard[0,2,0],
                    playerTile = vBoard[0,2,1],
                    id = 3
                },

                // Middle Row
                new BoardScan()
                {
                    // 1b
                    occ = vBoard[1,0,0],
                    playerTile = vBoard[1,0,1],
                    id = 4
                },

                new BoardScan()
                {
                    // 2b
                    occ = vBoard[1,1,0],
                    playerTile = vBoard[1,1,1],
                    id = 5
                },

                new BoardScan()
                {
                    // 3b
                    occ = vBoard[1,2,0],
                    playerTile = vBoard[1,2,1],
                    id = 6
                },

                // Top Row
                new BoardScan()
                {
                    // 1c
                    occ = vBoard[2,0,0],
                    playerTile = vBoard[2,0,1],
                    id = 7
                },

                new BoardScan()
                {
                    // 2c
                    occ = vBoard[2,1,0],
                    playerTile = vBoard[2,1,1],
                    id = 8
                },

                new BoardScan()
                {
                    // 3c
                    occ = vBoard[2,2,0],
                    playerTile = vBoard[2,2,1],
                    id = 9
                },
            };
            
        }

        #endregion
    }

    /// This class represents a static evaluation function for Tic-Tac-Toe
    /// The value is computed by summing number of game pieces in the rows, columns, and diagonals 
    /// for those rows, columns and diagonals that are still winnable
    /// </summary>
    public class EvaluationFunction
    {

        //public EvaluationFunction()
        //{
        //}

        ///// <summary>
        ///// Evaluates the favorability of the current board configuration for maxPiece.  Higher values
        ///// indicate better configuration for maxPiece
        ///// </summary>
        ///// <param name="b">the game board to evaluate</param>
        ///// <param name="maxPiece">the piece representing MAX</param>
        ///// <returns></returns>
        //public double Evaluate(Board b, Board.Pieces maxPiece)
        //{

        //    if (b.HasWinner())
        //    {
        //        if (b.WinningPiece == maxPiece)
        //            return double.MaxValue;
        //        else
        //            return double.MinValue;
        //    }

        //    double maxValue = EvaluatePiece(b, maxPiece);
        //    double minValue = EvaluatePiece(b, Board.GetOponentPiece(maxPiece));

        //    return maxValue - minValue;

        //}

        //// sums up all the possible ways to win for the specified board piece
        //private double EvaluatePiece(Board b, Board.Pieces p)
        //{

        //    return EvaluateRows(b, p) + EvaluateColumns(b, p) + EvaluateDiagonals(b, p);
        //}

        //// over all rows sums the number of pieces in the row if 
        //// the specified piece can still win in that row i.e. the row
        //// does not contain an opponent's piece
        //private double EvaluateRows(Board b, Board.Pieces p)
        //{

        //    int cols = b.Columns;
        //    int rows = b.Rows;

        //    double score = 0.0;
        //    int count;
        //    // check the rows
        //    for (int i = 0; i < b.Rows; i++)
        //    {
        //        count = 0;
        //        bool rowClean = true;
        //        for (int j = 0; j < b.Columns; j++)
        //        {
        //            Board.Pieces boardPiece = b.GetPieceAtPoint(i, j);

        //            if (boardPiece == p)
        //                count++;
        //            else if (boardPiece == Board.GetOponentPiece(p))
        //            {
        //                rowClean = false;
        //                break;
        //            }
        //        }

        //        // if we get here then the row is clean (an open row)
        //        if (rowClean && count != 0)
        //            score += count;
        //    }

        //    return score;
        //}

        //// over all rows sums the number of pieces in the row if 
        //// the specified piece can still win in that row i.e. the row
        //// does not contain an opponent's piece
        //private double EvaluateColumns(Board b, Board.Pieces p)
        //{
        //    int cols = b.Columns;
        //    int rows = b.Rows;

        //    double score = 0.0;
        //    int count;
        //    // check the rows
        //    for (int j = 0; j < b.Columns; j++)
        //    {
        //        count = 0;
        //        bool rowClean = true;
        //        for (int i = 0; i < b.Columns; i++)
        //        {
        //            Board.Pieces boardPiece = b.GetPieceAtPoint(i, j);

        //            if (boardPiece == p)
        //                count++;
        //            else if (boardPiece == Board.GetOponentPiece(p))
        //            {
        //                rowClean = false;
        //                break;
        //            }
        //        }

        //        // if we get here then the row is clean (an open row)
        //        if (rowClean && count != 0)
        //            score += count; //Math.Pow(count, count);

        //    }

        //    return score;
        //}

        //// over both diagonals sums the number of pieces in the diagonal if 
        //// the specified piece can still win in that diagonal i.e. the diagonal
        //// does not contain an opponent's piece
        //private double EvaluateDiagonals(Board b, Board.Pieces p)
        //{
        //    // go down and to the right diagonal first
        //    int count = 0;
        //    bool diagonalClean = true;

        //    double score = 0.0;

        //    for (int i = 0; i < b.Columns; i++)
        //    {
        //        Board.Pieces boardPiece = b.GetPieceAtPoint(i, i);

        //        if (boardPiece == p)
        //            count++;

        //        if (boardPiece == Board.GetOponentPiece(p))
        //        {
        //            diagonalClean = false;
        //            break;
        //        }
        //    }

        //    if (diagonalClean && count > 0)
        //        score += count;// Math.Pow(count, count);

        //    // now try the other way

        //    int row = 0;
        //    int col = 2;
        //    count = 0;
        //    diagonalClean = true;

        //    while (row < b.Rows && col >= 0)
        //    {
        //        Board.Pieces boardPiece = b.GetPieceAtPoint(row, col);

        //        if (boardPiece == p)
        //            count++;

        //        if (boardPiece == Board.GetOponentPiece(p))
        //        {
        //            diagonalClean = false;
        //            break;
        //        }

        //        row++;
        //        col--;
        //    }

        //    if (count > 0 && diagonalClean)
        //        score += count;

        //    return score;
        //}
    }

    public class BoardScan
    {
        public bool occ { get; set; }
        public char playerTile { get; set; }
        public int id { get; set; }
    }

    public class Player
    {
        public bool hasPlayed;
        public Image image;
        public int rowCount;

        public Player(Image image, int rowCount, bool hasPlayed)
        {
            image = this.image;
            hasPlayed = this.hasPlayed;
            rowCount = this.rowCount;
        }

        public class Actions
        {
            public bool playerTookAction = false;
            public string buttonLocationPressed { get; set; }
            public int player = 0;
        }
    }



}

