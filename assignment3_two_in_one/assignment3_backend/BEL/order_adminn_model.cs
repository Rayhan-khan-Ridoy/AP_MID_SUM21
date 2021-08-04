using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class order_adminn_model
    {
        public int id { get; set; }
        public System.DateTime created_at { get; set; }
        public string status { get; set; }
        public double amount { get; set; }

   
        public virtual ICollection<order_user_model> order_user { get; set; }
    }
}
