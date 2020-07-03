using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_MARKET.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Display(Name = "Supplier Name")]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Contact First Name")]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string ContactFirstName { get; set; }

        [Display(Name = "Contact Last Name")]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string ContactLastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string Adress { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; } //De uno a varios
    }
}