using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using static System.Windows.Forms.AxHost;

namespace FlappyDoge
{
    public partial class Play : Form
    {

        private bool needOpenSetting = true; // mặc định sẽ mở Setting

        int pipeSpeed = 7; // ForwardSpeed
        int lastSpeedUpScore = 0;
        int gravity = 5; // Gravity speed

        int score = 0;
        bool gameStarted = false;
        Random rand = new Random();

        int Distance2CapPipe = 200;
        int DistanceGiua2Pipe = 170;

        int PipeIndex = 1;
        int PipeDangToi = 1;

        private SoundPlayer jumpsound;

        private string playerName = "";
        private int characterIndex = 0;
        private int mapIndex = 0;

        public Play()
        {
            InitializeComponent();
            Khoitao();
        }

        void Khoitao()
        {
            if (needOpenSetting)
            {
                openSetting(); //Mo lan dau tien
            }

            ShowScoreImage(0);  //Hien thi diem 0

            // BackGround Music
            bkMusic.URL = "Fo4.wav";
            bkMusic.settings.setMode("loop", true);
            bkMusic.Ctlcontrols.play();

            jumpsound = new SoundPlayer("jumpsound.wav"); // Sound nhảy

            // Set cac control lien quan den giao dien
            SetupControl(Doge);
            SetupControl(MusicStatus);
            SetupControl(Nameplayer);
            SetupControl(ptbSetting);
            SetupControl(ScorePanel);
            //SetupControl(Settingptb);
            //SetupControl(Ground);

            PipeIndex = BackgroundImg.Controls.Count;
            PipeDangToi = PipeIndex;
        }

        void SetupControl(Control control)
        {
            control.Parent = BackgroundImg;
            control.BackColor = Color.Transparent;
        }


        private void openSetting()
        {
            Setting settingForm = new Setting();
            var result = settingForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                playerName = settingForm.PlayerNameSetting;
                characterIndex = settingForm.CharacterIndexSetting;
                mapIndex = settingForm.MapIndexSetting;

                ApplySettings();
            }
        }

        private void ApplySettings()
        {
            Nameplayer.Text = playerName;

            switch (mapIndex)
            {
                case 0:
                    BackgroundImg.Image = global::FlappyDoge.Properties.Resources.background;
                    break;
                case 1:
                    BackgroundImg.Image = global::FlappyDoge.Properties.Resources.background_night;
                    break;
            }

            switch (characterIndex)
            {
                case 0:
                    Doge.Image = global::FlappyDoge.Properties.Resources.shiba;
                    break;
                case 1:
                    Doge.Image = global::FlappyDoge.Properties.Resources.shiba_dark;
                    break;
            }
            CenterDoge();
            bkMusic.URL = "Fo4.wav";
            bkMusic.settings.setMode("loop", true);
            bkMusic.Ctlcontrols.play();
        }

        private void CenterDoge()
        {
            int centerX = (this.ClientSize.Width - Doge.Width) / 4;
            int centerY = (this.ClientSize.Height - Doge.Height) / 2;
            Doge.Location = new Point(centerX, centerY);
        }

        private void CenterScorePanel()
        {
            int centerX = (this.ClientSize.Width - ScorePanel.Width) / 2;
            int topY = this.ClientSize.Height / 6;
            ScorePanel.Location = new Point(centerX, topY);
        }

        private void ShowScoreImage(int score)
        {
            ScorePanel.Controls.Clear();

            string scoreStr = score.ToString();
            foreach (char digitChar in scoreStr)
            {
                int digit = digitChar - '0';

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.AutoSize;

                try
                {
                    //Lấy hình từ Resources theo số
                    if (digit == 0) { pb.Image = global::FlappyDoge.Properties.Resources.num0; }
                    if (digit == 1) { pb.Image = global::FlappyDoge.Properties.Resources.num1; }
                    if (digit == 2) { pb.Image = global::FlappyDoge.Properties.Resources.num2; }
                    if (digit == 3) { pb.Image = global::FlappyDoge.Properties.Resources.num3; }
                    if (digit == 4) { pb.Image = global::FlappyDoge.Properties.Resources.num4; }
                    if (digit == 5) { pb.Image = global::FlappyDoge.Properties.Resources.num5; }
                    if (digit == 6) { pb.Image = global::FlappyDoge.Properties.Resources.num6; }
                    if (digit == 7) { pb.Image = global::FlappyDoge.Properties.Resources.num7; }
                    if (digit == 8) { pb.Image = global::FlappyDoge.Properties.Resources.num8; }
                    if (digit == 9) { pb.Image = global::FlappyDoge.Properties.Resources.num9; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy hình ảnh: " + ex.Message);
                }

                ScorePanel.Controls.Add(pb);
            }

            int x = 0;
            foreach (Control control in ScorePanel.Controls)
            {
                control.Location = new Point(x, 0);
                x += control.Width;
            }

            CenterScorePanel();
        }

        void ThemPipe()
        {
            int holeY = rand.Next(100, 300);

            int lastIndex = BackgroundImg.Controls.Count - 1;
            int lastX = BackgroundImg.Controls[lastIndex].Location.X;
            int lastWidth = BackgroundImg.Controls[lastIndex].Width;

            int newPipeX = lastX + lastWidth + Distance2CapPipe;

            // Pipe top
            PictureBox topPipe = new PictureBox
            {
                Image = global::FlappyDoge.Properties.Resources.pipe,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent,
                Location = new Point(newPipeX, holeY - global::FlappyDoge.Properties.Resources.pipe.Height)
            };
            topPipe.BringToFront();
            BackgroundImg.Controls.Add(topPipe);

            // Pipe bot
            PictureBox botPipe = new PictureBox
            {
                Image = global::FlappyDoge.Properties.Resources.pipe,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent,
                Location = new Point(newPipeX, holeY + DistanceGiua2Pipe)
            };
            botPipe.BringToFront();
            BackgroundImg.Controls.Add(botPipe);
        }


        private void ThemPipe(int Dis)
        {
            int holeY = rand.Next(100, 300);

            // Pipe top
            PictureBox topPipe = new PictureBox
            {
                Image = global::FlappyDoge.Properties.Resources.pipe,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent,
                Location = new Point(Dis, holeY - global::FlappyDoge.Properties.Resources.pipe.Height)
            };
            topPipe.BringToFront();
            BackgroundImg.Controls.Add(topPipe);

            // Pipe bot
            PictureBox botPipe = new PictureBox
            {
                Image = global::FlappyDoge.Properties.Resources.pipe,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent,
                Location = new Point(Dis, holeY + DistanceGiua2Pipe)
            };
            botPipe.BringToFront();
            BackgroundImg.Controls.Add(botPipe);
        }


        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                return;
            }
            Doge.Top += gravity;

            int count = BackgroundImg.Controls.Count;
            for (int i = PipeIndex; i < count; i++)
            {

                BackgroundImg.Controls[i].Left -= pipeSpeed;
            }

            if (count <= PipeIndex)
            {
                ThemPipe(BackgroundImg.Width + 300);
            }
            else
            {
                var lastPipeBounds = BackgroundImg.Controls[count - 1].Bounds;
                int lastPipeRightEdge = lastPipeBounds.X + lastPipeBounds.Width;

                if (BackgroundImg.Width - lastPipeRightEdge > Distance2CapPipe)
                {
                    ThemPipe();
                }
            }

            var firstPipeBounds = BackgroundImg.Controls[PipeIndex].Bounds;
            int firstPipeRightEdge = firstPipeBounds.X + firstPipeBounds.Width;

            if (firstPipeRightEdge <= 0)
            {
                BackgroundImg.Controls.RemoveAt(PipeIndex); // Xoa top pipe
                BackgroundImg.Controls.RemoveAt(PipeIndex); // Xoa bot pipe
                PipeDangToi -= 2;
            }


            //Diem
            count = BackgroundImg.Controls.Count;
            if (PipeDangToi < count)
            {
                var DistancePipeDangToi = BackgroundImg.Controls[PipeDangToi].Bounds;

                if (DistancePipeDangToi.X <= Doge.Bounds.X)
                {
                    score++;
                    ScorePanel.BringToFront();
                    ShowScoreImage(score);
                    PipeDangToi += 2;
                }
            }

            // Endgame
            count = BackgroundImg.Controls.Count;
            for (int i = PipeIndex; i < count; i++)
            {
                var pipeBounds = BackgroundImg.Controls[i].Bounds;

                if (pipeBounds.IntersectsWith(Doge.Bounds) || Doge.Bounds.IntersectsWith(Ground.Bounds))
                {
                    this.Focus();
                    endGame();
                    break;
                }
            }

            if (score % 5 == 0 && score > 0 && score != lastSpeedUpScore)
            {
                pipeSpeed += 1;
                lastSpeedUpScore = score;
            }

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!gameStarted)
                {
                    // Xóa các ống cũ
                    while (BackgroundImg.Controls.Count > PipeIndex)
                    {
                        BackgroundImg.Controls.RemoveAt(PipeIndex);
                    }

                    PipeDangToi = PipeIndex;
                    score = 0;
                    ShowScoreImage(score);
                    GameTimer.Start();
                    gameStarted = true;
                }
                ptbSetting.Visible = false;
                jumpsound.Play();
                Doge.Top -= 65;
            }
            else if (e.KeyCode == Keys.M)
            {
                bkMusic.settings.mute = !bkMusic.settings.mute;

                MusicStatus.Image = bkMusic.settings.mute
                    ? global::FlappyDoge.Properties.Resources.musicoff
                    : global::FlappyDoge.Properties.Resources.sound1;
            }
        }


        private void GameKeyUp(object sender, KeyEventArgs e)
        {
        }

        private void endGame()
        {
            GameTimer.Stop();
            gameStarted = false;
            SaveScoreToTxt();

            this.Hide();
            bkMusic.settings.mute = true;

            Gameover GameoverForm = new Gameover(playerName, characterIndex, mapIndex);
            GameoverForm.ShowDialog();
            GameoverForm.Dispose();

            this.Close();
        }

        public Play(string name, int character, int map)
        {
            playerName = name;
            characterIndex = character;
            mapIndex = map;

            needOpenSetting = false;

            InitializeComponent();
            Khoitao();

            ApplySettings();
        }
        private void SaveScoreToTxt()
        {
            // Thêm điểm vào file yourscore.txt
            File.WriteAllText("yourscore.txt", $"{score}");

            // Thêm điểm vào file scores.txt dạng "playerName|score"
            File.AppendAllText("scores.txt", $"{playerName}|{score}{Environment.NewLine}");
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbSetting_Click(object sender, EventArgs e)
        {
            Setting settingForm = new Setting();
            var result = settingForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                playerName = settingForm.PlayerNameSetting;
                characterIndex = settingForm.CharacterIndexSetting;
                mapIndex = settingForm.MapIndexSetting;
                ApplySettings();
            }
        }
    }

}

