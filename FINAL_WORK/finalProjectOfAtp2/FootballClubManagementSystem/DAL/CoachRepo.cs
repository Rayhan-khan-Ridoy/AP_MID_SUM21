using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CoachRepo
    {
        static FCMSEntities context;
        static CoachRepo()
        {
            context = new FCMSEntities();
        }

        public static void AddCoach(Coach data)
        {
            context.Coaches.Add(data);
            context.SaveChanges();
        }

        public static List<Coach> GetCoach()
        {
            var data = context.Coaches.ToList();
            return data;
        }

        public static void CoachEdit(Coach obj)
        {
            var data = context.Coaches.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static void CoachDelete(int id)
        {
            var coach = context.Coaches.FirstOrDefault(e => e.Id == id);
            context.Coaches.Remove(coach);
            context.SaveChanges();
        }

        public static Coach GetCoach(int id)
        {
            var data = context.Coaches.FirstOrDefault(e => e.Id == id);
            return data;
        }
    }
}
