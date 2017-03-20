using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetTooth.Models.DAL
{
    public class OfferManager
    {
        public static List<Offer> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                List<Offer> lst = db.Offers.OrderBy(o => o.Name).ToList();
                return lst;
            }
        }

        public static void Create(Offer offer)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Offers.Add(offer);
                ctx.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                //search
                Offer offer = ctx.Offers.Where(o => o.OfferID == id).FirstOrDefault();
                if (offer != null)
                {
                    ctx.Offers.Remove(offer);
                }
                //save changes
                ctx.SaveChanges();
            }
        }
    }
}