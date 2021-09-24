using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FormationService
    {
        public static void AddFormation(FormationModel model)
        {
            var data = AutoMapper.Mapper.Map<FormationModel, Formation>(model);
            FormationRepo.AddFormation(data);
        }

        public static List<FormationModel> GetFormation()
        {
            var data = FormationRepo.GetFormation();
            var info = AutoMapper.Mapper.Map<List<Formation>, List<FormationModel>>(data);
            return info;
        }

        public static void FormationEdit(FormationModel obj)
        {
            var data = AutoMapper.Mapper.Map<FormationModel, Formation>(obj);
            FormationRepo.FormationEdit(data);
        }

        public static FormationModel GetFormationDetails(int id)
        {
            var info = FormationRepo.GetFormationDetails(id);
            var data = AutoMapper.Mapper.Map<Formation, FormationModel>(info);
            return data;
        }

        public static void FormationDelete(int id)
        {
            FormationRepo.FormationDelete(id);
        }
    }
}
