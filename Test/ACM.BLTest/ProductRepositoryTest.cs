using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Sugar",
                ProductDescription = "1kg Bag of Sugar",
                CurrentPrice = (decimal?)1.50
        };


            //-- Act 
            var actual = productRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 Bright Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act 
            var actual = productRepository.Save(updatedProduct);

            //-- Assert 
            Assert.AreEqual(true, actual);
        }


        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act 
            var actual = productRepository.Save(updatedProduct);

            //-- Assert 
            Assert.AreEqual(false, actual);
        }

    }
}
