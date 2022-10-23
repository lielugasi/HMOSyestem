using HMO.BL.BE;
using HMO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.BL
{
    public class PatientBL
    {
        public PatientDAL patientDal = new PatientDAL();
       // public VaccineDAL vaccineDal = new VaccineDAL();
        public bool AddNewPatient(Patient patient)
        {
            bool result = true;
            //throw new NotImplementedException();
            if (patient.RecoveryDate > patient.PositiveDate)
                patientDal.Add(patient);
            else
                result = false;
            return result;
        }

        public IEnumerable<Patient> GetPatients()
        {

            return patientDal.GetPatients();

        }
        
        public void Edit(Patient patient)
        {
            //throw new NotImplementedException();

            patientDal.Edit(patient);
        }
        public void Delete(int id)
        {
            //throw new NotImplementedException();

            patientDal.Delete(id);
        }
    }
}
