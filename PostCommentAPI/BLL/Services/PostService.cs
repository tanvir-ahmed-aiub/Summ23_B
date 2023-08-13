using AutoMapper;
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
    public class PostService
    {
        public static List<PostDTO> Get() {
            var data = DataAccess.PostData().Get();
            var mapper = MapperService<Post, PostDTO>.GetMapper();
            return mapper.Map<List<PostDTO>>(data);
        }
        public static PostDTO Get(int id) {
            var data = DataAccess.PostData().Get(id);
            var mapper = MapperService<Post, PostDTO>.GetMapper();
            return mapper.Map<PostDTO>(data);
        }
        public static bool Add(PostDTO post) { 
            var mapper = MapperService<PostDTO, Post>.GetMapper();
            var mapped = mapper.Map<Post> ( post);
            return DataAccess.PostData().Add(mapped);

        }
        public static bool Update(PostDTO post)
        {
            var mapper = MapperService<PostDTO, Post>.GetMapper();
            var mapped = mapper.Map<Post>(post);
            return DataAccess.PostData().Update(mapped);

        }
        public static bool Delete(int id)
        {
            
            return DataAccess.PostData().Delete(id);

        }
    }
}
