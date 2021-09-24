using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PerformanceService
    {
        public static void AddPerformance(AddPerformanceModel model) {

            var data = AutoMapper.Mapper.Map<AddPerformanceModel, Performance>(model);
            PerformanceRepo.AddPerformance(data);
        
        }

        public static List<PerformanceModel> GetAll()
        {
            var data = PerformanceRepo.GetPerformanceDetails();
            var info = AutoMapper.Mapper.Map<List<Performance>, List<PerformanceModel>>(data);
            return info;
        }

        public static void PerformanceEdit(EditPerformanceModel obj)
        {
            var data = AutoMapper.Mapper.Map<EditPerformanceModel, Performance>(obj);
            PerformanceRepo.PerformanceEdit(data);
        }

        public static PerformanceModel GetPerformance(int id)
        {
            var data = PerformanceRepo.GetPerformance(id);
            var p = AutoMapper.Mapper.Map<Performance, PerformanceModel>(data);
            return p;
        }

        public static void PerformanceDelete(int id)
        {
            PerformanceRepo.PerformanceDelete(id);
        }

        public static PerformanceDetailsModel GetPerformanceIndividual(int id)
        {
            var performance_details = PerformanceRepo.GetPerformanceIndividual(id);
           
            PerformanceDetailsModel data = new PerformanceDetailsModel();
        
            var dm = new PerformanceDetailsModel()
            {
                Id = performance_details.Id,
                Avg_Rating = performance_details.Avg_Rating,
                Goals = performance_details.Goals,
                Assists = performance_details.Assists,
                Accurate_Pass = performance_details.Accurate_Pass,
                Key_Pass = performance_details.Key_Pass,
                Interception = performance_details.Interception,
                Successfully_Tackled = performance_details.Successfully_Tackled,
                Chance_Create = performance_details.Chance_Create,
                Dribbles_Completed = performance_details.Dribbles_Completed,
                Saves = performance_details.Saves,
                Red_Cards = performance_details.Red_Cards,
                Yellow_Cards = performance_details.Yellow_Cards,
                Name = PerformanceRepo.getName(id)
            };
            data = dm;
            return data;
        }

        public static List<PerformanceDetailsModel> GetPerformanceDetails()
        {
            //  var data = PerformanceRepo.GetPerformanceDetails();
            // var info = AutoMapper.Mapper.Map<List<Performance>, List<PerformanceDetailsModel>>(data);
            // return info;

            var performance_details = PerformanceRepo.GetPerformanceDetails();
            List<PerformanceDetailsModel> data = new List<PerformanceDetailsModel>();

            foreach (var d in performance_details)
            {
                var dm = new PerformanceDetailsModel()
                {
                    Id = d.Id,
                    Avg_Rating = d.Avg_Rating,
                    Goals = d.Goals,
                    Assists = d.Assists,
                    Accurate_Pass = d.Accurate_Pass,
                    Key_Pass = d.Key_Pass,
                    Interception = d.Interception,
                    Successfully_Tackled = d.Successfully_Tackled,
                    Chance_Create = d.Chance_Create,
                    Dribbles_Completed = d.Dribbles_Completed,
                    Saves = d.Saves,
                    Red_Cards = d.Red_Cards,
                    Yellow_Cards = d.Yellow_Cards,
                    Name = PerformanceRepo.getName(d.Id)
            };

                    data.Add(dm);
            }
                return data;

        }
            
         
    }
}
