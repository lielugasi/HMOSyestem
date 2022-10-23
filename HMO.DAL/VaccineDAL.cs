using HMO.BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.DAL
{
    public class VaccineDAL
    {
        

        public void AddVaccine(Vaccine vaccineDate)
        {
            //throw new NotImplementedException();
            try
            {
                using (var ctx = new MyDbContext())
                {
                    ctx.VaccineDates.Add(vaccineDate);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public IEnumerable<Patient> GetPatients()
        {
            List<Patient> Result = new List<Patient>();
            try
            {
                using (var ctx = new MyDbContext())
                {
                    foreach (var p in ctx.Patients)
                    {
                        Result.Add(p);
                    }
                }
                return Result;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public IEnumerable<Vaccine> GetVaccines()
        {

            List<Vaccine> Result = new List<Vaccine>();
            try
            {
                using (var ctx = new MyDbContext())
                {
                    foreach (var v in ctx.VaccineDates)
                    {
                        Result.Add(v);
                    }
                }
                return Result;
            }

            catch (Exception e) { throw new Exception(e.Message); }
        }
        

    }
}
