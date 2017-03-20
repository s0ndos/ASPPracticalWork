using SweetTooth.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetTooth.Models.DAL
{
    public class FeedbackManager
    {

        public static List<Feedback> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                List<Feedback> lst = db.Feedbacks.ToList();
                return lst;
            }
        }

        public static void Create(Feedback fb)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Feedbacks.Add(fb);
                ctx.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                //search
                Feedback fb = ctx.Feedbacks.Where(f => f.FeedbackId == id).FirstOrDefault();
                if (fb != null)
                {
                    ctx.Feedbacks.Remove(fb);
                }
                //save changes
                ctx.SaveChanges();
            }
        }
    }
}