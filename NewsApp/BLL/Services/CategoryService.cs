using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService
    {
        public static List<CategoryDTO> Get()
        {
            var data = DataAccessFactory.CategorysData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<CategoryDTO>>(data);
            return cnvrted;
        }
        public static CategoryDTO Get(int id)
        {
            var data = DataAccessFactory.CategorysData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<CategoryDTO>(data);
            return cnvrted;
        }
        public static CategoryNewsDTO GetWithNews(int id)
        {
            var data = DataAccessFactory.CategorysData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Category, CategoryNewsDTO>();
                cfg.CreateMap<News, NewsDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<CategoryNewsDTO>(data);
            return cnvrted;
        }
        


    }
}
