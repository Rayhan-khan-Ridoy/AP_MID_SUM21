using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FixtureService
    {
        public static void AddFixture(AddFixtureModel model)
        {
            var data = AutoMapper.Mapper.Map<AddFixtureModel, Fixture>(model);
            FixtureRepo.AddFixture(data);
        }

        public static List<FixtureModel> GetFixture()
        {
            var data = FixtureRepo.GetFixture();
            var info = AutoMapper.Mapper.Map<List<Fixture>, List<FixtureModel>>(data);
            return info;
        }

        public static void FixtureEdit(FixtureModel obj)
        {
            var data = AutoMapper.Mapper.Map<FixtureModel, Fixture>(obj);
            FixtureRepo.FixtureEdit(data);
        }

        public static FixtureModel GetFixtures(int id)
        {
            var data = FixtureRepo.GetFixtures(id);
            var p = AutoMapper.Mapper.Map<Fixture, FixtureModel>(data);
            return p;
        }

        public static void FixtureDelete(int id)
        {
            FixtureRepo.FixtureDelete(id);
        }
    }
}
