using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SalaryRepo
    {
        static FCMSEntities context;
        static SalaryRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddSalary(Salary model)
        {
            context.Salaries.Add(model);
            context.SaveChanges();
        }

        public static List<Salary> GetSalaryDetails()
        {
            var data = context.Salaries.ToList();
            return data;
        }

        public static void SalaryEdit(Salary obj)
        {
            var data = context.Salaries.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static void SalaryDelete(int id)
        {
            var salary = context.Salaries.FirstOrDefault(e => e.Id == id);
            context.Salaries.Remove(salary);
            context.SaveChanges();
        }

        public static Salary GetSalary(int id)
        {
            var data = context.Salaries.FirstOrDefault(e => e.Id == id);
            return data;
        }
    }
}
