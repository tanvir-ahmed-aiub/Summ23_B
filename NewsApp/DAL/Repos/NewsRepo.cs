using DAL.EF;
using DAL.EF.Models;
using DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NewsRepo : Repo, IRepo<News, int, bool>
    {
        public bool Create(News obj)
        {
            db.News.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.News.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(int id)
        {
            return db.News.Find(id);
        }

        public bool Update(News obj)
        {
            throw new NotImplementedException();
        }
    }
}
