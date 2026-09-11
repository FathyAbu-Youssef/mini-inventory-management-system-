using AccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsProduct
    {
        private enum EnMode {AddNewProduct =1 , UpdateProduct=2 } 
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Decimal ProductPrice { get; set; }
        public int QuantityInStock { get; set; }
        public int MinimumQuantity { get; set; }
        public DateTime? ExpiryDate { get; set; }
        private EnMode _Mode;

        public clsProduct()
        {
            ProductID = -1;
            ProductName = string.Empty;
            ProductPrice = new Decimal(0);
            QuantityInStock = 0;
            ExpiryDate = null;
            MinimumQuantity = 0;
            _Mode= EnMode.AddNewProduct;
        }

        private clsProduct(int ProductID, string ProductName, decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpiryDate)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.QuantityInStock = QuantityInStock;
            this.MinimumQuantity = MinimumQuantity;
            this.ExpiryDate = ExpiryDate;
            _Mode = EnMode.UpdateProduct;
        }

        private static int _AddNewProduct(string ProductName, Decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpiryDate)
        {
            int ProductID = clsProductData.AddNewProduct(ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate);
            return ProductID;
        }

        public static clsProduct GetProductByID(int ProductID)
        {
            string ProductName; decimal ProductPrice; int QuantityInStock; int MinimumQuantity; DateTime? ExpiryDate;

            if (clsProductData.ReadProduct(ProductID, out ProductName, out ProductPrice, out QuantityInStock, out MinimumQuantity, out ExpiryDate))
            {
                return new clsProduct(ProductID, ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate);
            }
            else
            {
                return null;
            }
        }

        private static bool _UpdateProduct(int ProductID, string ProductName, Decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpiryDate)
        {
            return clsProductData.UpdateProduct(ProductID, ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate);
        }

        public bool DeleteProduct()
        {
            return clsProductData.DeleteProduct(ProductID);
        }

        public bool Save()
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case EnMode.AddNewProduct:
                    ProductID = _AddNewProduct(ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate);
                    IsSaved = ProductID > 0;
                    if(IsSaved)
                    _Mode = EnMode.UpdateProduct;
                    break;

                case EnMode.UpdateProduct:
                    IsSaved = _UpdateProduct(ProductID, ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate);
                    break;
            }
            return IsSaved;
        }
    }
}
