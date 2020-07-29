using System.Windows.Forms;

namespace TicTacToe_WF
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
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "topLeftBtn";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.topLeftBtn.FlatAppearance.BorderSize = 0;
            this.topLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topLeftBtn.Location = new System.Drawing.Point(48, 40);
            this.topLeftBtn.Name = "topLeftBtn";
            this.topLeftBtn.Size = new System.Drawing.Size(155, 144);
            this.topLeftBtn.TabIndex = 2;
            this.topLeftBtn.Tag = "topLeftBtn";
            this.topLeftBtn.UseVisualStyleBackColor = false;
            this.topLeftBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // topMiddleBtn
            // 
            this.topMiddleBtn.BackColor = System.Drawing.Color.Black;
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
            this.topRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topRightBtn.Location = new System.Drawing.Point(528, 40);
            this.topRightBtn.Name = "topRightBtn";
            this.topRightBtn.Size = new System.Drawing.Size(168, 144);
            this.topRightBtn.TabIndex = 4;
            this.topRightBtn.UseVisualStyleBackColor = false;
            this.topRightBtn.Click += new System.EventHandler(this.topRightBtn_Click);
            // 
            // middleRightBtn
            // 
            this.middleRightBtn.BackColor = System.Drawing.Color.Black;
            this.middleRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleRightBtn.Location = new System.Drawing.Point(528, 190);
            this.middleRightBtn.Name = "middleRightBtn";
            this.middleRightBtn.Size = new System.Drawing.Size(168, 154);
            this.middleRightBtn.TabIndex = 5;
            this.middleRightBtn.UseVisualStyleBackColor = false;
            this.middleRightBtn.Click += new System.EventHandler(this.middleRightBtn_Click);
            // 
            // bottomRightBtn
            // 
            this.bottomRightBtn.BackColor = System.Drawing.Color.Black;
            this.bottomRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomRightBtn.Location = new System.Drawing.Point(528, 350);
            this.bottomRightBtn.Name = "bottomRightBtn";
            this.bottomRightBtn.Size = new System.Drawing.Size(168, 117);
            this.bottomRightBtn.TabIndex = 7;
            this.bottomRightBtn.Text = "button3";
            this.bottomRightBtn.UseVisualStyleBackColor = false;
            this.bottomRightBtn.Click += new System.EventHandler(this.bottomRightBtn_Click);
            // 
            // bottomMiddleBtn
            // 
            this.bottomMiddleBtn.BackColor = System.Drawing.Color.Black;
            this.bottomMiddleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomMiddleBtn.Location = new System.Drawing.Point(209, 350);
            this.bottomMiddleBtn.Name = "bottomMiddleBtn";
            this.bottomMiddleBtn.Size = new System.Drawing.Size(313, 117);
            this.bottomMiddleBtn.TabIndex = 8;
            this.bottomMiddleBtn.Text = "button4";
            this.bottomMiddleBtn.UseVisualStyleBackColor = false;
            this.bottomMiddleBtn.Click += new System.EventHandler(this.bottomMiddleBtn_Click);
            // 
            // centerBtn
            // 
            this.centerBtn.BackColor = System.Drawing.Color.Black;
            this.centerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centerBtn.Location = new System.Drawing.Point(209, 190);
            this.centerBtn.Name = "centerBtn";
            this.centerBtn.Size = new System.Drawing.Size(313, 154);
            this.centerBtn.TabIndex = 9;
            this.centerBtn.Text = "button5";
            this.centerBtn.UseVisualStyleBackColor = false;
            this.centerBtn.Click += new System.EventHandler(this.centerBtn_Click);
            // 
            // middleLeftBtn
            // 
            this.middleLeftBtn.BackColor = System.Drawing.Color.Black;
            this.middleLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleLeftBtn.Location = new System.Drawing.Point(48, 190);
            this.middleLeftBtn.Name = "middleLeftBtn";
            this.middleLeftBtn.Size = new System.Drawing.Size(155, 154);
            this.middleLeftBtn.TabIndex = 10;
            this.middleLeftBtn.Text = "button6";
            this.middleLeftBtn.UseVisualStyleBackColor = false;
            this.middleLeftBtn.Click += new System.EventHandler(this.middleLeftBtn_Click);
            // 
            // bottomLeftBtn
            // 
            this.bottomLeftBtn.BackColor = System.Drawing.Color.Black;
            this.bottomLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomLeftBtn.Location = new System.Drawing.Point(48, 350);
            this.bottomLeftBtn.Name = "bottomLeftBtn";
            this.bottomLeftBtn.Size = new System.Drawing.Size(155, 117);
            this.bottomLeftBtn.TabIndex = 11;
            this.bottomLeftBtn.UseVisualStyleBackColor = false;
            this.bottomLeftBtn.Click += new System.EventHandler(this.bottomLeftBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(773, 600);
            this.MinimumSize = new System.Drawing.Size(773, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button topLeftBtn;
        private Button topMiddleBtn;
        private Button topRightBtn;
        private Button middleRightBtn;
        private Button bottomRightBtn;
        private Button bottomMiddleBtn;
        private Button centerBtn;
        private Button middleLeftBtn;
        private Button bottomLeftBtn;
    }
}

