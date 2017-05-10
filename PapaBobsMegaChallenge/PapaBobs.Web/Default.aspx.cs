using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PapaBobs.DTO.Enums;

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

        protected void orderButton_Click(object sender, EventArgs e)
        {
            var order = new DTO.OrderDTO();
            order.Size = determineSizeType();
            order.Crust = determineCrustType();
            order.Sausage = sausageCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = greenPeppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = determineAddress();
            order.Zip = zipTextBox.Text;
            order.Phone = phoneTextBox.Text;
            order.PaymentType = determinePaymentType();

            Domain.OrderManager.CreateOrder(order);
        }

        private DTO.Enums.SizeType determineSizeType()
        {
            DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Could not determine pizza size.");
            }
            return size;
        }

        private DTO.Enums.CrustType determineCrustType()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Could not determine pizza crust.");
            }
            return crust;
        }

        private string determineAddress()
        {
            if (addressTextBox.Text.Trim().Length == 0)
            {
                throw new Exception("Please enter an address");
            }
            else return addressTextBox.Text;
        }

        private DTO.Enums.PaymentType determinePaymentType()
        {
            if (cashRadioButton.Checked)
                return DTO.Enums.PaymentType.Cash;
            else if (creditRadioButton.Checked)
                return DTO.Enums.PaymentType.Credit;
            else
                throw new Exception("Please choose a payment type.");
        }
    }
}