using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.BL.BE
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base()
        {

        }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Vaccine> VaccineDates { get; set; }
    }
}
