using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FlappyDoge
{
    public partial class LeaderBoard : Form
    {
        //private readonly string JsonPath = "leaderboard.json";

        public LeaderBoard()
        {
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
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

            // Lấy top 3
            list = list.OrderByDescending(s => s.Score).Take(3).ToList();

            for (int i = 0; i < list.Count && i < 3; i++)
            {
                var entry = list[i];
                switch (i)
                {
                    case 0:
                        Rank1.Text = entry.PlayerName;
                        PointRank1.Text = entry.Score.ToString();
                        break;
                    case 1:
                        Rank2.Text = entry.PlayerName;
                        PointRank2.Text = entry.Score.ToString();
                        break;
                    case 2:
                        Rank3.Text = entry.PlayerName;
                        PointRank3.Text = entry.Score.ToString();
                        break;
                }
            }
        }
    }
}
