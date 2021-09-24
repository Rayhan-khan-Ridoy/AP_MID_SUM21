using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FixtureRepo
    {
        static FCMSEntities context;
        static FixtureRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddFixture(Fixture data)
        {
            context.Fixtures.Add(data);
            context.SaveChanges();

            
        }

        public static List<Fixture> GetFixture()
        {
            var data = context.Fixtures.ToList();
            return data;
        }

        public static void FixtureEdit(Fixture obj)
        {
            var data = context.Fixtures.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static void FixtureDelete(int id)
        {
            var fixture = context.Fixtures.FirstOrDefault(e => e.Id == id);
            context.Fixtures.Remove(fixture);
            context.SaveChanges();
        }

        public static Fixture GetFixtures(int id)
        {
            var data = context.Fixtures.FirstOrDefault(e => e.Id == id);
            return data;
        }
    }
}
