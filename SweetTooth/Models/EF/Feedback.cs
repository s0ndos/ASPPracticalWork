using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetTooth.Models.EF
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }
    }
}