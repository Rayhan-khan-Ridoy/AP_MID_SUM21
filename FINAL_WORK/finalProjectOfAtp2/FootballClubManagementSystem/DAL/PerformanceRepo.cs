using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PerformanceRepo
    {
        static FCMSEntities context;
        static PerformanceRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddPerformance(Performance model)
        {

            context.Performances.Add(model);
            context.SaveChanges();

        }

        public static void PerformanceEdit(Performance obj)
        {
            var data = context.Performances.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static void PerformanceDelete(int id)
        {
            var performance = context.Performances.FirstOrDefault(e => e.Id == id);
            context.Performances.Remove(performance);
            context.SaveChanges();
        }

        public static List<Performance> GetPerformanceDetails()
        {
            var data = context.Performances.ToList();
            return data;
        }

        public static Performance GetPerformance(int id)
        {
            var data = context.Performances.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public static string getName(int id)
        {

            var data = context.Players.Where(z => z.Performance_Id == id).Select(x => x.Name).FirstOrDefault();
            return data;
        }

        public static Performance GetPerformanceIndividual(int id)
        {
            var data = context.Performances.FirstOrDefault(e => e.Id == id);
            return data;
        }
    }
}
