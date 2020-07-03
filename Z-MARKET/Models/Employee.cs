﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Z_MARKET.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage ="you must enter {0}")]
        [StringLength(30, ErrorMessage ="The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "you must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0}, must be between {2} and {1} charates", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "you must enter {0}")]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Salary { get; set; }

        [Display(Name = "Bonus Percent")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float BonusPercent { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "you must enter {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Star Time")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "you must enter {0}")]
        public DateTime StarTime { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string URL { get; set; }

        [Required(ErrorMessage = "you must enter {0}")]
        public int DocumentTypeID { get; set; }

        [NotMapped]
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        public virtual DocumentType DocumentType { get; set; } //lado varios a uno con DocumentType

    }
}