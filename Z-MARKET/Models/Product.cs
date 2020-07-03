using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Z_MARKET.Models
{
    public class Product
    {
        [Key]
        public int IdProducto { get; set; }

        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        public decimal Price { get; set; }

        [Display(Name = "Last Buy")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Stock { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; } //De uno a varios

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } //De uno a varios
    }
}