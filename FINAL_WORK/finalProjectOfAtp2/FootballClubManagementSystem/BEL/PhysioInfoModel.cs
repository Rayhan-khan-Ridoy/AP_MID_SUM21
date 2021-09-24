using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PhysioInfoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Degree { get; set; }
        public string Major { get; set; }
        public int Salary_Id { get; set; }
        public string SalaryGrade { get; set; }
        public string SalaryAmount { get; set; }
    }
}
