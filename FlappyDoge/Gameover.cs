using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FlappyDoge
{
    public partial class Gameover : Form
    {
        private string playerName;
        private int characterIndex;
        private int mapIndex;
        public Gameover(string name, int character, int map)
        {
            InitializeComponent();
            playerName = name;
            characterIndex = character;
            mapIndex = map;

            LoadScores();
        }

        private void LoadScores()
        {
            // Đọc yourscore.txt để player vừa chơi
            if (File.Exists("yourscore.txt"))
            {
                var yourScore = File.ReadAllText("yourscore.txt").Trim();
                YourScore.Text = $"{yourScore}";
            }
            else
            {
                YourScore.Text = "0";
            }

            // Đọc scores.txt để tìm top scores
            int bestScore = 0;
            if (File.Exists("scores.txt"))
            {
                var lines = File.ReadAllLines("scores.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2 && int.TryParse(parts[1], out var score))
                    {
                        if (score > bestScore)
                            bestScore = score;
                    }
                }
            }

            BestScore.Text = $"{bestScore}";

            int newrecord = int.Parse(YourScore.Text);

            var list = new List<PlayerScore>();

            // Đọc tất cả dữ liệu trong scores.txt
            if (File.Exists("scores.txt"))
            {
                var lines = File.ReadAllLines("scores.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2 && int.TryParse(parts[1], out var score))
                    {
                        list.Add(new PlayerScore { PlayerName = parts[0], Score = score });
                    }
                }
            }

            list = list.OrderByDescending(s => s.Score).Take(3).ToList();

            if (newrecord > list[1].Score && newrecord == list[0].Score)
            {
                NewRecord.Visible = true;
                MedalImage.Image = global::FlappyDoge.Properties.Resources.gold;
            }
            else
            {
                NewRecord.Visible = false;
            }
        }

        private void PlayAg_Click(object sender, EventArgs e)
        {
            this.Hide();
            var play = new Play(playerName, characterIndex, mapIndex);
            play.ShowDialog();
            this.Close();
        }

        private void ShowLDB_Click(object sender, EventArgs e)
        {
            using (var lb = new LeaderBoard())
            {
                //Hide();
                lb.ShowDialog();
                //Close();
            }
        }
    }
}
