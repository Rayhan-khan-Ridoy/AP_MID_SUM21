using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginService
    {

        public static bool loginPlayer(int id, string pass)
        {
            return LoginRepo.loginPlayer(id, pass);
        }

        public static bool loginAdmin(int id, string pass)
        {
            return LoginRepo.loginAdmin(id, pass);
        }

        public static bool loginCoach(int id, string pass)
        {
            return LoginRepo.loginCoach(id, pass);
        }

        public static bool loginPhysio(int id, string pass)
        {
            return LoginRepo.loginPhysio(id, pass);
        }

        public static bool PlayerLogin(LogInModel obj)
        {
            var info = AutoMapper.Mapper.Map<LogInModel, LogIn>(obj);
            var data = LoginRepo.PlayerLogin(info);
            return data;
        }

        public static bool AdminLogin(LogInModel obj)
        {
            var info = AutoMapper.Mapper.Map<LogInModel, LogIn>(obj);
            var data = LoginRepo.AdminLogin(info);
            return data;
        }

        public static bool CoachLogin(LogInModel obj)
        {
            var info = AutoMapper.Mapper.Map<LogInModel, LogIn>(obj);
            var data = LoginRepo.CoachLogin(info);
            return data;
        }

        public static bool PhysioLogin(LogInModel obj)
        {
            var info = AutoMapper.Mapper.Map<LogInModel, LogIn>(obj);
            var data = LoginRepo.PhysioLogin(info);
            return data;
        }
    }
}
