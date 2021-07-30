using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class STUDENTREPO
    {
        static SMSEntities context;
        static STUDENTREPO()
        {
            context = new SMSEntities();
        }
        public static void AddStudent(STUDENT model)
        {
            context.STUDENTS.Add(model);
            context.SaveChanges();
        }
        public static List<STUDENT> GetAllStudents()
        {
            var data = context.STUDENTS.ToList();
            return data;
        }
        public static STUDENT GetStudent(int id)
        {
            var data = context.STUDENTS.FirstOrDefault(e => e.ID == id);
            return data;
        }

        public static List<string> GetStudentNames()
        {
            var data = context.STUDENTS.Select(e => e.NAME).ToList();
            return data;
        }
    }
}
