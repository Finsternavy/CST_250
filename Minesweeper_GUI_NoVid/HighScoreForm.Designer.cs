
namespace Minesweeper_GUI
{
    partial class HighScoreForm
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
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.difficultyListBox = new System.Windows.Forms.ListBox();
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.elapsedTimeListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.difficultyPlayedLabel = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.youScoredLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.pointsInLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterNameLabel.Location = new System.Drawing.Point(313, 51);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(262, 45);
            this.enterNameLabel.TabIndex = 0;
            this.enterNameLabel.Text = "Enter your name!";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Location = new System.Drawing.Point(137, 99);
            this.enterNameTextBox.Multiline = true;
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(614, 62);
            this.enterNameTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(137, 168);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(614, 68);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 15;
            this.nameListBox.Location = new System.Drawing.Point(49, 311);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(198, 514);
            this.nameListBox.TabIndex = 3;
            // 
            // difficultyListBox
            // 
            this.difficultyListBox.FormattingEnabled = true;
            this.difficultyListBox.ItemHeight = 15;
            this.difficultyListBox.Location = new System.Drawing.Point(253, 311);
            this.difficultyListBox.Name = "difficultyListBox";
            this.difficultyListBox.Size = new System.Drawing.Size(198, 514);
            this.difficultyListBox.TabIndex = 3;
            // 
            // scoreListBox
            // 
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.ItemHeight = 15;
            this.scoreListBox.Location = new System.Drawing.Point(661, 311);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(198, 514);
            this.scoreListBox.TabIndex = 3;
            // 
            // elapsedTimeListBox
            // 
            this.elapsedTimeListBox.FormattingEnabled = true;
            this.elapsedTimeListBox.ItemHeight = 15;
            this.elapsedTimeListBox.Location = new System.Drawing.Point(457, 311);
            this.elapsedTimeListBox.Name = "elapsedTimeListBox";
            this.elapsedTimeListBox.Size = new System.Drawing.Size(198, 514);
            this.elapsedTimeListBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(49, 283);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(119, 25);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Player Name";
            // 
            // difficultyPlayedLabel
            // 
            this.difficultyPlayedLabel.AutoSize = true;
            this.difficultyPlayedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultyPlayedLabel.Location = new System.Drawing.Point(253, 283);
            this.difficultyPlayedLabel.Name = "difficultyPlayedLabel";
            this.difficultyPlayedLabel.Size = new System.Drawing.Size(148, 25);
            this.difficultyPlayedLabel.TabIndex = 4;
            this.difficultyPlayedLabel.Text = "Difficulty Played";
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.elapsedTimeLabel.Location = new System.Drawing.Point(456, 283);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(161, 25);
            this.elapsedTimeLabel.TabIndex = 4;
            this.elapsedTimeLabel.Text = "Time to Complete";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(661, 283);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(59, 25);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score";
            // 
            // youScoredLabel
            // 
            this.youScoredLabel.AutoSize = true;
            this.youScoredLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.youScoredLabel.Location = new System.Drawing.Point(245, 26);
            this.youScoredLabel.Name = "youScoredLabel";
            this.youScoredLabel.Size = new System.Drawing.Size(104, 25);
            this.youScoredLabel.TabIndex = 5;
            this.youScoredLabel.Text = "You scored";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsLabel.Location = new System.Drawing.Point(355, 26);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(22, 25);
            this.pointsLabel.TabIndex = 5;
            this.pointsLabel.Text = "0";
            // 
            // pointsInLabel
            // 
            this.pointsInLabel.AutoSize = true;
            this.pointsInLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsInLabel.Location = new System.Drawing.Point(393, 26);
            this.pointsInLabel.Name = "pointsInLabel";
            this.pointsInLabel.Size = new System.Drawing.Size(95, 25);
            this.pointsInLabel.TabIndex = 5;
            this.pointsInLabel.Text = " points in ";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondsLabel.Location = new System.Drawing.Point(545, 26);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(85, 25);
            this.secondsLabel.TabIndex = 5;
            this.secondsLabel.Text = "seconds!";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(494, 26);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(22, 25);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "0";
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.pointsInLabel);
            this.Controls.Add(this.youScoredLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.difficultyPlayedLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.elapsedTimeListBox);
            this.Controls.Add(this.scoreListBox);
            this.Controls.Add(this.difficultyListBox);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.enterNameLabel);
            this.Name = "HighScoreForm";
            this.Text = "HighScoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.ListBox difficultyListBox;
        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.ListBox elapsedTimeListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label difficultyPlayedLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label youScoredLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label pointsInLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}