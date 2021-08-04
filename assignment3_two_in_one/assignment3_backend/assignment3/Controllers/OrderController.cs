using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace assignment3.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/GetAll")]
        [HttpGet]
        public List<order_adminn_model> GetAllOrders()
        {
            return OrderService.GetAllOrders();
        }

        [Route("api/Order/Place")]
        [HttpPost]
        public void OrderPlace(List<order_user_model> cart)
        {
            order_adminn_model o = new order_adminn_model();
            o.status = "Pending";
            double total = 0;
            foreach (var item in cart)
            {
                var product_price = Int32.Parse(item.product_price); //product_price-->string to int___vul e database e product_price r product_qty er data type nvar diye felecilam
                var product_qty = Int32.Parse(item.product_qty);
                total += product_price * product_qty;
            }
            o.amount = total;
            int orderId = OrderService.AddOrder(o);
            foreach (var item in cart)
            {
                item.id_order = orderId;
                OrderService.AddProductOrder(item);
            }
        }

        [Route("api/Order/info/{id}")]
        [HttpGet]
        public List<order_user_model> GetOrder(int id)
        {
            return OrderService.GetOrder(id);
        }

        [Route("api/Order/{id}")]
        [HttpGet]
        public order_adminn_model GetOrderInfo(int id)
        {
            return OrderService.GetOrderInfo(id);
        }
    }
}
