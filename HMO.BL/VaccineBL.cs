using HMO.BL.BE;
using HMO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.BL
{
    public class VaccineBL
    {
        public VaccineDAL vaccineDal = new VaccineDAL();
        public bool AddVaccine(Vaccine vaccineDate)
        {
            //throw new NotImplementedException();
            bool result = true;
            //throw new NotImplementedException();
            if (vaccineDal.GetVaccines().Count() < 3)
                vaccineDal.AddVaccine(vaccineDate);
            else
                result = false;
            return result;
        }

        public IEnumerable<Vaccine> GetVaccines()
        {
             return vaccineDal.GetVaccines();
        }
    }
}
