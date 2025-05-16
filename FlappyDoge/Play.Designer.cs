namespace FlappyDoge
{
    partial class Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.Nameplayer = new System.Windows.Forms.Label();
            this.ptbSetting = new System.Windows.Forms.PictureBox();
            this.MusicStatus = new System.Windows.Forms.PictureBox();
            this.Doge = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.BackgroundImg = new System.Windows.Forms.PictureBox();
            this.bkMusic = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.Transparent;
            this.ScorePanel.Location = new System.Drawing.Point(391, 45);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(59, 48);
            this.ScorePanel.TabIndex = 9;
            // 
            // Nameplayer
            // 
            this.Nameplayer.AutoSize = true;
            this.Nameplayer.BackColor = System.Drawing.Color.Transparent;
            this.Nameplayer.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nameplayer.ForeColor = System.Drawing.Color.Purple;
            this.Nameplayer.Location = new System.Drawing.Point(12, 73);
            this.Nameplayer.Name = "Nameplayer";
            this.Nameplayer.Size = new System.Drawing.Size(194, 32);
            this.Nameplayer.TabIndex = 13;
            this.Nameplayer.Text = "Player Name";
            // 
            // ptbSetting
            // 
            this.ptbSetting.BackColor = System.Drawing.Color.Transparent;
            this.ptbSetting.Image = global::FlappyDoge.Properties.Resources.settingcon;
            this.ptbSetting.Location = new System.Drawing.Point(100, 1);
            this.ptbSetting.Name = "ptbSetting";
            this.ptbSetting.Size = new System.Drawing.Size(65, 56);
            this.ptbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSetting.TabIndex = 16;
            this.ptbSetting.TabStop = false;
            this.ptbSetting.Click += new System.EventHandler(this.ptbSetting_Click);
            // 
            // MusicStatus
            // 
            this.MusicStatus.BackColor = System.Drawing.Color.Transparent;
            this.MusicStatus.Image = global::FlappyDoge.Properties.Resources.sound1;
            this.MusicStatus.Location = new System.Drawing.Point(29, 1);
            this.MusicStatus.Name = "MusicStatus";
            this.MusicStatus.Size = new System.Drawing.Size(65, 56);
            this.MusicStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MusicStatus.TabIndex = 12;
            this.MusicStatus.TabStop = false;
            // 
            // Doge
            // 
            this.Doge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Doge.BackColor = System.Drawing.Color.Transparent;
            this.Doge.Image = ((System.Drawing.Image)(resources.GetObject("Doge.Image")));
            this.Doge.Location = new System.Drawing.Point(100, 314);
            this.Doge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Doge.Name = "Doge";
            this.Doge.Size = new System.Drawing.Size(93, 64);
            this.Doge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Doge.TabIndex = 1;
            this.Doge.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-14, 708);
            this.Ground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(993, 116);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // BackgroundImg
            // 
            this.BackgroundImg.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImg.Image = global::FlappyDoge.Properties.Resources.background;
            this.BackgroundImg.Location = new System.Drawing.Point(-14, 1);
            this.BackgroundImg.Name = "BackgroundImg";
            this.BackgroundImg.Size = new System.Drawing.Size(973, 725);
            this.BackgroundImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImg.TabIndex = 15;
            this.BackgroundImg.TabStop = false;
            // 
            // bkMusic
            // 
            this.bkMusic.Enabled = true;
            this.bkMusic.Location = new System.Drawing.Point(362, 144);
            this.bkMusic.Name = "bkMusic";
            this.bkMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bkMusic.OcxState")));
            this.bkMusic.Size = new System.Drawing.Size(114, 56);
            this.bkMusic.TabIndex = 11;
            this.bkMusic.Visible = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(920, 825);
            this.Controls.Add(this.ptbSetting);
            this.Controls.Add(this.Nameplayer);
            this.Controls.Add(this.MusicStatus);
            this.Controls.Add(this.bkMusic);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.Doge);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.BackgroundImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyDoge";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Doge;
        private System.Windows.Forms.Timer GameTimer;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel ScorePanel;
        private AxWMPLib.AxWindowsMediaPlayer bkMusic;
        private System.Windows.Forms.PictureBox MusicStatus;
        private System.Windows.Forms.Label Nameplayer;
        private System.Windows.Forms.PictureBox BackgroundImg;
        private System.Windows.Forms.PictureBox ptbSetting;
    }
}

