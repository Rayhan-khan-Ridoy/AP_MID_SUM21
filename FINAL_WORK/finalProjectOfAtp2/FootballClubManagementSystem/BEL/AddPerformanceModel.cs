using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AddPerformanceModel
    {
        public int Id { get; set; }
        public double Avg_Rating { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Accurate_Pass { get; set; }
        public int Key_Pass { get; set; }
        public int Interception { get; set; }
        public int Successfully_Tackled { get; set; }
        public int Chance_Create { get; set; }
        public int Dribbles_Completed { get; set; }
        public int Saves { get; set; }
        public int Red_Cards { get; set; }
        public int Yellow_Cards { get; set; }
    }
}
