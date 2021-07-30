using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class DEPARTMENTDETAIL { 

        public int ID { get; set; }
        public string NAME { get; set; }
        public ICollection<STUDENTMODEL> STUDENT { get; set; }
    }
}