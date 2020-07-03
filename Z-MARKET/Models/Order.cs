using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_MARKET.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public DateTime DateOrder { get; set; }

        public int CustomerID { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public virtual Customer Customer { get; set; } // de varios a uno con Customer

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } // De uno a muchos
    }
}