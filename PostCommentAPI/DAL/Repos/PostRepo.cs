using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PostRepo : Repo, IRepo<Post, int, bool>
    {
        public bool Add(Post obj)
        {
            db.Posts.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Posts.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Post> Get()
        {
            return db.Posts.ToList();
        }

        public Post Get(int id)
        {
            return db.Posts.Find(id);
        }

        public bool Update(Post obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
