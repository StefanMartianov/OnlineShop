using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OnlineShop;

class Order
{
    public string OrderNumber {get; set; }
    public double OrderPrice { get; set; }

    public Order(string orderNumber, double orderPrice)
    {
        OrderNumber = orderNumber;
        OrderPrice = orderPrice;
    }
}
