using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class FixtureModel
    {
        public int Id { get; set; }
        public string Opponent { get; set; }
        public string Match_Status { get; set; }
        public string Ground_Name { get; set; }
        public System.DateTime Date { get; set; }
        public string Result { get; set; }
    }
}
