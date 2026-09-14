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
    public partial class frmLowStockNotification : Form
    {
        clsProduct.ProductEventArgs NotifitedProduct;
        public frmLowStockNotification(clsProduct.ProductEventArgs e)
        {
            InitializeComponent();
            NotifitedProduct = e;
        }

        private void frmLowStockNotification_Load(object sender, EventArgs e)
        {
            ucLowStockNotification1.Start(NotifitedProduct);
        }
    }
}
