using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Post, int, bool> PostData() {
            return new PostRepo();
        }

        public static IRepo<Comment, int, bool> CommentData()
        {
            return new CommentRepo();
        }
    }
}
