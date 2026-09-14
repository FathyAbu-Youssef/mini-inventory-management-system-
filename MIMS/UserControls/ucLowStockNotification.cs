using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIMS.Products
{
    public partial class ucLowStockNotification : UserControl
    {
        clsProduct.ProductEventArgs NotifiedProduct;

        public ucLowStockNotification()
        {
            InitializeComponent();
        }
        public void Start(clsProduct.ProductEventArgs e)
        {
            NotifiedProduct = e;

            lbProductName.Text = e.ProductName;
            pbProductImage.Image = Image.FromFile(e.ImagePath);
            lbQuantityInStock.Text = e.QuantityInStock.ToString();
            lbMinimumQuantity.Text=e.MiniumumQuantity.ToString();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            frmShowProductDetails frm = new frmShowProductDetails(NotifiedProduct.PrductID);
            frm.ShowDialog();
        }
    }
}
