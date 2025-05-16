using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyDoge
{
    public partial class Setting : Form
    {
        //string playername = ""; // Default player name
        int CharacterIndex = 0; // Default character index
        int MapIndex = 0; // Default map index
        public string PlayerNameSetting
        { 
            get; 
            private set; 
        }
        public int CharacterIndexSetting
        { 
            get; 
            private set; 
        }
        public int MapIndexSetting
        { 
            get; 
            private set; 
        }

        public Setting()
        {
            InitializeComponent();
            Setting_Load(this, null);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            CBBCharacter.SelectedIndex = 0;
            CBBMap.SelectedIndex = 0;
        }

        //private void PlayerName
        private void CBBCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBBCharacter.SelectedIndex)
            {
                case 0:
                    picCharacter.Image = global::FlappyDoge.Properties.Resources.shiba;
                    CharacterIndex = 0;
                    break;
                case 1:
                    picCharacter.Image = global::FlappyDoge.Properties.Resources.shiba_dark;
                    CharacterIndex = 1;
                    break;
            }
        }

        private void CBBMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBBMap.SelectedIndex)
            {
                case 0:
                    picBackground.Image = global::FlappyDoge.Properties.Resources.background;
                    MapIndex = 0;
                    break;
                case 1:
                    picBackground.Image = global::FlappyDoge.Properties.Resources.background_night;
                    MapIndex = 1;
                    break;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlayerName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên người chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlayerNameSetting = PlayerName.Text.Trim();
            CharacterIndexSetting = CharacterIndex;
            MapIndexSetting = MapIndex;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
