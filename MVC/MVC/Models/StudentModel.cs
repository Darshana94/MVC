using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class StudentModel
    {
        [StringLength(5)]
        [Required]
        public string productname { get; set; }
        [StringLength(5)]
        [Required]
        public string price { get; set; }
        [Required]
        [StringLength(5)]
        public string quantity { get; set; }

    }
}