using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage ="Please Provide Name")]
        [StringLength(10, ErrorMessage ="Name cant exceed 10 characters")]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        public string[] Hobbies { get; set; }
    }
}