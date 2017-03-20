using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetTooth.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}