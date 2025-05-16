namespace FlappyDoge
{
    partial class Gameover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameover));
            this.NewRecord = new System.Windows.Forms.Label();
            this.ShowLDB = new System.Windows.Forms.Button();
            this.PlayAg = new System.Windows.Forms.Button();
            this.MedalImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YourScore = new System.Windows.Forms.Label();
            this.BestScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewRecord
            // 
            this.NewRecord.AutoSize = true;
            this.NewRecord.BackColor = System.Drawing.Color.Transparent;
            this.NewRecord.Font = new System.Drawing.Font("Noto Sans KR", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewRecord.Location = new System.Drawing.Point(420, 245);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(67, 34);
            this.NewRecord.TabIndex = 4;
            this.NewRecord.Text = "NEW";
            this.NewRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowLDB
            // 
            this.ShowLDB.BackColor = System.Drawing.Color.Lavender;
            this.ShowLDB.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.ShowLDB.ForeColor = System.Drawing.Color.Purple;
            this.ShowLDB.Image = global::FlappyDoge.Properties.Resources.leaderboardmini;
            this.ShowLDB.Location = new System.Drawing.Point(447, 358);
            this.ShowLDB.Name = "ShowLDB";
            this.ShowLDB.Size = new System.Drawing.Size(135, 82);
            this.ShowLDB.TabIndex = 9;
            this.ShowLDB.Text = "Leaderboard";
            this.ShowLDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShowLDB.UseVisualStyleBackColor = false;
            this.ShowLDB.Click += new System.EventHandler(this.ShowLDB_Click);
            // 
            // PlayAg
            // 
            this.PlayAg.BackColor = System.Drawing.Color.Lavender;
            this.PlayAg.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.PlayAg.ForeColor = System.Drawing.Color.Purple;
            this.PlayAg.Image = global::FlappyDoge.Properties.Resources.resume;
            this.PlayAg.Location = new System.Drawing.Point(195, 358);
            this.PlayAg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayAg.Name = "PlayAg";
            this.PlayAg.Size = new System.Drawing.Size(143, 81);
            this.PlayAg.TabIndex = 8;
            this.PlayAg.Text = "Play Again";
            this.PlayAg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlayAg.UseVisualStyleBackColor = false;
            this.PlayAg.Click += new System.EventHandler(this.PlayAg_Click);
            // 
            // MedalImage
            // 
            this.MedalImage.BackColor = System.Drawing.Color.Transparent;
            this.MedalImage.Image = global::FlappyDoge.Properties.Resources.bronze;
            this.MedalImage.Location = new System.Drawing.Point(227, 213);
            this.MedalImage.Name = "MedalImage";
            this.MedalImage.Size = new System.Drawing.Size(97, 84);
            this.MedalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MedalImage.TabIndex = 1;
            this.MedalImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyDoge.Properties.Resources.gameOver;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // YourScore
            // 
            this.YourScore.AutoSize = true;
            this.YourScore.BackColor = System.Drawing.Color.Transparent;
            this.YourScore.Font = new System.Drawing.Font("Noto Sans KR", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourScore.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.YourScore.Location = new System.Drawing.Point(511, 202);
            this.YourScore.Name = "YourScore";
            this.YourScore.Size = new System.Drawing.Size(29, 34);
            this.YourScore.TabIndex = 10;
            this.YourScore.Text = "8";
            this.YourScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.BackColor = System.Drawing.Color.Transparent;
            this.BestScore.Font = new System.Drawing.Font("Noto Sans KR", 13.8F, System.Drawing.FontStyle.Bold);
            this.BestScore.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BestScore.Location = new System.Drawing.Point(511, 285);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(29, 34);
            this.BestScore.TabIndex = 10;
            this.BestScore.Text = "8";
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.YourScore);
            this.Controls.Add(this.ShowLDB);
            this.Controls.Add(this.PlayAg);
            this.Controls.Add(this.NewRecord);
            this.Controls.Add(this.MedalImage);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gameover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameover";
            ((System.ComponentModel.ISupportInitialize)(this.MedalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MedalImage;
        private System.Windows.Forms.Label NewRecord;
        private System.Windows.Forms.Button PlayAg;
        private System.Windows.Forms.Button ShowLDB;
        private System.Windows.Forms.Label YourScore;
        private System.Windows.Forms.Label BestScore;
    }
}