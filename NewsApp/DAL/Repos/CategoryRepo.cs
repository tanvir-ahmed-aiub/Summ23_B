using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        public static List<Category> Get()
        {
            var db = new NewsContext();
            return db.Categories.ToList();
        }
        public static Category Get(int id)
        {
            var db = new NewsContext();
            return db.Categories.Find(id);
        }
    }
}
