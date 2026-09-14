namespace MIMS.Products
{
    partial class ucLowStockNotification
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLowStockLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnViewProduct = new Guna.UI2.WinForms.Guna2Button();
            this.pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbalertpicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbQuantityInStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbMinimumQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbalertpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLowStockLabel
            // 
            this.lbLowStockLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbLowStockLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.lbLowStockLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lbLowStockLabel.Location = new System.Drawing.Point(92, 38);
            this.lbLowStockLabel.Name = "lbLowStockLabel";
            this.lbLowStockLabel.Size = new System.Drawing.Size(99, 29);
            this.lbLowStockLabel.TabIndex = 0;
            this.lbLowStockLabel.Text = "Low Stock";
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BorderRadius = 10;
            this.btnViewProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewProduct.FillColor = System.Drawing.Color.DarkRed;
            this.btnViewProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewProduct.Location = new System.Drawing.Point(323, 315);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(146, 45);
            this.btnViewProduct.TabIndex = 3;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProductImage.Image = global::MIMS.Properties.Resources.Sony_WH_1000XM5_Headphones;
            this.pbProductImage.ImageRotate = 0F;
            this.pbProductImage.Location = new System.Drawing.Point(3, 124);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(213, 201);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 2;
            this.pbProductImage.TabStop = false;
            // 
            // pbalertpicture
            // 
            this.pbalertpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbalertpicture.Image = global::MIMS.Properties.Resources.alert_sign;
            this.pbalertpicture.ImageRotate = 0F;
            this.pbalertpicture.Location = new System.Drawing.Point(10, 4);
            this.pbalertpicture.Name = "pbalertpicture";
            this.pbalertpicture.Size = new System.Drawing.Size(111, 64);
            this.pbalertpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbalertpicture.TabIndex = 1;
            this.pbalertpicture.TabStop = false;
            // 
            // lbProductName
            // 
            this.lbProductName.BackColor = System.Drawing.Color.Transparent;
            this.lbProductName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.lbProductName.ForeColor = System.Drawing.Color.DarkRed;
            this.lbProductName.Location = new System.Drawing.Point(241, 140);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(179, 45);
            this.lbProductName.TabIndex = 4;
            this.lbProductName.Text = "Product Name";
            // 
            // lbQuantityInStock
            // 
            this.lbQuantityInStock.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantityInStock.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.lbQuantityInStock.ForeColor = System.Drawing.Color.DarkRed;
            this.lbQuantityInStock.Location = new System.Drawing.Point(372, 190);
            this.lbQuantityInStock.Name = "lbQuantityInStock";
            this.lbQuantityInStock.Size = new System.Drawing.Size(55, 29);
            this.lbQuantityInStock.TabIndex = 5;
            this.lbQuantityInStock.Text = "Stock";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(296, 188);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 29);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Stock:";
            // 
            // lbMinimumQuantity
            // 
            this.lbMinimumQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbMinimumQuantity.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.lbMinimumQuantity.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMinimumQuantity.Location = new System.Drawing.Point(381, 232);
            this.lbMinimumQuantity.Name = "lbMinimumQuantity";
            this.lbMinimumQuantity.Size = new System.Drawing.Size(94, 29);
            this.lbMinimumQuantity.TabIndex = 7;
            this.lbMinimumQuantity.Text = "Minimum";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(276, 232);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(99, 29);
            this.guna2HtmlLabel2.TabIndex = 8;
            this.guna2HtmlLabel2.Text = "Minimum:";
            // 
            // ucLowStockNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbMinimumQuantity);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lbQuantityInStock);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.btnViewProduct);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.lbLowStockLabel);
            this.Controls.Add(this.pbalertpicture);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucLowStockNotification";
            this.Size = new System.Drawing.Size(490, 376);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbalertpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbLowStockLabel;
        private Guna.UI2.WinForms.Guna2PictureBox pbalertpicture;
        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private Guna.UI2.WinForms.Guna2Button btnViewProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbQuantityInStock;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMinimumQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
