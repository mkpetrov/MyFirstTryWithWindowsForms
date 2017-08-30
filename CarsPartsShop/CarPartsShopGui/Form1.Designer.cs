namespace CarPartsShopGui
{
    partial class ShopGui
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
            System.Windows.Forms.Button Products;
            this.Cars = new System.Windows.Forms.Button();
            this.Companies = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            Products = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cars
            // 
            this.Cars.BackColor = System.Drawing.Color.FloralWhite;
            this.Cars.ImageKey = "(none)";
            this.Cars.Location = new System.Drawing.Point(12, 21);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(94, 64);
            this.Cars.TabIndex = 0;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = false;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // Products
            // 
            Products.BackColor = System.Drawing.Color.FloralWhite;
            Products.Location = new System.Drawing.Point(12, 91);
            Products.Name = "Products";
            Products.Size = new System.Drawing.Size(94, 64);
            Products.TabIndex = 1;
            Products.Text = "Products";
            Products.UseVisualStyleBackColor = false;
            Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Companies
            // 
            this.Companies.BackColor = System.Drawing.Color.FloralWhite;
            this.Companies.ImageKey = "(none)";
            this.Companies.Location = new System.Drawing.Point(12, 161);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(94, 64);
            this.Companies.TabIndex = 2;
            this.Companies.Text = "Companies";
            this.Companies.UseVisualStyleBackColor = false;
            this.Companies.Click += new System.EventHandler(this.Companies_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 204);
            this.dataGridView1.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(172, 239);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Add/Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(352, 238);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShopGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(515, 274);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Companies);
            this.Controls.Add(Products);
            this.Controls.Add(this.Cars);
            this.Name = "ShopGui";
            this.Text = "ShopGui";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button Companies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

