using AccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsProduct
    {
        private enum EnMode {AddNewProduct =1 , UpdateProduct=2 } 
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public Decimal ProductPrice { get; set; }
        public int QuantityInStock { get; set; }
        public int MinimumQuantity { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public string ImagePath { get; set; }
        private EnMode _Mode;

        public clsProduct()
        {
            ProductID = -1;
            ProductName = string.Empty;
            ProductPrice = new Decimal(0);
            QuantityInStock = 0;
            ExpiryDate = null;
            MinimumQuantity = 0;
            ImagePath = string.Empty;
            _Mode = EnMode.AddNewProduct;
        }

        private clsProduct(int ProductID, string ProductName, decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpiryDate , string ImagePath)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.QuantityInStock = QuantityInStock;
            this.MinimumQuantity = MinimumQuantity;
            this.ExpiryDate = ExpiryDate;
            this.ImagePath = ImagePath;
            _Mode = EnMode.UpdateProduct;
        }

        private static int _AddNewProduct(string ProductName, Decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpiryDate,string ImagePath)
        {
            int ProductID = clsProductData.AddNewProduct(ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate, ImagePath);
            return ProductID;
        }

        public static clsProduct GetProductByID(int ProductID)
        {
            string ProductName; decimal ProductPrice; int QuantityInStock ; int MinimumQuantity; DateTime? ExpiryDate; string ImagePath;

            if (clsProductData.ReadProduct(ProductID, out ProductName, out ProductPrice, out QuantityInStock, out MinimumQuantity, out ExpiryDate, out ImagePath)) 
            {
                return new clsProduct(ProductID, ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate, ImagePath);
            }
            else
            {
                return null;
            }
        }

        private static bool _UpdateProduct(int ProductID, string ProductName, Decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpiryDate , string ImagePath)
        {
            return clsProductData.UpdateProduct(ProductID, ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate,ImagePath);
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
                    ProductID = _AddNewProduct(ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate, ImagePath);
                    IsSaved = ProductID > 0;
                    if(IsSaved)
                    _Mode = EnMode.UpdateProduct;
                    break;

                case EnMode.UpdateProduct:
                    IsSaved = _UpdateProduct(ProductID, ProductName, ProductPrice, QuantityInStock, MinimumQuantity, ExpiryDate, ImagePath);
                    break;
            }
            return IsSaved;
        }

        public static DataTable GetAllProducts()
        {
            return clsProductData.GetAllProdcuts();
        }
    }
}
