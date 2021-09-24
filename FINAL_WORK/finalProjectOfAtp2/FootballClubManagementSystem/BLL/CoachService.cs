using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoachService
    {
        public static void AddCoach(AddCoachModel model)
        {
            var data = AutoMapper.Mapper.Map<AddCoachModel, Coach>(model);
            CoachRepo.AddCoach(data);

        }

        public static List<CoachModel> GetCoach()
        {
            var info = CoachRepo.GetCoach();
            var data = AutoMapper.Mapper.Map<List<Coach>, List<CoachModel>>(info);
            return data;
        }

        public static void CoachEdit(CoachInfoModel obj)
        {
            var data = AutoMapper.Mapper.Map<CoachInfoModel, Coach>(obj);
            CoachRepo.CoachEdit(data);
        }

        public static CoachInfoModel GetCoach(int id)
        {
            var data = CoachRepo.GetCoach(id);
            var p = AutoMapper.Mapper.Map<Coach, CoachInfoModel>(data);
            return p;
        }

        public static void CoachDelete(int id)
        {
            CoachRepo.CoachDelete(id);
        }

        public static List<CoachInfoModel> GetCoachDetails()
        {
            var info = CoachRepo.GetCoach();
            var data = AutoMapper.Mapper.Map<List<Coach>, List<CoachInfoModel>>(info);
            return data;
        }
    }
}
