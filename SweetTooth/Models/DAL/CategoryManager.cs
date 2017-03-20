using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetTooth.Models.DAL
{
    public class CategoryManager
    {
        public static List<Category> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                List<Category> lst = db.Categories.OrderBy(h => h.CategoryName).ToList();
                return lst;
            }
        }

        public static void Create(Category cat)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Categories.Add(cat);
                ctx.SaveChanges();
            }
        }

        //using System.Web.Mvc for SelectListItem;
        public static IEnumerable<SelectListItem> GetSelectList(int? categoryId)
        {
            int selectedValue = categoryId.HasValue ? categoryId.Value : -1;

            IEnumerable<Category> lst = GetAll().OrderBy(c => c.CategoryName);

            IEnumerable<SelectListItem> selectList = lst.Select(c => new SelectListItem
            {
                Text = c.CategoryName,
                Value = c.CategoryID.ToString(),
                Selected = (selectedValue == c.CategoryID)
            });

            return selectList;
        }

        public static void Delete(int id)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                //search
                Category cat = ctx.Categories.Where(c => c.CategoryID == id).FirstOrDefault();
                if (cat != null)
                {
                    ctx.Categories.Remove(cat);
                }
                //save changes
                ctx.SaveChanges();
            }
        }
    }
}