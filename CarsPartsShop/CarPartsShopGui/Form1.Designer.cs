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
            this.AddCar = new System.Windows.Forms.Button();
            this.AddCompany = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            Products = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // Cars
            // 
            this.Cars.BackColor = System.Drawing.Color.FloralWhite;
            this.Cars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cars.ImageKey = "(none)";
            this.Cars.Location = new System.Drawing.Point(12, 21);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(94, 64);
            this.Cars.TabIndex = 0;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = false;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(138, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 204);
            this.dataGridView1.TabIndex = 3;
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(138, 273);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(82, 46);
            this.AddCar.TabIndex = 4;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // AddCompany
            // 
            this.AddCompany.Location = new System.Drawing.Point(431, 273);
            this.AddCompany.Name = "AddCompany";
            this.AddCompany.Size = new System.Drawing.Size(84, 46);
            this.AddCompany.TabIndex = 6;
            this.AddCompany.Text = "Add Company";
            this.AddCompany.UseVisualStyleBackColor = true;
            this.AddCompany.Click += new System.EventHandler(this.AddCompany_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(279, 273);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(85, 46);
            this.AddProduct.TabIndex = 8;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ShopGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(569, 384);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.AddCompany);
            this.Controls.Add(this.AddCar);
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
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button AddCompany;
        private System.Windows.Forms.Button AddProduct;
    }
}

