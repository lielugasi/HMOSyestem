using HMO.BL;
using HMO.BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMOSystem.Models
{
    public class PatientModel
    {
        PatientBL patientBL = new PatientBL();
        VaccineBL bl = new VaccineBL();
        public void AddPatient(int id, string fName, string lName, string addres, DateTime Birthday, int telephone,
                              int phoneNumber, List<Vaccine> vacDates, DateTime positive, DateTime recovery)
        {
            Patient patient = new Patient()
            {
                Id = id,
                FirstName = fName,
                LastName = lName,
                Addres = addres,
                Birthday = Birthday,
                PhoneNumber = phoneNumber,
                Telephone = telephone,
                VaccineDates = vacDates,
                PositiveDate = positive,
                RecoveryDate = recovery

            };
            try
            {
                patientBL.AddNewPatient(patient);
            }
            catch (Exception e) { throw new Exception(e.Message); }

        }

        public IEnumerable<Patient> GetPatients()
        {

            return patientBL.GetPatients();
        }
        

        internal void EditPatient(Patient patient)
        {

            patientBL.Edit(patient);
        }
        public void Delete(int id)
        {
            //throw new NotImplementedException();

            patientBL.Delete(id);
        }
    }
}