namespace MIMS.Products
{
    partial class UcProduct
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
            this.ProductPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantityInStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMinimumQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMinimumQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbQuantityInStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbProductPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbProductID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ProductPanel.BorderRadius = 20;
            this.ProductPanel.Controls.Add(this.btnUpdate);
            this.ProductPanel.Controls.Add(this.btndelete);
            this.ProductPanel.Controls.Add(this.pbProductImage);
            this.ProductPanel.Controls.Add(this.guna2CustomGradientPanel1);
            this.ProductPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ProductPanel.FillColor2 = System.Drawing.SystemColors.Window;
            this.ProductPanel.Location = new System.Drawing.Point(3, 3);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(477, 512);
            this.ProductPanel.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(263, 453);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BorderRadius = 10;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(19, 453);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(180, 45);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.White;
            this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProductImage.Location = new System.Drawing.Point(47, 4);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(371, 174);
            this.pbProductImage.TabIndex = 8;
            this.pbProductImage.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.txtPrice);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtQuantityInStock);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtMinimumQuantity);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbMinimumQuantity);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbQuantityInStock);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbProductPrice);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbProductName);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbProductID);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(6, 194);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(471, 253);
            this.guna2CustomGradientPanel1.TabIndex = 7;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 8;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(283, 198);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(136, 31);
            this.txtPrice.TabIndex = 19;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.Visible = false;
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.BorderRadius = 8;
            this.txtQuantityInStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantityInStock.DefaultText = "";
            this.txtQuantityInStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantityInStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantityInStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantityInStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantityInStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantityInStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtQuantityInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtQuantityInStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantityInStock.Location = new System.Drawing.Point(284, 112);
            this.txtQuantityInStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.PlaceholderText = "";
            this.txtQuantityInStock.SelectedText = "";
            this.txtQuantityInStock.Size = new System.Drawing.Size(136, 31);
            this.txtQuantityInStock.TabIndex = 17;
            this.txtQuantityInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityInStock.Visible = false;
            // 
            // txtMinimumQuantity
            // 
            this.txtMinimumQuantity.BorderRadius = 8;
            this.txtMinimumQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimumQuantity.DefaultText = "";
            this.txtMinimumQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinimumQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinimumQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimumQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimumQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimumQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtMinimumQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMinimumQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimumQuantity.Location = new System.Drawing.Point(277, 64);
            this.txtMinimumQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinimumQuantity.Name = "txtMinimumQuantity";
            this.txtMinimumQuantity.PlaceholderText = "";
            this.txtMinimumQuantity.SelectedText = "";
            this.txtMinimumQuantity.Size = new System.Drawing.Size(143, 34);
            this.txtMinimumQuantity.TabIndex = 11;
            this.txtMinimumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinimumQuantity.Visible = false;
            // 
            // lbMinimumQuantity
            // 
            this.lbMinimumQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbMinimumQuantity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbMinimumQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbMinimumQuantity.Location = new System.Drawing.Point(308, 72);
            this.lbMinimumQuantity.Name = "lbMinimumQuantity";
            this.lbMinimumQuantity.Size = new System.Drawing.Size(25, 26);
            this.lbMinimumQuantity.TabIndex = 11;
            this.lbMinimumQuantity.Text = "??";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(77, 198);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(54, 26);
            this.guna2HtmlLabel5.TabIndex = 16;
            this.guna2HtmlLabel5.Text = "Price";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(56, 156);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(113, 26);
            this.guna2HtmlLabel4.TabIndex = 15;
            this.guna2HtmlLabel4.Text = "Product ID";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(47, 115);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(181, 26);
            this.guna2HtmlLabel3.TabIndex = 14;
            this.guna2HtmlLabel3.Text = "Quantity In Stock";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(44, 72);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(184, 26);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "Minimun Quantity";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(47, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(146, 26);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Product Name";
            // 
            // lbQuantityInStock
            // 
            this.lbQuantityInStock.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantityInStock.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbQuantityInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbQuantityInStock.Location = new System.Drawing.Point(315, 115);
            this.lbQuantityInStock.Name = "lbQuantityInStock";
            this.lbQuantityInStock.Size = new System.Drawing.Size(25, 26);
            this.lbQuantityInStock.TabIndex = 10;
            this.lbQuantityInStock.Text = "??";
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbProductPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbProductPrice.Location = new System.Drawing.Point(315, 197);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(25, 26);
            this.lbProductPrice.TabIndex = 9;
            this.lbProductPrice.Text = "??";
            // 
            // lbProductName
            // 
            this.lbProductName.BackColor = System.Drawing.Color.Transparent;
            this.lbProductName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbProductName.Location = new System.Drawing.Point(249, 30);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(21, 21);
            this.lbProductName.TabIndex = 8;
            this.lbProductName.Text = "??";
            this.lbProductName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductID
            // 
            this.lbProductID.BackColor = System.Drawing.Color.Transparent;
            this.lbProductID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbProductID.Location = new System.Drawing.Point(315, 156);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(25, 26);
            this.lbProductID.TabIndex = 7;
            this.lbProductID.Text = "??";
            // 
            // UcProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.ProductPanel);
            this.Name = "UcProduct";
            this.Size = new System.Drawing.Size(483, 526);
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMinimumQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbQuantityInStock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbProductPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbProductID;
        private System.Windows.Forms.PictureBox pbProductImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtMinimumQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantityInStock;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
    }
}
