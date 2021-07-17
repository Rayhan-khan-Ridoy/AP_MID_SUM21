using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DEPARTMENT_REPO
    {
         static SMSEntities context;
         static DEPARTMENT_REPO()
        {

            context = new SMSEntities();
        }
        public static List<string> GetDEPARTMENTNAMES()
        {
            var data = context.DEPARTMENTs.Select(e => e.NAME).ToList();
            return data;
        }

        public static List<DEPARTMENT> GetDEPARTMENT()
        {
            return context.DEPARTMENTs.ToList();
        }
        public static void AddDEPARTMENT(DEPARTMENT d)
        {
            context.DEPARTMENTs.Add(d);
            context.SaveChanges();
        }
    }
}
