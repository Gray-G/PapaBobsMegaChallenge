using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
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

            Domain.OrderManager.CreateOrder(order);
        }
    }
}