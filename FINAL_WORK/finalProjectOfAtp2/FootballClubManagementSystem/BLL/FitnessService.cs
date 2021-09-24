using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FitnessService
    {
        public static void AddFitness(AddFitnessModel model)
        {

            var data = AutoMapper.Mapper.Map<AddFitnessModel, Fitness>(model);
            FitnessRepo.AddFitness(data);

        }

        public static void FitnessEdit(EditFitnessModel obj)
        {
            var data = AutoMapper.Mapper.Map<EditFitnessModel, Fitness>(obj);
            FitnessRepo.FitnessEdit(data);
        }

        public static List<FitnessDetailsModel> GetFitnessDetails()
        {
             //    var data = FitnessRepo.GetFitnessDetails();
            //     var info = AutoMapper.Mapper.Map<List<Fitness>, List<FitnessDetailsModel>>(data);
                // return info;

           var fitness_details = FitnessRepo.GetFitnessDetails();
            List<FitnessDetailsModel> data = new List<FitnessDetailsModel>();

            foreach (var d in fitness_details)
            {
                var dm = new FitnessDetailsModel()
                {
                    Id = d.Id,
                    Status = d.Status,
                    PlayerName = FitnessRepo.getName(d.Id)
            };
                
                data.Add(dm);
            }
            return data;
        }

        public static FitnessModel GetFitness(int id)
        {
            var data = FitnessRepo.GetFitness(id);
            var p = AutoMapper.Mapper.Map<Fitness, FitnessModel>(data);
            return p;
        }

        public static void FitnessDelete(int id)
        {
            FitnessRepo.FitnessDelete(id);
        }
    }
}
