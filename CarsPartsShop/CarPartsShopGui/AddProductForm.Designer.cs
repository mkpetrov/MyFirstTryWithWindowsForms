namespace CarPartsShopGui
{
    partial class AddProductForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SellPriceTextBox = new System.Windows.Forms.TextBox();
            this.PurchTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.purchasePrice = new System.Windows.Forms.Label();
            this.sellPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(133, 15);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // SellPriceTextBox
            // 
            this.SellPriceTextBox.Location = new System.Drawing.Point(133, 160);
            this.SellPriceTextBox.Name = "SellPriceTextBox";
            this.SellPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.SellPriceTextBox.TabIndex = 5;
            // 
            // PurchTextBox
            // 
            this.PurchTextBox.Location = new System.Drawing.Point(133, 111);
            this.PurchTextBox.Name = "PurchTextBox";
            this.PurchTextBox.Size = new System.Drawing.Size(100, 20);
            this.PurchTextBox.TabIndex = 6;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(133, 63);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Ivory;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name.Location = new System.Drawing.Point(25, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 8;
            this.name.Text = "Name";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.Color.Ivory;
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category.Location = new System.Drawing.Point(25, 63);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(51, 15);
            this.category.TabIndex = 9;
            this.category.Text = "Category";
            // 
            // purchasePrice
            // 
            this.purchasePrice.AutoSize = true;
            this.purchasePrice.BackColor = System.Drawing.Color.Ivory;
            this.purchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchasePrice.Location = new System.Drawing.Point(25, 111);
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Size = new System.Drawing.Size(81, 15);
            this.purchasePrice.TabIndex = 10;
            this.purchasePrice.Text = "Purchase Price";
            // 
            // sellPrice
            // 
            this.sellPrice.AutoSize = true;
            this.sellPrice.BackColor = System.Drawing.Color.Ivory;
            this.sellPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sellPrice.Location = new System.Drawing.Point(23, 165);
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Size = new System.Drawing.Size(53, 15);
            this.sellPrice.TabIndex = 11;
            this.sellPrice.Text = "Sell Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sellPrice);
            this.Controls.Add(this.purchasePrice);
            this.Controls.Add(this.category);
            this.Controls.Add(this.name);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.PurchTextBox);
            this.Controls.Add(this.SellPriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SellPriceTextBox;
        private System.Windows.Forms.TextBox PurchTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label purchasePrice;
        private System.Windows.Forms.Label sellPrice;
        private System.Windows.Forms.Button button1;
    }
}