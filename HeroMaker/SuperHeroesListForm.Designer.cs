
namespace HeroMaker
{
    partial class SuperHeroesListForm
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
            this.heroesLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.heroesListBox = new System.Windows.Forms.ListBox();
            this.profileTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heroesLabel
            // 
            this.heroesLabel.AutoSize = true;
            this.heroesLabel.Location = new System.Drawing.Point(46, 71);
            this.heroesLabel.Name = "heroesLabel";
            this.heroesLabel.Size = new System.Drawing.Size(47, 15);
            this.heroesLabel.TabIndex = 0;
            this.heroesLabel.Text = "Heroes:";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(225, 71);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(41, 15);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Profile";
            // 
            // heroesListBox
            // 
            this.heroesListBox.FormattingEnabled = true;
            this.heroesListBox.ItemHeight = 15;
            this.heroesListBox.Location = new System.Drawing.Point(46, 103);
            this.heroesListBox.Name = "heroesListBox";
            this.heroesListBox.Size = new System.Drawing.Size(120, 214);
            this.heroesListBox.TabIndex = 1;
            // 
            // profileTextBox
            // 
            this.profileTextBox.Location = new System.Drawing.Point(225, 103);
            this.profileTextBox.Multiline = true;
            this.profileTextBox.Name = "profileTextBox";
            this.profileTextBox.Size = new System.Drawing.Size(495, 214);
            this.profileTextBox.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(46, 342);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(120, 34);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SuperHeroesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.profileTextBox);
            this.Controls.Add(this.heroesListBox);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.heroesLabel);
            this.Name = "SuperHeroesListForm";
            this.Text = "SuperHeroesListForm";
            this.Shown += new System.EventHandler(this.SuperHeroesListForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroesLabel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.ListBox heroesListBox;
        private System.Windows.Forms.TextBox profileTextBox;
        private System.Windows.Forms.Button selectButton;
    }
}