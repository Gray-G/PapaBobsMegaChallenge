using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            /*
            var order = new DTO.OrderDTO();
            order.OrderId = Guid.NewGuid();
            order.Size = DTO.Enums.SizeType.Large;
            order.Crust = DTO.Enums.CrustType.Regular;
            order.Pepperoni = true;
            order.Name = "Test";
            order.Address = "123 Main St";
            order.Zip = "12345";
            order.Phone = "123-2345";
            order.PaymentType = DTO.Enums.PaymentType.Cash;
            order.TotalCost = 16.50M;
            */

            orderDTO.OrderId = new Guid();

            Persistence.OrderRepository.CreateOrder(orderDTO);
        }
    }
}
