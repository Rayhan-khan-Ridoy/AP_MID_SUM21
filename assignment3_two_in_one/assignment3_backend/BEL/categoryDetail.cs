using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class categoryDetail
    {
        public int id { get; set; }
        public string name { get; set; }

        public virtual ICollection<productModel> product { get; set; }
    }
}
