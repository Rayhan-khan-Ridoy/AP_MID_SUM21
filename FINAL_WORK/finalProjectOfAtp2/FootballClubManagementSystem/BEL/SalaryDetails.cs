using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SalaryDetails
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Grade { get; set; }
        public double Bonus { get; set; }
        public string Status { get; set; }
        public ICollection<PlayerInfoModel> Players { get; set; }
    }
}
