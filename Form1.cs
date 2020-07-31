using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace TicTacToe_WF
{
    public partial class Form1 : Form
    {
        public static SoundPlayer Player = new SoundPlayer();
        private PictureBox pictureBox1;
        public Button startButton;
        public Button topLeftBtn;
        public Button topMiddleBtn;
        public Button topRightBtn;
        public Button middleRightBtn;
        public Button bottomRightBtn;
        public Button bottomMiddleBtn;
        public Button centerBtn;
        public Button middleLeftBtn;
        public Button bottomLeftBtn;

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
                Player.SoundLocation = @"C:\Windows\Media\Alarm02.wav";
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
    }
}