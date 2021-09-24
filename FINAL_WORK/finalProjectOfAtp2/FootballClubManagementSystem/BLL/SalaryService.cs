using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SalaryService
    {
        public static void AddSalary(AddSalaryModel model)
        {
            var data = AutoMapper.Mapper.Map<AddSalaryModel, Salary>(model);
            SalaryRepo.AddSalary(data);
        }

        public static List<SalaryDetails> GetSalaryDetails()
        {
            var data = SalaryRepo.GetSalaryDetails();
            var info = AutoMapper.Mapper.Map<List<Salary>, List<SalaryDetails>>(data);
            return info;
        }

        public static void SalaryEdit(EditSalaryModel obj)
        {
            var data = AutoMapper.Mapper.Map<EditSalaryModel, Salary>(obj);
            SalaryRepo.SalaryEdit(data);
        }

        public static SalaryModel GetSalary(int id)
        {
            var data = SalaryRepo.GetSalary(id);
            var p = AutoMapper.Mapper.Map<Salary, SalaryModel>(data);
            return p;
        }

        public static void SalaryDelete(int id)
        {
            SalaryRepo.SalaryDelete(id);
        }
    }
}
