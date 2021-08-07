
namespace MinesweeperGUI
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
            this.startPanel = new System.Windows.Forms.Panel();
            this.playGameButton = new System.Windows.Forms.Button();
            this.difficultRadioButton = new System.Windows.Forms.RadioButton();
            this.moderateRadioButton = new System.Windows.Forms.RadioButton();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.levelSelectLabel = new System.Windows.Forms.Label();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.playGameButton);
            this.startPanel.Controls.Add(this.difficultRadioButton);
            this.startPanel.Controls.Add(this.moderateRadioButton);
            this.startPanel.Controls.Add(this.easyRadioButton);
            this.startPanel.Controls.Add(this.levelSelectLabel);
            this.startPanel.Location = new System.Drawing.Point(13, 13);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(679, 656);
            this.startPanel.TabIndex = 0;
            // 
            // playGameButton
            // 
            this.playGameButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playGameButton.Location = new System.Drawing.Point(332, 424);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(245, 87);
            this.playGameButton.TabIndex = 2;
            this.playGameButton.Text = "Play Game";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // difficultRadioButton
            // 
            this.difficultRadioButton.AutoSize = true;
            this.difficultRadioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultRadioButton.Location = new System.Drawing.Point(111, 304);
            this.difficultRadioButton.Name = "difficultRadioButton";
            this.difficultRadioButton.Size = new System.Drawing.Size(104, 34);
            this.difficultRadioButton.TabIndex = 1;
            this.difficultRadioButton.TabStop = true;
            this.difficultRadioButton.Text = "Difficult";
            this.difficultRadioButton.UseVisualStyleBackColor = true;
            // 
            // moderateRadioButton
            // 
            this.moderateRadioButton.AutoSize = true;
            this.moderateRadioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moderateRadioButton.Location = new System.Drawing.Point(111, 224);
            this.moderateRadioButton.Name = "moderateRadioButton";
            this.moderateRadioButton.Size = new System.Drawing.Size(121, 34);
            this.moderateRadioButton.TabIndex = 1;
            this.moderateRadioButton.TabStop = true;
            this.moderateRadioButton.Text = "Moderate";
            this.moderateRadioButton.UseVisualStyleBackColor = true;
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.easyRadioButton.Location = new System.Drawing.Point(111, 149);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(72, 34);
            this.easyRadioButton.TabIndex = 1;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // levelSelectLabel
            // 
            this.levelSelectLabel.AutoSize = true;
            this.levelSelectLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.levelSelectLabel.Location = new System.Drawing.Point(39, 42);
            this.levelSelectLabel.Name = "levelSelectLabel";
            this.levelSelectLabel.Size = new System.Drawing.Size(115, 30);
            this.levelSelectLabel.TabIndex = 0;
            this.levelSelectLabel.Text = "Select Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.startPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.RadioButton difficultRadioButton;
        private System.Windows.Forms.RadioButton moderateRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.Label levelSelectLabel;
    }
}

