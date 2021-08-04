using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class order_repo
    {
        static IMSEntities context;
        static order_repo()
        {
            context = new IMSEntities();
        }

        public static List<order_adminn> GetAllOrders()
        {
            return context.order_adminn.ToList();
        }

        public static int AddOrder(order_adminn order)
        {
            order.created_at = DateTime.Now;
            context.order_adminn.Add(order);
            context.SaveChanges();
            return order.id;
        }

        public static void AddProductOrder(order_user p)
        {
            context.order_user.Add(p);
            context.SaveChanges();
        }

        public static List<order_user> GetOrder(int id)
        {
            return context.order_user.Where(e => e.id_order == id).ToList();
        }

        public static order_adminn GetOrderInfo(int id)
        {
            return context.order_adminn.FirstOrDefault(e => e.id == id);
        }
    }
}
