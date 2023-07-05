using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.EF.Models
{
    public class Department
    {
        public int Id { get; set; }  //by default auto increment and PK
        [Required]
        [StringLength(100)]
        public string Name { get; set; } //nullable and nvarchar(MAX)
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
        public Department() {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
    }
}