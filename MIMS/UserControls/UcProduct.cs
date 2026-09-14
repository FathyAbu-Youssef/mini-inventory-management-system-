using BusinessLayer;
using MIMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace MIMS.Products
{
    public partial class UcProduct : UserControl
    {
        private clsProduct _Product = new clsProduct();
       
        public UcProduct()
        {
            InitializeComponent();
        }

        internal void Start(int productID)
        {
            _Product = clsProduct.GetProductByID(productID);
            if (_Product != null) 
            {
                ShowProductData();
            }
        }

        private void ShowProductData()
        {
            lbProductName.Text = _Product.ProductName;
            lbProductID.Text = _Product.ProductID.ToString();
            lbProductPrice.Text = _Product.ProductPrice.ToString();
            lbQuantityInStock.Text=_Product.QuantityInStock.ToString();
            lbMinimumQuantity.Text = _Product.MinimumQuantity.ToString();
            pbProductImage.BackgroundImage = Image.FromFile(_Product.ImagePath);
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure to delete this product", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (_Product.DeleteProduct())
                {
                    MessageBox.Show("Product Deleted!!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                txtMinimumQuantity.Visible = true;
                txtPrice.Visible = true;
                txtQuantityInStock.Visible = true;
                btnUpdate.Text = "Save";
            }
            else
            {
                _Product.MinimumQuantity = Convert.ToInt32(txtQuantityInStock.Text.ToString());
                _Product.ProductPrice = Convert.ToInt32(txtPrice.Text.ToString());
                _Product.QuantityInStock = Convert.ToInt32(txtQuantityInStock.Text.ToString());
                if (_Product.Save()) 
                {
                    MessageBox.Show("Product Updated!!");
                } 
            }
        }
    }
}
