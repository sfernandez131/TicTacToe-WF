using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_WF.Properties;

namespace TicTacToe_WF
{
    public partial class Form1 : Form
    {
        public static SoundPlayer Player = new SoundPlayer();
        private PictureBox pictureBox1;
        private Button startButton;

        public Form1()
        {
            InitializeComponent();
            topLeftBtn.Visible = false;
            topMiddleBtn.Visible = false;
            topLeftBtn.Visible = false;
            topRightBtn.Visible = false;
            middleLeftBtn.Visible = false;
            centerBtn.Visible = false;
            middleRightBtn.Visible = false;
            bottomLeftBtn.Visible = false;
            bottomMiddleBtn.Visible = false;
            bottomRightBtn.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayTheme();
        }

        public static void PlayTheme()
        {
            try
            {
                Player.SoundLocation = "theme.wav";
                Player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("bg.png");
            startButton.Visible = false;
            topLeftBtn.Visible = true;
            topMiddleBtn.Visible = true;
            topLeftBtn.Visible = true;
            topRightBtn.Visible = true;
            middleLeftBtn.Visible = true;
            centerBtn.Visible = true;
            middleRightBtn.Visible = true;
            bottomLeftBtn.Visible = true;
            bottomMiddleBtn.Visible = true;
            bottomRightBtn.Visible = true;
            Player.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void topMiddleBtn_Click(object sender, EventArgs e)
        {
        }

        private void topRightBtn_Click(object sender, EventArgs e)
        {
        }

        private void middleRightBtn_Click(object sender, EventArgs e)
        {
        }

        private void centerBtn_Click(object sender, EventArgs e)
        {
        }

        private void bottomMiddleBtn_Click(object sender, EventArgs e)
        {
        }

        private void bottomRightBtn_Click(object sender, EventArgs e)
        {
        }

        private void bottomLeftBtn_Click(object sender, EventArgs e)
        {
        }

        private void middleLeftBtn_Click(object sender, EventArgs e)
        {
        }
    }
}