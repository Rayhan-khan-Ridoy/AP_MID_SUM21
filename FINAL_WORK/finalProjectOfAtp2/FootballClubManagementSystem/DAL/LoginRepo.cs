using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginRepo
    {
        static FCMSEntities context;
        static LoginRepo()
        {
            context = new FCMSEntities();
        }
        public static bool loginPlayer(int id, string pass)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == id && uname.Password == pass && uname.Type == 0);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }

        public static bool loginPhysio(int id, string pass)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == id && uname.Password == pass && uname.Type == 2);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }

        public static bool PlayerLogin(LogIn obj)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == obj.Id && uname.Password == obj.Password && uname.Type == 0);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }

        public static bool CoachLogin(LogIn obj)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == obj.Id && uname.Password == obj.Password && uname.Type == 3);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }

        public static bool PhysioLogin(LogIn obj)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == obj.Id && uname.Password == obj.Password && uname.Type == 2);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }

        public static bool AdminLogin(LogIn obj)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == obj.Id && uname.Password == obj.Password && uname.Type == 1);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }

        public static bool loginCoach(int id, string pass)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == id && uname.Password == pass && uname.Type == 3);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }

        public static bool loginAdmin(int id, string pass)
        {
            var match_value = context.LogIns.FirstOrDefault(uname => uname.Id == id && uname.Password == pass && uname.Type == 1);
            bool data;
            if (match_value != null)
            {
                data = true;
            }
            else
                data = false;
            return data;
        }
    }
}
