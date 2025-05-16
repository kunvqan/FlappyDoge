namespace FlappyDoge
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Guide = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FlappyDoge.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(241, -64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::FlappyDoge.Properties.Resources.message;
            this.pictureBox2.Location = new System.Drawing.Point(323, 130);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Guide
            // 
            this.Guide.BackColor = System.Drawing.Color.Lavender;
            this.Guide.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.Guide.ForeColor = System.Drawing.Color.Purple;
            this.Guide.Image = global::FlappyDoge.Properties.Resources.userguidemini;
            this.Guide.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guide.Location = new System.Drawing.Point(168, 396);
            this.Guide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(132, 71);
            this.Guide.TabIndex = 3;
            this.Guide.Text = "GUIDELINE";
            this.Guide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guide.UseVisualStyleBackColor = false;
            this.Guide.Click += new System.EventHandler(this.Guide_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Lavender;
            this.Quit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Purple;
            this.Quit.Image = global::FlappyDoge.Properties.Resources.quitmini;
            this.Quit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Quit.Location = new System.Drawing.Point(653, 396);
            this.Quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(107, 71);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "QUIT";
            this.Quit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Image = global::FlappyDoge.Properties.Resources.resume;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(409, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "PLAY";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyDoge.Properties.Resources.startbg;
            this.ClientSize = new System.Drawing.Size(920, 554);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Guide;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button button1;
    }
}