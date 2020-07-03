﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_MARKET.Models
{
    public class DocumentType
    {
        [Key]
        [Display(Name = "Document Type")]
        public int DocumentTypeID { get; set; }

        [Display(Name = "Document")]
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } //Lado de uno a varios con Employee

        public virtual ICollection<Customer> Customers { get; set; } //Lado de uno a varios con Customer
    }
}