using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_MARKET.Models
{
    public class ProductOrder:Product
    {
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        public float Quantity { get; set; }

        public decimal value { get { return Price * (decimal)Quantity; } }
    }
}