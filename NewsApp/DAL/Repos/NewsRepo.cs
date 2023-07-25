using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        public static List<News> Get() {
            var db = new NewsContext();
            return db.News.ToList();
        }
        public static News Get(int id) {
            var db = new NewsContext();
            return db.News.Find(id);
        }
    }
}
