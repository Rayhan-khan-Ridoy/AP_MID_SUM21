using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class OrderService
    {
        public static List<order_adminn_model> GetAllOrders()
        {
            var orders = order_repo.GetAllOrders();
            var data = AutoMapper.Mapper.Map<List<order_adminn>, List<order_adminn_model>>(orders);
            return data;
        }

        public static int AddOrder(order_adminn_model o)
        {
            var order = AutoMapper.Mapper.Map<order_adminn_model, order_adminn>(o);
            return order_repo.AddOrder(order);
        }

        public static void AddProductOrder(order_user_model item)
        {
            var productOrder = AutoMapper.Mapper.Map<order_user_model, order_user>(item);
            order_repo.AddProductOrder(productOrder);
        }

        public static List<order_user_model> GetOrder(int id)
        {
            var productOrders = order_repo.GetOrder(id);
            return AutoMapper.Mapper.Map<List<order_user>, List<order_user_model>>(productOrders);
        }

        public static order_adminn_model GetOrderInfo(int id)
        {
            var order = order_repo.GetOrderInfo(id);
            return AutoMapper.Mapper.Map<order_adminn, order_adminn_model>(order);
        }
    }
}
