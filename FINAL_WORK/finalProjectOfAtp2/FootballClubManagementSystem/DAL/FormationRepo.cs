using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormationRepo
    {
        static FCMSEntities context;
        static FormationRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddFormation(Formation data)
        {
            context.Formations.Add(data);
            context.SaveChanges();
        }

        public static List<Formation> GetFormation()
        {
            var data = context.Formations.ToList();
            return data;
        }

        public static void FormationEdit(Formation obj)
        {
            var data = context.Formations.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static void FormationDelete(int id)
        {
            var formation = context.Formations.FirstOrDefault(e => e.Id == id);
            context.Formations.Remove(formation);
            context.SaveChanges();
        }

        public static Formation GetFormationDetails(int id)
        {
            var data = context.Formations.FirstOrDefault(e => e.Id == id);
            return data;
        }
    }
}
