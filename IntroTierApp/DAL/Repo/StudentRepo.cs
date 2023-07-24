using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo
    {
        public static List<Student> All() {
            var db = new UMSContext();
            return db.Students.ToList();
        }
        public static Student Get(int id) {
            var db = new UMSContext();
            return db.Students.Find(id);
        }
        public static bool Create(Student s) {
            var db = new UMSContext();
            db.Students.Add(s);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id) {
            return false;
        }
        public static bool Update(object obj) {
            return false;
        }
    }
}
