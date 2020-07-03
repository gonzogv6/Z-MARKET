using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Z_MARKET.Models;

namespace Z_MARKET.ViewModels
{
    public class OrderView
    {
        public Customer Customer { get; set; }

        public List<ProductOrder> Products { get; set; }
    }
}