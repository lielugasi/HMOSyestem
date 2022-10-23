using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.BL.BE
{
    public class Vaccine
    {
        public int Id { set; get; }
        public DateTime VacDate { set; get; }
        public string Producer { get; set; }
        
        //public int PatientId { set; get; }
        //public Patient Patient { set; get; }
        //public Vaccine(int id, DateTime date, string producer)
        //{
        //    Id = id;
        //    VacDate = date;
        //    Producer = producer;
        //}
        //public Vaccine()
        //{

        //}
        //public Vaccine(Vaccine vaccine)
        //{
        //    Id = vaccine.Id;
        //    VacDate = vaccine.VacDate;
        //    Producer = vaccine.Producer;
        //}
    }
}
