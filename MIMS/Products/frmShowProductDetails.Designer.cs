namespace MIMS.Products
{
    partial class frmShowProductDetails
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
            this.ucProductDetails = new MIMS.Products.UcProduct();
            this.SuspendLayout();
            // 
            // ucProductDetails
            // 
            this.ucProductDetails.AccessibleDescription = " ";
            this.ucProductDetails.BackColor = System.Drawing.Color.White;
            this.ucProductDetails.Location = new System.Drawing.Point(10, 10);
            this.ucProductDetails.Name = "ucProductDetails";
            this.ucProductDetails.Size = new System.Drawing.Size(483, 526);
            this.ucProductDetails.TabIndex = 0;
            // 
            // frmShowProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 551);
            this.Controls.Add(this.ucProductDetails);
            this.Name = "frmShowProductDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = " ";
            this.Text = "Product Details";
            this.ResumeLayout(false);

        }

        #endregion

        private UcProduct ucProductDetails;
    }
}