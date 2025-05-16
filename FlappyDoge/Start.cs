using System;
using System.Media;
using System.Windows.Forms;

namespace FlappyDoge
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void Guide_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.Show();
        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            Play play = new Play();
            this.Hide();
            play.ShowDialog();
            this.Close();
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
