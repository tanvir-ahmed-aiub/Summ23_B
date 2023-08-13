using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class MapperService<Src,Dest>
    {
        public static Mapper GetMapper() {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Src, Dest>();
            }
            );
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
