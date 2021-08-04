using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;

namespace BLL
{
    public class category_Service
    {
        public static List<string> GetCategoryNAMES()
        {
            return category_repo.GetCategoryNAMES();
        }
        public static List<categoryModel> GetCategory()
        {
            var categories = category_repo.GetCategory();

            List<categoryModel> data = new List<categoryModel>();

            foreach (var c in categories)
            {
                var categ_ = new categoryModel()
                {
                    id = c.id,
                    name = c.name
                };
                data.Add(categ_);
            }
            return data;
        }

        public static void AddCategory(categoryModel categ_)
        {

            var c = new category()
            {
                id = categ_.id,
                name = categ_.name
            };

            category_repo.AddCategory(c);
        }
    }
}
