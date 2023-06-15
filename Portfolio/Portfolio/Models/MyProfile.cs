using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class MyProfile
    {
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string[] Hobbies { get; set; }
    }
}