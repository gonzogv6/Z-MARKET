using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace Z_MARKET.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "you must enter the field {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string Adress { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 5)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [Display(Name = "Document")]
        public string Document { get; set; }

        public int DocumentTypeID { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName);}}

        public virtual DocumentType DocumentType { get; set; } // de varios a uno con DocumentType

        public virtual ICollection<Order> Orders { get; set; } //De uno a varios con Orders
    }
}