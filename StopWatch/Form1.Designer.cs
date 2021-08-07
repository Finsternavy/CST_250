
namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.targetButton = new System.Windows.Forms.Button();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.hitsValueLabel = new System.Windows.Forms.Label();
            this.formButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.highScoreValueLabel = new System.Windows.Forms.Label();
            this.decoyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Aqua;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(93, 366);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 33);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Aqua;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(245, 366);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 34);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Aqua;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(387, 366);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 33);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // targetButton
            // 
            this.targetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.targetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.targetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetButton.Location = new System.Drawing.Point(227, 116);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(114, 44);
            this.targetButton.TabIndex = 4;
            this.targetButton.Text = "Target";
            this.targetButton.UseVisualStyleBackColor = false;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.BackColor = System.Drawing.Color.Lime;
            this.hitsLabel.Location = new System.Drawing.Point(350, 48);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(31, 15);
            this.hitsLabel.TabIndex = 5;
            this.hitsLabel.Text = "Hits:";
            // 
            // hitsValueLabel
            // 
            this.hitsValueLabel.AutoSize = true;
            this.hitsValueLabel.BackColor = System.Drawing.Color.Lime;
            this.hitsValueLabel.Location = new System.Drawing.Point(410, 48);
            this.hitsValueLabel.Name = "hitsValueLabel";
            this.hitsValueLabel.Size = new System.Drawing.Size(13, 15);
            this.hitsValueLabel.TabIndex = 5;
            this.hitsValueLabel.Text = "0";
            // 
            // formButton
            // 
            this.formButton.BackColor = System.Drawing.Color.Lime;
            this.formButton.Location = new System.Drawing.Point(63, 40);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(472, 388);
            this.formButton.TabIndex = 6;
            this.formButton.UseVisualStyleBackColor = false;
            this.formButton.Click += new System.EventHandler(this.formButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Black;
            this.playAgainButton.Enabled = false;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.ForeColor = System.Drawing.Color.Aqua;
            this.playAgainButton.Location = new System.Drawing.Point(76, 91);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(448, 327);
            this.playAgainButton.TabIndex = 7;
            this.playAgainButton.Text = "Play Again?";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Location = new System.Drawing.Point(313, 19);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(68, 15);
            this.highScoreLabel.TabIndex = 8;
            this.highScoreLabel.Text = "High Score:";
            // 
            // highScoreValueLabel
            // 
            this.highScoreValueLabel.AutoSize = true;
            this.highScoreValueLabel.Location = new System.Drawing.Point(410, 19);
            this.highScoreValueLabel.Name = "highScoreValueLabel";
            this.highScoreValueLabel.Size = new System.Drawing.Size(13, 15);
            this.highScoreValueLabel.TabIndex = 8;
            this.highScoreValueLabel.Text = "0";
            // 
            // decoyButton
            // 
            this.decoyButton.BackColor = System.Drawing.Color.Red;
            this.decoyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.decoyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decoyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decoyButton.Location = new System.Drawing.Point(227, 166);
            this.decoyButton.Name = "decoyButton";
            this.decoyButton.Size = new System.Drawing.Size(114, 44);
            this.decoyButton.TabIndex = 4;
            this.decoyButton.Text = "Don\'t Click Me!";
            this.decoyButton.UseVisualStyleBackColor = false;
            this.decoyButton.Click += new System.EventHandler(this.decoyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 501);
            this.Controls.Add(this.highScoreValueLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.hitsValueLabel);
            this.Controls.Add(this.hitsLabel);
            this.Controls.Add(this.decoyButton);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Label hitsValueLabel;
        private System.Windows.Forms.Button formButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label highScoreValueLabel;
        private System.Windows.Forms.Button decoyButton;
    }
}

