using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetTooth.Models
{
    public class Product
    {
        public int CategoryID { get; set; } //foreignkey
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        public double? Price { get; set; }

        public int? QtyStock { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        Category category;
        List<Offer> relatedOffers;
    }
}