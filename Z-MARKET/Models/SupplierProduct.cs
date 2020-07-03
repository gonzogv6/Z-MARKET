using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_MARKET.Models
{
    public class SupplierProduct
    {
        [Key]
        public string SupplierProductID { get; set; }
        public int SupplierID { get; set; }
        public int IdProducto { get; set; }

        public virtual Supplier Supplier { get; set; } //De varios a uno
        public virtual Product Product { get; set; } //De varios a uno
    }
}