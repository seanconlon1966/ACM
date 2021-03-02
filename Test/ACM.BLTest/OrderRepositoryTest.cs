using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange 
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = DateTime.Parse("Nov 25 2021")
            };


            //-- Act 
            var actual = orderRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId); 
            Assert.AreEqual(expected.OrderDate, actual.OrderDate); 
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(1)
            {
                OrderDate = DateTime.Parse("Nov 25 2021"),
                HasChanges = true
            };

            //-- Act 
            var actual = orderRepository.Save(updatedOrder);

            //-- Assert 
            Assert.AreEqual(true, actual);
        }


        [TestMethod]
        public void SaveTestMissingOrderDate()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(1)
            {
                OrderDate = null,
                HasChanges = true
            };

            //-- Act 
            var actual = orderRepository.Save(updatedOrder);

            //-- Assert 
            Assert.AreEqual(false, actual);
        }
    }
}
