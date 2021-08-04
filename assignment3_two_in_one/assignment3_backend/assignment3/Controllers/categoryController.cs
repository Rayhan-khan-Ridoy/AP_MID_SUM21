using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BEL;

namespace assignment3.Controllers
{
    public class categoryController : ApiController
    {
        // GET: api/category

        [Route("api/category/names")]
        [HttpGet]

        public List<string> GetCategoryNAMES()
        {
            return category_Service.GetCategoryNAMES();
        }

        [Route("api/category/GetAll")]
        [HttpGet]
        public List<categoryModel> GetCategory()
        {
            return category_Service.GetCategory();
        }


        [Route("api/category/Add")]
        [HttpPost]
        public void Add(categoryModel cm)
        {

            category_Service.AddCategory(cm);
        }
    }
}
