using BEL;
using DAL;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AutoMapperConfig
{
    public class AutoMapperSettings:Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<Player, PlayerModel>();
            CreateMap<PlayerModel, Player>();
            CreateMap<AddPlayerModel, Player>();
            CreateMap<PlayerModel, Fitness>();
            CreateMap<PlayerModel, Salary>();
            CreateMap<Salary, SalaryInfoModel>();
            CreateMap<PlayerModel, Performance>();
            CreateMap<AddSalaryModel, Salary>();
            CreateMap<AddPerformanceModel, Performance>();
            CreateMap<AddFitnessModel, Fitness>();
            CreateMap<EditPlayerModel, Player>();
            CreateMap <EditSalaryModel, Salary>();
            CreateMap <EditFitnessModel, Fitness>();
            CreateMap <EditPerformanceModel, Performance>();
            CreateMap<PlayerInfoModel, Fitness>();
            CreateMap<PlayerInfoModel, Performance>();
            CreateMap<Fitness, FitnessDetailsModel>();
            CreateMap<Performance, PerformanceModel > ();
            CreateMap<AddCoachModel, Coach>();
            CreateMap<Coach, CoachModel>();
            CreateMap<CoachModel, Coach>();
            CreateMap<AddPhysioModel, Physio>();
            CreateMap<Physio, PhysioModel>();
            CreateMap<PhysioModel, Physio>();
            CreateMap<AddFixtureModel, Fixture>();
            CreateMap<Fixture, FixtureModel>();
            CreateMap<FixtureModel, Fixture>();
            CreateMap<FormationModel, Formation>();
            CreateMap<Formation, FormationModel>();
            CreateMap<Physio, PhysioInfoModel>();
            CreateMap<Coach, CoachInfoModel>();
            CreateMap<CoachInfoModel, Coach>();
            CreateMap<Coach, CoachModel>();
            CreateMap<Formation, FormationModel>();
            CreateMap<LogInModel, LogIn>();

        }
    }
}
