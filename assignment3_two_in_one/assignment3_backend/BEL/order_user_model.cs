using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class order_user_model
    {
        public int id { get; set; }
        public int id_product { get; set; }
        public int id_order { get; set; }
        public string product_price { get; set; }
        public string product_qty { get; set; }

        public string product_name { get; set; }
    }
}
