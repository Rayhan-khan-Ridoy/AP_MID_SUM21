using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhysioRepo
    {
        static FCMSEntities context;
        static PhysioRepo()
        {
            context = new FCMSEntities();
        }

        public static void AddPhysio(Physio model)
        {
            context.Physios.Add(model);
            context.SaveChanges();
        }

        public static List<Physio> GetPhysio()
        {
            var data = context.Physios.ToList();
            return data;
        }

        public static void PhysioEdit(Physio obj)
        {
            var data = context.Physios.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static void PhysioDelete(int id)
        {
            var physio = context.Physios.FirstOrDefault(e => e.Id == id);
            context.Physios.Remove(physio);
            context.SaveChanges();
        }

        public static Physio GetPhysioInfo(int id)
        {
            var data = context.Physios.FirstOrDefault(e => e.Id == id);
            return data;
        }

        public static List<Physio> GetPhysioDetails()
        {
            var data = context.Physios.ToList();
            return data;
        }
    }
}
