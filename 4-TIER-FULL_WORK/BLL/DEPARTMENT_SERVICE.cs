using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
namespace BLL
{
    public class DEPARTMENT_SERVICE
    {
      

        public static List<string> GetDEPARTMENTNAMES()
        {
            return DEPARTMENT_REPO.GetDEPARTMENTNAMES();
        }
        public static List<DEPARTMENTMODEL> GetDEPARTMENT()
        {
            var Departments = DEPARTMENT_REPO.GetDEPARTMENT();

            List<DEPARTMENTMODEL> data = new List<DEPARTMENTMODEL>();

            foreach (var d in Departments)
            {
                var dm = new DEPARTMENTMODEL()
                {
                    ID = d.ID,
                    NAME = d.NAME
                };
                data.Add(dm);
            }
            return data;
        }

        public static void AddDEPARTMENT(DEPARTMENTMODEL dept)
        {
            var d = new DEPARTMENT()
            {
                ID = dept.ID,
                NAME = dept.NAME
            };
            DEPARTMENT_REPO.AddDEPARTMENT(d);
        }
    }
}
