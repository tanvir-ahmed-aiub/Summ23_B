using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CategoryNewsDTO : CategoryDTO
    {
        public List<NewsDTO> News { get; set; }
        public CategoryNewsDTO() { 
            News= new List<NewsDTO>();
        }
    }
}
