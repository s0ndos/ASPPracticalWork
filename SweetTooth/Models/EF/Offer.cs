using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetTooth.Models
{
    public class Offer
    {
        public int OfferID { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        Category category;
        List<Product> relatedProducts;
    }
}