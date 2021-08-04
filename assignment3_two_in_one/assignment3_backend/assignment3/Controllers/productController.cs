using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace assignment3.Controllers
{
    public class productController : ApiController
    {
        // GET: api/product

        [Route("api/product/GetAllProducts")]
        public List<productModel> GetAllProducts()
        {
            return product_Service.GetAllProducts();
        }
        [Route("api/product/{id}")]
        public productModel GetProduct(int id)
        {
            return product_Service.GetProduct(id);
        }
        [Route("api/product/Add")]
        [HttpPost]
        public void AddProduct(productModel model)
        {
            product_Service.AddProduct(model);
        }
        [Route("api/product/Names")]
        public List<string> GetProductNames()
        {
            return product_Service.GetProductNames();
        }


        [Route("api/product/{id}")]
        [HttpPut]
        public void updateProduct(int id)
        {
             product_Service.updateProduct(id);
        }


        [Route("api/product/{id}")]
        [HttpDelete]
        public void  Delete(int id)
         {
            product_Service.Delete(id);
        }
    }
}
