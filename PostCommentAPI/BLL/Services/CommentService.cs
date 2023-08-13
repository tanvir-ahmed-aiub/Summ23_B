using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CommentService
    {
        public static List<CommentDTO> Get()
        {
            var data = DataAccess.CommentData().Get();
            var mapper = MapperService<Comment, CommentDTO>.GetMapper();
            return mapper.Map<List<CommentDTO>>(data);
        }
        public static CommentDTO Get(int id)
        {
            var data = DataAccess.CommentData().Get(id);
            var mapper = MapperService<Comment, CommentDTO>.GetMapper();
            return mapper.Map<CommentDTO>(data);
        }
        public static bool Add(CommentDTO Comment)
        {
            var mapper = MapperService<CommentDTO, Comment>.GetMapper();
            var mapped = mapper.Map<Comment>(Comment);
            return DataAccess.CommentData().Add(mapped);

        }
        public static bool Update(CommentDTO Comment)
        {
            var mapper = MapperService<CommentDTO, Comment>.GetMapper();
            var mapped = mapper.Map<Comment>(Comment);
            return DataAccess.CommentData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccess.CommentData().Delete(id);

        }
    }
}
