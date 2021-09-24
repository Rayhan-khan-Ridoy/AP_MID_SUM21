using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class EditPlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Position { get; set; }
        public System.DateTime Joining_Date { get; set; }
        public System.DateTime Contract_Year { get; set; }
        public int Performance_Id { get; set; }
        public int Salary_Id { get; set; }
        public int Fitness_Id { get; set; }

    }
}
