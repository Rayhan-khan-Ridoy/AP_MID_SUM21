using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FitnessRepo
    {
        static FCMSEntities context;
        static FitnessRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddFitness(Fitness model) {

            context.Fitnesses.Add(model);
            context.SaveChanges();
        
        }

        public static void FitnessEdit(Fitness obj)
        {
            var data = context.Fitnesses.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static string getName(int id)
        {
            // var data = context.Players.Select(e => e.Name).AsEnumerable().Where( e=> e.Id == id);
            var data = context.Players.Where(z => z.Fitness_Id == id).Select(x => x.Name).FirstOrDefault();
            return data;
        }

        public static void FitnessDelete(int id)
        {
            var fitness = context.Fitnesses.FirstOrDefault(e => e.Id == id);
            context.Fitnesses.Remove(fitness);
            context.SaveChanges();
        }

        public static List<Fitness> GetFitnessDetails()
        {
            var data = context.Fitnesses.ToList();
            return data;

        }

        public static Fitness GetFitness(int id)
        {
            var data = context.Fitnesses.FirstOrDefault(e => e.Id == id);
            return data;
        }
    }
}
