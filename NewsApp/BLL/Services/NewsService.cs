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
    public class NewsService
    {
        public static List<NewsDTO> Get() {
            var data = DataAccessFactory.NewsData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<News, NewsDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<NewsDTO>>(data);
            return cnvrted;
        }
        public static List<NewsDTO> Get(DateTime date) {
            var data = (from n in DataAccessFactory.NewsData().Get()
                        where n.Date.Date == date
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<News, NewsDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<NewsDTO>>(data);
            return cnvrted;

        }
        public static List<NewsDTO> Get(string cat)
        {
            var data = (from n in DataAccessFactory.NewsData().Get()
                        where n.Category.Name.ToLower().Contains(cat.ToLower())
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<News, NewsDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<NewsDTO>>(data);
            return cnvrted;

        }
        public static List<NewsDTO> Get(string cat, DateTime date) {
            var data = (from n in DataAccessFactory.NewsData().Get()
                        where n.Category.Name.ToLower().Contains(cat.ToLower())
                        && n.Date.Date == date
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<News, NewsDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<NewsDTO>>(data);
            return cnvrted;
        }
    }
}
