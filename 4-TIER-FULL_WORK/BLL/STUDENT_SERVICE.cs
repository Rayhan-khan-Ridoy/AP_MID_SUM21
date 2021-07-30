using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class STUDENT_SERVICE
    {
        static STUDENT_SERVICE()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }
        public static void AddStudent(STUDENTMODEL model)
        {
            var data = AutoMapper.Mapper.Map<STUDENTMODEL, STUDENT>(model);
            STUDENTREPO.AddStudent(data);
        }
        public static STUDENTMODEL GetStudent(int id)
        {
            var data = STUDENTREPO.GetStudent(id);
            var st = AutoMapper.Mapper.Map<STUDENT, STUDENTMODEL>(data);
            return st;
        }
        public static List<STUDENTMODEL> GetAllStudents()
        {
            var data = STUDENTREPO.GetAllStudents();
            var st = AutoMapper.Mapper.Map<List<STUDENT>, List<STUDENTMODEL>>(data);
            return st;
        }

        public static List<string> GetStudentNames()
        {
            var data = STUDENTREPO.GetStudentNames();
            return data;
        }
    }
}