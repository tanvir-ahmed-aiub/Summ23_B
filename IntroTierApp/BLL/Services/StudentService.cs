using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentDTO> GetAll() {
            var data= StudentRepo.All();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<StudentDTO>>(data);
            return converted;
        }
        public static bool CreateStudent(StudentDTO s) {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<Student>(s);
            return StudentRepo.Create(conv);
        }
       
    }
}
