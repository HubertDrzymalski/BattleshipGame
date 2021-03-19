namespace BattleshipGame
{
    partial class GamePanel
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
            this.labelScore = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.aiScore = new System.Windows.Forms.Label();
            this.aiScoreTextbox = new System.Windows.Forms.RichTextBox();
            this.playerScoreTextbox = new System.Windows.Forms.RichTextBox();
            this.leaderboardPanel = new System.Windows.Forms.Panel();
            this.logLabel = new System.Windows.Forms.Label();
            this.historyTextBox = new System.Windows.Forms.RichTextBox();
            this.leaderboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.Location = new System.Drawing.Point(38, 29);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 25);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerScore.Location = new System.Drawing.Point(15, 69);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(86, 25);
            this.playerScore.TabIndex = 1;
            this.playerScore.Text = "Player:";
            // 
            // aiScore
            // 
            this.aiScore.AutoSize = true;
            this.aiScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aiScore.Location = new System.Drawing.Point(15, 103);
            this.aiScore.Name = "aiScore";
            this.aiScore.Size = new System.Drawing.Size(40, 25);
            this.aiScore.TabIndex = 2;
            this.aiScore.Text = "AI:";
            // 
            // aiScoreTextbox
            // 
            this.aiScoreTextbox.Location = new System.Drawing.Point(61, 104);
            this.aiScoreTextbox.Name = "aiScoreTextbox";
            this.aiScoreTextbox.ReadOnly = true;
            this.aiScoreTextbox.Size = new System.Drawing.Size(30, 24);
            this.aiScoreTextbox.TabIndex = 3;
            this.aiScoreTextbox.Text = "";
            // 
            // playerScoreTextbox
            // 
            this.playerScoreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerScoreTextbox.Location = new System.Drawing.Point(107, 70);
            this.playerScoreTextbox.Name = "playerScoreTextbox";
            this.playerScoreTextbox.ReadOnly = true;
            this.playerScoreTextbox.Size = new System.Drawing.Size(30, 24);
            this.playerScoreTextbox.TabIndex = 4;
            this.playerScoreTextbox.Text = "";
            // 
            // leaderboardPanel
            // 
            this.leaderboardPanel.Controls.Add(this.logLabel);
            this.leaderboardPanel.Controls.Add(this.historyTextBox);
            this.leaderboardPanel.Controls.Add(this.labelScore);
            this.leaderboardPanel.Controls.Add(this.playerScoreTextbox);
            this.leaderboardPanel.Controls.Add(this.playerScore);
            this.leaderboardPanel.Controls.Add(this.aiScoreTextbox);
            this.leaderboardPanel.Controls.Add(this.aiScore);
            this.leaderboardPanel.Location = new System.Drawing.Point(327, 39);
            this.leaderboardPanel.Name = "leaderboardPanel";
            this.leaderboardPanel.Size = new System.Drawing.Size(146, 386);
            this.leaderboardPanel.TabIndex = 5;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logLabel.Location = new System.Drawing.Point(18, 158);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(86, 25);
            this.logLabel.TabIndex = 6;
            this.logLabel.Text = "History";
            // 
            // historyTextBox
            // 
            this.historyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyTextBox.Location = new System.Drawing.Point(18, 186);
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.Size = new System.Drawing.Size(119, 175);
            this.historyTextBox.TabIndex = 5;
            this.historyTextBox.Text = "";
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaderboardPanel);
            this.Name = "GamePanel";
            this.Text = "GamePanel";
            this.leaderboardPanel.ResumeLayout(false);
            this.leaderboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelScore;
        public System.Windows.Forms.Label playerScore;
        public System.Windows.Forms.Label aiScore;
        public System.Windows.Forms.RichTextBox aiScoreTextbox;
        public System.Windows.Forms.RichTextBox playerScoreTextbox;
        private System.Windows.Forms.Panel leaderboardPanel;
        public System.Windows.Forms.Label logLabel;
        public System.Windows.Forms.RichTextBox historyTextBox;
    }
}