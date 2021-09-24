using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CoachInfoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nationality { get; set; }
        public double Age { get; set; }
        public int Salary_Id { get; set; }
        public string SalaryGrade { get; set; }
        public string SalaryAmount { get; set; }
    }
}
