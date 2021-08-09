
namespace PeopleFileIO
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.URLLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.gameTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addToListButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(13, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameLabel.Location = new System.Drawing.Point(13, 60);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(51, 21);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Game";
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.URLLabel.Location = new System.Drawing.Point(13, 97);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(39, 21);
            this.URLLabel.TabIndex = 0;
            this.URLLabel.Text = "URL";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(71, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(161, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // gameTextBox
            // 
            this.gameTextBox.Location = new System.Drawing.Point(71, 58);
            this.gameTextBox.Name = "gameTextBox";
            this.gameTextBox.Size = new System.Drawing.Size(161, 23);
            this.gameTextBox.TabIndex = 1;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(71, 95);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(161, 23);
            this.urlTextBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(259, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(529, 409);
            this.listBox1.TabIndex = 2;
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(12, 138);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(219, 40);
            this.addToListButton.TabIndex = 3;
            this.addToListButton.Text = "Add to List ->";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 347);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(219, 40);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save to File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 393);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(219, 40);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load from File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.gameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "People I Know";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox urlTextBox;
    }
}

