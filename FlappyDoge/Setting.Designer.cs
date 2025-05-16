namespace FlappyDoge
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.CBBCharacter = new System.Windows.Forms.ComboBox();
            this.CBBMap = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 38.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(197, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "SETTING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(142, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(142, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Character:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(142, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Map:";
            // 
            // PlayerName
            // 
            this.PlayerName.BackColor = System.Drawing.Color.Lavender;
            this.PlayerName.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.PlayerName.ForeColor = System.Drawing.Color.Purple;
            this.PlayerName.Location = new System.Drawing.Point(382, 120);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(225, 38);
            this.PlayerName.TabIndex = 2;
            // 
            // CBBCharacter
            // 
            this.CBBCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CBBCharacter.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBCharacter.ForeColor = System.Drawing.Color.Purple;
            this.CBBCharacter.FormattingEnabled = true;
            this.CBBCharacter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBBCharacter.Items.AddRange(new object[] {
            "Doge Light",
            "Doge Dark"});
            this.CBBCharacter.Location = new System.Drawing.Point(382, 192);
            this.CBBCharacter.Name = "CBBCharacter";
            this.CBBCharacter.Size = new System.Drawing.Size(226, 38);
            this.CBBCharacter.TabIndex = 3;
            this.CBBCharacter.SelectedIndexChanged += new System.EventHandler(this.CBBCharacter_SelectedIndexChanged);
            // 
            // CBBMap
            // 
            this.CBBMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CBBMap.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBMap.ForeColor = System.Drawing.Color.Purple;
            this.CBBMap.FormattingEnabled = true;
            this.CBBMap.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.CBBMap.Location = new System.Drawing.Point(382, 282);
            this.CBBMap.Name = "CBBMap";
            this.CBBMap.Size = new System.Drawing.Size(226, 38);
            this.CBBMap.TabIndex = 3;
            this.CBBMap.SelectedIndexChanged += new System.EventHandler(this.CBBMap_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Lavender;
            this.btnAccept.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.btnAccept.ForeColor = System.Drawing.Color.Purple;
            this.btnAccept.Location = new System.Drawing.Point(283, 373);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(168, 54);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "ACCEPT";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // picCharacter
            // 
            this.picCharacter.Image = global::FlappyDoge.Properties.Resources.shiba;
            this.picCharacter.Location = new System.Drawing.Point(666, 192);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(69, 36);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacter.TabIndex = 5;
            this.picCharacter.TabStop = false;
            // 
            // picBackground
            // 
            this.picBackground.Image = global::FlappyDoge.Properties.Resources.background;
            this.picBackground.Location = new System.Drawing.Point(614, 244);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(174, 133);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBackground.TabIndex = 5;
            this.picBackground.TabStop = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.picCharacter);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.CBBMap);
            this.Controls.Add(this.CBBCharacter);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.ComboBox CBBCharacter;
        private System.Windows.Forms.ComboBox CBBMap;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.PictureBox picBackground;
    }
}