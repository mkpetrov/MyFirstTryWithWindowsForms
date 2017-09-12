namespace CarPartsShopGui
{
    partial class AddCarForm
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
            this.BrandLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.YearOfManufactureLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearOfManufacturTextBox = new System.Windows.Forms.TextBox();
            this.insertButtonCars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(28, 9);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(35, 13);
            this.BrandLabel.TabIndex = 0;
            this.BrandLabel.Text = "Brand";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(28, 80);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // YearOfManufactureLabel
            // 
            this.YearOfManufactureLabel.AutoSize = true;
            this.YearOfManufactureLabel.Location = new System.Drawing.Point(28, 152);
            this.YearOfManufactureLabel.Name = "YearOfManufactureLabel";
            this.YearOfManufactureLabel.Size = new System.Drawing.Size(106, 13);
            this.YearOfManufactureLabel.TabIndex = 2;
            this.YearOfManufactureLabel.Text = "Year Of Manufacture";
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(152, 9);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.BrandTextBox.TabIndex = 3;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(152, 73);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // yearOfManufacturTextBox
            // 
            this.yearOfManufacturTextBox.Location = new System.Drawing.Point(152, 145);
            this.yearOfManufacturTextBox.Name = "yearOfManufacturTextBox";
            this.yearOfManufacturTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearOfManufacturTextBox.TabIndex = 5;
            // 
            // insertButtonCars
            // 
            this.insertButtonCars.Location = new System.Drawing.Point(107, 208);
            this.insertButtonCars.Name = "insertButtonCars";
            this.insertButtonCars.Size = new System.Drawing.Size(100, 26);
            this.insertButtonCars.TabIndex = 6;
            this.insertButtonCars.Text = "Insert";
            this.insertButtonCars.UseVisualStyleBackColor = true;
            this.insertButtonCars.Click += new System.EventHandler(this.insertButtonCars_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.insertButtonCars);
            this.Controls.Add(this.yearOfManufacturTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.BrandTextBox);
            this.Controls.Add(this.YearOfManufactureLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandLabel);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label YearOfManufactureLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearOfManufacturTextBox;
        private System.Windows.Forms.Button insertButtonCars;
    }
}