using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.BL
{
    public class ProductRepository
    {
        public ProductRepository()
        {

        }

        public Product Retrieve(int productId)
        {
            // Create an instance of the Product class 
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves the defined product 

            // Temporary hard-coded values to return 
            // a populated product 
            if (productId == 1)
            {
                product.ProductName = "Sugar";
                product.ProductDescription = "1kg Bag of Sugar";
                product.CurrentPrice = (decimal?)1.50;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure 
                    }
                    else
                    {
                        // Call an Update Stored Procedure 
                    }
                }
                else
                {
                    success = false; 
                }
            }

            return success; 
        }

    }
}
