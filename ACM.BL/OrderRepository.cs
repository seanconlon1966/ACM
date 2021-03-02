using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.BL
{
    public class OrderRepository
    {
        public OrderRepository()
        {

        }

        public Order Retrieve(int orderId)
        {
            // Create an instance of the Order class 
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined order 

            // Temporary hard-coded values to return 
            // a populated order 
            if (orderId == 1)
            {
                order.OrderDate = DateTime.Parse("Nov 25 2021");
            }
            return order;
        }

        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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
