using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroAPI.EF.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}