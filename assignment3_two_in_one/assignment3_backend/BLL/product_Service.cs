using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class product_Service
    {
        //static product_Service()
        //{
        //    AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        //}
        public static void AddProduct(productModel model)
        {
            var data = AutoMapper.Mapper.Map<productModel, product>(model);
            product_repo.AddProduct(data);
        }
        public static productModel GetProduct(int id)
        {
            var data = product_repo.GetProduct(id);
            var p = AutoMapper.Mapper.Map<product, productModel>(data);
            return p;
        }
        public static List<productModel> GetAllProducts()
        {
            var data = product_repo.GetAllProducts();
            var p = AutoMapper.Mapper.Map<List<product>, List<productModel>>(data);
            return p;
        }

        public static List<string> GetProductNames()
        {
            var data = product_repo.GetProductNames();
            return data;
        }

        //---------------------------------------------//
        public static productModel updateProduct(int id)
        {
            var data = product_repo.updateProduct(id);
            var updated = AutoMapper.Mapper.Map<product, productModel>(data);
            
            return updated;
        }
        public static void Delete(int id)
        {
           
            product_repo.Delete(id);
        }
    }
}
