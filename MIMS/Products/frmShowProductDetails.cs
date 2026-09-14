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
    public partial class frmShowProductDetails : Form
    {
        private int _ProductID;
        public frmShowProductDetails(int ProductID)
        {
            _ProductID = ProductID;
            InitializeComponent();
            ucProductDetails.Start(_ProductID);
        }
    }
}
