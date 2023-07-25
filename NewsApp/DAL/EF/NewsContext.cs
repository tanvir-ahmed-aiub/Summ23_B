using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class NewsContext :DbContext
    {
        public DbSet<Category>  Categories { get; set; }
        public DbSet<News> News { get; set; }
    }
}
