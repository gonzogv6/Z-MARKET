using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Z_MARKET.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        public int OrderID { get; set; }

        public int IdProducto { get; set; }

        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        public decimal Price { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        public float Quantity { get; set; }

        public virtual Order Order { get; set; } // de varios a uno con order

        public virtual Product Product { get; set; }

    }
}