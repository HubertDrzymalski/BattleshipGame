namespace BattleshipGame
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.singlePlay = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.humanScoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aiScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.musicList = new System.Windows.Forms.ListBox();
            this.findMusicButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // singlePlay
            // 
            this.singlePlay.BackColor = System.Drawing.Color.Transparent;
            this.singlePlay.Location = new System.Drawing.Point(588, 279);
            this.singlePlay.Name = "singlePlay";
            this.singlePlay.Size = new System.Drawing.Size(200, 50);
            this.singlePlay.TabIndex = 0;
            this.singlePlay.Text = "Singleplayer";
            this.singlePlay.UseVisualStyleBackColor = false;
            this.singlePlay.Click += new System.EventHandler(this.singlePlay_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(588, 335);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 50);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(588, 393);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 50);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // humanScoreLabel
            // 
            this.humanScoreLabel.AutoSize = true;
            this.humanScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.humanScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humanScoreLabel.Location = new System.Drawing.Point(131, 66);
            this.humanScoreLabel.Name = "humanScoreLabel";
            this.humanScoreLabel.Size = new System.Drawing.Size(29, 31);
            this.humanScoreLabel.TabIndex = 8;
            this.humanScoreLabel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // aiScoreLabel
            // 
            this.aiScoreLabel.AutoSize = true;
            this.aiScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aiScoreLabel.Location = new System.Drawing.Point(72, 66);
            this.aiScoreLabel.Name = "aiScoreLabel";
            this.aiScoreLabel.Size = new System.Drawing.Size(29, 31);
            this.aiScoreLabel.TabIndex = 7;
            this.aiScoreLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Leaderboard";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(100, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(157, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 60);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.aiScoreLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.humanScoreLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 134);
            this.panel1.TabIndex = 19;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(12, 296);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(223, 44);
            this.Player.TabIndex = 20;
            // 
            // musicList
            // 
            this.musicList.FormattingEnabled = true;
            this.musicList.Location = new System.Drawing.Point(12, 347);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(223, 56);
            this.musicList.TabIndex = 21;
            this.musicList.SelectedIndexChanged += new System.EventHandler(this.musicList_SelectedIndexChanged);
            // 
            // findMusicButton
            // 
            this.findMusicButton.Location = new System.Drawing.Point(12, 410);
            this.findMusicButton.Name = "findMusicButton";
            this.findMusicButton.Size = new System.Drawing.Size(223, 29);
            this.findMusicButton.TabIndex = 22;
            this.findMusicButton.Text = "Select your music";
            this.findMusicButton.UseVisualStyleBackColor = true;
            this.findMusicButton.Click += new System.EventHandler(this.findMusicButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Mp3 files|*.mp3";
            this.openFileDialog1.Multiselect = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findMusicButton);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.singlePlay);
            this.Name = "FormMain";
            this.Text = "Battleship Game v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singlePlay;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Label humanScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label aiScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        public AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button findMusicButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ListBox musicList;
    }
}

