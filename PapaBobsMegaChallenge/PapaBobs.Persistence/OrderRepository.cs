using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder()
        {
            var db = new PapaBobsDbEntities();

            // Code for db connection testing purposes
            var order = new Order();
            order.OrderId = Guid.NewGuid();
            order.Size = 1;
            order.Crust = 0;
            order.Pepperoni = true;
            order.Name = "Test";
            order.Address = "123 Main St";
            order.Zip = "12345";
            order.Phone = "123-2345";
            order.PaymentType = 0;
            order.TotalCost = 16.50M;

            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}
