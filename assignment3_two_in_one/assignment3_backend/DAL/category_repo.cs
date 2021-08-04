using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class category_repo
    {
        static IMSEntities context;
        static category_repo()
        {

            context = new IMSEntities();
        }
        public static List<string> GetCategoryNAMES()
        {
            var data = context.categories.Select(e => e.name).ToList();
            return data;
        }

        public static List<category> GetCategory()
        {
            return context.categories.ToList();
        }
        public static void AddCategory(category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
        }
    }
}
