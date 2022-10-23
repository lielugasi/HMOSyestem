using HMO.BL;
using HMO.BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMOSystem.Models
{
    public class VaccineModel
    {
        public VaccineBL bl = new VaccineBL();
        internal void AddVaccine(int id, DateTime vacDate, string producer)
        {
            //throw new NotImplementedException();
            Vaccine vaccineDate = new Vaccine()
            {
                Id = id,
                VacDate = vacDate,
                Producer = producer
            };
            try
            {
                bl.AddVaccine(vaccineDate);
            }
            catch (Exception e) { throw new Exception(e.Message); }

        }
        public IEnumerable<Vaccine> GetVaccines()
        {

            return bl.GetVaccines();
        }


    }
}