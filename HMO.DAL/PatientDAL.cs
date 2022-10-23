using HMO.BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.DAL
{
    public class PatientDAL
    {
        public void Add(Patient patient)
        {
            try
            {
                using (var ctx = new MyDbContext())
                {
                    ctx.Patients.Add(patient);
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
        

        public void Edit(Patient patient)
        {
            //throw new NotImplementedException();
            try
            {
                using (var ctx = new MyDbContext())
                {
                    Patient EditedPatiened = ctx.Patients.First(p => p.Id == patient.Id);
                    EditedPatiened.FirstName = patient.FirstName;
                    EditedPatiened.LastName = patient.LastName;
                    EditedPatiened.Addres = patient.Addres;
                    EditedPatiened.Birthday = patient.Birthday;
                    EditedPatiened.Telephone = patient.Telephone;
                    EditedPatiened.PhoneNumber = patient.PhoneNumber;
                    EditedPatiened.VaccineDates = patient.VaccineDates;
                    EditedPatiened.PositiveDate = patient.PositiveDate;
                    EditedPatiened.RecoveryDate = patient.RecoveryDate;
                    ctx.SaveChanges();
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public void Delete(int id)
        {
            //throw new NotImplementedException();
            using (var ctx = new MyDbContext())
            {
                try
                {
                    Patient patient = ctx.Patients.Find(id);
                    ctx.Patients.Remove(patient);
                    ctx.SaveChanges();
                }
                catch (Exception e) { throw new Exception(e.Message); }
            }
        }
    }
}
