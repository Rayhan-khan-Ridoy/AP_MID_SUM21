using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class product_repo
    {
        static IMSEntities context;
        static product_repo()
        {
            context = new IMSEntities();
        }
        public static void AddProduct(product model)
        {
            context.products.Add(model);
            context.SaveChanges();
        }
        public static List<product> GetAllProducts()
        {
            var data = context.products.ToList();
            return data;
        }
        public static product GetProduct(int id)
        {
            var data = context.products.FirstOrDefault(e => e.id == id);
            return data;
        }

        public static List<string> GetProductNames()
        {
            var data = context.products.Select(e => e.name).ToList();
            return data;
        }


        //-------------------------------------------//
        
         public static product updateProduct(int id)
        {
            var data = context.products.FirstOrDefault(e => e.id == id);
            context.products.Add(data);
            context.SaveChanges();
            return data;
        }

        public static product Delete(int id)
        {
            var data = context.products.FirstOrDefault(e => e.id == id);
            context.products.Remove(data);
            context.SaveChanges();
            return data;
        }
    }
}
