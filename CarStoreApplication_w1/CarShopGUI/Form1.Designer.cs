
namespace CarShopGUI
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
            this.createCarGroupBox = new System.Windows.Forms.GroupBox();
            this.createCarButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.carInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.shoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostValueLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.createCarGroupBox.SuspendLayout();
            this.carInventoryGroupBox.SuspendLayout();
            this.shoppingCartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCarGroupBox
            // 
            this.createCarGroupBox.Controls.Add(this.createCarButton);
            this.createCarGroupBox.Controls.Add(this.colorTextBox);
            this.createCarGroupBox.Controls.Add(this.priceTextBox);
            this.createCarGroupBox.Controls.Add(this.yearTextBox);
            this.createCarGroupBox.Controls.Add(this.modelTextBox);
            this.createCarGroupBox.Controls.Add(this.makeTextBox);
            this.createCarGroupBox.Controls.Add(this.colorLabel);
            this.createCarGroupBox.Controls.Add(this.label1);
            this.createCarGroupBox.Controls.Add(this.yearLabel);
            this.createCarGroupBox.Controls.Add(this.modelLabel);
            this.createCarGroupBox.Controls.Add(this.makeLabel);
            this.createCarGroupBox.Location = new System.Drawing.Point(12, 28);
            this.createCarGroupBox.Name = "createCarGroupBox";
            this.createCarGroupBox.Size = new System.Drawing.Size(213, 312);
            this.createCarGroupBox.TabIndex = 0;
            this.createCarGroupBox.TabStop = false;
            this.createCarGroupBox.Text = "Create a Car";
            // 
            // createCarButton
            // 
            this.createCarButton.Location = new System.Drawing.Point(52, 184);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(88, 23);
            this.createCarButton.TabIndex = 2;
            this.createCarButton.Text = "Create a Car";
            this.createCarButton.UseVisualStyleBackColor = true;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(52, 91);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 23);
            this.yearTextBox.TabIndex = 1;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(52, 62);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 23);
            this.modelTextBox.TabIndex = 1;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(52, 33);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 23);
            this.makeTextBox.TabIndex = 1;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(6, 99);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 15);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(7, 70);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(44, 15);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Model:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(6, 41);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(39, 15);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make:";
            // 
            // carInventoryGroupBox
            // 
            this.carInventoryGroupBox.Controls.Add(this.listBox1);
            this.carInventoryGroupBox.Location = new System.Drawing.Point(242, 28);
            this.carInventoryGroupBox.Name = "carInventoryGroupBox";
            this.carInventoryGroupBox.Size = new System.Drawing.Size(200, 317);
            this.carInventoryGroupBox.TabIndex = 1;
            this.carInventoryGroupBox.TabStop = false;
            this.carInventoryGroupBox.Text = "Car Inventory";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(7, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 289);
            this.listBox1.TabIndex = 0;
            // 
            // shoppingCartGroupBox
            // 
            this.shoppingCartGroupBox.Controls.Add(this.listBox2);
            this.shoppingCartGroupBox.Location = new System.Drawing.Point(578, 28);
            this.shoppingCartGroupBox.Name = "shoppingCartGroupBox";
            this.shoppingCartGroupBox.Size = new System.Drawing.Size(200, 317);
            this.shoppingCartGroupBox.TabIndex = 2;
            this.shoppingCartGroupBox.TabStop = false;
            this.shoppingCartGroupBox.Text = "Shopping Cart";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(7, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(187, 289);
            this.listBox2.TabIndex = 0;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(448, 148);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(124, 23);
            this.addToCartButton.TabIndex = 2;
            this.addToCartButton.Text = "Add to Cart ->";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(634, 351);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(75, 23);
            this.checkoutButton.TabIndex = 2;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(585, 405);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(62, 15);
            this.totalCostLabel.TabIndex = 0;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // totalCostValueLabel
            // 
            this.totalCostValueLabel.AutoSize = true;
            this.totalCostValueLabel.Location = new System.Drawing.Point(650, 405);
            this.totalCostValueLabel.Name = "totalCostValueLabel";
            this.totalCostValueLabel.Size = new System.Drawing.Size(38, 15);
            this.totalCostValueLabel.TabIndex = 0;
            this.totalCostValueLabel.Text = "label1";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(52, 121);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 1;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(52, 150);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 23);
            this.colorTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(6, 158);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(39, 15);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Color:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.shoppingCartGroupBox);
            this.Controls.Add(this.carInventoryGroupBox);
            this.Controls.Add(this.totalCostValueLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.createCarGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.createCarGroupBox.ResumeLayout(false);
            this.createCarGroupBox.PerformLayout();
            this.carInventoryGroupBox.ResumeLayout(false);
            this.shoppingCartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox createCarGroupBox;
        private System.Windows.Forms.Button createCarButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.GroupBox carInventoryGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox shoppingCartGroupBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostValueLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label label1;
    }
}

