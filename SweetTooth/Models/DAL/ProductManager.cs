using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetTooth.Models.DAL
{
    public class ProductManager
    {
        public static List<Product> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                List<Product> lst = db.Products.OrderBy(p => p.Name).ToList();
                return lst;
            }
        }

        public static void Create(Product product)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Products.Add(product);
                ctx.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                //search
                Product prod = ctx.Products.Where(p => p.ProductID == id).FirstOrDefault();
                if (prod != null)
                {
                    ctx.Products.Remove(prod);
                }
                //save changes
                ctx.SaveChanges();
            }
        }
    }
}