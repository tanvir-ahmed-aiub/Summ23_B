using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string CommentText { get; set; }
        [ForeignKey("Post")]
        public int PId { get; set; }
        public virtual Post Post { get; set; }
    }
}
