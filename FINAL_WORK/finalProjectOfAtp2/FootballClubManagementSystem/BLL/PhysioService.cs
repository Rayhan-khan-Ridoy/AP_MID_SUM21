using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhysioService
    {
        public static void AddPhysio(AddPhysioModel model)
        {
            var data = AutoMapper.Mapper.Map<AddPhysioModel, Physio>(model);
            PhysioRepo.AddPhysio(data);
        }

        public static List<PhysioInfoModel> GetPhysio()
        {
            var info = PhysioRepo.GetPhysio();
            var data = AutoMapper.Mapper.Map<List<Physio>, List<PhysioInfoModel>>(info);
            return data;
        }

        public static void PhysioEdit(PhysioModel obj)
        {
            var data = AutoMapper.Mapper.Map<PhysioModel, Physio>(obj);
            PhysioRepo.PhysioEdit(data);
        }

        public static PhysioInfoModel GetPhysioInfo(int id)
        {
            var data = PhysioRepo.GetPhysioInfo(id);
            var p = AutoMapper.Mapper.Map<Physio, PhysioInfoModel>(data);
            return p;
        }

        public static void PhysioDelete(int id)
        {
            PhysioRepo.PhysioDelete(id);
        }

        public static List<PhysioInfoModel> GetPhysioDetails()
        {
            var info = PhysioRepo.GetPhysioDetails();
            var data = AutoMapper.Mapper.Map<List<Physio>, List<PhysioInfoModel>>(info);
            return data;
        }
    }
}
